#!/usr/bin/env node
const { execSync } = require("child_process");
const { globSync } = require("glob");
const path = require("path");

const TAILWIND_BIN = path.join("node_modules", ".bin", "tailwindcss");

function parseArgs(argv) {
  const args = {};
  for (let i = 0; i < argv.length; i++) {
    if ((argv[i] === "--input" || argv[i] === "-i") && argv[i + 1]) {
      args.input = argv[++i];
    } else if ((argv[i] === "--output" || argv[i] === "-o") && argv[i + 1]) {
      args.output = argv[++i];
    }
  }
  if (!args.input || !args.output) {
    console.error("Usage: node build-scoped-css.js --input <path> --output <path>");
    process.exit(1);
  }
  return args;
}

function compile(input, output) {
  execSync(`"${TAILWIND_BIN}" -i "${input}" -o "${output}" --minify`, { stdio: "inherit" });
}

const { input, output } = parseArgs(process.argv.slice(2));

compile(input, output);

const IGNORE = ["node_modules/**", "bin/**", "obj/**"];

const componentFiles = globSync("**/*.razor.pcss", { ignore: IGNORE });

for (const file of componentFiles) {
  const razorFileName = path.basename(file, ".pcss");
  const matches = globSync(`**/${razorFileName}`, { ignore: IGNORE });

  if (matches.length === 0) {
    console.error(`No component found for ${file}: expected a matching ${razorFileName} somewhere in the project.`);
    process.exit(1);
  }
  if (matches.length > 1) {
    console.error(`Ambiguous component for ${file}: multiple matches found for ${razorFileName}:\n${matches.join("\n")}`);
    process.exit(1);
  }

  const outputFile = path.join(path.dirname(matches[0]), razorFileName + ".css");
  compile(file, outputFile);
}

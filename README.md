# 📄 Resume in Blazor

A modern, responsive web resume built with **Blazor WebAssembly**, showcasing both my professional experience and technical skills in web development.

## 🌟 About This Project

This project serves a dual purpose:
- **Professional Showcase**: A clean, interactive web version of my resume
- **Technical Demonstration**: Showcasing modern web development practices and technologies

The design is inspired by the [Reddit-famous "Sheets Resume,"](https://www.reddit.com/r/jobs/comments/7y8k6p/im_an_exrecruiter_for_some_of_the_top_companies/?sort=new) from the founder of a sustainable bedding brand (Sheets & Giggles), reimagined with modern web technologies and responsive design principles.

## 🛠️ Tech Stack

- **Frontend Framework**: Blazor WebAssembly (.NET 9)
- **Styling**: Tailwind CSS v4 with a per-component scoped-CSS build pipeline
- **Architecture**: Feature/section components over a typed DTO model, behind an `IResumeSource` data abstraction
- **Responsive Design**: Mobile-first approach
- **Hosting**: GitHub Pages
- **CI/CD**: GitHub Actions

## 🏗️ Architecture & Design Patterns

### Component Structure
```
Components/
├── Features/        # Top-level feature composition (Resume)
├── Sections/        # Resume sections (Introduction, Jobs, Projects, …)
├── IconLinks/       # Contact / reference link icons (Email, Github, Website, …)
├── Layouts/         # App layout
└── *.razor          # Shared leaf components (MonthYearRange, Reference, …)
```

Components render a strongly-typed DTO model (`Models/Dtos/`), with cross-cutting
behaviors expressed as interfaces (`Models/Interfaces/` — `IHideable`,
`IPrintBreakable`).

### Resume data (`IResumeSource`)
Resume content is loaded through the `IResumeSource` abstraction
(`Services/IResumeSource.cs`), so components hold no knowledge of where the data
comes from. The current implementation, `StaticJsonResumeSource`, reads a static
JSON file shipped in `wwwroot/json/` (`MockDataNL.json` by default — the path is
a `const` in `StaticJsonResumeSource.cs`). Swapping in another source (e.g. a
resume API) is a single DI registration change in `Program.cs`.

To use your own data, replace `wwwroot/json/MockDataNL.json` with a document of
the same shape as `Models/Dtos/ResumeData.cs`.

### Scoped CSS pipeline
Global styles live in `Styles/MainStyles.css` (Tailwind v4 theme, element rules,
print styles). Each component may carry a `*.razor.pcss` file that is compiled to
a matching `*.razor.css` by `build-scoped-css.js`. The build runs automatically
before `dotnet build` (MSBuild `BuildScopedCss` target) and in CI; run it
manually with `npm run build:css`.

### Key Features
- **Component-Based Architecture**: Reusable, maintainable components
- **Responsive Design**: Optimized for all screen sizes
- **Modern CSS**: Tailwind CSS for utility-first styling
- **Type Safety**: Full C# type checking throughout
- **Fast Loading**: WebAssembly for near-native performance

## 🚀 Getting Started

### Prerequisites
- .NET 9 SDK
- Node.js 20+
- Git

### Local Development

1. **Clone the repository**
   ```bash
   git clone https://github.com/mikoflip/ResumeInBlazor.git
   cd ResumeInBlazor
   ```

2. **Install dependencies**
   ```bash
   # .NET dependencies
   dotnet restore
   
   # Node.js dependencies (for Tailwind CSS)
   npm install
   ```

3. **Run the application**
   ```bash
   dotnet watch run
   ```
   Scoped CSS is compiled automatically before each build via the MSBuild
   `BuildScopedCss` target. To format + rebuild CSS and run in one step, use
   `npm run dev`; to rebuild CSS only, use `npm run build:css`.

4. **Open in browser**
   Navigate to `http://localhost:5100` (or `https://localhost:7100` with the `https` profile)

### Development with DevContainer

For a consistent development environment:

1. Open in VS Code
2. Click "Reopen in Container" when prompted
3. The devcontainer will automatically:
   - Install all dependencies
   - Configure development tools
   - Set up the development environment

## 📱 Responsive Design


Layout bounds and breakpoints are defined in the Tailwind `@theme` block in
`Styles/MainStyles.css`:

- **Body min-width**: `240px` (`--container-body-min`)
- **Main content max-width**: `768px` (`--container-main-max`)

**Custom breakpoints** (the default Tailwind scale is disabled via `--breakpoint-*: initial`):
- **`b1`**: `480px` (phones → larger phones)
- **`b2`**: `640px` (tablets)
- **`b3`**: `768px` (small laptops and up)

## 🎨 Styling Philosophy

- **Utility-First**: Tailwind CSS for rapid development
- **Mobile-First**: Responsive design starting from mobile
- **Accessibility**: WCAG 2.1 compliant design patterns
- **Clean Typography**: Professional, readable font choices

## 📂 Project Structure

```
├── Components/
│   ├── Features/      # Top-level feature composition
│   ├── Sections/      # Resume sections
│   ├── IconLinks/     # Contact / reference link icons
│   ├── Layouts/       # App layout
│   └── *.razor        # Shared leaf components (+ *.razor.pcss scoped styles)
├── Models/
│   ├── Dtos/          # Resume data model
│   └── Interfaces/    # Cross-cutting component behaviors
├── Services/          # IResumeSource abstraction + StaticJsonResumeSource
├── Pages/             # Routable pages (Home)
├── Styles/            # Global Tailwind entry (MainStyles.css)
├── wwwroot/           # Static assets (incl. json/ resume data)
├── build-scoped-css.js  # Per-component pcss → css compiler
├── .github/           # GitHub Actions workflows
└── .devcontainer/     # Development container config
```

## 🔧 Build & Deployment

### Local Build
```bash
   dotnet publish -c Release -o publish
```

### Automated Deployment
- **GitHub Actions** builds and deploys to GitHub Pages on every push to `main`
- Manual runs are supported via `workflow_dispatch` from the Actions tab
- **Tailwind CSS** is compiled during the build process
- **Optimized output** for production performance

## 🤝 Contributing

This is a personal resume project, but if you find bugs or have suggestions:

1. Fork the repository
2. Create a feature branch
3. Submit a pull request

## 📄 License

**Code**: This project is open source and available under the [MIT License](LICENSE).

**Personal Content**: The resume content and personal information are proprietary. If you fork this project, please replace all personal data with your own information.

---

*Built with ❤️ using Blazor WebAssembly and modern web technologies*
# 📄 Resume in Blazor

A modern, responsive web resume built with **Blazor WebAssembly**, showcasing both my professional experience and technical skills in web development.

## 🌟 About This Project

This project serves a dual purpose:
- **Professional Showcase**: A clean, interactive web version of my resume
- **Technical Demonstration**: Showcasing modern web development practices and technologies

The design is inspired by the [Reddit-famous "Sheets Resume,"](https://www.reddit.com/r/jobs/comments/7y8k6p/im_an_exrecruiter_for_some_of_the_top_companies/?sort=new) from the founder of a sustainable bedding brand (Sheets & Giggles), reimagined with modern web technologies and responsive design principles.

## 🛠️ Tech Stack

- **Frontend Framework**: Blazor WebAssembly (.NET 9)
- **Styling**: Tailwind CSS
- **Architecture**: Atomic Design principles
- **Responsive Design**: Mobile-first approach
- **Hosting**: GitHub Pages
- **CI/CD**: GitHub Actions

## 🏗️ Architecture & Design Patterns

### Atomic Design Structure
```
Components/
├── Atoms/           # Basic building blocks (buttons, inputs, text)
├── Molecules/       # Simple combinations of atoms
└── Organisms/       # Complex UI sections (header, sections)
```

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

3. **Build Tailwind CSS**
   ```bash
   npm run build:css
   ```

4. **Run the application**
   ```bash
   dotnet watch run
   ```

5. **Open in browser**
   Navigate to `https://localhost:5001`

### Development with DevContainer

For a consistent development environment:

1. Open in VS Code
2. Click "Reopen in Container" when prompted
3. The devcontainer will automatically:
   - Install all dependencies
   - Configure development tools
   - Set up the development environment

## 📱 Responsive Design


**Key breakpoints:**
- **Extra Small**: 50px - 240px (smartwatches, narrow mobile)
- **Mobile**: 240px - 480px (phones)
- **Tablet**: 480px - 768px (tablets, small laptops)
- **Desktop**: 768px+ (laptops, desktops, ultrawide)

## 🎨 Styling Philosophy

- **Utility-First**: Tailwind CSS for rapid development
- **Mobile-First**: Responsive design starting from mobile
- **Accessibility**: WCAG 2.1 compliant design patterns
- **Clean Typography**: Professional, readable font choices

## 📂 Project Structure

```
├── Components/
│   ├── Atoms/         # Basic UI elements
│   ├── Molecules/     # Component combinations
│   └── Organisms/     # Page sections
├── Models/            # Data models and ViewModels
├── Views/             # Page components
├── wwwroot/           # Static assets
├── .github/           # GitHub Actions workflows
└── .devcontainer/     # Development container config
```

## 🔧 Build & Deployment

### Local Build
```bash
   dotnet publish -c Release -o publish
```

### Automated Deployment
- **GitHub Actions** automatically builds and deploys to GitHub Pages
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
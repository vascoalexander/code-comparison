# Code-Comparison

**Description:**
This project contains a collection of simple coding exercises solved in different programming languages. The goal is to compare the syntax and programming concepts of these languages.

[Exercises (ENG)](./Exercises_EN.md)  
[Exercises (DE)](./Exercises_DE.md)


## Usage

### Setting Up the C# Environment

1. **Install .NET SDK**: Ensure that the .NET SDK is installed. You can download it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

2. **Create a Project**:
   ```sh
   cd CodeComparison-CSharp-Python/CSharp
   dotnet new console -n <ProjectName>
   ```

3. **Run the Program**:
   ```sh
   dotnet run --project <ProjectName>
   ```

### Setting Up the Python Environment

1. **Install Python**: Ensure that Python is installed. You can download it from [python.org](https://www.python.org/).

2. **Create a Virtual Environment**:
   ```sh
   cd CodeComparison-CSharp-Python/Python
   python -m venv venv
   ```

3. **Activate the Virtual Environment**:
   - **Windows**:
     ```sh
     .\venv\Scripts\Activate
     ```
   - **macOS/Linux**:
     ```sh
     source venv/bin/activate
     ```

4. **Run the Program**:
   ```sh
   python <FileName>.py
   ```
### Setting Up the COBOL Environment

1. **Install VS Code**
2. **Install VS Code Extension:** IBM Z Open Editor
3. **Install a COBOL Compiler**
- **Windows**:
   1. Download and Install MSYS2: https://www.msys2.org/
   2. Open MSYS2 Terminal and Execute:
   ```shell
   pacman -Syu
   pacman -S mingw-w64-x86_64-gnucobol
   ```
   3. Add to PATH: C:\msys64\mingw64\bin
   4. Set Environment Variable in Powershell (sets the env var permanently):
   ```shell
   [System.Environment]::SetEnvironmentVariable('COB_CONFIG_DIR', 'C:\msys64\mingw64\share\gnucobol\config', 'User')
   ```
- **Linux**
   ```shell
   # Ubuntu
   sudo apt update && sudo apt install gnucobol
   # Fedora/RHEL
   sudo dnf install gnucobol
   ```
4. **Compiler testen**
   ```shell
   cobc --version
   ```
5. **Test Program**
   ```cobol
   IDENTIFICATION DIVISION.
         PROGRAM-ID. HelloWorld.
         
         PROCEDURE DIVISION.
            DISPLAY "Hello, COBOL World!".
            STOP RUN.
   ```
6. **Compile and Run**  
- **Windows:**
   ```shell
   cobc -x hello.cob -o hello.exe
   hello.exe
   ```
- **Linux**
   ```shell
   cobc -x -free hello.cob -o hello
   ./hello
   ```

## General Project Structure

```mathematica
code-comparison/
│
├── programming-language/
│   ├── HelloWorld/
│   │   └── HelloWorld.py
│   ├── Variables/
│   │   └── Exercise_1-1-1.py
│   ├── Conditionals/
│   │   └── Exercise_1-2-1.py
│   ├── Loops/
│   │   └── Exercise_1-3-1.py
│   ├── Functions/
│   │   └── Exercise_1-4-1.py
│   └── DataStructures/
│       ├── Arrays/
│       │   └── Exercise_2-1-1.py
│       ├── Lists/
│       │   └── Exercise_2-2-1.py
│       └── Maps/
│           └── Exercise_2-3-1.py
│ 
├── Exercises_DE.md
├── Exercises_EN.md
└── README.md
```
## Contributing

You are welcome to contribute to this project! If you want to add new Exercises, another Programming Language or any other
improvement open a Pull Request.

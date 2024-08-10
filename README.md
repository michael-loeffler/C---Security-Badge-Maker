
# C# Security Badge Maker
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Description

The Security Badge Maker is a command-line application created with C# that will allow users to quickly generate security badges for new employees after inputting employee information. This application serves as a quick and user-friendly way to generate many security badges with minimal effort.

Some of the key learning points include:

* Declaring and using statically typed variables, as well as dictionaries, arrays, and lists
* Interacting with users through the command-line interface with methods like ReadLine() and WriteLine()
* The purpose of a "null coalescing operator" (??)
* Organizing the program according to the "single-responsibility principle" of software design
* Namespace scoping
* Protection levels and access modifiers (public, private, static, etc.)
* Managing memory with the "using" keyword
* Creating files with StreamWriter
* SkiaSharp tools such as SKBitmap, SKData, SKCanvas, SKImage, and SKPaint
* Requesting data from an API and converting the JSON response to C# data types using Newtonsoft.Json

## Table of Contents
        
- [Installation](#installation)
- [Usage](#usage)
- [Credits](#credits)
- [License](#license)
- [Contributing](#contributing)
 
## Installation

1. Install .NET Core SDK
    - [Download Version 6.0 or greater of .NET](https://dotnet.microsoft.com/download/dotnet)
2. Clone this repo
   ```sh
   git clone https://github.com/michael-loeffler/CSharp-Security-Badge-Maker
   ```
3. Install the dependencies included in the CatWorx.BadgeMaker.csproj file
   ```sh
   dotnet add package (dependency) --version (version number)
   ```
4. Start the application by using the following command in the command-line
   ```sh
   dotnet run
   ```
## Usage

The Security Badge Maker functions as a command-line application. After following the installation instructions above and using the command "dotnet run", whenever users want to generate security badges for employees, they have two options: 1) inputting the information manually for their own employees, or 2) using the Random User Generator API to generate some sample badges to see what the result will look like. Option 2 doesn't require any user input. After selecting that option, the application will automatically generate 10 sample badges based on the response from the Random User Generator API and the application ends. If the user selects Option 1, they will be prompted to input basic information for as many employees for which they would like badges generated. The information requested by the application is first name, last name, ID number, and a URL to a photo of the employee. This will repeat as many times as required by the user, and can be exited by leaving the first name field empty after the last employee has been supplied. The application will end and generate the badges. Finally, no matter which option is selected by the user, the employee information is printed to the console, and also captured in a CSV file. 

### --- Video demonstration of application's functionality ---

Please review the [demonstration video](https://drive.google.com/file/d/12jQorTxnfoHV4q-s7QRMQ7tRWxJNaI8O/view?usp=sharing) to see how the app functions and experience the user perspective. Additionally, sample badges created using the application can be found in the ["sampleBadges"](https://github.com/michael-loeffler/CSharp-Security-Badge-Maker/tree/main/sampleBadges) folder in this repository.

## Credits
Some code blocks were supplied from EDX Coding Bootcamp continuation coursework as this was a learning exercise.

Packages used:
  - .NET Core SDK
  - dotnet
  - SkiaSharp
  - Place Kitten
  - Random User Generator API
  - Newtonsoft.Json

## License
    
Covered under the MIT License. For more details and to view the license in full, please visit the [MIT License Webpage](https://choosealicense.com/licenses/mit/).

## Contributing
    
If you have a suggestion for improvement, please fork the repo and create a pull request. You can also open an issue and tag it for "enhancement".
1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/featureName`)
3. Commit your Changes (`git commit -m 'adds featureName'`)
4. Push to the Branch (`git push origin feature/featureName`)
5. Open a Pull Request

# DevEnglishTutor

![GitHub repo size](https://img.shields.io/github/repo-size/Pedrolustosa/DevEnglishTutor)
![GitHub contributors](https://img.shields.io/github/contributors/Pedrolustosa/DevEnglishTutor)
![GitHub stars](https://img.shields.io/github/stars/Pedrolustosa/DevEnglishTutor?style=social)
![GitHub forks](https://img.shields.io/github/forks/Pedrolustosa/DevEnglishTutor?style=social)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
![Project Views](https://komarev.com/ghpvc/?username=Pedrolustosa&label=Project%20Views&color=brightgreen)

**DevEnglishTutor** is an application developed in C#/.NET 7 aimed at correcting English sentences, providing detailed feedback on grammatical and semantic aspects. The application utilizes the ChatGPT 3.5 interface to analyze sentences and provide accurate and explanatory corrections.

## Overview

**DevEnglishTutor** was created to help users improve their English language skills by offering detailed corrections and explanations on the grammatical and semantic aspects of their sentences. Upon receiving a sentence as input, the application uses the ChatGPT 3.5 interface to analyze the sentence, identify potential errors, and provide correction suggestions, along with explanations for the proposed corrections.

## Architecture

The project follows the principles of clean architecture, dividing itself into several layers:

- **API**: Responsible for exposing HTTP endpoints for interaction with the system.
- **Application**: Application layer containing the business logic of the application.
- **Domain**: Contains the entities and business rules of the application's domain.
- **Infra**: Infrastructure layer that deals with technical details, such as database access and communication with external APIs.
- **Infra.IoC**: Layer responsible for configuring dependency injection and dependency resolution of the system.

## Technologies

- Programming Language: [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- Framework: [.NET 7](https://dotnet.microsoft.com/)
- ChatGPT Interface: [ChatGPT 3.5](https://openai.com/gpt)
- Architecture: [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

## Installation

1. Clone the repository: `git clone https://github.com/your-username/DevEnglishTutor.git`
2. Navigate to the project directory: `cd DevEnglishTutor`
3. Install dependencies: `dotnet restore`

## Usage

To use **DevEnglishTutor**, follow these steps:

1. Start the application.
2. Submit an English sentence to be corrected.
3. Review the correction suggestions and explanations provided by the application.
4. Apply the suggested corrections to improve your sentence.

## Contribution

You are welcome to contribute to the project by submitting pull requests, bug reports, or suggestions for improvements. Follow these guidelines:

- Fork the project.
- Create a branch for your feature (`git checkout -b feature/MyFeature`).
- Commit your changes (`git commit -am 'Adding a new feature'`).
- Push to the branch (`git push origin feature/MyFeature`).
- Create a new Pull Request.

## License

This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for more details.

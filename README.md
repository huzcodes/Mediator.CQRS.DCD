# CQRS API in Domain-Centric Design Architecture

This project demonstrates the implementation of a CQRS API in a domain-centric design architecture using .NET 8 and Mediator with request pipeline.

## Features

- **CQRS Implementation**: Separation of concerns between read and write operations.
- **Domain-Centric Design**: Focus on the domain model and business logic.
- **Mediator with Request Pipeline**: Utilizes Mediator pattern for handling requests and responses with a configurable pipeline.

## Benefits of Request Pipeline with Mediator

### Simplified Request Handling
The request pipeline simplifies the handling of requests by providing a unified entry point for processing.

### Centralized Middleware Dependencies
Using Mediator as a middleware dependency centralizes the handling of cross-cutting concerns such as logging, validation, and authorization, reducing code duplication.

### Improved Testability
The request pipeline and Mediator pattern enhance testability by allowing easy isolation of components for unit testing.

## YouTube Video

[![Watch the implementation with explanation video in Arabic](https://img.youtube.com/vi/YOUTUBE_VIDEO_ID_HERE/0.jpg)](https://www.youtube.com/watch?v=m3eYy22qNvs)

## Getting Started

1. Clone the repository.
2. Install .NET 8 SDK.
3. Build and run the project using `dotnet run`.


## Examples

*Figure 1: Request Pipeline with Mediator Diagram*
<img src="https://github.com/huzcodes/Mediator.CQRS.DCD/blob/main/Assets/Request Pipeline.png" align="center" style="width: 100%" />

*Figure 2: Mediator Middleware Central Dependency Diagram*
<img src="https://github.com/huzcodes/Mediator.CQRS.DCD/blob/main/Assets/Central Dependency on Mediator Pipeline .png" align="center" style="width: 100%" />

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature`)
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`)
5. Push to the branch (`git push origin feature`)
6. Create a new Pull Request.


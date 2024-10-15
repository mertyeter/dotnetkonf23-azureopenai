# Azure OpenAI Service for .NET Developers

This repository contains the source code and materials for the presentation titled "Azure OpenAI Service for .NET Developers" at Devnot Dotnet Konf 2023 on June 1st, 2023.

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Azure OpenAI Service](https://azure.microsoft.com/en-us/services/cognitive-services/openai-service/)

### Setup

1. Clone the repository:
    ```sh
    git clone https://github.com/mertyeter/dotnetkonf23-azureopenai.git

    cd dotnetkonf23-azureopenai
    ```

2. Restore the dependencies:
    ```sh
    dotnet restore src/BugHunter.csproj
    ```

3. Add your Azure OpenAI Service credentials to the user secrets:
    ```sh
    dotnet user-secrets set "AzureOpenAI:Endpoint" "<your-endpoint>"

    dotnet user-secrets set "AzureOpenAI:ApiKey" "<your-api-key>"
    
    dotnet user-secrets set "AzureOpenAI:DeploymentId" "<your-deployment-id>"
    ```

### Build and Run

To build the project, use the following command:
```sh
dotnet build
dotnet run
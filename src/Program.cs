using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var endpoint = new Uri(config["AzureOpenAI:Endpoint"]);
var credentials = new Azure.AzureKeyCredential(config["AzureOpenAI:ApiKey"]);

var openAIClient = new OpenAIClient(endpoint, credentials);

var prompt = """
//Find bugs in the code below

public static void BuggyMethod()
{
    int[] array = new int[5];
    for (int i = 0; i <= 5; i++)
    {
        array[i] = i;
    }
}

//
""";

Completions response = await openAIClient.GetCompletionsAsync(config["AzureOpenAI:DeploymentId"], new CompletionsOptions
{
    Prompts = { prompt },
    MaxTokens = 150, // The maximum number of tokens to generate. The max tokens number can't exceed the number of tokens supported by the model
    Temperature = 0f, // A value between 0 and 1 that lets you control how confident the model is when making predictions. Lower temperatures mean less randomness in completion output.
    StopSequences = { "/*", "*/" } // String values that indicate when the model should stop generating new text. Returned text won't contain the stop sequence.
});

Console.WriteLine(response.Choices[0].Text);

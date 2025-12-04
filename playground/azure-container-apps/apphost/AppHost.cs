#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;
using TerraformPlayground.AppHost.Azure;

var builder = DistributedApplication.CreateBuilder(args);

// Parameters
var subscriptionIdParameter = builder.AddParameter("azure-subscription-id");

// Azure Container App Environment with Terraform
// This auto-provisions: ACR, Log Analytics, Managed Identity, Role Assignment, and Container App Environment
// using a two-stage Terraform deployment (registry state separate from environment state)
builder.AddTerraformAzureContainerAppEnvironment("azure")
    .WithSubscriptionId(subscriptionIdParameter)
    .WithLocation("westus2")
    .WithBackend("local");

// Frontend Vite app
var frontend = builder.AddViteApp("frontend", "../frontend");

// YARP reverse proxy - automatically published as Azure Container App
builder.AddYarp("app")
    .WithConfiguration(c =>
    {
        if (builder.ExecutionContext.IsRunMode)
        {
            c.AddRoute("{**catch-all}", frontend);
        }
    })
    .WithExternalHttpEndpoints()
    .PublishWithStaticFiles(frontend)
    .PublishAsTerraformContainerApp((infra, app) =>
    {
        // Example: Add a custom environment variable
        // The container app is already configured by the auto-generation,
        // this just adds additional customizations

        // Access the template and container via the Index extension method
        // Note: The template and container blocks are created during auto-generation
        // For more complex customizations, you may want to rebuild the entire app

        // Simple customization example - add tags
        app.Tags ??= new();
        app.Tags["CustomTag"] = "MyValue";
    });

builder.Build().Run();

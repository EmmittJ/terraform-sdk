#pragma warning disable ASPIREPIPELINES001 // Experimental API usage

using Aspire.Hosting;
using Aspire.Hosting.Yarp.Transforms;
using TerraformPlayground.AppHost;

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

// FastAPI backend - Todo API
var api = builder.AddUvicornApp("api", "../api", "main:app")
    .WithHttpHealthCheck("/health");

// Frontend Vite React app
var frontend = builder.AddViteApp("frontend", "../frontend")
    .WithReference(api);

// YARP reverse proxy - routes /api to backend, everything else to frontend
// Automatically published as Azure Container App
builder.AddYarp("app")
    .WithConfiguration(c =>
    {
        // Always proxy /api requests to FastAPI backend
        c.AddRoute("api/{**catch-all}", api)
            .WithTransformPathRemovePrefix("/api");

        if (builder.ExecutionContext.IsRunMode)
        {
            // In dev mode, proxy all other requests to Vite dev server
            c.AddRoute("{**catch-all}", frontend);
        }
    })
    .WithExternalHttpEndpoints()
    .PublishWithStaticFiles(frontend)
    .PublishAsTerraformContainerApp((infra, app) =>
    {
        // Simple customization example - add tags
        app.Tags ??= new();
        app.Tags["CustomTag"] = "MyValue";
    });

builder.Build().Run();

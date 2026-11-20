// Runs Terraform you already wrote from an Aspire AppHost. No cloud account needed:
// every .tf file here only uses terraform_data.
//
//   Aspire value  --WithVariable-->  Terraform `variable`
//   Terraform `output`  --GetOutput-->  Aspire value
//
// Run mode:   dotnet run   (nothing is applied; GetOutput values are prompted as parameters)
// Publish:    aspire publish / aspire deploy   (terraform init -> apply -> output)

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;

var builder = DistributedApplication.CreateBuilder(args);

// Modules and templates are called from a generated root configuration.
builder.AddTerraformEnvironment("terraform");

var environment = builder.AddParameter("environment");

// 1. Configuration: a root directory with its own backend and state, used in place.
var network = builder.AddTerraformConfiguration("network", "./infra/network")
    .WithVariable("environment", environment);

// 2. Module: a local path, registry address, or Git URL.
var queue = builder.AddTerraformModule("queue", "./infra/queue")
    .WithVariable("name", "orders");

// 3. Template: one HCL file, like a Bicep template.
var cache = builder.AddTerraformTemplate("cache", "./infra/cache/cache.tf")
    .WithVariable("size", "small");

// PublishAs*: runs as a container locally, deploys via Terraform when publishing.
var api = builder.AddContainer("api", "mcr.microsoft.com/dotnet/samples", "aspnetapp")
    .WithHttpEndpoint(targetPort: 8080, name: "http")
    .WithEnvironment("NETWORK_ID", network.GetOutput("network_id"))
    .WithEnvironment("CACHE_ID", cache.GetOutput("cache_id"))
    .PublishAsTerraformModule("./infra/api", module => module
        .WithVariable("name", "api")
        .WithVariable("queue_id", queue.GetOutput("queue_id"))
        .MapEndpoint("http", EndpointProperty.Url, "url"));

builder.AddContainer("worker", "busybox")
    .WithEnvironment("API_URL", api.GetEndpoint("http"));

builder.Build().Run();

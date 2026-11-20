// Wires Terraform that already lives on disk (./infra/*) into Aspire.
//   Aspire value  --WithVariable-->  Terraform `variable`
//   Terraform `output`  --GetOutput-->  Aspire value
// Deploy with: aspire deploy   (modules are not applied in run mode)

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform.Modules;

var builder = DistributedApplication.CreateBuilder(args);

var environment = builder.AddParameter("environment");

var network = builder.AddTerraformModule("network", "./infra/network")
    .WithVariable("environment", environment);

var app = builder.AddTerraformModule("app", "./infra/app")
    .WithVariable("network_id", network.GetOutput("network_id"))
    .WithVariable("callback_url", "https://example.com/hook");

var api = builder.AddContainer("echo", "busybox");

if (builder.ExecutionContext.IsPublishMode)
{
    api.WithEnvironment("APP_ID", app.GetOutput("app_id"));
}

builder.Build().Run();

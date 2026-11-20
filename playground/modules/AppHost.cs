// Wires Terraform that already lives on disk (./infra/*) into Aspire.
//   Aspire value  --WithVariable-->  Terraform `variable`
//   Terraform `output`  --GetOutput-->  Aspire value
// Deploy with: aspire deploy   (modules are only applied when deploying;
// in run mode, outputs are prompted for as parameters, or read via RunAsExisting())

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;

var builder = DistributedApplication.CreateBuilder(args);

var environment = builder.AddParameter("environment");

var network = builder.AddTerraformConfiguration("network", "./infra/network")
    .WithVariable("environment", environment);

var app = builder.AddTerraformConfiguration("app", "./infra/app")
    .WithVariable("network_id", network.GetOutput("network_id"))
    .WithVariable("callback_url", "https://example.com/hook");

var api = builder.AddContainer("echo", "busybox");

api.WithEnvironment("APP_ID", app.GetOutput("app_id"));

builder.Build().Run();

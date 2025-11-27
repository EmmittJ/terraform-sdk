using Aspire.Hosting;
using EmmittJ.Terraform.Sdk.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

// Add Terraform code generation environment
var codeGenEnv = builder.AddTerraformCodeGenEnvironment("terraform-codegen")
    .WithOutputDirectory(Path.Combine(Directory.GetParent(builder.AppHostDirectory)!.FullName, "providers"))
    .WithWorkingDirectory(Path.Combine(builder.AppHostDirectory, ".terraform-codegen"))
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers");

// Add Terraform providers for code generation
var aws = builder
    .AddTerraformProvider("aws", "~> 6.0");

var azurerm = builder
    .AddTerraformProvider("azurerm", "~> 4.0");

var azuread = builder
    .AddTerraformProvider("azuread", "~> 3.0");

var google = builder
    .AddTerraformProvider("google", "~> 7.0");

builder.Build().Run();

using Aspire.Hosting;
using EmmittJ.Terraform.Sdk.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

// Add Terraform code generation environment
var codeGenEnv = builder.AddTerraformCodeGenEnvironment("terraform-codegen")
    .WithOutputDirectory(Path.Combine(Directory.GetParent(builder.AppHostDirectory)!.FullName, "providers"))
    .WithWorkingDirectory(Path.Combine(builder.AppHostDirectory, ".terraform-codegen"))
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers");

// Add Terraform providers for code generation
// The new eventing system will automatically process these during publish mode
// Provider names become the namespace suffix (e.g., "AzureRM" -> "EmmittJ.Terraform.Sdk.Providers.AzureRM")
// var aws = builder.AddTerraformProvider("aws", "aws", "~> 6.0");

var azurerm = builder
    .AddTerraformProvider("azurerm", "~> 4.0");

// var azuread = builder.AddTerraformProvider("AzureAD", "azuread", "~> 3.0");

// var google = builder.AddTerraformProvider("Google", "google", "~> 7.0");

builder.Build().Run();

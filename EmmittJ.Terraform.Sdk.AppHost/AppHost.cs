using Aspire.Hosting;
using EmmittJ.Terraform.Sdk.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

// Enable Terraform code generation pipeline
builder.AddTerraformCodeGenPipeline();

// Add Terraform provider code generation resources
var aws = builder.AddTerraformProvider("aws", "~> 6.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.Aws");

var azurerm = builder.AddTerraformProvider("azurerm", "~> 4.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.AzureRM");

var azuread = builder.AddTerraformProvider("azuread", "~> 3.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.AzureAD");

var google = builder.AddTerraformProvider("google", "~> 7.0")
    .WithNamespace("EmmittJ.Terraform.Sdk.Providers.Google");

builder.Build().Run();

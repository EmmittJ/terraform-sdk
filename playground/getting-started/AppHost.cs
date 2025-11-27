// ============================================================================
// Getting Started with EmmittJ.Terraform.Sdk
// ============================================================================
// This minimal Aspire AppHost demonstrates the core concepts of the Terraform SDK:
// - Variables for input values
// - Resources for infrastructure
// - Outputs for exposing values
// - References between resources
//
// Run with: dotnet run
// Generate Terraform: aspire publish
// ============================================================================

using Aspire.Hosting;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk;

var builder = DistributedApplication.CreateBuilder(args);

// ============================================================================
// Create a Terraform environment with variables, resources, and outputs
// ============================================================================

var environment = builder.AddParameter("environment");
var projectName = builder.AddParameter("project-name");

builder.AddTerraformEnvironment("demo")
    .WithBackend("local")
    .WithOutputPath("infra")
    .WithAutoOperations(autoApply: true)
    .PublishAsTerraform(infra =>
    {
        // Variables - Input values for your configuration
        var environmentVar = environment.AsVariable(infra);

        var projectNameVar = projectName.AsVariable(infra);

        // Resource - A simple local file (no cloud provider required)
        var configFile = new TerraformResource("local_file", "config")
        {
            ["filename"] = "${path.module}/output/config.txt",
            ["content"] = Tf.Interpolate($"\"environment\": \"{environmentVar.AsReference()}\"\n\"project\": \"{projectNameVar.AsReference()}\"")
        };
        infra.Add(configFile);

        // Outputs - Expose values from your configuration
        infra.Add(new TerraformOutput("config_path")
        {
            Description = "Path to the generated config file",
            Value = configFile["filename"]
        });

        infra.Add(new TerraformOutput("environment")
        {
            Description = "The deployment environment",
            Value = environmentVar.AsReference()
        });
    });

builder.Build().Run();


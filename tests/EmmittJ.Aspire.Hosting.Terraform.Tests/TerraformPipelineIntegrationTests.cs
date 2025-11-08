// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001 // Type is for evaluation purposes only and is subject to change or removal in future updates

using Aspire.Hosting;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Hosting;
using Xunit;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

/// <summary>
/// Integration tests that actually execute the pipeline and verify file generation.
/// Uses Verify for snapshot testing of generated Terraform files.
/// </summary>
public class TerraformPipelineIntegrationTests
{
    private static string[] GetPublishArgs(string outputPath) =>
        ["--operation", "publish", "--output-path", outputPath, "--non-interactive"];

    [Fact]
    public async Task TerraformStack_GeneratesFileInDefaultLocation()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            // Add Terraform environment
            builder.AddTerraformEnvironment();

            var container = builder.AddContainer("myapp", "image")
                .PublishAsTerraform(stack =>
                {
                    var vpc = new TerraformVariable("vpc_cidr")
                    {
                        Type = "string",
                        Default = "10.0.0.0/16",
                        Description = "VPC CIDR block"
                    };
                    stack.Add(vpc);
                });

            using var app = builder.Build();

            // Act - Execute the publish pipeline
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }

    [Fact]
    public async Task TerraformStack_WithOutputDirectory_GeneratesFileInSpecifiedLocation()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        var customOutput = Path.Combine(tempDir, "custom-terraform");
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            // Add Terraform environment
            builder.AddTerraformEnvironment();

            builder.AddContainer("myapp", "image")
                .WithTerraformConfiguration(config => config.OutputPath = customOutput)
                .PublishAsTerraform(stack =>
                {
                    var region = new TerraformVariable("region")
                    {
                        Type = "string",
                        Default = "us-east-1"
                    };
                    stack.Add(region);
                });

            using var app = builder.Build();

            // Act
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }

    [Fact]
    public async Task MultipleStacks_GenerateSeparateFiles()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            var container = builder.AddContainer("myapp", "image")
                .PublishAsTerraform(stack =>
                {
                    stack.Name = "network";
                    var vpc = new TerraformVariable("vpc_cidr")
                    {
                        Type = "string",
                        Default = "10.0.0.0/16"
                    };
                    stack.Add(vpc);
                })
                .PublishAsTerraform(stack =>
                {
                    stack.Name = "security";
                    var allowSsh = new TerraformVariable("allow_ssh")
                    {
                        Type = "bool",
                        Default = "true"
                    };
                    stack.Add(allowSsh);
                });

            using var app = builder.Build();

            // Act
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }

    [Fact]
    public async Task TerraformStack_WithParentConfiguration_UsesParentDirectory()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        var parentOutputDir = Path.Combine(tempDir, "parent-terraform");
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            var container = builder.AddContainer("myapp", "image")
                .WithTerraformConfiguration(config => config.OutputPath = parentOutputDir)
                .PublishAsTerraform(stack =>
                {
                    stack.Name = "stack1";
                    var var1 = new TerraformVariable("var1")
                    {
                        Type = "string"
                    };
                    stack.Add(var1);
                })
                .PublishAsTerraform(stack =>
                {
                    stack.Name = "stack2";
                    var var2 = new TerraformVariable("var2")
                    {
                        Type = "string"
                    };
                    stack.Add(var2);
                });

            using var app = builder.Build();

            // Act
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }

    [Fact]
    public async Task TerraformStack_WithComplexConfiguration_GeneratesValidHCL()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "terraform-test", Guid.NewGuid().ToString());
        try
        {
            var builder = DistributedApplication.CreateBuilder(new DistributedApplicationOptions
            {
                Args = GetPublishArgs(tempDir),
                DisableDashboard = true
            });

            var container = builder.AddContainer("myapp", "image")
                .PublishAsTerraform(stack =>
                {
                    // Add multiple types of constructs
                    var stringVar = new TerraformVariable("environment")
                    {
                        Type = "string",
                        Default = "development",
                        Description = "Environment name"
                    };
                    stack.Add(stringVar);

                    var numberVar = new TerraformVariable("instance_count")
                    {
                        Type = "number",
                        Default = "3"
                    };
                    stack.Add(numberVar);

                    var boolVar = new TerraformVariable("enable_monitoring")
                    {
                        Type = "bool",
                        Default = "true"
                    };
                    stack.Add(boolVar);
                });

            using var app = builder.Build();

            // Act
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            await app.StartAsync(cts.Token);
            await app.WaitForShutdownAsync(cts.Token);

            // Assert - Verify the entire output directory structure
            await VerifyDirectory(tempDir);
        }
        finally
        {
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, recursive: true);
            }
        }
    }
}


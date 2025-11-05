using System.Diagnostics;

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Base class for integration tests that validate generated HCL with the Terraform CLI.
/// These tests require Terraform to be installed and available in PATH.
/// Each test class runs in parallel for faster execution.
/// </summary>
public abstract class TerraformIntegrationTestBase : IDisposable
{
    protected readonly string TempDir;

    protected TerraformIntegrationTestBase()
    {
        TempDir = Path.Combine(Path.GetTempPath(), $"terraform-test-{Guid.NewGuid()}");
        Directory.CreateDirectory(TempDir);
    }

    public void Dispose()
    {
        if (Directory.Exists(TempDir))
        {
            try
            {
                Directory.Delete(TempDir, recursive: true);
            }
            catch
            {
                // Ignore cleanup errors
            }
        }
    }

    protected async Task AssertTerraformValidatesAsync(TerraformStack config)
    {
        // Write HCL to file
        var hcl = config.ToHcl();
        var mainTfPath = Path.Combine(TempDir, "main.tf");
        await File.WriteAllTextAsync(mainTfPath, hcl);

        // Run terraform init
        var initResult = await RunTerraformCommandAsync("init -backend=false");
        Assert.Equal(0, initResult.ExitCode);

        // Run terraform validate
        var validateResult = await RunTerraformCommandAsync("validate");
        Assert.Equal(0, validateResult.ExitCode);
    }

    private async Task<(int ExitCode, string Output, string Error)> RunTerraformCommandAsync(string arguments)
    {
        var processInfo = new ProcessStartInfo
        {
            FileName = "terraform",
            Arguments = arguments,
            WorkingDirectory = TempDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(processInfo);
        if (process == null)
        {
            throw new InvalidOperationException("Failed to start Terraform process");
        }

        var outputBuilder = new System.Text.StringBuilder();
        var errorBuilder = new System.Text.StringBuilder();

        process.OutputDataReceived += (sender, e) =>
        {
            if (e.Data != null)
                outputBuilder.AppendLine(e.Data);
        };

        process.ErrorDataReceived += (sender, e) =>
        {
            if (e.Data != null)
                errorBuilder.AppendLine(e.Data);
        };

        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        await process.WaitForExitAsync();

        return (process.ExitCode, outputBuilder.ToString(), errorBuilder.ToString());
    }
}

public class TerraformIntegrationTests_SimpleResource : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task SimpleResource_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main");
        config.Add(new TerraformResource("aws_instance", "web")
            .WithProperty("ami", "ami-12345678")
            .WithProperty("instance_type", "t2.micro"));

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}

public class TerraformIntegrationTests_Backend : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task ResourceWithBackend_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("local")
                {
                    ["path"] = "terraform.tfstate"
                }
            }
        };

        config.Add(new TerraformResource("aws_s3_bucket", "data")
            .WithProperty("bucket", "my-data-bucket"));

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}

public class TerraformIntegrationTests_Settings : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task ResourceWithSettings_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">= 1.0"
            }
        };
        config.Terraform.RequiredProviders["aws"] = new ProviderRequirement
        {
            Source = "hashicorp/aws",
            Version = "~> 5.0"
        };

        config.Add(new TerraformResource("aws_instance", "web")
            .WithProperty("ami", "ami-12345678")
            .WithProperty("instance_type", "t2.micro"));

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}

public class TerraformIntegrationTests_Lifecycle : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task ResourceWithLifecycle_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main");
        var resource = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                CreateBeforeDestroy = true,
                PreventDestroy = false
            }
        };
        resource.Lifecycle.IgnoreChanges.Add("tags");
        resource.WithProperty("ami", "ami-12345678")
            .WithProperty("instance_type", "t2.micro");
        config.Add(resource);

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}

public class TerraformIntegrationTests_DataSource : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task DataSource_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main");
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu");
        dataSource.WithProperty("most_recent", true);
        config.Add(dataSource);

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}

public class TerraformIntegrationTests_Complex : TerraformIntegrationTestBase
{
    [Fact(Skip = "Integration test - requires Terraform CLI. Run manually with: dotnet test --filter Category=Integration")]
    [Trait("Category", "Integration")]
    public async Task ComplexConfiguration_PassesTerraformValidate()
    {
        // Arrange
        var config = new TerraformStack("main")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">= 1.0",
                Backend = new TerraformBackend("local")
                {
                    ["path"] = "terraform.tfstate"
                }
            }
        };

        config.Terraform.RequiredProviders["aws"] = new ProviderRequirement
        {
            Source = "hashicorp/aws",
            Version = "~> 5.0"
        };

        // Add provider
        var provider = new TerraformProvider("aws");
        provider.WithProperty("region", "us-west-2");
        config.Add(provider);

        // Add data source
        var ami = new TerraformDataSource("aws_ami", "ubuntu");
        ami.WithProperty("most_recent", true);
        config.Add(ami);

        // Add resource with lifecycle (reference ami output)
        var instance = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                CreateBeforeDestroy = true
            }
        };
        var amiRef = new TerraformReferenceExpression(ami, "id");
        instance.WithProperty("ami", amiRef)
            .WithProperty("instance_type", "t2.micro");
        config.Add(instance);

        // Act & Assert
        await AssertTerraformValidatesAsync(config);
    }
}





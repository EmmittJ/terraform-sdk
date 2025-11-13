namespace EmmittJ.Terraform.Sdk.Tests.Configuration;

public class TerraformSettingsTests
{
    [Fact]
    public Task CanGenerateBasicTerraformBlock()
    {
        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.9.0"
        };

        var stack = new TerraformStack { Name = "test" };
        stack.Terraform = settings;

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task CanGenerateTerraformBlockWithBackend()
    {
        var backend = new TerraformBackend("s3")
        {
            ["bucket"] = "my-state",
            ["region"] = "us-west-2",
            ["key"] = "terraform.tfstate"
        };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.9.0",
            Backend = backend
        };

        var stack = new TerraformStack { Name = "test" };
        stack.Terraform = settings;

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task CanGenerateTerraformBlockWithCloud()
    {
        var cloud = new TerraformCloudBlock
        {
            Organization = "my-org",
            Hostname = "app.terraform.io",
            Workspaces = new CloudWorkspacesBlock
            {
                Name = "my-workspace"
            }
        };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.9.0",
            Cloud = cloud
        };

        var stack = new TerraformStack { Name = "test" };
        stack.Terraform = settings;

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task CanGenerateTerraformBlockWithCloudTags()
    {
        var cloud = new TerraformCloudBlock
        {
            Organization = "my-org",
            Workspaces = new CloudWorkspacesBlock
            {
                Tags = ["app", "production"]
            }
        };

        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.9.0",
            Cloud = cloud
        };

        var stack = new TerraformStack { Name = "test" };
        stack.Terraform = settings;

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public Task CanGenerateTerraformBlockWithProviderRequirements()
    {
        var settings = new TerraformSettings
        {
            RequiredVersion = ">= 1.9.0",
            RequiredProviders = new TerraformMap<ProviderRequirement>
            {
                ["aws"] = new ProviderRequirement
                {
                    Source = "hashicorp/aws",
                    Version = "~> 5.0"
                },
                ["random"] = new ProviderRequirement
                {
                    Source = "hashicorp/random",
                    Version = ">= 3.0"
                }
            }
        };

        var stack = new TerraformStack { Name = "test" };
        stack.Terraform = settings;

        var hcl = stack.ToHcl();

        return Verify(hcl);
    }
}

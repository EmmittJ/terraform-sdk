using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformCloudConfigTests
{
    [Fact]
    public Task CloudConfig_WithOrganizationAndWorkspaceName_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Cloud = new TerraformCloudConfig
                {
                    Organization = "example_corp",
                    Workspaces = new CloudWorkspaceConfig
                    {
                        Name = "my-workspace"
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CloudConfig_WithWorkspaceTags_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Cloud = new TerraformCloudConfig
                {
                    Organization = "example_corp",
                    Workspaces = new CloudWorkspaceConfig
                    {
                        Tags = new List<string> { "app", "production" }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CloudConfig_WithTerraformEnterprise_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Cloud = new TerraformCloudConfig
                {
                    Organization = "example_corp",
                    Hostname = "my.terraform-enterprise.host",
                    Workspaces = new CloudWorkspaceConfig
                    {
                        Tags = new List<string> { "app" }
                    }
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task CloudConfig_WithAllOptions_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">= 1.0",
                Cloud = new TerraformCloudConfig
                {
                    Organization = "example_corp",
                    Hostname = "app.terraform.io",
                    Token = "my-token",
                    Workspaces = new CloudWorkspaceConfig
                    {
                        Name = "my-workspace",
                        Project = "my-project"
                    }
                }
            }
        };

        config.Terraform.RequiredProviders["aws"] = new ProviderRequirement
        {
            Source = "hashicorp/aws",
            Version = "~> 5.0"
        };

        return Verify(config.ToHcl());
    }
}

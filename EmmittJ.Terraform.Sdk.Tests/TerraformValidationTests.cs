using EmmittJ.Terraform.Sdk.Core;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformValidationTests
{
    [Fact]
    public void Validate_CloudAndBackendBothSet_ReturnsError()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Cloud = new TerraformCloudConfig
                {
                    Organization = "example_corp"
                },
                Backend = new TerraformBackend("s3")
            }
        };

        var result = config.Validate();

        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains("mutually exclusive", result.Errors[0].Message);
        Assert.Contains("cloud", result.Errors[0].Message.ToLower());
        Assert.Contains("backend", result.Errors[0].Message.ToLower());
    }

    [Fact]
    public void Validate_OnlyCloudSet_IsValid()
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

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_OnlyBackendSet_IsValid()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("s3")
            }
        };

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_WorkspacesNameAndTagsBothSet_ReturnsError()
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
                        Name = "my-workspace",
                        Tags = new List<string> { "app", "production" }
                    }
                }
            }
        };

        var result = config.Validate();

        Assert.False(result.IsValid);
        Assert.Single(result.Errors);
        Assert.Contains("mutually exclusive", result.Errors[0].Message);
        Assert.Contains("name", result.Errors[0].Message.ToLower());
        Assert.Contains("tags", result.Errors[0].Message.ToLower());
    }

    [Fact]
    public void Validate_WorkspacesOnlyNameSet_IsValid()
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

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_WorkspacesOnlyTagsSet_IsValid()
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

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_WorkspacesWithEmptyTags_IsValid()
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
                        Name = "my-workspace",
                        Tags = new List<string>() // Empty list should not conflict
                    }
                }
            }
        };

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_NoTerraformBlock_IsValid()
    {
        var config = new TerraformConfiguration("test");

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }
}

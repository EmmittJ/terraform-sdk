using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformSettingsTests
{
    [Fact]
    public Task Settings_RequiredVersion_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">= 1.0"
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Settings_RequiredProviders_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock()
        };

        config.Terraform.RequiredProviders["aws"] = new ProviderRequirement
        {
            Source = "hashicorp/aws",
            Version = "~> 5.0"
        };
        config.Terraform.RequiredProviders["azurerm"] = new ProviderRequirement
        {
            Source = "hashicorp/azurerm",
            Version = ">= 3.0"
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Settings_Complete_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">= 1.5.0"
            }
        };

        config.Terraform.RequiredProviders["aws"] = new ProviderRequirement
        {
            Source = "hashicorp/aws",
            Version = "~> 5.0"
        };
        config.Terraform.Experiments.Add("module_variable_optional_attrs");
        config.Terraform.Experiments.Add("defaults");

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Settings_WithConstructs_GeneratesHcl()
    {
        var config = new TerraformStack("test")
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

        var variable = new TerraformVariable("region")
        {
            Type = "string",
            Default = "us-west-2"
        };
        config.Add(variable);

        var provider = new TerraformProvider("aws");
        provider.WithProperty("region", variable.AsReference());
        config.Add(provider);

        return Verify(config.ToHcl());
    }
}


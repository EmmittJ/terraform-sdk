using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformBackendTests
{
    [Fact]
    public Task Backend_S3_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("s3")
                {
                    ["bucket"] = "my-terraform-state",
                    ["key"] = "vpc/terraform.tfstate",
                    ["region"] = "us-west-2",
                    ["encrypt"] = true
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Backend_Azurerm_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("azurerm")
                {
                    ["resource_group_name"] = "terraform-state-rg",
                    ["storage_account_name"] = "tfstate",
                    ["container_name"] = "tfstate",
                    ["key"] = "prod.terraform.tfstate"
                }
            }
        };

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Backend_WithSettings_GeneratesHcl()
    {
        var config = new TerraformStack("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">=1.0",
                Backend = new TerraformBackend("s3")
                {
                    ["bucket"] = "my-terraform-state",
                    ["key"] = "vpc/terraform.tfstate"
                }
            }
        };

        return Verify(config.ToHcl());
    }
}





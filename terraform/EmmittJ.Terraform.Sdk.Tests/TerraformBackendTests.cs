using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformBackendTests
{
    [Fact]
    public Task Backend_S3_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("s3")
            }
        };

        config.Terraform.Backend.Set("bucket", "my-terraform-state");
        config.Terraform.Backend.Set("key", "vpc/terraform.tfstate");
        config.Terraform.Backend.Set("region", "us-west-2");
        config.Terraform.Backend.Set("encrypt", true);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Backend_Azurerm_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                Backend = new TerraformBackend("azurerm")
            }
        };

        config.Terraform.Backend.Set("resource_group_name", "terraform-state-rg");
        config.Terraform.Backend.Set("storage_account_name", "tfstate");
        config.Terraform.Backend.Set("container_name", "tfstate");
        config.Terraform.Backend.Set("key", "prod.terraform.tfstate");

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Backend_WithSettings_GeneratesHcl()
    {
        var config = new TerraformConfiguration("test")
        {
            Terraform = new TerraformConfigurationBlock
            {
                RequiredVersion = ">=1.0",
                Backend = new TerraformBackend("s3")
            }
        };

        config.Terraform.Backend.Set("bucket", "my-terraform-state");
        config.Terraform.Backend.Set("key", "vpc/terraform.tfstate");

        return Verify(config.ToHcl());
    }
}

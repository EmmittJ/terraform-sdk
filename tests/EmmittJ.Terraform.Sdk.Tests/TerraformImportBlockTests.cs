using EmmittJ.Terraform.Sdk.Constructs;
using EmmittJ.Terraform.Sdk.Core;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformImportBlockTests
{
    [Fact]
    public Task ImportBlock_BasicResource_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "aws_instance.example",
            id: "i-1234567890abcdef0"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_WithProvider_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "aws_instance.example",
            id: "i-1234567890abcdef0",
            provider: "aws.west"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_WithCountIndex_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "aws_instance.example[0]",
            id: "i-1234567890abcdef0"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_WithForEachKey_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "aws_instance.web[\"primary\"]",
            id: "i-1234567890abcdef0"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_ModuleResource_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "module.web_servers.aws_instance.server",
            id: "i-1234567890abcdef0"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_AzureResource_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "azurerm_resource_group.example",
            id: "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/mygroup"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_GoogleResource_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var import = new TerraformImportBlock(
            to: "google_compute_instance.default",
            id: "projects/my-project/zones/us-central1-a/instances/my-instance"
        );

        config.Add(import);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task ImportBlock_MultipleImports_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        config.Add(new TerraformImportBlock(
            to: "aws_instance.web",
            id: "i-1111111111111111"
        ));

        config.Add(new TerraformImportBlock(
            to: "aws_instance.db",
            id: "i-2222222222222222",
            provider: "aws.east"
        ));

        config.Add(new TerraformImportBlock(
            to: "aws_security_group.allow_http",
            id: "sg-3333333333333333"
        ));

        return Verify(config.ToHcl());
    }

    [Fact]
    public void ImportBlock_ToIsNull_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformImportBlock(to: null!, id: "i-1234567890abcdef0")
        );

        Assert.Contains("'to' address cannot be null or empty", exception.Message);
    }

    [Fact]
    public void ImportBlock_ToIsEmpty_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformImportBlock(to: "", id: "i-1234567890abcdef0")
        );

        Assert.Contains("'to' address cannot be null or empty", exception.Message);
    }

    [Fact]
    public void ImportBlock_IdIsNull_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformImportBlock(to: "aws_instance.example", id: null!)
        );

        Assert.Contains("'id' cannot be null or empty", exception.Message);
    }

    [Fact]
    public void ImportBlock_IdIsEmpty_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformImportBlock(to: "aws_instance.example", id: "")
        );

        Assert.Contains("'id' cannot be null or empty", exception.Message);
    }

    [Fact]
    public void ImportBlock_AsReference_ThrowsNotSupportedException()
    {
        var import = new TerraformImportBlock(
            to: "aws_instance.example",
            id: "i-1234567890abcdef0"
        );

        Assert.Throws<NotSupportedException>(() => import.AsReference());
    }
}

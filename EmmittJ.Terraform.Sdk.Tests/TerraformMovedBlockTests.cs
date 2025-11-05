using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformMovedBlockTests
{
    [Fact]
    public Task MovedBlock_RenameResource_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "aws_instance.a",
            to: "aws_instance.b"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_RenameModule_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "module.old_name",
            to: "module.new_name"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_WithInstanceIndex_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "aws_instance.example",
            to: "aws_instance.example[0]"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_WithForEachKey_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "aws_instance.web",
            to: "aws_instance.web[\"primary\"]"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_ModuleToModuleInstance_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "module.vpc",
            to: "module.vpc[2]"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_ResourceIntoModule_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        var moved = new TerraformMovedBlock(
            from: "aws_instance.example",
            to: "module.servers.aws_instance.example"
        );

        config.Add(moved);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task MovedBlock_MultipleBlocks_GeneratesHcl()
    {
        var config = new TerraformStack("test");

        config.Add(new TerraformMovedBlock(
            from: "aws_instance.a",
            to: "aws_instance.b"
        ));

        config.Add(new TerraformMovedBlock(
            from: "aws_instance.b",
            to: "aws_instance.c"
        ));

        config.Add(new TerraformMovedBlock(
            from: "module.old",
            to: "module.new"
        ));

        return Verify(config.ToHcl());
    }

    [Fact]
    public void MovedBlock_FromIsNull_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new TerraformMovedBlock(null!, "aws_instance.b"));
    }

    [Fact]
    public void MovedBlock_ToIsNull_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new TerraformMovedBlock("aws_instance.a", null!));
    }

    [Fact]
    public void MovedBlock_FromIsEmpty_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new TerraformMovedBlock("", "aws_instance.b"));
    }

    [Fact]
    public void MovedBlock_ToIsEmpty_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new TerraformMovedBlock("aws_instance.a", ""));
    }
}

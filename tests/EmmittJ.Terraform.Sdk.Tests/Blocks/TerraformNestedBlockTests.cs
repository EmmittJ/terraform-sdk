namespace EmmittJ.Terraform.Sdk.Tests.Blocks;

using EmmittJ.Terraform.Sdk.Tests.TestHelpers;

/// <summary>
/// Tests for nested blocks within resources (lifecycle, provisioner, connection, etc.).
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "Block")]
public class TerraformNestedBlockTests
{
    [Fact]
    public Task LifecycleBlock_CreateBeforeDestroy_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();
        var resource = new TerraformResource("aws_instance", "web");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true
        };

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task LifecycleBlock_PreventDestroy_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();
        var resource = new TerraformResource("aws_instance", "web");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            PreventDestroy = true
        };

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task LifecycleBlock_IgnoreChanges_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();
        var resource = new TerraformResource("aws_instance", "web");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            IgnoreChanges = new TerraformList<string> { "tags", "ami" }
        };

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }

    [Fact]
    public Task LifecycleBlock_MultipleProperties_RendersCorrectly()
    {
        // Arrange
        var context = TerraformTestHelpers.CreateContext();
        var resource = new TerraformResource("aws_instance", "web");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true,
            PreventDestroy = false,
            IgnoreChanges = new TerraformList<string> { "tags" }
        };

        // Act
        var hcl = TerraformTestHelpers.RenderBlock(resource, context);

        // Assert
        return Verify(hcl);
    }
}

// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

public class TerraformStackResourceTests
{
    [Fact]
    public void Constructor_CreatesResourceWithCorrectProperties()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test-stack");
        var name = "test-resource";

        // Act
        var resource = new TerraformStackResource(name, parent, stack);

        // Assert
        Assert.Equal(name, resource.Name);
        Assert.Same(parent, resource.Parent);
        Assert.Same(stack, resource.Stack);
    }

    [Fact]
    public void Constructor_ThrowsWhenNameIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformStackResource(null!, parent, stack));
    }

    [Fact]
    public void Constructor_ThrowsWhenParentIsNull()
    {
        // Arrange
        var stack = new TerraformStack("test");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformStackResource("name", null!, stack));
    }

    [Fact]
    public void Constructor_ThrowsWhenStackIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new TerraformStackResource("name", parent, null!));
    }

    [Fact]
    public void TerraformStackResource_ImplementsIResourceWithParent()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test");

        // Act
        var resource = new TerraformStackResource("test", parent, stack);

        // Assert
        Assert.IsAssignableFrom<IResourceWithParent<IResource>>(resource);
    }

    [Fact]
    public void TerraformStackResource_InheritsFromResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test");

        // Act
        var resource = new TerraformStackResource("test", parent, stack);

        // Assert
        Assert.IsAssignableFrom<Resource>(resource);
    }

    [Fact]
    public void TerraformStackResource_StackPropertyExposesConstructs()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test");
        var variable = new TerraformVariable("test_var") { Type = "string" };
        stack.Add(variable);

        // Act
        var resource = new TerraformStackResource("test", parent, stack);

        // Assert
        Assert.Single(resource.Stack.Constructs);
        Assert.Contains(resource.Stack.Constructs, c => c is TerraformVariable v && v.Name == "test_var");
    }

    [Fact]
    public void TerraformStackResource_CanHaveAnnotations()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var parent = builder.AddContainer("parent", "image").Resource;
        var stack = new TerraformStack("test");
        var resource = new TerraformStackResource("test", parent, stack);

        // Act
        var testAnnotation = new TestAnnotation();
        resource.Annotations.Add(testAnnotation);

        // Assert
        Assert.Contains(testAnnotation, resource.Annotations);
    }

    private sealed class TestAnnotation : IResourceAnnotation
    {
    }
}

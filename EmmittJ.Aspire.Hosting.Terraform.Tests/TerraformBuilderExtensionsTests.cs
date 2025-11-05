// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Testing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

public class TerraformBuilderExtensionsTests
{
    [Fact]
    public void AddTerraformStack_CreatesStackResourceWithCorrectName()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var stackBuilder = container.AddTerraformStack("network");

        // Assert
        Assert.NotNull(stackBuilder);
        Assert.Equal("myapp-network", stackBuilder.Resource.Name);
    }

    [Fact]
    public void AddTerraformStack_AssociatesWithParentResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var stackBuilder = container.AddTerraformStack("infra");

        // Assert
        Assert.Same(container.Resource, stackBuilder.Resource.Parent);
    }

    [Fact]
    public void WithTerraformStack_ReturnsParentBuilder()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var result = container.WithTerraformStack("network");

        // Assert
        Assert.Same(container, result);
    }

    [Fact]
    public void AddTerraformStack_ConfiguresStackWhenActionProvided()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var configured = false;

        // Act
        var stackBuilder = container.AddTerraformStack("test", stack =>
        {
            configured = true;
            Assert.Equal("test", stack.Name);
        });

        // Assert
        Assert.True(configured);
    }

    [Fact]
    public void AddTerraformStack_ThrowsWhenBuilderIsNull()
    {
        // Arrange
        IResourceBuilder<IResource>? builder = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => builder!.AddTerraformStack("test"));
    }

    [Fact]
    public void AddTerraformStack_ThrowsWhenStackNameIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => container.AddTerraformStack(null!));
    }

    [Fact]
    public void AddTerraformStack_ThrowsWhenStackNameIsEmpty()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => container.AddTerraformStack(string.Empty));
    }

    [Fact]
    public void AddTerraformStack_RegistersEventingSubscriber()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.AddTerraformStack("test");

        using var app = builder.Build();
        var services = app.Services;

        // Assert - verify the eventing subscriber is registered
        var subscribers = services.GetServices<IDistributedApplicationEventingSubscriber>();
        Assert.Contains(subscribers, s => s is TerraformEventingSubscriber);
    }

    [Fact]
    public void WithTerraformStack_ConfiguresStackWhenActionProvided()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var configured = false;

        // Act
        container.WithTerraformStack("test", stack =>
        {
            configured = true;
            Assert.Equal("test", stack.Name);
        });

        // Assert
        Assert.True(configured);
    }

    [Fact]
    public void WithTerraformStack_ThrowsWhenBuilderIsNull()
    {
        // Arrange
        IResourceBuilder<IResource>? builder = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => builder!.WithTerraformStack("test"));
    }

    [Fact]
    public void WithTerraformStack_ThrowsWhenStackNameIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => container.WithTerraformStack(null!));
    }

    [Fact]
    public void WithTerraformStack_ThrowsWhenStackNameIsEmpty()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => container.WithTerraformStack(string.Empty));
    }

    [Fact]
    public void WithTerraformStack_RegistersEventingSubscriber()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.WithTerraformStack("test");

        using var app = builder.Build();
        var services = app.Services;

        // Assert - verify the eventing subscriber is registered
        var subscribers = services.GetServices<IDistributedApplicationEventingSubscriber>();
        Assert.Contains(subscribers, s => s is TerraformEventingSubscriber);
    }

    [Fact]
    public void WithTerraformStack_AllowsChaining()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var result = container
            .WithTerraformStack("network")
            .WithTerraformStack("security");

        // Assert
        Assert.Same(container, result);
    }

    [Fact]
    public void AddTerraformStack_AllowsMultipleStacksOnSameResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var networkStack = container.AddTerraformStack("network");
        var securityStack = container.AddTerraformStack("security");

        // Assert
        Assert.NotSame(networkStack.Resource, securityStack.Resource);
        Assert.Equal("myapp-network", networkStack.Resource.Name);
        Assert.Equal("myapp-security", securityStack.Resource.Name);
        Assert.Same(container.Resource, networkStack.Resource.Parent);
        Assert.Same(container.Resource, securityStack.Resource.Parent);
    }

    [Fact]
    public void WithTerraformWorkingDirectory_SetsWorkingDirectory()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var workingDir = "/tmp/terraform";

        // Act
        container.WithTerraformWorkingDirectory(workingDir);

        // Assert
        var annotation = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        Assert.NotNull(annotation);
        Assert.Equal(workingDir, annotation.WorkingDirectory);
    }

    [Fact]
    public void WithTerraformWorkingDirectory_UpdatesExistingAnnotation()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var firstDir = "/tmp/first";
        var secondDir = "/tmp/second";

        // Act
        container.WithTerraformWorkingDirectory(firstDir);
        container.WithTerraformWorkingDirectory(secondDir);

        // Assert
        var annotations = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .ToList();

        Assert.Single(annotations);
        Assert.Equal(secondDir, annotations[0].WorkingDirectory);
    }

    [Fact]
    public void WithTerraformWorkingDirectory_ThrowsWhenBuilderIsNull()
    {
        // Arrange
        IResourceBuilder<IResource>? builder = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => builder!.WithTerraformWorkingDirectory("/tmp"));
    }

    [Fact]
    public void WithTerraformWorkingDirectory_ThrowsWhenDirectoryIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => container.WithTerraformWorkingDirectory(null!));
    }

    [Fact]
    public void WithTerraformWorkingDirectory_ThrowsWhenDirectoryIsEmpty()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => container.WithTerraformWorkingDirectory(string.Empty));
    }

    [Fact]
    public void AddTerraformStack_StackContainsConfiguredResources()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var stackBuilder = container.AddTerraformStack("test", stack =>
        {
            var variable = new TerraformVariable("test_var")
            {
                Type = "string",
                Description = "Test variable"
            };
            stack.Add(variable);
        });

        // Assert
        var variables = stackBuilder.Resource.Stack.Constructs.OfType<TerraformVariable>();
        Assert.Single(variables);
        Assert.Equal("test_var", variables.First().Name);
    }

    [Fact]
    public void WithTerraformStack_CanChainWithOtherBuilderMethods()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();

        // Act
        var container = builder.AddContainer("myapp", "image")
            .WithTerraformWorkingDirectory("/tmp/tf")
            .WithTerraformStack("network")
            .WithTerraformStack("security");

        // Assert
        Assert.NotNull(container);
        Assert.Same(container.Resource, builder.Resources.First(r => r.Name == "myapp"));
        var annotation = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();
        Assert.NotNull(annotation);
        Assert.Equal("/tmp/tf", annotation.WorkingDirectory);
    }

    [Fact]
    public void AddAndWithTerraformStack_CanBeUsedTogether()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act - Use AddTerraformStack when you need the stack reference
        var stackBuilder = container.AddTerraformStack("network", stack =>
        {
            var variable = new TerraformVariable("vpc_cidr")
            {
                Type = "string",
                Default = "10.0.0.0/16"
            };
            stack.Add(variable);
        });

        // And use WithTerraformStack when you want to chain on the parent
        container.WithTerraformStack("security");

        // Assert
        Assert.Equal("myapp-network", stackBuilder.Resource.Name);
        Assert.Single(stackBuilder.Resource.Stack.Constructs);

        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();
        Assert.Equal(2, terraformStacks.Count);
    }
}

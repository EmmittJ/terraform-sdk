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
    public void PublishAsTerraformStack_CreatesStackResourceWithCorrectName()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var result = container.PublishAsTerraformStack("network");

        // Assert
        Assert.Same(container, result);

        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();
        Assert.Equal("myapp-network", stackResource.Name);
    }

    [Fact]
    public void PublishAsTerraformStack_AssociatesWithParentResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.PublishAsTerraformStack("infra");

        // Assert
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();
        Assert.Same(container.Resource, stackResource.Parent);
    }

    [Fact]
    public void PublishAsTerraformStack_ConfiguresStackWhenActionProvided()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var configured = false;

        // Act
        container.PublishAsTerraformStack("test", stack =>
        {
            configured = true;
            Assert.Equal("test", stack.Name);
        });

        // Assert
        Assert.True(configured);
    }

    [Fact]
    public void PublishAsTerraformStack_ThrowsWhenBuilderIsNull()
    {
        // Arrange
        IResourceBuilder<IResource>? builder = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => builder!.PublishAsTerraformStack("test"));
    }

    [Fact]
    public void PublishAsTerraformStack_ThrowsWhenStackNameIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => container.PublishAsTerraformStack(null!));
    }

    [Fact]
    public void PublishAsTerraformStack_ThrowsWhenStackNameIsEmpty()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => container.PublishAsTerraformStack(string.Empty));
    }

    [Fact]
    public void PublishAsTerraformStack_RegistersEventingSubscriber()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.PublishAsTerraformStack("test");

        using var app = builder.Build();
        var services = app.Services;

        // Assert - verify the eventing subscriber is registered
        var subscribers = services.GetServices<IDistributedApplicationEventingSubscriber>();
        Assert.Contains(subscribers, s => s is TerraformEventingSubscriber);
    }

    [Fact]
    public void PublishAsTerraformStack_AllowsChaining()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        var result = container
            .PublishAsTerraformStack("network")
            .PublishAsTerraformStack("security");

        // Assert
        Assert.Same(container, result);
    }

    [Fact]
    public void PublishAsTerraformStack_AllowsMultipleStacksOnSameResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.PublishAsTerraformStack("network");
        container.PublishAsTerraformStack("security");

        // Assert
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();
        Assert.Equal(2, terraformStacks.Count);
        Assert.Equal("myapp-network", terraformStacks[0].Name);
        Assert.Equal("myapp-security", terraformStacks[1].Name);
        Assert.Same(container.Resource, terraformStacks[0].Parent);
        Assert.Same(container.Resource, terraformStacks[1].Parent);
    }

    [Fact]
    public void WithTerraformConfiguration_SetsOutputDirectory()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var workingDir = "/tmp/terraform";

        // Act
        container.WithTerraformConfiguration(config => config.OutputPath = workingDir);

        // Assert
        var annotation = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();

        Assert.NotNull(annotation);
        Assert.Equal(workingDir, annotation.OutputPath);
    }

    [Fact]
    public void WithTerraformConfiguration_UpdatesExistingAnnotation()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        var firstDir = "/tmp/first";
        var secondDir = "/tmp/second";

        // Act
        container.WithTerraformConfiguration(config => config.OutputPath = firstDir);
        container.WithTerraformConfiguration(config => config.OutputPath = secondDir);

        // Assert
        var annotations = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .ToList();

        Assert.Single(annotations);
        Assert.Equal(secondDir, annotations[0].OutputPath);
    }

    [Fact]
    public void WithTerraformConfiguration_ThrowsWhenBuilderIsNull()
    {
        // Arrange
        IResourceBuilder<IResource>? builder = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => builder!.WithTerraformConfiguration(config => config.OutputPath = "/tmp"));
    }

    [Fact]
    public void WithTerraformConfiguration_ThrowsWhenConfigureActionIsNull()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => container.WithTerraformConfiguration(null!));
    }

    [Fact]
    public void PublishAsTerraformStack_StackContainsConfiguredResources()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.PublishAsTerraformStack("test", stack =>
        {
            var variable = new TerraformVariable("test_var")
            {
                Type = "string",
                Description = "Test variable"
            };
            stack.Add(variable);
        });

        // Assert
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();
        var variables = stackResource.Stack.Constructs.OfType<TerraformVariable>();
        Assert.Single(variables);
        Assert.Equal("test_var", variables.First().Name);
    }

    [Fact]
    public void PublishAsTerraformStack_CanChainWithOtherBuilderMethods()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();

        // Act
        var container = builder.AddContainer("myapp", "image")
            .WithTerraformConfiguration(config => config.OutputPath = "/tmp/tf")
            .PublishAsTerraformStack("network")
            .PublishAsTerraformStack("security");

        // Assert
        Assert.NotNull(container);
        Assert.Same(container.Resource, builder.Resources.First(r => r.Name == "myapp"));
        var annotation = container.Resource.Annotations
            .OfType<TerraformConfigurationAnnotation>()
            .FirstOrDefault();
        Assert.NotNull(annotation);
        Assert.Equal("/tmp/tf", annotation.OutputPath);
    }

    [Fact]
    public void PublishAsTerraformStack_CanBeCalledMultipleTimes()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Act
        container.PublishAsTerraformStack("network", stack =>
        {
            var variable = new TerraformVariable("vpc_cidr")
            {
                Type = "string",
                Default = "10.0.0.0/16"
            };
            stack.Add(variable);
        });

        container.PublishAsTerraformStack("security");

        // Assert
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();
        Assert.Equal(2, terraformStacks.Count);
        Assert.Equal("myapp-network", terraformStacks[0].Name);
        Assert.Single(terraformStacks[0].Stack.Constructs);
    }
}

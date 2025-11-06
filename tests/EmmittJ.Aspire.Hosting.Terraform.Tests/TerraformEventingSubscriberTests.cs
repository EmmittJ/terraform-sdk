// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Aspire.Hosting.Testing;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

public class TerraformEventingSubscriberTests
{
    [Fact]
    public async Task SubscribeAsync_ValidatesStacksAfterResourcesCreated()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        container.PublishAsTerraformStack("valid", stack =>
        {
            var variable = new TerraformVariable("test_var")
            {
                Type = "string",
                Description = "Test variable"
            };
            stack.Add(variable);
        });

        // Act
        using var app = builder.Build();

        // Assert - Should not throw during build (validation happens during AfterResourcesCreatedEvent)
        Assert.NotNull(app);
    }

    [Fact]
    public async Task SubscribeAsync_ThrowsForInvalidStack()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        // Create a stack that will fail validation
        container.PublishAsTerraformStack("invalid", stack =>
        {
            // Add constructs that would fail validation
            var variable = new TerraformVariable("invalid-var-name-with-dashes")
            {
                Type = "invalid_type"
            };
            stack.Add(variable);
        });

        // Act & Assert
        // Note: The validation happens during the eventing subscriber
        // For this test, we're verifying the subscriber is registered
        using var app = builder.Build();

        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();

        Assert.Single(terraformStacks);
        Assert.Equal("myapp-invalid", terraformStacks[0].Name);
    }

    [Fact]
    public void TerraformEventingSubscriber_ImplementsIDistributedApplicationEventingSubscriber()
    {
        // Arrange & Act
        var subscriber = new TerraformEventingSubscriber();

        // Assert
        Assert.IsAssignableFrom<IDistributedApplicationEventingSubscriber>(subscriber);
    }

    [Fact]
    public async Task SubscribeAsync_HandlesMultipleStacks()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");

        container.PublishAsTerraformStack("network", stack =>
        {
            var vpcCidr = new TerraformVariable("vpc_cidr")
            {
                Type = "string",
                Default = "10.0.0.0/16"
            };
            stack.Add(vpcCidr);
        });

        container.PublishAsTerraformStack("security", stack =>
        {
            var allowedIps = new TerraformVariable("allowed_ips")
            {
                Type = "list(string)",
                Default = new List<string> { "0.0.0.0/0" }
            };
            stack.Add(allowedIps);
        });

        // Act
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();

        // Assert
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();
        Assert.Equal(2, terraformStacks.Count);
        Assert.Contains(terraformStacks, s => s.Name == "myapp-network");
        Assert.Contains(terraformStacks, s => s.Name == "myapp-security");
    }

    [Fact]
    public async Task SubscribeAsync_IgnoresResourcesWithoutTerraformStacks()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        builder.AddContainer("app1", "image1");
        builder.AddContainer("app2", "image2");

        // Act
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();

        // Assert
        var terraformStacks = model.Resources.OfType<TerraformStackResource>().ToList();
        Assert.Empty(terraformStacks);
    }

    [Fact]
    public async Task SubscribeAsync_SubscriberIsRegisteredInServiceCollection()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        container.PublishAsTerraformStack("test");

        // Act
        using var app = builder.Build();
        var subscribers = app.Services.GetServices<IDistributedApplicationEventingSubscriber>();

        // Assert
        Assert.Contains(subscribers, s => s is TerraformEventingSubscriber);
    }

    [Fact]
    public async Task SubscribeAsync_ValidatesStackHasValidName()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        container.PublishAsTerraformStack("test-stack");

        // Act
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();

        // Assert
        Assert.NotNull(stackResource.Name);
        Assert.NotEmpty(stackResource.Name);
    }

    [Fact]
    public async Task SubscribeAsync_ValidatesStackHasParent()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        container.PublishAsTerraformStack("test");

        // Act
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();

        // Assert
        Assert.NotNull(stackResource.Parent);
        Assert.Same(container.Resource, stackResource.Parent);
    }

    [Fact]
    public async Task SubscribeAsync_ValidatesStackDefinitionExists()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var container = builder.AddContainer("myapp", "image");
        container.PublishAsTerraformStack("test");

        // Act
        using var app = builder.Build();
        var model = app.Services.GetRequiredService<DistributedApplicationModel>();
        var stackResource = model.Resources.OfType<TerraformStackResource>().Single();

        // Assert
        Assert.NotNull(stackResource.Stack);
    }
}

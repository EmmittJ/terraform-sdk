using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests for enhanced fluent API features added to improve developer experience.
/// </summary>
public class EnhancedApiTests
{
    // TODO: Priority feature removed with fluent API - these tests need to be redesigned
    /*
    [Fact]
    public Task WithProperty_WithPriority_RendersInOrder()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web")
            .WithProperty("tags", new Dictionary<string, string> { ["Name"] = "Web Server" })
            .WithProperty("ami", "ami-12345", priority: 0)  // Render first
            .WithProperty("instance_type", "t2.micro", priority: 1)  // Render second
            .WithProperty("monitoring", true);  // No priority, alphabetical at end

        config.Add(resource);

        return Verify(config.ToHcl());
    }
    */

    [Fact]
    public Task DictionaryImplicitConversion_Works()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource["ami"] = "ami-12345";
        resource["tags"] = new Dictionary<string, string>
        {
            ["Name"] = "Web Server",
            ["Environment"] = "Production",
            ["ManagedBy"] = "Terraform"
        };

        config.Add(resource);

        return Verify(config.ToHcl());
    }

    // TODO: Priority feature removed with fluent API - need to redesign without WithReference priority param
    /*
    [Fact]
    public Task WithReference_WithPriority_Works()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var vpc = new TerraformResource("aws_vpc", "main")
            .WithProperty("cidr_block", "10.0.0.0/16");

        var subnet = new TerraformResource("aws_subnet", "public")
            .WithProperty("cidr_block", "10.0.1.0/24")
            .WithReference("vpc_id", vpc, priority: 0);  // Reference first

        config.Add(vpc);
        config.Add(subnet);

        return Verify(config.ToHcl());
    }
    */

    [Fact]
    public Task MixedTypeDictionary_Works()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("test_resource", "example");
        resource["config"] = new Dictionary<string, object>
        {
            ["name"] = "my-resource",
            ["count"] = 5,
            ["enabled"] = true,
            ["timeout"] = 30.5
        };

        config.Add(resource);

        return Verify(config.ToHcl());
    }
}

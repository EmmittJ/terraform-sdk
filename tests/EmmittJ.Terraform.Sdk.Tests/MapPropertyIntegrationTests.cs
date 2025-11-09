namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// End-to-end integration test demonstrating TerraformMapProperty in a real scenario.
/// </summary>
public class MapPropertyIntegrationTests
{
    [Fact]
    public Task MapProperty_InResource_GeneratesValidHCL()

    {
        // Arrange
        var stack = new TerraformStack();

        var tags = new Dictionary<string, string>
        {
            ["Name"] = "WebServer",
            ["Environment"] = "Production",
            ["ManagedBy"] = "Terraform",
            ["CostCenter"] = "Engineering"
        };

        var instance = new TerraformResource("aws_instance", "web")
            .WithProperty("ami", "ami-0c55b159cbfafe1f0")
            .WithProperty("instance_type", "t2.micro")
            .WithProperty("tags", tags);

        stack.Add(instance);

        // Act & Assert
        return Verify(stack.ToHcl());
    }

    [Fact]
    public Task MapProperty_WithMixedTypes_GeneratesValidHCL()
    {
        // Arrange
        var stack = new TerraformStack();

        var metadata = new Dictionary<string, object>
        {
            ["name"] = "example-config",
            ["namespace"] = "default"
        };

        var data = new Dictionary<string, object>
        {
            ["api_endpoint"] = "https://api.example.com",
            ["timeout_seconds"] = 30,
            ["retry_enabled"] = true,
            ["max_retries"] = 3
        };

        var config = new TerraformResource("kubernetes_config_map", "example")
            .WithProperty("metadata", metadata)
            .WithProperty("data", data);

        stack.Add(config);

        // Act & Assert
        return Verify(stack.ToHcl());
    }

    [Fact]
    public Task MapProperty_WithDynamicValues_GeneratesValidHCL()
    {
        // Arrange
        var stack = new TerraformStack();

        var environment = new TerraformVariable("environment")
        {
            Type = "string",
            Default = "dev"
        };
        stack.Add(environment);

        // Mix literals and expressions using TerraformProperty wrapper
        var tags = new Dictionary<string, TerraformProperty<string>>
        {
            ["Name"] = "MyApp",  // Implicit conversion from string
            ["Environment"] = environment.AsReference(),  // TerraformExpression
            ["Timestamp"] = TerraformExpression.Raw("timestamp()"),  // Raw expression
            ["Region"] = TerraformExpression.Identifier("var.region")  // Identifier
        };

        var instance = new TerraformResource("aws_instance", "app")
            .WithProperty("ami", "ami-12345678")
            .WithProperty("instance_type", "t2.micro")
            .WithProperty("tags", new TerraformMapProperty<TerraformProperty<string>>(tags));

        stack.Add(instance);

        // Act & Assert
        return Verify(stack.ToHcl());
    }

    [Fact]
    public Task MapProperty_EmptyDictionary_GeneratesValidHCL()
    {
        // Arrange
        var stack = new TerraformStack();

        var emptyTags = new Dictionary<string, string>();

        var resource = new TerraformResource("aws_s3_bucket", "example")
            .WithProperty("bucket", "my-bucket")
            .WithProperty("tags", emptyTags);

        stack.Add(resource);

        // Act & Assert
        return Verify(stack.ToHcl());
    }

    [Fact]
    public Task MapProperty_MultipleResources_WithDifferentDictionaries()
    {
        // Arrange
        var stack = new TerraformStack();

        // EC2 Instance with string tags
        var instanceTags = new Dictionary<string, string>
        {
            ["Name"] = "WebServer",
            ["Type"] = "EC2"
        };

        var instance = new TerraformResource("aws_instance", "web")
            .WithProperty("ami", "ami-12345678")
            .WithProperty("tags", instanceTags);

        // RDS Database with mixed type configuration
        var dbParams = new Dictionary<string, object>
        {
            ["max_connections"] = 100,
            ["shared_buffers"] = "256MB",
            ["log_statement"] = "all"
        };

        var database = new TerraformResource("aws_db_instance", "postgres")
            .WithProperty("engine", "postgres")
            .WithProperty("parameters", dbParams);

        stack.Add(instance);
        stack.Add(database);

        // Act & Assert
        return Verify(stack.ToHcl());
    }
}

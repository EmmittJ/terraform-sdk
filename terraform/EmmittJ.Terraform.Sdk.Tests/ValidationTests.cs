namespace EmmittJ.Terraform.Sdk.Tests;

public class ValidationTests
{
    [Fact]
    public void Validate_EmptyConfiguration_Succeeds()
    {
        var config = new TerraformConfiguration();

        var result = config.Validate();

        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_DetectsCircularDependency()
    {
        var config = new TerraformConfiguration();

        // Create two resources that depend on each other in a cycle
        var resourceA = new TerraformResource("null_resource", "a");
        var resourceB = new TerraformResource("null_resource", "b");

        // Resource A depends on Resource B's id
        resourceA.Set("triggers", new TerraformObjectExpression
        {
            ["b_id"] = new TerraformReferenceExpression(resourceB, "id")
        });

        // Resource B depends on Resource A's id (creating the cycle)
        resourceB.Set("triggers", new TerraformObjectExpression
        {
            ["a_id"] = new TerraformReferenceExpression(resourceA, "id")
        });

        config.Add(resourceA);
        config.Add(resourceB);

        // Debug: let's see what the validation result actually contains
        var result = config.Validate();

        // For now, let's just check if we found any cycles at all
        var hasCycleError = result.Errors.Any(e => e.Message.Contains("Circular dependency"));

        Assert.False(result.IsValid, $"Validation should fail. Errors: {string.Join(", ", result.Errors.Select(e => e.Message))}");
        Assert.True(hasCycleError, $"Should detect circular dependency. Errors: {string.Join(", ", result.Errors.Select(e => e.Message))}");
    }

    [Fact]
    public void TerraformObject_PreparesCalled_RecordsDependencies()
    {
        // This test verifies that TerraformObject.Prepare() is actually recording dependencies
        var config = new TerraformConfiguration();
        var context = new TerraformContext(config);

        var resourceA = new TerraformResource("null_resource", "a");
        var resourceB = new TerraformResource("null_resource", "b");

        // Add both constructs to the graph
        context.DependencyGraph.AddConstruct(resourceA);
        context.DependencyGraph.AddConstruct(resourceB);

        // Create a TerraformObject with a reference - use Set() method
        var obj = new TerraformObjectExpression();
        var refToB = new TerraformReferenceExpression(resourceB, "id");
        obj.Set("ref", refToB);

        // Verify the reference was stored (not converted)
        var stored = obj.Get("ref");
        Assert.NotNull(stored);
        Assert.IsType<TerraformReferenceExpression>(stored);

        // Set current construct to resourceA and prepare the object
        context.SetCurrentConstruct(resourceA);
        obj.Prepare(context);

        // Check if the dependency was recorded
        var deps = context.DependencyGraph.GetDependsOn(resourceA);
        Assert.Contains(resourceB, deps);
    }

    [Fact]
    public void Validate_DetectsDuplicateNames()
    {
        var config = new TerraformConfiguration();

        var vpc1 = new TerraformResource("aws_vpc", "main");
        var vpc2 = new TerraformResource("aws_vpc", "main");

        config.Add(vpc1);
        config.Add(vpc2);

        var result = config.Validate();

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.Message.Contains("Duplicate"));
    }

    [Fact]
    public void Validate_AllowsSameNameForDifferentTypes()
    {
        var config = new TerraformConfiguration();

        var resource = new TerraformResource("aws_vpc", "main");
        var data = new TerraformDataSource("aws_vpc", "main");

        config.Add(resource);
        config.Add(data);

        var result = config.Validate();

        Assert.True(result.IsValid);
    }

    [Fact]
    public void ValidationResult_GetSummary_ReturnsFormattedMessage()
    {
        var errors = new[]
        {
            new ValidationError("Error 1", ValidationSeverity.Error),
            new ValidationError("Warning 1", ValidationSeverity.Warning)
        };

        var result = new ValidationResult(errors);

        var summary = result.GetSummary();

        Assert.Contains("1 error(s)", summary);
        Assert.Contains("1 warning(s)", summary);
    }

    [Fact]
    public void ValidationResult_ThrowIfInvalid_ThrowsWhenInvalid()
    {
        var errors = new[]
        {
            new ValidationError("Error", ValidationSeverity.Error)
        };

        var result = new ValidationResult(errors);

        Assert.Throws<TerraformValidationException>(() => result.ThrowIfInvalid());
    }

    [Fact]
    public void ValidationResult_ThrowIfInvalid_DoesNotThrowWhenValid()
    {
        var result = ValidationResult.Success();

        var exception = Record.Exception(() => result.ThrowIfInvalid());

        Assert.Null(exception);
    }

    [Fact]
    public void ValidationError_GetFormattedMessage_IncludesContext()
    {
        var vpc = new TerraformResource("aws_vpc", "main");
        var error = new ValidationError(
            "Test error",
            ValidationSeverity.Error,
            vpc,
            "cidr_block");

        var formatted = error.GetFormattedMessage();

        Assert.Contains("Test error", formatted);
        Assert.Contains("TerraformResource", formatted);
        Assert.Contains("main", formatted);
        Assert.Contains("cidr_block", formatted);
    }

    [Fact]
    public void Validate_HandlesComplexDependencyChain()
    {
        var config = new TerraformConfiguration();

        var vpc = new TerraformResource("aws_vpc", "main");
        vpc.DeclareOutput("id");

        var subnet = new TerraformResource("aws_subnet", "app");
        subnet.Set("vpc_id", vpc["id"]);
        subnet.DeclareOutput("id");

        var instance = new TerraformResource("aws_instance", "web");
        instance.Set("subnet_id", subnet["id"]);

        config.Add(vpc);
        config.Add(subnet);
        config.Add(instance);

        var result = config.Validate();

        Assert.True(result.IsValid);
    }
}

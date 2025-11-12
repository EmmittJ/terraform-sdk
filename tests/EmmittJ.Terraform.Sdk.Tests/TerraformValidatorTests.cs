using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformValidatorTests
{
    [Fact]
    public void Validate_WithValidConstruct_ReturnsSuccess()
    {
        // Arrange
        var resource = new TestResourceWithRequiredProperty
        {
            RequiredName = "test-name"
        };

        // Act
        var result = TerraformValidator.Validate(resource);

        // Assert
        Assert.True(result.IsValid);
        Assert.Empty(result.Errors);
    }

    [Fact]
    public void Validate_WithMissingRequiredProperty_ReturnsError()
    {
        // Arrange - Create instance using Activator to bypass required property check
        var resource = (TestResourceWithRequiredProperty)Activator.CreateInstance(typeof(TestResourceWithRequiredProperty))!;

        // Act
        var result = TerraformValidator.Validate(resource);

        // Assert
        Assert.False(result.IsValid);
        Assert.Equal(1, result.ErrorCount);
        Assert.Contains(result.Errors, e => e.PropertyName == "RequiredName");
    }

    [Fact]
    [RequiresUnreferencedCode("Test uses class with MinLength/MaxLength validation")]
    public void Validate_WithCollectionViolatingMinLength_ReturnsError()
    {
        // Arrange
        var resource = new TestResourceWithCollectionConstraints
        {
            RequiredName = "test",
            Items = new List<TerraformValue<string>>() // Empty list, but min is 1
        };

        // Act
        var result = TerraformValidator.Validate(resource);

        // Assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "Items");
        Assert.Contains(result.Errors, e => e.Message.Contains("at least 1"));
    }

    [Fact]
    [RequiresUnreferencedCode("Test uses class with MinLength/MaxLength validation")]
    public void Validate_WithCollectionViolatingMaxLength_ReturnsError()
    {
        // Arrange
        var resource = new TestResourceWithCollectionConstraints
        {
            RequiredName = "test",
            Items = new List<TerraformValue<string>>
            {
                "item1", "item2", "item3", "item4", "item5", "item6" // 6 items, max is 5
            }
        };

        // Act
        var result = TerraformValidator.Validate(resource);

        // Assert
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "Items");
        Assert.Contains(result.Errors, e => e.Message.Contains("at most 5"));
    }

    [Fact]
    public void ValidateAndThrow_WithInvalidConstruct_ThrowsException()
    {
        // Arrange - Create instance using Activator to bypass required property check
        var resource = (TestResourceWithRequiredProperty)Activator.CreateInstance(typeof(TestResourceWithRequiredProperty))!;

        // Act & Assert
        var exception = Assert.Throws<TerraformValidationException>(() =>
            TerraformValidator.ValidateAndThrow(resource));

        Assert.NotNull(exception.ValidationResult);
        Assert.False(exception.ValidationResult.IsValid);
    }

    [Fact]
    public void ValidateMany_WithMultipleConstructs_AggregatesErrors()
    {
        // Arrange - Create instances using Activator to bypass required property check
        var resource1 = (TestResourceWithRequiredProperty)Activator.CreateInstance(typeof(TestResourceWithRequiredProperty))!;
        var resource2 = (TestResourceWithRequiredProperty)Activator.CreateInstance(typeof(TestResourceWithRequiredProperty))!;

        var constructs = new[] { resource1, resource2 };

        // Act
        var result = TerraformValidator.ValidateMany(constructs);

        // Assert
        Assert.False(result.IsValid);
        Assert.Equal(2, result.ErrorCount); // One error from each resource
    }
}

// Test helper classes that simulate generated resources

public class TestResourceWithRequiredProperty : TerraformResource
{
    public TestResourceWithRequiredProperty() : base("test_resource", "test")
    {
    }

    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequiredName is required")]
    public required TerraformValue<string> RequiredName
    {
        get => GetProperty<TerraformValue<string>>("required_name")!;
        set => this["required_name"] = value);
    }

    public TerraformValue<string>? OptionalDescription
    {
        get => GetProperty<TerraformValue<string>>("optional_description");
        set => this["optional_description"] = value);
    }
}

[RequiresUnreferencedCode("Uses MinLength/MaxLength validation attributes")]
public class TestResourceWithCollectionConstraints : TerraformResource
{
    public TestResourceWithCollectionConstraints() : base("test_collection_resource", "test")
    {
    }

    [System.ComponentModel.DataAnnotations.Required]
    public required TerraformValue<string> RequiredName
    {
        get => GetProperty<TerraformValue<string>>("required_name")!;
        set => this["required_name"] = value);
    }

    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "Items must have at least 1 element")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Items must have at most 5 elements")]
    public List<TerraformValue<string>>? Items
    {
        get => GetProperty<List<TerraformValue<string>>>("items");
        set => this["items"] = value);
    }
}

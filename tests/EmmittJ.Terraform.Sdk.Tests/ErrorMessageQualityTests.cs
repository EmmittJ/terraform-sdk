using EmmittJ.Terraform.Sdk;
using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

/// <summary>
/// Tests to ensure error messages are helpful, actionable, and include sufficient context.
/// These tests validate that when things go wrong, users get clear guidance on how to fix issues.
/// Uses snapshot testing to ensure error messages remain consistent and high-quality.
/// </summary>
[Trait("Category", "Unit")]
[Trait("Layer", "ErrorMessages")]
public class ErrorMessageQualityTests
{
    private static ITerraformContext CreateContext() => TerraformContext.Temporary();

    [Fact]
    public Task UnsupportedType_Object_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            TerraformValue<object> value = new object();
            var nodes = value.ResolveNodes(CreateContext()).ToList();
            nodes[0].ToHcl(CreateContext());
        });

        return Verify(ex.Message);
    }

    [Fact]
    public Task UnsupportedType_DateTime_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            TerraformValue<DateTime> value = new DateTime(2025, 1, 15, 10, 30, 45);
            var nodes = value.ResolveNodes(CreateContext()).ToList();
            nodes[0].ToHcl(CreateContext());
        });

        return Verify(ex.Message);
    }

    [Fact]
    public Task UnsupportedType_Guid_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            TerraformValue<Guid> value = new Guid("12345678-1234-1234-1234-123456789abc");
            var nodes = value.ResolveNodes(CreateContext()).ToList();
            nodes[0].ToHcl(CreateContext());
        });

        return Verify(ex.Message);
    }

    [Fact]
    public Task UnsupportedType_CustomClass_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            var customObject = new TestCustomClass { Value = "test" };
            TerraformValue<TestCustomClass> value = customObject;
            var nodes = value.ResolveNodes(CreateContext()).ToList();
            nodes[0].ToHcl(CreateContext());
        });

        return Verify(ex.Message);
    }

    [Fact]
    public Task OutputWithoutValue_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            var stack = new TerraformStack { Name = "test" };
            var context = new TerraformContext(stack);
            var output = new TerraformOutput("test_output") { Value = null! };

            // This will fail when trying to get the required value
            _ = output.Value;
        });

        return Verify(ex.Message);
    }

    [Fact]
    public Task TerraformValue_NoResolvable_ErrorMessage()
    {
        var ex = GetException(() =>
        {
            var value = new EmptyTerraformValue<string>();
            value.ResolveNodes(CreateContext()).ToList();
        });

        return Verify(ex.Message);
    }

    private static Exception GetException(Action action)
    {
        try
        {
            action();
            throw new InvalidOperationException("Expected an exception to be thrown");
        }
        catch (NotSupportedException ex)
        {
            return ex;
        }
        catch (InvalidOperationException ex)
        {
            return ex;
        }
    }
}

file class TestCustomClass
{
    public string Value { get; set; } = string.Empty;
}

file class EmptyTerraformValue<T> : TerraformValue<T>
{
    public EmptyTerraformValue() : base()
    {
    }
}

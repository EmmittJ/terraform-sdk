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

file class EmptyTerraformValue<T> : TerraformValue<T>
{
    public EmptyTerraformValue() : base()
    {
    }
}

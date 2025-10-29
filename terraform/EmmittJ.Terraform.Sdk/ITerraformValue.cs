namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for Terraform values that can be used in property assignments.
/// </summary>
public interface ITerraformValue
{
    /// <summary>
    /// Gets the kind of value (Unset, Literal, Expression, or Reference).
    /// </summary>
    TerraformValueKind Kind { get; }

    /// <summary>
    /// Gets whether this value is empty (unset).
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Compiles this value to a TerraformExpression for HCL generation.
    /// </summary>
    /// <returns>The compiled expression.</returns>
    TerraformExpression Compile();
}

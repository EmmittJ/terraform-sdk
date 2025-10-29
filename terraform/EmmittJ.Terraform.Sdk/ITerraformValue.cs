namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for Terraform values that can be used in property assignments.
/// Extends ITerraformResolvable to participate in two-pass resolution.
/// Resolves to a TerraformExpression which can then be converted to HCL.
/// </summary>
public interface ITerraformValue : ITerraformResolvable<TerraformExpression>
{
    /// <summary>
    /// Gets the kind of value (Unset, Literal, Expression, or Reference).
    /// </summary>
    TerraformValueKind Kind { get; }

    /// <summary>
    /// Gets whether this value is empty (unset).
    /// </summary>
    bool IsEmpty { get; }
}

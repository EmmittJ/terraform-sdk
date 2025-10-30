namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents the kind of value stored in a TerraformValue.
/// </summary>
public enum TerraformValueKind
{
    /// <summary>
    /// The value has not been set.
    /// </summary>
    Unset,

    /// <summary>
    /// The value is a literal .NET value.
    /// </summary>
    Literal,

    /// <summary>
    /// The value is a TerraformExpression (function call, arithmetic, etc.).
    /// </summary>
    Expression,

    /// <summary>
    /// The value is a reference to another construct.
    /// </summary>
    Reference
}

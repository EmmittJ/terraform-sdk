namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for literal property values.
/// Indicates that a property stores a literal value (not just a reference).
/// </summary>
public interface ITerraformLiteral
{
    // Marker interface - no members needed
}

/// <summary>
/// Generic interface for literal property values with type-safe value access.
/// </summary>
/// <typeparam name="TValue">The type of the literal value.</typeparam>
public interface ITerraformLiteral<out TValue> : ITerraformLiteral
{
    /// <summary>
    /// Gets the literal value stored in this property.
    /// </summary>
    TValue? Value { get; }
}

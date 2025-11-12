namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for TerraformValue&lt;T&gt; to enable non-reflection based value resolution.
/// All TerraformValue&lt;T&gt; types implement this interface to provide polymorphic resolution.
/// </summary>
public interface ITerraformValue
{
    /// <summary>
    /// Gets whether this TerraformValue has a value.
    /// </summary>
    bool HasValue { get; }

    /// <summary>
    /// Resolve this value to a TerraformExpression.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The resolved TerraformExpression.</returns>
    TerraformExpression Resolve(ITerraformContext context);
}

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for TerraformValue&lt;T&gt; to enable non-reflection based value resolution.
/// All TerraformValue&lt;T&gt; types implement this interface to provide polymorphic resolution.
/// </summary>
public interface ITerraformValue : ITerraformResolvable
{
    /// <summary>
    /// Gets or sets the lineage of this value, tracking its origin path.
    /// When set, this value resolves to a reference expression instead of a literal.
    /// </summary>
    TerraformLineage? Lineage { get; set; }

    /// <summary>
    /// Creates a copy of this value with the specified lineage.
    /// </summary>
    /// <param name="lineage">The lineage to set on the copy, or null to clear lineage.</param>
    /// <returns>A new value with the lineage set.</returns>
    ITerraformValue WithLineage(TerraformLineage? lineage);

    /// <summary>
    /// Creates a reference expression for this value based on its lineage.
    /// Used when the value needs to be referenced in expressions rather than resolved to its content.
    /// </summary>
    /// <returns>A TerraformExpression representing a reference to this value.</returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the value has no lineage (has not been attached to a stack or accessed through a property).
    /// </exception>
    TerraformExpression ToReference();
}

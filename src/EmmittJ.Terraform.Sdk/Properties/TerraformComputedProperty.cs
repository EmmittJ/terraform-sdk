namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a computed-only Terraform attribute (read-only reference).
/// This is a simpler version of TerraformReferenceProperty for attributes that are
/// computed by Terraform and cannot be set by users.
/// </summary>
/// <typeparam name="TValue">The type of the computed value.</typeparam>
/// <remarks>
/// Used for output-only attributes in data sources and resources.
/// Creates a reference expression that points to the computed attribute.
/// 
/// Usage:
/// <code>
/// // Computed attribute in a data source
/// public TerraformProperty&lt;string&gt; Id =>
///     new TerraformComputedProperty&lt;string&gt;(ResourceAddress, "id");
/// </code>
/// </remarks>
public class TerraformComputedProperty<TValue> : TerraformProperty<TValue>
{
    /// <summary>
    /// Initializes a new computed property reference.
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    public TerraformComputedProperty(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Preparation phase - nothing to prepare for a computed reference.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        // Computed reference, nothing to prepare
    }

    /// <summary>
    /// Resolution phase - resolves to the reference path.
    /// </summary>
    /// <returns>A Terraform expression representing the reference path.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        // Direct reference: resource.attribute
        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }
}

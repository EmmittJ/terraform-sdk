namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a reference to another Terraform property.
/// Used for indexers and nested property access - doesn't store values, just references.
/// </summary>
/// <typeparam name="TValue">The type of the referenced value.</typeparam>
/// <typeparam name="TSource">The type of the source property (for indexed references).</typeparam>
/// <typeparam name="TIndex">The type of the index (int for lists, string for maps).</typeparam>
/// <remarks>
/// This property type represents a pure reference to another Terraform value. It doesn't store
/// any values itself, only the path to the referenced value. Used for:
/// <list type="bullet">
/// <item><description>Computed-only attributes (read-only properties)</description></item>
/// <item><description>Indexed property access (list[0], map["key"])</description></item>
/// <item><description>Nested property references</description></item>
/// </list>
///
/// Note: Creates new instances on each access to maintain reference semantics.
/// For frequently accessed properties, consider caching the reference.
///
/// Usage patterns:
/// <code>
/// // Computed attribute (read-only)
/// public TerraformProperty&lt;string&gt; Id =>
///     new TerraformReferenceProperty&lt;string, object, object&gt;("aws_instance.web", "id");
///
/// // Indexed access (created by indexer)
/// var firstSg = instance.SecurityGroups[0]; // Returns TerraformReferenceProperty
///
/// // Using reference in expressions
/// rule.SourceSecurityGroupId = instance.SecurityGroups[0]; // aws_instance.web.security_groups[0]
/// </code>
/// </remarks>
public class TerraformReferenceProperty<TValue, TSource, TIndex> : TerraformProperty<TValue>
{
    private readonly TerraformProperty<TSource>? _sourceProperty;
    private readonly TerraformProperty<TIndex>? _indexProperty;

    /// <summary>
    /// Initializes a new reference property for direct references (computed attributes).
    /// </summary>
    /// <param name="resourceAddress">The address of the resource.</param>
    /// <param name="attributeName">The name of the attribute.</param>
    public TerraformReferenceProperty(string resourceAddress, string attributeName)
        : base(resourceAddress, attributeName)
    {
    }

    /// <summary>
    /// Initializes a new reference property for indexed/nested references (indexers).
    /// </summary>
    /// <param name="sourceProperty">The source property being indexed.</param>
    /// <param name="indexProperty">The index property (key or numeric index).</param>
    public TerraformReferenceProperty(
        TerraformProperty<TSource> sourceProperty,
        TerraformProperty<TIndex> indexProperty)
        : base("", "")
    {
        _sourceProperty = sourceProperty;
        _indexProperty = indexProperty;
    }

    /// <summary>
    /// Preparation phase - nothing to prepare for a pure reference.
    /// </summary>
    /// <param name="context">The context for dependency tracking.</param>
    public override void Prepare(ITerraformContext context)
    {
        // Pure reference, nothing to prepare
    }

    /// <summary>
    /// Resolution phase - resolves to the reference path.
    /// </summary>
    /// <param name="context">Optional context for resolution.</param>
    /// <returns>A Terraform expression representing the reference path.</returns>
    public override TerraformExpression Resolve(ITerraformContext? context = null)
    {
        if (_sourceProperty is not null && _indexProperty is not null)
        {
            // Indexed reference: source[index]
            var sourceExpr = _sourceProperty.Resolve(context);
            var indexExpr = _indexProperty.Resolve(context);
            
            // Use IndexExpression for proper index access
            return TerraformExpression.Index(sourceExpr, indexExpr);
        }

        // Direct reference: resource.attribute
        return TerraformExpression.Identifier($"{_resourceAddress}.{_attributeName}");
    }
}
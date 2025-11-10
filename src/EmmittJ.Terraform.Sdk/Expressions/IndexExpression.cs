namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Index access expression for lists and maps (e.g., "list[0]", "map['key']").
/// </summary>
/// <remarks>
/// Used for accessing elements in lists by numeric index or maps by string key.
/// Examples:
/// <code>
/// // Numeric index: aws_instance.web.security_groups[0]
/// var indexExpr = new IndexExpression(
///     TerraformExpression.Identifier("aws_instance.web.security_groups"),
///     TerraformExpression.Literal(0)
/// );
/// 
/// // String key: instance.tags["Name"]
/// var keyExpr = new IndexExpression(
///     TerraformExpression.Identifier("instance.tags"),
///     TerraformExpression.Literal("Name")
/// );
/// </code>
/// </remarks>
internal class IndexExpression : TerraformExpression
{
    private readonly TerraformExpression _source;
    private readonly TerraformExpression _index;

    /// <summary>
    /// Creates an index expression.
    /// </summary>
    /// <param name="source">The expression being indexed (list or map).</param>
    /// <param name="index">The index expression (numeric for lists, string for maps).</param>
    public IndexExpression(TerraformExpression source, TerraformExpression index)
    {
        _source = source ?? throw new ArgumentNullException(nameof(source));
        _index = index ?? throw new ArgumentNullException(nameof(index));
    }

    public override void Prepare(ITerraformContext context)
    {
        if (_source is ITerraformPreparable sourcePreparable)
        {
            sourcePreparable.Prepare(context);
        }

        if (_index is ITerraformPreparable indexPreparable)
        {
            indexPreparable.Prepare(context);
        }
    }

    public override string Resolve(ITerraformContext? context = null)
    {
        var sourceHcl = _source.ToHcl(context);
        var indexHcl = _index.ToHcl(context);
        
        return $"{sourceHcl}[{indexHcl}]";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is IndexExpression other
            && Equals(_source, other._source)
            && Equals(_index, other._index);
    }

    public override int GetHashCode()
        => HashCode.Combine(_source, _index);
}

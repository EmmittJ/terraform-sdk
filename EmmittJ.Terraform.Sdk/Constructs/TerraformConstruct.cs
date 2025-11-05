namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformResolvable for two-pass resolution support.
/// </summary>
public abstract class TerraformConstruct : ITerraformResolvable<string>
{
    private readonly TerraformPropertyCollection _properties = new();

    /// <summary>
    /// Gets the block type (e.g., "resource", "data", "provider", "output", "variable", "module").
    /// </summary>
    public abstract string BlockType { get; }

    /// <summary>
    /// Gets the primary label(s) for this construct in HCL.
    /// For resources/data sources: [type, name]
    /// For providers/modules/outputs/variables: [name]
    /// </summary>
    protected abstract string[] BlockLabels { get; }

    /// <summary>
    /// Gets additional properties to write before the main properties dictionary.
    /// Override this to add construct-specific properties that need special handling.
    /// </summary>
    protected virtual void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Default: no additional properties
    }

    /// <summary>
    /// Internal setter for property accessors and extension methods.
    /// Supports null to remove properties.
    /// </summary>
    internal void WithPropertyInternal(string key, TerraformProperty? value)
        => _properties.Set(key, value);

    /// <summary>
    /// Internal setter for property accessors with priority support.
    /// Supports null to remove properties.
    /// </summary>
    internal void WithPropertyInternal(string key, TerraformProperty? value, int? priority)
    {
        _properties.Set(key, value, priority);
    }

    /// <summary>
    /// Gets a property value (for derived classes).
    /// </summary>
    protected T? GetProperty<T>(string key) where T : class
    {
        return _properties.Get<T>(key);
    }

    /// <summary>
    /// Gets the properties dictionary for subclasses to use in HCL generation.
    /// </summary>
    protected IReadOnlyDictionary<string, TerraformProperty> BlockProperties => _properties;

    /// <summary>
    /// Writes properties to HCL with proper formatting.
    /// Properties with priority (lower numbers first) are written before alphabetically sorted properties.
    /// </summary>
    /// <param name="sb">The StringBuilder to append to.</param>
    /// <param name="context">The context for indentation and resolution.</param>
    protected void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        // Order by: priority first (ascending), then alphabetically by key
        foreach (var (key, property) in _properties.GetOrderedProperties())
        {
            var expression = property.Resolve(context);
            var hcl = expression.ToHcl(context);
            sb.AppendLine($"{context.Indent}{key}{expression.AssignmentOperator}{hcl}");
        }
    }

    /// <inheritdoc/>
    public abstract TerraformExpression AsReference();

    /// <summary>
    /// Preparation phase - prepares all nested values and expressions.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        foreach (var value in _properties.Values)
        {
            value.Prepare(context);
        }
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// When context is provided, uses it for dependency tracking.
    /// When context is null, creates a temporary context.
    /// </summary>
    public virtual string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

        // Build block header: blockType "identifier1" "identifier2" {
        sb.Append($"{context.Indent}{BlockType}");
        foreach (var identifier in BlockLabels)
        {
            sb.Append($" \"{identifier}\"");
        }
        sb.AppendLine(" {");

        using (context.PushIndent())
        {
            WriteAdditionalProperties(sb, context);
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}



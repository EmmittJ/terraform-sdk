namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Abstract base class for all Terraform constructs (resources, data sources, providers, locals).
/// Provides common property management and HCL generation infrastructure.
/// Implements ITerraformSerializable for two-pass HCL generation support.
/// </summary>
public abstract class TerraformConstruct : ITerraformSerializable
{
    /// <summary>
    /// Internal storage for property values set by users via source-generated setters.
    /// Key = Terraform property name (e.g., "name", "location")
    /// Value = TerraformValue&lt;T&gt;, TerraformList&lt;T&gt;, TerraformMap&lt;T&gt;, etc.
    /// </summary>
    private readonly Dictionary<string, object?> _propertyValues = new();

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
    /// Called by source-generated property setters to store values.
    /// </summary>
    /// <param name="terraformName">The Terraform property name (from [TerraformProperty("name")] attribute).</param>
    /// <param name="value">The value to store.</param>
    protected void SetPropertyValue(string terraformName, object? value)
    {
        _propertyValues[terraformName] = value;
    }

    /// <summary>
    /// Called by source-generated property getters to retrieve stored values.
    /// Returns null if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value or null.</returns>
    protected T? GetPropertyValue<T>(string terraformName)
    {
        return _propertyValues.TryGetValue(terraformName, out var value) && value is T ret
            ? ret
            : default;
    }

    /// <summary>
    /// Called by source-generated property getters for required properties.
    /// Throws if the property was never set.
    /// </summary>
    /// <typeparam name="T">The property type.</typeparam>
    /// <param name="terraformName">The Terraform property name.</param>
    /// <returns>The stored value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when a required property has not been set.</exception>
    protected T GetRequiredPropertyValue<T>(string terraformName)
    {
        return GetPropertyValue<T>(terraformName) ?? throw new InvalidOperationException($"Required property '{terraformName}' has not been set.");
    }

    /// <summary>
    /// Gets the internal property values dictionary for serialization.
    /// </summary>
    internal IReadOnlyDictionary<string, object?> PropertyValues => _propertyValues;

    /// <summary>
    /// Writes all properties to HCL with proper formatting.
    /// Override this in derived classes to write properties using reflection and polymorphic resolution.
    /// </summary>
    /// <param name="sb">The StringBuilder to append to.</param>
    /// <param name="context">The context for indentation and resolution.</param>
    protected virtual void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        var resolveContext = new TerraformResolveContext(context);

        foreach (var (terraformName, value) in _propertyValues)
        {
            if (value == null)
                continue;

            TerraformExpression? expression = null;

            // Handle TerraformValue<T> via ITerraformValue interface (no reflection!)
            if (value is ITerraformValue terraformValue)
            {
                if (!terraformValue.HasValue)
                    continue;

                expression = terraformValue.Resolve(resolveContext);
            }
            // Handle other serializable types (blocks, nested objects, etc.)
            else if (value is ITerraformSerializable serializable)
            {
                var hcl = serializable.ToHcl(context);
                sb.AppendLine($"{context.Indent}{terraformName} = {hcl}");
                continue;
            }
            else
            {
                // Fallback to literal value
                expression = TerraformExpression.Literal(value);
            }

            if (expression != null)
            {
                var hcl = expression.ToHcl(context);
                sb.AppendLine($"{context.Indent}{terraformName} = {hcl}");
            }
        }
    }

    /// <inheritdoc/>
    public abstract TerraformExpression AsReference();

    /// <summary>
    /// Preparation phase - prepares all nested values and expressions.
    /// Iterates property values dictionary and calls Prepare() on each ITerraformPreparable.
    /// </summary>
    public virtual void Prepare(ITerraformContext context)
    {
        foreach (var value in _propertyValues.Values)
        {
            if (value is ITerraformPreparable preparable)
            {
                preparable.Prepare(context);
            }
        }
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// When context is provided, uses it for dependency tracking.
    /// When context is null, creates a temporary context.
    /// </summary>
    public virtual string ToHcl(ITerraformContext? context = null)
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
            WriteProperties(sb, context);
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}


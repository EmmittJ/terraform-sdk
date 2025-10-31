namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform output value block.
/// </summary>
public class TerraformOutput(string name) : TerraformConstruct
{
    private TerraformProperty? _value;

    /// <summary>
    /// Gets the output name.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>
    /// Gets or sets the output value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformProperty? Value
    {
        get => _value;
        set => _value = value;
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets whether the output is sensitive.
    /// </summary>
    public bool? Sensitive { get; set; }

    /// <summary>
    /// Gets the list of resources this depends on.
    /// </summary>
    public List<string> DependsOn { get; } = new();

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"output.{Name}");

    /// <summary>
    /// Preparation phase - prepares all nested values.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        base.Prepare(context);
        _value?.Prepare(context);
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// </summary>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        if (_value == null)
        {
            throw new TerraformConfigurationException(
                $"Output '{Name}' must have a value set before it can be synthesized. " +
                "Use the Value property to set the output value.",
                this,
                "Value");
        }

        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}output \"{Name}\" {{");

        using (context.PushIndent())
        {
            // Value is required
            sb.AppendLine($"{context.Indent}value = {_value.Resolve(context).ToHcl(context)}");

            // Optional attributes
            if (Description != null)
            {
                sb.AppendLine($"{context.Indent}description = \"{Description}\"");
            }

            if (Sensitive.HasValue)
            {
                sb.AppendLine($"{context.Indent}sensitive = {Sensitive.Value.ToString().ToLowerInvariant()}");
            }

            if (DependsOn.Count > 0)
            {
                var deps = string.Join(", ", DependsOn);
                sb.AppendLine($"{context.Indent}depends_on = [{deps}]");
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}

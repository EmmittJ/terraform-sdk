namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform output value block.
/// </summary>
public class TerraformOutput(string name) : TerraformConstruct
{
    /// <summary>
    /// Gets the output name.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <inheritdoc/>
    public override string BlockType => "output";

    /// <inheritdoc/>
    protected override string[] BlockLabels => [Name];

    /// <summary>
    /// Gets or sets the output value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformProperty? Value
    {
        get => GetProperty<TerraformProperty>("value");
        set => WithPropertyInternal("value", value, priority: 0);
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => WithPropertyInternal("description", value, priority: 1);
    }

    /// <summary>
    /// Gets or sets whether the output is sensitive.
    /// </summary>
    public TerraformLiteralProperty<bool>? Sensitive
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sensitive");
        set => WithPropertyInternal("sensitive", value, priority: 2);
    }

    /// <summary>
    /// Gets the list of resources this depends on.
    /// </summary>
    public List<string> DependsOn { get; } = new();

    /// <summary>
    /// Gets the list of preconditions to validate before using this output.
    /// Preconditions allow you to validate assumptions about the output value.
    /// </summary>
    public List<TerraformCondition> Preconditions { get; } = new();

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"output.{Name}");

    /// <inheritdoc/>
    protected override void WriteAdditionalProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        if (Value == null)
        {
            throw new TerraformConfigurationException(
                $"Output '{Name}' must have a value set before it can be synthesized. " +
                "Use the Value property to set the output value.",
                this,
                "Value");
        }
    }

    /// <inheritdoc/>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

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

            if (DependsOn.Count > 0)
            {
                var deps = string.Join(", ", DependsOn);
                sb.AppendLine($"{context.Indent}depends_on = [{deps}]");
            }

            // Write preconditions
            foreach (var precondition in Preconditions)
            {
                sb.AppendLine();
                sb.AppendLine($"{context.Indent}precondition {{");
                using (context.PushIndent())
                {
                    sb.AppendLine($"{context.Indent}condition     = {precondition.Condition}");
                    sb.AppendLine($"{context.Indent}error_message = \"{precondition.ErrorMessage}\"");
                }
                sb.AppendLine($"{context.Indent}}}");
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}
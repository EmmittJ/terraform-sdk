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
    public TerraformValue<object>? Value
    {
        get => GetPropertyValue<TerraformValue<object>?>("value");
        set => SetPropertyValue("value", value);
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetPropertyValue<TerraformValue<string>?>("description");
        set => SetPropertyValue("description", value);
    }

    /// <summary>
    /// Gets or sets whether the output is sensitive.
    /// </summary>
    public TerraformValue<bool>? Sensitive
    {
        get => GetPropertyValue<TerraformValue<bool>?>("sensitive");
        set => SetPropertyValue("sensitive", value);
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

    /// <summary>
    /// Implicit conversion to TerraformExpression for natural reference usage.
    /// Allows using outputs directly in expressions without calling AsReference().
    /// </summary>
    /// <param name="output">The output to convert.</param>
    /// <returns>A TerraformExpression representing the output reference.</returns>
    public static implicit operator TerraformExpression(TerraformOutput output)
        => output.AsReference();

    /// <inheritdoc/>
    protected override void WriteProperties(System.Text.StringBuilder sb, ITerraformContext context)
    {
        if (GetPropertyValue<TerraformValue<object>?>("value") == null)
        {
            throw new TerraformStackException(
                $"Output '{Name}' must have a value set before it can be synthesized. " +
                "Use the Value property to set the output value.",
                this,
                "Value");
        }

        // Call base to write all regular properties
        base.WriteProperties(sb, context);
    }

    /// <inheritdoc/>
    public override string ToHcl(ITerraformContext? context = null)
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

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform variable declaration.
/// </summary>
public class TerraformVariable(string name) : TerraformConstruct
{
    private TerraformProperty? _default;

    /// <summary>
    /// Gets the name of the variable.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>
    /// Gets or sets the description of the variable.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the default value.
    /// Can be a literal value or an expression.
    /// </summary>
    public TerraformProperty? Default
    {
        get => _default;
        set => _default = value;
    }

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public bool Sensitive { get; set; }

    /// <inheritdoc/>
    public override TerraformExpression AsReference()
        => TerraformExpression.Identifier($"var.{Name}");

    /// <summary>
    /// Preparation phase - prepares all nested values.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        base.Prepare(context);
        _default?.Prepare(context);
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// </summary>
    public override string Resolve(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);

        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{context.Indent}variable \"{Name}\" {{");

        using (context.PushIndent())
        {
            if (Description != null)
            {
                sb.AppendLine($"{context.Indent}description = \"{Description}\"");
            }

            if (Type != null)
            {
                sb.AppendLine($"{context.Indent}type = {Type}");
            }

            if (_default != null)
            {
                sb.AppendLine($"{context.Indent}default = {_default.Resolve(context)}");
            }

            if (Sensitive)
            {
                sb.AppendLine($"{context.Indent}sensitive = true");
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }
}

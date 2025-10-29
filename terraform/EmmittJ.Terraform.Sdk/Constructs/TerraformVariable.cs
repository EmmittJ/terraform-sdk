namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform variable declaration.
/// </summary>
public class TerraformVariable(string name) : ITerraformConstruct
{
    private readonly Dictionary<string, ITerraformValue> _properties = [];

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
    /// </summary>
    public TerraformValue<object> Default { get; set; } = new();

    /// <summary>
    /// Gets or sets the type constraint (e.g., "string", "list(string)").
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets whether the variable is sensitive.
    /// </summary>
    public bool Sensitive { get; set; }

    /// <inheritdoc/>
    public TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier($"var.{Name}");

    /// <summary>
    /// Preparation phase - prepares all nested values.
    /// </summary>
    public void Prepare(ITerraformContext context)
    {
        Default.Prepare(context);
    }

    /// <summary>
    /// Resolution phase - generates HCL string with optional context.
    /// </summary>
    public string Resolve(ITerraformContext? context = null)
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

            if (!Default.IsEmpty)
            {
                sb.AppendLine($"{context.Indent}default = {Default.Resolve(context).ToHcl(context)}");
            }

            if (Sensitive)
            {
                sb.AppendLine($"{context.Indent}sensitive = true");
            }
        }

        sb.AppendLine($"{context.Indent}}}");

        return sb.ToString();
    }

    /// <summary>
    /// Creates a reference to this variable.
    /// </summary>
    public TerraformReference AsReference() => new(this);

    /// <summary>
    /// Implicit conversion to reference for convenience.
    /// </summary>
    public static implicit operator TerraformReference(TerraformVariable variable)
        => variable.AsReference();
}

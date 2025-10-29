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

    /// <inheritdoc/>
    public string ToHcl(int indent = 0)
    {
        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}variable \"{Name}\" {{");

        if (Description != null)
        {
            sb.AppendLine($"{innerIndent}description = \"{Description}\"");
        }

        if (Type != null)
        {
            sb.AppendLine($"{innerIndent}type = {Type}");
        }

        if (!Default.IsEmpty)
        {
            sb.AppendLine($"{innerIndent}default = {Default.Compile().ToHcl()}");
        }

        if (Sensitive)
        {
            sb.AppendLine($"{innerIndent}sensitive = true");
        }

        sb.AppendLine($"{indentStr}}}");

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

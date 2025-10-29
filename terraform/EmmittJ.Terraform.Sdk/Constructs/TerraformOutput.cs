namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform output value block.
/// </summary>
public class TerraformOutput(string name) : ITerraformConstruct
{
    /// <summary>
    /// Gets the output name.
    /// </summary>
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));

    /// <summary>
    /// Gets or sets the output value.
    /// </summary>
    public TerraformValue<object> Value { get; set; } = new();

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
    public TerraformExpression GetReferenceExpression()
        => TerraformExpression.Identifier($"output.{Name}");

    /// <inheritdoc/>
    public string ToHcl(int indent = 0)
    {
        if (Value.IsEmpty)
        {
            throw new InvalidOperationException($"Output '{Name}' must have a value set before it can be synthesized.");
        }

        var indentStr = new string(' ', indent * 2);
        var innerIndent = new string(' ', (indent + 1) * 2);
        var sb = new System.Text.StringBuilder();

        sb.AppendLine($"{indentStr}output \"{Name}\" {{");

        // Value is required
        sb.AppendLine($"{innerIndent}value = {Value.Compile().ToHcl()}");

        // Optional attributes
        if (Description != null)
        {
            sb.AppendLine($"{innerIndent}description = \"{Description}\"");
        }

        if (Sensitive.HasValue)
        {
            sb.AppendLine($"{innerIndent}sensitive = {Sensitive.Value.ToString().ToLowerInvariant()}");
        }

        if (DependsOn.Count > 0)
        {
            var deps = string.Join(", ", DependsOn);
            sb.AppendLine($"{innerIndent}depends_on = [{deps}]");
        }

        sb.AppendLine($"{indentStr}}}");

        return sb.ToString();
    }
}

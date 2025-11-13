using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a nested block in HCL: label { ... }
/// </summary>
/// <example>
/// tags {
///   Name = "Example"
///   Environment = "Production"
/// }
///
/// lifecycle {
///   create_before_destroy = true
/// }
/// </example>
public sealed class TerraformBlockNode : TerraformSyntaxNode
{
    /// <summary>
    /// The block label (e.g., "tags", "lifecycle")
    /// </summary>
    public string Label { get; }

    /// <summary>
    /// Additional labels for blocks that need them (e.g., dynamic blocks)
    /// </summary>
    public IReadOnlyList<string> AdditionalLabels { get; }

    /// <summary>
    /// Child nodes within this block
    /// </summary>
    public IEnumerable<TerraformSyntaxNode> Children { get; }

    /// <summary>
    /// Creates a new block node.
    /// </summary>
    /// <param name="label">The block label</param>
    /// <param name="children">Child nodes within this block</param>
    /// <param name="additionalLabels">Additional labels for the block</param>
    public TerraformBlockNode(string label, IEnumerable<TerraformSyntaxNode> children, params string[] additionalLabels)
    {
        Label = label ?? throw new ArgumentNullException(nameof(label));
        Children = children ?? throw new ArgumentNullException(nameof(children));
        AdditionalLabels = additionalLabels ?? Array.Empty<string>();
    }

    /// <summary>
    /// Renders this block node to HCL format with proper indentation.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        var sb = new StringBuilder();

        // Block header: label [additional_labels...] {
        sb.Append(Label);
        foreach (var additionalLabel in AdditionalLabels)
        {
            sb.Append(' ');
            sb.Append(additionalLabel);
        }
        sb.AppendLine(" {");

        // Block body (indented)
        using (context.PushIndent())
        {
            foreach (var child in Children)
            {
                var childHcl = child.ToHcl(context);
                sb.Append(context.Indent);
                sb.AppendLine(childHcl);
            }
        }

        // Closing brace
        sb.Append('}');

        return sb.ToString();
    }
}

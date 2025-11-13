using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a top-level Terraform block with a type, labels, and child nodes.
/// </summary>
/// <remarks>
/// Top-level blocks include resource, data, module, provider, output, variable, locals, etc.
/// These blocks have a specific structure: <c>type ["label1"] ["label2"] { ... }</c>
/// </remarks>
public class TerraformTopLevelBlockNode : TerraformSyntaxNode
{
    /// <summary>
    /// Gets the block type (e.g., "resource", "data", "module", "provider").
    /// </summary>
    public string BlockType { get; }

    /// <summary>
    /// Gets the labels for the block (e.g., ["aws_vpc", "main"] for a resource).
    /// </summary>
    public IReadOnlyList<string> Labels { get; }

    /// <summary>
    /// Gets the child nodes contained within this block.
    /// </summary>
    public IReadOnlyList<TerraformSyntaxNode> Children { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformTopLevelBlockNode"/> class.
    /// </summary>
    /// <param name="blockType">The block type (e.g., "resource", "data").</param>
    /// <param name="labels">The labels for the block.</param>
    /// <param name="children">The child nodes.</param>
    public TerraformTopLevelBlockNode(string blockType, IReadOnlyList<string> labels, IReadOnlyList<TerraformSyntaxNode> children)
    {
        BlockType = blockType;
        Labels = labels;
        Children = children;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformTopLevelBlockNode"/> class.
    /// </summary>
    /// <param name="blockType">The block type (e.g., "resource", "data").</param>
    /// <param name="labels">The labels for the block.</param>
    /// <param name="children">The child nodes.</param>
    public TerraformTopLevelBlockNode(string blockType, IReadOnlyList<string> labels, IEnumerable<TerraformSyntaxNode> children)
        : this(blockType, labels, children.ToList())
    {
    }

    /// <summary>
    /// Renders this top-level block as HCL code.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>The HCL representation of this block.</returns>
    public override string ToHcl(ITerraformContext context)
    {
        var sb = new StringBuilder();

        // Build the block header: type "label1" "label2" {
        sb.Append(BlockType);
        foreach (var label in Labels)
        {
            sb.Append(' ');
            sb.Append('"');
            sb.Append(label);
            sb.Append('"');
        }
        sb.AppendLine(" {");

        // Render children with indentation
        using (context.PushIndent())
        {
            foreach (var child in Children)
            {
                sb.Append(context.Indent);
                sb.AppendLine(child.ToHcl(context));
            }
        }

        sb.Append("}");
        return sb.ToString();
    }
}

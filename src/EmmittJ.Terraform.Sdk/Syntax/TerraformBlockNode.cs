using System.Text;

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a block in HCL with a label and optional additional labels.
/// Used for both top-level blocks (resource, data, etc.) and nested blocks (lifecycle, tags, etc.).
/// </summary>
/// <example>
/// Top-level block:
/// resource "aws_vpc" "main" {
///   cidr_block = "10.0.0.0/16"
/// }
///
/// Nested block:
/// lifecycle {
///   create_before_destroy = true
/// }
/// </example>
public class TerraformBlockNode : TerraformSyntaxNode
{
    /// <summary>
    /// The block type keyword (e.g., "resource", "backend", "provider", "lifecycle", "tags").
    /// This is the first identifier that starts the block.
    /// </summary>
    public string BlockType { get; }

    /// <summary>
    /// Block labels that follow the block type.
    /// For resource blocks: ["aws_vpc", "main"] → resource "aws_vpc" "main"
    /// For backend blocks: ["s3"] → backend "s3"
    /// For nested blocks without labels: [] → lifecycle { }
    /// Labels are always quoted in the output.
    /// </summary>
    public IReadOnlyList<string> Labels { get; }

    /// <summary>
    /// Child nodes within this block
    /// </summary>
    public IEnumerable<TerraformSyntaxNode> Children { get; }

    /// <summary>
    /// Creates a new block node with labels as a list.
    /// </summary>
    /// <param name="blockType">The block type keyword</param>
    /// <param name="children">Child nodes within this block</param>
    public TerraformBlockNode(string blockType, IEnumerable<TerraformSyntaxNode> children)
    {
        BlockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
        Labels = [];
        Children = children ?? throw new ArgumentNullException(nameof(children));
    }

    /// <summary>
    /// Creates a new block node with labels as a list.
    /// </summary>
    /// <param name="blockType">The block type keyword</param>
    /// <param name="labels">Labels for the block (will be quoted in output)</param>
    /// <param name="children">Child nodes within this block</param>
    public TerraformBlockNode(string blockType, IReadOnlyList<string> labels, IEnumerable<TerraformSyntaxNode> children)
    {
        BlockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
        Labels = labels ?? [];
        Children = children ?? throw new ArgumentNullException(nameof(children));
    }

    /// <summary>
    /// Renders this block node to HCL format with proper indentation.
    /// </summary>
    public override string ToHcl(ITerraformContext context)
    {
        var sb = new StringBuilder();

        // Block header: block_type "label1" "label2" {
        sb.Append(BlockType);
        foreach (var label in Labels)
        {
            sb.Append(' ');
            sb.Append('"');
            sb.Append(label);
            sb.Append('"');
        }
        sb.AppendLine(" {");

        // Block body (indented)
        using (context.PushIndent())
        {
            foreach (var child in Children)
            {
                if (child is TerraformMapExpression expr)
                {
                    var hcl = expr.RenderProperties(context);
                    sb.Append(hcl);
                }
                else
                {
                    var childHcl = child.ToHcl(context);
                    sb.Append(context.Indent);
                    sb.AppendLine(childHcl);
                }
            }
        }

        // Closing brace (at same indentation as opening)
        sb.Append(context.Indent);
        sb.Append('}');

        return sb.ToString();
    }
}

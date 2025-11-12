namespace EmmittJ.Terraform.Sdk;

using System.Text;

/// <summary>
/// Expression representing a complete top-level Terraform block with block type and labels.
/// This is used for top-level blocks like resources, data sources, outputs, variables, etc.
/// Renamed from TerraformBlockExpression to avoid conflict with nested block expression.
/// </summary>
/// <remarks>
/// Examples of generated HCL:
/// <code>
/// resource "aws_vpc" "main" {
///   cidr_block = "10.0.0.0/16"
/// }
///
/// data "aws_ami" "ubuntu" {
///   most_recent = true
/// }
///
/// output "connection_string" {
///   value = "..."
/// }
///
/// variable "region" {
///   type = string
/// }
/// </code>
/// </remarks>
public class TerraformTopLevelBlockExpression : TerraformExpression
{
    private readonly string _blockType;
    private readonly string[] _labels;
    private readonly TerraformExpression _body;

    /// <summary>
    /// Initializes a new instance of TerraformTopLevelBlockExpression.
    /// </summary>
    /// <param name="blockType">The block type (e.g., "resource", "data", "output", "variable", "provider", "module").</param>
    /// <param name="labels">The block labels. For resources: [type, name]. For outputs/variables: [name].</param>
    /// <param name="body">The body expression, typically a TerraformMapExpression containing properties.</param>
    public TerraformTopLevelBlockExpression(
        string blockType,
        string[] labels,
        TerraformExpression body)
    {
        _blockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
        _labels = labels ?? throw new ArgumentNullException(nameof(labels));
        _body = body ?? throw new ArgumentNullException(nameof(body));
    }

    /// <summary>
    /// Prepares the body expression and any nested dependencies.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        _body.Prepare(context);
    }

    /// <summary>
    /// Converts the block to HCL format.
    /// </summary>
    /// <param name="context">The context providing indentation and scope information.</param>
    /// <returns>The HCL string representation.</returns>
    public override string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new StringBuilder();

        // Header: resource "aws_vpc" "main" {
        sb.Append($"{context.Indent}{_blockType}");
        foreach (var label in _labels)
        {
            sb.Append($" \"{label}\"");
        }
        sb.AppendLine(" {");

        // Body - render with increased indentation
        using (context.PushIndent())
        {
            // If the body is a TerraformMapExpression, render just the properties without braces
            // since we're already providing the block-level braces
            if (_body is TerraformMapExpression mapExpr)
            {
                sb.Append(mapExpr.RenderProperties(context));
            }
            else
            {
                // For other expression types, render normally
                var bodyHcl = _body.ToHcl(context);
                sb.Append(bodyHcl);
                if (!bodyHcl.EndsWith("\n"))
                {
                    sb.AppendLine();
                }
            }
        }

        // Closing brace
        sb.Append($"{context.Indent}}}");

        return sb.ToString();
    }
}

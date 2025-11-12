namespace EmmittJ.Terraform.Sdk;

using System.Text;

/// <summary>
/// Represents a Terraform dynamic block expression in the AST.
/// Dynamic blocks are a special Terraform construct that generates repeated nested blocks
/// based on a collection. They render with unique syntax: dynamic "block_type" { for_each = ... content { } }
/// </summary>
public class TerraformDynamicBlockExpression : TerraformExpression
{
    private readonly string _blockType;
    private readonly TerraformExpression _forEach;
    private readonly TerraformMapExpression _content;
    private readonly string? _iterator;

    /// <summary>
    /// Creates a new dynamic block expression.
    /// </summary>
    /// <param name="blockType">The type of nested block to generate (e.g., "ingress", "egress", "setting")</param>
    /// <param name="forEach">The collection to iterate over (must resolve to a collection)</param>
    /// <param name="content">The content of each generated block (must be a TerraformMapExpression)</param>
    /// <param name="iterator">Optional name for the iterator variable (defaults to blockType if null)</param>
    public TerraformDynamicBlockExpression(
        string blockType,
        TerraformExpression forEach,
        TerraformMapExpression content,
        string? iterator = null)
    {
        _blockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
        _forEach = forEach ?? throw new ArgumentNullException(nameof(forEach));
        _content = content ?? throw new ArgumentNullException(nameof(content));
        _iterator = iterator;
    }

    /// <summary>
    /// Preparation phase - prepares nested expressions.
    /// </summary>
    public override void Prepare(ITerraformContext context)
    {
        _forEach.Prepare(context);
        _content.Prepare(context);
    }

    /// <summary>
    /// Renders the dynamic block to HCL syntax.
    /// Example output:
    /// dynamic "ingress" {
    ///   for_each = var.ingress_rules
    ///   iterator = rule
    ///
    ///   content {
    ///     from_port   = rule.value.from_port
    ///     to_port     = rule.value.to_port
    ///     cidr_blocks = rule.value.cidr_blocks
    ///   }
    /// }
    /// </summary>
    public override string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary(this);
        var sb = new StringBuilder();

        // Dynamic block header: dynamic "block_type" {
        sb.Append(context.Indent);
        sb.Append("dynamic \"");
        sb.Append(_blockType);
        sb.AppendLine("\" {");

        using (context.PushIndent())
        {
            // for_each argument
            sb.Append(context.Indent);
            sb.Append("for_each = ");
            sb.AppendLine(_forEach.ToHcl(context));

            // iterator argument (optional)
            if (_iterator != null)
            {
                sb.Append(context.Indent);
                sb.Append("iterator = ");
                sb.AppendLine(_iterator);
            }

            // Blank line for readability
            sb.AppendLine();

            // content block
            sb.Append(context.Indent);
            sb.AppendLine("content {");

            using (context.PushIndent())
            {
                // Render the content's properties without outer braces
                sb.Append(_content.RenderProperties(context));
            }

            sb.Append(context.Indent);
            sb.AppendLine("}");
        }

        sb.Append(context.Indent);
        sb.Append("}");

        return sb.ToString();
    }
}

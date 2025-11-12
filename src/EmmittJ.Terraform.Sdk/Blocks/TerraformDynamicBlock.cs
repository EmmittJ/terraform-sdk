namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform dynamic block that generates nested blocks conditionally.
/// Dynamic blocks allow you to dynamically block repeatable nested blocks based on a collection.
/// Example: dynamic "ingress" { for_each = var.ingress_rules ... }
/// </summary>
public class TerraformDynamicBlock
{
    /// <summary>
    /// Gets the block type name for the generated blocks.
    /// Example: "ingress", "egress", "tag"
    /// </summary>
    public string BlockType { get; }

    /// <summary>
    /// Gets or sets the collection to iterate over.
    /// Can be a list, set, or map.
    /// </summary>
    public ITerraformValue ForEach { get; set; }

    /// <summary>
    /// Gets or sets the name of the iterator variable.
    /// Defaults to the block type name if not specified.
    /// Example: If BlockType is "ingress", iterator defaults to "ingress"
    /// </summary>
    public string? Iterator { get; set; }

    /// <summary>
    /// Gets or sets labels for the generated blocks.
    /// These are evaluated expressions that can use the iterator.
    /// Example: [iterator.value.name] for named blocks
    /// </summary>
    public List<TerraformValue<string>> Labels { get; } = new();

    /// <summary>
    /// Gets the content properties that will be included in each generated block.
    /// Key is the property name, value is the value expression (can reference the iterator).
    /// </summary>
    public Dictionary<string, ITerraformValue> Content { get; } = new();

    /// <summary>
    /// Creates a new dynamic block.
    /// </summary>
    /// <param name="blockType">The type name for the generated blocks</param>
    /// <param name="forEach">The collection to iterate over</param>
    public TerraformDynamicBlock(string blockType, ITerraformValue forEach)
    {
        BlockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
        ForEach = forEach ?? throw new ArgumentNullException(nameof(forEach));
    }

    /// <summary>
    /// Sets a content property that will be included in each generated block.
    /// </summary>
    public TerraformDynamicBlock WithContent(string name, ITerraformValue value)
    {
        Content[name] = value ?? throw new ArgumentNullException(nameof(value));
        return this;
    }

    /// <summary>
    /// Sets multiple content properties.
    /// </summary>
    public TerraformDynamicBlock WithContent(Dictionary<string, ITerraformValue> content)
    {
        foreach (var (key, value) in content)
        {
            Content[key] = value ?? throw new ArgumentNullException(nameof(value));
        }
        return this;
    }

    /// <summary>
    /// Adds a label expression for the generated blocks.
    /// </summary>
    public TerraformDynamicBlock WithLabel(TerraformValue<string> label)
    {
        Labels.Add(label ?? throw new ArgumentNullException(nameof(label)));
        return this;
    }

    /// <summary>
    /// Resolves the dynamic block to HCL string.
    /// </summary>
    public string ToHcl(ITerraformContext? context = null)
    {
        context ??= TerraformContext.Temporary();

        var sb = new System.Text.StringBuilder();

        // Dynamic block opening
        sb.Append(context.Indent);
        sb.Append("dynamic \"");
        sb.Append(BlockType);
        sb.AppendLine("\" {");

        // Push indent for block contents
        using (context.PushIndent())
        {
            // for_each
            sb.Append(context.Indent);
            sb.Append("for_each = ");
            sb.AppendLine(ForEach.Resolve(context).ToHcl(context));

            // iterator (optional, only if explicitly set)
            if (Iterator != null)
            {
                sb.Append(context.Indent);
                sb.Append("iterator = ");
                sb.AppendLine(Iterator);
            }

            // content block
            sb.Append(context.Indent);
            sb.AppendLine("content {");

            // Push indent for content properties
            using (context.PushIndent())
            {
                // Render each content property
                foreach (var (key, value) in Content)
                {
                    sb.Append(context.Indent);
                    sb.Append(key);
                    sb.Append(" = ");
                    sb.AppendLine(value.Resolve(context).ToHcl(context));
                }
            }

            // Close content block
            sb.Append(context.Indent);
            sb.AppendLine("}");
        }

        // Close dynamic block
        sb.Append(context.Indent);
        sb.Append("}");

        return sb.ToString();
    }
}

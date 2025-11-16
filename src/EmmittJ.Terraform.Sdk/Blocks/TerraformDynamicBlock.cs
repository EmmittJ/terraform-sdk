namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a Terraform dynamic block that generates nested blocks conditionally.
/// Generic version where TContent is the type of block being generated.
/// Dynamic blocks allow you to dynamically generate repeatable nested blocks based on a collection.
/// Example: dynamic "ingress" { for_each = var.ingress_rules ... }
/// </summary>
/// <typeparam name="TContent">The type of block being generated (must inherit from TerraformBlock)</typeparam>
public class TerraformDynamicBlock<TContent> : TerraformBlock
    where TContent : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic";

    /// <summary>
    /// Gets the block type name for blocks being generated (e.g., "ingress", "egress").
    /// Extracted from the Content block's BlockType.
    /// </summary>
    public string BlockTypeToGenerate => Content.BlockType;

    /// <summary>
    /// Gets the strongly-typed content - this IS the block being generated.
    /// </summary>
    public TContent Content { get; }

    /// <summary>
    /// Gets or sets the collection to iterate over.
    /// Can be a list, set, or map.
    /// </summary>
    public ITerraformValue ForEach { get; set; }

    /// <summary>
    /// Gets or sets the name of the iterator variable.
    /// Defaults to the block type name if not specified.
    /// Example: If BlockTypeToGenerate is "ingress", iterator defaults to "ingress"
    /// </summary>
    public string? Iterator { get; set; }

    /// <summary>
    /// Gets or sets labels for the generated blocks (rarely used).
    /// These are evaluated expressions that can use the iterator.
    /// Example: [iterator.value.name] for named blocks
    /// </summary>
    public List<TerraformValue<string>> Labels { get; } = new();

    /// <summary>
    /// Creates a new dynamic block with strongly-typed content.
    /// </summary>
    /// <param name="content">The content template for each generated block</param>
    /// <param name="forEach">The collection to iterate over</param>
    public TerraformDynamicBlock(TContent content, ITerraformValue forEach)
    {
        Content = content ?? throw new ArgumentNullException(nameof(content));
        ForEach = forEach ?? throw new ArgumentNullException(nameof(forEach));
    }

    /// <summary>
    /// Cannot generate reference to dynamic blocks.
    /// </summary>
    public override TerraformExpression AsReference()
        => throw new NotSupportedException("Dynamic blocks cannot be referenced.");

    /// <summary>
    /// Resolves the dynamic block to a TerraformDynamicBlockNode for rendering.
    /// This converts the block model into the syntax node that generates HCL.
    /// </summary>
    /// <param name="context">The resolution context.</param>
    /// <returns>A TerraformDynamicBlockNode representing this dynamic block.</returns>
    public TerraformDynamicBlockNode Resolve(ITerraformContext context)
    {
        // Resolve the forEach value to an expression
        var forEachNodes = ForEach.ResolveNodes(context).ToList();
        if (forEachNodes.Count != 1 || forEachNodes[0] is not TerraformExpression forEachExpr)
        {
            throw new InvalidOperationException(
                $"Dynamic block '{BlockType}' ForEach expression resolved to {forEachNodes.Count} nodes instead of a single expression. " +
                $"ForEach must resolve to a single list, set, or map expression.");
        }

        // Resolve content to a map expression
        var contentNodes = Content.ResolveNodes(context).ToList();
        var contentMap = new TerraformMapExpression();

        foreach (var node in contentNodes)
        {
            if (node is TerraformArgumentNode argNode)
            {
                contentMap[argNode.Key] = argNode.Value;
            }
        }

        return new TerraformDynamicBlockNode(
            BlockTypeToGenerate,
            forEachExpr,
            contentMap,
            Iterator
        );
    }
}

/// <summary>
/// Non-generic convenience version of TerraformDynamicBlock for untyped scenarios.
/// Use this when you don't have a strongly-typed block class and need to configure
/// properties dynamically using string names.
/// </summary>
public class TerraformDynamicBlock : TerraformDynamicBlock<DynamicBlockContent>
{
    /// <summary>
    /// Creates a new dynamic block with untyped content.
    /// </summary>
    /// <param name="blockType">The type of block being generated (e.g., "setting", "ingress")</param>
    /// <param name="forEach">The collection to iterate over</param>
    public TerraformDynamicBlock(string blockType, ITerraformValue forEach)
        : base(new DynamicBlockContent(blockType), forEach)
    {
    }
}

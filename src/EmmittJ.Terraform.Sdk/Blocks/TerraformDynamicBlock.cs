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
    /// Gets the block labels - for dynamic blocks, this is the type of block being generated.
    /// </summary>
    public override string[] BlockLabels => [Content.BlockType];

    /// <summary>
    /// Gets the strongly-typed content - this IS the block being generated.
    /// </summary>
    public TContent Content { get; }

    /// <summary>
    /// Gets or sets the collection to iterate over.
    /// Can be a list, set, or map.
    /// </summary>
    public ITerraformValue ForEach
    {
        get => GetRequiredArgument<ITerraformValue>("for_each");
        set => SetArgument("for_each", value);
    }

    /// <summary>
    /// Gets or sets the name of the iterator variable.
    /// Defaults to the block type name if not specified.
    /// Example: If BlockTypeToGenerate is "ingress", iterator defaults to "ingress"
    /// </summary>
    public TerraformValue<string>? Iterator
    {
        get => GetArgument<TerraformValue<string>?>("iterator");
        set => SetArgument("iterator", value);
    }

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
    /// Resolves the dynamic block to a TerraformDynamicBlockNode.
    /// Dynamic blocks have special HCL syntax that requires custom rendering.
    /// </summary>
    public override IEnumerable<TerraformSyntaxNode> ResolveNodes(ITerraformContext context)
    {
        // Resolve for_each to an expression
        var forEachNodes = ForEach.ResolveNodes(context).ToList();
        if (forEachNodes.Count != 1 || forEachNodes[0] is not TerraformExpression forEachExpr)
        {
            throw new InvalidOperationException(
                "Dynamic block for_each must resolve to a single expression.");
        }

        // Resolve iterator if set
        string? iteratorName = null;
        if (_elements.TryGetValue("iterator", out var iteratorElement))
        {
            var iteratorNodes = iteratorElement.ResolveNodes(context).ToList();
            if (iteratorNodes.Count == 1 && iteratorNodes[0] is TerraformExpression iterExpr)
            {
                var hcl = iterExpr.ToHcl(context);
                // Remove quotes if it's a literal string
                iteratorName = hcl.Trim().Trim('"');
            }
        }

        // Resolve content block's children
        var contentNodes = Content.ResolveNodes(context).ToList();
        var contentMap = new TerraformMapExpression();

        // Extract arguments from the content block
        if (contentNodes.Count == 1 && contentNodes[0] is TerraformBlockNode blockNode)
        {
            foreach (var child in blockNode.Children)
            {
                if (child is TerraformArgumentNode argNode)
                {
                    contentMap[argNode.Key] = argNode.Value;
                }
            }
        }

        yield return new TerraformDynamicBlockNode(
            Content.BlockType,
            forEachExpr,
            contentMap,
            iteratorName
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

namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for TerraformProvisionableConstruct (resources and data sources).
/// Provides dynamic block management for constructs that support it.
/// </summary>
public static class TerraformProvisionableConstructExtensions
{
    /// <summary>
    /// Adds a dynamic block with a callback to configure the content.
    /// The iterator variable is automatically named after the block type.
    /// Example: resource.WithDynamicBlock("ingress", var.rules, ingress => { ... })
    /// </summary>
    public static TConstruct WithDynamicBlock<TConstruct>(
        this TConstruct construct,
        string blockType,
        TerraformExpression forEach,
        Action<TerraformDynamicBlockBuilder> configure)
        where TConstruct : TerraformProvisionableConstruct
    {
        var dynamicBlock = new TerraformDynamicBlock(blockType, forEach);
        var builder = new TerraformDynamicBlockBuilder(dynamicBlock, blockType);
        configure(builder);
        construct.DynamicBlocks.Add(dynamicBlock);
        return construct;
    }

    /// <summary>
    /// Adds a dynamic block with a custom iterator name and a callback to configure the content.
    /// Example: resource.WithDynamicBlock("egress", "rule", var.rules, rule => { ... })
    /// </summary>
    public static TConstruct WithDynamicBlock<TConstruct>(
        this TConstruct construct,
        string blockType,
        string iteratorName,
        TerraformExpression forEach,
        Action<TerraformDynamicBlockBuilder> configure)
        where TConstruct : TerraformProvisionableConstruct
    {
        var dynamicBlock = new TerraformDynamicBlock(blockType, forEach)
        {
            Iterator = iteratorName
        };
        var builder = new TerraformDynamicBlockBuilder(dynamicBlock, iteratorName);
        configure(builder);
        construct.DynamicBlocks.Add(dynamicBlock);
        return construct;
    }
}

/// <summary>
/// Builder for configuring dynamic block content with automatic identifier resolution.
/// Provides convenient access to iterator.value, iterator.key for building content expressions.
/// </summary>
public class TerraformDynamicBlockBuilder
{
    private readonly TerraformDynamicBlock _dynamicBlock;
    private readonly string _iteratorName;

    internal TerraformDynamicBlockBuilder(TerraformDynamicBlock dynamicBlock, string iteratorName)
    {
        _dynamicBlock = dynamicBlock;
        _iteratorName = iteratorName;
    }

    /// <summary>
    /// Gets an expression for the iterator (e.g., "ingress").
    /// </summary>
    public TerraformExpression Iterator => TerraformExpression.Identifier(_iteratorName);

    /// <summary>
    /// Gets an expression for iterator.value (e.g., "ingress.value").
    /// Supports indexer syntax for accessing attributes: Value["from_port"] produces "ingress.value.from_port".
    /// </summary>
    public DynamicBlockValueAccessor Value => new DynamicBlockValueAccessor(_iteratorName);

    /// <summary>
    /// Gets an expression for iterator.key (e.g., "ingress.key").
    /// </summary>
    public TerraformExpression Key => TerraformExpression.Identifier($"{_iteratorName}.key");

    /// <summary>
    /// Adds a content property to the dynamic block.
    /// </summary>
    public TerraformDynamicBlockBuilder WithContent(string name, TerraformExpression value)
    {
        _dynamicBlock.WithContent(name, value);
        return this;
    }

    /// <summary>
    /// Adds multiple content properties to the dynamic block.
    /// </summary>
    public TerraformDynamicBlockBuilder WithContent(Dictionary<string, TerraformExpression> content)
    {
        _dynamicBlock.WithContent(content);
        return this;
    }
}

/// <summary>
/// Accessor for iterator.value with indexer support for attribute access.
/// Allows syntax like: ingress.Value or ingress.Value["from_port"].
/// </summary>
public class DynamicBlockValueAccessor
{
    private readonly string _iteratorName;

    internal DynamicBlockValueAccessor(string iteratorName)
    {
        _iteratorName = iteratorName;
    }

    /// <summary>
    /// Gets an expression for a specific attribute on iterator.value (e.g., "ingress.value.from_port").
    /// </summary>
    public TerraformExpression this[string attribute] => TerraformExpression.Identifier($"{_iteratorName}.value.{attribute}");

    /// <summary>
    /// Implicitly converts to TerraformExpression representing iterator.value (e.g., "ingress.value").
    /// </summary>
    public static implicit operator TerraformExpression(DynamicBlockValueAccessor accessor)
        => TerraformExpression.Identifier($"{accessor._iteratorName}.value");
}

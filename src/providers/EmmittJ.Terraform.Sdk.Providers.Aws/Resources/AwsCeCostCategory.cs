using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsCeCostCategory.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// InheritedValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InheritedValue block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockInheritedValueBlock>? InheritedValue
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockInheritedValueBlock>>("inherited_value");
        set => SetArgument("inherited_value", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for inherited_value in AwsCeCostCategoryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockInheritedValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inherited_value";

    /// <summary>
    /// The dimension_key attribute.
    /// </summary>
    public TerraformValue<string>? DimensionKey
    {
        get => GetArgument<TerraformValue<string>>("dimension_key");
        set => SetArgument("dimension_key", value);
    }

    /// <summary>
    /// The dimension_name attribute.
    /// </summary>
    public TerraformValue<string>? DimensionName
    {
        get => GetArgument<TerraformValue<string>>("dimension_name");
        set => SetArgument("dimension_name", value);
    }

}

/// <summary>
/// Block type for rule in AwsCeCostCategoryRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockAndBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for not in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockNotBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for or in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockOrBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockAndBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for not in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockAndBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for not in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockNotBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for or in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockOrBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockNotBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for or in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockAndBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for not in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockNotBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for or in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockCostCategoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cost_category";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for dimension in AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockOrBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockOrBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for tags in AwsCeCostCategoryRuleBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeCostCategoryRuleBlockRuleBlockTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tags";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The match_options attribute.
    /// </summary>
    public TerraformSet<string>? MatchOptions
    {
        get => GetArgument<TerraformSet<string>>("match_options");
        set => SetArgument("match_options", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformSet<string>? ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for split_charge_rule in AwsCeCostCategory.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategorySplitChargeRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "split_charge_rule";

    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    public required TerraformValue<string> Method
    {
        get => GetRequiredArgument<TerraformValue<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The targets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    public required TerraformSet<string> Targets
    {
        get => GetRequiredArgument<TerraformSet<string>>("targets");
        set => SetArgument("targets", value);
    }

    /// <summary>
    /// Parameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategorySplitChargeRuleBlockParameterBlock>? Parameter
    {
        get => GetArgument<TerraformSet<AwsCeCostCategorySplitChargeRuleBlockParameterBlock>>("parameter");
        set => SetArgument("parameter", value);
    }

}

/// <summary>
/// Block type for parameter in AwsCeCostCategorySplitChargeRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeCostCategorySplitChargeRuleBlockParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameter";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ce_cost_category Terraform resource.
/// Manages a aws_ce_cost_category resource.
/// </summary>
public partial class AwsCeCostCategory(string name) : TerraformResource("aws_ce_cost_category", name)
{
    /// <summary>
    /// The default_value attribute.
    /// </summary>
    public TerraformValue<string>? DefaultValue
    {
        get => GetArgument<TerraformValue<string>>("default_value");
        set => SetArgument("default_value", value);
    }

    /// <summary>
    /// The effective_start attribute.
    /// </summary>
    public TerraformValue<string> EffectiveStart
    {
        get => GetArgument<TerraformValue<string>>("effective_start") ?? AsReference("effective_start");
        set => SetArgument("effective_start", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rule_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleVersion is required")]
    public required TerraformValue<string> RuleVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_version");
        set => SetArgument("rule_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The effective_end attribute.
    /// </summary>
    public TerraformValue<string> EffectiveEnd
        => AsReference("effective_end");

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformList<AwsCeCostCategoryRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsCeCostCategoryRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// SplitChargeRule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeCostCategorySplitChargeRuleBlock>? SplitChargeRule
    {
        get => GetArgument<TerraformSet<AwsCeCostCategorySplitChargeRuleBlock>>("split_charge_rule");
        set => SetArgument("split_charge_rule", value);
    }

}

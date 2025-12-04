using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsCeTagsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeTagsDataSourceFilterBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeTagsDataSourceFilterBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeTagsDataSourceFilterBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeTagsDataSourceFilterBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeTagsDataSourceFilterBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeTagsDataSourceFilterBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockAndBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeTagsDataSourceFilterBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockAndBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeTagsDataSourceFilterBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockAndBlockTagsBlock : TerraformBlock
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
/// Block type for cost_category in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockDimensionBlock : TerraformBlock
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
/// Block type for not in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeTagsDataSourceFilterBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockNotBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeTagsDataSourceFilterBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockNotBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeTagsDataSourceFilterBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockNotBlockTagsBlock : TerraformBlock
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
/// Block type for or in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeTagsDataSourceFilterBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeTagsDataSourceFilterBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockOrBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeTagsDataSourceFilterBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockOrBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeTagsDataSourceFilterBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockOrBlockTagsBlock : TerraformBlock
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
/// Block type for tags in AwsCeTagsDataSourceFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceFilterBlockTagsBlock : TerraformBlock
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
/// Block type for sort_by in AwsCeTagsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceSortByBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sort_by";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The sort_order attribute.
    /// </summary>
    public TerraformValue<string>? SortOrder
    {
        get => GetArgument<TerraformValue<string>>("sort_order");
        set => SetArgument("sort_order", value);
    }

}


/// <summary>
/// Block type for time_period in AwsCeTagsDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCeTagsDataSourceTimePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_period";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => GetArgument<TerraformValue<string>>("end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => GetArgument<TerraformValue<string>>("start");
        set => SetArgument("start", value);
    }

}


/// <summary>
/// Represents a aws_ce_tags Terraform data source.
/// Retrieves information about a aws_ce_tags.
/// </summary>
public partial class AwsCeTagsDataSource(string name) : TerraformDataSource("aws_ce_tags", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformValue<string>? SearchString
    {
        get => GetArgument<TerraformValue<string>>("search_string");
        set => SetArgument("search_string", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    public TerraformValue<string>? TagKey
    {
        get => GetArgument<TerraformValue<string>>("tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformSet<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsCeTagsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// SortBy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCeTagsDataSourceSortByBlock>? SortBy
    {
        get => GetArgument<TerraformList<AwsCeTagsDataSourceSortByBlock>>("sort_by");
        set => SetArgument("sort_by", value);
    }

    /// <summary>
    /// TimePeriod block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimePeriod block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePeriod block(s) allowed")]
    public required TerraformList<AwsCeTagsDataSourceTimePeriodBlock> TimePeriod
    {
        get => GetRequiredArgument<TerraformList<AwsCeTagsDataSourceTimePeriodBlock>>("time_period");
        set => SetArgument("time_period", value);
    }

}

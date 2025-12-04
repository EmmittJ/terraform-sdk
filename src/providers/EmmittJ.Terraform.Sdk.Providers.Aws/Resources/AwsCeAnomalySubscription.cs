using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for subscriber in AwsCeAnomalySubscription.
/// Nesting mode: set
/// </summary>
public class AwsCeAnomalySubscriptionSubscriberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscriber";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for threshold_expression in AwsCeAnomalySubscription.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threshold_expression";

    /// <summary>
    /// And block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock>? And
    {
        get => GetArgument<TerraformSet<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock>>("and");
        set => SetArgument("and", value);
    }

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Not block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Not block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock>? Not
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock>>("not");
        set => SetArgument("not", value);
    }

    /// <summary>
    /// Or block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock>? Or
    {
        get => GetArgument<TerraformSet<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock>>("or");
        set => SetArgument("or", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for and in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "and";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockAndBlockTagsBlock : TerraformBlock
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
/// Block type for cost_category in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockDimensionBlock : TerraformBlock
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
/// Block type for not in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockNotBlockTagsBlock : TerraformBlock
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
/// Block type for or in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: set
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or";

    /// <summary>
    /// CostCategory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CostCategory block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockCostCategoryBlock>? CostCategory
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockCostCategoryBlock>>("cost_category");
        set => SetArgument("cost_category", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dimension block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Tags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tags block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockTagsBlock>? Tags
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockTagsBlock>>("tags");
        set => SetArgument("tags", value);
    }

}

/// <summary>
/// Block type for cost_category in AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockCostCategoryBlock : TerraformBlock
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
/// Block type for dimension in AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockDimensionBlock : TerraformBlock
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
/// Block type for tags in AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockOrBlockTagsBlock : TerraformBlock
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
/// Block type for tags in AwsCeAnomalySubscriptionThresholdExpressionBlock.
/// Nesting mode: list
/// </summary>
public class AwsCeAnomalySubscriptionThresholdExpressionBlockTagsBlock : TerraformBlock
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
/// Represents a aws_ce_anomaly_subscription Terraform resource.
/// Manages a aws_ce_anomaly_subscription resource.
/// </summary>
public partial class AwsCeAnomalySubscription(string name) : TerraformResource("aws_ce_anomaly_subscription", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? AsReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
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
    /// The monitor_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorArnList is required")]
    public TerraformList<string>? MonitorArnList
    {
        get => GetArgument<TerraformList<string>>("monitor_arn_list");
        set => SetArgument("monitor_arn_list", value);
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
    /// Subscriber block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subscriber is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subscriber block(s) required")]
    public required TerraformSet<AwsCeAnomalySubscriptionSubscriberBlock> Subscriber
    {
        get => GetRequiredArgument<TerraformSet<AwsCeAnomalySubscriptionSubscriberBlock>>("subscriber");
        set => SetArgument("subscriber", value);
    }

    /// <summary>
    /// ThresholdExpression block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThresholdExpression block(s) allowed")]
    public TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlock>? ThresholdExpression
    {
        get => GetArgument<TerraformList<AwsCeAnomalySubscriptionThresholdExpressionBlock>>("threshold_expression");
        set => SetArgument("threshold_expression", value);
    }

}

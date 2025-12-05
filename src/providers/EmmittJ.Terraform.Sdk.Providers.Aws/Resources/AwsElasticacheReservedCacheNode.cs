using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsElasticacheReservedCacheNode.
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReservedCacheNodeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_elasticache_reserved_cache_node Terraform resource.
/// Manages a aws_elasticache_reserved_cache_node resource.
/// </summary>
public partial class AwsElasticacheReservedCacheNode(string name) : TerraformResource("aws_elasticache_reserved_cache_node", name)
{
    /// <summary>
    /// The cache_node_count attribute.
    /// </summary>
    public TerraformValue<double> CacheNodeCount
    {
        get => GetArgument<TerraformValue<double>>("cache_node_count") ?? CreateReference("cache_node_count");
        set => SetArgument("cache_node_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    public required TerraformValue<string> ReservedCacheNodesOfferingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("reserved_cache_nodes_offering_id");
        set => SetArgument("reserved_cache_nodes_offering_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformValue<string> CacheNodeType
        => CreateReference("cache_node_type");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string> Duration
        => CreateReference("duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
        => CreateReference("fixed_price");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformValue<string> OfferingType
        => CreateReference("offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformValue<string> ProductDescription
        => CreateReference("product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RecurringCharges
        => CreateReference("recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
        => CreateReference("start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformValue<double> UsagePrice
        => CreateReference("usage_price");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheReservedCacheNodeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheReservedCacheNodeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

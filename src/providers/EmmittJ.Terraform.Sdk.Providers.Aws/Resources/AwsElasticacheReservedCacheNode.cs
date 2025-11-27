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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<double>(this, "cache_node_count");
        set => SetArgument("cache_node_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    public required TerraformValue<string> ReservedCacheNodesOfferingId
    {
        get => new TerraformReference<string>(this, "reserved_cache_nodes_offering_id");
        set => SetArgument("reserved_cache_nodes_offering_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    public TerraformValue<string> CacheNodeType
    {
        get => new TerraformReference<string>(this, "cache_node_type");
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string> Duration
    {
        get => new TerraformReference<string>(this, "duration");
    }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    public TerraformValue<double> FixedPrice
    {
        get => new TerraformReference<double>(this, "fixed_price");
    }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    public TerraformValue<string> OfferingType
    {
        get => new TerraformReference<string>(this, "offering_type");
    }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    public TerraformValue<string> ProductDescription
    {
        get => new TerraformReference<string>(this, "product_description");
    }

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RecurringCharges
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "recurring_charges").ResolveNodes(ctx));
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    public TerraformValue<double> UsagePrice
    {
        get => new TerraformReference<double>(this, "usage_price");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticacheReservedCacheNodeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticacheReservedCacheNodeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

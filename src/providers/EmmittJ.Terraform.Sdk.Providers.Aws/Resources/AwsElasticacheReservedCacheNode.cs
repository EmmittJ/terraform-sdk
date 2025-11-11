using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReservedCacheNodeTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_reserved_cache_node resource.
/// </summary>
public class AwsElasticacheReservedCacheNode : TerraformResource
{
    public AwsElasticacheReservedCacheNode(string name) : base("aws_elasticache_reserved_cache_node", name)
    {
    }

    /// <summary>
    /// The cache_node_count attribute.
    /// </summary>
    [TerraformPropertyName("cache_node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> CacheNodeCount { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    [TerraformPropertyName("reserved_cache_nodes_offering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReservedCacheNodesOfferingId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheReservedCacheNodeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformPropertyName("cache_node_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CacheNodeType => new TerraformReference(this, "cache_node_type");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Duration => new TerraformReference(this, "duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FixedPrice => new TerraformReference(this, "fixed_price");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformPropertyName("offering_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OfferingType => new TerraformReference(this, "offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformPropertyName("product_description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductDescription => new TerraformReference(this, "product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformPropertyName("recurring_charges")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RecurringCharges => new TerraformReference(this, "recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartTime => new TerraformReference(this, "start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformPropertyName("usage_price")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UsagePrice => new TerraformReference(this, "usage_price");

}

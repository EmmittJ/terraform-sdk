using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsElasticacheReservedCacheNodeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elasticache_reserved_cache_node resource.
/// </summary>
public partial class AwsElasticacheReservedCacheNode : TerraformResource
{
    public AwsElasticacheReservedCacheNode(string name) : base("aws_elasticache_reserved_cache_node", name)
    {
    }

    /// <summary>
    /// The cache_node_count attribute.
    /// </summary>
    [TerraformProperty("cache_node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> CacheNodeCount { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    [TerraformProperty("reserved_cache_nodes_offering_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReservedCacheNodesOfferingId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsElasticacheReservedCacheNodeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformProperty("cache_node_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CacheNodeType { get; }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformProperty("duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Duration { get; }

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformProperty("fixed_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> FixedPrice { get; }

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformProperty("offering_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OfferingType { get; }

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformProperty("product_description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProductDescription { get; }

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformProperty("recurring_charges")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RecurringCharges { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformProperty("usage_price")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> UsagePrice { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticacheReservedCacheNodeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> CacheNodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cache_node_count");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The reserved_cache_nodes_offering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedCacheNodesOfferingId is required")]
    [TerraformPropertyName("reserved_cache_nodes_offering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReservedCacheNodesOfferingId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticacheReservedCacheNodeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cache_node_type attribute.
    /// </summary>
    [TerraformPropertyName("cache_node_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CacheNodeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_node_type");

    /// <summary>
    /// The duration attribute.
    /// </summary>
    [TerraformPropertyName("duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Duration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "duration");

    /// <summary>
    /// The fixed_price attribute.
    /// </summary>
    [TerraformPropertyName("fixed_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FixedPrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "fixed_price");

    /// <summary>
    /// The offering_type attribute.
    /// </summary>
    [TerraformPropertyName("offering_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OfferingType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "offering_type");

    /// <summary>
    /// The product_description attribute.
    /// </summary>
    [TerraformPropertyName("product_description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductDescription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_description");

    /// <summary>
    /// The recurring_charges attribute.
    /// </summary>
    [TerraformPropertyName("recurring_charges")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RecurringCharges => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "recurring_charges");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The usage_price attribute.
    /// </summary>
    [TerraformPropertyName("usage_price")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UsagePrice => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "usage_price");

}

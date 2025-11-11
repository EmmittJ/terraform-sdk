using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMemorydbMultiRegionClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_memorydb_multi_region_cluster resource.
/// </summary>
public partial class AwsMemorydbMultiRegionCluster : TerraformResource
{
    public AwsMemorydbMultiRegionCluster(string name) : base("aws_memorydb_multi_region_cluster", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The multi_region_cluster_name_suffix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiRegionClusterNameSuffix is required")]
    [TerraformProperty("multi_region_cluster_name_suffix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MultiRegionClusterNameSuffix { get; set; }

    /// <summary>
    /// The multi_region_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("multi_region_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MultiRegionParameterGroupName { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The num_shards attribute.
    /// </summary>
    [TerraformProperty("num_shards")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NumShards { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    [TerraformProperty("tls_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TlsEnabled { get; set; }

    /// <summary>
    /// The update_strategy attribute.
    /// </summary>
    [TerraformProperty("update_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UpdateStrategy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsMemorydbMultiRegionClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The multi_region_cluster_name attribute.
    /// </summary>
    [TerraformProperty("multi_region_cluster_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MultiRegionClusterName { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}

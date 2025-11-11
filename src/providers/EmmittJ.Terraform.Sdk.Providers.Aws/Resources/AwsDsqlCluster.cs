using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multi_region_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsDsqlClusterMultiRegionPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The clusters attribute.
    /// </summary>
    [TerraformProperty("clusters")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Clusters { get; set; }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    [TerraformProperty("witness_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WitnessRegion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDsqlClusterTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_dsql_cluster resource.
/// </summary>
public partial class AwsDsqlCluster : TerraformResource
{
    public AwsDsqlCluster(string name) : base("aws_dsql_cluster", name)
    {
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ForceDestroy { get; set; }

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    [TerraformProperty("kms_encryption_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsEncryptionKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for multi_region_properties.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("multi_region_properties")]
    public partial TerraformList<TerraformBlock<AwsDsqlClusterMultiRegionPropertiesBlock>>? MultiRegionProperties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDsqlClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    [TerraformProperty("encryption_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionDetails { get; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Identifier { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint_service_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcEndpointServiceName { get; }

}

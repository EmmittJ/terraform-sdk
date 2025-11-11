using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multi_region_properties in .
/// Nesting mode: list
/// </summary>
public class AwsDsqlClusterMultiRegionPropertiesBlock
{
    /// <summary>
    /// The clusters attribute.
    /// </summary>
    [TerraformPropertyName("clusters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Clusters { get; set; } = default!;

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    [TerraformPropertyName("witness_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WitnessRegion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDsqlClusterTimeoutsBlock
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
/// Manages a aws_dsql_cluster resource.
/// </summary>
public class AwsDsqlCluster : TerraformResource
{
    public AwsDsqlCluster(string name) : base("aws_dsql_cluster", name)
    {
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DeletionProtectionEnabled { get; set; } = default!;

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ForceDestroy { get; set; } = default!;

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_encryption_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsEncryptionKey { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for multi_region_properties.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multi_region_properties")]
    public TerraformList<TerraformBlock<AwsDsqlClusterMultiRegionPropertiesBlock>>? MultiRegionProperties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDsqlClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    [TerraformPropertyName("encryption_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionDetails => new TerraformReference(this, "encryption_details");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Identifier => new TerraformReference(this, "identifier");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_service_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcEndpointServiceName => new TerraformReference(this, "vpc_endpoint_service_name");

}

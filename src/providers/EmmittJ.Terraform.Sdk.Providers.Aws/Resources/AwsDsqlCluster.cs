using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multi_region_properties in .
/// Nesting mode: list
/// </summary>
public class AwsDsqlClusterMultiRegionPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The clusters attribute.
    /// </summary>
    [TerraformPropertyName("clusters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Clusters { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "clusters");

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    [TerraformPropertyName("witness_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WitnessRegion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDsqlClusterTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DeletionProtectionEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection_enabled");

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ForceDestroy { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "force_destroy");

    /// <summary>
    /// The kms_encryption_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_encryption_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsEncryptionKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_encryption_key");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for multi_region_properties.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("multi_region_properties")]
    public TerraformList<TerraformBlock<AwsDsqlClusterMultiRegionPropertiesBlock>>? MultiRegionProperties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDsqlClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The encryption_details attribute.
    /// </summary>
    [TerraformPropertyName("encryption_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_details");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Identifier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpc_endpoint_service_name attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_service_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointServiceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_endpoint_service_name");

}

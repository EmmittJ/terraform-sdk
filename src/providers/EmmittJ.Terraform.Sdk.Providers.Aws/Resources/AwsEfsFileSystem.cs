using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemLifecyclePolicyBlock
{
    /// <summary>
    /// The transition_to_archive attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_archive")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitionToArchive { get; set; }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_ia")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitionToIa { get; set; }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_primary_storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TransitionToPrimaryStorageClass { get; set; }

}

/// <summary>
/// Block type for protection in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemProtectionBlock
{
    /// <summary>
    /// The replication_overwrite attribute.
    /// </summary>
    [TerraformPropertyName("replication_overwrite")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ReplicationOverwrite { get; set; } = default!;

}

/// <summary>
/// Manages a aws_efs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEfsFileSystem : TerraformResource
{
    public AwsEfsFileSystem(string name) : base("aws_efs_file_system", name)
    {
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZoneName { get; set; } = default!;

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    [TerraformPropertyName("creation_token")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CreationToken { get; set; } = default!;

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Encrypted { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("performance_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PerformanceMode { get; set; } = default!;

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput_in_mibps")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ProvisionedThroughputInMibps { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ThroughputMode { get; set; }

    /// <summary>
    /// Block for lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LifecyclePolicy block(s) allowed")]
    [TerraformPropertyName("lifecycle_policy")]
    public TerraformList<TerraformBlock<AwsEfsFileSystemLifecyclePolicyBlock>>? LifecyclePolicy { get; set; }

    /// <summary>
    /// Block for protection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protection block(s) allowed")]
    [TerraformPropertyName("protection")]
    public TerraformList<TerraformBlock<AwsEfsFileSystemProtectionBlock>>? Protection { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZoneId => new TerraformReference(this, "availability_zone_id");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_mount_targets")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumberOfMountTargets => new TerraformReference(this, "number_of_mount_targets");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SizeInBytes => new TerraformReference(this, "size_in_bytes");

}

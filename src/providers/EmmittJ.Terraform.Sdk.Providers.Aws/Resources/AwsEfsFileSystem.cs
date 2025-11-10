using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemLifecyclePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The transition_to_archive attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_archive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitionToArchive { get; set; }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_ia")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitionToIa { get; set; }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    [TerraformPropertyName("transition_to_primary_storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitionToPrimaryStorageClass { get; set; }

}

/// <summary>
/// Block type for protection in .
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemProtectionBlock : ITerraformBlock
{
    /// <summary>
    /// The replication_overwrite attribute.
    /// </summary>
    [TerraformPropertyName("replication_overwrite")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReplicationOverwrite { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "replication_overwrite");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_name");

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    [TerraformPropertyName("creation_token")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CreationToken { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_token");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Encrypted { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformPropertyName("performance_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PerformanceMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "performance_mode");

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_throughput_in_mibps")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ProvisionedThroughputInMibps { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformPropertyName("throughput_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThroughputMode { get; set; }

    /// <summary>
    /// Block for lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LifecyclePolicy block(s) allowed")]
    [TerraformPropertyName("lifecycle_policy")]
    public TerraformList<TerraformBlock<AwsEfsFileSystemLifecyclePolicyBlock>>? LifecyclePolicy { get; set; } = new();

    /// <summary>
    /// Block for protection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protection block(s) allowed")]
    [TerraformPropertyName("protection")]
    public TerraformList<TerraformBlock<AwsEfsFileSystemProtectionBlock>>? Protection { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone_id");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_mount_targets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumberOfMountTargets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_mount_targets");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SizeInBytes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "size_in_bytes");

}

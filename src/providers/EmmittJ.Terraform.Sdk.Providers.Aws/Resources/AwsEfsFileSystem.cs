using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEfsFileSystemLifecyclePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The transition_to_archive attribute.
    /// </summary>
    [TerraformProperty("transition_to_archive")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitionToArchive { get; set; }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    [TerraformProperty("transition_to_ia")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitionToIa { get; set; }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    [TerraformProperty("transition_to_primary_storage_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransitionToPrimaryStorageClass { get; set; }

}

/// <summary>
/// Block type for protection in .
/// Nesting mode: list
/// </summary>
public partial class AwsEfsFileSystemProtectionBlock : TerraformBlockBase
{
    /// <summary>
    /// The replication_overwrite attribute.
    /// </summary>
    [TerraformProperty("replication_overwrite")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReplicationOverwrite { get; set; }

}

/// <summary>
/// Manages a aws_efs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEfsFileSystem : TerraformResource
{
    public AwsEfsFileSystem(string name) : base("aws_efs_file_system", name)
    {
    }

    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    [TerraformProperty("availability_zone_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZoneName { get; set; }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    [TerraformProperty("creation_token")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CreationToken { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Encrypted { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    [TerraformProperty("performance_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PerformanceMode { get; set; }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    [TerraformProperty("provisioned_throughput_in_mibps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ProvisionedThroughputInMibps { get; set; }

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
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    [TerraformProperty("throughput_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThroughputMode { get; set; }

    /// <summary>
    /// Block for lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LifecyclePolicy block(s) allowed")]
    [TerraformProperty("lifecycle_policy")]
    public partial TerraformList<TerraformBlock<AwsEfsFileSystemLifecyclePolicyBlock>>? LifecyclePolicy { get; set; }

    /// <summary>
    /// Block for protection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protection block(s) allowed")]
    [TerraformProperty("protection")]
    public partial TerraformList<TerraformBlock<AwsEfsFileSystemProtectionBlock>>? Protection { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZoneId { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    [TerraformProperty("number_of_mount_targets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfMountTargets { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    [TerraformProperty("size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SizeInBytes { get; }

}

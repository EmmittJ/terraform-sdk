using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsClusterSnapshotCopyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_rds_cluster_snapshot_copy resource.
/// </summary>
public partial class AwsRdsClusterSnapshotCopy : TerraformResource
{
    public AwsRdsClusterSnapshotCopy(string name) : base("aws_rds_cluster_snapshot_copy", name)
    {
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    [TerraformProperty("copy_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTags { get; set; }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    [TerraformProperty("destination_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationRegion { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    [TerraformProperty("presigned_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PresignedUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    [TerraformProperty("shared_accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SharedAccounts { get; set; }

    /// <summary>
    /// The source_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbClusterSnapshotIdentifier is required")]
    [TerraformProperty("source_db_cluster_snapshot_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceDbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The target_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbClusterSnapshotIdentifier is required")]
    [TerraformProperty("target_db_cluster_snapshot_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetDbClusterSnapshotIdentifier { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRdsClusterSnapshotCopyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AllocatedStorage { get; }

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("db_cluster_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbClusterSnapshotArn { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformProperty("snapshot_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotType { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

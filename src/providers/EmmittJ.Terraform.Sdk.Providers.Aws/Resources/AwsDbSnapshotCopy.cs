using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDbSnapshotCopyTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_db_snapshot_copy resource.
/// </summary>
public partial class AwsDbSnapshotCopy : TerraformResource
{
    public AwsDbSnapshotCopy(string name) : base("aws_db_snapshot_copy", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    [TerraformProperty("option_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptionGroupName { get; set; }

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
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbSnapshotIdentifier is required")]
    [TerraformProperty("source_db_snapshot_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceDbSnapshotIdentifier { get; set; }

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
    /// The target_custom_availability_zone attribute.
    /// </summary>
    [TerraformProperty("target_custom_availability_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetCustomAvailabilityZone { get; set; }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbSnapshotIdentifier is required")]
    [TerraformProperty("target_db_snapshot_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetDbSnapshotIdentifier { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDbSnapshotCopyTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AllocatedStorage { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    [TerraformProperty("db_snapshot_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbSnapshotArn { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Encrypted { get; }

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
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Iops { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    [TerraformProperty("snapshot_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotType { get; }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [TerraformProperty("source_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceRegion { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

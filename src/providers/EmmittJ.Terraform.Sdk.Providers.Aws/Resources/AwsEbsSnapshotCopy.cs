using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEbsSnapshotCopyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_ebs_snapshot_copy resource.
/// </summary>
public partial class AwsEbsSnapshotCopy : TerraformResource
{
    public AwsEbsSnapshotCopy(string name) : base("aws_ebs_snapshot_copy", name)
    {
    }

    /// <summary>
    /// The completion_duration_minutes attribute.
    /// </summary>
    [TerraformProperty("completion_duration_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CompletionDurationMinutes { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Encrypted { get; set; }

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
    /// The permanent_restore attribute.
    /// </summary>
    [TerraformProperty("permanent_restore")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PermanentRestore { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRegion is required")]
    [TerraformProperty("source_region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceRegion { get; set; }

    /// <summary>
    /// The source_snapshot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSnapshotId is required")]
    [TerraformProperty("source_snapshot_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceSnapshotId { get; set; }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformProperty("storage_tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageTier { get; set; }

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
    /// The temporary_restore_days attribute.
    /// </summary>
    [TerraformProperty("temporary_restore_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TemporaryRestoreDays { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsEbsSnapshotCopyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The data_encryption_key_id attribute.
    /// </summary>
    [TerraformProperty("data_encryption_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataEncryptionKeyId { get; }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    [TerraformProperty("outpost_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutpostArn { get; }

    /// <summary>
    /// The owner_alias attribute.
    /// </summary>
    [TerraformProperty("owner_alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAlias { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [TerraformProperty("volume_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumeId { get; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VolumeSize { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEbsSnapshotDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEbsSnapshotDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ebs_snapshot.
/// </summary>
public partial class AwsEbsSnapshotDataSource : TerraformDataSource
{
    public AwsEbsSnapshotDataSource(string name) : base("aws_ebs_snapshot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformProperty("owners")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Owners { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The restorable_by_user_ids attribute.
    /// </summary>
    [TerraformProperty("restorable_by_user_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RestorableByUserIds { get; set; }

    /// <summary>
    /// The snapshot_ids attribute.
    /// </summary>
    [TerraformProperty("snapshot_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SnapshotIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsEbsSnapshotDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEbsSnapshotDataSourceTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Encrypted { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

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
    /// The snapshot_id attribute.
    /// </summary>
    [TerraformProperty("snapshot_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SnapshotId { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The storage_tier attribute.
    /// </summary>
    [TerraformProperty("storage_tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageTier { get; }

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

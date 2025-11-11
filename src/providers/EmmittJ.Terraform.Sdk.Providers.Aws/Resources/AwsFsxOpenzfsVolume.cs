using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nfs_exports in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOpenzfsVolumeNfsExportsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for origin_snapshot in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOpenzfsVolumeOriginSnapshotBlock : TerraformBlockBase
{
    /// <summary>
    /// The copy_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyStrategy is required")]
    [TerraformProperty("copy_strategy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CopyStrategy { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    [TerraformProperty("snapshot_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SnapshotArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxOpenzfsVolumeTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_and_group_quotas in .
/// Nesting mode: set
/// </summary>
public partial class AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Id { get; set; }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    [TerraformProperty("storage_capacity_quota_gib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageCapacityQuotaGib { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_fsx_openzfs_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxOpenzfsVolume : TerraformResource
{
    public AwsFsxOpenzfsVolume(string name) : base("aws_fsx_openzfs_volume", name)
    {
    }

    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshots")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToSnapshots { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformProperty("data_compression_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    [TerraformProperty("delete_volume_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DeleteVolumeOptions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    [TerraformProperty("parent_volume_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParentVolumeId { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformProperty("read_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ReadOnly { get; set; }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    [TerraformProperty("record_size_kib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RecordSizeKib { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [TerraformProperty("storage_capacity_quota_gib")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StorageCapacityQuotaGib { get; set; }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    [TerraformProperty("storage_capacity_reservation_gib")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StorageCapacityReservationGib { get; set; }

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
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeType { get; set; }

    /// <summary>
    /// Block for nfs_exports.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    [TerraformProperty("nfs_exports")]
    public partial TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeNfsExportsBlock>>? NfsExports { get; set; }

    /// <summary>
    /// Block for origin_snapshot.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    [TerraformProperty("origin_snapshot")]
    public partial TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeOriginSnapshotBlock>>? OriginSnapshot { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFsxOpenzfsVolumeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_and_group_quotas.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("user_and_group_quotas")]
    public partial TerraformSet<TerraformBlock<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>>? UserAndGroupQuotas { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nfs_exports in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeNfsExportsBlock
{
}

/// <summary>
/// Block type for origin_snapshot in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeOriginSnapshotBlock
{
    /// <summary>
    /// The copy_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyStrategy is required")]
    [TerraformPropertyName("copy_strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CopyStrategy { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    [TerraformPropertyName("snapshot_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SnapshotArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsVolumeTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_and_group_quotas in .
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Id { get; set; }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    [TerraformPropertyName("storage_capacity_quota_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> StorageCapacityQuotaGib { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_fsx_openzfs_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOpenzfsVolume : TerraformResource
{
    public AwsFsxOpenzfsVolume(string name) : base("aws_fsx_openzfs_volume", name)
    {
    }

    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshots")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToSnapshots { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("data_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    [TerraformPropertyName("delete_volume_options")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DeleteVolumeOptions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    [TerraformPropertyName("parent_volume_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ParentVolumeId { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformPropertyName("read_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ReadOnly { get; set; } = default!;

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    [TerraformPropertyName("record_size_kib")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RecordSizeKib { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity_quota_gib")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> StorageCapacityQuotaGib { get; set; } = default!;

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity_reservation_gib")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> StorageCapacityReservationGib { get; set; } = default!;

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
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VolumeType { get; set; }

    /// <summary>
    /// Block for nfs_exports.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    [TerraformPropertyName("nfs_exports")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeNfsExportsBlock>>? NfsExports { get; set; }

    /// <summary>
    /// Block for origin_snapshot.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    [TerraformPropertyName("origin_snapshot")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeOriginSnapshotBlock>>? OriginSnapshot { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxOpenzfsVolumeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_and_group_quotas.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("user_and_group_quotas")]
    public TerraformSet<TerraformBlock<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>>? UserAndGroupQuotas { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}

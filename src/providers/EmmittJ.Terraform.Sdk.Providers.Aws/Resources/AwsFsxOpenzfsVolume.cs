using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nfs_exports in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeNfsExportsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for origin_snapshot in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeOriginSnapshotBlock : ITerraformBlock
{
    /// <summary>
    /// The copy_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyStrategy is required")]
    [TerraformPropertyName("copy_strategy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CopyStrategy { get; set; }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    [TerraformPropertyName("snapshot_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SnapshotArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsVolumeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for user_and_group_quotas in .
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Id { get; set; }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    [TerraformPropertyName("storage_capacity_quota_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> StorageCapacityQuotaGib { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToSnapshots { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("data_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataCompressionType { get; set; }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    [TerraformPropertyName("delete_volume_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DeleteVolumeOptions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    [TerraformPropertyName("parent_volume_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParentVolumeId { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformPropertyName("read_only")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ReadOnly { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "read_only");

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    [TerraformPropertyName("record_size_kib")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RecordSizeKib { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity_quota_gib")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageCapacityQuotaGib { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_capacity_quota_gib");

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity_reservation_gib")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageCapacityReservationGib { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_capacity_reservation_gib");

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
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VolumeType { get; set; }

    /// <summary>
    /// Block for nfs_exports.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    [TerraformPropertyName("nfs_exports")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeNfsExportsBlock>>? NfsExports { get; set; } = new();

    /// <summary>
    /// Block for origin_snapshot.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    [TerraformPropertyName("origin_snapshot")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsVolumeOriginSnapshotBlock>>? OriginSnapshot { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxOpenzfsVolumeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_and_group_quotas.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("user_and_group_quotas")]
    public TerraformSet<TerraformBlock<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>>? UserAndGroupQuotas { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}

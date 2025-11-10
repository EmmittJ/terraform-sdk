using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nfs_exports in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeNfsExportsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for origin_snapshot in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeOriginSnapshotBlock : TerraformBlock
{
    /// <summary>
    /// The copy_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyStrategy is required")]
    public required TerraformProperty<string> CopyStrategy
    {
        get => GetProperty<TerraformProperty<string>>("copy_strategy");
        set => WithProperty("copy_strategy", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    public required TerraformProperty<string> SnapshotArn
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_arn");
        set => WithProperty("snapshot_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsVolumeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for user_and_group_quotas in .
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<double> Id
    {
        get => GetProperty<TerraformProperty<double>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    public required TerraformProperty<double> StorageCapacityQuotaGib
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity_quota_gib");
        set => WithProperty("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_fsx_openzfs_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOpenzfsVolume : TerraformResource
{
    public AwsFsxOpenzfsVolume(string name) : base("aws_fsx_openzfs_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToSnapshots
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_snapshots");
        set => this.WithProperty("copy_tags_to_snapshots", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformProperty<string>? DataCompressionType
    {
        get => GetProperty<TerraformProperty<string>>("data_compression_type");
        set => this.WithProperty("data_compression_type", value);
    }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DeleteVolumeOptions
    {
        get => GetProperty<List<TerraformProperty<string>>>("delete_volume_options");
        set => this.WithProperty("delete_volume_options", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    public required TerraformProperty<string> ParentVolumeId
    {
        get => GetProperty<TerraformProperty<string>>("parent_volume_id");
        set => this.WithProperty("parent_volume_id", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadOnly
    {
        get => GetProperty<TerraformProperty<bool>>("read_only");
        set => this.WithProperty("read_only", value);
    }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    public TerraformProperty<double>? RecordSizeKib
    {
        get => GetProperty<TerraformProperty<double>>("record_size_kib");
        set => this.WithProperty("record_size_kib", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacityQuotaGib
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity_quota_gib");
        set => this.WithProperty("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacityReservationGib
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity_reservation_gib");
        set => this.WithProperty("storage_capacity_reservation_gib", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => this.WithProperty("volume_type", value);
    }

    /// <summary>
    /// Block for nfs_exports.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    public List<AwsFsxOpenzfsVolumeNfsExportsBlock>? NfsExports
    {
        get => GetProperty<List<AwsFsxOpenzfsVolumeNfsExportsBlock>>("nfs_exports");
        set => this.WithProperty("nfs_exports", value);
    }

    /// <summary>
    /// Block for origin_snapshot.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    public List<AwsFsxOpenzfsVolumeOriginSnapshotBlock>? OriginSnapshot
    {
        get => GetProperty<List<AwsFsxOpenzfsVolumeOriginSnapshotBlock>>("origin_snapshot");
        set => this.WithProperty("origin_snapshot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOpenzfsVolumeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFsxOpenzfsVolumeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_and_group_quotas.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>? UserAndGroupQuotas
    {
        get => GetProperty<HashSet<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>>("user_and_group_quotas");
        set => this.WithProperty("user_and_group_quotas", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

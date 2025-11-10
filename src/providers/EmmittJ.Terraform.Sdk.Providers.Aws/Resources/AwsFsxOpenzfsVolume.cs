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
        set => SetProperty("copy_strategy", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    public required TerraformProperty<string> SnapshotArn
    {
        set => SetProperty("snapshot_arn", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    public required TerraformProperty<double> StorageCapacityQuotaGib
    {
        set => SetProperty("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        SetOutput("arn");
        SetOutput("copy_tags_to_snapshots");
        SetOutput("data_compression_type");
        SetOutput("delete_volume_options");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent_volume_id");
        SetOutput("read_only");
        SetOutput("record_size_kib");
        SetOutput("region");
        SetOutput("storage_capacity_quota_gib");
        SetOutput("storage_capacity_reservation_gib");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("volume_type");
    }

    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToSnapshots
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_snapshots");
        set => SetProperty("copy_tags_to_snapshots", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformProperty<string> DataCompressionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_compression_type");
        set => SetProperty("data_compression_type", value);
    }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    public List<TerraformProperty<string>> DeleteVolumeOptions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("delete_volume_options");
        set => SetProperty("delete_volume_options", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    public required TerraformProperty<string> ParentVolumeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_volume_id");
        set => SetProperty("parent_volume_id", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformProperty<bool> ReadOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("read_only");
        set => SetProperty("read_only", value);
    }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    public TerraformProperty<double> RecordSizeKib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("record_size_kib");
        set => SetProperty("record_size_kib", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    public TerraformProperty<double> StorageCapacityQuotaGib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_capacity_quota_gib");
        set => SetProperty("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    public TerraformProperty<double> StorageCapacityReservationGib
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_capacity_reservation_gib");
        set => SetProperty("storage_capacity_reservation_gib", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string> VolumeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_type");
        set => SetProperty("volume_type", value);
    }

    /// <summary>
    /// Block for nfs_exports.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    public List<AwsFsxOpenzfsVolumeNfsExportsBlock>? NfsExports
    {
        set => SetProperty("nfs_exports", value);
    }

    /// <summary>
    /// Block for origin_snapshot.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    public List<AwsFsxOpenzfsVolumeOriginSnapshotBlock>? OriginSnapshot
    {
        set => SetProperty("origin_snapshot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOpenzfsVolumeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_and_group_quotas.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>? UserAndGroupQuotas
    {
        set => SetProperty("user_and_group_quotas", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

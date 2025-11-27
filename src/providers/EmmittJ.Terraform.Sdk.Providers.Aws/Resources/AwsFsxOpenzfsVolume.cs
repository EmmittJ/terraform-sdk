using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for nfs_exports in AwsFsxOpenzfsVolume.
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeNfsExportsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs_exports";

    /// <summary>
    /// ClientConfigurations block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientConfigurations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClientConfigurations block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 ClientConfigurations block(s) allowed")]
    public required TerraformSet<AwsFsxOpenzfsVolumeNfsExportsBlockClientConfigurationsBlock> ClientConfigurations
    {
        get => GetRequiredArgument<TerraformSet<AwsFsxOpenzfsVolumeNfsExportsBlockClientConfigurationsBlock>>("client_configurations");
        set => SetArgument("client_configurations", value);
    }

}

/// <summary>
/// Block type for client_configurations in AwsFsxOpenzfsVolumeNfsExportsBlock.
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsVolumeNfsExportsBlockClientConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_configurations";

    /// <summary>
    /// The clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Clients is required")]
    public required TerraformValue<string> Clients
    {
        get => new TerraformReference<string>(this, "clients");
        set => SetArgument("clients", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Options is required")]
    public TerraformList<string>? Options
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "options").ResolveNodes(ctx));
        set => SetArgument("options", value);
    }

}


/// <summary>
/// Block type for origin_snapshot in AwsFsxOpenzfsVolume.
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsVolumeOriginSnapshotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "origin_snapshot";

    /// <summary>
    /// The copy_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyStrategy is required")]
    public required TerraformValue<string> CopyStrategy
    {
        get => new TerraformReference<string>(this, "copy_strategy");
        set => SetArgument("copy_strategy", value);
    }

    /// <summary>
    /// The snapshot_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotArn is required")]
    public required TerraformValue<string> SnapshotArn
    {
        get => new TerraformReference<string>(this, "snapshot_arn");
        set => SetArgument("snapshot_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxOpenzfsVolume.
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsVolumeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_and_group_quotas in AwsFsxOpenzfsVolume.
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_and_group_quotas";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<double> Id
    {
        get => new TerraformReference<double>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacityQuotaGib is required")]
    public required TerraformValue<double> StorageCapacityQuotaGib
    {
        get => new TerraformReference<double>(this, "storage_capacity_quota_gib");
        set => SetArgument("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_fsx_openzfs_volume Terraform resource.
/// Manages a aws_fsx_openzfs_volume resource.
/// </summary>
public partial class AwsFsxOpenzfsVolume(string name) : TerraformResource("aws_fsx_openzfs_volume", name)
{
    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToSnapshots
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_snapshots");
        set => SetArgument("copy_tags_to_snapshots", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformValue<string>? DataCompressionType
    {
        get => new TerraformReference<string>(this, "data_compression_type");
        set => SetArgument("data_compression_type", value);
    }

    /// <summary>
    /// The delete_volume_options attribute.
    /// </summary>
    public TerraformList<string>? DeleteVolumeOptions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "delete_volume_options").ResolveNodes(ctx));
        set => SetArgument("delete_volume_options", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentVolumeId is required")]
    public required TerraformValue<string> ParentVolumeId
    {
        get => new TerraformReference<string>(this, "parent_volume_id");
        set => SetArgument("parent_volume_id", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformValue<bool> ReadOnlyAttribute
    {
        get => new TerraformReference<bool>(this, "read_only");
        set => SetArgument("read_only", value);
    }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    public TerraformValue<double>? RecordSizeKib
    {
        get => new TerraformReference<double>(this, "record_size_kib");
        set => SetArgument("record_size_kib", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The storage_capacity_quota_gib attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacityQuotaGib
    {
        get => new TerraformReference<double>(this, "storage_capacity_quota_gib");
        set => SetArgument("storage_capacity_quota_gib", value);
    }

    /// <summary>
    /// The storage_capacity_reservation_gib attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacityReservationGib
    {
        get => new TerraformReference<double>(this, "storage_capacity_reservation_gib");
        set => SetArgument("storage_capacity_reservation_gib", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// NfsExports block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    public TerraformList<AwsFsxOpenzfsVolumeNfsExportsBlock>? NfsExports
    {
        get => GetArgument<TerraformList<AwsFsxOpenzfsVolumeNfsExportsBlock>>("nfs_exports");
        set => SetArgument("nfs_exports", value);
    }

    /// <summary>
    /// OriginSnapshot block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OriginSnapshot block(s) allowed")]
    public TerraformList<AwsFsxOpenzfsVolumeOriginSnapshotBlock>? OriginSnapshot
    {
        get => GetArgument<TerraformList<AwsFsxOpenzfsVolumeOriginSnapshotBlock>>("origin_snapshot");
        set => SetArgument("origin_snapshot", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxOpenzfsVolumeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxOpenzfsVolumeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserAndGroupQuotas block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>? UserAndGroupQuotas
    {
        get => GetArgument<TerraformSet<AwsFsxOpenzfsVolumeUserAndGroupQuotasBlock>>("user_and_group_quotas");
        set => SetArgument("user_and_group_quotas", value);
    }

}

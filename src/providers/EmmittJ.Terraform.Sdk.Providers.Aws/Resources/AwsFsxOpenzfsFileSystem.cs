using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in AwsFsxOpenzfsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_iops_configuration";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for root_volume_configuration in AwsFsxOpenzfsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_volume_configuration";

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
    /// NfsExports block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NfsExports block(s) allowed")]
    public TerraformList<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlock>? NfsExports
    {
        get => GetArgument<TerraformList<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlock>>("nfs_exports");
        set => SetArgument("nfs_exports", value);
    }

    /// <summary>
    /// UserAndGroupQuotas block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockUserAndGroupQuotasBlock>? UserAndGroupQuotas
    {
        get => GetArgument<TerraformSet<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockUserAndGroupQuotasBlock>>("user_and_group_quotas");
        set => SetArgument("user_and_group_quotas", value);
    }

}

/// <summary>
/// Block type for nfs_exports in AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlock : TerraformBlock
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
    public required TerraformSet<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlockClientConfigurationsBlock> ClientConfigurations
    {
        get => GetRequiredArgument<TerraformSet<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlockClientConfigurationsBlock>>("client_configurations");
        set => SetArgument("client_configurations", value);
    }

}

/// <summary>
/// Block type for client_configurations in AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlock.
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockNfsExportsBlockClientConfigurationsBlock : TerraformBlock
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
/// Block type for user_and_group_quotas in AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlockUserAndGroupQuotasBlock : TerraformBlock
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
/// Block type for timeouts in AwsFsxOpenzfsFileSystem.
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsFileSystemTimeoutsBlock : TerraformBlock
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
/// Represents a aws_fsx_openzfs_file_system Terraform resource.
/// Manages a aws_fsx_openzfs_file_system resource.
/// </summary>
public partial class AwsFsxOpenzfsFileSystem(string name) : TerraformResource("aws_fsx_openzfs_file_system", name)
{
    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? AutomaticBackupRetentionDays
    {
        get => new TerraformReference<double>(this, "automatic_backup_retention_days");
        set => SetArgument("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformValue<string>? BackupId
    {
        get => new TerraformReference<string>(this, "backup_id");
        set => SetArgument("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToBackups
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_backups");
        set => SetArgument("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The copy_tags_to_volumes attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToVolumes
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_volumes");
        set => SetArgument("copy_tags_to_volumes", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
    {
        get => new TerraformReference<string>(this, "daily_automatic_backup_start_time");
        set => SetArgument("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The delete_options attribute.
    /// </summary>
    public TerraformSet<string>? DeleteOptions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "delete_options").ResolveNodes(ctx));
        set => SetArgument("delete_options", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    public required TerraformValue<string> DeploymentType
    {
        get => new TerraformReference<string>(this, "deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressRange
    {
        get => new TerraformReference<string>(this, "endpoint_ip_address_range");
        set => SetArgument("endpoint_ip_address_range", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformMap<string>? FinalBackupTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "final_backup_tags").ResolveNodes(ctx));
        set => SetArgument("final_backup_tags", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? PreferredSubnetId
    {
        get => new TerraformReference<string>(this, "preferred_subnet_id");
        set => SetArgument("preferred_subnet_id", value);
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
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_table_ids").ResolveNodes(ctx));
        set => SetArgument("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalBackup
    {
        get => new TerraformReference<bool>(this, "skip_final_backup");
        set => SetArgument("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformValue<double>? StorageCapacity
    {
        get => new TerraformReference<double>(this, "storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
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
    /// The throughput_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    public required TerraformValue<double> ThroughputCapacity
    {
        get => new TerraformReference<double>(this, "throughput_capacity");
        set => SetArgument("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
    {
        get => new TerraformReference<string>(this, "weekly_maintenance_start_time");
        set => SetArgument("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The endpoint_ip_address attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddress
    {
        get => new TerraformReference<string>(this, "endpoint_ip_address");
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformList<string> NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The root_volume_id attribute.
    /// </summary>
    public TerraformValue<string> RootVolumeId
    {
        get => new TerraformReference<string>(this, "root_volume_id");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// DiskIopsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock>>("disk_iops_configuration");
        set => SetArgument("disk_iops_configuration", value);
    }

    /// <summary>
    /// RootVolumeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolumeConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock>? RootVolumeConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock>>("root_volume_configuration");
        set => SetArgument("root_volume_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxOpenzfsFileSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxOpenzfsFileSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

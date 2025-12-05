using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_read_cache_configuration in AwsFsxLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemDataReadCacheConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_read_cache_configuration";

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    public required TerraformValue<string> SizingMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("sizing_mode");
        set => SetArgument("sizing_mode", value);
    }

}


/// <summary>
/// Block type for log_configuration in AwsFsxLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformValue<string> Destination
    {
        get => GetArgument<TerraformValue<string>>("destination") ?? CreateReference("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string>? Level
    {
        get => GetArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

}


/// <summary>
/// Block type for metadata_configuration in AwsFsxLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_configuration";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? CreateReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? CreateReference("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for root_squash_configuration in AwsFsxLustreFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemRootSquashConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_squash_configuration";

    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    public TerraformSet<string>? NoSquashNids
    {
        get => GetArgument<TerraformSet<string>>("no_squash_nids");
        set => SetArgument("no_squash_nids", value);
    }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    public TerraformValue<string>? RootSquash
    {
        get => GetArgument<TerraformValue<string>>("root_squash");
        set => SetArgument("root_squash", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxLustreFileSystem.
/// Nesting mode: single
/// </summary>
public class AwsFsxLustreFileSystemTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_lustre_file_system Terraform resource.
/// Manages a aws_fsx_lustre_file_system resource.
/// </summary>
public partial class AwsFsxLustreFileSystem(string name) : TerraformResource("aws_fsx_lustre_file_system", name)
{
    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    public TerraformValue<string> AutoImportPolicy
    {
        get => GetArgument<TerraformValue<string>>("auto_import_policy") ?? CreateReference("auto_import_policy");
        set => SetArgument("auto_import_policy", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> AutomaticBackupRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("automatic_backup_retention_days") ?? CreateReference("automatic_backup_retention_days");
        set => SetArgument("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformValue<string>? BackupId
    {
        get => GetArgument<TerraformValue<string>>("backup_id");
        set => SetArgument("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToBackups
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_backups");
        set => SetArgument("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
    {
        get => GetArgument<TerraformValue<string>>("daily_automatic_backup_start_time") ?? CreateReference("daily_automatic_backup_start_time");
        set => SetArgument("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformValue<string>? DataCompressionType
    {
        get => GetArgument<TerraformValue<string>>("data_compression_type");
        set => SetArgument("data_compression_type", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => GetArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    public TerraformValue<string>? DriveCacheType
    {
        get => GetArgument<TerraformValue<string>>("drive_cache_type");
        set => SetArgument("drive_cache_type", value);
    }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EfaEnabled
    {
        get => GetArgument<TerraformValue<bool>>("efa_enabled") ?? CreateReference("efa_enabled");
        set => SetArgument("efa_enabled", value);
    }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    public TerraformValue<string> ExportPath
    {
        get => GetArgument<TerraformValue<string>>("export_path") ?? CreateReference("export_path");
        set => SetArgument("export_path", value);
    }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    public TerraformValue<string> FileSystemTypeVersion
    {
        get => GetArgument<TerraformValue<string>>("file_system_type_version") ?? CreateReference("file_system_type_version");
        set => SetArgument("file_system_type_version", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformMap<string>? FinalBackupTags
    {
        get => GetArgument<TerraformMap<string>>("final_backup_tags");
        set => SetArgument("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The import_path attribute.
    /// </summary>
    public TerraformValue<string>? ImportPath
    {
        get => GetArgument<TerraformValue<string>>("import_path");
        set => SetArgument("import_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformValue<double> ImportedFileChunkSize
    {
        get => GetArgument<TerraformValue<double>>("imported_file_chunk_size") ?? CreateReference("imported_file_chunk_size");
        set => SetArgument("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? CreateReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    public TerraformValue<double>? PerUnitStorageThroughput
    {
        get => GetArgument<TerraformValue<double>>("per_unit_storage_throughput");
        set => SetArgument("per_unit_storage_throughput", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalBackup
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_backup");
        set => SetArgument("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformValue<double>? StorageCapacity
    {
        get => GetArgument<TerraformValue<double>>("storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => GetArgument<TerraformList<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformValue<double>? ThroughputCapacity
    {
        get => GetArgument<TerraformValue<double>>("throughput_capacity");
        set => SetArgument("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
    {
        get => GetArgument<TerraformValue<string>>("weekly_maintenance_start_time") ?? CreateReference("weekly_maintenance_start_time");
        set => SetArgument("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformValue<string> MountName
        => CreateReference("mount_name");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformList<string> NetworkInterfaceIds
        => CreateReference("network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// DataReadCacheConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    public TerraformList<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>? DataReadCacheConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>>("data_read_cache_configuration");
        set => SetArgument("data_read_cache_configuration", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public TerraformList<AwsFsxLustreFileSystemLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxLustreFileSystemLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

    /// <summary>
    /// MetadataConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    public TerraformList<AwsFsxLustreFileSystemMetadataConfigurationBlock>? MetadataConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxLustreFileSystemMetadataConfigurationBlock>>("metadata_configuration");
        set => SetArgument("metadata_configuration", value);
    }

    /// <summary>
    /// RootSquashConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    public TerraformList<AwsFsxLustreFileSystemRootSquashConfigurationBlock>? RootSquashConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxLustreFileSystemRootSquashConfigurationBlock>>("root_squash_configuration");
        set => SetArgument("root_squash_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxLustreFileSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxLustreFileSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

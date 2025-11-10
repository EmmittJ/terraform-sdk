using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_read_cache_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemDataReadCacheConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    public required TerraformProperty<string> SizingMode
    {
        set => SetProperty("sizing_mode", value);
    }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformProperty<string>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        set => SetProperty("level", value);
    }

}

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for root_squash_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemRootSquashConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NoSquashNids
    {
        set => SetProperty("no_squash_nids", value);
    }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    public TerraformProperty<string>? RootSquash
    {
        set => SetProperty("root_squash", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxLustreFileSystemTimeoutsBlock : TerraformBlock
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
/// Manages a aws_fsx_lustre_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxLustreFileSystem : TerraformResource
{
    public AwsFsxLustreFileSystem(string name) : base("aws_fsx_lustre_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("mount_name");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("vpc_id");
        SetOutput("auto_import_policy");
        SetOutput("automatic_backup_retention_days");
        SetOutput("backup_id");
        SetOutput("copy_tags_to_backups");
        SetOutput("daily_automatic_backup_start_time");
        SetOutput("data_compression_type");
        SetOutput("deployment_type");
        SetOutput("drive_cache_type");
        SetOutput("efa_enabled");
        SetOutput("export_path");
        SetOutput("file_system_type_version");
        SetOutput("final_backup_tags");
        SetOutput("id");
        SetOutput("import_path");
        SetOutput("imported_file_chunk_size");
        SetOutput("kms_key_id");
        SetOutput("per_unit_storage_throughput");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("skip_final_backup");
        SetOutput("storage_capacity");
        SetOutput("storage_type");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("throughput_capacity");
        SetOutput("weekly_maintenance_start_time");
    }

    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    public TerraformProperty<string> AutoImportPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_import_policy");
        set => SetProperty("auto_import_policy", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> AutomaticBackupRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("automatic_backup_retention_days");
        set => SetProperty("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformProperty<string> BackupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_id");
        set => SetProperty("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToBackups
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_backups");
        set => SetProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformProperty<string> DailyAutomaticBackupStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("daily_automatic_backup_start_time");
        set => SetProperty("daily_automatic_backup_start_time", value);
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
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_type");
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    public TerraformProperty<string> DriveCacheType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("drive_cache_type");
        set => SetProperty("drive_cache_type", value);
    }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EfaEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("efa_enabled");
        set => SetProperty("efa_enabled", value);
    }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    public TerraformProperty<string> ExportPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("export_path");
        set => SetProperty("export_path", value);
    }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    public TerraformProperty<string> FileSystemTypeVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_system_type_version");
        set => SetProperty("file_system_type_version", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> FinalBackupTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => SetProperty("final_backup_tags", value);
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
    /// The import_path attribute.
    /// </summary>
    public TerraformProperty<string> ImportPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("import_path");
        set => SetProperty("import_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double> ImportedFileChunkSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("imported_file_chunk_size");
        set => SetProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    public TerraformProperty<double> PerUnitStorageThroughput
    {
        get => GetRequiredOutput<TerraformProperty<double>>("per_unit_storage_throughput");
        set => SetProperty("per_unit_storage_throughput", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalBackup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_backup");
        set => SetProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformProperty<double> StorageCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_capacity");
        set => SetProperty("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformProperty<double> ThroughputCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput_capacity");
        set => SetProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string> WeeklyMaintenanceStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("weekly_maintenance_start_time");
        set => SetProperty("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// Block for data_read_cache_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>? DataReadCacheConfiguration
    {
        set => SetProperty("data_read_cache_configuration", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemLogConfigurationBlock>? LogConfiguration
    {
        set => SetProperty("log_configuration", value);
    }

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemMetadataConfigurationBlock>? MetadataConfiguration
    {
        set => SetProperty("metadata_configuration", value);
    }

    /// <summary>
    /// Block for root_squash_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemRootSquashConfigurationBlock>? RootSquashConfiguration
    {
        set => SetProperty("root_squash_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxLustreFileSystemTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    public TerraformExpression MountName => this["mount_name"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}

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
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    public required TerraformProperty<string> SizingMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sizing_mode");
        set => WithProperty("sizing_mode", value);
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
        get => GetProperty<TerraformProperty<string>>("destination");
        set => WithProperty("destination", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        get => GetProperty<TerraformProperty<string>>("level");
        set => WithProperty("level", value);
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
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("no_squash_nids");
        set => WithProperty("no_squash_nids", value);
    }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    public TerraformProperty<string>? RootSquash
    {
        get => GetProperty<TerraformProperty<string>>("root_squash");
        set => WithProperty("root_squash", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("mount_name");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    public TerraformProperty<string>? AutoImportPolicy
    {
        get => GetProperty<TerraformProperty<string>>("auto_import_policy");
        set => this.WithProperty("auto_import_policy", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? AutomaticBackupRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("automatic_backup_retention_days");
        set => this.WithProperty("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackupId
    {
        get => GetProperty<TerraformProperty<string>>("backup_id");
        set => this.WithProperty("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToBackups
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_backups");
        set => this.WithProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? DailyAutomaticBackupStartTime
    {
        get => GetProperty<TerraformProperty<string>>("daily_automatic_backup_start_time");
        set => this.WithProperty("daily_automatic_backup_start_time", value);
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
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentType
    {
        get => GetProperty<TerraformProperty<string>>("deployment_type");
        set => this.WithProperty("deployment_type", value);
    }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    public TerraformProperty<string>? DriveCacheType
    {
        get => GetProperty<TerraformProperty<string>>("drive_cache_type");
        set => this.WithProperty("drive_cache_type", value);
    }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EfaEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("efa_enabled");
        set => this.WithProperty("efa_enabled", value);
    }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    public TerraformProperty<string>? ExportPath
    {
        get => GetProperty<TerraformProperty<string>>("export_path");
        set => this.WithProperty("export_path", value);
    }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemTypeVersion
    {
        get => GetProperty<TerraformProperty<string>>("file_system_type_version");
        set => this.WithProperty("file_system_type_version", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? FinalBackupTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => this.WithProperty("final_backup_tags", value);
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
    /// The import_path attribute.
    /// </summary>
    public TerraformProperty<string>? ImportPath
    {
        get => GetProperty<TerraformProperty<string>>("import_path");
        set => this.WithProperty("import_path", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double>? ImportedFileChunkSize
    {
        get => GetProperty<TerraformProperty<double>>("imported_file_chunk_size");
        set => this.WithProperty("imported_file_chunk_size", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? PerUnitStorageThroughput
    {
        get => GetProperty<TerraformProperty<double>>("per_unit_storage_throughput");
        set => this.WithProperty("per_unit_storage_throughput", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalBackup
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_backup");
        set => this.WithProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacity
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity");
        set => this.WithProperty("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ThroughputCapacity
    {
        get => GetProperty<TerraformProperty<double>>("throughput_capacity");
        set => this.WithProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformProperty<string>>("weekly_maintenance_start_time");
        set => this.WithProperty("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// Block for data_read_cache_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>? DataReadCacheConfiguration
    {
        get => GetProperty<List<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>>("data_read_cache_configuration");
        set => this.WithProperty("data_read_cache_configuration", value);
    }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemLogConfigurationBlock>? LogConfiguration
    {
        get => GetProperty<List<AwsFsxLustreFileSystemLogConfigurationBlock>>("log_configuration");
        set => this.WithProperty("log_configuration", value);
    }

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemMetadataConfigurationBlock>? MetadataConfiguration
    {
        get => GetProperty<List<AwsFsxLustreFileSystemMetadataConfigurationBlock>>("metadata_configuration");
        set => this.WithProperty("metadata_configuration", value);
    }

    /// <summary>
    /// Block for root_squash_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    public List<AwsFsxLustreFileSystemRootSquashConfigurationBlock>? RootSquashConfiguration
    {
        get => GetProperty<List<AwsFsxLustreFileSystemRootSquashConfigurationBlock>>("root_squash_configuration");
        set => this.WithProperty("root_squash_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxLustreFileSystemTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFsxLustreFileSystemTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

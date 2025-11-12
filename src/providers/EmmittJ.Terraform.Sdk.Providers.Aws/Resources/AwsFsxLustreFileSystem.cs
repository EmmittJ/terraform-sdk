using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_read_cache_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxLustreFileSystemDataReadCacheConfigurationBlock() : TerraformBlock("data_read_cache_configuration")
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Size { get; set; }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    [TerraformProperty("sizing_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SizingMode { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxLustreFileSystemLogConfigurationBlock() : TerraformBlock("log_configuration")
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformProperty("destination")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Destination { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformProperty("level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Level { get; set; }

}

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxLustreFileSystemMetadataConfigurationBlock() : TerraformBlock("metadata_configuration")
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for root_squash_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxLustreFileSystemRootSquashConfigurationBlock() : TerraformBlock("root_squash_configuration")
{
    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [TerraformProperty("no_squash_nids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? NoSquashNids { get; set; }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    [TerraformProperty("root_squash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RootSquash { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxLustreFileSystemTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_fsx_lustre_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxLustreFileSystem : TerraformResource
{
    public AwsFsxLustreFileSystem(string name) : base("aws_fsx_lustre_file_system", name)
    {
    }

    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    [TerraformProperty("auto_import_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AutoImportPolicy { get; set; }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("automatic_backup_retention_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AutomaticBackupRetentionDays { get; set; }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformProperty("backup_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupId { get; set; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_backups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToBackups { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DailyAutomaticBackupStartTime { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformProperty("data_compression_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentType { get; set; }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    [TerraformProperty("drive_cache_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DriveCacheType { get; set; }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    [TerraformProperty("efa_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EfaEnabled { get; set; }

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    [TerraformProperty("export_path")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExportPath { get; set; }

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    [TerraformProperty("file_system_type_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FileSystemTypeVersion { get; set; }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    [TerraformProperty("final_backup_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? FinalBackupTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The import_path attribute.
    /// </summary>
    [TerraformProperty("import_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImportPath { get; set; }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    [TerraformProperty("imported_file_chunk_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ImportedFileChunkSize { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [TerraformProperty("per_unit_storage_throughput")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformProperty("skip_final_backup")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipFinalBackup { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformProperty("storage_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StorageCapacity { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageType { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SubnetIds { get; set; }

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
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WeeklyMaintenanceStartTime { get; set; }

    /// <summary>
    /// Block for data_read_cache_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    [TerraformProperty("data_read_cache_configuration")]
    public TerraformList<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock> DataReadCacheConfiguration { get; set; } = new();

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformProperty("log_configuration")]
    public TerraformList<AwsFsxLustreFileSystemLogConfigurationBlock> LogConfiguration { get; set; } = new();

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    [TerraformProperty("metadata_configuration")]
    public TerraformList<AwsFsxLustreFileSystemMetadataConfigurationBlock> MetadataConfiguration { get; set; } = new();

    /// <summary>
    /// Block for root_squash_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    [TerraformProperty("root_squash_configuration")]
    public TerraformList<AwsFsxLustreFileSystemRootSquashConfigurationBlock> RootSquashConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFsxLustreFileSystemTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    [TerraformProperty("mount_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MountName { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

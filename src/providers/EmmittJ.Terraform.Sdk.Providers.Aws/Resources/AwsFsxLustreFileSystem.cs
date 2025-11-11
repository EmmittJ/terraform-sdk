using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_read_cache_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemDataReadCacheConfigurationBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Size { get; set; }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    [TerraformPropertyName("sizing_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SizingMode { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemLogConfigurationBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Destination { get; set; } = default!;

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformPropertyName("level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Level { get; set; }

}

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemMetadataConfigurationBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Mode { get; set; } = default!;

}

/// <summary>
/// Block type for root_squash_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemRootSquashConfigurationBlock
{
    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [TerraformPropertyName("no_squash_nids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? NoSquashNids { get; set; }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    [TerraformPropertyName("root_squash")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RootSquash { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxLustreFileSystemTimeoutsBlock
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
/// Manages a aws_fsx_lustre_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxLustreFileSystem : TerraformResource
{
    public AwsFsxLustreFileSystem(string name) : base("aws_fsx_lustre_file_system", name)
    {
    }

    /// <summary>
    /// The auto_import_policy attribute.
    /// </summary>
    [TerraformPropertyName("auto_import_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AutoImportPolicy { get; set; } = default!;

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AutomaticBackupRetentionDays { get; set; } = default!;

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformPropertyName("backup_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackupId { get; set; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_backups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToBackups { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DailyAutomaticBackupStartTime { get; set; } = default!;

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("data_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentType { get; set; }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    [TerraformPropertyName("drive_cache_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DriveCacheType { get; set; }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    [TerraformPropertyName("efa_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EfaEnabled { get; set; } = default!;

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    [TerraformPropertyName("export_path")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ExportPath { get; set; } = default!;

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    [TerraformPropertyName("file_system_type_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> FileSystemTypeVersion { get; set; } = default!;

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    [TerraformPropertyName("final_backup_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? FinalBackupTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The import_path attribute.
    /// </summary>
    [TerraformPropertyName("import_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ImportPath { get; set; }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    [TerraformPropertyName("imported_file_chunk_size")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ImportedFileChunkSize { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("per_unit_storage_throughput")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_backup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipFinalBackup { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StorageCapacity { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageType { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? SubnetIds { get; set; }

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
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyMaintenanceStartTime { get; set; } = default!;

    /// <summary>
    /// Block for data_read_cache_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    [TerraformPropertyName("data_read_cache_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>>? DataReadCacheConfiguration { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    [TerraformPropertyName("metadata_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemMetadataConfigurationBlock>>? MetadataConfiguration { get; set; }

    /// <summary>
    /// Block for root_squash_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    [TerraformPropertyName("root_squash_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemRootSquashConfigurationBlock>>? RootSquashConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxLustreFileSystemTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    [TerraformPropertyName("mount_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MountName => new TerraformReference(this, "mount_name");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> NetworkInterfaceIds => new TerraformReference(this, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}

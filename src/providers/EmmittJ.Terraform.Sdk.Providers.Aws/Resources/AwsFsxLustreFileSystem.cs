using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_read_cache_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemDataReadCacheConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Size { get; set; }

    /// <summary>
    /// The sizing_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizingMode is required")]
    [TerraformPropertyName("sizing_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SizingMode { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemLogConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Destination { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "destination");

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformPropertyName("level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Level { get; set; }

}

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemMetadataConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

}

/// <summary>
/// Block type for root_squash_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxLustreFileSystemRootSquashConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The no_squash_nids attribute.
    /// </summary>
    [TerraformPropertyName("no_squash_nids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? NoSquashNids { get; set; }

    /// <summary>
    /// The root_squash attribute.
    /// </summary>
    [TerraformPropertyName("root_squash")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RootSquash { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxLustreFileSystemTimeoutsBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AutoImportPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auto_import_policy");

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AutomaticBackupRetentionDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "automatic_backup_retention_days");

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformPropertyName("backup_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackupId { get; set; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_backups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToBackups { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DailyAutomaticBackupStartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "daily_automatic_backup_start_time");

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("data_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataCompressionType { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentType { get; set; }

    /// <summary>
    /// The drive_cache_type attribute.
    /// </summary>
    [TerraformPropertyName("drive_cache_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DriveCacheType { get; set; }

    /// <summary>
    /// The efa_enabled attribute.
    /// </summary>
    [TerraformPropertyName("efa_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EfaEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "efa_enabled");

    /// <summary>
    /// The export_path attribute.
    /// </summary>
    [TerraformPropertyName("export_path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExportPath { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "export_path");

    /// <summary>
    /// The file_system_type_version attribute.
    /// </summary>
    [TerraformPropertyName("file_system_type_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FileSystemTypeVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "file_system_type_version");

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    [TerraformPropertyName("final_backup_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? FinalBackupTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The import_path attribute.
    /// </summary>
    [TerraformPropertyName("import_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImportPath { get; set; }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    [TerraformPropertyName("imported_file_chunk_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ImportedFileChunkSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "imported_file_chunk_size");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The per_unit_storage_throughput attribute.
    /// </summary>
    [TerraformPropertyName("per_unit_storage_throughput")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PerUnitStorageThroughput { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_backup")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFinalBackup { get; set; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StorageCapacity { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageType { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SubnetIds { get; set; }

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
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceStartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_start_time");

    /// <summary>
    /// Block for data_read_cache_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataReadCacheConfiguration block(s) allowed")]
    [TerraformPropertyName("data_read_cache_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemDataReadCacheConfigurationBlock>>? DataReadCacheConfiguration { get; set; } = new();

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemLogConfigurationBlock>>? LogConfiguration { get; set; } = new();

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataConfiguration block(s) allowed")]
    [TerraformPropertyName("metadata_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemMetadataConfigurationBlock>>? MetadataConfiguration { get; set; } = new();

    /// <summary>
    /// Block for root_squash_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootSquashConfiguration block(s) allowed")]
    [TerraformPropertyName("root_squash_configuration")]
    public TerraformList<TerraformBlock<AwsFsxLustreFileSystemRootSquashConfigurationBlock>>? RootSquashConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxLustreFileSystemTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The mount_name attribute.
    /// </summary>
    [TerraformPropertyName("mount_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mount_name");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}

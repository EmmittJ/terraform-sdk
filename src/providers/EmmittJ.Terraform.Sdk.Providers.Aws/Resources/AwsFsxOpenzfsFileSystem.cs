using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock
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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Mode { get; set; }

}

/// <summary>
/// Block type for root_volume_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock
{
    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshots")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToSnapshots { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformPropertyName("data_compression_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformPropertyName("read_only")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ReadOnly { get; set; } = default!;

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    [TerraformPropertyName("record_size_kib")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RecordSizeKib { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsFileSystemTimeoutsBlock
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
/// Manages a aws_fsx_openzfs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOpenzfsFileSystem : TerraformResource
{
    public AwsFsxOpenzfsFileSystem(string name) : base("aws_fsx_openzfs_file_system", name)
    {
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AutomaticBackupRetentionDays { get; set; }

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
    /// The copy_tags_to_volumes attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_volumes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CopyTagsToVolumes { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DailyAutomaticBackupStartTime { get; set; } = default!;

    /// <summary>
    /// The delete_options attribute.
    /// </summary>
    [TerraformPropertyName("delete_options")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DeleteOptions { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    [TerraformPropertyName("deployment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DeploymentType { get; set; }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EndpointIpAddressRange { get; set; } = default!;

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
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("preferred_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredSubnetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformPropertyName("route_table_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> RouteTableIds { get; set; } = default!;

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    [TerraformPropertyName("throughput_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WeeklyMaintenanceStartTime { get; set; } = default!;

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    [TerraformPropertyName("disk_iops_configuration")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock>>? DiskIopsConfiguration { get; set; }

    /// <summary>
    /// Block for root_volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolumeConfiguration block(s) allowed")]
    [TerraformPropertyName("root_volume_configuration")]
    public TerraformList<TerraformBlock<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock>>? RootVolumeConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxOpenzfsFileSystemTimeoutsBlock>? Timeouts { get; set; }

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
    /// The endpoint_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointIpAddress => new TerraformReference(this, "endpoint_ip_address");

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
    /// The root_volume_id attribute.
    /// </summary>
    [TerraformPropertyName("root_volume_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RootVolumeId => new TerraformReference(this, "root_volume_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}

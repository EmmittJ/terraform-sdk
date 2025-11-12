using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock() : TerraformBlock("disk_iops_configuration")
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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

}

/// <summary>
/// Block type for root_volume_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock() : TerraformBlock("root_volume_configuration")
{
    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshots")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToSnapshots { get; set; }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    [TerraformProperty("data_compression_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataCompressionType { get; set; }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    [TerraformProperty("read_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ReadOnly { get; set; }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    [TerraformProperty("record_size_kib")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RecordSizeKib { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxOpenzfsFileSystemTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_fsx_openzfs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxOpenzfsFileSystem : TerraformResource
{
    public AwsFsxOpenzfsFileSystem(string name) : base("aws_fsx_openzfs_file_system", name)
    {
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("automatic_backup_retention_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AutomaticBackupRetentionDays { get; set; }

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
    /// The copy_tags_to_volumes attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_volumes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToVolumes { get; set; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DailyAutomaticBackupStartTime { get; set; }

    /// <summary>
    /// The delete_options attribute.
    /// </summary>
    [TerraformProperty("delete_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DeleteOptions { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    [TerraformProperty("deployment_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeploymentType { get; set; }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointIpAddressRange { get; set; }

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
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformProperty("preferred_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredSubnetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [TerraformProperty("route_table_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> RouteTableIds { get; set; }

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    [TerraformProperty("throughput_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WeeklyMaintenanceStartTime { get; set; }

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    [TerraformProperty("disk_iops_configuration")]
    public TerraformList<AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock> DiskIopsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for root_volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolumeConfiguration block(s) allowed")]
    [TerraformProperty("root_volume_configuration")]
    public TerraformList<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock> RootVolumeConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFsxOpenzfsFileSystemTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The endpoint_ip_address attribute.
    /// </summary>
    [TerraformProperty("endpoint_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointIpAddress { get; }

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
    /// The root_volume_id attribute.
    /// </summary>
    [TerraformProperty("root_volume_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RootVolumeId { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

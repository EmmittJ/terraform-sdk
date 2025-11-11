using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_windows_file_system.
/// </summary>
public partial class AwsFsxWindowsFileSystemDataSource : TerraformDataSource
{
    public AwsFsxWindowsFileSystemDataSource(string name) : base("aws_fsx_windows_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformProperty("active_directory_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ActiveDirectoryId { get; }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Aliases { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    [TerraformProperty("audit_log_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AuditLogConfiguration { get; }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformProperty("automatic_backup_retention_days")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AutomaticBackupRetentionDays { get; }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformProperty("backup_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackupId { get; }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_backups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> CopyTagsToBackups { get; }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DailyAutomaticBackupStartTime { get; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentType { get; }

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    [TerraformProperty("disk_iops_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DiskIopsConfiguration { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformProperty("network_interface_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> NetworkInterfaceIds { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    [TerraformProperty("preferred_file_server_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredFileServerIp { get; }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformProperty("preferred_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredSubnetId { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroupIds { get; }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformProperty("skip_final_backup")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SkipFinalBackup { get; }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformProperty("storage_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageCapacity { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformProperty("throughput_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ThroughputCapacity { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformProperty("weekly_maintenance_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WeeklyMaintenanceStartTime { get; }

}

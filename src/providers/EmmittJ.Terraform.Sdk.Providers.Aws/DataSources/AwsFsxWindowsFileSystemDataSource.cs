using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_windows_file_system.
/// </summary>
public class AwsFsxWindowsFileSystemDataSource : TerraformDataSource
{
    public AwsFsxWindowsFileSystemDataSource(string name) : base("aws_fsx_windows_file_system", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ActiveDirectoryId => new TerraformReference(this, "active_directory_id");

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Aliases => new TerraformReference(this, "aliases");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    [TerraformPropertyName("audit_log_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuditLogConfiguration => new TerraformReference(this, "audit_log_configuration");

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutomaticBackupRetentionDays => new TerraformReference(this, "automatic_backup_retention_days");

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformPropertyName("backup_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupId => new TerraformReference(this, "backup_id");

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_backups")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CopyTagsToBackups => new TerraformReference(this, "copy_tags_to_backups");

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DailyAutomaticBackupStartTime => new TerraformReference(this, "daily_automatic_backup_start_time");

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentType => new TerraformReference(this, "deployment_type");

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DiskIopsConfiguration => new TerraformReference(this, "disk_iops_configuration");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> NetworkInterfaceIds => new TerraformReference(this, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    [TerraformPropertyName("preferred_file_server_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredFileServerIp => new TerraformReference(this, "preferred_file_server_ip");

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("preferred_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredSubnetId => new TerraformReference(this, "preferred_subnet_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_backup")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SkipFinalBackup => new TerraformReference(this, "skip_final_backup");

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageCapacity => new TerraformReference(this, "storage_capacity");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ThroughputCapacity => new TerraformReference(this, "throughput_capacity");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WeeklyMaintenanceStartTime => new TerraformReference(this, "weekly_maintenance_start_time");

}

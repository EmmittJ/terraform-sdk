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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActiveDirectoryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "active_directory_id");

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Aliases => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "aliases");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    [TerraformPropertyName("audit_log_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuditLogConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "audit_log_configuration");

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutomaticBackupRetentionDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "automatic_backup_retention_days");

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    [TerraformPropertyName("backup_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_id");

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_backups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CopyTagsToBackups => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "copy_tags_to_backups");

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformPropertyName("daily_automatic_backup_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DailyAutomaticBackupStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "daily_automatic_backup_start_time");

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_type");

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    [TerraformPropertyName("disk_iops_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DiskIopsConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "disk_iops_configuration");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    [TerraformPropertyName("preferred_file_server_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredFileServerIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_file_server_ip");

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("preferred_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_subnet_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_backup")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SkipFinalBackup => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "skip_final_backup");

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_capacity");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [TerraformPropertyName("throughput_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ThroughputCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput_capacity");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_start_time");

}

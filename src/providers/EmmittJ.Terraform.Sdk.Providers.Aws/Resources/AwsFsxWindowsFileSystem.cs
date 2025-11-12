using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audit_log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxWindowsFileSystemAuditLogConfigurationBlock() : TerraformBlock("audit_log_configuration")
{
    /// <summary>
    /// The audit_log_destination attribute.
    /// </summary>
    [TerraformProperty("audit_log_destination")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuditLogDestination { get; set; }

    /// <summary>
    /// The file_access_audit_log_level attribute.
    /// </summary>
    [TerraformProperty("file_access_audit_log_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileAccessAuditLogLevel { get; set; }

    /// <summary>
    /// The file_share_access_audit_log_level attribute.
    /// </summary>
    [TerraformProperty("file_share_access_audit_log_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileShareAccessAuditLogLevel { get; set; }

}

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxWindowsFileSystemDiskIopsConfigurationBlock() : TerraformBlock("disk_iops_configuration")
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
/// Block type for self_managed_active_directory in .
/// Nesting mode: list
/// </summary>
public partial class AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock() : TerraformBlock("self_managed_active_directory")
{
    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsIps is required")]
    [TerraformProperty("dns_ips")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DnsIps { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    [TerraformProperty("file_system_administrators_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FileSystemAdministratorsGroup { get; set; }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_distinguished_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFsxWindowsFileSystemTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_fsx_windows_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFsxWindowsFileSystem : TerraformResource
{
    public AwsFsxWindowsFileSystem(string name) : base("aws_fsx_windows_file_system", name)
    {
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformProperty("active_directory_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ActiveDirectoryId { get; set; }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Aliases { get; set; }

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
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    [TerraformProperty("daily_automatic_backup_start_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DailyAutomaticBackupStartTime { get; set; }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [TerraformProperty("deployment_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentType { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredSubnetId { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> StorageCapacity { get; set; }

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
    /// Block for audit_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogConfiguration block(s) allowed")]
    [TerraformProperty("audit_log_configuration")]
    public TerraformList<AwsFsxWindowsFileSystemAuditLogConfigurationBlock> AuditLogConfiguration { get; set; } = new();

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    [TerraformProperty("disk_iops_configuration")]
    public TerraformList<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock> DiskIopsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for self_managed_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectory block(s) allowed")]
    [TerraformProperty("self_managed_active_directory")]
    public TerraformList<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock> SelfManagedActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsFsxWindowsFileSystemTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The remote_administration_endpoint attribute.
    /// </summary>
    [TerraformProperty("remote_administration_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RemoteAdministrationEndpoint { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

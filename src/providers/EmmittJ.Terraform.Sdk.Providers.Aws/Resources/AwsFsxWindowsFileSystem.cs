using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audit_log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemAuditLogConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The audit_log_destination attribute.
    /// </summary>
    [TerraformPropertyName("audit_log_destination")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuditLogDestination { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "audit_log_destination");

    /// <summary>
    /// The file_access_audit_log_level attribute.
    /// </summary>
    [TerraformPropertyName("file_access_audit_log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileAccessAuditLogLevel { get; set; }

    /// <summary>
    /// The file_share_access_audit_log_level attribute.
    /// </summary>
    [TerraformPropertyName("file_share_access_audit_log_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileShareAccessAuditLogLevel { get; set; }

}

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemDiskIopsConfigurationBlock : ITerraformBlock
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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

}

/// <summary>
/// Block type for self_managed_active_directory in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock : ITerraformBlock
{
    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsIps is required")]
    [TerraformPropertyName("dns_ips")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DnsIps { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    [TerraformPropertyName("file_system_administrators_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileSystemAdministratorsGroup { get; set; }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_distinguished_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OrganizationalUnitDistinguishedName { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxWindowsFileSystemTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_fsx_windows_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxWindowsFileSystem : TerraformResource
{
    public AwsFsxWindowsFileSystem(string name) : base("aws_fsx_windows_file_system", name)
    {
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActiveDirectoryId { get; set; }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Aliases { get; set; }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    [TerraformPropertyName("automatic_backup_retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AutomaticBackupRetentionDays { get; set; }

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
    /// The deployment_type attribute.
    /// </summary>
    [TerraformPropertyName("deployment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentType { get; set; }

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
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("preferred_subnet_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredSubnetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_subnet_id");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_capacity");

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    [TerraformPropertyName("throughput_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ThroughputCapacity { get; set; }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    [TerraformPropertyName("weekly_maintenance_start_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WeeklyMaintenanceStartTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "weekly_maintenance_start_time");

    /// <summary>
    /// Block for audit_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogConfiguration block(s) allowed")]
    [TerraformPropertyName("audit_log_configuration")]
    public TerraformList<TerraformBlock<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>>? AuditLogConfiguration { get; set; } = new();

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    [TerraformPropertyName("disk_iops_configuration")]
    public TerraformList<TerraformBlock<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>>? DiskIopsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for self_managed_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectory block(s) allowed")]
    [TerraformPropertyName("self_managed_active_directory")]
    public TerraformList<TerraformBlock<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>>? SelfManagedActiveDirectory { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFsxWindowsFileSystemTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The remote_administration_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("remote_administration_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RemoteAdministrationEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remote_administration_endpoint");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}

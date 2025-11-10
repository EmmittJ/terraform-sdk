using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audit_log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemAuditLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The audit_log_destination attribute.
    /// </summary>
    public TerraformProperty<string>? AuditLogDestination
    {
        get => GetProperty<TerraformProperty<string>>("audit_log_destination");
        set => WithProperty("audit_log_destination", value);
    }

    /// <summary>
    /// The file_access_audit_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? FileAccessAuditLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("file_access_audit_log_level");
        set => WithProperty("file_access_audit_log_level", value);
    }

    /// <summary>
    /// The file_share_access_audit_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? FileShareAccessAuditLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("file_share_access_audit_log_level");
        set => WithProperty("file_share_access_audit_log_level", value);
    }

}

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemDiskIopsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for self_managed_active_directory in .
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsIps is required")]
    public HashSet<TerraformProperty<string>>? DnsIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("dns_ips");
        set => WithProperty("dns_ips", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemAdministratorsGroup
    {
        get => GetProperty<TerraformProperty<string>>("file_system_administrators_group");
        set => WithProperty("file_system_administrators_group", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit_distinguished_name");
        set => WithProperty("organizational_unit_distinguished_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxWindowsFileSystemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_fsx_windows_file_system resource.
/// </summary>
public class AwsFsxWindowsFileSystem : TerraformResource
{
    public AwsFsxWindowsFileSystem(string name) : base("aws_fsx_windows_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("preferred_file_server_ip");
        this.DeclareOutput("remote_administration_endpoint");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformProperty<string>? ActiveDirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("active_directory_id");
        set => this.WithProperty("active_directory_id", value);
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Aliases
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("aliases");
        set => this.WithProperty("aliases", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double>? AutomaticBackupRetentionDays
    {
        get => GetProperty<TerraformProperty<double>>("automatic_backup_retention_days");
        set => this.WithProperty("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackupId
    {
        get => GetProperty<TerraformProperty<string>>("backup_id");
        set => this.WithProperty("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToBackups
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_backups");
        set => this.WithProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? DailyAutomaticBackupStartTime
    {
        get => GetProperty<TerraformProperty<string>>("daily_automatic_backup_start_time");
        set => this.WithProperty("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentType
    {
        get => GetProperty<TerraformProperty<string>>("deployment_type");
        set => this.WithProperty("deployment_type", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? FinalBackupTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => this.WithProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("preferred_subnet_id");
        set => this.WithProperty("preferred_subnet_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipFinalBackup
    {
        get => GetProperty<TerraformProperty<bool>>("skip_final_backup");
        set => this.WithProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacity
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity");
        set => this.WithProperty("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    public required TerraformProperty<double> ThroughputCapacity
    {
        get => GetProperty<TerraformProperty<double>>("throughput_capacity");
        set => this.WithProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformProperty<string>>("weekly_maintenance_start_time");
        set => this.WithProperty("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// Block for audit_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogConfiguration block(s) allowed")]
    public List<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>? AuditLogConfiguration
    {
        get => GetProperty<List<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>>("audit_log_configuration");
        set => this.WithProperty("audit_log_configuration", value);
    }

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public List<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        get => GetProperty<List<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>>("disk_iops_configuration");
        set => this.WithProperty("disk_iops_configuration", value);
    }

    /// <summary>
    /// Block for self_managed_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectory block(s) allowed")]
    public List<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>? SelfManagedActiveDirectory
    {
        get => GetProperty<List<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>>("self_managed_active_directory");
        set => this.WithProperty("self_managed_active_directory", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxWindowsFileSystemTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFsxWindowsFileSystemTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    public TerraformExpression PreferredFileServerIp => this["preferred_file_server_ip"];

    /// <summary>
    /// The remote_administration_endpoint attribute.
    /// </summary>
    public TerraformExpression RemoteAdministrationEndpoint => this["remote_administration_endpoint"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}

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
        set => SetProperty("audit_log_destination", value);
    }

    /// <summary>
    /// The file_access_audit_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? FileAccessAuditLogLevel
    {
        set => SetProperty("file_access_audit_log_level", value);
    }

    /// <summary>
    /// The file_share_access_audit_log_level attribute.
    /// </summary>
    public TerraformProperty<string>? FileShareAccessAuditLogLevel
    {
        set => SetProperty("file_share_access_audit_log_level", value);
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
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
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
        set => SetProperty("dns_ips", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemAdministratorsGroup
    {
        set => SetProperty("file_system_administrators_group", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitDistinguishedName
    {
        set => SetProperty("organizational_unit_distinguished_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_fsx_windows_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxWindowsFileSystem : TerraformResource
{
    public AwsFsxWindowsFileSystem(string name) : base("aws_fsx_windows_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("preferred_file_server_ip");
        SetOutput("remote_administration_endpoint");
        SetOutput("vpc_id");
        SetOutput("active_directory_id");
        SetOutput("aliases");
        SetOutput("automatic_backup_retention_days");
        SetOutput("backup_id");
        SetOutput("copy_tags_to_backups");
        SetOutput("daily_automatic_backup_start_time");
        SetOutput("deployment_type");
        SetOutput("final_backup_tags");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("preferred_subnet_id");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("skip_final_backup");
        SetOutput("storage_capacity");
        SetOutput("storage_type");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("throughput_capacity");
        SetOutput("weekly_maintenance_start_time");
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformProperty<string> ActiveDirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("active_directory_id");
        set => SetProperty("active_directory_id", value);
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Aliases
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("aliases");
        set => SetProperty("aliases", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformProperty<double> AutomaticBackupRetentionDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("automatic_backup_retention_days");
        set => SetProperty("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformProperty<string> BackupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_id");
        set => SetProperty("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToBackups
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_backups");
        set => SetProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformProperty<string> DailyAutomaticBackupStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("daily_automatic_backup_start_time");
        set => SetProperty("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_type");
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> FinalBackupTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("final_backup_tags");
        set => SetProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> PreferredSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preferred_subnet_id");
        set => SetProperty("preferred_subnet_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformProperty<bool> SkipFinalBackup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_final_backup");
        set => SetProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformProperty<double> StorageCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_capacity");
        set => SetProperty("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    public required TerraformProperty<double> ThroughputCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput_capacity");
        set => SetProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformProperty<string> WeeklyMaintenanceStartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("weekly_maintenance_start_time");
        set => SetProperty("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// Block for audit_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogConfiguration block(s) allowed")]
    public List<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>? AuditLogConfiguration
    {
        set => SetProperty("audit_log_configuration", value);
    }

    /// <summary>
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public List<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        set => SetProperty("disk_iops_configuration", value);
    }

    /// <summary>
    /// Block for self_managed_active_directory.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectory block(s) allowed")]
    public List<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>? SelfManagedActiveDirectory
    {
        set => SetProperty("self_managed_active_directory", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxWindowsFileSystemTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

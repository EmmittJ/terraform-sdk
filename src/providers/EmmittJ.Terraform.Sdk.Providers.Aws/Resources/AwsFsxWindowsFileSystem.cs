using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audit_log_configuration in AwsFsxWindowsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemAuditLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audit_log_configuration";

    /// <summary>
    /// The audit_log_destination attribute.
    /// </summary>
    public TerraformValue<string> AuditLogDestination
    {
        get => GetArgument<TerraformValue<string>>("audit_log_destination") ?? AsReference("audit_log_destination");
        set => SetArgument("audit_log_destination", value);
    }

    /// <summary>
    /// The file_access_audit_log_level attribute.
    /// </summary>
    public TerraformValue<string>? FileAccessAuditLogLevel
    {
        get => GetArgument<TerraformValue<string>>("file_access_audit_log_level");
        set => SetArgument("file_access_audit_log_level", value);
    }

    /// <summary>
    /// The file_share_access_audit_log_level attribute.
    /// </summary>
    public TerraformValue<string>? FileShareAccessAuditLogLevel
    {
        get => GetArgument<TerraformValue<string>>("file_share_access_audit_log_level");
        set => SetArgument("file_share_access_audit_log_level", value);
    }

}


/// <summary>
/// Block type for disk_iops_configuration in AwsFsxWindowsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemDiskIopsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_iops_configuration";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => GetArgument<TerraformValue<double>>("iops") ?? AsReference("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for self_managed_active_directory in AwsFsxWindowsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed_active_directory";

    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsIps is required")]
    public required TerraformSet<string> DnsIps
    {
        get => GetRequiredArgument<TerraformSet<string>>("dns_ips");
        set => SetArgument("dns_ips", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The file_system_administrators_group attribute.
    /// </summary>
    public TerraformValue<string>? FileSystemAdministratorsGroup
    {
        get => GetArgument<TerraformValue<string>>("file_system_administrators_group");
        set => SetArgument("file_system_administrators_group", value);
    }

    /// <summary>
    /// The organizational_unit_distinguished_name attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitDistinguishedName
    {
        get => GetArgument<TerraformValue<string>>("organizational_unit_distinguished_name");
        set => SetArgument("organizational_unit_distinguished_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxWindowsFileSystem.
/// Nesting mode: single
/// </summary>
public class AwsFsxWindowsFileSystemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_windows_file_system Terraform resource.
/// Manages a aws_fsx_windows_file_system resource.
/// </summary>
public partial class AwsFsxWindowsFileSystem(string name) : TerraformResource("aws_fsx_windows_file_system", name)
{
    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformValue<string>? ActiveDirectoryId
    {
        get => GetArgument<TerraformValue<string>>("active_directory_id");
        set => SetArgument("active_directory_id", value);
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string>? Aliases
    {
        get => GetArgument<TerraformSet<string>>("aliases");
        set => SetArgument("aliases", value);
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? AutomaticBackupRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("automatic_backup_retention_days");
        set => SetArgument("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformValue<string>? BackupId
    {
        get => GetArgument<TerraformValue<string>>("backup_id");
        set => SetArgument("backup_id", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool>? CopyTagsToBackups
    {
        get => GetArgument<TerraformValue<bool>>("copy_tags_to_backups");
        set => SetArgument("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
    {
        get => GetArgument<TerraformValue<string>>("daily_automatic_backup_start_time") ?? AsReference("daily_automatic_backup_start_time");
        set => SetArgument("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentType
    {
        get => GetArgument<TerraformValue<string>>("deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformMap<string>? FinalBackupTags
    {
        get => GetArgument<TerraformMap<string>>("final_backup_tags");
        set => SetArgument("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? AsReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> PreferredSubnetId
    {
        get => GetArgument<TerraformValue<string>>("preferred_subnet_id") ?? AsReference("preferred_subnet_id");
        set => SetArgument("preferred_subnet_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool>? SkipFinalBackup
    {
        get => GetArgument<TerraformValue<bool>>("skip_final_backup");
        set => SetArgument("skip_final_backup", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacity
    {
        get => GetArgument<TerraformValue<double>>("storage_capacity") ?? AsReference("storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => GetArgument<TerraformList<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputCapacity is required")]
    public required TerraformValue<double> ThroughputCapacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("throughput_capacity");
        set => SetArgument("throughput_capacity", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
    {
        get => GetArgument<TerraformValue<string>>("weekly_maintenance_start_time") ?? AsReference("weekly_maintenance_start_time");
        set => SetArgument("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
        => AsReference("network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    public TerraformValue<string> PreferredFileServerIp
        => AsReference("preferred_file_server_ip");

    /// <summary>
    /// The remote_administration_endpoint attribute.
    /// </summary>
    public TerraformValue<string> RemoteAdministrationEndpoint
        => AsReference("remote_administration_endpoint");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// AuditLogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuditLogConfiguration block(s) allowed")]
    public TerraformList<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>? AuditLogConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxWindowsFileSystemAuditLogConfigurationBlock>>("audit_log_configuration");
        set => SetArgument("audit_log_configuration", value);
    }

    /// <summary>
    /// DiskIopsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public TerraformList<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxWindowsFileSystemDiskIopsConfigurationBlock>>("disk_iops_configuration");
        set => SetArgument("disk_iops_configuration", value);
    }

    /// <summary>
    /// SelfManagedActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedActiveDirectory block(s) allowed")]
    public TerraformList<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>? SelfManagedActiveDirectory
    {
        get => GetArgument<TerraformList<AwsFsxWindowsFileSystemSelfManagedActiveDirectoryBlock>>("self_managed_active_directory");
        set => SetArgument("self_managed_active_directory", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxWindowsFileSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxWindowsFileSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

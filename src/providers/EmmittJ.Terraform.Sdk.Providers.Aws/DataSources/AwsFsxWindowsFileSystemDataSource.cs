using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_fsx_windows_file_system Terraform data source.
/// Retrieves information about a aws_fsx_windows_file_system.
/// </summary>
public partial class AwsFsxWindowsFileSystemDataSource(string name) : TerraformDataSource("aws_fsx_windows_file_system", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformValue<string> ActiveDirectoryId
        => AsReference("active_directory_id");

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string> Aliases
        => AsReference("aliases");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuditLogConfiguration
        => AsReference("audit_log_configuration");

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> AutomaticBackupRetentionDays
        => AsReference("automatic_backup_retention_days");

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformValue<string> BackupId
        => AsReference("backup_id");

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool> CopyTagsToBackups
        => AsReference("copy_tags_to_backups");

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
        => AsReference("daily_automatic_backup_start_time");

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformValue<string> DeploymentType
        => AsReference("deployment_type");

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskIopsConfiguration
        => AsReference("disk_iops_configuration");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

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
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> PreferredSubnetId
        => AsReference("preferred_subnet_id");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
        => AsReference("security_group_ids");

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool> SkipFinalBackup
        => AsReference("skip_final_backup");

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacity
        => AsReference("storage_capacity");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => AsReference("storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
        => AsReference("subnet_ids");

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacity
        => AsReference("throughput_capacity");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
        => AsReference("weekly_maintenance_start_time");

}

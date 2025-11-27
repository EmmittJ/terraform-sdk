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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformValue<string> ActiveDirectoryId
    {
        get => new TerraformReference<string>(this, "active_directory_id");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string> Aliases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "aliases").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuditLogConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "audit_log_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> AutomaticBackupRetentionDays
    {
        get => new TerraformReference<double>(this, "automatic_backup_retention_days");
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformValue<string> BackupId
    {
        get => new TerraformReference<string>(this, "backup_id");
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformValue<bool> CopyTagsToBackups
    {
        get => new TerraformReference<bool>(this, "copy_tags_to_backups");
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
    {
        get => new TerraformReference<string>(this, "daily_automatic_backup_start_time");
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformValue<string> DeploymentType
    {
        get => new TerraformReference<string>(this, "deployment_type");
    }

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskIopsConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "disk_iops_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_interface_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The preferred_file_server_ip attribute.
    /// </summary>
    public TerraformValue<string> PreferredFileServerIp
    {
        get => new TerraformReference<string>(this, "preferred_file_server_ip");
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> PreferredSubnetId
    {
        get => new TerraformReference<string>(this, "preferred_subnet_id");
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformValue<bool> SkipFinalBackup
    {
        get => new TerraformReference<bool>(this, "skip_final_backup");
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformValue<double> StorageCapacity
    {
        get => new TerraformReference<double>(this, "storage_capacity");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacity
    {
        get => new TerraformReference<double>(this, "throughput_capacity");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
    {
        get => new TerraformReference<string>(this, "weekly_maintenance_start_time");
    }

}

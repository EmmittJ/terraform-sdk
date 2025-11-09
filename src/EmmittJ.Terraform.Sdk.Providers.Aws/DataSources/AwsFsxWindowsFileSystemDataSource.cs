using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_windows_file_system.
/// </summary>
public class AwsFsxWindowsFileSystemDataSource : TerraformDataSource
{
    public AwsFsxWindowsFileSystemDataSource(string name) : base("aws_fsx_windows_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_directory_id");
        this.DeclareOutput("aliases");
        this.DeclareOutput("arn");
        this.DeclareOutput("audit_log_configuration");
        this.DeclareOutput("automatic_backup_retention_days");
        this.DeclareOutput("backup_id");
        this.DeclareOutput("copy_tags_to_backups");
        this.DeclareOutput("daily_automatic_backup_start_time");
        this.DeclareOutput("deployment_type");
        this.DeclareOutput("disk_iops_configuration");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("preferred_file_server_ip");
        this.DeclareOutput("preferred_subnet_id");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("skip_final_backup");
        this.DeclareOutput("storage_capacity");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("throughput_capacity");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("weekly_maintenance_start_time");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The active_directory_id attribute.
    /// </summary>
    public TerraformExpression ActiveDirectoryId => this["active_directory_id"];

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformExpression Aliases => this["aliases"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The audit_log_configuration attribute.
    /// </summary>
    public TerraformExpression AuditLogConfiguration => this["audit_log_configuration"];

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformExpression AutomaticBackupRetentionDays => this["automatic_backup_retention_days"];

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public TerraformExpression BackupId => this["backup_id"];

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformExpression CopyTagsToBackups => this["copy_tags_to_backups"];

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformExpression DailyAutomaticBackupStartTime => this["daily_automatic_backup_start_time"];

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public TerraformExpression DeploymentType => this["deployment_type"];

    /// <summary>
    /// The disk_iops_configuration attribute.
    /// </summary>
    public TerraformExpression DiskIopsConfiguration => this["disk_iops_configuration"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

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
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformExpression PreferredSubnetId => this["preferred_subnet_id"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformExpression SkipFinalBackup => this["skip_final_backup"];

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformExpression StorageCapacity => this["storage_capacity"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformExpression ThroughputCapacity => this["throughput_capacity"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformExpression WeeklyMaintenanceStartTime => this["weekly_maintenance_start_time"];

}

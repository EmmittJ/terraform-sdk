using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? ActiveDirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_directory_id")?.Value;
        set => this.WithProperty("active_directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<string>? Aliases
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("aliases")?.Value;
        set => this.WithProperty("aliases", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public double? AutomaticBackupRetentionDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("automatic_backup_retention_days")?.Value;
        set => this.WithProperty("automatic_backup_retention_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backup_id attribute.
    /// </summary>
    public string? BackupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_id")?.Value;
        set => this.WithProperty("backup_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public bool? CopyTagsToBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_backups")?.Value;
        set => this.WithProperty("copy_tags_to_backups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public string? DailyAutomaticBackupStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("daily_automatic_backup_start_time")?.Value;
        set => this.WithProperty("daily_automatic_backup_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    public string? DeploymentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_type")?.Value;
        set => this.WithProperty("deployment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, string>? FinalBackupTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("final_backup_tags")?.Value;
        set => this.WithProperty("final_backup_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public string? PreferredSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("preferred_subnet_id")?.Value;
        set => this.WithProperty("preferred_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public bool? SkipFinalBackup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_backup")?.Value;
        set => this.WithProperty("skip_final_backup", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public double? StorageCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity")?.Value;
        set => this.WithProperty("storage_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public List<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public double? ThroughputCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_capacity")?.Value;
        set => this.WithProperty("throughput_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public string? WeeklyMaintenanceStartTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("weekly_maintenance_start_time")?.Value;
        set => this.WithProperty("weekly_maintenance_start_time", value == null ? null : new TerraformLiteralProperty<string>(value));
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

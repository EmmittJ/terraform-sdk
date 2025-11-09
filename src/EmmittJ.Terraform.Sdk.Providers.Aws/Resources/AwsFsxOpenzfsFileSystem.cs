using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_openzfs_file_system resource.
/// </summary>
public class AwsFsxOpenzfsFileSystem : TerraformResource
{
    public AwsFsxOpenzfsFileSystem(string name) : base("aws_fsx_openzfs_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("endpoint_ip_address");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("root_volume_id");
        this.DeclareOutput("vpc_id");
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
    /// The copy_tags_to_volumes attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToVolumes
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_volumes");
        set => this.WithProperty("copy_tags_to_volumes", value);
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
    /// The delete_options attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DeleteOptions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("delete_options");
        set => this.WithProperty("delete_options", value);
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
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointIpAddressRange
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_ip_address_range");
        set => this.WithProperty("endpoint_ip_address_range", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? FinalBackupTags
    {
        get => GetProperty<TerraformMapProperty<string>>("final_backup_tags");
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
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RouteTableIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("route_table_ids");
        set => this.WithProperty("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
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
    public TerraformProperty<List<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ThroughputCapacity
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The endpoint_ip_address attribute.
    /// </summary>
    public TerraformExpression EndpointIpAddress => this["endpoint_ip_address"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The root_volume_id attribute.
    /// </summary>
    public TerraformExpression RootVolumeId => this["root_volume_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}

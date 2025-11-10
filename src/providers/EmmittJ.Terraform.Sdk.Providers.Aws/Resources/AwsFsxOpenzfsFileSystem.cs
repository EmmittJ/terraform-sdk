using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock : TerraformBlock
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
/// Block type for root_volume_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The copy_tags_to_snapshots attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTagsToSnapshots
    {
        set => SetProperty("copy_tags_to_snapshots", value);
    }

    /// <summary>
    /// The data_compression_type attribute.
    /// </summary>
    public TerraformProperty<string>? DataCompressionType
    {
        set => SetProperty("data_compression_type", value);
    }

    /// <summary>
    /// The read_only attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadOnly
    {
        set => SetProperty("read_only", value);
    }

    /// <summary>
    /// The record_size_kib attribute.
    /// </summary>
    public TerraformProperty<double>? RecordSizeKib
    {
        set => SetProperty("record_size_kib", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOpenzfsFileSystemTimeoutsBlock : TerraformBlock
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
/// Manages a aws_fsx_openzfs_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOpenzfsFileSystem : TerraformResource
{
    public AwsFsxOpenzfsFileSystem(string name) : base("aws_fsx_openzfs_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("endpoint_ip_address");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("root_volume_id");
        SetOutput("vpc_id");
        SetOutput("automatic_backup_retention_days");
        SetOutput("backup_id");
        SetOutput("copy_tags_to_backups");
        SetOutput("copy_tags_to_volumes");
        SetOutput("daily_automatic_backup_start_time");
        SetOutput("delete_options");
        SetOutput("deployment_type");
        SetOutput("endpoint_ip_address_range");
        SetOutput("final_backup_tags");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("preferred_subnet_id");
        SetOutput("region");
        SetOutput("route_table_ids");
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
    /// The copy_tags_to_volumes attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTagsToVolumes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags_to_volumes");
        set => SetProperty("copy_tags_to_volumes", value);
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
    /// The delete_options attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DeleteOptions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("delete_options");
        set => SetProperty("delete_options", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    public required TerraformProperty<string> DeploymentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_type");
        set => SetProperty("deployment_type", value);
    }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformProperty<string> EndpointIpAddressRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_ip_address_range");
        set => SetProperty("endpoint_ip_address_range", value);
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
    /// The route_table_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RouteTableIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("route_table_ids");
        set => SetProperty("route_table_ids", value);
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
    /// Block for disk_iops_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public List<AwsFsxOpenzfsFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        set => SetProperty("disk_iops_configuration", value);
    }

    /// <summary>
    /// Block for root_volume_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RootVolumeConfiguration block(s) allowed")]
    public List<AwsFsxOpenzfsFileSystemRootVolumeConfigurationBlock>? RootVolumeConfiguration
    {
        set => SetProperty("root_volume_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOpenzfsFileSystemTimeoutsBlock? Timeouts
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapFileSystemDiskIopsConfigurationBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapFileSystemTimeoutsBlock : TerraformBlock
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
/// Manages a aws_fsx_ontap_file_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFsxOntapFileSystem : TerraformResource
{
    public AwsFsxOntapFileSystem(string name) : base("aws_fsx_ontap_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("endpoints");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("vpc_id");
        SetOutput("automatic_backup_retention_days");
        SetOutput("daily_automatic_backup_start_time");
        SetOutput("deployment_type");
        SetOutput("endpoint_ip_address_range");
        SetOutput("fsx_admin_password");
        SetOutput("ha_pairs");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("preferred_subnet_id");
        SetOutput("region");
        SetOutput("route_table_ids");
        SetOutput("security_group_ids");
        SetOutput("storage_capacity");
        SetOutput("storage_type");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("throughput_capacity");
        SetOutput("throughput_capacity_per_ha_pair");
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
    /// The fsx_admin_password attribute.
    /// </summary>
    public TerraformProperty<string> FsxAdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fsx_admin_password");
        set => SetProperty("fsx_admin_password", value);
    }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    public TerraformProperty<double> HaPairs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ha_pairs");
        set => SetProperty("ha_pairs", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredSubnetId is required")]
    public required TerraformProperty<string> PreferredSubnetId
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
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformProperty<double> StorageCapacity
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
    public TerraformProperty<double> ThroughputCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput_capacity");
        set => SetProperty("throughput_capacity", value);
    }

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    public TerraformProperty<double> ThroughputCapacityPerHaPair
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput_capacity_per_ha_pair");
        set => SetProperty("throughput_capacity_per_ha_pair", value);
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
    public List<AwsFsxOntapFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        set => SetProperty("disk_iops_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxOntapFileSystemTimeoutsBlock? Timeouts
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
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}

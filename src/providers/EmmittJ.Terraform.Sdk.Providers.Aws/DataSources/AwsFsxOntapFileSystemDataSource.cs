using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fsx_ontap_file_system.
/// </summary>
public class AwsFsxOntapFileSystemDataSource : TerraformDataSource
{
    public AwsFsxOntapFileSystemDataSource(string name) : base("aws_fsx_ontap_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("automatic_backup_retention_days");
        SetOutput("daily_automatic_backup_start_time");
        SetOutput("deployment_type");
        SetOutput("disk_iops_configuration");
        SetOutput("dns_name");
        SetOutput("endpoint_ip_address_range");
        SetOutput("endpoints");
        SetOutput("ha_pairs");
        SetOutput("kms_key_id");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("preferred_subnet_id");
        SetOutput("route_table_ids");
        SetOutput("storage_capacity");
        SetOutput("storage_type");
        SetOutput("subnet_ids");
        SetOutput("throughput_capacity");
        SetOutput("throughput_capacity_per_ha_pair");
        SetOutput("vpc_id");
        SetOutput("weekly_maintenance_start_time");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformExpression AutomaticBackupRetentionDays => this["automatic_backup_retention_days"];

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
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformExpression EndpointIpAddressRange => this["endpoint_ip_address_range"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    public TerraformExpression HaPairs => this["ha_pairs"];

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
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformExpression PreferredSubnetId => this["preferred_subnet_id"];

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformExpression RouteTableIds => this["route_table_ids"];

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
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    public TerraformExpression ThroughputCapacityPerHaPair => this["throughput_capacity_per_ha_pair"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformExpression WeeklyMaintenanceStartTime => this["weekly_maintenance_start_time"];

}

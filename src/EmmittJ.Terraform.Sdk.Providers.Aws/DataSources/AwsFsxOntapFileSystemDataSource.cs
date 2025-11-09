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
        this.DeclareOutput("arn");
        this.DeclareOutput("automatic_backup_retention_days");
        this.DeclareOutput("daily_automatic_backup_start_time");
        this.DeclareOutput("deployment_type");
        this.DeclareOutput("disk_iops_configuration");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("endpoint_ip_address_range");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("ha_pairs");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("preferred_subnet_id");
        this.DeclareOutput("route_table_ids");
        this.DeclareOutput("storage_capacity");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("throughput_capacity");
        this.DeclareOutput("throughput_capacity_per_ha_pair");
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

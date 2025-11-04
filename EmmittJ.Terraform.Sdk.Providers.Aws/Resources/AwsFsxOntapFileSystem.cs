using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_ontap_file_system resource.
/// </summary>
public class AwsFsxOntapFileSystem : TerraformResource
{
    public AwsFsxOntapFileSystem(string name) : base("aws_fsx_ontap_file_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("endpoints");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
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
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public string? EndpointIpAddressRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_ip_address_range")?.Value;
        set => this.WithProperty("endpoint_ip_address_range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fsx_admin_password attribute.
    /// </summary>
    public string? FsxAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fsx_admin_password")?.Value;
        set => this.WithProperty("fsx_admin_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    public double? HaPairs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ha_pairs")?.Value;
        set => this.WithProperty("ha_pairs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public HashSet<string>? RouteTableIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("route_table_ids")?.Value;
        set => this.WithProperty("route_table_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    public double? ThroughputCapacityPerHaPair
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_capacity_per_ha_pair")?.Value;
        set => this.WithProperty("throughput_capacity_per_ha_pair", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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

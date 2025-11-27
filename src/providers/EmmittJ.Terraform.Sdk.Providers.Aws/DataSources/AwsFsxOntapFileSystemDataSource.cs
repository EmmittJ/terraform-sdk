using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_fsx_ontap_file_system Terraform data source.
/// Retrieves information about a aws_fsx_ontap_file_system.
/// </summary>
public partial class AwsFsxOntapFileSystemDataSource(string name) : TerraformDataSource("aws_fsx_ontap_file_system", name)
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double> AutomaticBackupRetentionDays
    {
        get => new TerraformReference<double>(this, "automatic_backup_retention_days");
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
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressRange
    {
        get => new TerraformReference<string>(this, "endpoint_ip_address_range");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    public TerraformValue<double> HaPairs
    {
        get => new TerraformReference<double>(this, "ha_pairs");
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
    public TerraformList<string> NetworkInterfaceIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "network_interface_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> PreferredSubnetId
    {
        get => new TerraformReference<string>(this, "preferred_subnet_id");
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_table_ids").ResolveNodes(ctx));
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
    public TerraformList<string> SubnetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnet_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacity
    {
        get => new TerraformReference<double>(this, "throughput_capacity");
    }

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacityPerHaPair
    {
        get => new TerraformReference<double>(this, "throughput_capacity_per_ha_pair");
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for disk_iops_configuration in AwsFsxOntapFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsFsxOntapFileSystemDiskIopsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_iops_configuration";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFsxOntapFileSystem.
/// Nesting mode: single
/// </summary>
public class AwsFsxOntapFileSystemTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_fsx_ontap_file_system Terraform resource.
/// Manages a aws_fsx_ontap_file_system resource.
/// </summary>
public partial class AwsFsxOntapFileSystem(string name) : TerraformResource("aws_fsx_ontap_file_system", name)
{
    /// <summary>
    /// The automatic_backup_retention_days attribute.
    /// </summary>
    public TerraformValue<double>? AutomaticBackupRetentionDays
    {
        get => new TerraformReference<double>(this, "automatic_backup_retention_days");
        set => SetArgument("automatic_backup_retention_days", value);
    }

    /// <summary>
    /// The daily_automatic_backup_start_time attribute.
    /// </summary>
    public TerraformValue<string> DailyAutomaticBackupStartTime
    {
        get => new TerraformReference<string>(this, "daily_automatic_backup_start_time");
        set => SetArgument("daily_automatic_backup_start_time", value);
    }

    /// <summary>
    /// The deployment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentType is required")]
    public required TerraformValue<string> DeploymentType
    {
        get => new TerraformReference<string>(this, "deployment_type");
        set => SetArgument("deployment_type", value);
    }

    /// <summary>
    /// The endpoint_ip_address_range attribute.
    /// </summary>
    public TerraformValue<string> EndpointIpAddressRange
    {
        get => new TerraformReference<string>(this, "endpoint_ip_address_range");
        set => SetArgument("endpoint_ip_address_range", value);
    }

    /// <summary>
    /// The fsx_admin_password attribute.
    /// </summary>
    public TerraformValue<string>? FsxAdminPassword
    {
        get => new TerraformReference<string>(this, "fsx_admin_password");
        set => SetArgument("fsx_admin_password", value);
    }

    /// <summary>
    /// The ha_pairs attribute.
    /// </summary>
    public TerraformValue<double> HaPairs
    {
        get => new TerraformReference<double>(this, "ha_pairs");
        set => SetArgument("ha_pairs", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The preferred_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredSubnetId is required")]
    public required TerraformValue<string> PreferredSubnetId
    {
        get => new TerraformReference<string>(this, "preferred_subnet_id");
        set => SetArgument("preferred_subnet_id", value);
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
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_table_ids").ResolveNodes(ctx));
        set => SetArgument("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCapacity is required")]
    public required TerraformValue<double> StorageCapacity
    {
        get => new TerraformReference<double>(this, "storage_capacity");
        set => SetArgument("storage_capacity", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public TerraformList<string>? SubnetIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput_capacity attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacity
    {
        get => new TerraformReference<double>(this, "throughput_capacity");
        set => SetArgument("throughput_capacity", value);
    }

    /// <summary>
    /// The throughput_capacity_per_ha_pair attribute.
    /// </summary>
    public TerraformValue<double> ThroughputCapacityPerHaPair
    {
        get => new TerraformReference<double>(this, "throughput_capacity_per_ha_pair");
        set => SetArgument("throughput_capacity_per_ha_pair", value);
    }

    /// <summary>
    /// The weekly_maintenance_start_time attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceStartTime
    {
        get => new TerraformReference<string>(this, "weekly_maintenance_start_time");
        set => SetArgument("weekly_maintenance_start_time", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoints
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoints").ResolveNodes(ctx));
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// DiskIopsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskIopsConfiguration block(s) allowed")]
    public TerraformList<AwsFsxOntapFileSystemDiskIopsConfigurationBlock>? DiskIopsConfiguration
    {
        get => GetArgument<TerraformList<AwsFsxOntapFileSystemDiskIopsConfigurationBlock>>("disk_iops_configuration");
        set => SetArgument("disk_iops_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFsxOntapFileSystemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFsxOntapFileSystemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

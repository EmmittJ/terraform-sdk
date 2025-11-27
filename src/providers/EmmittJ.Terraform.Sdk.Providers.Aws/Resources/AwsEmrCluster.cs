using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_termination_policy in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterAutoTerminationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_termination_policy";

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeout
    {
        get => new TerraformReference<double>(this, "idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

}


/// <summary>
/// Block type for bootstrap_action in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterBootstrapActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bootstrap_action";

    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

}


/// <summary>
/// Block type for core_instance_fleet in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "core_instance_fleet";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_on_demand_capacity");
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedSpotCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_spot_capacity");
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "target_on_demand_capacity");
        set => SetArgument("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetSpotCapacity
    {
        get => new TerraformReference<double>(this, "target_spot_capacity");
        set => SetArgument("target_spot_capacity", value);
    }

    /// <summary>
    /// InstanceTypeConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlock>? InstanceTypeConfigs
    {
        get => GetArgument<TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlock>>("instance_type_configs");
        set => SetArgument("instance_type_configs", value);
    }

    /// <summary>
    /// LaunchSpecifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    public TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlock>? LaunchSpecifications
    {
        get => GetArgument<TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlock>>("launch_specifications");
        set => SetArgument("launch_specifications", value);
    }

}

/// <summary>
/// Block type for instance_type_configs in AwsEmrClusterCoreInstanceFleetBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_type_configs";

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => new TerraformReference<string>(this, "bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? BidPriceAsPercentageOfOnDemandPrice
    {
        get => new TerraformReference<double>(this, "bid_price_as_percentage_of_on_demand_price");
        set => SetArgument("bid_price_as_percentage_of_on_demand_price", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WeightedCapacity
    {
        get => new TerraformReference<double>(this, "weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// Configurations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock>? Configurations
    {
        get => GetArgument<TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock>>("configurations");
        set => SetArgument("configurations", value);
    }

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}

/// <summary>
/// Block type for configurations in AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configurations";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformValue<string>? Classification
    {
        get => new TerraformReference<string>(this, "classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for ebs_config in AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => new TerraformReference<double>(this, "volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}

/// <summary>
/// Block type for launch_specifications in AwsEmrClusterCoreInstanceFleetBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_specifications";

    /// <summary>
    /// OnDemandSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock>? OnDemandSpecification
    {
        get => GetArgument<TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock>>("on_demand_specification");
        set => SetArgument("on_demand_specification", value);
    }

    /// <summary>
    /// SpotSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock>? SpotSpecification
    {
        get => GetArgument<TerraformList<AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock>>("spot_specification");
        set => SetArgument("spot_specification", value);
    }

}

/// <summary>
/// Block type for on_demand_specification in AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

}

/// <summary>
/// Block type for spot_specification in AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The block_duration_minutes attribute.
    /// </summary>
    public TerraformValue<double>? BlockDurationMinutes
    {
        get => new TerraformReference<double>(this, "block_duration_minutes");
        set => SetArgument("block_duration_minutes", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutAction is required")]
    public required TerraformValue<string> TimeoutAction
    {
        get => new TerraformReference<string>(this, "timeout_action");
        set => SetArgument("timeout_action", value);
    }

    /// <summary>
    /// The timeout_duration_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutDurationMinutes is required")]
    public required TerraformValue<double> TimeoutDurationMinutes
    {
        get => new TerraformReference<double>(this, "timeout_duration_minutes");
        set => SetArgument("timeout_duration_minutes", value);
    }

}


/// <summary>
/// Block type for core_instance_group in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "core_instance_group";

    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    public TerraformValue<string>? AutoscalingPolicy
    {
        get => new TerraformReference<string>(this, "autoscaling_policy");
        set => SetArgument("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => new TerraformReference<string>(this, "bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterCoreInstanceGroupBlockEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrClusterCoreInstanceGroupBlockEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}

/// <summary>
/// Block type for ebs_config in AwsEmrClusterCoreInstanceGroupBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterCoreInstanceGroupBlockEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => new TerraformReference<double>(this, "volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}


/// <summary>
/// Block type for ec2_attributes in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterEc2AttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_attributes";

    /// <summary>
    /// The additional_master_security_groups attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalMasterSecurityGroups
    {
        get => new TerraformReference<string>(this, "additional_master_security_groups");
        set => SetArgument("additional_master_security_groups", value);
    }

    /// <summary>
    /// The additional_slave_security_groups attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalSlaveSecurityGroups
    {
        get => new TerraformReference<string>(this, "additional_slave_security_groups");
        set => SetArgument("additional_slave_security_groups", value);
    }

    /// <summary>
    /// The emr_managed_master_security_group attribute.
    /// </summary>
    public TerraformValue<string> EmrManagedMasterSecurityGroup
    {
        get => new TerraformReference<string>(this, "emr_managed_master_security_group");
        set => SetArgument("emr_managed_master_security_group", value);
    }

    /// <summary>
    /// The emr_managed_slave_security_group attribute.
    /// </summary>
    public TerraformValue<string> EmrManagedSlaveSecurityGroup
    {
        get => new TerraformReference<string>(this, "emr_managed_slave_security_group");
        set => SetArgument("emr_managed_slave_security_group", value);
    }

    /// <summary>
    /// The instance_profile attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfile is required")]
    public required TerraformValue<string> InstanceProfile
    {
        get => new TerraformReference<string>(this, "instance_profile");
        set => SetArgument("instance_profile", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string>? KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The service_access_security_group attribute.
    /// </summary>
    public TerraformValue<string> ServiceAccessSecurityGroup
    {
        get => new TerraformReference<string>(this, "service_access_security_group");
        set => SetArgument("service_access_security_group", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for kerberos_attributes in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterKerberosAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kerberos_attributes";

    /// <summary>
    /// The ad_domain_join_password attribute.
    /// </summary>
    public TerraformValue<string>? AdDomainJoinPassword
    {
        get => new TerraformReference<string>(this, "ad_domain_join_password");
        set => SetArgument("ad_domain_join_password", value);
    }

    /// <summary>
    /// The ad_domain_join_user attribute.
    /// </summary>
    public TerraformValue<string>? AdDomainJoinUser
    {
        get => new TerraformReference<string>(this, "ad_domain_join_user");
        set => SetArgument("ad_domain_join_user", value);
    }

    /// <summary>
    /// The cross_realm_trust_principal_password attribute.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustPrincipalPassword
    {
        get => new TerraformReference<string>(this, "cross_realm_trust_principal_password");
        set => SetArgument("cross_realm_trust_principal_password", value);
    }

    /// <summary>
    /// The kdc_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KdcAdminPassword is required")]
    public required TerraformValue<string> KdcAdminPassword
    {
        get => new TerraformReference<string>(this, "kdc_admin_password");
        set => SetArgument("kdc_admin_password", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Realm is required")]
    public required TerraformValue<string> Realm
    {
        get => new TerraformReference<string>(this, "realm");
        set => SetArgument("realm", value);
    }

}


/// <summary>
/// Block type for master_instance_fleet in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_instance_fleet";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_on_demand_capacity");
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double> ProvisionedSpotCapacity
    {
        get => new TerraformReference<double>(this, "provisioned_spot_capacity");
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetOnDemandCapacity
    {
        get => new TerraformReference<double>(this, "target_on_demand_capacity");
        set => SetArgument("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformValue<double>? TargetSpotCapacity
    {
        get => new TerraformReference<double>(this, "target_spot_capacity");
        set => SetArgument("target_spot_capacity", value);
    }

    /// <summary>
    /// InstanceTypeConfigs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlock>? InstanceTypeConfigs
    {
        get => GetArgument<TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlock>>("instance_type_configs");
        set => SetArgument("instance_type_configs", value);
    }

    /// <summary>
    /// LaunchSpecifications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    public TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlock>? LaunchSpecifications
    {
        get => GetArgument<TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlock>>("launch_specifications");
        set => SetArgument("launch_specifications", value);
    }

}

/// <summary>
/// Block type for instance_type_configs in AwsEmrClusterMasterInstanceFleetBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_type_configs";

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => new TerraformReference<string>(this, "bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    public TerraformValue<double>? BidPriceAsPercentageOfOnDemandPrice
    {
        get => new TerraformReference<double>(this, "bid_price_as_percentage_of_on_demand_price");
        set => SetArgument("bid_price_as_percentage_of_on_demand_price", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<double>? WeightedCapacity
    {
        get => new TerraformReference<double>(this, "weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// Configurations block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock>? Configurations
    {
        get => GetArgument<TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock>>("configurations");
        set => SetArgument("configurations", value);
    }

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}

/// <summary>
/// Block type for configurations in AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configurations";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformValue<string>? Classification
    {
        get => new TerraformReference<string>(this, "classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for ebs_config in AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockInstanceTypeConfigsBlockEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => new TerraformReference<double>(this, "volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}

/// <summary>
/// Block type for launch_specifications in AwsEmrClusterMasterInstanceFleetBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_specifications";

    /// <summary>
    /// OnDemandSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock>? OnDemandSpecification
    {
        get => GetArgument<TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock>>("on_demand_specification");
        set => SetArgument("on_demand_specification", value);
    }

    /// <summary>
    /// SpotSpecification block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock>? SpotSpecification
    {
        get => GetArgument<TerraformList<AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock>>("spot_specification");
        set => SetArgument("spot_specification", value);
    }

}

/// <summary>
/// Block type for on_demand_specification in AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockOnDemandSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "on_demand_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

}

/// <summary>
/// Block type for spot_specification in AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlockLaunchSpecificationsBlockSpotSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_specification";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationStrategy is required")]
    public required TerraformValue<string> AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The block_duration_minutes attribute.
    /// </summary>
    public TerraformValue<double>? BlockDurationMinutes
    {
        get => new TerraformReference<double>(this, "block_duration_minutes");
        set => SetArgument("block_duration_minutes", value);
    }

    /// <summary>
    /// The timeout_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutAction is required")]
    public required TerraformValue<string> TimeoutAction
    {
        get => new TerraformReference<string>(this, "timeout_action");
        set => SetArgument("timeout_action", value);
    }

    /// <summary>
    /// The timeout_duration_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutDurationMinutes is required")]
    public required TerraformValue<double> TimeoutDurationMinutes
    {
        get => new TerraformReference<double>(this, "timeout_duration_minutes");
        set => SetArgument("timeout_duration_minutes", value);
    }

}


/// <summary>
/// Block type for master_instance_group in AwsEmrCluster.
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_instance_group";

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformValue<string>? BidPrice
    {
        get => new TerraformReference<string>(this, "bid_price");
        set => SetArgument("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// EbsConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrClusterMasterInstanceGroupBlockEbsConfigBlock>? EbsConfig
    {
        get => GetArgument<TerraformSet<AwsEmrClusterMasterInstanceGroupBlockEbsConfigBlock>>("ebs_config");
        set => SetArgument("ebs_config", value);
    }

}

/// <summary>
/// Block type for ebs_config in AwsEmrClusterMasterInstanceGroupBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrClusterMasterInstanceGroupBlockEbsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_config";

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volumes_per_instance attribute.
    /// </summary>
    public TerraformValue<double>? VolumesPerInstance
    {
        get => new TerraformReference<double>(this, "volumes_per_instance");
        set => SetArgument("volumes_per_instance", value);
    }

}


/// <summary>
/// Represents a aws_emr_cluster Terraform resource.
/// Manages a aws_emr_cluster resource.
/// </summary>
public partial class AwsEmrCluster(string name) : TerraformResource("aws_emr_cluster", name)
{
    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    public TerraformValue<string>? AdditionalInfo
    {
        get => new TerraformReference<string>(this, "additional_info");
        set => SetArgument("additional_info", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformSet<string>? Applications
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "applications").ResolveNodes(ctx));
        set => SetArgument("applications", value);
    }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    public TerraformValue<string>? AutoscalingRole
    {
        get => new TerraformReference<string>(this, "autoscaling_role");
        set => SetArgument("autoscaling_role", value);
    }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    public TerraformValue<string>? Configurations
    {
        get => new TerraformReference<string>(this, "configurations");
        set => SetArgument("configurations", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationsJson
    {
        get => new TerraformReference<string>(this, "configurations_json");
        set => SetArgument("configurations_json", value);
    }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomAmiId
    {
        get => new TerraformReference<string>(this, "custom_ami_id");
        set => SetArgument("custom_ami_id", value);
    }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    public TerraformValue<double>? EbsRootVolumeSize
    {
        get => new TerraformReference<double>(this, "ebs_root_volume_size");
        set => SetArgument("ebs_root_volume_size", value);
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
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    public TerraformValue<bool> KeepJobFlowAliveWhenNoSteps
    {
        get => new TerraformReference<bool>(this, "keep_job_flow_alive_when_no_steps");
        set => SetArgument("keep_job_flow_alive_when_no_steps", value);
    }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    public TerraformSet<string>? ListStepsStates
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "list_steps_states").ResolveNodes(ctx));
        set => SetArgument("list_steps_states", value);
    }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? LogEncryptionKmsKeyId
    {
        get => new TerraformReference<string>(this, "log_encryption_kms_key_id");
        set => SetArgument("log_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public TerraformValue<string>? LogUri
    {
        get => new TerraformReference<string>(this, "log_uri");
        set => SetArgument("log_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_release_label attribute.
    /// </summary>
    public TerraformValue<string>? OsReleaseLabel
    {
        get => new TerraformReference<string>(this, "os_release_label");
        set => SetArgument("os_release_label", value);
    }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? PlacementGroupConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "placement_group_config").ResolveNodes(ctx));
        set => SetArgument("placement_group_config", value);
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
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformValue<string> ReleaseLabel
    {
        get => new TerraformReference<string>(this, "release_label");
        set => SetArgument("release_label", value);
    }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    public TerraformValue<string> ScaleDownBehavior
    {
        get => new TerraformReference<string>(this, "scale_down_behavior");
        set => SetArgument("scale_down_behavior", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformValue<string>? SecurityConfiguration
    {
        get => new TerraformReference<string>(this, "security_configuration");
        set => SetArgument("security_configuration", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformValue<string> ServiceRole
    {
        get => new TerraformReference<string>(this, "service_role");
        set => SetArgument("service_role", value);
    }

    /// <summary>
    /// The step attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Step
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "step").ResolveNodes(ctx));
        set => SetArgument("step", value);
    }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    public TerraformValue<double>? StepConcurrencyLevel
    {
        get => new TerraformReference<double>(this, "step_concurrency_level");
        set => SetArgument("step_concurrency_level", value);
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
    /// The termination_protection attribute.
    /// </summary>
    public TerraformValue<bool> TerminationProtection
    {
        get => new TerraformReference<bool>(this, "termination_protection");
        set => SetArgument("termination_protection", value);
    }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    public TerraformValue<bool>? UnhealthyNodeReplacement
    {
        get => new TerraformReference<bool>(this, "unhealthy_node_replacement");
        set => SetArgument("unhealthy_node_replacement", value);
    }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    public TerraformValue<bool>? VisibleToAllUsers
    {
        get => new TerraformReference<bool>(this, "visible_to_all_users");
        set => SetArgument("visible_to_all_users", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformValue<string> ClusterState
    {
        get => new TerraformReference<string>(this, "cluster_state");
    }

    /// <summary>
    /// The master_public_dns attribute.
    /// </summary>
    public TerraformValue<string> MasterPublicDns
    {
        get => new TerraformReference<string>(this, "master_public_dns");
    }

    /// <summary>
    /// AutoTerminationPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTerminationPolicy block(s) allowed")]
    public TerraformList<AwsEmrClusterAutoTerminationPolicyBlock>? AutoTerminationPolicy
    {
        get => GetArgument<TerraformList<AwsEmrClusterAutoTerminationPolicyBlock>>("auto_termination_policy");
        set => SetArgument("auto_termination_policy", value);
    }

    /// <summary>
    /// BootstrapAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrClusterBootstrapActionBlock>? BootstrapAction
    {
        get => GetArgument<TerraformList<AwsEmrClusterBootstrapActionBlock>>("bootstrap_action");
        set => SetArgument("bootstrap_action", value);
    }

    /// <summary>
    /// CoreInstanceFleet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceFleet block(s) allowed")]
    public TerraformList<AwsEmrClusterCoreInstanceFleetBlock>? CoreInstanceFleet
    {
        get => GetArgument<TerraformList<AwsEmrClusterCoreInstanceFleetBlock>>("core_instance_fleet");
        set => SetArgument("core_instance_fleet", value);
    }

    /// <summary>
    /// CoreInstanceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceGroup block(s) allowed")]
    public TerraformList<AwsEmrClusterCoreInstanceGroupBlock>? CoreInstanceGroup
    {
        get => GetArgument<TerraformList<AwsEmrClusterCoreInstanceGroupBlock>>("core_instance_group");
        set => SetArgument("core_instance_group", value);
    }

    /// <summary>
    /// Ec2Attributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Attributes block(s) allowed")]
    public TerraformList<AwsEmrClusterEc2AttributesBlock>? Ec2Attributes
    {
        get => GetArgument<TerraformList<AwsEmrClusterEc2AttributesBlock>>("ec2_attributes");
        set => SetArgument("ec2_attributes", value);
    }

    /// <summary>
    /// KerberosAttributes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAttributes block(s) allowed")]
    public TerraformList<AwsEmrClusterKerberosAttributesBlock>? KerberosAttributes
    {
        get => GetArgument<TerraformList<AwsEmrClusterKerberosAttributesBlock>>("kerberos_attributes");
        set => SetArgument("kerberos_attributes", value);
    }

    /// <summary>
    /// MasterInstanceFleet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceFleet block(s) allowed")]
    public TerraformList<AwsEmrClusterMasterInstanceFleetBlock>? MasterInstanceFleet
    {
        get => GetArgument<TerraformList<AwsEmrClusterMasterInstanceFleetBlock>>("master_instance_fleet");
        set => SetArgument("master_instance_fleet", value);
    }

    /// <summary>
    /// MasterInstanceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceGroup block(s) allowed")]
    public TerraformList<AwsEmrClusterMasterInstanceGroupBlock>? MasterInstanceGroup
    {
        get => GetArgument<TerraformList<AwsEmrClusterMasterInstanceGroupBlock>>("master_instance_group");
        set => SetArgument("master_instance_group", value);
    }

}

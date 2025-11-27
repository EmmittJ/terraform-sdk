using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for launch_specification in AwsSpotFleetRequest.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_specification";

    /// <summary>
    /// The ami attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ami is required")]
    public required TerraformValue<string> Ami
    {
        get => new TerraformReference<string>(this, "ami");
        set => SetArgument("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool>? AssociatePublicIpAddress
    {
        get => new TerraformReference<bool>(this, "associate_public_ip_address");
        set => SetArgument("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool>? EbsOptimized
    {
        get => new TerraformReference<bool>(this, "ebs_optimized");
        set => SetArgument("ebs_optimized", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string>? IamInstanceProfile
    {
        get => new TerraformReference<string>(this, "iam_instance_profile");
        set => SetArgument("iam_instance_profile", value);
    }

    /// <summary>
    /// The iam_instance_profile_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamInstanceProfileArn
    {
        get => new TerraformReference<string>(this, "iam_instance_profile_arn");
        set => SetArgument("iam_instance_profile_arn", value);
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
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformValue<bool>? Monitoring
    {
        get => new TerraformReference<bool>(this, "monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string> PlacementGroup
    {
        get => new TerraformReference<string>(this, "placement_group");
        set => SetArgument("placement_group", value);
    }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformValue<string>? PlacementTenancy
    {
        get => new TerraformReference<string>(this, "placement_tenancy");
        set => SetArgument("placement_tenancy", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string>? SpotPrice
    {
        get => new TerraformReference<string>(this, "spot_price");
        set => SetArgument("spot_price", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string>? UserData
    {
        get => new TerraformReference<string>(this, "user_data");
        set => SetArgument("user_data", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<string>? WeightedCapacity
    {
        get => new TerraformReference<string>(this, "weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// EbsBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockEbsBlockDeviceBlock>? EbsBlockDevice
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockEbsBlockDeviceBlock>>("ebs_block_device");
        set => SetArgument("ebs_block_device", value);
    }

    /// <summary>
    /// EphemeralBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockEphemeralBlockDeviceBlock>? EphemeralBlockDevice
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockEphemeralBlockDeviceBlock>>("ephemeral_block_device");
        set => SetArgument("ephemeral_block_device", value);
    }

    /// <summary>
    /// RootBlockDevice block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockRootBlockDeviceBlock>? RootBlockDevice
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlockRootBlockDeviceBlock>>("root_block_device");
        set => SetArgument("root_block_device", value);
    }

}

/// <summary>
/// Block type for ebs_block_device in AwsSpotFleetRequestLaunchSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlockEbsBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
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
    /// The snapshot_id attribute.
    /// </summary>
    public TerraformValue<string> SnapshotId
    {
        get => new TerraformReference<string>(this, "snapshot_id");
        set => SetArgument("snapshot_id", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}

/// <summary>
/// Block type for ephemeral_block_device in AwsSpotFleetRequestLaunchSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlockEphemeralBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_block_device";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualName is required")]
    public required TerraformValue<string> VirtualName
    {
        get => new TerraformReference<string>(this, "virtual_name");
        set => SetArgument("virtual_name", value);
    }

}

/// <summary>
/// Block type for root_block_device in AwsSpotFleetRequestLaunchSpecificationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchSpecificationBlockRootBlockDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "root_block_device";

    /// <summary>
    /// The delete_on_termination attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteOnTermination
    {
        get => new TerraformReference<bool>(this, "delete_on_termination");
        set => SetArgument("delete_on_termination", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
        set => SetArgument("iops", value);
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
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double> Throughput
    {
        get => new TerraformReference<double>(this, "throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double> VolumeSize
    {
        get => new TerraformReference<double>(this, "volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for launch_template_config in AwsSpotFleetRequest.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_config";

    /// <summary>
    /// LaunchTemplateSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplateSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplateSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplateSpecification block(s) allowed")]
    public required TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock> LaunchTemplateSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock>>("launch_template_specification");
        set => SetArgument("launch_template_specification", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

}

/// <summary>
/// Block type for launch_template_specification in AwsSpotFleetRequestLaunchTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockLaunchTemplateSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template_specification";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for overrides in AwsSpotFleetRequestLaunchTemplateConfigBlock.
/// Nesting mode: set
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overrides";

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string> SpotPrice
    {
        get => new TerraformReference<string>(this, "spot_price");
        set => SetArgument("spot_price", value);
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
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<double> WeightedCapacity
    {
        get => new TerraformReference<double>(this, "weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

    /// <summary>
    /// InstanceRequirements block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceRequirements block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock>? InstanceRequirements
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock>>("instance_requirements");
        set => SetArgument("instance_requirements", value);
    }

}

/// <summary>
/// Block type for instance_requirements in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_requirements";

    /// <summary>
    /// The accelerator_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorManufacturers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_manufacturers").ResolveNodes(ctx));
        set => SetArgument("accelerator_manufacturers", value);
    }

    /// <summary>
    /// The accelerator_names attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_names").ResolveNodes(ctx));
        set => SetArgument("accelerator_names", value);
    }

    /// <summary>
    /// The accelerator_types attribute.
    /// </summary>
    public TerraformSet<string>? AcceleratorTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accelerator_types").ResolveNodes(ctx));
        set => SetArgument("accelerator_types", value);
    }

    /// <summary>
    /// The allowed_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? AllowedInstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_instance_types").ResolveNodes(ctx));
        set => SetArgument("allowed_instance_types", value);
    }

    /// <summary>
    /// The bare_metal attribute.
    /// </summary>
    public TerraformValue<string>? BareMetal
    {
        get => new TerraformReference<string>(this, "bare_metal");
        set => SetArgument("bare_metal", value);
    }

    /// <summary>
    /// The burstable_performance attribute.
    /// </summary>
    public TerraformValue<string>? BurstablePerformance
    {
        get => new TerraformReference<string>(this, "burstable_performance");
        set => SetArgument("burstable_performance", value);
    }

    /// <summary>
    /// The cpu_manufacturers attribute.
    /// </summary>
    public TerraformSet<string>? CpuManufacturers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cpu_manufacturers").ResolveNodes(ctx));
        set => SetArgument("cpu_manufacturers", value);
    }

    /// <summary>
    /// The excluded_instance_types attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedInstanceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "excluded_instance_types").ResolveNodes(ctx));
        set => SetArgument("excluded_instance_types", value);
    }

    /// <summary>
    /// The instance_generations attribute.
    /// </summary>
    public TerraformSet<string>? InstanceGenerations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "instance_generations").ResolveNodes(ctx));
        set => SetArgument("instance_generations", value);
    }

    /// <summary>
    /// The local_storage attribute.
    /// </summary>
    public TerraformValue<string>? LocalStorage
    {
        get => new TerraformReference<string>(this, "local_storage");
        set => SetArgument("local_storage", value);
    }

    /// <summary>
    /// The local_storage_types attribute.
    /// </summary>
    public TerraformSet<string>? LocalStorageTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_storage_types").ResolveNodes(ctx));
        set => SetArgument("local_storage_types", value);
    }

    /// <summary>
    /// The on_demand_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandMaxPricePercentageOverLowestPrice
    {
        get => new TerraformReference<double>(this, "on_demand_max_price_percentage_over_lowest_price");
        set => SetArgument("on_demand_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// The require_hibernate_support attribute.
    /// </summary>
    public TerraformValue<bool>? RequireHibernateSupport
    {
        get => new TerraformReference<bool>(this, "require_hibernate_support");
        set => SetArgument("require_hibernate_support", value);
    }

    /// <summary>
    /// The spot_max_price_percentage_over_lowest_price attribute.
    /// </summary>
    public TerraformValue<double>? SpotMaxPricePercentageOverLowestPrice
    {
        get => new TerraformReference<double>(this, "spot_max_price_percentage_over_lowest_price");
        set => SetArgument("spot_max_price_percentage_over_lowest_price", value);
    }

    /// <summary>
    /// AcceleratorCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorCount block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorCountBlock>? AcceleratorCount
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorCountBlock>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// AcceleratorTotalMemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorTotalMemoryMib block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>? AcceleratorTotalMemoryMib
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock>>("accelerator_total_memory_mib");
        set => SetArgument("accelerator_total_memory_mib", value);
    }

    /// <summary>
    /// BaselineEbsBandwidthMbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaselineEbsBandwidthMbps block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>? BaselineEbsBandwidthMbps
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock>>("baseline_ebs_bandwidth_mbps");
        set => SetArgument("baseline_ebs_bandwidth_mbps", value);
    }

    /// <summary>
    /// MemoryGibPerVcpu block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryGibPerVcpu block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>? MemoryGibPerVcpu
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock>>("memory_gib_per_vcpu");
        set => SetArgument("memory_gib_per_vcpu", value);
    }

    /// <summary>
    /// MemoryMib block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MemoryMib block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryMibBlock>? MemoryMib
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryMibBlock>>("memory_mib");
        set => SetArgument("memory_mib", value);
    }

    /// <summary>
    /// NetworkBandwidthGbps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkBandwidthGbps block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>? NetworkBandwidthGbps
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock>>("network_bandwidth_gbps");
        set => SetArgument("network_bandwidth_gbps", value);
    }

    /// <summary>
    /// NetworkInterfaceCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInterfaceCount block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>? NetworkInterfaceCount
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkInterfaceCountBlock>>("network_interface_count");
        set => SetArgument("network_interface_count", value);
    }

    /// <summary>
    /// TotalLocalStorageGb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotalLocalStorageGb block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>? TotalLocalStorageGb
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockTotalLocalStorageGbBlock>>("total_local_storage_gb");
        set => SetArgument("total_local_storage_gb", value);
    }

    /// <summary>
    /// VcpuCount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VcpuCount block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockVcpuCountBlock>? VcpuCount
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockVcpuCountBlock>>("vcpu_count");
        set => SetArgument("vcpu_count", value);
    }

}

/// <summary>
/// Block type for accelerator_count in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for accelerator_total_memory_mib in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockAcceleratorTotalMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_total_memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for baseline_ebs_bandwidth_mbps in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockBaselineEbsBandwidthMbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "baseline_ebs_bandwidth_mbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_gib_per_vcpu in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryGibPerVcpuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_gib_per_vcpu";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for memory_mib in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockMemoryMibBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "memory_mib";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_bandwidth_gbps in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkBandwidthGbpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_bandwidth_gbps";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for network_interface_count in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockNetworkInterfaceCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interface_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for total_local_storage_gb in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockTotalLocalStorageGbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "total_local_storage_gb";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for vcpu_count in AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestLaunchTemplateConfigBlockOverridesBlockInstanceRequirementsBlockVcpuCountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vcpu_count";

    /// <summary>
    /// The max attribute.
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => new TerraformReference<double>(this, "max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// The min attribute.
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => new TerraformReference<double>(this, "min");
        set => SetArgument("min", value);
    }

}


/// <summary>
/// Block type for spot_maintenance_strategies in AwsSpotFleetRequest.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestSpotMaintenanceStrategiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spot_maintenance_strategies";

    /// <summary>
    /// CapacityRebalance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityRebalance block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestSpotMaintenanceStrategiesBlockCapacityRebalanceBlock>? CapacityRebalance
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestSpotMaintenanceStrategiesBlockCapacityRebalanceBlock>>("capacity_rebalance");
        set => SetArgument("capacity_rebalance", value);
    }

}

/// <summary>
/// Block type for capacity_rebalance in AwsSpotFleetRequestSpotMaintenanceStrategiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSpotFleetRequestSpotMaintenanceStrategiesBlockCapacityRebalanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_rebalance";

    /// <summary>
    /// The replacement_strategy attribute.
    /// </summary>
    public TerraformValue<string>? ReplacementStrategy
    {
        get => new TerraformReference<string>(this, "replacement_strategy");
        set => SetArgument("replacement_strategy", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSpotFleetRequest.
/// Nesting mode: single
/// </summary>
public class AwsSpotFleetRequestTimeoutsBlock : TerraformBlock
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
/// Represents a aws_spot_fleet_request Terraform resource.
/// Manages a aws_spot_fleet_request resource.
/// </summary>
public partial class AwsSpotFleetRequest(string name) : TerraformResource("aws_spot_fleet_request", name)
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AllocationStrategy
    {
        get => new TerraformReference<string>(this, "allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformValue<string>? Context
    {
        get => new TerraformReference<string>(this, "context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public TerraformValue<string>? ExcessCapacityTerminationPolicy
    {
        get => new TerraformReference<string>(this, "excess_capacity_termination_policy");
        set => SetArgument("excess_capacity_termination_policy", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformValue<string>? FleetType
    {
        get => new TerraformReference<string>(this, "fleet_type");
        set => SetArgument("fleet_type", value);
    }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamFleetRole is required")]
    public required TerraformValue<string> IamFleetRole
    {
        get => new TerraformReference<string>(this, "iam_fleet_role");
        set => SetArgument("iam_fleet_role", value);
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
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    public TerraformValue<string>? InstanceInterruptionBehaviour
    {
        get => new TerraformReference<string>(this, "instance_interruption_behaviour");
        set => SetArgument("instance_interruption_behaviour", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformValue<double>? InstancePoolsToUseCount
    {
        get => new TerraformReference<double>(this, "instance_pools_to_use_count");
        set => SetArgument("instance_pools_to_use_count", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancers").ResolveNodes(ctx));
        set => SetArgument("load_balancers", value);
    }

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string>? OnDemandAllocationStrategy
    {
        get => new TerraformReference<string>(this, "on_demand_allocation_strategy");
        set => SetArgument("on_demand_allocation_strategy", value);
    }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    public TerraformValue<string>? OnDemandMaxTotalPrice
    {
        get => new TerraformReference<string>(this, "on_demand_max_total_price");
        set => SetArgument("on_demand_max_total_price", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformValue<double>? OnDemandTargetCapacity
    {
        get => new TerraformReference<double>(this, "on_demand_target_capacity");
        set => SetArgument("on_demand_target_capacity", value);
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
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public TerraformValue<bool>? ReplaceUnhealthyInstances
    {
        get => new TerraformReference<bool>(this, "replace_unhealthy_instances");
        set => SetArgument("replace_unhealthy_instances", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string>? SpotPrice
    {
        get => new TerraformReference<string>(this, "spot_price");
        set => SetArgument("spot_price", value);
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
    /// The target_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetCapacity is required")]
    public required TerraformValue<double> TargetCapacity
    {
        get => new TerraformReference<double>(this, "target_capacity");
        set => SetArgument("target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetCapacityUnitType
    {
        get => new TerraformReference<string>(this, "target_capacity_unit_type");
        set => SetArgument("target_capacity_unit_type", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformSet<string> TargetGroupArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "target_group_arns").ResolveNodes(ctx));
        set => SetArgument("target_group_arns", value);
    }

    /// <summary>
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    public TerraformValue<string>? TerminateInstancesOnDelete
    {
        get => new TerraformReference<string>(this, "terminate_instances_on_delete");
        set => SetArgument("terminate_instances_on_delete", value);
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public TerraformValue<bool>? TerminateInstancesWithExpiration
    {
        get => new TerraformReference<bool>(this, "terminate_instances_with_expiration");
        set => SetArgument("terminate_instances_with_expiration", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformValue<string>? ValidFrom
    {
        get => new TerraformReference<string>(this, "valid_from");
        set => SetArgument("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformValue<string>? ValidUntil
    {
        get => new TerraformReference<string>(this, "valid_until");
        set => SetArgument("valid_until", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForFulfillment
    {
        get => new TerraformReference<bool>(this, "wait_for_fulfillment");
        set => SetArgument("wait_for_fulfillment", value);
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformValue<string> ClientToken
    {
        get => new TerraformReference<string>(this, "client_token");
    }

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    public TerraformValue<string> SpotRequestState
    {
        get => new TerraformReference<string>(this, "spot_request_state");
    }

    /// <summary>
    /// LaunchSpecification block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlock>? LaunchSpecification
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchSpecificationBlock>>("launch_specification");
        set => SetArgument("launch_specification", value);
    }

    /// <summary>
    /// LaunchTemplateConfig block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSpotFleetRequestLaunchTemplateConfigBlock>? LaunchTemplateConfig
    {
        get => GetArgument<TerraformSet<AwsSpotFleetRequestLaunchTemplateConfigBlock>>("launch_template_config");
        set => SetArgument("launch_template_config", value);
    }

    /// <summary>
    /// SpotMaintenanceStrategies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotMaintenanceStrategies block(s) allowed")]
    public TerraformList<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>? SpotMaintenanceStrategies
    {
        get => GetArgument<TerraformList<AwsSpotFleetRequestSpotMaintenanceStrategiesBlock>>("spot_maintenance_strategies");
        set => SetArgument("spot_maintenance_strategies", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSpotFleetRequestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSpotFleetRequestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

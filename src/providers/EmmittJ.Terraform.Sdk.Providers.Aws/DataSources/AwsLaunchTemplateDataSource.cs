using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsLaunchTemplateDataSource.
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLaunchTemplateDataSource.
/// Nesting mode: single
/// </summary>
public class AwsLaunchTemplateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_launch_template Terraform data source.
/// Retrieves information about a aws_launch_template.
/// </summary>
public partial class AwsLaunchTemplateDataSource(string name) : TerraformDataSource("aws_launch_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BlockDeviceMappings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "block_device_mappings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CapacityReservationSpecification
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "capacity_reservation_specification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CpuOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cpu_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "credit_specification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<double> DefaultVersion
    {
        get => new TerraformReference<double>(this, "default_version");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
    {
        get => new TerraformReference<bool>(this, "disable_api_stop");
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
    {
        get => new TerraformReference<bool>(this, "disable_api_termination");
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimized
    {
        get => new TerraformReference<string>(this, "ebs_optimized");
    }

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "enclave_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HibernationOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hibernation_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IamInstanceProfile
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "iam_instance_profile").ResolveNodes(ctx));
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformValue<string> InstanceInitiatedShutdownBehavior
    {
        get => new TerraformReference<string>(this, "instance_initiated_shutdown_behavior");
    }

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMarketOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_market_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceRequirements
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_requirements").ResolveNodes(ctx));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string> KernelId
    {
        get => new TerraformReference<string>(this, "kernel_id");
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
    }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<double> LatestVersion
    {
        get => new TerraformReference<double>(this, "latest_version");
    }

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LicenseSpecification
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "license_specification").ResolveNodes(ctx));
    }

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "metadata_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Monitoring
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "monitoring").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterfaces
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_interfaces").ResolveNodes(ctx));
    }

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "placement").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "private_dns_name_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformValue<string> RamDiskId
    {
        get => new TerraformReference<string>(this, "ram_disk_id");
    }

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TagSpecifications
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "tag_specifications").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
    {
        get => new TerraformReference<string>(this, "user_data");
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLaunchTemplateDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsLaunchTemplateDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLaunchTemplateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLaunchTemplateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

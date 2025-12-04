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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BlockDeviceMappings
        => AsReference("block_device_mappings");

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CapacityReservationSpecification
        => AsReference("capacity_reservation_specification");

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CpuOptions
        => AsReference("cpu_options");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
        => AsReference("credit_specification");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<double> DefaultVersion
        => AsReference("default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
        => AsReference("disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
        => AsReference("disable_api_termination");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimized
        => AsReference("ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
        => AsReference("enclave_options");

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HibernationOptions
        => AsReference("hibernation_options");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IamInstanceProfile
        => AsReference("iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => AsReference("image_id");

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformValue<string> InstanceInitiatedShutdownBehavior
        => AsReference("instance_initiated_shutdown_behavior");

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMarketOptions
        => AsReference("instance_market_options");

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceRequirements
        => AsReference("instance_requirements");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => AsReference("instance_type");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string> KernelId
        => AsReference("kernel_id");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
        => AsReference("key_name");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<double> LatestVersion
        => AsReference("latest_version");

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LicenseSpecification
        => AsReference("license_specification");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
        => AsReference("maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
        => AsReference("metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Monitoring
        => AsReference("monitoring");

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterfaces
        => AsReference("network_interfaces");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
        => AsReference("placement");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
        => AsReference("private_dns_name_options");

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformValue<string> RamDiskId
        => AsReference("ram_disk_id");

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupNames
        => AsReference("security_group_names");

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TagSpecifications
        => AsReference("tag_specifications");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
        => AsReference("user_data");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

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

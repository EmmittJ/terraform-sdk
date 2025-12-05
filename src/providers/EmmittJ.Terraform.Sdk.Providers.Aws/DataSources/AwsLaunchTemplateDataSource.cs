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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BlockDeviceMappings
        => CreateReference("block_device_mappings");

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CapacityReservationSpecification
        => CreateReference("capacity_reservation_specification");

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CpuOptions
        => CreateReference("cpu_options");

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreditSpecification
        => CreateReference("credit_specification");

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<double> DefaultVersion
        => CreateReference("default_version");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiStop
        => CreateReference("disable_api_stop");

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformValue<bool> DisableApiTermination
        => CreateReference("disable_api_termination");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<string> EbsOptimized
        => CreateReference("ebs_optimized");

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnclaveOptions
        => CreateReference("enclave_options");

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HibernationOptions
        => CreateReference("hibernation_options");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IamInstanceProfile
        => CreateReference("iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => CreateReference("image_id");

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformValue<string> InstanceInitiatedShutdownBehavior
        => CreateReference("instance_initiated_shutdown_behavior");

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceMarketOptions
        => CreateReference("instance_market_options");

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceRequirements
        => CreateReference("instance_requirements");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => CreateReference("instance_type");

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformValue<string> KernelId
        => CreateReference("kernel_id");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
        => CreateReference("key_name");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<double> LatestVersion
        => CreateReference("latest_version");

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LicenseSpecification
        => CreateReference("license_specification");

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceOptions
        => CreateReference("maintenance_options");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
        => CreateReference("metadata_options");

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Monitoring
        => CreateReference("monitoring");

    /// <summary>
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterfaces
        => CreateReference("network_interfaces");

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Placement
        => CreateReference("placement");

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsNameOptions
        => CreateReference("private_dns_name_options");

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformValue<string> RamDiskId
        => CreateReference("ram_disk_id");

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupNames
        => CreateReference("security_group_names");

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TagSpecifications
        => CreateReference("tag_specifications");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
        => CreateReference("user_data");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => CreateReference("vpc_security_group_ids");

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

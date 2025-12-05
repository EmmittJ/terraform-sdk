using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_launch_configuration Terraform data source.
/// Retrieves information about a aws_launch_configuration.
/// </summary>
public partial class AwsLaunchConfigurationDataSource(string name) : TerraformDataSource("aws_launch_configuration", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
        => CreateReference("associate_public_ip_address");

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EbsBlockDevice
        => CreateReference("ebs_block_device");

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
        => CreateReference("ebs_optimized");

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    public TerraformValue<bool> EnableMonitoring
        => CreateReference("enable_monitoring");

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EphemeralBlockDevice
        => CreateReference("ephemeral_block_device");

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
        => CreateReference("iam_instance_profile");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => CreateReference("image_id");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => CreateReference("instance_type");

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
        => CreateReference("key_name");

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
        => CreateReference("metadata_options");

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformValue<string> PlacementTenancy
        => CreateReference("placement_tenancy");

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RootBlockDevice
        => CreateReference("root_block_device");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => CreateReference("security_groups");

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string> SpotPrice
        => CreateReference("spot_price");

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
        => CreateReference("user_data");

}

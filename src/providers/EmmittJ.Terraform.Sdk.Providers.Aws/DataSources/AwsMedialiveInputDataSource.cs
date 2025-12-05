using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_medialive_input Terraform data source.
/// Retrieves information about a aws_medialive_input.
/// </summary>
public partial class AwsMedialiveInputDataSource(string name) : TerraformDataSource("aws_medialive_input", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The attached_channels attribute.
    /// </summary>
    public TerraformList<string> AttachedChannels
        => CreateReference("attached_channels");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destinations
        => CreateReference("destinations");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformValue<string> InputClass
        => CreateReference("input_class");

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InputDevices
        => CreateReference("input_devices");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformList<string> InputPartnerIds
        => CreateReference("input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformValue<string> InputSourceType
        => CreateReference("input_source_type");

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MediaConnectFlows
        => CreateReference("media_connect_flows");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformList<string> SecurityGroups
        => CreateReference("security_groups");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sources
        => CreateReference("sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

}

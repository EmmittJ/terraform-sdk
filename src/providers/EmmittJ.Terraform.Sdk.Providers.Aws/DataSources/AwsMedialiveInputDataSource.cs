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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformList<string> AttachedChannels
        => AsReference("attached_channels");

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destinations
        => AsReference("destinations");

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformValue<string> InputClass
        => AsReference("input_class");

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InputDevices
        => AsReference("input_devices");

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformList<string> InputPartnerIds
        => AsReference("input_partner_ids");

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformValue<string> InputSourceType
        => AsReference("input_source_type");

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MediaConnectFlows
        => AsReference("media_connect_flows");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformList<string> SecurityGroups
        => AsReference("security_groups");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sources
        => AsReference("sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}

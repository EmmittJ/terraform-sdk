using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_oam_link Terraform data source.
/// Retrieves information about a aws_oam_link.
/// </summary>
public partial class AwsOamLinkDataSource(string name) : TerraformDataSource("aws_oam_link", name)
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
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    public required TerraformValue<string> LinkIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("link_identifier");
        set => SetArgument("link_identifier", value);
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
    /// The label attribute.
    /// </summary>
    public TerraformValue<string> Label
        => AsReference("label");

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    public TerraformValue<string> LabelTemplate
        => AsReference("label_template");

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinkConfiguration
        => AsReference("link_configuration");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string> LinkId
        => AsReference("link_id");

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformSet<string> ResourceTypes
        => AsReference("resource_types");

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformValue<string> SinkArn
        => AsReference("sink_arn");

}

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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The label attribute.
    /// </summary>
    public TerraformValue<string> Label
        => CreateReference("label");

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    public TerraformValue<string> LabelTemplate
        => CreateReference("label_template");

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinkConfiguration
        => CreateReference("link_configuration");

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string> LinkId
        => CreateReference("link_id");

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformSet<string> ResourceTypes
        => CreateReference("resource_types");

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformValue<string> SinkArn
        => CreateReference("sink_arn");

}

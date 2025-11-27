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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The link_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkIdentifier is required")]
    public required TerraformValue<string> LinkIdentifier
    {
        get => new TerraformReference<string>(this, "link_identifier");
        set => SetArgument("link_identifier", value);
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
    /// The label attribute.
    /// </summary>
    public TerraformValue<string> Label
    {
        get => new TerraformReference<string>(this, "label");
    }

    /// <summary>
    /// The label_template attribute.
    /// </summary>
    public TerraformValue<string> LabelTemplate
    {
        get => new TerraformReference<string>(this, "label_template");
    }

    /// <summary>
    /// The link_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LinkConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "link_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The link_id attribute.
    /// </summary>
    public TerraformValue<string> LinkId
    {
        get => new TerraformReference<string>(this, "link_id");
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public TerraformSet<string> ResourceTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resource_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sink_arn attribute.
    /// </summary>
    public TerraformValue<string> SinkArn
    {
        get => new TerraformReference<string>(this, "sink_arn");
    }

}

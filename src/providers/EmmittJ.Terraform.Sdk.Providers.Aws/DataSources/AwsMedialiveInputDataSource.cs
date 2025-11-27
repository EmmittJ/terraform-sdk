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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformList<string> AttachedChannels
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "attached_channels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Destinations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "destinations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformValue<string> InputClass
    {
        get => new TerraformReference<string>(this, "input_class");
    }

    /// <summary>
    /// The input_devices attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InputDevices
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "input_devices").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformList<string> InputPartnerIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "input_partner_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformValue<string> InputSourceType
    {
        get => new TerraformReference<string>(this, "input_source_type");
    }

    /// <summary>
    /// The media_connect_flows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MediaConnectFlows
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "media_connect_flows").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformList<string> SecurityGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sources
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sources").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}

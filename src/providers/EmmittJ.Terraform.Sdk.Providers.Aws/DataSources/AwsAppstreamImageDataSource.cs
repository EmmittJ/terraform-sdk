using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appstream_image Terraform data source.
/// Retrieves information about a aws_appstream_image.
/// </summary>
public partial class AwsAppstreamImageDataSource(string name) : TerraformDataSource("aws_appstream_image", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => new TerraformReference<string>(this, "name_regex");
        set => SetArgument("name_regex", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Applications
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "applications").ResolveNodes(ctx));
    }

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformValue<string> AppstreamAgentVersion
    {
        get => new TerraformReference<string>(this, "appstream_agent_version");
    }

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    public TerraformValue<string> BaseImageArn
    {
        get => new TerraformReference<string>(this, "base_image_arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    public TerraformValue<string> ImageBuilderName
    {
        get => new TerraformReference<string>(this, "image_builder_name");
    }

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    public TerraformValue<bool> ImageBuilderSupported
    {
        get => new TerraformReference<bool>(this, "image_builder_supported");
    }

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImagePermissions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "image_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    public TerraformValue<string> PublicBaseImageReleasedDate
    {
        get => new TerraformReference<string>(this, "public_base_image_released_date");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateChangeReason
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "state_change_reason").ResolveNodes(ctx));
    }

}

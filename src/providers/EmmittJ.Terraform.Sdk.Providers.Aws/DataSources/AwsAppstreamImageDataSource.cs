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
        get => GetArgument<TerraformValue<string>>("arn") ?? CreateReference("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => GetArgument<TerraformValue<string>>("name_regex");
        set => SetArgument("name_regex", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Applications
        => CreateReference("applications");

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformValue<string> AppstreamAgentVersion
        => CreateReference("appstream_agent_version");

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    public TerraformValue<string> BaseImageArn
        => CreateReference("base_image_arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => CreateReference("created_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    public TerraformValue<string> ImageBuilderName
        => CreateReference("image_builder_name");

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    public TerraformValue<bool> ImageBuilderSupported
        => CreateReference("image_builder_supported");

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ImagePermissions
        => CreateReference("image_permissions");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => CreateReference("platform");

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    public TerraformValue<string> PublicBaseImageReleasedDate
        => CreateReference("public_base_image_released_date");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateChangeReason
        => CreateReference("state_change_reason");

}

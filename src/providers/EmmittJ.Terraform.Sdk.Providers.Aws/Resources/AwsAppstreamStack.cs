using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoints in AwsAppstreamStack.
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackAccessEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_endpoints";

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformValue<string> VpceId
    {
        get => new TerraformReference<string>(this, "vpce_id");
        set => SetArgument("vpce_id", value);
    }

}


/// <summary>
/// Block type for application_settings in AwsAppstreamStack.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackApplicationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_settings";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    public TerraformValue<string>? SettingsGroup
    {
        get => new TerraformReference<string>(this, "settings_group");
        set => SetArgument("settings_group", value);
    }

}


/// <summary>
/// Block type for storage_connectors in AwsAppstreamStack.
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackStorageConnectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_connectors";

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformValue<string> ConnectorType
    {
        get => new TerraformReference<string>(this, "connector_type");
        set => SetArgument("connector_type", value);
    }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    public TerraformList<string> Domains
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "domains").ResolveNodes(ctx));
        set => SetArgument("domains", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformValue<string> ResourceIdentifier
    {
        get => new TerraformReference<string>(this, "resource_identifier");
        set => SetArgument("resource_identifier", value);
    }

}


/// <summary>
/// Block type for streaming_experience_settings in AwsAppstreamStack.
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackStreamingExperienceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "streaming_experience_settings";

    /// <summary>
    /// The preferred_protocol attribute.
    /// </summary>
    public TerraformValue<string>? PreferredProtocol
    {
        get => new TerraformReference<string>(this, "preferred_protocol");
        set => SetArgument("preferred_protocol", value);
    }

}


/// <summary>
/// Block type for user_settings in AwsAppstreamStack.
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_settings";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformValue<string> Permission
    {
        get => new TerraformReference<string>(this, "permission");
        set => SetArgument("permission", value);
    }

}


/// <summary>
/// Represents a aws_appstream_stack Terraform resource.
/// Manages a aws_appstream_stack resource.
/// </summary>
public partial class AwsAppstreamStack(string name) : TerraformResource("aws_appstream_stack", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    public TerraformSet<string> EmbedHostDomains
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "embed_host_domains").ResolveNodes(ctx));
        set => SetArgument("embed_host_domains", value);
    }

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    public TerraformValue<string> FeedbackUrl
    {
        get => new TerraformReference<string>(this, "feedback_url");
        set => SetArgument("feedback_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformValue<string> RedirectUrl
    {
        get => new TerraformReference<string>(this, "redirect_url");
        set => SetArgument("redirect_url", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// AccessEndpoints block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    public TerraformSet<AwsAppstreamStackAccessEndpointsBlock>? AccessEndpoints
    {
        get => GetArgument<TerraformSet<AwsAppstreamStackAccessEndpointsBlock>>("access_endpoints");
        set => SetArgument("access_endpoints", value);
    }

    /// <summary>
    /// ApplicationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    public TerraformList<AwsAppstreamStackApplicationSettingsBlock>? ApplicationSettings
    {
        get => GetArgument<TerraformList<AwsAppstreamStackApplicationSettingsBlock>>("application_settings");
        set => SetArgument("application_settings", value);
    }

    /// <summary>
    /// StorageConnectors block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppstreamStackStorageConnectorsBlock>? StorageConnectors
    {
        get => GetArgument<TerraformSet<AwsAppstreamStackStorageConnectorsBlock>>("storage_connectors");
        set => SetArgument("storage_connectors", value);
    }

    /// <summary>
    /// StreamingExperienceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    public TerraformList<AwsAppstreamStackStreamingExperienceSettingsBlock>? StreamingExperienceSettings
    {
        get => GetArgument<TerraformList<AwsAppstreamStackStreamingExperienceSettingsBlock>>("streaming_experience_settings");
        set => SetArgument("streaming_experience_settings", value);
    }

    /// <summary>
    /// UserSettings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppstreamStackUserSettingsBlock>? UserSettings
    {
        get => GetArgument<TerraformSet<AwsAppstreamStackUserSettingsBlock>>("user_settings");
        set => SetArgument("user_settings", value);
    }

}

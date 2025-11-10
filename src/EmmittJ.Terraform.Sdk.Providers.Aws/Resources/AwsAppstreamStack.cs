using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_endpoints in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackAccessEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointType is required")]
    public required TerraformProperty<string> EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpceId
    {
        get => GetProperty<TerraformProperty<string>>("vpce_id");
        set => WithProperty("vpce_id", value);
    }

}

/// <summary>
/// Block type for application_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackApplicationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    public TerraformProperty<string>? SettingsGroup
    {
        get => GetProperty<TerraformProperty<string>>("settings_group");
        set => WithProperty("settings_group", value);
    }

}

/// <summary>
/// Block type for storage_connectors in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackStorageConnectorsBlock : TerraformBlock
{
    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformProperty<string> ConnectorType
    {
        get => GetProperty<TerraformProperty<string>>("connector_type");
        set => WithProperty("connector_type", value);
    }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Domains
    {
        get => GetProperty<List<TerraformProperty<string>>>("domains");
        set => WithProperty("domains", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("resource_identifier");
        set => WithProperty("resource_identifier", value);
    }

}

/// <summary>
/// Block type for streaming_experience_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAppstreamStackStreamingExperienceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The preferred_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? PreferredProtocol
    {
        get => GetProperty<TerraformProperty<string>>("preferred_protocol");
        set => WithProperty("preferred_protocol", value);
    }

}

/// <summary>
/// Block type for user_settings in .
/// Nesting mode: set
/// </summary>
public class AwsAppstreamStackUserSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformProperty<string> Permission
    {
        get => GetProperty<TerraformProperty<string>>("permission");
        set => WithProperty("permission", value);
    }

}

/// <summary>
/// Manages a aws_appstream_stack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAppstreamStack : TerraformResource
{
    public AwsAppstreamStack(string name) : base("aws_appstream_stack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EmbedHostDomains
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("embed_host_domains");
        set => this.WithProperty("embed_host_domains", value);
    }

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    public TerraformProperty<string>? FeedbackUrl
    {
        get => GetProperty<TerraformProperty<string>>("feedback_url");
        set => this.WithProperty("feedback_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformProperty<string>? RedirectUrl
    {
        get => GetProperty<TerraformProperty<string>>("redirect_url");
        set => this.WithProperty("redirect_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_endpoints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    public HashSet<AwsAppstreamStackAccessEndpointsBlock>? AccessEndpoints
    {
        get => GetProperty<HashSet<AwsAppstreamStackAccessEndpointsBlock>>("access_endpoints");
        set => this.WithProperty("access_endpoints", value);
    }

    /// <summary>
    /// Block for application_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    public List<AwsAppstreamStackApplicationSettingsBlock>? ApplicationSettings
    {
        get => GetProperty<List<AwsAppstreamStackApplicationSettingsBlock>>("application_settings");
        set => this.WithProperty("application_settings", value);
    }

    /// <summary>
    /// Block for storage_connectors.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAppstreamStackStorageConnectorsBlock>? StorageConnectors
    {
        get => GetProperty<HashSet<AwsAppstreamStackStorageConnectorsBlock>>("storage_connectors");
        set => this.WithProperty("storage_connectors", value);
    }

    /// <summary>
    /// Block for streaming_experience_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    public List<AwsAppstreamStackStreamingExperienceSettingsBlock>? StreamingExperienceSettings
    {
        get => GetProperty<List<AwsAppstreamStackStreamingExperienceSettingsBlock>>("streaming_experience_settings");
        set => this.WithProperty("streaming_experience_settings", value);
    }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAppstreamStackUserSettingsBlock>? UserSettings
    {
        get => GetProperty<HashSet<AwsAppstreamStackUserSettingsBlock>>("user_settings");
        set => this.WithProperty("user_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

}

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
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The vpce_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpceId
    {
        set => SetProperty("vpce_id", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The settings_group attribute.
    /// </summary>
    public TerraformProperty<string>? SettingsGroup
    {
        set => SetProperty("settings_group", value);
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
        set => SetProperty("connector_type", value);
    }

    /// <summary>
    /// The domains attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Domains
    {
        set => SetProperty("domains", value);
    }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceIdentifier
    {
        set => SetProperty("resource_identifier", value);
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
        set => SetProperty("preferred_protocol", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformProperty<string> Permission
    {
        set => SetProperty("permission", value);
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
        SetOutput("arn");
        SetOutput("created_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("embed_host_domains");
        SetOutput("feedback_url");
        SetOutput("id");
        SetOutput("name");
        SetOutput("redirect_url");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The embed_host_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EmbedHostDomains
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("embed_host_domains");
        set => SetProperty("embed_host_domains", value);
    }

    /// <summary>
    /// The feedback_url attribute.
    /// </summary>
    public TerraformProperty<string> FeedbackUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("feedback_url");
        set => SetProperty("feedback_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The redirect_url attribute.
    /// </summary>
    public TerraformProperty<string> RedirectUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redirect_url");
        set => SetProperty("redirect_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for access_endpoints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 AccessEndpoints block(s) allowed")]
    public HashSet<AwsAppstreamStackAccessEndpointsBlock>? AccessEndpoints
    {
        set => SetProperty("access_endpoints", value);
    }

    /// <summary>
    /// Block for application_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSettings block(s) allowed")]
    public List<AwsAppstreamStackApplicationSettingsBlock>? ApplicationSettings
    {
        set => SetProperty("application_settings", value);
    }

    /// <summary>
    /// Block for storage_connectors.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAppstreamStackStorageConnectorsBlock>? StorageConnectors
    {
        set => SetProperty("storage_connectors", value);
    }

    /// <summary>
    /// Block for streaming_experience_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StreamingExperienceSettings block(s) allowed")]
    public List<AwsAppstreamStackStreamingExperienceSettingsBlock>? StreamingExperienceSettings
    {
        set => SetProperty("streaming_experience_settings", value);
    }

    /// <summary>
    /// Block for user_settings.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAppstreamStackUserSettingsBlock>? UserSettings
    {
        set => SetProperty("user_settings", value);
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

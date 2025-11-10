using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for provider_oauth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Required. User selected scopes to apply to the Oauth config
    /// In the event of changing scopes, user records under AccountConnector will
    /// be deleted and users will re-auth again.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public List<TerraformProperty<string>>? Scopes
    {
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// List of providers that are owned by Developer Connect.
    /// 
    /// Possible values:
    /// GITHUB
    /// GITLAB
    /// GOOGLE
    /// SENTRY
    /// ROVO
    /// NEW_RELIC
    /// DATASTAX
    /// </summary>
    public TerraformProperty<string>? SystemProviderId
    {
        set => SetProperty("system_provider_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectAccountConnectorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_developer_connect_account_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeveloperConnectAccountConnector : TerraformResource
{
    public GoogleDeveloperConnectAccountConnector(string name) : base("google_developer_connect_account_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("oauth_start_uri");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("account_connector_id");
        SetOutput("annotations");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Required. The ID to use for the AccountConnector, which will become the final
    /// component of the AccountConnector&#39;s resource name. Its format should adhere
    /// to https://google.aip.dev/122#resource-id-segments Names must be unique
    /// per-project per-location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountConnectorId is required")]
    public required TerraformProperty<string> AccountConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_connector_id");
        set => SetProperty("account_connector_id", value);
    }

    /// <summary>
    /// Optional. Allows users to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
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
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for provider_oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProviderOauthConfig block(s) allowed")]
    public List<GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock>? ProviderOauthConfig
    {
        set => SetProperty("provider_oauth_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDeveloperConnectAccountConnectorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The timestamp when the userConnection was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Identifier. The resource name of the userConnection, in the format
    /// &#39;projects/{project}/locations/{location}/accountConnectors/{account_connector_id}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Start OAuth flow by clicking on this URL.
    /// </summary>
    public TerraformExpression OauthStartUri => this["oauth_start_uri"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The timestamp when the userConnection was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

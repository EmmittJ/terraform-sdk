using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for provider_oauth_config in GoogleDeveloperConnectAccountConnector.
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider_oauth_config";

    /// <summary>
    /// Required. User selected scopes to apply to the Oauth config
    /// In the event of changing scopes, user records under AccountConnector will
    /// be deleted and users will re-auth again.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
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
    public TerraformValue<string>? SystemProviderId
    {
        get => GetArgument<TerraformValue<string>>("system_provider_id");
        set => SetArgument("system_provider_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDeveloperConnectAccountConnector.
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectAccountConnectorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_developer_connect_account_connector Terraform resource.
/// Manages a google_developer_connect_account_connector resource.
/// </summary>
public partial class GoogleDeveloperConnectAccountConnector(string name) : TerraformResource("google_developer_connect_account_connector", name)
{
    /// <summary>
    /// Required. The ID to use for the AccountConnector, which will become the final
    /// component of the AccountConnector&#39;s resource name. Its format should adhere
    /// to https://google.aip.dev/122#resource-id-segments Names must be unique
    /// per-project per-location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountConnectorId is required")]
    public required TerraformValue<string> AccountConnectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_connector_id");
        set => SetArgument("account_connector_id", value);
    }

    /// <summary>
    /// Optional. Allows users to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The timestamp when the userConnection was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. The resource name of the userConnection, in the format
    /// &#39;projects/{project}/locations/{location}/accountConnectors/{account_connector_id}&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. Start OAuth flow by clicking on this URL.
    /// </summary>
    public TerraformValue<string> OauthStartUri
        => AsReference("oauth_start_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. The timestamp when the userConnection was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ProviderOauthConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProviderOauthConfig block(s) allowed")]
    public TerraformList<GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock>? ProviderOauthConfig
    {
        get => GetArgument<TerraformList<GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock>>("provider_oauth_config");
        set => SetArgument("provider_oauth_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDeveloperConnectAccountConnectorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDeveloperConnectAccountConnectorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

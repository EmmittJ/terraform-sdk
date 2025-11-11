using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for provider_oauth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock
{
    /// <summary>
    /// Required. User selected scopes to apply to the Oauth config
    /// In the event of changing scopes, user records under AccountConnector will
    /// be deleted and users will re-auth again.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Scopes { get; set; }

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
    [TerraformPropertyName("system_provider_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SystemProviderId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDeveloperConnectAccountConnectorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_developer_connect_account_connector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDeveloperConnectAccountConnector : TerraformResource
{
    public GoogleDeveloperConnectAccountConnector(string name) : base("google_developer_connect_account_connector", name)
    {
    }

    /// <summary>
    /// Required. The ID to use for the AccountConnector, which will become the final
    /// component of the AccountConnector&#39;s resource name. Its format should adhere
    /// to https://google.aip.dev/122#resource-id-segments Names must be unique
    /// per-project per-location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountConnectorId is required")]
    [TerraformPropertyName("account_connector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountConnectorId { get; set; }

    /// <summary>
    /// Optional. Allows users to store small amounts of arbitrary data.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Optional. Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for provider_oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProviderOauthConfig block(s) allowed")]
    [TerraformPropertyName("provider_oauth_config")]
    public TerraformList<TerraformBlock<GoogleDeveloperConnectAccountConnectorProviderOauthConfigBlock>>? ProviderOauthConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDeveloperConnectAccountConnectorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The timestamp when the userConnection was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// Identifier. The resource name of the userConnection, in the format
    /// &#39;projects/{project}/locations/{location}/accountConnectors/{account_connector_id}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. Start OAuth flow by clicking on this URL.
    /// </summary>
    [TerraformPropertyName("oauth_start_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OauthStartUri => new TerraformReference(this, "oauth_start_uri");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Output only. The timestamp when the userConnection was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}

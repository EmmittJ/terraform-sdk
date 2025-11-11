using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamOauthClientTimeoutsBlock
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
/// Manages a google_iam_oauth_client resource.
/// </summary>
public class GoogleIamOauthClient : TerraformResource
{
    public GoogleIamOauthClient(string name) : base("google_iam_oauth_client", name)
    {
    }

    /// <summary>
    /// Required. The list of OAuth grant types is allowed for the OauthClient.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedGrantTypes is required")]
    [TerraformPropertyName("allowed_grant_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedGrantTypes { get; set; }

    /// <summary>
    /// Required. The list of redirect uris that is allowed to redirect back
    /// when authorization process is completed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedRedirectUris is required")]
    [TerraformPropertyName("allowed_redirect_uris")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedRedirectUris { get; set; }

    /// <summary>
    /// Required. The list of scopes that the OauthClient is allowed to request during
    /// OAuth flows.
    /// 
    /// The following scopes are supported:
    /// 
    /// * &#39;https://www.googleapis.com/auth/cloud-platform&#39;: See, edit, configure,
    /// and delete your Google Cloud data and see the email address for your Google
    /// Account.
    /// * &#39;openid&#39;: The OAuth client can associate you with your personal
    /// information on Google Cloud.
    /// * &#39;email&#39;: The OAuth client can read a federated identity&#39;s email address.
    /// * &#39;groups&#39;: The OAuth client can read a federated identity&#39;s groups.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedScopes is required")]
    [TerraformPropertyName("allowed_scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AllowedScopes { get; set; }

    /// <summary>
    /// Immutable. The type of OauthClient. Either public or private.
    /// For private clients, the client secret can be managed using the dedicated
    /// OauthClientCredential resource.
    /// Possible values:
    /// CLIENT_TYPE_UNSPECIFIED
    /// PUBLIC_CLIENT
    /// CONFIDENTIAL_CLIENT
    /// </summary>
    [TerraformPropertyName("client_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientType { get; set; }

    /// <summary>
    /// A user-specified description of the OauthClient.
    /// 
    /// Cannot exceed 256 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Whether the OauthClient is disabled. You cannot use a disabled OAuth
    /// client.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// A user-specified display name of the OauthClient.
    /// 
    /// Cannot exceed 32 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Required. The ID to use for the OauthClient, which becomes the final component of
    /// the resource name. This value should be a string of 6 to 63 lowercase
    /// letters, digits, or hyphens. It must start with a letter, and cannot have a
    /// trailing hyphen. The prefix &#39;gcp-&#39; is reserved for use by Google, and may
    /// not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientId is required")]
    [TerraformPropertyName("oauth_client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OauthClientId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIamOauthClientTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The system-generated OauthClient id.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientId => new TerraformReference(this, "client_id");

    /// <summary>
    /// Time after which the OauthClient will be permanently purged and cannot
    /// be recovered.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpireTime => new TerraformReference(this, "expire_time");

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClient.
    /// 
    /// Format:&#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The state of the OauthClient.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// DELETED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamOauthClientTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_iam_oauth_client resource.
/// </summary>
public class GoogleIamOauthClient : TerraformResource
{
    public GoogleIamOauthClient(string name) : base("google_iam_oauth_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("client_id");
        this.WithOutput("expire_time");
        this.WithOutput("name");
        this.WithOutput("state");
    }

    /// <summary>
    /// Required. The list of OAuth grant types is allowed for the OauthClient.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedGrantTypes is required")]
    public List<TerraformProperty<string>>? AllowedGrantTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_grant_types");
        set => this.WithProperty("allowed_grant_types", value);
    }

    /// <summary>
    /// Required. The list of redirect uris that is allowed to redirect back
    /// when authorization process is completed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedRedirectUris is required")]
    public List<TerraformProperty<string>>? AllowedRedirectUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_redirect_uris");
        set => this.WithProperty("allowed_redirect_uris", value);
    }

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
    public List<TerraformProperty<string>>? AllowedScopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_scopes");
        set => this.WithProperty("allowed_scopes", value);
    }

    /// <summary>
    /// Immutable. The type of OauthClient. Either public or private.
    /// For private clients, the client secret can be managed using the dedicated
    /// OauthClientCredential resource.
    /// Possible values:
    /// CLIENT_TYPE_UNSPECIFIED
    /// PUBLIC_CLIENT
    /// CONFIDENTIAL_CLIENT
    /// </summary>
    public TerraformProperty<string>? ClientType
    {
        get => GetProperty<TerraformProperty<string>>("client_type");
        set => this.WithProperty("client_type", value);
    }

    /// <summary>
    /// A user-specified description of the OauthClient.
    /// 
    /// Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Whether the OauthClient is disabled. You cannot use a disabled OAuth
    /// client.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the OauthClient.
    /// 
    /// Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Required. The ID to use for the OauthClient, which becomes the final component of
    /// the resource name. This value should be a string of 6 to 63 lowercase
    /// letters, digits, or hyphens. It must start with a letter, and cannot have a
    /// trailing hyphen. The prefix &#39;gcp-&#39; is reserved for use by Google, and may
    /// not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientId is required")]
    public required TerraformProperty<string> OauthClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("oauth_client_id");
        set => this.WithProperty("oauth_client_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamOauthClientTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamOauthClientTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The system-generated OauthClient id.
    /// </summary>
    public TerraformExpression ClientId => this["client_id"];

    /// <summary>
    /// Time after which the OauthClient will be permanently purged and cannot
    /// be recovered.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClient.
    /// 
    /// Format:&#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The state of the OauthClient.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// DELETED
    /// </summary>
    public TerraformExpression State => this["state"];

}

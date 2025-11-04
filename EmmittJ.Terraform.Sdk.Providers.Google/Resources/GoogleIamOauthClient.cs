using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("client_id");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Required. The list of OAuth grant types is allowed for the OauthClient.
    /// </summary>
    public List<string>? AllowedGrantTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_grant_types")?.Value;
        set => this.WithProperty("allowed_grant_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Required. The list of redirect uris that is allowed to redirect back
    /// when authorization process is completed.
    /// </summary>
    public List<string>? AllowedRedirectUris
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_redirect_uris")?.Value;
        set => this.WithProperty("allowed_redirect_uris", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    public List<string>? AllowedScopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("allowed_scopes")?.Value;
        set => this.WithProperty("allowed_scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    public string? ClientType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_type")?.Value;
        set => this.WithProperty("client_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A user-specified description of the OauthClient.
    /// 
    /// Cannot exceed 256 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the OauthClient is disabled. You cannot use a disabled OAuth
    /// client.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A user-specified display name of the OauthClient.
    /// 
    /// Cannot exceed 32 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. The ID to use for the OauthClient, which becomes the final component of
    /// the resource name. This value should be a string of 6 to 63 lowercase
    /// letters, digits, or hyphens. It must start with a letter, and cannot have a
    /// trailing hyphen. The prefix &#39;gcp-&#39; is reserved for use by Google, and may
    /// not be specified.
    /// </summary>
    public string? OauthClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oauth_client_id")?.Value;
        set => this.WithProperty("oauth_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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

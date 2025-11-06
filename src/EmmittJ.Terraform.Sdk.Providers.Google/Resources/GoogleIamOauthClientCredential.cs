using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_oauth_client_credential resource.
/// </summary>
public class GoogleIamOauthClientCredential : TerraformResource
{
    public GoogleIamOauthClientCredential(string name) : base("google_iam_oauth_client_credential", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("client_secret");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Whether the OauthClientCredential is disabled. You cannot use a
    /// disabled OauthClientCredential.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A user-specified display name of the OauthClientCredential.
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
    /// Required. The ID to use for the OauthClientCredential, which becomes the
    /// final component of the resource name. This value should be 4-32 characters,
    /// and may contain the characters [a-z0-9-]. The prefix &#39;gcp-&#39; is
    /// reserved for use by Google, and may not be specified.
    /// </summary>
    public string? OauthClientCredentialId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oauth_client_credential_id")?.Value;
        set => this.WithProperty("oauth_client_credential_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public string? Oauthclient
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oauthclient")?.Value;
        set => this.WithProperty("oauthclient", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The system-generated OAuth client secret.
    /// 
    /// The client secret must be stored securely. If the client secret is
    /// leaked, you must delete and re-create the client credential. To learn
    /// more, see [OAuth client and credential security risks and
    /// mitigations](https://cloud.google.com/iam/docs/workforce-oauth-app#security)
    /// </summary>
    public TerraformExpression ClientSecret => this["client_secret"];

    /// <summary>
    /// Immutable. Identifier. The resource name of the OauthClientCredential.
    /// 
    /// Format:
    /// &#39;projects/{project}/locations/{location}/oauthClients/{oauth_client}/credentials/{credential}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}

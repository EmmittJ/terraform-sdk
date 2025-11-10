using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamOauthClientCredentialTimeoutsBlock : TerraformBlock
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
        this.WithOutput("client_secret");
        this.WithOutput("name");
    }

    /// <summary>
    /// Whether the OauthClientCredential is disabled. You cannot use a
    /// disabled OauthClientCredential.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// A user-specified display name of the OauthClientCredential.
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
    /// Required. The ID to use for the OauthClientCredential, which becomes the
    /// final component of the resource name. This value should be 4-32 characters,
    /// and may contain the characters [a-z0-9-]. The prefix &#39;gcp-&#39; is
    /// reserved for use by Google, and may not be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthClientCredentialId is required")]
    public required TerraformProperty<string> OauthClientCredentialId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("oauth_client_credential_id");
        set => this.WithProperty("oauth_client_credential_id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauthclient is required")]
    public required TerraformProperty<string> Oauthclient
    {
        get => GetRequiredProperty<TerraformProperty<string>>("oauthclient");
        set => this.WithProperty("oauthclient", value);
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
    public GoogleIamOauthClientCredentialTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamOauthClientCredentialTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

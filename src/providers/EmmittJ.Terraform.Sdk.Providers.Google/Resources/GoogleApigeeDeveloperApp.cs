using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeDeveloperAppAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeDeveloperAppTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_developer_app resource.
/// </summary>
public class GoogleApigeeDeveloperApp : TerraformResource
{
    public GoogleApigeeDeveloperApp(string name) : base("google_apigee_developer_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_id");
        this.WithOutput("created_at");
        this.WithOutput("credentials");
        this.WithOutput("developer_id");
        this.WithOutput("last_modified_at");
    }

    /// <summary>
    /// List of API products associated with the developer app.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ApiProducts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("api_products");
        set => this.WithProperty("api_products", value);
    }

    /// <summary>
    /// Developer app family.
    /// </summary>
    public TerraformProperty<string>? AppFamily
    {
        get => GetProperty<TerraformProperty<string>>("app_family");
        set => this.WithProperty("app_family", value);
    }

    /// <summary>
    /// Callback URL used by OAuth 2.0 authorization servers to communicate
    /// authorization codes back to developer apps.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUrl is required")]
    public required TerraformProperty<string> CallbackUrl
    {
        get => GetRequiredProperty<TerraformProperty<string>>("callback_url");
        set => this.WithProperty("callback_url", value);
    }

    /// <summary>
    /// Email address of the developer.
    /// This value is used to uniquely identify the developer in Apigee hybrid.
    /// Note that the email address has to be in lowercase only.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeveloperEmail is required")]
    public required TerraformProperty<string> DeveloperEmail
    {
        get => GetRequiredProperty<TerraformProperty<string>>("developer_email");
        set => this.WithProperty("developer_email", value);
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
    /// Expiration time, in milliseconds, for the consumer key that is generated
    /// for the developer app. If not set or left to the default value of -1,
    /// the API key never expires. The expiration time can&#39;t be updated after it is set.
    /// </summary>
    public TerraformProperty<string>? KeyExpiresIn
    {
        get => GetProperty<TerraformProperty<string>>("key_expires_in");
        set => this.WithProperty("key_expires_in", value);
    }

    /// <summary>
    /// Name of the developer app.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Scopes to apply to the developer app.
    /// The specified scopes must already exist for the API product that
    /// you associate with the developer app.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// Status of the credential. Valid values include approved or revoked.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleApigeeDeveloperAppAttributesBlock>? Attributes
    {
        get => GetProperty<List<GoogleApigeeDeveloperAppAttributesBlock>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeDeveloperAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeDeveloperAppTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// ID of the developer app. This ID is not user specified but is
    /// automatically generated on app creation. appId is a UUID.
    /// </summary>
    public TerraformExpression AppId => this["app_id"];

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// Output only. Set of credentials for the developer app consisting of
    /// the consumer key/secret pairs associated with the API products.
    /// </summary>
    public TerraformExpression Credentials => this["credentials"];

    /// <summary>
    /// ID of the developer.
    /// </summary>
    public TerraformExpression DeveloperId => this["developer_id"];

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    public TerraformExpression LastModifiedAt => this["last_modified_at"];

}

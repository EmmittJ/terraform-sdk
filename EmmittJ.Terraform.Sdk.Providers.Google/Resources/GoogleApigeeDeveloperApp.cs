using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("app_id");
        this.DeclareOutput("created_at");
        this.DeclareOutput("credentials");
        this.DeclareOutput("developer_id");
        this.DeclareOutput("last_modified_at");
    }

    /// <summary>
    /// List of API products associated with the developer app.
    /// </summary>
    public HashSet<string>? ApiProducts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("api_products")?.Value;
        set => this.WithProperty("api_products", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Developer app family.
    /// </summary>
    public string? AppFamily
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_family")?.Value;
        set => this.WithProperty("app_family", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Callback URL used by OAuth 2.0 authorization servers to communicate
    /// authorization codes back to developer apps.
    /// </summary>
    public string? CallbackUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("callback_url")?.Value;
        set => this.WithProperty("callback_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Email address of the developer.
    /// This value is used to uniquely identify the developer in Apigee hybrid.
    /// Note that the email address has to be in lowercase only.
    /// </summary>
    public string? DeveloperEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("developer_email")?.Value;
        set => this.WithProperty("developer_email", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Expiration time, in milliseconds, for the consumer key that is generated
    /// for the developer app. If not set or left to the default value of -1,
    /// the API key never expires. The expiration time can&#39;t be updated after it is set.
    /// </summary>
    public string? KeyExpiresIn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_expires_in")?.Value;
        set => this.WithProperty("key_expires_in", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the developer app.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Scopes to apply to the developer app.
    /// The specified scopes must already exist for the API product that
    /// you associate with the developer app.
    /// </summary>
    public HashSet<string>? Scopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("scopes")?.Value;
        set => this.WithProperty("scopes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Status of the credential. Valid values include approved or revoked.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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

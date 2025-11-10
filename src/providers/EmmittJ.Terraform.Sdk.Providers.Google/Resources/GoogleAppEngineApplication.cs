using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for feature_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationFeatureSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The split_health_checks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SplitHealthChecks is required")]
    public required TerraformProperty<bool> SplitHealthChecks
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("split_health_checks");
        set => WithProperty("split_health_checks", value);
    }

}

/// <summary>
/// Block type for iap in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationIapBlock : TerraformBlock
{
    /// <summary>
    /// Adapted for use with the app
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    public required TerraformProperty<string> Oauth2ClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("oauth2_client_id");
        set => WithProperty("oauth2_client_id", value);
    }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    public required TerraformProperty<string> Oauth2ClientSecret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("oauth2_client_secret");
        set => WithProperty("oauth2_client_secret", value);
    }

    /// <summary>
    /// Hex-encoded SHA-256 hash of the client secret.
    /// </summary>
    public TerraformProperty<string>? Oauth2ClientSecretSha256
    {
        get => GetProperty<TerraformProperty<string>>("oauth2_client_secret_sha256");
        set => WithProperty("oauth2_client_secret_sha256", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_app_engine_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineApplication : TerraformResource
{
    public GoogleAppEngineApplication(string name) : base("google_app_engine_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_id");
        this.DeclareOutput("code_bucket");
        this.DeclareOutput("default_bucket");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("gcr_domain");
        this.DeclareOutput("name");
        this.DeclareOutput("url_dispatch_rule");
    }

    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    public TerraformProperty<string>? AuthDomain
    {
        get => GetProperty<TerraformProperty<string>>("auth_domain");
        set => this.WithProperty("auth_domain", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseType
    {
        get => GetProperty<TerraformProperty<string>>("database_type");
        set => this.WithProperty("database_type", value);
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
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    public required TerraformProperty<string> LocationId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location_id");
        set => this.WithProperty("location_id", value);
    }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    public TerraformProperty<string>? ServingStatus
    {
        get => GetProperty<TerraformProperty<string>>("serving_status");
        set => this.WithProperty("serving_status", value);
    }

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    public TerraformProperty<string>? SslPolicy
    {
        get => GetProperty<TerraformProperty<string>>("ssl_policy");
        set => this.WithProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for feature_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    public List<GoogleAppEngineApplicationFeatureSettingsBlock>? FeatureSettings
    {
        get => GetProperty<List<GoogleAppEngineApplicationFeatureSettingsBlock>>("feature_settings");
        set => this.WithProperty("feature_settings", value);
    }

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    public List<GoogleAppEngineApplicationIapBlock>? Iap
    {
        get => GetProperty<List<GoogleAppEngineApplicationIapBlock>>("iap");
        set => this.WithProperty("iap", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineApplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAppEngineApplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    public TerraformExpression AppId => this["app_id"];

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    public TerraformExpression CodeBucket => this["code_bucket"];

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    public TerraformExpression DefaultBucket => this["default_bucket"];

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    public TerraformExpression GcrDomain => this["gcr_domain"];

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    public TerraformExpression UrlDispatchRule => this["url_dispatch_rule"];

}

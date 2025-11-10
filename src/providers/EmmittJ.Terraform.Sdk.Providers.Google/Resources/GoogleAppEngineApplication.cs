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
        set => SetProperty("split_health_checks", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    public required TerraformProperty<string> Oauth2ClientId
    {
        set => SetProperty("oauth2_client_id", value);
    }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    public required TerraformProperty<string> Oauth2ClientSecret
    {
        set => SetProperty("oauth2_client_secret", value);
    }

    /// <summary>
    /// Hex-encoded SHA-256 hash of the client secret.
    /// </summary>
    public TerraformProperty<string>? Oauth2ClientSecretSha256
    {
        set => SetProperty("oauth2_client_secret_sha256", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("app_id");
        SetOutput("code_bucket");
        SetOutput("default_bucket");
        SetOutput("default_hostname");
        SetOutput("gcr_domain");
        SetOutput("name");
        SetOutput("url_dispatch_rule");
        SetOutput("auth_domain");
        SetOutput("database_type");
        SetOutput("id");
        SetOutput("location_id");
        SetOutput("project");
        SetOutput("serving_status");
        SetOutput("ssl_policy");
    }

    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    public TerraformProperty<string> AuthDomain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auth_domain");
        set => SetProperty("auth_domain", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_type");
        set => SetProperty("database_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    public required TerraformProperty<string> LocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location_id");
        set => SetProperty("location_id", value);
    }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    public TerraformProperty<string> ServingStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("serving_status");
        set => SetProperty("serving_status", value);
    }

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    public TerraformProperty<string> SslPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_policy");
        set => SetProperty("ssl_policy", value);
    }

    /// <summary>
    /// Block for feature_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    public List<GoogleAppEngineApplicationFeatureSettingsBlock>? FeatureSettings
    {
        set => SetProperty("feature_settings", value);
    }

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    public List<GoogleAppEngineApplicationIapBlock>? Iap
    {
        set => SetProperty("iap", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

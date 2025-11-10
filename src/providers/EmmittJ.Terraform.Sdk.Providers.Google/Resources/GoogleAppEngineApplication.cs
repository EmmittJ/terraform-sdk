using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for feature_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationFeatureSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The split_health_checks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SplitHealthChecks is required")]
    [TerraformPropertyName("split_health_checks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> SplitHealthChecks { get; set; }

}

/// <summary>
/// Block type for iap in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationIapBlock : ITerraformBlock
{
    /// <summary>
    /// Adapted for use with the app
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    [TerraformPropertyName("oauth2_client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    [TerraformPropertyName("oauth2_client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Oauth2ClientSecret { get; set; }

    /// <summary>
    /// Hex-encoded SHA-256 hash of the client secret.
    /// </summary>
    [TerraformPropertyName("oauth2_client_secret_sha256")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Oauth2ClientSecretSha256 => new TerraformReferenceProperty<TerraformProperty<string>>("", "oauth2_client_secret_sha256");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineApplication : TerraformResource
{
    public GoogleAppEngineApplication(string name) : base("google_app_engine_application", name)
    {
    }

    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    [TerraformPropertyName("auth_domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthDomain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auth_domain");

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    [TerraformPropertyName("database_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    [TerraformPropertyName("location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LocationId { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    [TerraformPropertyName("serving_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServingStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "serving_status");

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SslPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_policy");

    /// <summary>
    /// Block for feature_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    [TerraformPropertyName("feature_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationFeatureSettingsBlock>>? FeatureSettings { get; set; } = new();

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    [TerraformPropertyName("iap")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationIapBlock>>? Iap { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAppEngineApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_id");

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    [TerraformPropertyName("code_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CodeBucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "code_bucket");

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    [TerraformPropertyName("default_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultBucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_bucket");

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_hostname");

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    [TerraformPropertyName("gcr_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GcrDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcr_domain");

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    [TerraformPropertyName("url_dispatch_rule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UrlDispatchRule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "url_dispatch_rule");

}

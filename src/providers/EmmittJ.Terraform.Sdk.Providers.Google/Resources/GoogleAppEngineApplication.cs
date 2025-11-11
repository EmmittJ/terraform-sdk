using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for feature_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationFeatureSettingsBlock
{
    /// <summary>
    /// The split_health_checks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SplitHealthChecks is required")]
    [TerraformPropertyName("split_health_checks")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> SplitHealthChecks { get; set; }

}

/// <summary>
/// Block type for iap in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationIapBlock
{
    /// <summary>
    /// Adapted for use with the app
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    [TerraformPropertyName("oauth2_client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    [TerraformPropertyName("oauth2_client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Oauth2ClientSecret { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthDomain { get; set; } = default!;

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    [TerraformPropertyName("database_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DatabaseType { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    [TerraformPropertyName("location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LocationId { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    [TerraformPropertyName("serving_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServingStatus { get; set; } = default!;

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SslPolicy { get; set; } = default!;

    /// <summary>
    /// Block for feature_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    [TerraformPropertyName("feature_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationFeatureSettingsBlock>>? FeatureSettings { get; set; }

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    [TerraformPropertyName("iap")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationIapBlock>>? Iap { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAppEngineApplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AppId => new TerraformReference(this, "app_id");

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    [TerraformPropertyName("code_bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CodeBucket => new TerraformReference(this, "code_bucket");

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    [TerraformPropertyName("default_bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultBucket => new TerraformReference(this, "default_bucket");

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultHostname => new TerraformReference(this, "default_hostname");

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    [TerraformPropertyName("gcr_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GcrDomain => new TerraformReference(this, "gcr_domain");

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    [TerraformPropertyName("url_dispatch_rule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UrlDispatchRule => new TerraformReference(this, "url_dispatch_rule");

}

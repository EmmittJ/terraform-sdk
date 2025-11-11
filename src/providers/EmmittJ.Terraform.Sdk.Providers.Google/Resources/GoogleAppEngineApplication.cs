using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for feature_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineApplicationFeatureSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The split_health_checks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SplitHealthChecks is required")]
    [TerraformProperty("split_health_checks")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> SplitHealthChecks { get; set; }

}

/// <summary>
/// Block type for iap in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineApplicationIapBlock : TerraformBlockBase
{
    /// <summary>
    /// Adapted for use with the app
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    [TerraformProperty("oauth2_client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Oauth2ClientId { get; set; }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    [TerraformProperty("oauth2_client_secret")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Oauth2ClientSecret { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineApplicationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_app_engine_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineApplication : TerraformResource
{
    public GoogleAppEngineApplication(string name) : base("google_app_engine_application", name)
    {
    }

    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    [TerraformProperty("auth_domain")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AuthDomain { get; set; }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    [TerraformProperty("database_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DatabaseType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    [TerraformProperty("location_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LocationId { get; set; }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    [TerraformProperty("serving_status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServingStatus { get; set; }

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SslPolicy { get; set; }

    /// <summary>
    /// Block for feature_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    [TerraformProperty("feature_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationFeatureSettingsBlock>>? FeatureSettings { get; set; }

    /// <summary>
    /// Block for iap.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    [TerraformProperty("iap")]
    public TerraformList<TerraformBlock<GoogleAppEngineApplicationIapBlock>>? Iap { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineApplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    [TerraformProperty("app_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppId { get; }

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    [TerraformProperty("code_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CodeBucket { get; }

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    [TerraformProperty("default_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultBucket { get; }

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    [TerraformProperty("gcr_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GcrDomain { get; }

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    [TerraformProperty("url_dispatch_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UrlDispatchRule { get; }

}

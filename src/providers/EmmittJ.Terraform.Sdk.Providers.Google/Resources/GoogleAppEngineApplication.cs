using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for feature_settings in GoogleAppEngineApplication.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationFeatureSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feature_settings";

    /// <summary>
    /// The split_health_checks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SplitHealthChecks is required")]
    public required TerraformValue<bool> SplitHealthChecks
    {
        get => new TerraformReference<bool>(this, "split_health_checks");
        set => SetArgument("split_health_checks", value);
    }

}


/// <summary>
/// Block type for iap in GoogleAppEngineApplication.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineApplicationIapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iap";

    /// <summary>
    /// Adapted for use with the app
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// OAuth2 client ID to use for the authentication flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientId is required")]
    public required TerraformValue<string> Oauth2ClientId
    {
        get => new TerraformReference<string>(this, "oauth2_client_id");
        set => SetArgument("oauth2_client_id", value);
    }

    /// <summary>
    /// OAuth2 client secret to use for the authentication flow. The SHA-256 hash of the value is returned in the oauth2ClientSecretSha256 field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oauth2ClientSecret is required")]
    public required TerraformValue<string> Oauth2ClientSecret
    {
        get => new TerraformReference<string>(this, "oauth2_client_secret");
        set => SetArgument("oauth2_client_secret", value);
    }

    /// <summary>
    /// Hex-encoded SHA-256 hash of the client secret.
    /// </summary>
    public TerraformValue<string> Oauth2ClientSecretSha256
    {
        get => new TerraformReference<string>(this, "oauth2_client_secret_sha256");
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineApplication.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineApplicationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_app_engine_application Terraform resource.
/// Manages a google_app_engine_application resource.
/// </summary>
public partial class GoogleAppEngineApplication(string name) : TerraformResource("google_app_engine_application", name)
{
    /// <summary>
    /// The domain to authenticate users with when using App Engine&#39;s User API.
    /// </summary>
    public TerraformValue<string> AuthDomain
    {
        get => new TerraformReference<string>(this, "auth_domain");
        set => SetArgument("auth_domain", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformValue<string> DatabaseType
    {
        get => new TerraformReference<string>(this, "database_type");
        set => SetArgument("database_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location to serve the app from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    public required TerraformValue<string> LocationId
    {
        get => new TerraformReference<string>(this, "location_id");
        set => SetArgument("location_id", value);
    }

    /// <summary>
    /// The project ID to create the application under.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The serving status of the app.
    /// </summary>
    public TerraformValue<string> ServingStatus
    {
        get => new TerraformReference<string>(this, "serving_status");
        set => SetArgument("serving_status", value);
    }

    /// <summary>
    /// The SSL policy that will be applied to the application. If set to Modern it will restrict traffic with TLS \u003c 1.2 and allow only Modern Ciphers suite
    /// </summary>
    public TerraformValue<string> SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
        set => SetArgument("ssl_policy", value);
    }

    /// <summary>
    /// Identifier of the app.
    /// </summary>
    public TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
    }

    /// <summary>
    /// The GCS bucket code is being stored in for this app.
    /// </summary>
    public TerraformValue<string> CodeBucket
    {
        get => new TerraformReference<string>(this, "code_bucket");
    }

    /// <summary>
    /// The GCS bucket content is being stored in for this app.
    /// </summary>
    public TerraformValue<string> DefaultBucket
    {
        get => new TerraformReference<string>(this, "default_bucket");
    }

    /// <summary>
    /// The default hostname for this app.
    /// </summary>
    public TerraformValue<string> DefaultHostname
    {
        get => new TerraformReference<string>(this, "default_hostname");
    }

    /// <summary>
    /// The GCR domain used for storing managed Docker images for this app.
    /// </summary>
    public TerraformValue<string> GcrDomain
    {
        get => new TerraformReference<string>(this, "gcr_domain");
    }

    /// <summary>
    /// Unique name of the app.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// A list of dispatch rule blocks. Each block has a domain, path, and service field.
    /// </summary>
    public TerraformList<TerraformMap<object>> UrlDispatchRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "url_dispatch_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// FeatureSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeatureSettings block(s) allowed")]
    public TerraformList<GoogleAppEngineApplicationFeatureSettingsBlock>? FeatureSettings
    {
        get => GetArgument<TerraformList<GoogleAppEngineApplicationFeatureSettingsBlock>>("feature_settings");
        set => SetArgument("feature_settings", value);
    }

    /// <summary>
    /// Iap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Iap block(s) allowed")]
    public TerraformList<GoogleAppEngineApplicationIapBlock>? Iap
    {
        get => GetArgument<TerraformList<GoogleAppEngineApplicationIapBlock>>("iap");
        set => SetArgument("iap", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

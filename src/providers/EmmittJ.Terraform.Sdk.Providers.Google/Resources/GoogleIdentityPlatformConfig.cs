using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for blocking_functions in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigBlockingFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "blocking_functions";

    /// <summary>
    /// ForwardInboundCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardInboundCredentials block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigBlockingFunctionsBlockForwardInboundCredentialsBlock>? ForwardInboundCredentials
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigBlockingFunctionsBlockForwardInboundCredentialsBlock>>("forward_inbound_credentials");
        set => SetArgument("forward_inbound_credentials", value);
    }

    /// <summary>
    /// Triggers block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Triggers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Triggers block(s) required")]
    public required TerraformSet<GoogleIdentityPlatformConfigBlockingFunctionsBlockTriggersBlock> Triggers
    {
        get => GetRequiredArgument<TerraformSet<GoogleIdentityPlatformConfigBlockingFunctionsBlockTriggersBlock>>("triggers");
        set => SetArgument("triggers", value);
    }

}

/// <summary>
/// Block type for forward_inbound_credentials in GoogleIdentityPlatformConfigBlockingFunctionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigBlockingFunctionsBlockForwardInboundCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forward_inbound_credentials";

    /// <summary>
    /// Whether to pass the user&#39;s OAuth identity provider&#39;s access token.
    /// </summary>
    public TerraformValue<bool>? AccessToken
    {
        get => new TerraformReference<bool>(this, "access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// Whether to pass the user&#39;s OIDC identity provider&#39;s ID token.
    /// </summary>
    public TerraformValue<bool>? IdToken
    {
        get => new TerraformReference<bool>(this, "id_token");
        set => SetArgument("id_token", value);
    }

    /// <summary>
    /// Whether to pass the user&#39;s OAuth identity provider&#39;s refresh token.
    /// </summary>
    public TerraformValue<bool>? RefreshToken
    {
        get => new TerraformReference<bool>(this, "refresh_token");
        set => SetArgument("refresh_token", value);
    }

}

/// <summary>
/// Block type for triggers in GoogleIdentityPlatformConfigBlockingFunctionsBlock.
/// Nesting mode: set
/// </summary>
public class GoogleIdentityPlatformConfigBlockingFunctionsBlockTriggersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "triggers";

    /// <summary>
    /// The event_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformValue<string> EventType
    {
        get => new TerraformReference<string>(this, "event_type");
        set => SetArgument("event_type", value);
    }

    /// <summary>
    /// HTTP URI trigger for the Cloud Function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionUri is required")]
    public required TerraformValue<string> FunctionUri
    {
        get => new TerraformReference<string>(this, "function_uri");
        set => SetArgument("function_uri", value);
    }

    /// <summary>
    /// When the trigger was changed.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}


/// <summary>
/// Block type for client in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigClientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client";

    /// <summary>
    /// API key that can be used when making requests for this project.
    /// </summary>
    public TerraformValue<string> ApiKey
    {
        get => new TerraformReference<string>(this, "api_key");
    }

    /// <summary>
    /// Firebase subdomain.
    /// </summary>
    public TerraformValue<string> FirebaseSubdomain
    {
        get => new TerraformReference<string>(this, "firebase_subdomain");
    }

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Permissions block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigClientBlockPermissionsBlock>? Permissions
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigClientBlockPermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

}

/// <summary>
/// Block type for permissions in GoogleIdentityPlatformConfigClientBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigClientBlockPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// When true, end users cannot delete their account on the associated project through any of our API methods
    /// </summary>
    public TerraformValue<bool>? DisabledUserDeletion
    {
        get => new TerraformReference<bool>(this, "disabled_user_deletion");
        set => SetArgument("disabled_user_deletion", value);
    }

    /// <summary>
    /// When true, end users cannot sign up for a new account on the associated project through any of our API methods
    /// </summary>
    public TerraformValue<bool>? DisabledUserSignup
    {
        get => new TerraformReference<bool>(this, "disabled_user_signup");
        set => SetArgument("disabled_user_signup", value);
    }

}


/// <summary>
/// Block type for mfa in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMfaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mfa";

    /// <summary>
    /// A list of usable second factors for this project. Possible values: [&amp;quot;PHONE_SMS&amp;quot;]
    /// </summary>
    public TerraformList<string>? EnabledProviders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_providers").ResolveNodes(ctx));
        set => SetArgument("enabled_providers", value);
    }

    /// <summary>
    /// Whether MultiFactor Authentication has been enabled for this project. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;MANDATORY&amp;quot;]
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// ProviderConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlock>? ProviderConfigs
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlock>>("provider_configs");
        set => SetArgument("provider_configs", value);
    }

}

/// <summary>
/// Block type for provider_configs in GoogleIdentityPlatformConfigMfaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider_configs";

    /// <summary>
    /// Whether MultiFactor Authentication has been enabled for this project. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;MANDATORY&amp;quot;]
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// TotpProviderConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TotpProviderConfig block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlockTotpProviderConfigBlock>? TotpProviderConfig
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlockTotpProviderConfigBlock>>("totp_provider_config");
        set => SetArgument("totp_provider_config", value);
    }

}

/// <summary>
/// Block type for totp_provider_config in GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMfaBlockProviderConfigsBlockTotpProviderConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "totp_provider_config";

    /// <summary>
    /// The allowed number of adjacent intervals that will be used for verification to avoid clock skew.
    /// </summary>
    public TerraformValue<double>? AdjacentIntervals
    {
        get => new TerraformReference<double>(this, "adjacent_intervals");
        set => SetArgument("adjacent_intervals", value);
    }

}


/// <summary>
/// Block type for monitoring in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring";

    /// <summary>
    /// RequestLogging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestLogging block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigMonitoringBlockRequestLoggingBlock>? RequestLogging
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMonitoringBlockRequestLoggingBlock>>("request_logging");
        set => SetArgument("request_logging", value);
    }

}

/// <summary>
/// Block type for request_logging in GoogleIdentityPlatformConfigMonitoringBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMonitoringBlockRequestLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_logging";

    /// <summary>
    /// Whether logging is enabled for this project or not.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for multi_tenant in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMultiTenantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_tenant";

    /// <summary>
    /// Whether this project can have tenants or not.
    /// </summary>
    public TerraformValue<bool>? AllowTenants
    {
        get => new TerraformReference<bool>(this, "allow_tenants");
        set => SetArgument("allow_tenants", value);
    }

    /// <summary>
    /// The default cloud parent org or folder that the tenant project should be created under.
    /// The parent resource name should be in the format of &amp;quot;/&amp;quot;, such as &amp;quot;folders/123&amp;quot; or &amp;quot;organizations/456&amp;quot;.
    /// If the value is not set, the tenant will be created under the same organization or folder as the agent project.
    /// </summary>
    public TerraformValue<string>? DefaultTenantLocation
    {
        get => new TerraformReference<string>(this, "default_tenant_location");
        set => SetArgument("default_tenant_location", value);
    }

}


/// <summary>
/// Block type for quota in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigQuotaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota";

    /// <summary>
    /// SignUpQuotaConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignUpQuotaConfig block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigQuotaBlockSignUpQuotaConfigBlock>? SignUpQuotaConfig
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigQuotaBlockSignUpQuotaConfigBlock>>("sign_up_quota_config");
        set => SetArgument("sign_up_quota_config", value);
    }

}

/// <summary>
/// Block type for sign_up_quota_config in GoogleIdentityPlatformConfigQuotaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigQuotaBlockSignUpQuotaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_up_quota_config";

    /// <summary>
    /// A sign up APIs quota that customers can override temporarily. Value can be in between 1 and 1000.
    /// </summary>
    public TerraformValue<double>? Quota
    {
        get => new TerraformReference<double>(this, "quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// How long this quota will be active for. It is measurred in seconds, e.g., Example: &amp;quot;9.615s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? QuotaDuration
    {
        get => new TerraformReference<string>(this, "quota_duration");
        set => SetArgument("quota_duration", value);
    }

    /// <summary>
    /// When this quota will take affect.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for sign_in in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_in";

    /// <summary>
    /// Whether to allow more than one account to have the same email.
    /// </summary>
    public TerraformValue<bool>? AllowDuplicateEmails
    {
        get => new TerraformReference<bool>(this, "allow_duplicate_emails");
        set => SetArgument("allow_duplicate_emails", value);
    }

    /// <summary>
    /// Output only. Hash config information.
    /// </summary>
    public TerraformList<TerraformMap<object>> HashConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hash_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Anonymous block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Anonymous block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSignInBlockAnonymousBlock>? Anonymous
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSignInBlockAnonymousBlock>>("anonymous");
        set => SetArgument("anonymous", value);
    }

    /// <summary>
    /// Email block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Email block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSignInBlockEmailBlock>? Email
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSignInBlockEmailBlock>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// PhoneNumber block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumber block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSignInBlockPhoneNumberBlock>? PhoneNumber
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSignInBlockPhoneNumberBlock>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}

/// <summary>
/// Block type for anonymous in GoogleIdentityPlatformConfigSignInBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlockAnonymousBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "anonymous";

    /// <summary>
    /// Whether anonymous user auth is enabled for the project or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for email in GoogleIdentityPlatformConfigSignInBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlockEmailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email";

    /// <summary>
    /// Whether email auth is enabled for the project or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Whether a password is required for email auth or not. If true, both an email and
    /// password must be provided to sign in. If false, a user may sign in via either
    /// email/password or email link.
    /// </summary>
    public TerraformValue<bool>? PasswordRequired
    {
        get => new TerraformReference<bool>(this, "password_required");
        set => SetArgument("password_required", value);
    }

}

/// <summary>
/// Block type for phone_number in GoogleIdentityPlatformConfigSignInBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlockPhoneNumberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "phone_number";

    /// <summary>
    /// Whether phone number auth is enabled for the project or not.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// A map of &amp;lt;test phone number, fake code&amp;gt; that can be used for phone auth testing.
    /// </summary>
    public TerraformMap<string>? TestPhoneNumbers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "test_phone_numbers").ResolveNodes(ctx));
        set => SetArgument("test_phone_numbers", value);
    }

}


/// <summary>
/// Block type for sms_region_config in GoogleIdentityPlatformConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSmsRegionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sms_region_config";

    /// <summary>
    /// AllowByDefault block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowByDefault block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowByDefaultBlock>? AllowByDefault
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowByDefaultBlock>>("allow_by_default");
        set => SetArgument("allow_by_default", value);
    }

    /// <summary>
    /// AllowlistOnly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowlistOnly block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowlistOnlyBlock>? AllowlistOnly
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowlistOnlyBlock>>("allowlist_only");
        set => SetArgument("allowlist_only", value);
    }

}

/// <summary>
/// Block type for allow_by_default in GoogleIdentityPlatformConfigSmsRegionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowByDefaultBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allow_by_default";

    /// <summary>
    /// Two letter unicode region codes to disallow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json
    /// </summary>
    public TerraformList<string>? DisallowedRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "disallowed_regions").ResolveNodes(ctx));
        set => SetArgument("disallowed_regions", value);
    }

}

/// <summary>
/// Block type for allowlist_only in GoogleIdentityPlatformConfigSmsRegionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSmsRegionConfigBlockAllowlistOnlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowlist_only";

    /// <summary>
    /// Two letter unicode region codes to allow as defined by https://cldr.unicode.org/ The full list of these region codes is here: https://github.com/unicode-cldr/cldr-localenames-full/blob/master/main/en/territories.json
    /// </summary>
    public TerraformList<string>? AllowedRegions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_regions").ResolveNodes(ctx));
        set => SetArgument("allowed_regions", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIdentityPlatformConfig.
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformConfigTimeoutsBlock : TerraformBlock
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
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
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
/// Represents a google_identity_platform_config Terraform resource.
/// Manages a google_identity_platform_config resource.
/// </summary>
public partial class GoogleIdentityPlatformConfig(string name) : TerraformResource("google_identity_platform_config", name)
{
    /// <summary>
    /// List of domains authorized for OAuth redirects.
    /// </summary>
    public TerraformList<string> AuthorizedDomains
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "authorized_domains").ResolveNodes(ctx));
        set => SetArgument("authorized_domains", value);
    }

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    public TerraformValue<bool>? AutodeleteAnonymousUsers
    {
        get => new TerraformReference<bool>(this, "autodelete_anonymous_users");
        set => SetArgument("autodelete_anonymous_users", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// BlockingFunctions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockingFunctions block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigBlockingFunctionsBlock>? BlockingFunctions
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigBlockingFunctionsBlock>>("blocking_functions");
        set => SetArgument("blocking_functions", value);
    }

    /// <summary>
    /// Client block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Client block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigClientBlock>? Client
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigClientBlock>>("client");
        set => SetArgument("client", value);
    }

    /// <summary>
    /// Mfa block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mfa block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigMfaBlock>? Mfa
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMfaBlock>>("mfa");
        set => SetArgument("mfa", value);
    }

    /// <summary>
    /// Monitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigMonitoringBlock>? Monitoring
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMonitoringBlock>>("monitoring");
        set => SetArgument("monitoring", value);
    }

    /// <summary>
    /// MultiTenant block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTenant block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigMultiTenantBlock>? MultiTenant
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigMultiTenantBlock>>("multi_tenant");
        set => SetArgument("multi_tenant", value);
    }

    /// <summary>
    /// Quota block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigQuotaBlock>? Quota
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigQuotaBlock>>("quota");
        set => SetArgument("quota", value);
    }

    /// <summary>
    /// SignIn block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSignInBlock>? SignIn
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSignInBlock>>("sign_in");
        set => SetArgument("sign_in", value);
    }

    /// <summary>
    /// SmsRegionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsRegionConfig block(s) allowed")]
    public TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlock>? SmsRegionConfig
    {
        get => GetArgument<TerraformList<GoogleIdentityPlatformConfigSmsRegionConfigBlock>>("sms_region_config");
        set => SetArgument("sms_region_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIdentityPlatformConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIdentityPlatformConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

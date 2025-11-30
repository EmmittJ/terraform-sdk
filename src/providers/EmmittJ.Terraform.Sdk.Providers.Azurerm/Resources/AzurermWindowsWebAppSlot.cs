using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings";

    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    public TerraformMap<string>? AdditionalLoginParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_login_parameters").ResolveNodes(ctx));
        set => SetArgument("additional_login_parameters", value);
    }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    public TerraformList<string> AllowedExternalRedirectUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_external_redirect_urls").ResolveNodes(ctx));
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    public TerraformValue<string> DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    public TerraformValue<string> RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => new TerraformReference<double>(this, "token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => new TerraformReference<bool>(this, "token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    public TerraformValue<string> UnauthenticatedClientAction
    {
        get => new TerraformReference<string>(this, "unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Github block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Github block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockGithubBlock>? Github
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockGithubBlock>>("github");
        set => SetArgument("github", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_audiences").ResolveNodes(ctx));
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

}

/// <summary>
/// Block type for facebook in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockFacebookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "facebook";

    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? AppSecret
    {
        get => new TerraformReference<string>(this, "app_secret");
        set => SetArgument("app_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    public TerraformValue<string>? AppSecretSettingName
    {
        get => new TerraformReference<string>(this, "app_secret_setting_name");
        set => SetArgument("app_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for github in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockGithubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github";

    /// <summary>
    /// The ID of the GitHub app used for login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for google in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockGoogleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google";

    /// <summary>
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &amp;quot;openid&amp;quot;, &amp;quot;profile&amp;quot;, and &amp;quot;email&amp;quot; are used as default scopes.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for microsoft in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockMicrosoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft";

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for twitter in AzurermWindowsWebAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlockTwitterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "twitter";

    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerKey is required")]
    public required TerraformValue<string> ConsumerKey
    {
        get => new TerraformReference<string>(this, "consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ConsumerSecret
    {
        get => new TerraformReference<string>(this, "consumer_secret");
        set => SetArgument("consumer_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    public TerraformValue<string>? ConsumerSecretSettingName
    {
        get => new TerraformReference<string>(this, "consumer_secret_setting_name");
        set => SetArgument("consumer_secret_setting_name", value);
    }

}


/// <summary>
/// Block type for auth_settings_v2 in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings_v2";

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? AuthEnabled
    {
        get => new TerraformReference<bool>(this, "auth_enabled");
        set => SetArgument("auth_enabled", value);
    }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    public TerraformValue<string>? ConfigFilePath
    {
        get => new TerraformReference<string>(this, "config_file_path");
        set => SetArgument("config_file_path", value);
    }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    public TerraformValue<string>? DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    public TerraformList<string>? ExcludedPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_paths").ResolveNodes(ctx));
        set => SetArgument("excluded_paths", value);
    }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    public TerraformValue<string>? ForwardProxyConvention
    {
        get => new TerraformReference<string>(this, "forward_proxy_convention");
        set => SetArgument("forward_proxy_convention", value);
    }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    public TerraformValue<string>? ForwardProxyCustomHostHeaderName
    {
        get => new TerraformReference<string>(this, "forward_proxy_custom_host_header_name");
        set => SetArgument("forward_proxy_custom_host_header_name", value);
    }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    public TerraformValue<string>? ForwardProxyCustomSchemeHeaderName
    {
        get => new TerraformReference<string>(this, "forward_proxy_custom_scheme_header_name");
        set => SetArgument("forward_proxy_custom_scheme_header_name", value);
    }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    public TerraformValue<string>? HttpRouteApiPrefix
    {
        get => new TerraformReference<string>(this, "http_route_api_prefix");
        set => SetArgument("http_route_api_prefix", value);
    }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    public TerraformValue<bool>? RequireAuthentication
    {
        get => new TerraformReference<bool>(this, "require_authentication");
        set => SetArgument("require_authentication", value);
    }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    public TerraformValue<bool>? RequireHttps
    {
        get => new TerraformReference<bool>(this, "require_https");
        set => SetArgument("require_https", value);
    }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    public TerraformValue<string>? UnauthenticatedAction
    {
        get => new TerraformReference<string>(this, "unauthenticated_action");
        set => SetArgument("unauthenticated_action", value);
    }

    /// <summary>
    /// ActiveDirectoryV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockActiveDirectoryV2Block>? ActiveDirectoryV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockActiveDirectoryV2Block>>("active_directory_v2");
        set => SetArgument("active_directory_v2", value);
    }

    /// <summary>
    /// AppleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppleV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockAppleV2Block>? AppleV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockAppleV2Block>>("apple_v2");
        set => SetArgument("apple_v2", value);
    }

    /// <summary>
    /// AzureStaticWebAppV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureStaticWebAppV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block>? AzureStaticWebAppV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block>>("azure_static_web_app_v2");
        set => SetArgument("azure_static_web_app_v2", value);
    }

    /// <summary>
    /// CustomOidcV2 block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockCustomOidcV2Block>? CustomOidcV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockCustomOidcV2Block>>("custom_oidc_v2");
        set => SetArgument("custom_oidc_v2", value);
    }

    /// <summary>
    /// FacebookV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FacebookV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockFacebookV2Block>? FacebookV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockFacebookV2Block>>("facebook_v2");
        set => SetArgument("facebook_v2", value);
    }

    /// <summary>
    /// GithubV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockGithubV2Block>? GithubV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockGithubV2Block>>("github_v2");
        set => SetArgument("github_v2", value);
    }

    /// <summary>
    /// GoogleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockGoogleV2Block>? GoogleV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockGoogleV2Block>>("google_v2");
        set => SetArgument("google_v2", value);
    }

    /// <summary>
    /// Login block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Login is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Login block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Login block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockLoginBlock> Login
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockLoginBlock>>("login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// MicrosoftV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockMicrosoftV2Block>? MicrosoftV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockMicrosoftV2Block>>("microsoft_v2");
        set => SetArgument("microsoft_v2", value);
    }

    /// <summary>
    /// TwitterV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TwitterV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockTwitterV2Block>? TwitterV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2BlockTwitterV2Block>>("twitter_v2");
        set => SetArgument("twitter_v2", value);
    }

}

/// <summary>
/// Block type for active_directory_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockActiveDirectoryV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory_v2";

    /// <summary>
    /// The list of allowed Applications for the Default Authorisation Policy.
    /// </summary>
    public TerraformList<string>? AllowedApplications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_applications").ResolveNodes(ctx));
        set => SetArgument("allowed_applications", value);
    }

    /// <summary>
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_audiences").ResolveNodes(ctx));
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// </summary>
    public TerraformList<string>? AllowedGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_groups").ResolveNodes(ctx));
        set => SetArgument("allowed_groups", value);
    }

    /// <summary>
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// </summary>
    public TerraformList<string>? AllowedIdentities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_identities").ResolveNodes(ctx));
        set => SetArgument("allowed_identities", value);
    }

    /// <summary>
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The thumbprint of the certificate used for signing purposes.
    /// </summary>
    public TerraformValue<string>? ClientSecretCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "client_secret_certificate_thumbprint");
        set => SetArgument("client_secret_certificate_thumbprint", value);
    }

    /// <summary>
    /// The App Setting name that contains the client secret of the Client.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// A list of Allowed Client Applications in the JWT Claim.
    /// </summary>
    public TerraformList<string>? JwtAllowedClientApplications
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "jwt_allowed_client_applications").ResolveNodes(ctx));
        set => SetArgument("jwt_allowed_client_applications", value);
    }

    /// <summary>
    /// A list of Allowed Groups in the JWT Claim.
    /// </summary>
    public TerraformList<string>? JwtAllowedGroups
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "jwt_allowed_groups").ResolveNodes(ctx));
        set => SetArgument("jwt_allowed_groups", value);
    }

    /// <summary>
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// </summary>
    public TerraformMap<string>? LoginParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "login_parameters").ResolveNodes(ctx));
        set => SetArgument("login_parameters", value);
    }

    /// <summary>
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantAuthEndpoint is required")]
    public required TerraformValue<string> TenantAuthEndpoint
    {
        get => new TerraformReference<string>(this, "tenant_auth_endpoint");
        set => SetArgument("tenant_auth_endpoint", value);
    }

    /// <summary>
    /// Should the www-authenticate provider should be omitted from the request? Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? WwwAuthenticationDisabled
    {
        get => new TerraformReference<bool>(this, "www_authentication_disabled");
        set => SetArgument("www_authentication_disabled", value);
    }

}

/// <summary>
/// Block type for apple_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockAppleV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apple_v2";

    /// <summary>
    /// The OpenID Connect Client ID for the Apple web application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Apple Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The login_scopes attribute.
    /// </summary>
    public TerraformList<string> LoginScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "login_scopes").ResolveNodes(ctx));
    }

}

/// <summary>
/// Block type for azure_static_web_app_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_static_web_app_v2";

    /// <summary>
    /// The ID of the Client to use to authenticate with Azure Static Web App Authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

}

/// <summary>
/// Block type for custom_oidc_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockCustomOidcV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_oidc_v2";

    /// <summary>
    /// The endpoint to make the Authorisation Request.
    /// </summary>
    public TerraformValue<string> AuthorisationEndpoint
    {
        get => new TerraformReference<string>(this, "authorisation_endpoint");
    }

    /// <summary>
    /// The endpoint that provides the keys necessary to validate the token.
    /// </summary>
    public TerraformValue<string> CertificationUri
    {
        get => new TerraformReference<string>(this, "certification_uri");
    }

    /// <summary>
    /// The Client Credential Method used. Currently the only supported value is `ClientSecretPost`.
    /// </summary>
    public TerraformValue<string> ClientCredentialMethod
    {
        get => new TerraformReference<string>(this, "client_credential_method");
    }

    /// <summary>
    /// The ID of the Client to use to authenticate with this Custom OIDC.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The App Setting name that contains the secret for this Custom OIDC Client.
    /// </summary>
    public TerraformValue<string> ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
    }

    /// <summary>
    /// The endpoint that issued the Token.
    /// </summary>
    public TerraformValue<string> IssuerEndpoint
    {
        get => new TerraformReference<string>(this, "issuer_endpoint");
    }

    /// <summary>
    /// The name of the Custom OIDC Authentication Provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the claim that contains the users name.
    /// </summary>
    public TerraformValue<string>? NameClaimType
    {
        get => new TerraformReference<string>(this, "name_claim_type");
        set => SetArgument("name_claim_type", value);
    }

    /// <summary>
    /// The endpoint that contains all the configuration endpoints for this Custom OIDC provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidConfigurationEndpoint is required")]
    public required TerraformValue<string> OpenidConfigurationEndpoint
    {
        get => new TerraformReference<string>(this, "openid_configuration_endpoint");
        set => SetArgument("openid_configuration_endpoint", value);
    }

    /// <summary>
    /// The list of the scopes that should be requested while authenticating.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The endpoint used to request a Token.
    /// </summary>
    public TerraformValue<string> TokenEndpoint
    {
        get => new TerraformReference<string>(this, "token_endpoint");
    }

}

/// <summary>
/// Block type for facebook_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockFacebookV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "facebook_v2";

    /// <summary>
    /// The App ID of the Facebook app used for login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `app_secret` value used for Facebook Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSecretSettingName is required")]
    public required TerraformValue<string> AppSecretSettingName
    {
        get => new TerraformReference<string>(this, "app_secret_setting_name");
        set => SetArgument("app_secret_setting_name", value);
    }

    /// <summary>
    /// The version of the Facebook API to be used while logging in.
    /// </summary>
    public TerraformValue<string> GraphApiVersion
    {
        get => new TerraformReference<string>(this, "graph_api_version");
        set => SetArgument("graph_api_version", value);
    }

    /// <summary>
    /// Specifies a list of scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "login_scopes").ResolveNodes(ctx));
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for github_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockGithubV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_v2";

    /// <summary>
    /// The ID of the GitHub app used for login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for GitHub Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "login_scopes").ResolveNodes(ctx));
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for google_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockGoogleV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_v2";

    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Google Sign-In authentication.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_audiences").ResolveNodes(ctx));
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Google Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "login_scopes").ResolveNodes(ctx));
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for login in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockLoginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "login";

    /// <summary>
    /// External URLs that can be redirected to as part of logging in or logging out of the app. This is an advanced setting typically only needed by Windows Store application backends. **Note:** URLs within the current domain are always implicitly allowed.
    /// </summary>
    public TerraformList<string>? AllowedExternalRedirectUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_external_redirect_urls").ResolveNodes(ctx));
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.
    /// </summary>
    public TerraformValue<string>? CookieExpirationConvention
    {
        get => new TerraformReference<string>(this, "cookie_expiration_convention");
        set => SetArgument("cookie_expiration_convention", value);
    }

    /// <summary>
    /// The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.
    /// </summary>
    public TerraformValue<string>? CookieExpirationTime
    {
        get => new TerraformReference<string>(this, "cookie_expiration_time");
        set => SetArgument("cookie_expiration_time", value);
    }

    /// <summary>
    /// The endpoint to which logout requests should be made.
    /// </summary>
    public TerraformValue<string>? LogoutEndpoint
    {
        get => new TerraformReference<string>(this, "logout_endpoint");
        set => SetArgument("logout_endpoint", value);
    }

    /// <summary>
    /// The time after the request is made when the nonce should expire. Defaults to `00:05:00`.
    /// </summary>
    public TerraformValue<string>? NonceExpirationTime
    {
        get => new TerraformReference<string>(this, "nonce_expiration_time");
        set => SetArgument("nonce_expiration_time", value);
    }

    /// <summary>
    /// Should the fragments from the request be preserved after the login request is made. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? PreserveUrlFragmentsForLogins
    {
        get => new TerraformReference<bool>(this, "preserve_url_fragments_for_logins");
        set => SetArgument("preserve_url_fragments_for_logins", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionTime
    {
        get => new TerraformReference<double>(this, "token_refresh_extension_time");
        set => SetArgument("token_refresh_extension_time", value);
    }

    /// <summary>
    /// Should the Token Store configuration Enabled. Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => new TerraformReference<bool>(this, "token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// </summary>
    public TerraformValue<string>? TokenStorePath
    {
        get => new TerraformReference<string>(this, "token_store_path");
        set => SetArgument("token_store_path", value);
    }

    /// <summary>
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// </summary>
    public TerraformValue<string>? TokenStoreSasSettingName
    {
        get => new TerraformReference<string>(this, "token_store_sas_setting_name");
        set => SetArgument("token_store_sas_setting_name", value);
    }

    /// <summary>
    /// Should the nonce be validated while completing the login flow. Defaults to `true`.
    /// </summary>
    public TerraformValue<bool>? ValidateNonce
    {
        get => new TerraformReference<bool>(this, "validate_nonce");
        set => SetArgument("validate_nonce", value);
    }

}

/// <summary>
/// Block type for microsoft_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockMicrosoftV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft_v2";

    /// <summary>
    /// Specifies a list of Allowed Audiences that will be requested as part of Microsoft Sign-In authentication.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_audiences").ResolveNodes(ctx));
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => new TerraformReference<string>(this, "client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The list of Login scopes that will be requested as part of Microsoft Account authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "login_scopes").ResolveNodes(ctx));
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for twitter_v2 in AzurermWindowsWebAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsV2BlockTwitterV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "twitter_v2";

    /// <summary>
    /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerKey is required")]
    public required TerraformValue<string> ConsumerKey
    {
        get => new TerraformReference<string>(this, "consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerSecretSettingName is required")]
    public required TerraformValue<string> ConsumerSecretSettingName
    {
        get => new TerraformReference<string>(this, "consumer_secret_setting_name");
        set => SetArgument("consumer_secret_setting_name", value);
    }

}


/// <summary>
/// Block type for backup in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    public required TerraformValue<string> StorageAccountUrl
    {
        get => new TerraformReference<string>(this, "storage_account_url");
        set => SetArgument("storage_account_url", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSlotBackupBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSlotBackupBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermWindowsWebAppSlotBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotBackupBlockScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyInterval is required")]
    public required TerraformValue<double> FrequencyInterval
    {
        get => new TerraformReference<double>(this, "frequency_interval");
        set => SetArgument("frequency_interval", value);
    }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyUnit is required")]
    public required TerraformValue<string> FrequencyUnit
    {
        get => new TerraformReference<string>(this, "frequency_unit");
        set => SetArgument("frequency_unit", value);
    }

    /// <summary>
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? KeepAtLeastOneBackup
    {
        get => new TerraformReference<bool>(this, "keep_at_least_one_backup");
        set => SetArgument("keep_at_least_one_backup", value);
    }

    /// <summary>
    /// The time the backup was last attempted.
    /// </summary>
    public TerraformValue<string> LastExecutionTime
    {
        get => new TerraformReference<string>(this, "last_execution_time");
    }

    /// <summary>
    /// After how many days backups should be deleted.
    /// </summary>
    public TerraformValue<double>? RetentionPeriodDays
    {
        get => new TerraformReference<double>(this, "retention_period_days");
        set => SetArgument("retention_period_days", value);
    }

    /// <summary>
    /// When the schedule should start working in RFC-3339 format.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermWindowsWebAppSlot.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_string";

    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The detailed_error_messages attribute.
    /// </summary>
    public TerraformValue<bool>? DetailedErrorMessages
    {
        get => new TerraformReference<bool>(this, "detailed_error_messages");
        set => SetArgument("detailed_error_messages", value);
    }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    public TerraformValue<bool>? FailedRequestTracing
    {
        get => new TerraformReference<bool>(this, "failed_request_tracing");
        set => SetArgument("failed_request_tracing", value);
    }

    /// <summary>
    /// ApplicationLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationLogs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlock>? ApplicationLogs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlock>>("application_logs");
        set => SetArgument("application_logs", value);
    }

    /// <summary>
    /// HttpLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpLogs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlock>? HttpLogs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlock>>("http_logs");
        set => SetArgument("http_logs", value);
    }

}

/// <summary>
/// Block type for application_logs in AzurermWindowsWebAppSlotLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_logs";

    /// <summary>
    /// The file_system_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemLevel is required")]
    public required TerraformValue<string> FileSystemLevel
    {
        get => new TerraformReference<string>(this, "file_system_level");
        set => SetArgument("file_system_level", value);
    }

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlockApplicationLogsBlockAzureBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage";

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    public required TerraformValue<string> Level
    {
        get => new TerraformReference<string>(this, "level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => new TerraformReference<string>(this, "sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for http_logs in AzurermWindowsWebAppSlotLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlockHttpLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_logs";

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

    /// <summary>
    /// FileSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystem block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockFileSystemBlock>? FileSystem
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockFileSystemBlock>>("file_system");
        set => SetArgument("file_system", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermWindowsWebAppSlotLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockAzureBlobStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage";

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => new TerraformReference<string>(this, "sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for file_system in AzurermWindowsWebAppSlotLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlockHttpLogsBlockFileSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system";

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The retention_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInMb is required")]
    public required TerraformValue<double> RetentionInMb
    {
        get => new TerraformReference<double>(this, "retention_in_mb");
        set => SetArgument("retention_in_mb", value);
    }

}


/// <summary>
/// Block type for site_config in AzurermWindowsWebAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_config";

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformValue<bool>? AlwaysOn
    {
        get => new TerraformReference<bool>(this, "always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    public TerraformValue<string>? ApiDefinitionUrl
    {
        get => new TerraformReference<string>(this, "api_definition_url");
        set => SetArgument("api_definition_url", value);
    }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    public TerraformValue<string>? ApiManagementApiId
    {
        get => new TerraformReference<string>(this, "api_management_api_id");
        set => SetArgument("api_management_api_id", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => new TerraformReference<string>(this, "app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => new TerraformReference<string>(this, "auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId
    {
        get => new TerraformReference<string>(this, "container_registry_managed_identity_client_id");
        set => SetArgument("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity
    {
        get => new TerraformReference<bool>(this, "container_registry_use_managed_identity");
        set => SetArgument("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    public TerraformList<string> DefaultDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "default_documents").ResolveNodes(ctx));
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// The detailed_error_logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DetailedErrorLoggingEnabled
    {
        get => new TerraformReference<bool>(this, "detailed_error_logging_enabled");
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformValue<string>? FtpsState
    {
        get => new TerraformReference<string>(this, "ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformValue<double>? HealthCheckEvictionTimeInMin
    {
        get => new TerraformReference<double>(this, "health_check_eviction_time_in_min");
        set => SetArgument("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => new TerraformReference<string>(this, "health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    public TerraformValue<string>? IpRestrictionDefaultAction
    {
        get => new TerraformReference<string>(this, "ip_restriction_default_action");
        set => SetArgument("ip_restriction_default_action", value);
    }

    /// <summary>
    /// The load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancingMode
    {
        get => new TerraformReference<string>(this, "load_balancing_mode");
        set => SetArgument("load_balancing_mode", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalMysqlEnabled
    {
        get => new TerraformReference<bool>(this, "local_mysql_enabled");
        set => SetArgument("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => new TerraformReference<string>(this, "managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => new TerraformReference<string>(this, "remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    public TerraformValue<string>? ScmIpRestrictionDefaultAction
    {
        get => new TerraformReference<string>(this, "scm_ip_restriction_default_action");
        set => SetArgument("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? ScmMinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "scm_minimum_tls_version");
        set => SetArgument("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => new TerraformReference<bool>(this, "scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker attribute.
    /// </summary>
    public TerraformValue<bool> Use32BitWorker
    {
        get => new TerraformReference<bool>(this, "use_32_bit_worker");
        set => SetArgument("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? VnetRouteAllEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => new TerraformReference<bool>(this, "websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    public TerraformValue<string> WindowsFxVersion
    {
        get => new TerraformReference<string>(this, "windows_fx_version");
    }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformValue<double> WorkerCount
    {
        get => new TerraformReference<double>(this, "worker_count");
        set => SetArgument("worker_count", value);
    }

    /// <summary>
    /// ApplicationStack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationStack block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockApplicationStackBlock>? ApplicationStack
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockApplicationStackBlock>>("application_stack");
        set => SetArgument("application_stack", value);
    }

    /// <summary>
    /// AutoHealSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealSetting block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlock>? AutoHealSetting
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlock>>("auto_heal_setting");
        set => SetArgument("auto_heal_setting", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// HandlerMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockHandlerMappingBlock>? HandlerMapping
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockHandlerMappingBlock>>("handler_mapping");
        set => SetArgument("handler_mapping", value);
    }

    /// <summary>
    /// IpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockIpRestrictionBlock>? IpRestriction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockIpRestrictionBlock>>("ip_restriction");
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// ScmIpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockScmIpRestrictionBlock>? ScmIpRestriction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockScmIpRestrictionBlock>>("scm_ip_restriction");
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// VirtualApplication block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlock>? VirtualApplication
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlock>>("virtual_application");
        set => SetArgument("virtual_application", value);
    }

}

/// <summary>
/// Block type for application_stack in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockApplicationStackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_stack";

    /// <summary>
    /// The current_stack attribute.
    /// </summary>
    public TerraformValue<string> CurrentStack
    {
        get => new TerraformReference<string>(this, "current_stack");
        set => SetArgument("current_stack", value);
    }

    /// <summary>
    /// The docker_image_name attribute.
    /// </summary>
    public TerraformValue<string>? DockerImageName
    {
        get => new TerraformReference<string>(this, "docker_image_name");
        set => SetArgument("docker_image_name", value);
    }

    /// <summary>
    /// The docker_registry_password attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryPassword
    {
        get => new TerraformReference<string>(this, "docker_registry_password");
        set => SetArgument("docker_registry_password", value);
    }

    /// <summary>
    /// The docker_registry_url attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryUrl
    {
        get => new TerraformReference<string>(this, "docker_registry_url");
        set => SetArgument("docker_registry_url", value);
    }

    /// <summary>
    /// The docker_registry_username attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryUsername
    {
        get => new TerraformReference<string>(this, "docker_registry_username");
        set => SetArgument("docker_registry_username", value);
    }

    /// <summary>
    /// The version of DotNetCore to use.
    /// </summary>
    public TerraformValue<string>? DotnetCoreVersion
    {
        get => new TerraformReference<string>(this, "dotnet_core_version");
        set => SetArgument("dotnet_core_version", value);
    }

    /// <summary>
    /// The dotnet_version attribute.
    /// </summary>
    public TerraformValue<string> DotnetVersion
    {
        get => new TerraformReference<string>(this, "dotnet_version");
        set => SetArgument("dotnet_version", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? JavaContainer
    {
        get => new TerraformReference<string>(this, "java_container");
        set => SetArgument("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? JavaContainerVersion
    {
        get => new TerraformReference<string>(this, "java_container_version");
        set => SetArgument("java_container_version", value);
    }

    /// <summary>
    /// Should the application use the embedded web server for the version of Java in use.
    /// </summary>
    public TerraformValue<bool> JavaEmbeddedServerEnabled
    {
        get => new TerraformReference<bool>(this, "java_embedded_server_enabled");
        set => SetArgument("java_embedded_server_enabled", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaVersion
    {
        get => new TerraformReference<string>(this, "java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The node_version attribute.
    /// </summary>
    public TerraformValue<string>? NodeVersion
    {
        get => new TerraformReference<string>(this, "node_version");
        set => SetArgument("node_version", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    public TerraformValue<string> PhpVersion
    {
        get => new TerraformReference<string>(this, "php_version");
        set => SetArgument("php_version", value);
    }

    /// <summary>
    /// The python attribute.
    /// </summary>
    public TerraformValue<bool>? Python
    {
        get => new TerraformReference<bool>(this, "python");
        set => SetArgument("python", value);
    }

    /// <summary>
    /// The tomcat_version attribute.
    /// </summary>
    public TerraformValue<string>? TomcatVersion
    {
        get => new TerraformReference<string>(this, "tomcat_version");
        set => SetArgument("tomcat_version", value);
    }

}

/// <summary>
/// Block type for auto_heal_setting in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_heal_setting";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for action in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => new TerraformReference<string>(this, "action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// The minimum_process_execution_time attribute.
    /// </summary>
    public TerraformValue<string> MinimumProcessExecutionTime
    {
        get => new TerraformReference<string>(this, "minimum_process_execution_time");
        set => SetArgument("minimum_process_execution_time", value);
    }

    /// <summary>
    /// CustomAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomAction block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock>? CustomAction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock>>("custom_action");
        set => SetArgument("custom_action", value);
    }

}

/// <summary>
/// Block type for custom_action in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_action";

    /// <summary>
    /// The executable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Executable is required")]
    public required TerraformValue<string> Executable
    {
        get => new TerraformReference<string>(this, "executable");
        set => SetArgument("executable", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => new TerraformReference<string>(this, "parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for trigger in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The private_memory_kb attribute.
    /// </summary>
    public TerraformValue<double>? PrivateMemoryKb
    {
        get => new TerraformReference<double>(this, "private_memory_kb");
        set => SetArgument("private_memory_kb", value);
    }

    /// <summary>
    /// Requests block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requests block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock>? Requests
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock>>("requests");
        set => SetArgument("requests", value);
    }

    /// <summary>
    /// SlowRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SlowRequest block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock>? SlowRequest
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock>>("slow_request");
        set => SetArgument("slow_request", value);
    }

    /// <summary>
    /// SlowRequestWithPath block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock>? SlowRequestWithPath
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock>>("slow_request_with_path");
        set => SetArgument("slow_request_with_path", value);
    }

    /// <summary>
    /// StatusCode block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock>? StatusCode
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock>>("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for requests in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requests";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

}

/// <summary>
/// Block type for slow_request in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slow_request";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The time_taken attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeTaken is required")]
    public required TerraformValue<string> TimeTaken
    {
        get => new TerraformReference<string>(this, "time_taken");
        set => SetArgument("time_taken", value);
    }

}

/// <summary>
/// Block type for slow_request_with_path in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slow_request_with_path";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The time_taken attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeTaken is required")]
    public required TerraformValue<string> TimeTaken
    {
        get => new TerraformReference<string>(this, "time_taken");
        set => SetArgument("time_taken", value);
    }

}

/// <summary>
/// Block type for status_code in AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "status_code";

    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CountAttribute is required")]
    public required TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => new TerraformReference<string>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The status_code_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCodeRange is required")]
    public required TerraformValue<string> StatusCodeRange
    {
        get => new TerraformReference<string>(this, "status_code_range");
        set => SetArgument("status_code_range", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformValue<double>? SubStatus
    {
        get => new TerraformReference<double>(this, "sub_status");
        set => SetArgument("sub_status", value);
    }

    /// <summary>
    /// The win32_status_code attribute.
    /// </summary>
    public TerraformValue<double>? Win32StatusCode
    {
        get => new TerraformReference<double>(this, "win32_status_code");
        set => SetArgument("win32_status_code", value);
    }

}

/// <summary>
/// Block type for cors in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// Specifies a list of origins that should be allowed to make cross-origin calls.
    /// </summary>
    public TerraformSet<string>? AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? SupportCredentials
    {
        get => new TerraformReference<bool>(this, "support_credentials");
        set => SetArgument("support_credentials", value);
    }

}

/// <summary>
/// Block type for handler_mapping in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockHandlerMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "handler_mapping";

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    public TerraformValue<string>? Arguments
    {
        get => new TerraformReference<string>(this, "arguments");
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    public required TerraformValue<string> Extension
    {
        get => new TerraformReference<string>(this, "extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The script_processor_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptProcessorPath is required")]
    public required TerraformValue<string> ScriptProcessorPath
    {
        get => new TerraformReference<string>(this, "script_processor_path");
        set => SetArgument("script_processor_path", value);
    }

}

/// <summary>
/// Block type for ip_restriction in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockIpRestrictionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_restriction";

    /// <summary>
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description of the IP restriction rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? Headers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority value of this `ip_restriction`.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? ServiceTag
    {
        get => new TerraformReference<string>(this, "service_tag");
        set => SetArgument("service_tag", value);
    }

    /// <summary>
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

}

/// <summary>
/// Block type for scm_ip_restriction in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockScmIpRestrictionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scm_ip_restriction";

    /// <summary>
    /// The action to take. Possible values are `Allow` or `Deny`.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description of the IP restriction rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? Headers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority value of this `ip_restriction`.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? ServiceTag
    {
        get => new TerraformReference<string>(this, "service_tag");
        set => SetArgument("service_tag", value);
    }

    /// <summary>
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

}

/// <summary>
/// Block type for virtual_application in AzurermWindowsWebAppSlotSiteConfigBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_application";

    /// <summary>
    /// The physical_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhysicalPath is required")]
    public required TerraformValue<string> PhysicalPath
    {
        get => new TerraformReference<string>(this, "physical_path");
        set => SetArgument("physical_path", value);
    }

    /// <summary>
    /// The preload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preload is required")]
    public required TerraformValue<bool> Preload
    {
        get => new TerraformReference<bool>(this, "preload");
        set => SetArgument("preload", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformValue<string> VirtualPath
    {
        get => new TerraformReference<string>(this, "virtual_path");
        set => SetArgument("virtual_path", value);
    }

    /// <summary>
    /// VirtualDirectory block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock>? VirtualDirectory
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock>>("virtual_directory");
        set => SetArgument("virtual_directory", value);
    }

}

/// <summary>
/// Block type for virtual_directory in AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_directory";

    /// <summary>
    /// The physical_path attribute.
    /// </summary>
    public TerraformValue<string>? PhysicalPath
    {
        get => new TerraformReference<string>(this, "physical_path");
        set => SetArgument("physical_path", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    public TerraformValue<string>? VirtualPath
    {
        get => new TerraformReference<string>(this, "virtual_path");
        set => SetArgument("virtual_path", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermWindowsWebAppSlot.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSlotStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    public required TerraformValue<string> AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWindowsWebAppSlot.
/// Nesting mode: single
/// </summary>
public class AzurermWindowsWebAppSlotTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_windows_web_app_slot Terraform resource.
/// Manages a azurerm_windows_web_app_slot resource.
/// </summary>
public partial class AzurermWindowsWebAppSlot(string name) : TerraformResource("azurerm_windows_web_app_slot", name)
{
    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    public required TerraformValue<string> AppServiceId
    {
        get => new TerraformReference<string>(this, "app_service_id");
        set => SetArgument("app_service_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "client_affinity_enabled");
        set => SetArgument("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformValue<string>? ClientCertificateExclusionPaths
    {
        get => new TerraformReference<string>(this, "client_certificate_exclusion_paths");
        set => SetArgument("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "ftp_publish_basic_authentication_enabled");
        set => SetArgument("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformValue<string>? ServicePlanId
    {
        get => new TerraformReference<string>(this, "service_plan_id");
        set => SetArgument("service_plan_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_backup_restore_enabled");
        set => SetArgument("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "webdeploy_publish_basic_authentication_enabled");
        set => SetArgument("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.
    /// </summary>
    public TerraformValue<string> ZipDeployFile
    {
        get => new TerraformReference<string>(this, "zip_deploy_file");
        set => SetArgument("zip_deploy_file", value);
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
    {
        get => new TerraformReference<string>(this, "default_hostname");
    }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
    {
        get => new TerraformReference<string>(this, "hosting_environment_id");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "outbound_ip_addresses");
    }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "possible_outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "possible_outbound_ip_addresses");
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "site_credential").ResolveNodes(ctx));
    }

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// AuthSettingsV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2Block>? AuthSettingsV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotAuthSettingsV2Block>>("auth_settings_v2");
        set => SetArgument("auth_settings_v2", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSlotLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSlotLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSlotSiteConfigBlock> SiteConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSlotSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSlotStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSlotStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWindowsWebAppSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWindowsWebAppSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

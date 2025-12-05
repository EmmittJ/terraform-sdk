using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformMap<string>>("additional_login_parameters");
        set => SetArgument("additional_login_parameters", value);
    }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    public TerraformList<string> AllowedExternalRedirectUrls
    {
        get => GetArgument<TerraformList<string>>("allowed_external_redirect_urls") ?? CreateReference("allowed_external_redirect_urls");
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    public TerraformValue<string> DefaultProvider
    {
        get => GetArgument<TerraformValue<string>>("default_provider") ?? CreateReference("default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    public TerraformValue<string> RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version") ?? CreateReference("runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => GetArgument<TerraformValue<double>>("token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    public TerraformValue<string> UnauthenticatedClientAction
    {
        get => GetArgument<TerraformValue<string>>("unauthenticated_client_action") ?? CreateReference("unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Github block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Github block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockGithubBlock>? Github
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockGithubBlock>>("github");
        set => SetArgument("github", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The Client Secret for the Client ID. Cannot be used with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The App Setting name that contains the client secret of the Client. Cannot be used with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

}

/// <summary>
/// Block type for facebook in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockFacebookBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The App Secret of the Facebook app used for Facebook Login. Cannot be specified with `app_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? AppSecret
    {
        get => GetArgument<TerraformValue<string>>("app_secret");
        set => SetArgument("app_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `app_secret` value used for Facebook Login. Cannot be specified with `app_secret`.
    /// </summary>
    public TerraformValue<string>? AppSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("app_secret_setting_name");
        set => SetArgument("app_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for github in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockGithubBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The Client Secret of the GitHub app used for GitHub Login. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for GitHub Login. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for google in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockGoogleBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret associated with the Google web application.  Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Google Login. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. If not specified, &amp;quot;openid&amp;quot;, &amp;quot;profile&amp;quot;, and &amp;quot;email&amp;quot; are used as default scopes.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for microsoft in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockMicrosoftBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication. Cannot be specified with `client_secret`.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The list of OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. If not specified, `wl.basic` is used as the default scope.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for twitter in AzurermWindowsWebAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsBlockTwitterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret_setting_name`.
    /// </summary>
    public TerraformValue<string>? ConsumerSecret
    {
        get => GetArgument<TerraformValue<string>>("consumer_secret");
        set => SetArgument("consumer_secret", value);
    }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in. Cannot be specified with `consumer_secret`.
    /// </summary>
    public TerraformValue<string>? ConsumerSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("consumer_secret_setting_name");
        set => SetArgument("consumer_secret_setting_name", value);
    }

}


/// <summary>
/// Block type for auth_settings_v2 in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2Block : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("auth_enabled");
        set => SetArgument("auth_enabled", value);
    }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    public TerraformValue<string>? ConfigFilePath
    {
        get => GetArgument<TerraformValue<string>>("config_file_path");
        set => SetArgument("config_file_path", value);
    }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    public TerraformValue<string>? DefaultProvider
    {
        get => GetArgument<TerraformValue<string>>("default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    public TerraformList<string>? ExcludedPaths
    {
        get => GetArgument<TerraformList<string>>("excluded_paths");
        set => SetArgument("excluded_paths", value);
    }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    public TerraformValue<string>? ForwardProxyConvention
    {
        get => GetArgument<TerraformValue<string>>("forward_proxy_convention");
        set => SetArgument("forward_proxy_convention", value);
    }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    public TerraformValue<string>? ForwardProxyCustomHostHeaderName
    {
        get => GetArgument<TerraformValue<string>>("forward_proxy_custom_host_header_name");
        set => SetArgument("forward_proxy_custom_host_header_name", value);
    }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    public TerraformValue<string>? ForwardProxyCustomSchemeHeaderName
    {
        get => GetArgument<TerraformValue<string>>("forward_proxy_custom_scheme_header_name");
        set => SetArgument("forward_proxy_custom_scheme_header_name", value);
    }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    public TerraformValue<string>? HttpRouteApiPrefix
    {
        get => GetArgument<TerraformValue<string>>("http_route_api_prefix");
        set => SetArgument("http_route_api_prefix", value);
    }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    public TerraformValue<bool>? RequireAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("require_authentication");
        set => SetArgument("require_authentication", value);
    }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    public TerraformValue<bool>? RequireHttps
    {
        get => GetArgument<TerraformValue<bool>>("require_https");
        set => SetArgument("require_https", value);
    }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    public TerraformValue<string>? UnauthenticatedAction
    {
        get => GetArgument<TerraformValue<string>>("unauthenticated_action");
        set => SetArgument("unauthenticated_action", value);
    }

    /// <summary>
    /// ActiveDirectoryV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectoryV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockActiveDirectoryV2Block>? ActiveDirectoryV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockActiveDirectoryV2Block>>("active_directory_v2");
        set => SetArgument("active_directory_v2", value);
    }

    /// <summary>
    /// AppleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppleV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockAppleV2Block>? AppleV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockAppleV2Block>>("apple_v2");
        set => SetArgument("apple_v2", value);
    }

    /// <summary>
    /// AzureStaticWebAppV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureStaticWebAppV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockAzureStaticWebAppV2Block>? AzureStaticWebAppV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockAzureStaticWebAppV2Block>>("azure_static_web_app_v2");
        set => SetArgument("azure_static_web_app_v2", value);
    }

    /// <summary>
    /// CustomOidcV2 block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockCustomOidcV2Block>? CustomOidcV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockCustomOidcV2Block>>("custom_oidc_v2");
        set => SetArgument("custom_oidc_v2", value);
    }

    /// <summary>
    /// FacebookV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FacebookV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockFacebookV2Block>? FacebookV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockFacebookV2Block>>("facebook_v2");
        set => SetArgument("facebook_v2", value);
    }

    /// <summary>
    /// GithubV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockGithubV2Block>? GithubV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockGithubV2Block>>("github_v2");
        set => SetArgument("github_v2", value);
    }

    /// <summary>
    /// GoogleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockGoogleV2Block>? GoogleV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockGoogleV2Block>>("google_v2");
        set => SetArgument("google_v2", value);
    }

    /// <summary>
    /// Login block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Login is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Login block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Login block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockLoginBlock> Login
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockLoginBlock>>("login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// MicrosoftV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockMicrosoftV2Block>? MicrosoftV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockMicrosoftV2Block>>("microsoft_v2");
        set => SetArgument("microsoft_v2", value);
    }

    /// <summary>
    /// TwitterV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TwitterV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockTwitterV2Block>? TwitterV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2BlockTwitterV2Block>>("twitter_v2");
        set => SetArgument("twitter_v2", value);
    }

}

/// <summary>
/// Block type for active_directory_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockActiveDirectoryV2Block : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_applications");
        set => SetArgument("allowed_applications", value);
    }

    /// <summary>
    /// Specifies a list of Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The list of allowed Group Names for the Default Authorisation Policy.
    /// </summary>
    public TerraformList<string>? AllowedGroups
    {
        get => GetArgument<TerraformList<string>>("allowed_groups");
        set => SetArgument("allowed_groups", value);
    }

    /// <summary>
    /// The list of allowed Identities for the Default Authorisation Policy.
    /// </summary>
    public TerraformList<string>? AllowedIdentities
    {
        get => GetArgument<TerraformList<string>>("allowed_identities");
        set => SetArgument("allowed_identities", value);
    }

    /// <summary>
    /// The ID of the Client to use to authenticate with Azure Active Directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The thumbprint of the certificate used for signing purposes.
    /// </summary>
    public TerraformValue<string>? ClientSecretCertificateThumbprint
    {
        get => GetArgument<TerraformValue<string>>("client_secret_certificate_thumbprint");
        set => SetArgument("client_secret_certificate_thumbprint", value);
    }

    /// <summary>
    /// The App Setting name that contains the client secret of the Client.
    /// </summary>
    public TerraformValue<string>? ClientSecretSettingName
    {
        get => GetArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// A list of Allowed Client Applications in the JWT Claim.
    /// </summary>
    public TerraformList<string>? JwtAllowedClientApplications
    {
        get => GetArgument<TerraformList<string>>("jwt_allowed_client_applications");
        set => SetArgument("jwt_allowed_client_applications", value);
    }

    /// <summary>
    /// A list of Allowed Groups in the JWT Claim.
    /// </summary>
    public TerraformList<string>? JwtAllowedGroups
    {
        get => GetArgument<TerraformList<string>>("jwt_allowed_groups");
        set => SetArgument("jwt_allowed_groups", value);
    }

    /// <summary>
    /// A map of key-value pairs to send to the Authorisation Endpoint when a user logs in.
    /// </summary>
    public TerraformMap<string>? LoginParameters
    {
        get => GetArgument<TerraformMap<string>>("login_parameters");
        set => SetArgument("login_parameters", value);
    }

    /// <summary>
    /// The Azure Tenant Endpoint for the Authenticating Tenant. e.g. `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantAuthEndpoint is required")]
    public required TerraformValue<string> TenantAuthEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_auth_endpoint");
        set => SetArgument("tenant_auth_endpoint", value);
    }

    /// <summary>
    /// Should the www-authenticate provider should be omitted from the request? Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? WwwAuthenticationDisabled
    {
        get => GetArgument<TerraformValue<bool>>("www_authentication_disabled");
        set => SetArgument("www_authentication_disabled", value);
    }

}

/// <summary>
/// Block type for apple_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockAppleV2Block : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Apple Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The login_scopes attribute.
    /// </summary>
    public TerraformList<string> LoginScopes
        => CreateReference("login_scopes");

}

/// <summary>
/// Block type for azure_static_web_app_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockAzureStaticWebAppV2Block : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

}

/// <summary>
/// Block type for custom_oidc_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockCustomOidcV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_oidc_v2";

    /// <summary>
    /// The endpoint to make the Authorisation Request.
    /// </summary>
    public TerraformValue<string> AuthorisationEndpoint
        => CreateReference("authorisation_endpoint");

    /// <summary>
    /// The endpoint that provides the keys necessary to validate the token.
    /// </summary>
    public TerraformValue<string> CertificationUri
        => CreateReference("certification_uri");

    /// <summary>
    /// The Client Credential Method used. Currently the only supported value is `ClientSecretPost`.
    /// </summary>
    public TerraformValue<string> ClientCredentialMethod
        => CreateReference("client_credential_method");

    /// <summary>
    /// The ID of the Client to use to authenticate with this Custom OIDC.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The App Setting name that contains the secret for this Custom OIDC Client.
    /// </summary>
    public TerraformValue<string> ClientSecretSettingName
        => CreateReference("client_secret_setting_name");

    /// <summary>
    /// The endpoint that issued the Token.
    /// </summary>
    public TerraformValue<string> IssuerEndpoint
        => CreateReference("issuer_endpoint");

    /// <summary>
    /// The name of the Custom OIDC Authentication Provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the claim that contains the users name.
    /// </summary>
    public TerraformValue<string>? NameClaimType
    {
        get => GetArgument<TerraformValue<string>>("name_claim_type");
        set => SetArgument("name_claim_type", value);
    }

    /// <summary>
    /// The endpoint that contains all the configuration endpoints for this Custom OIDC provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OpenidConfigurationEndpoint is required")]
    public required TerraformValue<string> OpenidConfigurationEndpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("openid_configuration_endpoint");
        set => SetArgument("openid_configuration_endpoint", value);
    }

    /// <summary>
    /// The list of the scopes that should be requested while authenticating.
    /// </summary>
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The endpoint used to request a Token.
    /// </summary>
    public TerraformValue<string> TokenEndpoint
        => CreateReference("token_endpoint");

}

/// <summary>
/// Block type for facebook_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockFacebookV2Block : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `app_secret` value used for Facebook Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSecretSettingName is required")]
    public required TerraformValue<string> AppSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_secret_setting_name");
        set => SetArgument("app_secret_setting_name", value);
    }

    /// <summary>
    /// The version of the Facebook API to be used while logging in.
    /// </summary>
    public TerraformValue<string> GraphApiVersion
    {
        get => GetArgument<TerraformValue<string>>("graph_api_version") ?? CreateReference("graph_api_version");
        set => SetArgument("graph_api_version", value);
    }

    /// <summary>
    /// Specifies a list of scopes to be requested as part of Facebook Login authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => GetArgument<TerraformList<string>>("login_scopes");
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for github_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockGithubV2Block : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for GitHub Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of OAuth 2.0 scopes that will be requested as part of GitHub Login authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => GetArgument<TerraformList<string>>("login_scopes");
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for google_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockGoogleV2Block : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The OpenID Connect Client ID for the Google web application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name that contains the `client_secret` value used for Google Login.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// Specifies a list of Login scopes that will be requested as part of Google Sign-In authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => GetArgument<TerraformList<string>>("login_scopes");
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for login in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockLoginBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_external_redirect_urls");
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The method by which cookies expire. Possible values include: `FixedTime`, and `IdentityProviderDerived`. Defaults to `FixedTime`.
    /// </summary>
    public TerraformValue<string>? CookieExpirationConvention
    {
        get => GetArgument<TerraformValue<string>>("cookie_expiration_convention");
        set => SetArgument("cookie_expiration_convention", value);
    }

    /// <summary>
    /// The time after the request is made when the session cookie should expire. Defaults to `08:00:00`.
    /// </summary>
    public TerraformValue<string>? CookieExpirationTime
    {
        get => GetArgument<TerraformValue<string>>("cookie_expiration_time");
        set => SetArgument("cookie_expiration_time", value);
    }

    /// <summary>
    /// The endpoint to which logout requests should be made.
    /// </summary>
    public TerraformValue<string>? LogoutEndpoint
    {
        get => GetArgument<TerraformValue<string>>("logout_endpoint");
        set => SetArgument("logout_endpoint", value);
    }

    /// <summary>
    /// The time after the request is made when the nonce should expire. Defaults to `00:05:00`.
    /// </summary>
    public TerraformValue<string>? NonceExpirationTime
    {
        get => GetArgument<TerraformValue<string>>("nonce_expiration_time");
        set => SetArgument("nonce_expiration_time", value);
    }

    /// <summary>
    /// Should the fragments from the request be preserved after the login request is made. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? PreserveUrlFragmentsForLogins
    {
        get => GetArgument<TerraformValue<bool>>("preserve_url_fragments_for_logins");
        set => SetArgument("preserve_url_fragments_for_logins", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionTime
    {
        get => GetArgument<TerraformValue<double>>("token_refresh_extension_time");
        set => SetArgument("token_refresh_extension_time", value);
    }

    /// <summary>
    /// Should the Token Store configuration Enabled. Defaults to `false`
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The directory path in the App Filesystem in which the tokens will be stored.
    /// </summary>
    public TerraformValue<string>? TokenStorePath
    {
        get => GetArgument<TerraformValue<string>>("token_store_path");
        set => SetArgument("token_store_path", value);
    }

    /// <summary>
    /// The name of the app setting which contains the SAS URL of the blob storage containing the tokens.
    /// </summary>
    public TerraformValue<string>? TokenStoreSasSettingName
    {
        get => GetArgument<TerraformValue<string>>("token_store_sas_setting_name");
        set => SetArgument("token_store_sas_setting_name", value);
    }

    /// <summary>
    /// Should the nonce be validated while completing the login flow. Defaults to `true`.
    /// </summary>
    public TerraformValue<bool>? ValidateNonce
    {
        get => GetArgument<TerraformValue<bool>>("validate_nonce");
        set => SetArgument("validate_nonce", value);
    }

}

/// <summary>
/// Block type for microsoft_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockMicrosoftV2Block : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The OAuth 2.0 client ID that was created for the app used for authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The app setting name containing the OAuth 2.0 client secret that was created for the app used for authentication.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecretSettingName is required")]
    public required TerraformValue<string> ClientSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret_setting_name");
        set => SetArgument("client_secret_setting_name", value);
    }

    /// <summary>
    /// The list of Login scopes that will be requested as part of Microsoft Account authentication.
    /// </summary>
    public TerraformList<string>? LoginScopes
    {
        get => GetArgument<TerraformList<string>>("login_scopes");
        set => SetArgument("login_scopes", value);
    }

}

/// <summary>
/// Block type for twitter_v2 in AzurermWindowsWebAppAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppAuthSettingsV2BlockTwitterV2Block : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter application used for sign-in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerSecretSettingName is required")]
    public required TerraformValue<string> ConsumerSecretSettingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("consumer_secret_setting_name");
        set => SetArgument("consumer_secret_setting_name", value);
    }

}


/// <summary>
/// Block type for backup in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppBackupBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    public required TerraformValue<string> StorageAccountUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_url");
        set => SetArgument("storage_account_url", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppBackupBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppBackupBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermWindowsWebAppBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppBackupBlockScheduleBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("frequency_interval");
        set => SetArgument("frequency_interval", value);
    }

    /// <summary>
    /// The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrequencyUnit is required")]
    public required TerraformValue<string> FrequencyUnit
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency_unit");
        set => SetArgument("frequency_unit", value);
    }

    /// <summary>
    /// Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? KeepAtLeastOneBackup
    {
        get => GetArgument<TerraformValue<bool>>("keep_at_least_one_backup");
        set => SetArgument("keep_at_least_one_backup", value);
    }

    /// <summary>
    /// The time the backup was last attempted.
    /// </summary>
    public TerraformValue<string> LastExecutionTime
        => CreateReference("last_execution_time");

    /// <summary>
    /// After how many days backups should be deleted.
    /// </summary>
    public TerraformValue<double>? RetentionPeriodDays
    {
        get => GetArgument<TerraformValue<double>>("retention_period_days");
        set => SetArgument("retention_period_days", value);
    }

    /// <summary>
    /// When the schedule should start working in RFC-3339 format.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time") ?? CreateReference("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermWindowsWebApp.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppConnectionStringBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => CreateReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => CreateReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("detailed_error_messages");
        set => SetArgument("detailed_error_messages", value);
    }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    public TerraformValue<bool>? FailedRequestTracing
    {
        get => GetArgument<TerraformValue<bool>>("failed_request_tracing");
        set => SetArgument("failed_request_tracing", value);
    }

    /// <summary>
    /// ApplicationLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationLogs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlockApplicationLogsBlock>? ApplicationLogs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlockApplicationLogsBlock>>("application_logs");
        set => SetArgument("application_logs", value);
    }

    /// <summary>
    /// HttpLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpLogs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlock>? HttpLogs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlock>>("http_logs");
        set => SetArgument("http_logs", value);
    }

}

/// <summary>
/// Block type for application_logs in AzurermWindowsWebAppLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlockApplicationLogsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("file_system_level");
        set => SetArgument("file_system_level", value);
    }

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlockApplicationLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlockApplicationLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermWindowsWebAppLogsBlockApplicationLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlockApplicationLogsBlockAzureBlobStorageBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInDays is required")]
    public required TerraformValue<double> RetentionInDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for http_logs in AzurermWindowsWebAppLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlockHttpLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_logs";

    /// <summary>
    /// AzureBlobStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorage block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlockAzureBlobStorageBlock>? AzureBlobStorage
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlockAzureBlobStorageBlock>>("azure_blob_storage");
        set => SetArgument("azure_blob_storage", value);
    }

    /// <summary>
    /// FileSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileSystem block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlockFileSystemBlock>? FileSystem
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlockHttpLogsBlockFileSystemBlock>>("file_system");
        set => SetArgument("file_system", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage in AzurermWindowsWebAppLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlockHttpLogsBlockAzureBlobStorageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasUrl is required")]
    public required TerraformValue<string> SasUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("sas_url");
        set => SetArgument("sas_url", value);
    }

}

/// <summary>
/// Block type for file_system in AzurermWindowsWebAppLogsBlockHttpLogsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppLogsBlockHttpLogsBlockFileSystemBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The retention_in_mb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInMb is required")]
    public required TerraformValue<double> RetentionInMb
    {
        get => GetRequiredArgument<TerraformValue<double>>("retention_in_mb");
        set => SetArgument("retention_in_mb", value);
    }

}


/// <summary>
/// Block type for site_config in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<bool>>("always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    public TerraformValue<string>? ApiDefinitionUrl
    {
        get => GetArgument<TerraformValue<string>>("api_definition_url");
        set => SetArgument("api_definition_url", value);
    }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    public TerraformValue<string>? ApiManagementApiId
    {
        get => GetArgument<TerraformValue<string>>("api_management_api_id");
        set => SetArgument("api_management_api_id", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => GetArgument<TerraformValue<string>>("app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_managed_identity_client_id");
        set => SetArgument("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity
    {
        get => GetArgument<TerraformValue<bool>>("container_registry_use_managed_identity");
        set => SetArgument("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    public TerraformList<string> DefaultDocuments
    {
        get => GetArgument<TerraformList<string>>("default_documents") ?? CreateReference("default_documents");
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// The detailed_error_logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> DetailedErrorLoggingEnabled
        => CreateReference("detailed_error_logging_enabled");

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformValue<string>? FtpsState
    {
        get => GetArgument<TerraformValue<string>>("ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformValue<double>? HealthCheckEvictionTimeInMin
    {
        get => GetArgument<TerraformValue<double>>("health_check_eviction_time_in_min");
        set => SetArgument("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => GetArgument<TerraformValue<string>>("health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Http2Enabled
    {
        get => GetArgument<TerraformValue<bool>>("http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    public TerraformValue<string>? IpRestrictionDefaultAction
    {
        get => GetArgument<TerraformValue<string>>("ip_restriction_default_action");
        set => SetArgument("ip_restriction_default_action", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformValue<string> LinuxFxVersion
        => CreateReference("linux_fx_version");

    /// <summary>
    /// The load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancingMode
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_mode");
        set => SetArgument("load_balancing_mode", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalMysqlEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_mysql_enabled");
        set => SetArgument("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => GetArgument<TerraformValue<string>>("managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => GetArgument<TerraformValue<string>>("remote_debugging_version") ?? CreateReference("remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    public TerraformValue<string>? ScmIpRestrictionDefaultAction
    {
        get => GetArgument<TerraformValue<string>>("scm_ip_restriction_default_action");
        set => SetArgument("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? ScmMinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("scm_minimum_tls_version");
        set => SetArgument("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformValue<string> ScmType
        => CreateReference("scm_type");

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => GetArgument<TerraformValue<bool>>("scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker attribute.
    /// </summary>
    public TerraformValue<bool>? Use32BitWorker
    {
        get => GetArgument<TerraformValue<bool>>("use_32_bit_worker");
        set => SetArgument("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? VnetRouteAllEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    public TerraformValue<string> WindowsFxVersion
        => CreateReference("windows_fx_version");

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    public TerraformValue<double> WorkerCount
    {
        get => GetArgument<TerraformValue<double>>("worker_count") ?? CreateReference("worker_count");
        set => SetArgument("worker_count", value);
    }

    /// <summary>
    /// ApplicationStack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationStack block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockApplicationStackBlock>? ApplicationStack
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockApplicationStackBlock>>("application_stack");
        set => SetArgument("application_stack", value);
    }

    /// <summary>
    /// AutoHealSetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealSetting block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlock>? AutoHealSetting
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlock>>("auto_heal_setting");
        set => SetArgument("auto_heal_setting", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// HandlerMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSiteConfigBlockHandlerMappingBlock>? HandlerMapping
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSiteConfigBlockHandlerMappingBlock>>("handler_mapping");
        set => SetArgument("handler_mapping", value);
    }

    /// <summary>
    /// IpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockIpRestrictionBlock>? IpRestriction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockIpRestrictionBlock>>("ip_restriction");
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// ScmIpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockScmIpRestrictionBlock>? ScmIpRestriction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockScmIpRestrictionBlock>>("scm_ip_restriction");
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// VirtualApplication block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlock>? VirtualApplication
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlock>>("virtual_application");
        set => SetArgument("virtual_application", value);
    }

}

/// <summary>
/// Block type for application_stack in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockApplicationStackBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("current_stack") ?? CreateReference("current_stack");
        set => SetArgument("current_stack", value);
    }

    /// <summary>
    /// The docker_image_name attribute.
    /// </summary>
    public TerraformValue<string>? DockerImageName
    {
        get => GetArgument<TerraformValue<string>>("docker_image_name");
        set => SetArgument("docker_image_name", value);
    }

    /// <summary>
    /// The docker_registry_password attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryPassword
    {
        get => GetArgument<TerraformValue<string>>("docker_registry_password");
        set => SetArgument("docker_registry_password", value);
    }

    /// <summary>
    /// The docker_registry_url attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryUrl
    {
        get => GetArgument<TerraformValue<string>>("docker_registry_url");
        set => SetArgument("docker_registry_url", value);
    }

    /// <summary>
    /// The docker_registry_username attribute.
    /// </summary>
    public TerraformValue<string>? DockerRegistryUsername
    {
        get => GetArgument<TerraformValue<string>>("docker_registry_username");
        set => SetArgument("docker_registry_username", value);
    }

    /// <summary>
    /// The version of DotNetCore to use.
    /// </summary>
    public TerraformValue<string>? DotnetCoreVersion
    {
        get => GetArgument<TerraformValue<string>>("dotnet_core_version");
        set => SetArgument("dotnet_core_version", value);
    }

    /// <summary>
    /// The dotnet_version attribute.
    /// </summary>
    public TerraformValue<string> DotnetVersion
    {
        get => GetArgument<TerraformValue<string>>("dotnet_version") ?? CreateReference("dotnet_version");
        set => SetArgument("dotnet_version", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? JavaContainer
    {
        get => GetArgument<TerraformValue<string>>("java_container");
        set => SetArgument("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? JavaContainerVersion
    {
        get => GetArgument<TerraformValue<string>>("java_container_version");
        set => SetArgument("java_container_version", value);
    }

    /// <summary>
    /// Should the application use the embedded web server for the version of Java in use.
    /// </summary>
    public TerraformValue<bool> JavaEmbeddedServerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("java_embedded_server_enabled") ?? CreateReference("java_embedded_server_enabled");
        set => SetArgument("java_embedded_server_enabled", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformValue<string>? JavaVersion
    {
        get => GetArgument<TerraformValue<string>>("java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The node_version attribute.
    /// </summary>
    public TerraformValue<string>? NodeVersion
    {
        get => GetArgument<TerraformValue<string>>("node_version");
        set => SetArgument("node_version", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    public TerraformValue<string> PhpVersion
    {
        get => GetArgument<TerraformValue<string>>("php_version") ?? CreateReference("php_version");
        set => SetArgument("php_version", value);
    }

    /// <summary>
    /// The python attribute.
    /// </summary>
    public TerraformValue<bool>? Python
    {
        get => GetArgument<TerraformValue<bool>>("python");
        set => SetArgument("python", value);
    }

    /// <summary>
    /// The tomcat_version attribute.
    /// </summary>
    public TerraformValue<string>? TomcatVersion
    {
        get => GetArgument<TerraformValue<string>>("tomcat_version");
        set => SetArgument("tomcat_version", value);
    }

}

/// <summary>
/// Block type for auto_heal_setting in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlock : TerraformBlock
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
    public required TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for action in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// The minimum_process_execution_time attribute.
    /// </summary>
    public TerraformValue<string> MinimumProcessExecutionTime
    {
        get => GetArgument<TerraformValue<string>>("minimum_process_execution_time") ?? CreateReference("minimum_process_execution_time");
        set => SetArgument("minimum_process_execution_time", value);
    }

    /// <summary>
    /// CustomAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomAction block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock>? CustomAction
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock>>("custom_action");
        set => SetArgument("custom_action", value);
    }

}

/// <summary>
/// Block type for custom_action in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockActionBlockCustomActionBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("executable");
        set => SetArgument("executable", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for trigger in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("private_memory_kb");
        set => SetArgument("private_memory_kb", value);
    }

    /// <summary>
    /// Requests block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requests block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock>? Requests
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock>>("requests");
        set => SetArgument("requests", value);
    }

    /// <summary>
    /// SlowRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SlowRequest block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock>? SlowRequest
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock>>("slow_request");
        set => SetArgument("slow_request", value);
    }

    /// <summary>
    /// SlowRequestWithPath block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock>? SlowRequestWithPath
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock>>("slow_request_with_path");
        set => SetArgument("slow_request_with_path", value);
    }

    /// <summary>
    /// StatusCode block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock>? StatusCode
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock>>("status_code");
        set => SetArgument("status_code", value);
    }

}

/// <summary>
/// Block type for requests in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockRequestsBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => GetRequiredArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

}

/// <summary>
/// Block type for slow_request in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => GetRequiredArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The time_taken attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeTaken is required")]
    public required TerraformValue<string> TimeTaken
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_taken");
        set => SetArgument("time_taken", value);
    }

}

/// <summary>
/// Block type for slow_request_with_path in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockSlowRequestWithPathBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => GetRequiredArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The time_taken attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeTaken is required")]
    public required TerraformValue<string> TimeTaken
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_taken");
        set => SetArgument("time_taken", value);
    }

}

/// <summary>
/// Block type for status_code in AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockAutoHealSettingBlockTriggerBlockStatusCodeBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<string> Interval
    {
        get => GetRequiredArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The status_code_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatusCodeRange is required")]
    public required TerraformValue<string> StatusCodeRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("status_code_range");
        set => SetArgument("status_code_range", value);
    }

    /// <summary>
    /// The sub_status attribute.
    /// </summary>
    public TerraformValue<double>? SubStatus
    {
        get => GetArgument<TerraformValue<double>>("sub_status");
        set => SetArgument("sub_status", value);
    }

    /// <summary>
    /// The win32_status_code attribute.
    /// </summary>
    public TerraformValue<double>? Win32StatusCode
    {
        get => GetArgument<TerraformValue<double>>("win32_status_code");
        set => SetArgument("win32_status_code", value);
    }

}

/// <summary>
/// Block type for cors in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockCorsBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// Are credentials allowed in CORS requests? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? SupportCredentials
    {
        get => GetArgument<TerraformValue<bool>>("support_credentials");
        set => SetArgument("support_credentials", value);
    }

}

/// <summary>
/// Block type for handler_mapping in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockHandlerMappingBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("arguments");
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    public required TerraformValue<string> Extension
    {
        get => GetRequiredArgument<TerraformValue<string>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The script_processor_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptProcessorPath is required")]
    public required TerraformValue<string> ScriptProcessorPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("script_processor_path");
        set => SetArgument("script_processor_path", value);
    }

}

/// <summary>
/// Block type for ip_restriction in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockIpRestrictionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description of the IP restriction rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? Headers
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority value of this `ip_restriction`.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? ServiceTag
    {
        get => GetArgument<TerraformValue<string>>("service_tag");
        set => SetArgument("service_tag", value);
    }

    /// <summary>
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

}

/// <summary>
/// Block type for scm_ip_restriction in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockScmIpRestrictionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description of the IP restriction rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? Headers
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("headers");
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// The CIDR notation of the IP or IP Range to match. For example: `10.0.0.0/24` or `192.168.10.1/32` or `fe80::/64` or `13.107.6.152/31,13.107.128.0/22`
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name which should be used for this `ip_restriction`.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority value of this `ip_restriction`.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The Service Tag used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? ServiceTag
    {
        get => GetArgument<TerraformValue<string>>("service_tag");
        set => SetArgument("service_tag", value);
    }

    /// <summary>
    /// The Virtual Network Subnet ID used for this IP Restriction.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

}

/// <summary>
/// Block type for virtual_application in AzurermWindowsWebAppSiteConfigBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("physical_path");
        set => SetArgument("physical_path", value);
    }

    /// <summary>
    /// The preload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preload is required")]
    public required TerraformValue<bool> Preload
    {
        get => GetRequiredArgument<TerraformValue<bool>>("preload");
        set => SetArgument("preload", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualPath is required")]
    public required TerraformValue<string> VirtualPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_path");
        set => SetArgument("virtual_path", value);
    }

    /// <summary>
    /// VirtualDirectory block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock>? VirtualDirectory
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock>>("virtual_directory");
        set => SetArgument("virtual_directory", value);
    }

}

/// <summary>
/// Block type for virtual_directory in AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppSiteConfigBlockVirtualApplicationBlockVirtualDirectoryBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("physical_path");
        set => SetArgument("physical_path", value);
    }

    /// <summary>
    /// The virtual_path attribute.
    /// </summary>
    public TerraformValue<string>? VirtualPath
    {
        get => GetArgument<TerraformValue<string>>("virtual_path");
        set => SetArgument("virtual_path", value);
    }

}


/// <summary>
/// Block type for sticky_settings in AzurermWindowsWebApp.
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppStickySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sticky_settings";

    /// <summary>
    /// The app_setting_names attribute.
    /// </summary>
    public TerraformList<string>? AppSettingNames
    {
        get => GetArgument<TerraformList<string>>("app_setting_names");
        set => SetArgument("app_setting_names", value);
    }

    /// <summary>
    /// The connection_string_names attribute.
    /// </summary>
    public TerraformList<string>? ConnectionStringNames
    {
        get => GetArgument<TerraformList<string>>("connection_string_names");
        set => SetArgument("connection_string_names", value);
    }

}


/// <summary>
/// Block type for storage_account in AzurermWindowsWebApp.
/// Nesting mode: set
/// </summary>
public class AzurermWindowsWebAppStorageAccountBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformValue<string>? MountPath
    {
        get => GetArgument<TerraformValue<string>>("mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformValue<string> ShareName
    {
        get => GetRequiredArgument<TerraformValue<string>>("share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWindowsWebApp.
/// Nesting mode: single
/// </summary>
public class AzurermWindowsWebAppTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_windows_web_app Terraform resource.
/// Manages a azurerm_windows_web_app resource.
/// </summary>
public partial class AzurermWindowsWebApp(string name) : TerraformResource("azurerm_windows_web_app", name)
{
    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => GetArgument<TerraformMap<string>>("app_settings");
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientAffinityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_affinity_enabled");
        set => SetArgument("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClientCertificateEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformValue<string>? ClientCertificateExclusionPaths
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_exclusion_paths");
        set => SetArgument("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ftp_publish_basic_authentication_enabled");
        set => SetArgument("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool>? HttpsOnly
    {
        get => GetArgument<TerraformValue<bool>>("https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_reference_identity_id") ?? CreateReference("key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    public required TerraformValue<string> ServicePlanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_plan_id");
        set => SetArgument("service_plan_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("virtual_network_backup_restore_enabled");
        set => SetArgument("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => SetArgument("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    public TerraformValue<string> ZipDeployFile
    {
        get => GetArgument<TerraformValue<string>>("zip_deploy_file") ?? CreateReference("zip_deploy_file");
        set => SetArgument("zip_deploy_file", value);
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => CreateReference("custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
        => CreateReference("default_hostname");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
        => CreateReference("hosting_environment_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => CreateReference("kind");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => CreateReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => CreateReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => CreateReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => CreateReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => CreateReference("site_credential");

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// AuthSettingsV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppAuthSettingsV2Block>? AuthSettingsV2
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppAuthSettingsV2Block>>("auth_settings_v2");
        set => SetArgument("auth_settings_v2", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public required TerraformList<AzurermWindowsWebAppSiteConfigBlock> SiteConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermWindowsWebAppSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// StickySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    public TerraformList<AzurermWindowsWebAppStickySettingsBlock>? StickySettings
    {
        get => GetArgument<TerraformList<AzurermWindowsWebAppStickySettingsBlock>>("sticky_settings");
        set => SetArgument("sticky_settings", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWindowsWebAppStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformSet<AzurermWindowsWebAppStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWindowsWebAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWindowsWebAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

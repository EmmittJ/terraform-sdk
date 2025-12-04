using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermLinuxFunctionAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlock : TerraformBlock
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
        get => GetArgument<TerraformList<string>>("allowed_external_redirect_urls") ?? AsReference("allowed_external_redirect_urls");
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    public TerraformValue<string> DefaultProvider
    {
        get => GetArgument<TerraformValue<string>>("default_provider") ?? AsReference("default_provider");
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
        get => GetArgument<TerraformValue<string>>("runtime_version") ?? AsReference("runtime_version");
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
        get => GetArgument<TerraformValue<string>>("unauthenticated_client_action") ?? AsReference("unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Github block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Github block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockGithubBlock>? Github
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockGithubBlock>>("github");
        set => SetArgument("github", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
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
/// Block type for facebook in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockFacebookBlock : TerraformBlock
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
/// Block type for github in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockGithubBlock : TerraformBlock
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
/// Block type for google in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockGoogleBlock : TerraformBlock
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
/// Block type for microsoft in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockMicrosoftBlock : TerraformBlock
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
/// Block type for twitter in AzurermLinuxFunctionAppSlotAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlockTwitterBlock : TerraformBlock
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
/// Block type for auth_settings_v2 in AzurermLinuxFunctionAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2Block : TerraformBlock
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
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockActiveDirectoryV2Block>? ActiveDirectoryV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockActiveDirectoryV2Block>>("active_directory_v2");
        set => SetArgument("active_directory_v2", value);
    }

    /// <summary>
    /// AppleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppleV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAppleV2Block>? AppleV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAppleV2Block>>("apple_v2");
        set => SetArgument("apple_v2", value);
    }

    /// <summary>
    /// AzureStaticWebAppV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureStaticWebAppV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block>? AzureStaticWebAppV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block>>("azure_static_web_app_v2");
        set => SetArgument("azure_static_web_app_v2", value);
    }

    /// <summary>
    /// CustomOidcV2 block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockCustomOidcV2Block>? CustomOidcV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockCustomOidcV2Block>>("custom_oidc_v2");
        set => SetArgument("custom_oidc_v2", value);
    }

    /// <summary>
    /// FacebookV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FacebookV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockFacebookV2Block>? FacebookV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockFacebookV2Block>>("facebook_v2");
        set => SetArgument("facebook_v2", value);
    }

    /// <summary>
    /// GithubV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGithubV2Block>? GithubV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGithubV2Block>>("github_v2");
        set => SetArgument("github_v2", value);
    }

    /// <summary>
    /// GoogleV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGoogleV2Block>? GoogleV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGoogleV2Block>>("google_v2");
        set => SetArgument("google_v2", value);
    }

    /// <summary>
    /// Login block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Login is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Login block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Login block(s) allowed")]
    public required TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockLoginBlock> Login
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockLoginBlock>>("login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// MicrosoftV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockMicrosoftV2Block>? MicrosoftV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockMicrosoftV2Block>>("microsoft_v2");
        set => SetArgument("microsoft_v2", value);
    }

    /// <summary>
    /// TwitterV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TwitterV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockTwitterV2Block>? TwitterV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2BlockTwitterV2Block>>("twitter_v2");
        set => SetArgument("twitter_v2", value);
    }

}

/// <summary>
/// Block type for active_directory_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockActiveDirectoryV2Block : TerraformBlock
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
/// Block type for apple_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAppleV2Block : TerraformBlock
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
        => AsReference("login_scopes");

}

/// <summary>
/// Block type for azure_static_web_app_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockAzureStaticWebAppV2Block : TerraformBlock
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
/// Block type for custom_oidc_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockCustomOidcV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_oidc_v2";

    /// <summary>
    /// The endpoint to make the Authorisation Request.
    /// </summary>
    public TerraformValue<string> AuthorisationEndpoint
        => AsReference("authorisation_endpoint");

    /// <summary>
    /// The endpoint that provides the keys necessary to validate the token.
    /// </summary>
    public TerraformValue<string> CertificationUri
        => AsReference("certification_uri");

    /// <summary>
    /// The Client Credential Method used. Currently the only supported value is `ClientSecretPost`.
    /// </summary>
    public TerraformValue<string> ClientCredentialMethod
        => AsReference("client_credential_method");

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
        => AsReference("client_secret_setting_name");

    /// <summary>
    /// The endpoint that issued the Token.
    /// </summary>
    public TerraformValue<string> IssuerEndpoint
        => AsReference("issuer_endpoint");

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
        => AsReference("token_endpoint");

}

/// <summary>
/// Block type for facebook_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockFacebookV2Block : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("graph_api_version") ?? AsReference("graph_api_version");
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
/// Block type for github_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGithubV2Block : TerraformBlock
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
/// Block type for google_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockGoogleV2Block : TerraformBlock
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
/// Block type for login in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockLoginBlock : TerraformBlock
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
/// Block type for microsoft_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockMicrosoftV2Block : TerraformBlock
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
/// Block type for twitter_v2 in AzurermLinuxFunctionAppSlotAuthSettingsV2Block.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2BlockTwitterV2Block : TerraformBlock
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
/// Block type for backup in AzurermLinuxFunctionAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotBackupBlock : TerraformBlock
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
    public required TerraformList<AzurermLinuxFunctionAppSlotBackupBlockScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxFunctionAppSlotBackupBlockScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}

/// <summary>
/// Block type for schedule in AzurermLinuxFunctionAppSlotBackupBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotBackupBlockScheduleBlock : TerraformBlock
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
        => AsReference("last_execution_time");

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
        get => GetArgument<TerraformValue<string>>("start_time") ?? AsReference("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermLinuxFunctionAppSlot.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxFunctionAppSlotConnectionStringBlock : TerraformBlock
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
/// Block type for identity in AzurermLinuxFunctionAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotIdentityBlock : TerraformBlock
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
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

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
/// Block type for site_config in AzurermLinuxFunctionAppSlot.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_config";

    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool> AlwaysOn
    {
        get => GetArgument<TerraformValue<bool>>("always_on") ?? AsReference("always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    public TerraformValue<string>? ApiDefinitionUrl
    {
        get => GetArgument<TerraformValue<string>>("api_definition_url");
        set => SetArgument("api_definition_url", value);
    }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    public TerraformValue<string>? ApiManagementApiId
    {
        get => GetArgument<TerraformValue<string>>("api_management_api_id");
        set => SetArgument("api_management_api_id", value);
    }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => GetArgument<TerraformValue<string>>("app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    public TerraformValue<double> AppScaleLimit
    {
        get => GetArgument<TerraformValue<double>>("app_scale_limit") ?? AsReference("app_scale_limit");
        set => SetArgument("app_scale_limit", value);
    }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    public TerraformValue<string>? ApplicationInsightsConnectionString
    {
        get => GetArgument<TerraformValue<string>>("application_insights_connection_string");
        set => SetArgument("application_insights_connection_string", value);
    }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    public TerraformValue<string>? ApplicationInsightsKey
    {
        get => GetArgument<TerraformValue<string>>("application_insights_key");
        set => SetArgument("application_insights_key", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => GetArgument<TerraformValue<string>>("auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_managed_identity_client_id");
        set => SetArgument("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity
    {
        get => GetArgument<TerraformValue<bool>>("container_registry_use_managed_identity");
        set => SetArgument("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    public TerraformList<string> DefaultDocuments
    {
        get => GetArgument<TerraformList<string>>("default_documents") ?? AsReference("default_documents");
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// Is detailed error logging enabled
    /// </summary>
    public TerraformValue<bool> DetailedErrorLoggingEnabled
        => AsReference("detailed_error_logging_enabled");

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    public TerraformValue<double> ElasticInstanceMinimum
    {
        get => GetArgument<TerraformValue<double>>("elastic_instance_minimum") ?? AsReference("elastic_instance_minimum");
        set => SetArgument("elastic_instance_minimum", value);
    }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    public TerraformValue<string>? FtpsState
    {
        get => GetArgument<TerraformValue<string>>("ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformValue<double>? HealthCheckEvictionTimeInMin
    {
        get => GetArgument<TerraformValue<double>>("health_check_eviction_time_in_min");
        set => SetArgument("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => GetArgument<TerraformValue<string>>("health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
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
    /// The Linux FX Version
    /// </summary>
    public TerraformValue<string> LinuxFxVersion
        => AsReference("linux_fx_version");

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    public TerraformValue<string>? LoadBalancingMode
    {
        get => GetArgument<TerraformValue<string>>("load_balancing_mode");
        set => SetArgument("load_balancing_mode", value);
    }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => GetArgument<TerraformValue<string>>("managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    public TerraformValue<double> PreWarmedInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("pre_warmed_instance_count") ?? AsReference("pre_warmed_instance_count");
        set => SetArgument("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => GetArgument<TerraformValue<string>>("remote_debugging_version") ?? AsReference("remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    public TerraformValue<bool>? RuntimeScaleMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("runtime_scale_monitoring_enabled");
        set => SetArgument("runtime_scale_monitoring_enabled", value);
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
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformValue<string>? ScmMinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("scm_minimum_tls_version");
        set => SetArgument("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The SCM Type in use by the Linux Function App.
    /// </summary>
    public TerraformValue<string> ScmType
        => AsReference("scm_type");

    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => GetArgument<TerraformValue<bool>>("scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker.
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
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    public TerraformValue<double> WorkerCount
    {
        get => GetArgument<TerraformValue<double>>("worker_count") ?? AsReference("worker_count");
        set => SetArgument("worker_count", value);
    }

    /// <summary>
    /// AppServiceLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppServiceLogs block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockAppServiceLogsBlock>? AppServiceLogs
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockAppServiceLogsBlock>>("app_service_logs");
        set => SetArgument("app_service_logs", value);
    }

    /// <summary>
    /// ApplicationStack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationStack block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlock>? ApplicationStack
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlock>>("application_stack");
        set => SetArgument("application_stack", value);
    }

    /// <summary>
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

    /// <summary>
    /// IpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockIpRestrictionBlock>? IpRestriction
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockIpRestrictionBlock>>("ip_restriction");
        set => SetArgument("ip_restriction", value);
    }

    /// <summary>
    /// ScmIpRestriction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockScmIpRestrictionBlock>? ScmIpRestriction
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockScmIpRestrictionBlock>>("scm_ip_restriction");
        set => SetArgument("scm_ip_restriction", value);
    }

}

/// <summary>
/// Block type for app_service_logs in AzurermLinuxFunctionAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockAppServiceLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_service_logs";

    /// <summary>
    /// The amount of disk space to use for logs. Valid values are between `25` and `100`.
    /// </summary>
    public TerraformValue<double>? DiskQuotaMb
    {
        get => GetArgument<TerraformValue<double>>("disk_quota_mb");
        set => SetArgument("disk_quota_mb", value);
    }

    /// <summary>
    /// The retention period for logs in days. Valid values are between `0` and `99999`. Defaults to `0` (never delete).
    /// </summary>
    public TerraformValue<double>? RetentionPeriodDays
    {
        get => GetArgument<TerraformValue<double>>("retention_period_days");
        set => SetArgument("retention_period_days", value);
    }

}

/// <summary>
/// Block type for application_stack in AzurermLinuxFunctionAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_stack";

    /// <summary>
    /// The version of .Net. Possible values are `3.1`, `6.0`, `7.0`, `8.0` and `9.0`
    /// </summary>
    public TerraformValue<string>? DotnetVersion
    {
        get => GetArgument<TerraformValue<string>>("dotnet_version");
        set => SetArgument("dotnet_version", value);
    }

    /// <summary>
    /// The version of Java to use. Possible values are `8`, `11`, `17`, and `21`
    /// </summary>
    public TerraformValue<string>? JavaVersion
    {
        get => GetArgument<TerraformValue<string>>("java_version");
        set => SetArgument("java_version", value);
    }

    /// <summary>
    /// The version of Node to use. Possible values include `12`, `14`, `16`, `18`, `20` and `22`
    /// </summary>
    public TerraformValue<string>? NodeVersion
    {
        get => GetArgument<TerraformValue<string>>("node_version");
        set => SetArgument("node_version", value);
    }

    /// <summary>
    /// The version of PowerShell Core to use. Possibles values are `7`, `7.2`, and `7.4`
    /// </summary>
    public TerraformValue<string>? PowershellCoreVersion
    {
        get => GetArgument<TerraformValue<string>>("powershell_core_version");
        set => SetArgument("powershell_core_version", value);
    }

    /// <summary>
    /// The version of Python to use. Possible values include `3.13`, `3.12`, `3.11`, `3.10`, `3.9`, `3.8`, and `3.7`.
    /// </summary>
    public TerraformValue<string>? PythonVersion
    {
        get => GetArgument<TerraformValue<string>>("python_version");
        set => SetArgument("python_version", value);
    }

    /// <summary>
    /// The use_custom_runtime attribute.
    /// </summary>
    public TerraformValue<bool>? UseCustomRuntime
    {
        get => GetArgument<TerraformValue<bool>>("use_custom_runtime");
        set => SetArgument("use_custom_runtime", value);
    }

    /// <summary>
    /// Should the DotNet process use an isolated runtime. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? UseDotnetIsolatedRuntime
    {
        get => GetArgument<TerraformValue<bool>>("use_dotnet_isolated_runtime");
        set => SetArgument("use_dotnet_isolated_runtime", value);
    }

    /// <summary>
    /// Docker block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlockDockerBlock>? Docker
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlockDockerBlock>>("docker");
        set => SetArgument("docker", value);
    }

}

/// <summary>
/// Block type for docker in AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockApplicationStackBlockDockerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker";

    /// <summary>
    /// The name of the Docker image to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The image tag of the image to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageTag is required")]
    public required TerraformValue<string> ImageTag
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_tag");
        set => SetArgument("image_tag", value);
    }

    /// <summary>
    /// The password for the account to use to connect to the registry.
    /// </summary>
    public TerraformValue<string>? RegistryPassword
    {
        get => GetArgument<TerraformValue<string>>("registry_password");
        set => SetArgument("registry_password", value);
    }

    /// <summary>
    /// The URL of the docker registry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryUrl is required")]
    public required TerraformValue<string> RegistryUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("registry_url");
        set => SetArgument("registry_url", value);
    }

    /// <summary>
    /// The username to use for connections to the registry.
    /// </summary>
    public TerraformValue<string>? RegistryUsername
    {
        get => GetArgument<TerraformValue<string>>("registry_username");
        set => SetArgument("registry_username", value);
    }

}

/// <summary>
/// Block type for cors in AzurermLinuxFunctionAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockCorsBlock : TerraformBlock
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
/// Block type for ip_restriction in AzurermLinuxFunctionAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockIpRestrictionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
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
/// Block type for scm_ip_restriction in AzurermLinuxFunctionAppSlotSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlockScmIpRestrictionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
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
/// Block type for storage_account in AzurermLinuxFunctionAppSlot.
/// Nesting mode: set
/// </summary>
public class AzurermLinuxFunctionAppSlotStorageAccountBlock : TerraformBlock
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
/// Block type for timeouts in AzurermLinuxFunctionAppSlot.
/// Nesting mode: single
/// </summary>
public class AzurermLinuxFunctionAppSlotTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_linux_function_app_slot Terraform resource.
/// Manages a azurerm_linux_function_app_slot resource.
/// </summary>
public partial class AzurermLinuxFunctionAppSlot(string name) : TerraformResource("azurerm_linux_function_app_slot", name)
{
    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => GetArgument<TerraformMap<string>>("app_settings");
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    public TerraformValue<bool>? BuiltinLoggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("builtin_logging_enabled");
        set => SetArgument("builtin_logging_enabled", value);
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
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
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    public TerraformValue<bool>? ContentShareForceDisabled
    {
        get => GetArgument<TerraformValue<bool>>("content_share_force_disabled");
        set => SetArgument("content_share_force_disabled", value);
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    public TerraformValue<double>? DailyMemoryTimeQuota
    {
        get => GetArgument<TerraformValue<double>>("daily_memory_time_quota");
        set => SetArgument("daily_memory_time_quota", value);
    }

    /// <summary>
    /// Is the Linux Function App Slot enabled.
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
    /// The ID of the Linux Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformValue<string> FunctionAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_app_id");
        set => SetArgument("function_app_id", value);
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    public TerraformValue<string>? FunctionsExtensionVersion
    {
        get => GetArgument<TerraformValue<string>>("functions_extension_version");
        set => SetArgument("functions_extension_version", value);
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_reference_identity_id") ?? AsReference("key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// Specifies the name of the Function App Slot.
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
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformValue<string>? ServicePlanId
    {
        get => GetArgument<TerraformValue<string>>("service_plan_id");
        set => SetArgument("service_plan_id", value);
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    public TerraformValue<string>? StorageKeyVaultSecretId
    {
        get => GetArgument<TerraformValue<string>>("storage_key_vault_secret_id");
        set => SetArgument("storage_key_vault_secret_id", value);
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    public TerraformValue<bool>? StorageUsesManagedIdentity
    {
        get => GetArgument<TerraformValue<bool>>("storage_uses_managed_identity");
        set => SetArgument("storage_uses_managed_identity", value);
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
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? VnetImagePullEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vnet_image_pull_enabled");
        set => SetArgument("vnet_image_pull_enabled", value);
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
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => AsReference("custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
        => AsReference("default_hostname");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
        => AsReference("hosting_environment_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => AsReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => AsReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => AsReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => AsReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => AsReference("site_credential");

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// AuthSettingsV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>? AuthSettingsV2
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>>("auth_settings_v2");
        set => SetArgument("auth_settings_v2", value);
    }

    /// <summary>
    /// Backup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotBackupBlock>? Backup
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotBackupBlock>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLinuxFunctionAppSlotConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermLinuxFunctionAppSlotConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermLinuxFunctionAppSlotIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermLinuxFunctionAppSlotIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public required TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlock> SiteConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermLinuxFunctionAppSlotSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// StorageAccount block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermLinuxFunctionAppSlotStorageAccountBlock>? StorageAccount
    {
        get => GetArgument<TerraformSet<AzurermLinuxFunctionAppSlotStorageAccountBlock>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLinuxFunctionAppSlotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLinuxFunctionAppSlotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

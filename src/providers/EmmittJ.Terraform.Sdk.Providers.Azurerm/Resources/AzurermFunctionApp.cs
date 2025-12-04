using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auth_settings in AzurermFunctionApp.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings";

    /// <summary>
    /// The additional_login_params attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalLoginParams
    {
        get => GetArgument<TerraformMap<string>>("additional_login_params");
        set => SetArgument("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    public TerraformList<string>? AllowedExternalRedirectUrls
    {
        get => GetArgument<TerraformList<string>>("allowed_external_redirect_urls");
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    public TerraformValue<string>? DefaultProvider
    {
        get => GetArgument<TerraformValue<string>>("default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => GetArgument<TerraformValue<double>>("token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    public TerraformValue<string>? UnauthenticatedClientAction
    {
        get => GetArgument<TerraformValue<string>>("unauthenticated_client_action");
        set => SetArgument("unauthenticated_client_action", value);
    }

    /// <summary>
    /// ActiveDirectory block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActiveDirectory block(s) allowed")]
    public TerraformList<AzurermFunctionAppAuthSettingsBlockActiveDirectoryBlock>? ActiveDirectory
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlockActiveDirectoryBlock>>("active_directory");
        set => SetArgument("active_directory", value);
    }

    /// <summary>
    /// Facebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Facebook block(s) allowed")]
    public TerraformList<AzurermFunctionAppAuthSettingsBlockFacebookBlock>? Facebook
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlockFacebookBlock>>("facebook");
        set => SetArgument("facebook", value);
    }

    /// <summary>
    /// Google block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Google block(s) allowed")]
    public TerraformList<AzurermFunctionAppAuthSettingsBlockGoogleBlock>? Google
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlockGoogleBlock>>("google");
        set => SetArgument("google", value);
    }

    /// <summary>
    /// Microsoft block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Microsoft block(s) allowed")]
    public TerraformList<AzurermFunctionAppAuthSettingsBlockMicrosoftBlock>? Microsoft
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlockMicrosoftBlock>>("microsoft");
        set => SetArgument("microsoft", value);
    }

    /// <summary>
    /// Twitter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Twitter block(s) allowed")]
    public TerraformList<AzurermFunctionAppAuthSettingsBlockTwitterBlock>? Twitter
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlockTwitterBlock>>("twitter");
        set => SetArgument("twitter", value);
    }

}

/// <summary>
/// Block type for active_directory in AzurermFunctionAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlockActiveDirectoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "active_directory";

    /// <summary>
    /// The allowed_audiences attribute.
    /// </summary>
    public TerraformList<string>? AllowedAudiences
    {
        get => GetArgument<TerraformList<string>>("allowed_audiences");
        set => SetArgument("allowed_audiences", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

}

/// <summary>
/// Block type for facebook in AzurermFunctionAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlockFacebookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "facebook";

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => GetArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The app_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppSecret is required")]
    public required TerraformValue<string> AppSecret
    {
        get => GetArgument<TerraformValue<string>>("app_secret");
        set => SetArgument("app_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for google in AzurermFunctionAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlockGoogleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for microsoft in AzurermFunctionAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlockMicrosoftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The oauth_scopes attribute.
    /// </summary>
    public TerraformList<string>? OauthScopes
    {
        get => GetArgument<TerraformList<string>>("oauth_scopes");
        set => SetArgument("oauth_scopes", value);
    }

}

/// <summary>
/// Block type for twitter in AzurermFunctionAppAuthSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlockTwitterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "twitter";

    /// <summary>
    /// The consumer_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerKey is required")]
    public required TerraformValue<string> ConsumerKey
    {
        get => GetArgument<TerraformValue<string>>("consumer_key");
        set => SetArgument("consumer_key", value);
    }

    /// <summary>
    /// The consumer_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerSecret is required")]
    public required TerraformValue<string> ConsumerSecret
    {
        get => GetArgument<TerraformValue<string>>("consumer_secret");
        set => SetArgument("consumer_secret", value);
    }

}


/// <summary>
/// Block type for connection_string in AzurermFunctionApp.
/// Nesting mode: set
/// </summary>
public class AzurermFunctionAppConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_string";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermFunctionApp.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for site_config in AzurermFunctionApp.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppSiteConfigBlock : TerraformBlock
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
    /// The app_scale_limit attribute.
    /// </summary>
    public TerraformValue<double>? AppScaleLimit
    {
        get => GetArgument<TerraformValue<double>>("app_scale_limit");
        set => SetArgument("app_scale_limit", value);
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
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformValue<string>? DotnetFrameworkVersion
    {
        get => GetArgument<TerraformValue<string>>("dotnet_framework_version");
        set => SetArgument("dotnet_framework_version", value);
    }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    public TerraformValue<double>? ElasticInstanceMinimum
    {
        get => GetArgument<TerraformValue<double>>("elastic_instance_minimum");
        set => SetArgument("elastic_instance_minimum", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformValue<string>? FtpsState
    {
        get => GetArgument<TerraformValue<string>>("ftps_state");
        set => SetArgument("ftps_state", value);
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
    /// The ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? IpRestriction
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("ip_restriction");
        set => SetArgument("ip_restriction", value);
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
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformValue<string>? LinuxFxVersion
    {
        get => GetArgument<TerraformValue<string>>("linux_fx_version");
        set => SetArgument("linux_fx_version", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? PreWarmedInstanceCount
    {
        get => GetArgument<TerraformValue<double>>("pre_warmed_instance_count");
        set => SetArgument("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RuntimeScaleMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("runtime_scale_monitoring_enabled");
        set => SetArgument("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? ScmIpRestriction
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("scm_ip_restriction");
        set => SetArgument("scm_ip_restriction", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformValue<string>? ScmType
    {
        get => GetArgument<TerraformValue<string>>("scm_type");
        set => SetArgument("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => GetArgument<TerraformValue<bool>>("scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformValue<bool>? Use32BitWorkerProcess
    {
        get => GetArgument<TerraformValue<bool>>("use_32_bit_worker_process");
        set => SetArgument("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
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
    /// Cors block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cors block(s) allowed")]
    public TerraformList<AzurermFunctionAppSiteConfigBlockCorsBlock>? Cors
    {
        get => GetArgument<TerraformList<AzurermFunctionAppSiteConfigBlockCorsBlock>>("cors");
        set => SetArgument("cors", value);
    }

}

/// <summary>
/// Block type for cors in AzurermFunctionAppSiteConfigBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppSiteConfigBlockCorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors";

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public required TerraformSet<string> AllowedOrigins
    {
        get => GetArgument<TerraformSet<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The support_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? SupportCredentials
    {
        get => GetArgument<TerraformValue<bool>>("support_credentials");
        set => SetArgument("support_credentials", value);
    }

}


/// <summary>
/// Block type for source_control in AzurermFunctionApp.
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppSourceControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_control";

    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformValue<string>? Branch
    {
        get => GetArgument<TerraformValue<string>>("branch");
        set => SetArgument("branch", value);
    }

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    public TerraformValue<bool>? ManualIntegration
    {
        get => GetArgument<TerraformValue<bool>>("manual_integration");
        set => SetArgument("manual_integration", value);
    }

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    public TerraformValue<string>? RepoUrl
    {
        get => GetArgument<TerraformValue<string>>("repo_url");
        set => SetArgument("repo_url", value);
    }

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RollbackEnabled
    {
        get => GetArgument<TerraformValue<bool>>("rollback_enabled");
        set => SetArgument("rollback_enabled", value);
    }

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    public TerraformValue<bool>? UseMercurial
    {
        get => GetArgument<TerraformValue<bool>>("use_mercurial");
        set => SetArgument("use_mercurial", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFunctionApp.
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_function_app Terraform resource.
/// Manages a azurerm_function_app resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermFunctionApp(string name) : TerraformResource("azurerm_function_app", name)
{
    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformValue<string> AppServicePlanId
    {
        get => GetArgument<TerraformValue<string>>("app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => GetArgument<TerraformMap<string>>("app_settings");
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertMode
    {
        get => GetArgument<TerraformValue<string>>("client_cert_mode");
        set => SetArgument("client_cert_mode", value);
    }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformValue<double>? DailyMemoryTimeQuota
    {
        get => GetArgument<TerraformValue<double>>("daily_memory_time_quota");
        set => SetArgument("daily_memory_time_quota", value);
    }

    /// <summary>
    /// The enable_builtin_logging attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBuiltinLogging
    {
        get => GetArgument<TerraformValue<bool>>("enable_builtin_logging");
        set => SetArgument("enable_builtin_logging", value);
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultReferenceIdentityId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformValue<string>? OsType
    {
        get => GetArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformValue<string> StorageAccountAccessKey
    {
        get => GetArgument<TerraformValue<string>>("storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => AsReference("outbound_ip_addresses");

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
    public TerraformList<AzurermFunctionAppAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermFunctionAppAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermFunctionAppConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermFunctionAppConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermFunctionAppIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermFunctionAppIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public TerraformList<AzurermFunctionAppSiteConfigBlock>? SiteConfig
    {
        get => GetArgument<TerraformList<AzurermFunctionAppSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// SourceControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    public TerraformList<AzurermFunctionAppSourceControlBlock>? SourceControl
    {
        get => GetArgument<TerraformList<AzurermFunctionAppSourceControlBlock>>("source_control");
        set => SetArgument("source_control", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

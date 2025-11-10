using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppAuthSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [TerraformPropertyName("additional_login_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [TerraformPropertyName("allowed_external_redirect_urls")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AllowedExternalRedirectUrls { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "allowed_external_redirect_urls");

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [TerraformPropertyName("default_provider")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultProvider { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "default_provider");

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Issuer { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RuntimeVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "runtime_version");

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [TerraformPropertyName("token_refresh_extension_hours")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("token_store_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [TerraformPropertyName("unauthenticated_client_action")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UnauthenticatedClientAction { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "unauthenticated_client_action");

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppAuthSettingsV2Block : ITerraformBlock
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [TerraformPropertyName("auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AuthEnabled { get; set; }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [TerraformPropertyName("config_file_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfigFilePath { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [TerraformPropertyName("default_provider")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [TerraformPropertyName("excluded_paths")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ExcludedPaths { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [TerraformPropertyName("forward_proxy_convention")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    [TerraformPropertyName("forward_proxy_custom_host_header_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [TerraformPropertyName("forward_proxy_custom_scheme_header_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [TerraformPropertyName("http_route_api_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpRouteApiPrefix { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [TerraformPropertyName("require_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [TerraformPropertyName("require_https")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuntimeVersion { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [TerraformPropertyName("unauthenticated_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UnauthenticatedAction { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppBackupBlock : ITerraformBlock
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformPropertyName("storage_account_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountUrl { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxWebAppConnectionStringBlock : ITerraformBlock
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The detailed_error_messages attribute.
    /// </summary>
    [TerraformPropertyName("detailed_error_messages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DetailedErrorMessages { get; set; }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    [TerraformPropertyName("failed_request_tracing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailedRequestTracing { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSiteConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AlwaysOn { get; set; }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    [TerraformPropertyName("api_definition_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_management_api_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    [TerraformPropertyName("app_command_line")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppCommandLine { get; set; }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_managed_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_use_managed_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    [TerraformPropertyName("default_documents")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DefaultDocuments { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "default_documents");

    /// <summary>
    /// The detailed_error_logging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("detailed_error_logging_enabled")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DetailedErrorLoggingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>("", "detailed_error_logging_enabled");

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformPropertyName("ftps_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformPropertyName("health_check_eviction_time_in_min")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    [TerraformPropertyName("ip_restriction_default_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformPropertyName("linux_fx_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinuxFxVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "linux_fx_version");

    /// <summary>
    /// The load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_mysql_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalMysqlEnabled { get; set; }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    [TerraformPropertyName("managed_pipeline_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RemoteDebuggingVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "remote_debugging_version");

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformPropertyName("scm_ip_restriction_default_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("scm_minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScmMinimumTlsVersion { get; set; }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScmType => new TerraformReferenceProperty<TerraformProperty<string>>("", "scm_type");

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("scm_use_main_ip_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker attribute.
    /// </summary>
    [TerraformPropertyName("use_32_bit_worker")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("vnet_route_all_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformPropertyName("websockets_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformPropertyName("worker_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WorkerCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "worker_count");

}

/// <summary>
/// Block type for sticky_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppStickySettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The app_setting_names attribute.
    /// </summary>
    [TerraformPropertyName("app_setting_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AppSettingNames { get; set; }

    /// <summary>
    /// The connection_string_names attribute.
    /// </summary>
    [TerraformPropertyName("connection_string_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ConnectionStringNames { get; set; }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxWebAppStorageAccountBlock : ITerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformPropertyName("access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformPropertyName("mount_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MountPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformPropertyName("share_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxWebAppTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_linux_web_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxWebApp : TerraformResource
{
    public AzurermLinuxWebApp(string name) : base("azurerm_linux_web_app", name)
    {
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AppSettings { get; set; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformPropertyName("client_certificate_exclusion_paths")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ftp_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_reference_identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultReferenceIdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_reference_identity_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    [TerraformPropertyName("service_plan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePlanId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_backup_restore_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The vnet_image_pull_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vnet_image_pull_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [TerraformPropertyName("zip_deploy_file")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipDeployFile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zip_deploy_file");

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppAuthSettingsBlock>>? AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformPropertyName("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppAuthSettingsV2Block>>? AuthSettingsV2 { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppBackupBlock>>? Backup { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppLogsBlock>>? Logs { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for sticky_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    [TerraformPropertyName("sticky_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppStickySettingsBlock>>? StickySettings { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_account")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppStorageAccountBlock>>? StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxWebAppTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_hostname");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("hosting_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostingEnvironmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosting_environment_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_address_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundIpAddressList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutboundIpAddresses => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_address_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PossibleOutboundIpAddressList => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PossibleOutboundIpAddresses => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "possible_outbound_ip_addresses");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformPropertyName("site_credential")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SiteCredential => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "site_credential");

}

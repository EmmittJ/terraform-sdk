using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlock : ITerraformBlock
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
public class AzurermLinuxFunctionAppSlotAuthSettingsV2Block : ITerraformBlock
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
public class AzurermLinuxFunctionAppSlotBackupBlock : ITerraformBlock
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
public class AzurermLinuxFunctionAppSlotConnectionStringBlock : ITerraformBlock
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
public class AzurermLinuxFunctionAppSlotIdentityBlock : ITerraformBlock
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
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlock : ITerraformBlock
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AlwaysOn { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "always_on");

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [TerraformPropertyName("api_definition_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [TerraformPropertyName("api_management_api_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [TerraformPropertyName("app_command_line")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppCommandLine { get; set; }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [TerraformPropertyName("app_scale_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AppScaleLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "app_scale_limit");

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    [TerraformPropertyName("application_insights_connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationInsightsConnectionString { get; set; }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    [TerraformPropertyName("application_insights_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationInsightsKey { get; set; }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformPropertyName("auto_swap_slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [TerraformPropertyName("container_registry_managed_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [TerraformPropertyName("container_registry_use_managed_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [TerraformPropertyName("default_documents")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DefaultDocuments { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "default_documents");

    /// <summary>
    /// Is detailed error logging enabled
    /// </summary>
    [TerraformPropertyName("detailed_error_logging_enabled")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DetailedErrorLoggingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>("", "detailed_error_logging_enabled");

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [TerraformPropertyName("elastic_instance_minimum")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ElasticInstanceMinimum { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "elastic_instance_minimum");

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [TerraformPropertyName("ftps_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformPropertyName("health_check_eviction_time_in_min")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
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
    /// The Linux FX Version
    /// </summary>
    [TerraformPropertyName("linux_fx_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LinuxFxVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "linux_fx_version");

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [TerraformPropertyName("load_balancing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [TerraformPropertyName("managed_pipeline_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [TerraformPropertyName("pre_warmed_instance_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PreWarmedInstanceCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "pre_warmed_instance_count");

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [TerraformPropertyName("remote_debugging_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RemoteDebuggingVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "remote_debugging_version");

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [TerraformPropertyName("runtime_scale_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformPropertyName("scm_ip_restriction_default_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformPropertyName("scm_minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScmMinimumTlsVersion { get; set; }

    /// <summary>
    /// The SCM Type in use by the Linux Function App.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScmType => new TerraformReferenceProperty<TerraformProperty<string>>("", "scm_type");

    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [TerraformPropertyName("scm_use_main_ip_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker.
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
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("websockets_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [TerraformPropertyName("worker_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> WorkerCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "worker_count");

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxFunctionAppSlotStorageAccountBlock : ITerraformBlock
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
public class AzurermLinuxFunctionAppSlotTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_linux_function_app_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxFunctionAppSlot : TerraformResource
{
    public AzurermLinuxFunctionAppSlot(string name) : base("azurerm_linux_function_app_slot", name)
    {
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AppSettings { get; set; }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    [TerraformPropertyName("builtin_logging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BuiltinLoggingEnabled { get; set; }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
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
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateMode { get; set; }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    [TerraformPropertyName("content_share_force_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContentShareForceDisabled { get; set; }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [TerraformPropertyName("daily_memory_time_quota")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Is the Linux Function App Slot enabled.
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
    /// The ID of the Linux Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformPropertyName("function_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionAppId { get; set; }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    [TerraformPropertyName("functions_extension_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FunctionsExtensionVersion { get; set; }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
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
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [TerraformPropertyName("key_vault_reference_identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultReferenceIdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_reference_identity_id");

    /// <summary>
    /// Specifies the name of the Function App Slot.
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
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("service_plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServicePlanId { get; set; }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountName { get; set; }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [TerraformPropertyName("storage_key_vault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageKeyVaultSecretId { get; set; }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    [TerraformPropertyName("storage_uses_managed_identity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StorageUsesManagedIdentity { get; set; }

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
    /// Is container image pull over virtual network enabled? Defaults to `false`.
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
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotAuthSettingsBlock>>? AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformPropertyName("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>>? AuthSettingsV2 { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotBackupBlock>>? Backup { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermLinuxFunctionAppSlotConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_account")]
    public TerraformSet<TerraformBlock<AzurermLinuxFunctionAppSlotStorageAccountBlock>>? StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxFunctionAppSlotTimeoutsBlock>? Timeouts { get; set; } = new();

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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxFunctionAppSlotAuthSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [TerraformProperty("additional_login_parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [TerraformProperty("allowed_external_redirect_urls")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [TerraformProperty("default_provider")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultProvider { get; set; }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RuntimeVersion { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [TerraformProperty("token_refresh_extension_hours")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [TerraformProperty("token_store_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [TerraformProperty("unauthenticated_client_action")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UnauthenticatedClientAction { get; set; }

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxFunctionAppSlotAuthSettingsV2Block : TerraformBlockBase
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [TerraformProperty("auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AuthEnabled { get; set; }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [TerraformProperty("config_file_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigFilePath { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [TerraformProperty("default_provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [TerraformProperty("excluded_paths")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExcludedPaths { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [TerraformProperty("forward_proxy_convention")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    [TerraformProperty("forward_proxy_custom_host_header_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [TerraformProperty("forward_proxy_custom_scheme_header_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [TerraformProperty("http_route_api_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpRouteApiPrefix { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [TerraformProperty("require_authentication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [TerraformProperty("require_https")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeVersion { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [TerraformProperty("unauthenticated_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UnauthenticatedAction { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxFunctionAppSlotBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformProperty("storage_account_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountUrl { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxFunctionAppSlotConnectionStringBlock : TerraformBlockBase
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxFunctionAppSlotIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxFunctionAppSlotSiteConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("always_on")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AlwaysOn { get; set; }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [TerraformProperty("api_definition_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [TerraformProperty("api_management_api_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [TerraformProperty("app_command_line")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AppCommandLine { get; set; }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [TerraformProperty("app_scale_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AppScaleLimit { get; set; }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    [TerraformProperty("application_insights_connection_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationInsightsConnectionString { get; set; }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    [TerraformProperty("application_insights_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationInsightsKey { get; set; }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformProperty("auto_swap_slot_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [TerraformProperty("container_registry_managed_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [TerraformProperty("container_registry_use_managed_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [TerraformProperty("default_documents")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> DefaultDocuments { get; set; }


    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [TerraformProperty("elastic_instance_minimum")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [TerraformProperty("ftps_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformProperty("health_check_eviction_time_in_min")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    [TerraformProperty("ip_restriction_default_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpRestrictionDefaultAction { get; set; }


    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [TerraformProperty("load_balancing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [TerraformProperty("managed_pipeline_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [TerraformProperty("pre_warmed_instance_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("remote_debugging_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [TerraformProperty("remote_debugging_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [TerraformProperty("runtime_scale_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformProperty("scm_ip_restriction_default_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformProperty("scm_minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ScmMinimumTlsVersion { get; set; }


    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [TerraformProperty("scm_use_main_ip_restriction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker.
    /// </summary>
    [TerraformProperty("use_32_bit_worker")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [TerraformProperty("vnet_route_all_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("websockets_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [TerraformProperty("worker_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> WorkerCount { get; set; }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxFunctionAppSlotStorageAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformProperty("access_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformProperty("mount_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MountPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformProperty("share_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLinuxFunctionAppSlotTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_linux_function_app_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLinuxFunctionAppSlot : TerraformResource
{
    public AzurermLinuxFunctionAppSlot(string name) : base("azurerm_linux_function_app_slot", name)
    {
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AppSettings { get; set; }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    [TerraformProperty("builtin_logging_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BuiltinLoggingEnabled { get; set; }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    [TerraformProperty("client_certificate_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformProperty("client_certificate_exclusion_paths")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificateMode { get; set; }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    [TerraformProperty("content_share_force_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ContentShareForceDisabled { get; set; }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [TerraformProperty("daily_memory_time_quota")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// Is the Linux Function App Slot enabled.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("ftp_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The ID of the Linux Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformProperty("function_app_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionAppId { get; set; }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    [TerraformProperty("functions_extension_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FunctionsExtensionVersion { get; set; }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [TerraformProperty("key_vault_reference_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultReferenceIdentityId { get; set; }

    /// <summary>
    /// Specifies the name of the Function App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformProperty("service_plan_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServicePlanId { get; set; }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    [TerraformProperty("storage_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountName { get; set; }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [TerraformProperty("storage_key_vault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageKeyVaultSecretId { get; set; }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    [TerraformProperty("storage_uses_managed_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StorageUsesManagedIdentity { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_network_backup_restore_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    [TerraformProperty("vnet_image_pull_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformProperty("auth_settings")]
    public partial TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotAuthSettingsBlock>>? AuthSettings { get; set; }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformProperty("auth_settings_v2")]
    public partial TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>>? AuthSettingsV2 { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformProperty("backup")]
    public partial TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connection_string")]
    public partial TerraformSet<TerraformBlock<AzurermLinuxFunctionAppSlotConnectionStringBlock>>? ConnectionString { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformProperty("site_config")]
    public partial TerraformList<TerraformBlock<AzurermLinuxFunctionAppSlotSiteConfigBlock>>? SiteConfig { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("storage_account")]
    public partial TerraformSet<TerraformBlock<AzurermLinuxFunctionAppSlotStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLinuxFunctionAppSlotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformProperty("hosting_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostingEnvironmentId { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundIpAddressList { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PossibleOutboundIpAddressList { get; }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PossibleOutboundIpAddresses { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteCredential { get; }

}

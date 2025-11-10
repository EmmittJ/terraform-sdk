using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalLoginParameters
    {
        set => SetProperty("additional_login_parameters", value);
    }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedExternalRedirectUrls
    {
        set => SetProperty("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        set => SetProperty("default_provider", value);
    }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformProperty<double>? TokenRefreshExtensionHours
    {
        set => SetProperty("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? TokenStoreEnabled
    {
        set => SetProperty("token_store_enabled", value);
    }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedClientAction
    {
        set => SetProperty("unauthenticated_client_action", value);
    }

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotAuthSettingsV2Block : TerraformBlock
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? AuthEnabled
    {
        set => SetProperty("auth_enabled", value);
    }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    public TerraformProperty<string>? ConfigFilePath
    {
        set => SetProperty("config_file_path", value);
    }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        set => SetProperty("default_provider", value);
    }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedPaths
    {
        set => SetProperty("excluded_paths", value);
    }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    public TerraformProperty<string>? ForwardProxyConvention
    {
        set => SetProperty("forward_proxy_convention", value);
    }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    public TerraformProperty<string>? ForwardProxyCustomHostHeaderName
    {
        set => SetProperty("forward_proxy_custom_host_header_name", value);
    }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    public TerraformProperty<string>? ForwardProxyCustomSchemeHeaderName
    {
        set => SetProperty("forward_proxy_custom_scheme_header_name", value);
    }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    public TerraformProperty<string>? HttpRouteApiPrefix
    {
        set => SetProperty("http_route_api_prefix", value);
    }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    public TerraformProperty<bool>? RequireAuthentication
    {
        set => SetProperty("require_authentication", value);
    }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? RequireHttps
    {
        set => SetProperty("require_https", value);
    }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedAction
    {
        set => SetProperty("unauthenticated_action", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotBackupBlock : TerraformBlock
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    public required TerraformProperty<string> StorageAccountUrl
    {
        set => SetProperty("storage_account_url", value);
    }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsFunctionAppSlotConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// If this Windows Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        set => SetProperty("always_on", value);
    }

    /// <summary>
    /// The URL of the API definition that describes this Windows Function App.
    /// </summary>
    public TerraformProperty<string>? ApiDefinitionUrl
    {
        set => SetProperty("api_definition_url", value);
    }

    /// <summary>
    /// The ID of the API Management API for this Windows Function App.
    /// </summary>
    public TerraformProperty<string>? ApiManagementApiId
    {
        set => SetProperty("api_management_api_id", value);
    }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    public TerraformProperty<string>? AppCommandLine
    {
        set => SetProperty("app_command_line", value);
    }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    public TerraformProperty<double>? AppScaleLimit
    {
        set => SetProperty("app_scale_limit", value);
    }

    /// <summary>
    /// The Connection String for linking the Windows Function App to Application Insights.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsConnectionString
    {
        set => SetProperty("application_insights_connection_string", value);
    }

    /// <summary>
    /// The Instrumentation Key for connecting the Windows Function App to Application Insights.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsKey
    {
        set => SetProperty("application_insights_key", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutoSwapSlotName
    {
        set => SetProperty("auto_swap_slot_name", value);
    }

    /// <summary>
    /// Specifies a list of Default Documents for the Windows Web App.
    /// </summary>
    public List<TerraformProperty<string>>? DefaultDocuments
    {
        set => SetProperty("default_documents", value);
    }

    /// <summary>
    /// Is detailed error logging enabled
    /// </summary>
    public TerraformProperty<bool>? DetailedErrorLoggingEnabled
    {
        set => SetProperty("detailed_error_logging_enabled", value);
    }

    /// <summary>
    /// The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    public TerraformProperty<double>? ElasticInstanceMinimum
    {
        set => SetProperty("elastic_instance_minimum", value);
    }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        set => SetProperty("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformProperty<double>? HealthCheckEvictionTimeInMin
    {
        set => SetProperty("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        set => SetProperty("health_check_path", value);
    }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        set => SetProperty("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    public TerraformProperty<string>? IpRestrictionDefaultAction
    {
        set => SetProperty("ip_restriction_default_action", value);
    }

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingMode
    {
        set => SetProperty("load_balancing_mode", value);
    }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    public TerraformProperty<string>? ManagedPipelineMode
    {
        set => SetProperty("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        set => SetProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    public TerraformProperty<double>? PreWarmedInstanceCount
    {
        set => SetProperty("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? RemoteDebuggingEnabled
    {
        set => SetProperty("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    public TerraformProperty<string>? RemoteDebuggingVersion
    {
        set => SetProperty("remote_debugging_version", value);
    }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    public TerraformProperty<bool>? RuntimeScaleMonitoringEnabled
    {
        set => SetProperty("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    public TerraformProperty<string>? ScmIpRestrictionDefaultAction
    {
        set => SetProperty("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformProperty<string>? ScmMinimumTlsVersion
    {
        set => SetProperty("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The SCM Type in use by the Windows Function App.
    /// </summary>
    public TerraformProperty<string>? ScmType
    {
        set => SetProperty("scm_type", value);
    }

    /// <summary>
    /// Should the Windows Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    public TerraformProperty<bool>? ScmUseMainIpRestriction
    {
        set => SetProperty("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// Should the Windows Function App use a 32-bit worker.
    /// </summary>
    public TerraformProperty<bool>? Use32BitWorker
    {
        set => SetProperty("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? VnetRouteAllEnabled
    {
        set => SetProperty("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? WebsocketsEnabled
    {
        set => SetProperty("websockets_enabled", value);
    }

    /// <summary>
    /// The Windows FX Version string.
    /// </summary>
    public TerraformProperty<string>? WindowsFxVersion
    {
        set => SetProperty("windows_fx_version", value);
    }

    /// <summary>
    /// The number of Workers for this Windows Function App.
    /// </summary>
    public TerraformProperty<double>? WorkerCount
    {
        set => SetProperty("worker_count", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsFunctionAppSlotStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    public required TerraformProperty<string> AccessKey
    {
        set => SetProperty("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformProperty<string>? MountPath
    {
        set => SetProperty("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformProperty<string> ShareName
    {
        set => SetProperty("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsFunctionAppSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_windows_function_app_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWindowsFunctionAppSlot : TerraformResource
{
    public AzurermWindowsFunctionAppSlot(string name) : base("azurerm_windows_function_app_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_domain_verification_id");
        SetOutput("default_hostname");
        SetOutput("hosting_environment_id");
        SetOutput("kind");
        SetOutput("outbound_ip_address_list");
        SetOutput("outbound_ip_addresses");
        SetOutput("possible_outbound_ip_address_list");
        SetOutput("possible_outbound_ip_addresses");
        SetOutput("site_credential");
        SetOutput("app_settings");
        SetOutput("builtin_logging_enabled");
        SetOutput("client_certificate_enabled");
        SetOutput("client_certificate_exclusion_paths");
        SetOutput("client_certificate_mode");
        SetOutput("content_share_force_disabled");
        SetOutput("daily_memory_time_quota");
        SetOutput("enabled");
        SetOutput("ftp_publish_basic_authentication_enabled");
        SetOutput("function_app_id");
        SetOutput("functions_extension_version");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("key_vault_reference_identity_id");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("service_plan_id");
        SetOutput("storage_account_access_key");
        SetOutput("storage_account_name");
        SetOutput("storage_key_vault_secret_id");
        SetOutput("storage_uses_managed_identity");
        SetOutput("tags");
        SetOutput("virtual_network_backup_restore_enabled");
        SetOutput("virtual_network_subnet_id");
        SetOutput("vnet_image_pull_enabled");
        SetOutput("webdeploy_publish_basic_authentication_enabled");
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AppSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => SetProperty("app_settings", value);
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    public TerraformProperty<bool> BuiltinLoggingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("builtin_logging_enabled");
        set => SetProperty("builtin_logging_enabled", value);
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    public TerraformProperty<bool> ClientCertificateEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("client_certificate_enabled");
        set => SetProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformProperty<string> ClientCertificateExclusionPaths
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_exclusion_paths");
        set => SetProperty("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    public TerraformProperty<string> ClientCertificateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_mode");
        set => SetProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    public TerraformProperty<bool> ContentShareForceDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("content_share_force_disabled");
        set => SetProperty("content_share_force_disabled", value);
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    public TerraformProperty<double> DailyMemoryTimeQuota
    {
        get => GetRequiredOutput<TerraformProperty<double>>("daily_memory_time_quota");
        set => SetProperty("daily_memory_time_quota", value);
    }

    /// <summary>
    /// Is the Windows Function App Slot enabled.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FtpPublishBasicAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ftp_publish_basic_authentication_enabled");
        set => SetProperty("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The ID of the Windows Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformProperty<string> FunctionAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_app_id");
        set => SetProperty("function_app_id", value);
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    public TerraformProperty<string> FunctionsExtensionVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("functions_extension_version");
        set => SetProperty("functions_extension_version", value);
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    public TerraformProperty<bool> HttpsOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("https_only");
        set => SetProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    public TerraformProperty<string> KeyVaultReferenceIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => SetProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// Specifies the name of the Windows Function App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string> ServicePlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_plan_id");
        set => SetProperty("service_plan_id", value);
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    public TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_access_key");
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    public TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_name");
        set => SetProperty("storage_account_name", value);
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    public TerraformProperty<string> StorageKeyVaultSecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_key_vault_secret_id");
        set => SetProperty("storage_key_vault_secret_id", value);
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    public TerraformProperty<bool> StorageUsesManagedIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_uses_managed_identity");
        set => SetProperty("storage_uses_managed_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> VirtualNetworkBackupRestoreEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("virtual_network_backup_restore_enabled");
        set => SetProperty("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_subnet_id");
        set => SetProperty("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool> VnetImagePullEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vnet_image_pull_enabled");
        set => SetProperty("vnet_image_pull_enabled", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => SetProperty("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermWindowsFunctionAppSlotAuthSettingsBlock>? AuthSettings
    {
        set => SetProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public List<AzurermWindowsFunctionAppSlotAuthSettingsV2Block>? AuthSettingsV2
    {
        set => SetProperty("auth_settings_v2", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermWindowsFunctionAppSlotBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWindowsFunctionAppSlotConnectionStringBlock>? ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWindowsFunctionAppSlotIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermWindowsFunctionAppSlotSiteConfigBlock>? SiteConfig
    {
        set => SetProperty("site_config", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWindowsFunctionAppSlotStorageAccountBlock>? StorageAccount
    {
        set => SetProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWindowsFunctionAppSlotTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default hostname of the Windows Function App Slot.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The Kind value for this Windows Function App Slot.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// A list of outbound IP addresses. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;,&amp;quot;52.143.43.17&amp;quot;]`.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}

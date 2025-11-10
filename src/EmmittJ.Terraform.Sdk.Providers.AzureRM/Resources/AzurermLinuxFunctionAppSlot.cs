using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalLoginParameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_login_parameters");
        set => WithProperty("additional_login_parameters", value);
    }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedExternalRedirectUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_external_redirect_urls");
        set => WithProperty("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        get => GetProperty<TerraformProperty<string>>("default_provider");
        set => WithProperty("default_provider", value);
    }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    public TerraformProperty<double>? TokenRefreshExtensionHours
    {
        get => GetProperty<TerraformProperty<double>>("token_refresh_extension_hours");
        set => WithProperty("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? TokenStoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("token_store_enabled");
        set => WithProperty("token_store_enabled", value);
    }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedClientAction
    {
        get => GetProperty<TerraformProperty<string>>("unauthenticated_client_action");
        set => WithProperty("unauthenticated_client_action", value);
    }

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotAuthSettingsV2Block : TerraformBlock
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? AuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auth_enabled");
        set => WithProperty("auth_enabled", value);
    }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    public TerraformProperty<string>? ConfigFilePath
    {
        get => GetProperty<TerraformProperty<string>>("config_file_path");
        set => WithProperty("config_file_path", value);
    }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        get => GetProperty<TerraformProperty<string>>("default_provider");
        set => WithProperty("default_provider", value);
    }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedPaths
    {
        get => GetProperty<List<TerraformProperty<string>>>("excluded_paths");
        set => WithProperty("excluded_paths", value);
    }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    public TerraformProperty<string>? ForwardProxyConvention
    {
        get => GetProperty<TerraformProperty<string>>("forward_proxy_convention");
        set => WithProperty("forward_proxy_convention", value);
    }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    public TerraformProperty<string>? ForwardProxyCustomHostHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("forward_proxy_custom_host_header_name");
        set => WithProperty("forward_proxy_custom_host_header_name", value);
    }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    public TerraformProperty<string>? ForwardProxyCustomSchemeHeaderName
    {
        get => GetProperty<TerraformProperty<string>>("forward_proxy_custom_scheme_header_name");
        set => WithProperty("forward_proxy_custom_scheme_header_name", value);
    }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    public TerraformProperty<string>? HttpRouteApiPrefix
    {
        get => GetProperty<TerraformProperty<string>>("http_route_api_prefix");
        set => WithProperty("http_route_api_prefix", value);
    }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    public TerraformProperty<bool>? RequireAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("require_authentication");
        set => WithProperty("require_authentication", value);
    }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? RequireHttps
    {
        get => GetProperty<TerraformProperty<bool>>("require_https");
        set => WithProperty("require_https", value);
    }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedAction
    {
        get => GetProperty<TerraformProperty<string>>("unauthenticated_action");
        set => WithProperty("unauthenticated_action", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotBackupBlock : TerraformBlock
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    public required TerraformProperty<string> StorageAccountUrl
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_url");
        set => WithProperty("storage_account_url", value);
    }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxFunctionAppSlotConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxFunctionAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// If this Linux Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        get => GetProperty<TerraformProperty<bool>>("always_on");
        set => WithProperty("always_on", value);
    }

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    public TerraformProperty<string>? ApiDefinitionUrl
    {
        get => GetProperty<TerraformProperty<string>>("api_definition_url");
        set => WithProperty("api_definition_url", value);
    }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    public TerraformProperty<string>? ApiManagementApiId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_api_id");
        set => WithProperty("api_management_api_id", value);
    }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    public TerraformProperty<string>? AppCommandLine
    {
        get => GetProperty<TerraformProperty<string>>("app_command_line");
        set => WithProperty("app_command_line", value);
    }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    public TerraformProperty<double>? AppScaleLimit
    {
        get => GetProperty<TerraformProperty<double>>("app_scale_limit");
        set => WithProperty("app_scale_limit", value);
    }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("application_insights_connection_string");
        set => WithProperty("application_insights_connection_string", value);
    }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    public TerraformProperty<string>? ApplicationInsightsKey
    {
        get => GetProperty<TerraformProperty<string>>("application_insights_key");
        set => WithProperty("application_insights_key", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutoSwapSlotName
    {
        get => GetProperty<TerraformProperty<string>>("auto_swap_slot_name");
        set => WithProperty("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryManagedIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_managed_identity_client_id");
        set => WithProperty("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    public TerraformProperty<bool>? ContainerRegistryUseManagedIdentity
    {
        get => GetProperty<TerraformProperty<bool>>("container_registry_use_managed_identity");
        set => WithProperty("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    public List<TerraformProperty<string>>? DefaultDocuments
    {
        get => GetProperty<List<TerraformProperty<string>>>("default_documents");
        set => WithProperty("default_documents", value);
    }

    /// <summary>
    /// Is detailed error logging enabled
    /// </summary>
    public TerraformProperty<bool>? DetailedErrorLoggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("detailed_error_logging_enabled");
        set => WithProperty("detailed_error_logging_enabled", value);
    }

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    public TerraformProperty<double>? ElasticInstanceMinimum
    {
        get => GetProperty<TerraformProperty<double>>("elastic_instance_minimum");
        set => WithProperty("elastic_instance_minimum", value);
    }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        get => GetProperty<TerraformProperty<string>>("ftps_state");
        set => WithProperty("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformProperty<double>? HealthCheckEvictionTimeInMin
    {
        get => GetProperty<TerraformProperty<double>>("health_check_eviction_time_in_min");
        set => WithProperty("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        get => GetProperty<TerraformProperty<string>>("health_check_path");
        set => WithProperty("health_check_path", value);
    }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("http2_enabled");
        set => WithProperty("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    public TerraformProperty<string>? IpRestrictionDefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("ip_restriction_default_action");
        set => WithProperty("ip_restriction_default_action", value);
    }

    /// <summary>
    /// The Linux FX Version
    /// </summary>
    public TerraformProperty<string>? LinuxFxVersion
    {
        get => GetProperty<TerraformProperty<string>>("linux_fx_version");
        set => WithProperty("linux_fx_version", value);
    }

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingMode
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_mode");
        set => WithProperty("load_balancing_mode", value);
    }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    public TerraformProperty<string>? ManagedPipelineMode
    {
        get => GetProperty<TerraformProperty<string>>("managed_pipeline_mode");
        set => WithProperty("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    public TerraformProperty<double>? PreWarmedInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("pre_warmed_instance_count");
        set => WithProperty("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? RemoteDebuggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("remote_debugging_enabled");
        set => WithProperty("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    public TerraformProperty<string>? RemoteDebuggingVersion
    {
        get => GetProperty<TerraformProperty<string>>("remote_debugging_version");
        set => WithProperty("remote_debugging_version", value);
    }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    public TerraformProperty<bool>? RuntimeScaleMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("runtime_scale_monitoring_enabled");
        set => WithProperty("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    public TerraformProperty<string>? ScmIpRestrictionDefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("scm_ip_restriction_default_action");
        set => WithProperty("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    public TerraformProperty<string>? ScmMinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("scm_minimum_tls_version");
        set => WithProperty("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The SCM Type in use by the Linux Function App.
    /// </summary>
    public TerraformProperty<string>? ScmType
    {
        get => GetProperty<TerraformProperty<string>>("scm_type");
        set => WithProperty("scm_type", value);
    }

    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    public TerraformProperty<bool>? ScmUseMainIpRestriction
    {
        get => GetProperty<TerraformProperty<bool>>("scm_use_main_ip_restriction");
        set => WithProperty("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// Should the Linux Web App use a 32-bit worker.
    /// </summary>
    public TerraformProperty<bool>? Use32BitWorker
    {
        get => GetProperty<TerraformProperty<bool>>("use_32_bit_worker");
        set => WithProperty("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? VnetRouteAllEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_route_all_enabled");
        set => WithProperty("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? WebsocketsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("websockets_enabled");
        set => WithProperty("websockets_enabled", value);
    }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    public TerraformProperty<double>? WorkerCount
    {
        get => GetProperty<TerraformProperty<double>>("worker_count");
        set => WithProperty("worker_count", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxFunctionAppSlotStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    public required TerraformProperty<string> AccessKey
    {
        get => GetProperty<TerraformProperty<string>>("access_key");
        set => WithProperty("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    public TerraformProperty<string>? MountPath
    {
        get => GetProperty<TerraformProperty<string>>("mount_path");
        set => WithProperty("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    public required TerraformProperty<string> ShareName
    {
        get => GetProperty<TerraformProperty<string>>("share_name");
        set => WithProperty("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxFunctionAppSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_linux_function_app_slot resource.
/// </summary>
public class AzurermLinuxFunctionAppSlot : TerraformResource
{
    public AzurermLinuxFunctionAppSlot(string name) : base("azurerm_linux_function_app_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("hosting_environment_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AppSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    public TerraformProperty<bool>? BuiltinLoggingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("builtin_logging_enabled");
        set => this.WithProperty("builtin_logging_enabled", value);
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    public TerraformProperty<bool>? ClientCertificateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_certificate_enabled");
        set => this.WithProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformProperty<string>? ClientCertificateExclusionPaths
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_exclusion_paths");
        set => this.WithProperty("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => this.WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    public TerraformProperty<bool>? ContentShareForceDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("content_share_force_disabled");
        set => this.WithProperty("content_share_force_disabled", value);
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    public TerraformProperty<double>? DailyMemoryTimeQuota
    {
        get => GetProperty<TerraformProperty<double>>("daily_memory_time_quota");
        set => this.WithProperty("daily_memory_time_quota", value);
    }

    /// <summary>
    /// Is the Linux Function App Slot enabled.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ftp_publish_basic_authentication_enabled");
        set => this.WithProperty("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The ID of the Linux Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformProperty<string> FunctionAppId
    {
        get => GetProperty<TerraformProperty<string>>("function_app_id");
        set => this.WithProperty("function_app_id", value);
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    public TerraformProperty<string>? FunctionsExtensionVersion
    {
        get => GetProperty<TerraformProperty<string>>("functions_extension_version");
        set => this.WithProperty("functions_extension_version", value);
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    public TerraformProperty<string>? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => this.WithProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// Specifies the name of the Function App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("service_plan_id");
        set => this.WithProperty("service_plan_id", value);
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    public TerraformProperty<string>? StorageKeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("storage_key_vault_secret_id");
        set => this.WithProperty("storage_key_vault_secret_id", value);
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    public TerraformProperty<bool>? StorageUsesManagedIdentity
    {
        get => GetProperty<TerraformProperty<bool>>("storage_uses_managed_identity");
        set => this.WithProperty("storage_uses_managed_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualNetworkBackupRestoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("virtual_network_backup_restore_enabled");
        set => this.WithProperty("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_subnet_id");
        set => this.WithProperty("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? VnetImagePullEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_image_pull_enabled");
        set => this.WithProperty("vnet_image_pull_enabled", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => this.WithProperty("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermLinuxFunctionAppSlotAuthSettingsBlock>? AuthSettings
    {
        get => GetProperty<List<AzurermLinuxFunctionAppSlotAuthSettingsBlock>>("auth_settings");
        set => this.WithProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public List<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>? AuthSettingsV2
    {
        get => GetProperty<List<AzurermLinuxFunctionAppSlotAuthSettingsV2Block>>("auth_settings_v2");
        set => this.WithProperty("auth_settings_v2", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermLinuxFunctionAppSlotBackupBlock>? Backup
    {
        get => GetProperty<List<AzurermLinuxFunctionAppSlotBackupBlock>>("backup");
        set => this.WithProperty("backup", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxFunctionAppSlotConnectionStringBlock>? ConnectionString
    {
        get => GetProperty<HashSet<AzurermLinuxFunctionAppSlotConnectionStringBlock>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLinuxFunctionAppSlotIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermLinuxFunctionAppSlotIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermLinuxFunctionAppSlotSiteConfigBlock>? SiteConfig
    {
        get => GetProperty<List<AzurermLinuxFunctionAppSlotSiteConfigBlock>>("site_config");
        set => this.WithProperty("site_config", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxFunctionAppSlotStorageAccountBlock>? StorageAccount
    {
        get => GetProperty<HashSet<AzurermLinuxFunctionAppSlotStorageAccountBlock>>("storage_account");
        set => this.WithProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLinuxFunctionAppSlotTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLinuxFunctionAppSlotTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}

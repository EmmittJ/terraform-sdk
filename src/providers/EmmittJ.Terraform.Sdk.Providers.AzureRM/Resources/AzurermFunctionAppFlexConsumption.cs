using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for always_ready in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionAlwaysReadyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "always_ready";

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => new TerraformReference<double>(this, "instance_count");
        set => SetArgument("instance_count", value);
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

}

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionAuthSettingsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionAuthSettingsV2Block : TerraformBlock
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

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermFunctionAppFlexConsumptionConnectionStringBlock : TerraformBlock
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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionIdentityBlock : TerraformBlock
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
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_config";

    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    public TerraformValue<string>? ApiDefinitionUrl
    {
        get => new TerraformReference<string>(this, "api_definition_url");
        set => SetArgument("api_definition_url", value);
    }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    public TerraformValue<string>? ApiManagementApiId
    {
        get => new TerraformReference<string>(this, "api_management_api_id");
        set => SetArgument("api_management_api_id", value);
    }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    public TerraformValue<string>? AppCommandLine
    {
        get => new TerraformReference<string>(this, "app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    public TerraformValue<string>? ApplicationInsightsConnectionString
    {
        get => new TerraformReference<string>(this, "application_insights_connection_string");
        set => SetArgument("application_insights_connection_string", value);
    }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    public TerraformValue<string>? ApplicationInsightsKey
    {
        get => new TerraformReference<string>(this, "application_insights_key");
        set => SetArgument("application_insights_key", value);
    }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId
    {
        get => new TerraformReference<string>(this, "container_registry_managed_identity_client_id");
        set => SetArgument("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity
    {
        get => new TerraformReference<bool>(this, "container_registry_use_managed_identity");
        set => SetArgument("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    public TerraformList<string> DefaultDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "default_documents").ResolveNodes(ctx));
        set => SetArgument("default_documents", value);
    }

    /// <summary>
    /// Is detailed error logging enabled
    /// </summary>
    public TerraformValue<bool> DetailedErrorLoggingEnabled
    {
        get => new TerraformReference<bool>(this, "detailed_error_logging_enabled");
    }

    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    public TerraformValue<double> ElasticInstanceMinimum
    {
        get => new TerraformReference<double>(this, "elastic_instance_minimum");
        set => SetArgument("elastic_instance_minimum", value);
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
    /// The path to be checked for this function app health.
    /// </summary>
    public TerraformValue<string>? HealthCheckPath
    {
        get => new TerraformReference<string>(this, "health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
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
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    public TerraformValue<string>? LoadBalancingMode
    {
        get => new TerraformReference<string>(this, "load_balancing_mode");
        set => SetArgument("load_balancing_mode", value);
    }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => new TerraformReference<string>(this, "managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022``
    /// </summary>
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => new TerraformReference<string>(this, "remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    public TerraformValue<bool>? RuntimeScaleMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "runtime_scale_monitoring_enabled");
        set => SetArgument("runtime_scale_monitoring_enabled", value);
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
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    public TerraformValue<string>? ScmMinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "scm_minimum_tls_version");
        set => SetArgument("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The SCM Type in use by the Linux Function App.
    /// </summary>
    public TerraformValue<string> ScmType
    {
        get => new TerraformReference<string>(this, "scm_type");
    }

    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => new TerraformReference<bool>(this, "scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// Should the Linux Function App use a 32-bit worker.
    /// </summary>
    public TerraformValue<bool>? Use32BitWorker
    {
        get => new TerraformReference<bool>(this, "use_32_bit_worker");
        set => SetArgument("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should the Linux Function App route all traffic through the virtual network.
    /// </summary>
    public TerraformValue<bool>? VnetRouteAllEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => new TerraformReference<bool>(this, "websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    public TerraformValue<double> WorkerCount
    {
        get => new TerraformReference<double>(this, "worker_count");
        set => SetArgument("worker_count", value);
    }

}

/// <summary>
/// Block type for sticky_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionStickySettingsBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "app_setting_names").ResolveNodes(ctx));
        set => SetArgument("app_setting_names", value);
    }

    /// <summary>
    /// The connection_string_names attribute.
    /// </summary>
    public TerraformList<string>? ConnectionStringNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connection_string_names").ResolveNodes(ctx));
        set => SetArgument("connection_string_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppFlexConsumptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_function_app_flex_consumption Terraform resource.
/// Manages a azurerm_function_app_flex_consumption resource.
/// </summary>
public partial class AzurermFunctionAppFlexConsumption(string name) : TerraformResource("azurerm_function_app_flex_consumption", name)
{
    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public TerraformMap<string>? AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// Should the function app use Client Certificates
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
    /// The mode of the Function App&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` 
    /// </summary>
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// Is the Function App enabled.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The http_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? HttpConcurrency
    {
        get => new TerraformReference<double>(this, "http_concurrency");
        set => SetArgument("http_concurrency", value);
    }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS?
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
    /// The instance_memory_in_mb attribute.
    /// </summary>
    public TerraformValue<double>? InstanceMemoryInMb
    {
        get => new TerraformReference<double>(this, "instance_memory_in_mb");
        set => SetArgument("instance_memory_in_mb", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maximum_instance_count attribute.
    /// </summary>
    public TerraformValue<double>? MaximumInstanceCount
    {
        get => new TerraformReference<double>(this, "maximum_instance_count");
        set => SetArgument("maximum_instance_count", value);
    }

    /// <summary>
    /// Specifies the name of the Function App.
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeName is required")]
    public required TerraformValue<string> RuntimeName
    {
        get => new TerraformReference<string>(this, "runtime_name");
        set => SetArgument("runtime_name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    public required TerraformValue<string> RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    public required TerraformValue<string> ServicePlanId
    {
        get => new TerraformReference<string>(this, "service_plan_id");
        set => SetArgument("service_plan_id", value);
    }

    /// <summary>
    /// The storage_access_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccessKey
    {
        get => new TerraformReference<string>(this, "storage_access_key");
        set => SetArgument("storage_access_key", value);
    }

    /// <summary>
    /// The storage_authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAuthenticationType is required")]
    public required TerraformValue<string> StorageAuthenticationType
    {
        get => new TerraformReference<string>(this, "storage_authentication_type");
        set => SetArgument("storage_authentication_type", value);
    }

    /// <summary>
    /// The endpoint of the storage container where the function app&#39;s code is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerEndpoint is required")]
    public required TerraformValue<string> StorageContainerEndpoint
    {
        get => new TerraformReference<string>(this, "storage_container_endpoint");
        set => SetArgument("storage_container_endpoint", value);
    }

    /// <summary>
    /// The type of the storage container where the function app&#39;s code is hosted. Only `blobContainer` is supported currently.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerType is required")]
    public required TerraformValue<string> StorageContainerType
    {
        get => new TerraformReference<string>(this, "storage_container_type");
        set => SetArgument("storage_container_type", value);
    }

    /// <summary>
    /// The storage_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "storage_user_assigned_identity_id");
        set => SetArgument("storage_user_assigned_identity_id", value);
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
    /// The local path and filename of the Zip packaged application to deploy to this Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
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
    /// AlwaysReady block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFunctionAppFlexConsumptionAlwaysReadyBlock>? AlwaysReady
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFlexConsumptionAlwaysReadyBlock>>("always_ready");
        set => SetArgument("always_ready", value);
    }

    /// <summary>
    /// AuthSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public TerraformList<AzurermFunctionAppFlexConsumptionAuthSettingsBlock>? AuthSettings
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFlexConsumptionAuthSettingsBlock>>("auth_settings");
        set => SetArgument("auth_settings", value);
    }

    /// <summary>
    /// AuthSettingsV2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public TerraformList<AzurermFunctionAppFlexConsumptionAuthSettingsV2Block>? AuthSettingsV2
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFlexConsumptionAuthSettingsV2Block>>("auth_settings_v2");
        set => SetArgument("auth_settings_v2", value);
    }

    /// <summary>
    /// ConnectionString block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermFunctionAppFlexConsumptionConnectionStringBlock>? ConnectionString
    {
        get => GetArgument<TerraformSet<AzurermFunctionAppFlexConsumptionConnectionStringBlock>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermFunctionAppFlexConsumptionIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFlexConsumptionIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// SiteConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public required TerraformList<AzurermFunctionAppFlexConsumptionSiteConfigBlock> SiteConfig
    {
        get => GetRequiredArgument<TerraformList<AzurermFunctionAppFlexConsumptionSiteConfigBlock>>("site_config");
        set => SetArgument("site_config", value);
    }

    /// <summary>
    /// StickySettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    public TerraformList<AzurermFunctionAppFlexConsumptionStickySettingsBlock>? StickySettings
    {
        get => GetArgument<TerraformList<AzurermFunctionAppFlexConsumptionStickySettingsBlock>>("sticky_settings");
        set => SetArgument("sticky_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppFlexConsumptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppFlexConsumptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

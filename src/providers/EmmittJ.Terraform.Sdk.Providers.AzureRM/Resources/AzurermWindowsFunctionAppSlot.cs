using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings";

    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [TerraformArgument("additional_login_parameters")]
    public TerraformMap<string>? AdditionalLoginParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_login_parameters").ResolveNodes(ctx));
        set => SetArgument("additional_login_parameters", value);
    }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [TerraformArgument("allowed_external_redirect_urls")]
    public TerraformList<string> AllowedExternalRedirectUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_external_redirect_urls").ResolveNodes(ctx));
        set => SetArgument("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [TerraformArgument("default_provider")]
    public TerraformValue<string> DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformArgument("enabled")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [TerraformArgument("issuer")]
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [TerraformArgument("runtime_version")]
    public TerraformValue<string> RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [TerraformArgument("token_refresh_extension_hours")]
    public TerraformValue<double>? TokenRefreshExtensionHours
    {
        get => new TerraformReference<double>(this, "token_refresh_extension_hours");
        set => SetArgument("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [TerraformArgument("token_store_enabled")]
    public TerraformValue<bool>? TokenStoreEnabled
    {
        get => new TerraformReference<bool>(this, "token_store_enabled");
        set => SetArgument("token_store_enabled", value);
    }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [TerraformArgument("unauthenticated_client_action")]
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
public class AzurermWindowsFunctionAppSlotAuthSettingsV2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_settings_v2";

    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [TerraformArgument("auth_enabled")]
    public TerraformValue<bool>? AuthEnabled
    {
        get => new TerraformReference<bool>(this, "auth_enabled");
        set => SetArgument("auth_enabled", value);
    }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [TerraformArgument("config_file_path")]
    public TerraformValue<string>? ConfigFilePath
    {
        get => new TerraformReference<string>(this, "config_file_path");
        set => SetArgument("config_file_path", value);
    }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [TerraformArgument("default_provider")]
    public TerraformValue<string>? DefaultProvider
    {
        get => new TerraformReference<string>(this, "default_provider");
        set => SetArgument("default_provider", value);
    }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [TerraformArgument("excluded_paths")]
    public TerraformList<string>? ExcludedPaths
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_paths").ResolveNodes(ctx));
        set => SetArgument("excluded_paths", value);
    }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [TerraformArgument("forward_proxy_convention")]
    public TerraformValue<string>? ForwardProxyConvention
    {
        get => new TerraformReference<string>(this, "forward_proxy_convention");
        set => SetArgument("forward_proxy_convention", value);
    }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    [TerraformArgument("forward_proxy_custom_host_header_name")]
    public TerraformValue<string>? ForwardProxyCustomHostHeaderName
    {
        get => new TerraformReference<string>(this, "forward_proxy_custom_host_header_name");
        set => SetArgument("forward_proxy_custom_host_header_name", value);
    }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [TerraformArgument("forward_proxy_custom_scheme_header_name")]
    public TerraformValue<string>? ForwardProxyCustomSchemeHeaderName
    {
        get => new TerraformReference<string>(this, "forward_proxy_custom_scheme_header_name");
        set => SetArgument("forward_proxy_custom_scheme_header_name", value);
    }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [TerraformArgument("http_route_api_prefix")]
    public TerraformValue<string>? HttpRouteApiPrefix
    {
        get => new TerraformReference<string>(this, "http_route_api_prefix");
        set => SetArgument("http_route_api_prefix", value);
    }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [TerraformArgument("require_authentication")]
    public TerraformValue<bool>? RequireAuthentication
    {
        get => new TerraformReference<bool>(this, "require_authentication");
        set => SetArgument("require_authentication", value);
    }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [TerraformArgument("require_https")]
    public TerraformValue<bool>? RequireHttps
    {
        get => new TerraformReference<bool>(this, "require_https");
        set => SetArgument("require_https", value);
    }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [TerraformArgument("runtime_version")]
    public TerraformValue<string>? RuntimeVersion
    {
        get => new TerraformReference<string>(this, "runtime_version");
        set => SetArgument("runtime_version", value);
    }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [TerraformArgument("unauthenticated_action")]
    public TerraformValue<string>? UnauthenticatedAction
    {
        get => new TerraformReference<string>(this, "unauthenticated_action");
        set => SetArgument("unauthenticated_action", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsFunctionAppSlotBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup";

    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformArgument("storage_account_url")]
    public required TerraformValue<string> StorageAccountUrl
    {
        get => new TerraformReference<string>(this, "storage_account_url");
        set => SetArgument("storage_account_url", value);
    }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsFunctionAppSlotConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_string";

    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
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
public class AzurermWindowsFunctionAppSlotIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
public class AzurermWindowsFunctionAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_config";

    /// <summary>
    /// If this Windows Web App is Always On enabled. Defaults to `false`.
    /// </summary>
    [TerraformArgument("always_on")]
    public TerraformValue<bool> AlwaysOn
    {
        get => new TerraformReference<bool>(this, "always_on");
        set => SetArgument("always_on", value);
    }

    /// <summary>
    /// The URL of the API definition that describes this Windows Function App.
    /// </summary>
    [TerraformArgument("api_definition_url")]
    public TerraformValue<string>? ApiDefinitionUrl
    {
        get => new TerraformReference<string>(this, "api_definition_url");
        set => SetArgument("api_definition_url", value);
    }

    /// <summary>
    /// The ID of the API Management API for this Windows Function App.
    /// </summary>
    [TerraformArgument("api_management_api_id")]
    public TerraformValue<string>? ApiManagementApiId
    {
        get => new TerraformReference<string>(this, "api_management_api_id");
        set => SetArgument("api_management_api_id", value);
    }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [TerraformArgument("app_command_line")]
    public TerraformValue<string>? AppCommandLine
    {
        get => new TerraformReference<string>(this, "app_command_line");
        set => SetArgument("app_command_line", value);
    }

    /// <summary>
    /// The number of workers this function app can scale out to. Only applicable to apps on the Consumption and Premium plan.
    /// </summary>
    [TerraformArgument("app_scale_limit")]
    public TerraformValue<double> AppScaleLimit
    {
        get => new TerraformReference<double>(this, "app_scale_limit");
        set => SetArgument("app_scale_limit", value);
    }

    /// <summary>
    /// The Connection String for linking the Windows Function App to Application Insights.
    /// </summary>
    [TerraformArgument("application_insights_connection_string")]
    public TerraformValue<string>? ApplicationInsightsConnectionString
    {
        get => new TerraformReference<string>(this, "application_insights_connection_string");
        set => SetArgument("application_insights_connection_string", value);
    }

    /// <summary>
    /// The Instrumentation Key for connecting the Windows Function App to Application Insights.
    /// </summary>
    [TerraformArgument("application_insights_key")]
    public TerraformValue<string>? ApplicationInsightsKey
    {
        get => new TerraformReference<string>(this, "application_insights_key");
        set => SetArgument("application_insights_key", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformArgument("auto_swap_slot_name")]
    public TerraformValue<string>? AutoSwapSlotName
    {
        get => new TerraformReference<string>(this, "auto_swap_slot_name");
        set => SetArgument("auto_swap_slot_name", value);
    }

    /// <summary>
    /// Specifies a list of Default Documents for the Windows Web App.
    /// </summary>
    [TerraformArgument("default_documents")]
    public TerraformList<string> DefaultDocuments
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "default_documents").ResolveNodes(ctx));
        set => SetArgument("default_documents", value);
    }


    /// <summary>
    /// The number of minimum instances for this Windows Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [TerraformArgument("elastic_instance_minimum")]
    public TerraformValue<double> ElasticInstanceMinimum
    {
        get => new TerraformReference<double>(this, "elastic_instance_minimum");
        set => SetArgument("elastic_instance_minimum", value);
    }

    /// <summary>
    /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`. Defaults to `Disabled`.
    /// </summary>
    [TerraformArgument("ftps_state")]
    public TerraformValue<string>? FtpsState
    {
        get => new TerraformReference<string>(this, "ftps_state");
        set => SetArgument("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Defaults to `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformArgument("health_check_eviction_time_in_min")]
    public TerraformValue<double>? HealthCheckEvictionTimeInMin
    {
        get => new TerraformReference<double>(this, "health_check_eviction_time_in_min");
        set => SetArgument("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    [TerraformArgument("health_check_path")]
    public TerraformValue<string>? HealthCheckPath
    {
        get => new TerraformReference<string>(this, "health_check_path");
        set => SetArgument("health_check_path", value);
    }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [TerraformArgument("http2_enabled")]
    public TerraformValue<bool>? Http2Enabled
    {
        get => new TerraformReference<bool>(this, "http2_enabled");
        set => SetArgument("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    [TerraformArgument("ip_restriction_default_action")]
    public TerraformValue<string>? IpRestrictionDefaultAction
    {
        get => new TerraformReference<string>(this, "ip_restriction_default_action");
        set => SetArgument("ip_restriction_default_action", value);
    }

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [TerraformArgument("load_balancing_mode")]
    public TerraformValue<string>? LoadBalancingMode
    {
        get => new TerraformReference<string>(this, "load_balancing_mode");
        set => SetArgument("load_balancing_mode", value);
    }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [TerraformArgument("managed_pipeline_mode")]
    public TerraformValue<string>? ManagedPipelineMode
    {
        get => new TerraformReference<string>(this, "managed_pipeline_mode");
        set => SetArgument("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The number of pre-warmed instances for this function app. Only affects apps on an Elastic Premium plan.
    /// </summary>
    [TerraformArgument("pre_warmed_instance_count")]
    public TerraformValue<double> PreWarmedInstanceCount
    {
        get => new TerraformReference<double>(this, "pre_warmed_instance_count");
        set => SetArgument("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [TerraformArgument("remote_debugging_enabled")]
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The Remote Debugging Version. Currently only `VS2022` is supported.
    /// </summary>
    [TerraformArgument("remote_debugging_version")]
    public TerraformValue<string> RemoteDebuggingVersion
    {
        get => new TerraformReference<string>(this, "remote_debugging_version");
        set => SetArgument("remote_debugging_version", value);
    }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [TerraformArgument("runtime_scale_monitoring_enabled")]
    public TerraformValue<bool>? RuntimeScaleMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "runtime_scale_monitoring_enabled");
        set => SetArgument("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformArgument("scm_ip_restriction_default_action")]
    public TerraformValue<string>? ScmIpRestrictionDefaultAction
    {
        get => new TerraformReference<string>(this, "scm_ip_restriction_default_action");
        set => SetArgument("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, `1.2` and `1.3`. Defaults to `1.2`.
    /// </summary>
    [TerraformArgument("scm_minimum_tls_version")]
    public TerraformValue<string>? ScmMinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "scm_minimum_tls_version");
        set => SetArgument("scm_minimum_tls_version", value);
    }


    /// <summary>
    /// Should the Windows Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [TerraformArgument("scm_use_main_ip_restriction")]
    public TerraformValue<bool>? ScmUseMainIpRestriction
    {
        get => new TerraformReference<bool>(this, "scm_use_main_ip_restriction");
        set => SetArgument("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// Should the Windows Function App use a 32-bit worker.
    /// </summary>
    [TerraformArgument("use_32_bit_worker")]
    public TerraformValue<bool>? Use32BitWorker
    {
        get => new TerraformReference<bool>(this, "use_32_bit_worker");
        set => SetArgument("use_32_bit_worker", value);
    }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [TerraformArgument("vnet_route_all_enabled")]
    public TerraformValue<bool>? VnetRouteAllEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_route_all_enabled");
        set => SetArgument("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [TerraformArgument("websockets_enabled")]
    public TerraformValue<bool>? WebsocketsEnabled
    {
        get => new TerraformReference<bool>(this, "websockets_enabled");
        set => SetArgument("websockets_enabled", value);
    }


    /// <summary>
    /// The number of Workers for this Windows Function App.
    /// </summary>
    [TerraformArgument("worker_count")]
    public TerraformValue<double> WorkerCount
    {
        get => new TerraformReference<double>(this, "worker_count");
        set => SetArgument("worker_count", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermWindowsFunctionAppSlotStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_account";

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformArgument("access_key")]
    public required TerraformValue<string> AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformArgument("mount_path")]
    public TerraformValue<string>? MountPath
    {
        get => new TerraformReference<string>(this, "mount_path");
        set => SetArgument("mount_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformArgument("share_name")]
    public required TerraformValue<string> ShareName
    {
        get => new TerraformReference<string>(this, "share_name");
        set => SetArgument("share_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsFunctionAppSlotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [TerraformArgument("app_settings")]
    public TerraformMap<string>? AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
        set => SetArgument("app_settings", value);
    }

    /// <summary>
    /// Should built in logging be enabled. Configures `AzureWebJobsDashboard` app setting based on the configured storage setting.
    /// </summary>
    [TerraformArgument("builtin_logging_enabled")]
    public TerraformValue<bool>? BuiltinLoggingEnabled
    {
        get => new TerraformReference<bool>(this, "builtin_logging_enabled");
        set => SetArgument("builtin_logging_enabled", value);
    }

    /// <summary>
    /// Should the Function App Slot use Client Certificates.
    /// </summary>
    [TerraformArgument("client_certificate_enabled")]
    public TerraformValue<bool>? ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
        set => SetArgument("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformArgument("client_certificate_exclusion_paths")]
    public TerraformValue<string>? ClientCertificateExclusionPaths
    {
        get => new TerraformReference<string>(this, "client_certificate_exclusion_paths");
        set => SetArgument("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The mode of the Function App Slot&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser`.
    /// </summary>
    [TerraformArgument("client_certificate_mode")]
    public TerraformValue<string>? ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
        set => SetArgument("client_certificate_mode", value);
    }

    /// <summary>
    /// Force disable the content share settings.
    /// </summary>
    [TerraformArgument("content_share_force_disabled")]
    public TerraformValue<bool>? ContentShareForceDisabled
    {
        get => new TerraformReference<bool>(this, "content_share_force_disabled");
        set => SetArgument("content_share_force_disabled", value);
    }

    /// <summary>
    /// The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps in Consumption Plans.
    /// </summary>
    [TerraformArgument("daily_memory_time_quota")]
    public TerraformValue<double>? DailyMemoryTimeQuota
    {
        get => new TerraformReference<double>(this, "daily_memory_time_quota");
        set => SetArgument("daily_memory_time_quota", value);
    }

    /// <summary>
    /// Is the Windows Function App Slot enabled.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("ftp_publish_basic_authentication_enabled")]
    public TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "ftp_publish_basic_authentication_enabled");
        set => SetArgument("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The ID of the Windows Function App this Slot is a member of.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformArgument("function_app_id")]
    public required TerraformValue<string> FunctionAppId
    {
        get => new TerraformReference<string>(this, "function_app_id");
        set => SetArgument("function_app_id", value);
    }

    /// <summary>
    /// The runtime version associated with the Function App Slot.
    /// </summary>
    [TerraformArgument("functions_extension_version")]
    public TerraformValue<string>? FunctionsExtensionVersion
    {
        get => new TerraformReference<string>(this, "functions_extension_version");
        set => SetArgument("functions_extension_version", value);
    }

    /// <summary>
    /// Can the Function App Slot only be accessed via HTTPS?
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool>? HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
        set => SetArgument("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Key Vault access.
    /// </summary>
    [TerraformArgument("key_vault_reference_identity_id")]
    public TerraformValue<string> KeyVaultReferenceIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_reference_identity_id");
        set => SetArgument("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// Specifies the name of the Windows Function App Slot.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformArgument("service_plan_id")]
    public TerraformValue<string>? ServicePlanId
    {
        get => new TerraformReference<string>(this, "service_plan_id");
        set => SetArgument("service_plan_id", value);
    }

    /// <summary>
    /// The access key which will be used to access the storage account for the Function App Slot.
    /// </summary>
    [TerraformArgument("storage_account_access_key")]
    public TerraformValue<string>? StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
        set => SetArgument("storage_account_access_key", value);
    }

    /// <summary>
    /// The backend storage account name which will be used by this Function App Slot.
    /// </summary>
    [TerraformArgument("storage_account_name")]
    public TerraformValue<string>? StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String to connect to the storage account for this Function App.
    /// </summary>
    [TerraformArgument("storage_key_vault_secret_id")]
    public TerraformValue<string>? StorageKeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "storage_key_vault_secret_id");
        set => SetArgument("storage_key_vault_secret_id", value);
    }

    /// <summary>
    /// Should the Function App Slot use its Managed Identity to access storage?
    /// </summary>
    [TerraformArgument("storage_uses_managed_identity")]
    public TerraformValue<bool>? StorageUsesManagedIdentity
    {
        get => new TerraformReference<bool>(this, "storage_uses_managed_identity");
        set => SetArgument("storage_uses_managed_identity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformArgument("virtual_network_backup_restore_enabled")]
    public TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_backup_restore_enabled");
        set => SetArgument("virtual_network_backup_restore_enabled", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_subnet_id")]
    public TerraformValue<string>? VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
        set => SetArgument("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// Is container image pull over virtual network enabled? Defaults to `false`.
    /// </summary>
    [TerraformArgument("vnet_image_pull_enabled")]
    public TerraformValue<bool>? VnetImagePullEnabled
    {
        get => new TerraformReference<bool>(this, "vnet_image_pull_enabled");
        set => SetArgument("vnet_image_pull_enabled", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("webdeploy_publish_basic_authentication_enabled")]
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "webdeploy_publish_basic_authentication_enabled");
        set => SetArgument("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformArgument("auth_settings")]
    public TerraformList<AzurermWindowsFunctionAppSlotAuthSettingsBlock> AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformArgument("auth_settings_v2")]
    public TerraformList<AzurermWindowsFunctionAppSlotAuthSettingsV2Block> AuthSettingsV2 { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformArgument("backup")]
    public TerraformList<AzurermWindowsFunctionAppSlotBackupBlock> Backup { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformSet<AzurermWindowsFunctionAppSlotConnectionStringBlock> ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermWindowsFunctionAppSlotIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformArgument("site_config")]
    public required TerraformList<AzurermWindowsFunctionAppSlotSiteConfigBlock> SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("storage_account")]
    public TerraformSet<AzurermWindowsFunctionAppSlotStorageAccountBlock> StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWindowsFunctionAppSlotTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The identifier used by App Service to perform domain ownership verification via DNS TXT record.
    /// </summary>
    [TerraformArgument("custom_domain_verification_id")]
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The default hostname of the Windows Function App Slot.
    /// </summary>
    [TerraformArgument("default_hostname")]
    public TerraformValue<string> DefaultHostname
    {
        get => new TerraformReference<string>(this, "default_hostname");
    }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformArgument("hosting_environment_id")]
    public TerraformValue<string> HostingEnvironmentId
    {
        get => new TerraformReference<string>(this, "hosting_environment_id");
    }

    /// <summary>
    /// The Kind value for this Windows Function App Slot.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// A list of outbound IP addresses. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    [TerraformArgument("outbound_ip_address_list")]
    public TerraformList<string> OutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// A comma separated list of outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12`.
    /// </summary>
    [TerraformArgument("outbound_ip_addresses")]
    public TerraformValue<string> OutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "outbound_ip_addresses");
    }

    /// <summary>
    /// A list of possible outbound IP addresses, not all of which are necessarily in use. This is a superset of `outbound_ip_address_list`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;]`.
    /// </summary>
    [TerraformArgument("possible_outbound_ip_address_list")]
    public TerraformList<string> PossibleOutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "possible_outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// A comma separated list of possible outbound IP addresses as a string. For example `52.23.25.3,52.143.43.12,52.143.43.17`. This is a superset of `outbound_ip_addresses`. For example `[&amp;quot;52.23.25.3&amp;quot;, &amp;quot;52.143.43.12&amp;quot;,&amp;quot;52.143.43.17&amp;quot;]`.
    /// </summary>
    [TerraformArgument("possible_outbound_ip_addresses")]
    public TerraformValue<string> PossibleOutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "possible_outbound_ip_addresses");
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformArgument("site_credential")]
    public TerraformList<object> SiteCredential
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "site_credential").ResolveNodes(ctx));
    }

}

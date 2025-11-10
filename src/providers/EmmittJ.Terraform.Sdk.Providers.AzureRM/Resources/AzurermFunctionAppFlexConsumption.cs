using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for always_ready in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionAlwaysReadyBlock : ITerraformBlock
{
    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstanceCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionAuthSettingsBlock : ITerraformBlock
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
public class AzurermFunctionAppFlexConsumptionAuthSettingsV2Block : ITerraformBlock
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
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermFunctionAppFlexConsumptionConnectionStringBlock : ITerraformBlock
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
public class AzurermFunctionAppFlexConsumptionIdentityBlock : ITerraformBlock
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
public class AzurermFunctionAppFlexConsumptionSiteConfigBlock : ITerraformBlock
{
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
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
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
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022``
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
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
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
    /// Should the Linux Function App use a 32-bit worker.
    /// </summary>
    [TerraformPropertyName("use_32_bit_worker")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should the Linux Function App route all traffic through the virtual network.
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
/// Block type for sticky_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFlexConsumptionStickySettingsBlock : ITerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppFlexConsumptionTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_function_app_flex_consumption resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFunctionAppFlexConsumption : TerraformResource
{
    public AzurermFunctionAppFlexConsumption(string name) : base("azurerm_function_app_flex_consumption", name)
    {
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AppSettings { get; set; }

    /// <summary>
    /// Should the function app use Client Certificates
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
    /// The mode of the Function App&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` 
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateMode { get; set; }

    /// <summary>
    /// Is the Function App enabled.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The http_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("http_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HttpConcurrency { get; set; }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS?
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
    /// The instance_memory_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("instance_memory_in_mb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstanceMemoryInMb { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The maximum_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("maximum_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumInstanceCount { get; set; }

    /// <summary>
    /// Specifies the name of the Function App.
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
    /// The runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeName is required")]
    [TerraformPropertyName("runtime_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuntimeName { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformPropertyName("runtime_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuntimeVersion { get; set; }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    [TerraformPropertyName("service_plan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServicePlanId { get; set; }

    /// <summary>
    /// The storage_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccessKey { get; set; }

    /// <summary>
    /// The storage_authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAuthenticationType is required")]
    [TerraformPropertyName("storage_authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAuthenticationType { get; set; }

    /// <summary>
    /// The endpoint of the storage container where the function app&#39;s code is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerEndpoint is required")]
    [TerraformPropertyName("storage_container_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageContainerEndpoint { get; set; }

    /// <summary>
    /// The type of the storage container where the function app&#39;s code is hosted. Only `blobContainer` is supported currently.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerType is required")]
    [TerraformPropertyName("storage_container_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageContainerType { get; set; }

    /// <summary>
    /// The storage_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [TerraformPropertyName("zip_deploy_file")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZipDeployFile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zip_deploy_file");

    /// <summary>
    /// Block for always_ready.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("always_ready")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAlwaysReadyBlock>>? AlwaysReady { get; set; } = new();

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAuthSettingsBlock>>? AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformPropertyName("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAuthSettingsV2Block>>? AuthSettingsV2 { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermFunctionAppFlexConsumptionConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for sticky_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    [TerraformPropertyName("sticky_settings")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionStickySettingsBlock>>? StickySettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppFlexConsumptionTimeoutsBlock>? Timeouts { get; set; } = new();

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

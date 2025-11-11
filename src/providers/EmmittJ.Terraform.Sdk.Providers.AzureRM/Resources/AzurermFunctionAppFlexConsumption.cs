using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for always_ready in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionAlwaysReadyBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionAuthSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [TerraformProperty("additional_login_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [TerraformProperty("allowed_external_redirect_urls")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [TerraformProperty("default_provider")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DefaultProvider { get; set; }

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RuntimeVersion { get; set; }

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [TerraformProperty("token_refresh_extension_hours")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [TerraformProperty("token_store_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [TerraformProperty("unauthenticated_client_action")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> UnauthenticatedClientAction { get; set; }

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionAuthSettingsV2Block : TerraformBlockBase
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [TerraformProperty("auth_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AuthEnabled { get; set; }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [TerraformProperty("config_file_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfigFilePath { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [TerraformProperty("default_provider")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [TerraformProperty("excluded_paths")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExcludedPaths { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [TerraformProperty("forward_proxy_convention")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    [TerraformProperty("forward_proxy_custom_host_header_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [TerraformProperty("forward_proxy_custom_scheme_header_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [TerraformProperty("http_route_api_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HttpRouteApiPrefix { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [TerraformProperty("require_authentication")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [TerraformProperty("require_https")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuntimeVersion { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [TerraformProperty("unauthenticated_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UnauthenticatedAction { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionConnectionStringBlock : TerraformBlockBase
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionSiteConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The URL of the API definition that describes this Linux Function App.
    /// </summary>
    [TerraformProperty("api_definition_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The ID of the API Management API for this Linux Function App.
    /// </summary>
    [TerraformProperty("api_management_api_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The program and any arguments used to launch this app via the command line. (Example `node myapp.js`).
    /// </summary>
    [TerraformProperty("app_command_line")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppCommandLine { get; set; }

    /// <summary>
    /// The Connection String for linking the Linux Function App to Application Insights.
    /// </summary>
    [TerraformProperty("application_insights_connection_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApplicationInsightsConnectionString { get; set; }

    /// <summary>
    /// The Instrumentation Key for connecting the Linux Function App to Application Insights.
    /// </summary>
    [TerraformProperty("application_insights_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApplicationInsightsKey { get; set; }

    /// <summary>
    /// The Client ID of the Managed Service Identity to use for connections to the Azure Container Registry.
    /// </summary>
    [TerraformProperty("container_registry_managed_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// Should connections for Azure Container Registry use Managed Identity.
    /// </summary>
    [TerraformProperty("container_registry_use_managed_identity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// Specifies a list of Default Documents for the Linux Web App.
    /// </summary>
    [TerraformProperty("default_documents")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> DefaultDocuments { get; set; }


    /// <summary>
    /// The number of minimum instances for this Linux Function App. Only affects apps on Elastic Premium plans.
    /// </summary>
    [TerraformProperty("elastic_instance_minimum")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformProperty("health_check_eviction_time_in_min")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The path to be checked for this function app health.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// Specifies if the http2 protocol should be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    [TerraformProperty("ip_restriction_default_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The Site load balancing mode. Possible values include: `WeightedRoundRobin`, `LeastRequests`, `LeastResponseTime`, `WeightedTotalTraffic`, `RequestHash`, `PerSiteRoundRobin`. Defaults to `LeastRequests` if omitted.
    /// </summary>
    [TerraformProperty("load_balancing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The Managed Pipeline mode. Possible values include: `Integrated`, `Classic`. Defaults to `Integrated`.
    /// </summary>
    [TerraformProperty("managed_pipeline_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The configures the minimum version of TLS required for SSL requests. Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// Should Remote Debugging be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("remote_debugging_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The Remote Debugging Version. Possible values include `VS2017`, `VS2019`, and `VS2022``
    /// </summary>
    [TerraformProperty("remote_debugging_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// Should Functions Runtime Scale Monitoring be enabled.
    /// </summary>
    [TerraformProperty("runtime_scale_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformProperty("scm_ip_restriction_default_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// Configures the minimum version of TLS required for SSL requests to the SCM site Possible values include: `1.0`, `1.1`, and  `1.2`. Defaults to `1.2`.
    /// </summary>
    [TerraformProperty("scm_minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScmMinimumTlsVersion { get; set; }


    /// <summary>
    /// Should the Linux Function App `ip_restriction` configuration be used for the SCM also.
    /// </summary>
    [TerraformProperty("scm_use_main_ip_restriction")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// Should the Linux Function App use a 32-bit worker.
    /// </summary>
    [TerraformProperty("use_32_bit_worker")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should the Linux Function App route all traffic through the virtual network.
    /// </summary>
    [TerraformProperty("vnet_route_all_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// Should Web Sockets be enabled. Defaults to `false`.
    /// </summary>
    [TerraformProperty("websockets_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The number of Workers for this Linux Function App.
    /// </summary>
    [TerraformProperty("worker_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> WorkerCount { get; set; }

}

/// <summary>
/// Block type for sticky_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionStickySettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The app_setting_names attribute.
    /// </summary>
    [TerraformProperty("app_setting_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AppSettingNames { get; set; }

    /// <summary>
    /// The connection_string_names attribute.
    /// </summary>
    [TerraformProperty("connection_string_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ConnectionStringNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppFlexConsumptionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_function_app_flex_consumption resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFunctionAppFlexConsumption : TerraformResource
{
    public AzurermFunctionAppFlexConsumption(string name) : base("azurerm_function_app_flex_consumption", name)
    {
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AppSettings { get; set; }

    /// <summary>
    /// Should the function app use Client Certificates
    /// </summary>
    [TerraformProperty("client_certificate_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformProperty("client_certificate_exclusion_paths")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The mode of the Function App&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` 
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificateMode { get; set; }

    /// <summary>
    /// Is the Function App enabled.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The http_concurrency attribute.
    /// </summary>
    [TerraformProperty("http_concurrency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HttpConcurrency { get; set; }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_memory_in_mb attribute.
    /// </summary>
    [TerraformProperty("instance_memory_in_mb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? InstanceMemoryInMb { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum_instance_count attribute.
    /// </summary>
    [TerraformProperty("maximum_instance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaximumInstanceCount { get; set; }

    /// <summary>
    /// Specifies the name of the Function App.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The runtime_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeName is required")]
    [TerraformProperty("runtime_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuntimeName { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformProperty("runtime_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuntimeVersion { get; set; }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    [TerraformProperty("service_plan_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePlanId { get; set; }

    /// <summary>
    /// The storage_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_access_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccessKey { get; set; }

    /// <summary>
    /// The storage_authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAuthenticationType is required")]
    [TerraformProperty("storage_authentication_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAuthenticationType { get; set; }

    /// <summary>
    /// The endpoint of the storage container where the function app&#39;s code is hosted.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerEndpoint is required")]
    [TerraformProperty("storage_container_endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageContainerEndpoint { get; set; }

    /// <summary>
    /// The type of the storage container where the function app&#39;s code is hosted. Only `blobContainer` is supported currently.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerType is required")]
    [TerraformProperty("storage_container_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageContainerType { get; set; }

    /// <summary>
    /// The storage_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("storage_user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [TerraformProperty("zip_deploy_file")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ZipDeployFile { get; set; }

    /// <summary>
    /// Block for always_ready.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("always_ready")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAlwaysReadyBlock>>? AlwaysReady { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformProperty("auth_settings")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAuthSettingsBlock>>? AuthSettings { get; set; }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformProperty("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionAuthSettingsV2Block>>? AuthSettingsV2 { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connection_string")]
    public TerraformSet<TerraformBlock<AzurermFunctionAppFlexConsumptionConnectionStringBlock>>? ConnectionString { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformProperty("site_config")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionSiteConfigBlock>>? SiteConfig { get; set; }

    /// <summary>
    /// Block for sticky_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    [TerraformProperty("sticky_settings")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFlexConsumptionStickySettingsBlock>>? StickySettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermFunctionAppFlexConsumptionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformProperty("hosting_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostingEnvironmentId { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Kind { get; }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OutboundIpAddressList { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PossibleOutboundIpAddressList { get; }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PossibleOutboundIpAddresses { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SiteCredential { get; }

}

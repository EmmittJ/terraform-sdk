using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxWebAppAuthSettingsBlock : TerraformBlockBase
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
public partial class AzurermLinuxWebAppAuthSettingsV2Block : TerraformBlockBase
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
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxWebAppBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformProperty("storage_account_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountUrl { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxWebAppConnectionStringBlock : TerraformBlockBase
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
public partial class AzurermLinuxWebAppIdentityBlock : TerraformBlockBase
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
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxWebAppLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The detailed_error_messages attribute.
    /// </summary>
    [TerraformProperty("detailed_error_messages")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DetailedErrorMessages { get; set; }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    [TerraformProperty("failed_request_tracing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FailedRequestTracing { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxWebAppSiteConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformProperty("always_on")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AlwaysOn { get; set; }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    [TerraformProperty("api_definition_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    [TerraformProperty("api_management_api_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    [TerraformProperty("app_command_line")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppCommandLine { get; set; }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("container_registry_managed_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    [TerraformProperty("container_registry_use_managed_identity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    [TerraformProperty("default_documents")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> DefaultDocuments { get; set; }


    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformProperty("ftps_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformProperty("health_check_eviction_time_in_min")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
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
    /// The load_balancing_mode attribute.
    /// </summary>
    [TerraformProperty("load_balancing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    [TerraformProperty("local_mysql_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LocalMysqlEnabled { get; set; }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    [TerraformProperty("managed_pipeline_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformProperty("remote_debugging_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    [TerraformProperty("remote_debugging_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RemoteDebuggingVersion { get; set; }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformProperty("scm_ip_restriction_default_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("scm_minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScmMinimumTlsVersion { get; set; }


    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformProperty("scm_use_main_ip_restriction")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker attribute.
    /// </summary>
    [TerraformProperty("use_32_bit_worker")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [TerraformProperty("vnet_route_all_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformProperty("websockets_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformProperty("worker_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> WorkerCount { get; set; }

}

/// <summary>
/// Block type for sticky_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLinuxWebAppStickySettingsBlock : TerraformBlockBase
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
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLinuxWebAppStorageAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformProperty("access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformProperty("mount_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MountPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformProperty("share_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLinuxWebAppTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_linux_web_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLinuxWebApp : TerraformResource
{
    public AzurermLinuxWebApp(string name) : base("azurerm_linux_web_app", name)
    {
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AppSettings { get; set; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("client_affinity_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// The client_certificate_enabled attribute.
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
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("ftp_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_reference_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyVaultReferenceIdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
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
    /// The service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePlanId is required")]
    [TerraformProperty("service_plan_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePlanId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_network_backup_restore_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The vnet_image_pull_enabled attribute.
    /// </summary>
    [TerraformProperty("vnet_image_pull_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Linux Web App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    [TerraformProperty("zip_deploy_file")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ZipDeployFile { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformProperty("auth_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppAuthSettingsBlock>>? AuthSettings { get; set; }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformProperty("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppAuthSettingsV2Block>>? AuthSettingsV2 { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformProperty("backup")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connection_string")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppConnectionStringBlock>>? ConnectionString { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformProperty("logs")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformProperty("site_config")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSiteConfigBlock>>? SiteConfig { get; set; }

    /// <summary>
    /// Block for sticky_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StickySettings block(s) allowed")]
    [TerraformProperty("sticky_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppStickySettingsBlock>>? StickySettings { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("storage_account")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLinuxWebAppTimeoutsBlock>? Timeouts { get; set; }

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

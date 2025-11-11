using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotAuthSettingsBlock
{
    /// <summary>
    /// Specifies a map of Login Parameters to send to the OpenID Connect authorization endpoint when a user logs in.
    /// </summary>
    [TerraformPropertyName("additional_login_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AdditionalLoginParameters { get; set; }

    /// <summary>
    /// Specifies a list of External URLs that can be redirected to as part of logging in or logging out of the Windows Web App.
    /// </summary>
    [TerraformPropertyName("allowed_external_redirect_urls")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> AllowedExternalRedirectUrls { get; set; } = default!;

    /// <summary>
    /// The default authentication provider to use when multiple providers are configured. Possible values include: `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount`, `Twitter`, `Github`.
    /// </summary>
    [TerraformPropertyName("default_provider")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultProvider { get; set; } = default!;

    /// <summary>
    /// Should the Authentication / Authorization feature be enabled?
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues access tokens.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The RuntimeVersion of the Authentication / Authorization feature in use.
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RuntimeVersion { get; set; } = default!;

    /// <summary>
    /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to `72` hours.
    /// </summary>
    [TerraformPropertyName("token_refresh_extension_hours")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// Should the Windows Web App durably store platform-specific security tokens that are obtained during login flows? Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("token_store_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The action to take when an unauthenticated client attempts to access the app. Possible values include: `RedirectToLoginPage`, `AllowAnonymous`.
    /// </summary>
    [TerraformPropertyName("unauthenticated_client_action")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UnauthenticatedClientAction { get; set; } = default!;

}

/// <summary>
/// Block type for auth_settings_v2 in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotAuthSettingsV2Block
{
    /// <summary>
    /// Should the AuthV2 Settings be enabled. Defaults to `false`
    /// </summary>
    [TerraformPropertyName("auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AuthEnabled { get; set; }

    /// <summary>
    /// The path to the App Auth settings. **Note:** Relative Paths are evaluated from the Site Root directory.
    /// </summary>
    [TerraformPropertyName("config_file_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigFilePath { get; set; }

    /// <summary>
    /// The Default Authentication Provider to use when the `unauthenticated_action` is set to `RedirectToLoginPage`. Possible values include: `apple`, `azureactivedirectory`, `facebook`, `github`, `google`, `twitter` and the `name` of your `custom_oidc_v2` provider.
    /// </summary>
    [TerraformPropertyName("default_provider")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultProvider { get; set; }

    /// <summary>
    /// The paths which should be excluded from the `unauthenticated_action` when it is set to `RedirectToLoginPage`.
    /// </summary>
    [TerraformPropertyName("excluded_paths")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludedPaths { get; set; }

    /// <summary>
    /// The convention used to determine the url of the request made. Possible values include `ForwardProxyConventionNoProxy`, `ForwardProxyConventionStandard`, `ForwardProxyConventionCustom`. Defaults to `ForwardProxyConventionNoProxy`
    /// </summary>
    [TerraformPropertyName("forward_proxy_convention")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ForwardProxyConvention { get; set; }

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    [TerraformPropertyName("forward_proxy_custom_host_header_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ForwardProxyCustomHostHeaderName { get; set; }

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    [TerraformPropertyName("forward_proxy_custom_scheme_header_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ForwardProxyCustomSchemeHeaderName { get; set; }

    /// <summary>
    /// The prefix that should precede all the authentication and authorisation paths. Defaults to `/.auth`
    /// </summary>
    [TerraformPropertyName("http_route_api_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpRouteApiPrefix { get; set; }

    /// <summary>
    /// Should the authentication flow be used for all requests.
    /// </summary>
    [TerraformPropertyName("require_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireAuthentication { get; set; }

    /// <summary>
    /// Should HTTPS be required on connections? Defaults to true.
    /// </summary>
    [TerraformPropertyName("require_https")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireHttps { get; set; }

    /// <summary>
    /// The Runtime Version of the Authentication and Authorisation feature of this App. Defaults to `~1`
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RuntimeVersion { get; set; }

    /// <summary>
    /// The action to take for requests made without authentication. Possible values include `RedirectToLoginPage`, `AllowAnonymous`, `Return401`, and `Return403`. Defaults to `RedirectToLoginPage`.
    /// </summary>
    [TerraformPropertyName("unauthenticated_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UnauthenticatedAction { get; set; }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotBackupBlock
{
    /// <summary>
    /// Should this backup job be enabled?
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The name which should be used for this Backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The SAS URL to the container.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformPropertyName("storage_account_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageAccountUrl { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxWebAppSlotConnectionStringBlock
{
    /// <summary>
    /// The name which should be used for this Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Type of database. Possible values include: `MySQL`, `SQLServer`, `SQLAzure`, `Custom`, `NotificationHub`, `ServiceBus`, `EventHub`, `APIHub`, `DocDb`, `RedisCache`, and `PostgreSQL`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The connection string value.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotLogsBlock
{
    /// <summary>
    /// The detailed_error_messages attribute.
    /// </summary>
    [TerraformPropertyName("detailed_error_messages")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DetailedErrorMessages { get; set; }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    [TerraformPropertyName("failed_request_tracing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FailedRequestTracing { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxWebAppSlotSiteConfigBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AlwaysOn { get; set; }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    [TerraformPropertyName("api_definition_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiDefinitionUrl { get; set; }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    [TerraformPropertyName("api_management_api_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiManagementApiId { get; set; }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    [TerraformPropertyName("app_command_line")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AppCommandLine { get; set; }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformPropertyName("auto_swap_slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_managed_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerRegistryManagedIdentityClientId { get; set; }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    [TerraformPropertyName("container_registry_use_managed_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ContainerRegistryUseManagedIdentity { get; set; }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    [TerraformPropertyName("default_documents")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> DefaultDocuments { get; set; } = default!;


    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformPropertyName("ftps_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FtpsState { get; set; }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    [TerraformPropertyName("health_check_eviction_time_in_min")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthCheckEvictionTimeInMin { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction_default_action attribute.
    /// </summary>
    [TerraformPropertyName("ip_restriction_default_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpRestrictionDefaultAction { get; set; }


    /// <summary>
    /// The load_balancing_mode attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancingMode { get; set; }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_mysql_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalMysqlEnabled { get; set; }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    [TerraformPropertyName("managed_pipeline_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManagedPipelineMode { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RemoteDebuggingVersion { get; set; } = default!;

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    [TerraformPropertyName("scm_ip_restriction_default_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScmIpRestrictionDefaultAction { get; set; }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("scm_minimum_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ScmMinimumTlsVersion { get; set; }


    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("scm_use_main_ip_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker attribute.
    /// </summary>
    [TerraformPropertyName("use_32_bit_worker")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Use32BitWorker { get; set; }

    /// <summary>
    /// Should all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied? Defaults to `false`.
    /// </summary>
    [TerraformPropertyName("vnet_route_all_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformPropertyName("websockets_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WebsocketsEnabled { get; set; }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformPropertyName("worker_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> WorkerCount { get; set; } = default!;

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxWebAppSlotStorageAccountBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformPropertyName("access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformPropertyName("mount_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MountPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformPropertyName("share_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ShareName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxWebAppSlotTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_linux_web_app_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxWebAppSlot : TerraformResource
{
    public AzurermLinuxWebAppSlot(string name) : base("azurerm_linux_web_app_slot", name)
    {
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    [TerraformPropertyName("app_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppServiceId { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AppSettings { get; set; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ClientCertificateEnabled { get; set; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformPropertyName("client_certificate_exclusion_paths")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientCertificateExclusionPaths { get; set; }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ftp_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_reference_identity_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyVaultReferenceIdentityId { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("service_plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServicePlanId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_backup_restore_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VirtualNetworkBackupRestoreEnabled { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The vnet_image_pull_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vnet_image_pull_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VnetImagePullEnabled { get; set; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("webdeploy_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WebdeployPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.
    /// </summary>
    [TerraformPropertyName("zip_deploy_file")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ZipDeployFile { get; set; } = default!;

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotAuthSettingsBlock>>? AuthSettings { get; set; }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    [TerraformPropertyName("auth_settings_v2")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotAuthSettingsV2Block>>? AuthSettingsV2 { get; set; }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotBackupBlock>>? Backup { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppSlotConnectionStringBlock>>? ConnectionString { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermLinuxWebAppSlotSiteConfigBlock>>? SiteConfig { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_account")]
    public TerraformSet<TerraformBlock<AzurermLinuxWebAppSlotStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxWebAppSlotTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_metadata attribute.
    /// </summary>
    [TerraformPropertyName("app_metadata")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppMetadata => new TerraformReference(this, "app_metadata");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainVerificationId => new TerraformReference(this, "custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultHostname => new TerraformReference(this, "default_hostname");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("hosting_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostingEnvironmentId => new TerraformReference(this, "hosting_environment_id");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_address_list")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OutboundIpAddressList => new TerraformReference(this, "outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutboundIpAddresses => new TerraformReference(this, "outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_address_list")]
    // Output-only attribute - read-only reference
    public TerraformList<string> PossibleOutboundIpAddressList => new TerraformReference(this, "possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PossibleOutboundIpAddresses => new TerraformReference(this, "possible_outbound_ip_addresses");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformPropertyName("site_credential")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SiteCredential => new TerraformReference(this, "site_credential");

}

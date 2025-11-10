using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotAuthSettingsBlock : TerraformBlock
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
public class AzurermWindowsWebAppSlotAuthSettingsV2Block : TerraformBlock
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
public class AzurermWindowsWebAppSlotBackupBlock : TerraformBlock
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
public class AzurermWindowsWebAppSlotConnectionStringBlock : TerraformBlock
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
public class AzurermWindowsWebAppSlotIdentityBlock : TerraformBlock
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
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotLogsBlock : TerraformBlock
{
    /// <summary>
    /// The detailed_error_messages attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedErrorMessages
    {
        set => SetProperty("detailed_error_messages", value);
    }

    /// <summary>
    /// The failed_request_tracing attribute.
    /// </summary>
    public TerraformProperty<bool>? FailedRequestTracing
    {
        set => SetProperty("failed_request_tracing", value);
    }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermWindowsWebAppSlotSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        set => SetProperty("always_on", value);
    }

    /// <summary>
    /// The api_definition_url attribute.
    /// </summary>
    public TerraformProperty<string>? ApiDefinitionUrl
    {
        set => SetProperty("api_definition_url", value);
    }

    /// <summary>
    /// The api_management_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApiManagementApiId
    {
        set => SetProperty("api_management_api_id", value);
    }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    public TerraformProperty<string>? AppCommandLine
    {
        set => SetProperty("app_command_line", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutoSwapSlotName
    {
        set => SetProperty("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The container_registry_managed_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerRegistryManagedIdentityClientId
    {
        set => SetProperty("container_registry_managed_identity_client_id", value);
    }

    /// <summary>
    /// The container_registry_use_managed_identity attribute.
    /// </summary>
    public TerraformProperty<bool>? ContainerRegistryUseManagedIdentity
    {
        set => SetProperty("container_registry_use_managed_identity", value);
    }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DefaultDocuments
    {
        set => SetProperty("default_documents", value);
    }

    /// <summary>
    /// The detailed_error_logging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedErrorLoggingEnabled
    {
        set => SetProperty("detailed_error_logging_enabled", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        set => SetProperty("ftps_state", value);
    }

    /// <summary>
    /// The amount of time in minutes that a node is unhealthy before being removed from the load balancer. Possible values are between `2` and `10`. Only valid in conjunction with `health_check_path`
    /// </summary>
    public TerraformProperty<double>? HealthCheckEvictionTimeInMin
    {
        set => SetProperty("health_check_eviction_time_in_min", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        set => SetProperty("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
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
    /// The load_balancing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingMode
    {
        set => SetProperty("load_balancing_mode", value);
    }

    /// <summary>
    /// The local_mysql_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalMysqlEnabled
    {
        set => SetProperty("local_mysql_enabled", value);
    }

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedPipelineMode
    {
        set => SetProperty("managed_pipeline_mode", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        set => SetProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RemoteDebuggingEnabled
    {
        set => SetProperty("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteDebuggingVersion
    {
        set => SetProperty("remote_debugging_version", value);
    }

    /// <summary>
    /// The scm_ip_restriction_default_action attribute.
    /// </summary>
    public TerraformProperty<string>? ScmIpRestrictionDefaultAction
    {
        set => SetProperty("scm_ip_restriction_default_action", value);
    }

    /// <summary>
    /// The scm_minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? ScmMinimumTlsVersion
    {
        set => SetProperty("scm_minimum_tls_version", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScmType
    {
        set => SetProperty("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformProperty<bool>? ScmUseMainIpRestriction
    {
        set => SetProperty("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker attribute.
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
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebsocketsEnabled
    {
        set => SetProperty("websockets_enabled", value);
    }

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    public TerraformProperty<string>? WindowsFxVersion
    {
        set => SetProperty("windows_fx_version", value);
    }

    /// <summary>
    /// The worker_count attribute.
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
public class AzurermWindowsWebAppSlotStorageAccountBlock : TerraformBlock
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
public class AzurermWindowsWebAppSlotTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_windows_web_app_slot resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWindowsWebAppSlot : TerraformResource
{
    public AzurermWindowsWebAppSlot(string name) : base("azurerm_windows_web_app_slot", name)
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
        SetOutput("app_service_id");
        SetOutput("app_settings");
        SetOutput("client_affinity_enabled");
        SetOutput("client_certificate_enabled");
        SetOutput("client_certificate_exclusion_paths");
        SetOutput("client_certificate_mode");
        SetOutput("enabled");
        SetOutput("ftp_publish_basic_authentication_enabled");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("key_vault_reference_identity_id");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("service_plan_id");
        SetOutput("tags");
        SetOutput("virtual_network_backup_restore_enabled");
        SetOutput("virtual_network_subnet_id");
        SetOutput("webdeploy_publish_basic_authentication_enabled");
        SetOutput("zip_deploy_file");
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    public required TerraformProperty<string> AppServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_id");
        set => SetProperty("app_service_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AppSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => SetProperty("app_settings", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ClientAffinityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("client_affinity_enabled");
        set => SetProperty("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
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
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformProperty<string> ClientCertificateMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_mode");
        set => SetProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
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
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultReferenceIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => SetProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The name attribute.
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
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => SetProperty("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Windows Web App. **Note:** Using this value requires `WEBSITE_RUN_FROM_PACKAGE=1` on the App in `app_settings`.
    /// </summary>
    public TerraformProperty<string> ZipDeployFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zip_deploy_file");
        set => SetProperty("zip_deploy_file", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermWindowsWebAppSlotAuthSettingsBlock>? AuthSettings
    {
        set => SetProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for auth_settings_v2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettingsV2 block(s) allowed")]
    public List<AzurermWindowsWebAppSlotAuthSettingsV2Block>? AuthSettingsV2
    {
        set => SetProperty("auth_settings_v2", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermWindowsWebAppSlotBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWindowsWebAppSlotConnectionStringBlock>? ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWindowsWebAppSlotIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public List<AzurermWindowsWebAppSlotLogsBlock>? Logs
    {
        set => SetProperty("logs", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SiteConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermWindowsWebAppSlotSiteConfigBlock>? SiteConfig
    {
        set => SetProperty("site_config", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermWindowsWebAppSlotStorageAccountBlock>? StorageAccount
    {
        set => SetProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWindowsWebAppSlotTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

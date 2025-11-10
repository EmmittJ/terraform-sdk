using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The additional_login_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalLoginParams
    {
        set => SetProperty("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedExternalRedirectUrls
    {
        set => SetProperty("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        set => SetProperty("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    public TerraformProperty<double>? TokenRefreshExtensionHours
    {
        set => SetProperty("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TokenStoreEnabled
    {
        set => SetProperty("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedClientAction
    {
        set => SetProperty("unauthenticated_client_action", value);
    }

}

/// <summary>
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceBackupBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
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
    /// The storage_account_url attribute.
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
public class AzurermAppServiceConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
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
public class AzurermAppServiceIdentityBlock : TerraformBlock
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
public class AzurermAppServiceLogsBlock : TerraformBlock
{
    /// <summary>
    /// The detailed_error_messages_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DetailedErrorMessagesEnabled
    {
        set => SetProperty("detailed_error_messages_enabled", value);
    }

    /// <summary>
    /// The failed_request_tracing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FailedRequestTracingEnabled
    {
        set => SetProperty("failed_request_tracing_enabled", value);
    }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// The acr_use_managed_identity_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? AcrUseManagedIdentityCredentials
    {
        set => SetProperty("acr_use_managed_identity_credentials", value);
    }

    /// <summary>
    /// The acr_user_managed_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? AcrUserManagedIdentityClientId
    {
        set => SetProperty("acr_user_managed_identity_client_id", value);
    }

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        set => SetProperty("always_on", value);
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
    /// The default_documents attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DefaultDocuments
    {
        set => SetProperty("default_documents", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformProperty<string>? DotnetFrameworkVersion
    {
        set => SetProperty("dotnet_framework_version", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        set => SetProperty("ftps_state", value);
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
    /// The ip_restriction attribute.
    /// </summary>
    public List<TerraformProperty<object>>? IpRestriction
    {
        set => SetProperty("ip_restriction", value);
    }

    /// <summary>
    /// The java_container attribute.
    /// </summary>
    public TerraformProperty<string>? JavaContainer
    {
        set => SetProperty("java_container", value);
    }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    public TerraformProperty<string>? JavaContainerVersion
    {
        set => SetProperty("java_container_version", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformProperty<string>? JavaVersion
    {
        set => SetProperty("java_version", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformProperty<string>? LinuxFxVersion
    {
        set => SetProperty("linux_fx_version", value);
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
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        set => SetProperty("min_tls_version", value);
    }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfWorkers
    {
        set => SetProperty("number_of_workers", value);
    }

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    public TerraformProperty<string>? PhpVersion
    {
        set => SetProperty("php_version", value);
    }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    public TerraformProperty<string>? PythonVersion
    {
        set => SetProperty("python_version", value);
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
    /// The scm_ip_restriction attribute.
    /// </summary>
    public List<TerraformProperty<object>>? ScmIpRestriction
    {
        set => SetProperty("scm_ip_restriction", value);
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
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformProperty<bool>? Use32BitWorkerProcess
    {
        set => SetProperty("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
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

}

/// <summary>
/// Block type for source_control in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        set => SetProperty("branch", value);
    }

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    public TerraformProperty<bool>? ManualIntegration
    {
        set => SetProperty("manual_integration", value);
    }

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    public TerraformProperty<string>? RepoUrl
    {
        set => SetProperty("repo_url", value);
    }

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RollbackEnabled
    {
        set => SetProperty("rollback_enabled", value);
    }

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    public TerraformProperty<bool>? UseMercurial
    {
        set => SetProperty("use_mercurial", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceStorageAccountBlock : TerraformBlock
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
public class AzurermAppServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_service resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppService : TerraformResource
{
    public AzurermAppService(string name) : base("azurerm_app_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_domain_verification_id");
        SetOutput("default_site_hostname");
        SetOutput("outbound_ip_address_list");
        SetOutput("outbound_ip_addresses");
        SetOutput("possible_outbound_ip_address_list");
        SetOutput("possible_outbound_ip_addresses");
        SetOutput("site_credential");
        SetOutput("app_service_plan_id");
        SetOutput("app_settings");
        SetOutput("client_affinity_enabled");
        SetOutput("client_cert_enabled");
        SetOutput("client_cert_mode");
        SetOutput("enabled");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("key_vault_reference_identity_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformProperty<string> AppServicePlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_plan_id");
        set => SetProperty("app_service_plan_id", value);
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
    /// The client_cert_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ClientCertEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("client_cert_enabled");
        set => SetProperty("client_cert_enabled", value);
    }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformProperty<string> ClientCertMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_cert_mode");
        set => SetProperty("client_cert_mode", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermAppServiceAuthSettingsBlock>? AuthSettings
    {
        set => SetProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    public List<AzurermAppServiceBackupBlock>? Backup
    {
        set => SetProperty("backup", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermAppServiceConnectionStringBlock>? ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermAppServiceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public List<AzurermAppServiceLogsBlock>? Logs
    {
        set => SetProperty("logs", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermAppServiceSiteConfigBlock>? SiteConfig
    {
        set => SetProperty("site_config", value);
    }

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    public List<AzurermAppServiceSourceControlBlock>? SourceControl
    {
        set => SetProperty("source_control", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermAppServiceStorageAccountBlock>? StorageAccount
    {
        set => SetProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultSiteHostname => this["default_site_hostname"];

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

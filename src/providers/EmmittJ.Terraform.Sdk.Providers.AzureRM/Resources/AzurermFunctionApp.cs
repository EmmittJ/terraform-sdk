using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlock : TerraformBlock
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
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermFunctionAppConnectionStringBlock : TerraformBlock
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
public class AzurermFunctionAppIdentityBlock : TerraformBlock
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
public class AzurermFunctionAppSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        set => SetProperty("always_on", value);
    }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    public TerraformProperty<double>? AppScaleLimit
    {
        set => SetProperty("app_scale_limit", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutoSwapSlotName
    {
        set => SetProperty("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformProperty<string>? DotnetFrameworkVersion
    {
        set => SetProperty("dotnet_framework_version", value);
    }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    public TerraformProperty<double>? ElasticInstanceMinimum
    {
        set => SetProperty("elastic_instance_minimum", value);
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
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        set => SetProperty("min_tls_version", value);
    }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? PreWarmedInstanceCount
    {
        set => SetProperty("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RuntimeScaleMonitoringEnabled
    {
        set => SetProperty("runtime_scale_monitoring_enabled", value);
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

}

/// <summary>
/// Block type for source_control in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppSourceControlBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_function_app resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFunctionApp : TerraformResource
{
    public AzurermFunctionApp(string name) : base("azurerm_function_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("custom_domain_verification_id");
        SetOutput("default_hostname");
        SetOutput("kind");
        SetOutput("outbound_ip_addresses");
        SetOutput("possible_outbound_ip_addresses");
        SetOutput("site_credential");
        SetOutput("app_service_plan_id");
        SetOutput("app_settings");
        SetOutput("client_cert_mode");
        SetOutput("daily_memory_time_quota");
        SetOutput("enable_builtin_logging");
        SetOutput("enabled");
        SetOutput("https_only");
        SetOutput("id");
        SetOutput("key_vault_reference_identity_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("os_type");
        SetOutput("resource_group_name");
        SetOutput("storage_account_access_key");
        SetOutput("storage_account_name");
        SetOutput("tags");
        SetOutput("version");
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
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformProperty<string> ClientCertMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_cert_mode");
        set => SetProperty("client_cert_mode", value);
    }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformProperty<double> DailyMemoryTimeQuota
    {
        get => GetRequiredOutput<TerraformProperty<double>>("daily_memory_time_quota");
        set => SetProperty("daily_memory_time_quota", value);
    }

    /// <summary>
    /// The enable_builtin_logging attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBuiltinLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_builtin_logging");
        set => SetProperty("enable_builtin_logging", value);
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
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
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
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_access_key");
        set => SetProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_name");
        set => SetProperty("storage_account_name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermFunctionAppAuthSettingsBlock>? AuthSettings
    {
        set => SetProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermFunctionAppConnectionStringBlock>? ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermFunctionAppIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermFunctionAppSiteConfigBlock>? SiteConfig
    {
        set => SetProperty("site_config", value);
    }

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    public List<AzurermFunctionAppSourceControlBlock>? SourceControl
    {
        set => SetProperty("source_control", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppTimeoutsBlock? Timeouts
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
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}

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
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_login_params");
        set => WithProperty("additional_login_params", value);
    }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedExternalRedirectUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_external_redirect_urls");
        set => WithProperty("allowed_external_redirect_urls", value);
    }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultProvider
    {
        get => GetProperty<TerraformProperty<string>>("default_provider");
        set => WithProperty("default_provider", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    public TerraformProperty<double>? TokenRefreshExtensionHours
    {
        get => GetProperty<TerraformProperty<double>>("token_refresh_extension_hours");
        set => WithProperty("token_refresh_extension_hours", value);
    }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TokenStoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("token_store_enabled");
        set => WithProperty("token_store_enabled", value);
    }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    public TerraformProperty<string>? UnauthenticatedClientAction
    {
        get => GetProperty<TerraformProperty<string>>("unauthenticated_client_action");
        set => WithProperty("unauthenticated_client_action", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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

    /// <summary>
    /// The value attribute.
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
public class AzurermFunctionAppIdentityBlock : TerraformBlock
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
public class AzurermFunctionAppSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        get => GetProperty<TerraformProperty<bool>>("always_on");
        set => WithProperty("always_on", value);
    }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    public TerraformProperty<double>? AppScaleLimit
    {
        get => GetProperty<TerraformProperty<double>>("app_scale_limit");
        set => WithProperty("app_scale_limit", value);
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
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformProperty<string>? DotnetFrameworkVersion
    {
        get => GetProperty<TerraformProperty<string>>("dotnet_framework_version");
        set => WithProperty("dotnet_framework_version", value);
    }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    public TerraformProperty<double>? ElasticInstanceMinimum
    {
        get => GetProperty<TerraformProperty<double>>("elastic_instance_minimum");
        set => WithProperty("elastic_instance_minimum", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        get => GetProperty<TerraformProperty<string>>("ftps_state");
        set => WithProperty("ftps_state", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        get => GetProperty<TerraformProperty<string>>("health_check_path");
        set => WithProperty("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("http2_enabled");
        set => WithProperty("http2_enabled", value);
    }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    public List<TerraformProperty<object>>? IpRestriction
    {
        get => GetProperty<List<TerraformProperty<object>>>("ip_restriction");
        set => WithProperty("ip_restriction", value);
    }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    public TerraformProperty<string>? JavaVersion
    {
        get => GetProperty<TerraformProperty<string>>("java_version");
        set => WithProperty("java_version", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformProperty<string>? LinuxFxVersion
    {
        get => GetProperty<TerraformProperty<string>>("linux_fx_version");
        set => WithProperty("linux_fx_version", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? PreWarmedInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("pre_warmed_instance_count");
        set => WithProperty("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RuntimeScaleMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("runtime_scale_monitoring_enabled");
        set => WithProperty("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    public List<TerraformProperty<object>>? ScmIpRestriction
    {
        get => GetProperty<List<TerraformProperty<object>>>("scm_ip_restriction");
        set => WithProperty("scm_ip_restriction", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScmType
    {
        get => GetProperty<TerraformProperty<string>>("scm_type");
        set => WithProperty("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformProperty<bool>? ScmUseMainIpRestriction
    {
        get => GetProperty<TerraformProperty<bool>>("scm_use_main_ip_restriction");
        set => WithProperty("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformProperty<bool>? Use32BitWorkerProcess
    {
        get => GetProperty<TerraformProperty<bool>>("use_32_bit_worker_process");
        set => WithProperty("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VnetRouteAllEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_route_all_enabled");
        set => WithProperty("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebsocketsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("websockets_enabled");
        set => WithProperty("websockets_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    public TerraformProperty<bool>? ManualIntegration
    {
        get => GetProperty<TerraformProperty<bool>>("manual_integration");
        set => WithProperty("manual_integration", value);
    }

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    public TerraformProperty<string>? RepoUrl
    {
        get => GetProperty<TerraformProperty<string>>("repo_url");
        set => WithProperty("repo_url", value);
    }

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RollbackEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rollback_enabled");
        set => WithProperty("rollback_enabled", value);
    }

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    public TerraformProperty<bool>? UseMercurial
    {
        get => GetProperty<TerraformProperty<bool>>("use_mercurial");
        set => WithProperty("use_mercurial", value);
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
/// Manages a azurerm_function_app resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermFunctionApp : TerraformResource
{
    public AzurermFunctionApp(string name) : base("azurerm_function_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("kind");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformProperty<string> AppServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_plan_id");
        set => this.WithProperty("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AppSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertMode
    {
        get => GetProperty<TerraformProperty<string>>("client_cert_mode");
        set => this.WithProperty("client_cert_mode", value);
    }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformProperty<double>? DailyMemoryTimeQuota
    {
        get => GetProperty<TerraformProperty<double>>("daily_memory_time_quota");
        set => this.WithProperty("daily_memory_time_quota", value);
    }

    /// <summary>
    /// The enable_builtin_logging attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBuiltinLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_builtin_logging");
        set => this.WithProperty("enable_builtin_logging", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultReferenceIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_reference_identity_id");
        set => this.WithProperty("key_vault_reference_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    public List<AzurermFunctionAppAuthSettingsBlock>? AuthSettings
    {
        get => GetProperty<List<AzurermFunctionAppAuthSettingsBlock>>("auth_settings");
        set => this.WithProperty("auth_settings", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermFunctionAppConnectionStringBlock>? ConnectionString
    {
        get => GetProperty<HashSet<AzurermFunctionAppConnectionStringBlock>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermFunctionAppIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermFunctionAppIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermFunctionAppSiteConfigBlock>? SiteConfig
    {
        get => GetProperty<List<AzurermFunctionAppSiteConfigBlock>>("site_config");
        set => this.WithProperty("site_config", value);
    }

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    public List<AzurermFunctionAppSourceControlBlock>? SourceControl
    {
        get => GetProperty<List<AzurermFunctionAppSourceControlBlock>>("source_control");
        set => this.WithProperty("source_control", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFunctionAppTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFunctionAppTimeoutsBlock>("timeouts");
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

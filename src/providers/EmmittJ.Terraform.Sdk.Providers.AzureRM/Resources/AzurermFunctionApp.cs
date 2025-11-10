using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppAuthSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_login_params attribute.
    /// </summary>
    [TerraformPropertyName("additional_login_params")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalLoginParams { get; set; }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    [TerraformPropertyName("allowed_external_redirect_urls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    [TerraformPropertyName("default_provider")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultProvider { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Issuer { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [TerraformPropertyName("runtime_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RuntimeVersion { get; set; }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    [TerraformPropertyName("token_refresh_extension_hours")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    [TerraformPropertyName("token_store_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    [TerraformPropertyName("unauthenticated_client_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UnauthenticatedClientAction { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermFunctionAppConnectionStringBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The value attribute.
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
public class AzurermFunctionAppIdentityBlock : ITerraformBlock
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
public class AzurermFunctionAppSiteConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AlwaysOn { get; set; }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    [TerraformPropertyName("app_scale_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AppScaleLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "app_scale_limit");

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformPropertyName("auto_swap_slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformPropertyName("dotnet_framework_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DotnetFrameworkVersion { get; set; }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    [TerraformPropertyName("elastic_instance_minimum")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ElasticInstanceMinimum { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "elastic_instance_minimum");

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformPropertyName("ftps_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FtpsState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ftps_state");

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("ip_restriction")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> IpRestriction { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "ip_restriction");

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    [TerraformPropertyName("java_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JavaVersion { get; set; }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformPropertyName("linux_fx_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LinuxFxVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "linux_fx_version");

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinTlsVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_tls_version");

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("pre_warmed_instance_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PreWarmedInstanceCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "pre_warmed_instance_count");

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("runtime_scale_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("scm_ip_restriction")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> ScmIpRestriction { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "scm_ip_restriction");

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScmType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scm_type");

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("scm_use_main_ip_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    [TerraformPropertyName("use_32_bit_worker_process")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Use32BitWorkerProcess { get; set; }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vnet_route_all_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> VnetRouteAllEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "vnet_route_all_enabled");

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformPropertyName("websockets_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebsocketsEnabled { get; set; }

}

/// <summary>
/// Block type for source_control in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppSourceControlBlock : ITerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformPropertyName("branch")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Branch { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "branch");

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    [TerraformPropertyName("manual_integration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ManualIntegration { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "manual_integration");

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    [TerraformPropertyName("repo_url")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RepoUrl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "repo_url");

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rollback_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RollbackEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "rollback_enabled");

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    [TerraformPropertyName("use_mercurial")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> UseMercurial { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "use_mercurial");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_function_app resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFunctionApp : TerraformResource
{
    public AzurermFunctionApp(string name) : base("azurerm_function_app", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    [TerraformPropertyName("app_service_plan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppServicePlanId { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppSettings { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_settings");

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_cert_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertMode { get; set; }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    [TerraformPropertyName("daily_memory_time_quota")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// The enable_builtin_logging attribute.
    /// </summary>
    [TerraformPropertyName("enable_builtin_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableBuiltinLogging { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The https_only attribute.
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
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_reference_identity_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultReferenceIdentityId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_reference_identity_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OsType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformPropertyName("storage_account_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformPropertyName("storage_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermFunctionAppAuthSettingsBlock>>? AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermFunctionAppConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermFunctionAppIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermFunctionAppSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    [TerraformPropertyName("source_control")]
    public TerraformList<TerraformBlock<AzurermFunctionAppSourceControlBlock>>? SourceControl { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutboundIpAddresses => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outbound_ip_addresses");

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

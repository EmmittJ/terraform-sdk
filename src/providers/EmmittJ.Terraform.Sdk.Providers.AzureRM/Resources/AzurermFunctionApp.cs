using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppAuthSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_login_params attribute.
    /// </summary>
    [TerraformProperty("additional_login_params")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalLoginParams { get; set; }

    /// <summary>
    /// The allowed_external_redirect_urls attribute.
    /// </summary>
    [TerraformProperty("allowed_external_redirect_urls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedExternalRedirectUrls { get; set; }

    /// <summary>
    /// The default_provider attribute.
    /// </summary>
    [TerraformProperty("default_provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultProvider { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeVersion { get; set; }

    /// <summary>
    /// The token_refresh_extension_hours attribute.
    /// </summary>
    [TerraformProperty("token_refresh_extension_hours")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TokenRefreshExtensionHours { get; set; }

    /// <summary>
    /// The token_store_enabled attribute.
    /// </summary>
    [TerraformProperty("token_store_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TokenStoreEnabled { get; set; }

    /// <summary>
    /// The unauthenticated_client_action attribute.
    /// </summary>
    [TerraformProperty("unauthenticated_client_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UnauthenticatedClientAction { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public partial class AzurermFunctionAppConnectionStringBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppSiteConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformProperty("always_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AlwaysOn { get; set; }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    [TerraformProperty("app_scale_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AppScaleLimit { get; set; }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformProperty("auto_swap_slot_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformProperty("dotnet_framework_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DotnetFrameworkVersion { get; set; }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    [TerraformProperty("elastic_instance_minimum")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformProperty("ftps_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FtpsState { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The ip_restriction attribute.
    /// </summary>
    [TerraformProperty("ip_restriction")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> IpRestriction { get; set; }

    /// <summary>
    /// The java_version attribute.
    /// </summary>
    [TerraformProperty("java_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JavaVersion { get; set; }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformProperty("linux_fx_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LinuxFxVersion { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinTlsVersion { get; set; }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    [TerraformProperty("pre_warmed_instance_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("runtime_scale_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_ip_restriction attribute.
    /// </summary>
    [TerraformProperty("scm_ip_restriction")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> ScmIpRestriction { get; set; }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformProperty("scm_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScmType { get; set; }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformProperty("scm_use_main_ip_restriction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    [TerraformProperty("use_32_bit_worker_process")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Use32BitWorkerProcess { get; set; }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    [TerraformProperty("vnet_route_all_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformProperty("websockets_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WebsocketsEnabled { get; set; }

}

/// <summary>
/// Block type for source_control in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppSourceControlBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    [TerraformProperty("branch")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Branch { get; set; }

    /// <summary>
    /// The manual_integration attribute.
    /// </summary>
    [TerraformProperty("manual_integration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ManualIntegration { get; set; }

    /// <summary>
    /// The repo_url attribute.
    /// </summary>
    [TerraformProperty("repo_url")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RepoUrl { get; set; }

    /// <summary>
    /// The rollback_enabled attribute.
    /// </summary>
    [TerraformProperty("rollback_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> RollbackEnabled { get; set; }

    /// <summary>
    /// The use_mercurial attribute.
    /// </summary>
    [TerraformProperty("use_mercurial")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> UseMercurial { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_function_app resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFunctionApp : TerraformResource
{
    public AzurermFunctionApp(string name) : base("azurerm_function_app", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    [TerraformProperty("app_service_plan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppServicePlanId { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> AppSettings { get; set; }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    [TerraformProperty("client_cert_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertMode { get; set; }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    [TerraformProperty("daily_memory_time_quota")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DailyMemoryTimeQuota { get; set; }

    /// <summary>
    /// The enable_builtin_logging attribute.
    /// </summary>
    [TerraformProperty("enable_builtin_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableBuiltinLogging { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_reference_identity_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_reference_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultReferenceIdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformProperty("storage_account_access_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformProperty("storage_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformProperty("auth_settings")]
    public partial TerraformList<TerraformBlock<AzurermFunctionAppAuthSettingsBlock>>? AuthSettings { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connection_string")]
    public partial TerraformSet<TerraformBlock<AzurermFunctionAppConnectionStringBlock>>? ConnectionString { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermFunctionAppIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformProperty("site_config")]
    public partial TerraformList<TerraformBlock<AzurermFunctionAppSiteConfigBlock>>? SiteConfig { get; set; }

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    [TerraformProperty("source_control")]
    public partial TerraformList<TerraformBlock<AzurermFunctionAppSourceControlBlock>>? SourceControl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermFunctionAppTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PossibleOutboundIpAddresses { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteCredential { get; }

}

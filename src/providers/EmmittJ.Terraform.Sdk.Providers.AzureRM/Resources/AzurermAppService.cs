using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auth_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceAuthSettingsBlock : ITerraformBlock
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
/// Block type for backup in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceBackupBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountUrl is required")]
    [TerraformPropertyName("storage_account_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountUrl { get; set; }

}

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceConnectionStringBlock : ITerraformBlock
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
public class AzurermAppServiceIdentityBlock : ITerraformBlock
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
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The detailed_error_messages_enabled attribute.
    /// </summary>
    [TerraformPropertyName("detailed_error_messages_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DetailedErrorMessagesEnabled { get; set; }

    /// <summary>
    /// The failed_request_tracing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("failed_request_tracing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FailedRequestTracingEnabled { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSiteConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The acr_use_managed_identity_credentials attribute.
    /// </summary>
    [TerraformPropertyName("acr_use_managed_identity_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AcrUseManagedIdentityCredentials { get; set; }

    /// <summary>
    /// The acr_user_managed_identity_client_id attribute.
    /// </summary>
    [TerraformPropertyName("acr_user_managed_identity_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcrUserManagedIdentityClientId { get; set; }

    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AlwaysOn { get; set; }

    /// <summary>
    /// The app_command_line attribute.
    /// </summary>
    [TerraformPropertyName("app_command_line")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AppCommandLine { get; set; }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformPropertyName("auto_swap_slot_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutoSwapSlotName { get; set; }

    /// <summary>
    /// The default_documents attribute.
    /// </summary>
    [TerraformPropertyName("default_documents")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DefaultDocuments { get; set; }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformPropertyName("dotnet_framework_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DotnetFrameworkVersion { get; set; }

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
    /// The java_container attribute.
    /// </summary>
    [TerraformPropertyName("java_container")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JavaContainer { get; set; }

    /// <summary>
    /// The java_container_version attribute.
    /// </summary>
    [TerraformPropertyName("java_container_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JavaContainerVersion { get; set; }

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
    /// The local_mysql_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_mysql_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> LocalMysqlEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "local_mysql_enabled");

    /// <summary>
    /// The managed_pipeline_mode attribute.
    /// </summary>
    [TerraformPropertyName("managed_pipeline_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ManagedPipelineMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "managed_pipeline_mode");

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinTlsVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_tls_version");

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("number_of_workers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumberOfWorkers { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "number_of_workers");

    /// <summary>
    /// The php_version attribute.
    /// </summary>
    [TerraformPropertyName("php_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PhpVersion { get; set; }

    /// <summary>
    /// The python_version attribute.
    /// </summary>
    [TerraformPropertyName("python_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PythonVersion { get; set; }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteDebuggingEnabled { get; set; }

    /// <summary>
    /// The remote_debugging_version attribute.
    /// </summary>
    [TerraformPropertyName("remote_debugging_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RemoteDebuggingVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "remote_debugging_version");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> WebsocketsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "websockets_enabled");

    /// <summary>
    /// The windows_fx_version attribute.
    /// </summary>
    [TerraformPropertyName("windows_fx_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WindowsFxVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "windows_fx_version");

}

/// <summary>
/// Block type for source_control in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceSourceControlBlock : ITerraformBlock
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
/// Block type for storage_account in .
/// Nesting mode: set
/// </summary>
public class AzurermAppServiceStorageAccountBlock : ITerraformBlock
{
    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKey is required")]
    [TerraformPropertyName("access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessKey { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The mount_path attribute.
    /// </summary>
    [TerraformPropertyName("mount_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MountPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareName is required")]
    [TerraformPropertyName("share_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ShareName { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_app_service resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermAppService : TerraformResource
{
    public AzurermAppService(string name) : base("azurerm_app_service", name)
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
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientAffinityEnabled { get; set; }

    /// <summary>
    /// The client_cert_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_cert_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientCertEnabled { get; set; }

    /// <summary>
    /// The client_cert_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_cert_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClientCertMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_cert_mode");

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for auth_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthSettings block(s) allowed")]
    [TerraformPropertyName("auth_settings")]
    public TerraformList<TerraformBlock<AzurermAppServiceAuthSettingsBlock>>? AuthSettings { get; set; } = new();

    /// <summary>
    /// Block for backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Backup block(s) allowed")]
    [TerraformPropertyName("backup")]
    public TerraformList<TerraformBlock<AzurermAppServiceBackupBlock>>? Backup { get; set; } = new();

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermAppServiceConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermAppServiceIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermAppServiceLogsBlock>>? Logs { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermAppServiceSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for source_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceControl block(s) allowed")]
    [TerraformPropertyName("source_control")]
    public TerraformList<TerraformBlock<AzurermAppServiceSourceControlBlock>>? SourceControl { get; set; } = new();

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("storage_account")]
    public TerraformSet<TerraformBlock<AzurermAppServiceStorageAccountBlock>>? StorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermAppServiceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The default_site_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_site_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultSiteHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_site_hostname");

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

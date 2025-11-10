using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWindowsFunctionAppDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_windows_function_app.
/// </summary>
public class AzurermWindowsFunctionAppDataSource : TerraformDataSource
{
    public AzurermWindowsFunctionAppDataSource(string name) : base("azurerm_windows_function_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermWindowsFunctionAppDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppSettings => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_settings");

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    [TerraformPropertyName("auth_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auth_settings");

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    [TerraformPropertyName("auth_settings_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AuthSettingsV2 => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auth_settings_v2");

    /// <summary>
    /// The backup attribute.
    /// </summary>
    [TerraformPropertyName("backup")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Backup => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backup");

    /// <summary>
    /// The builtin_logging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("builtin_logging_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BuiltinLoggingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "builtin_logging_enabled");

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ClientCertificateEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "client_certificate_enabled");

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformPropertyName("client_certificate_exclusion_paths")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientCertificateExclusionPaths => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_certificate_exclusion_paths");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientCertificateMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_certificate_mode");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> ConnectionString => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "connection_string");

    /// <summary>
    /// The content_share_force_disabled attribute.
    /// </summary>
    [TerraformPropertyName("content_share_force_disabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ContentShareForceDisabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "content_share_force_disabled");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    [TerraformPropertyName("daily_memory_time_quota")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DailyMemoryTimeQuota => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "daily_memory_time_quota");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ftp_publish_basic_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FtpPublishBasicAuthenticationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ftp_publish_basic_authentication_enabled");

    /// <summary>
    /// The functions_extension_version attribute.
    /// </summary>
    [TerraformPropertyName("functions_extension_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FunctionsExtensionVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "functions_extension_version");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("hosting_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostingEnvironmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosting_environment_id");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HttpsOnly => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "public_network_access_enabled");

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("service_plan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicePlanId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_plan_id");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformPropertyName("site_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SiteConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformPropertyName("site_credential")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SiteCredential => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "site_credential");

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    [TerraformPropertyName("sticky_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StickySettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sticky_settings");

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_access_key");

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageAccountName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_name");

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String used to connect to the storage account for this Function App.
    /// </summary>
    [TerraformPropertyName("storage_key_vault_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageKeyVaultSecretId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_key_vault_secret_id");

    /// <summary>
    /// The storage_uses_managed_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_uses_managed_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StorageUsesManagedIdentity => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_uses_managed_identity");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_backup_restore_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> VirtualNetworkBackupRestoreEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "virtual_network_backup_restore_enabled");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualNetworkSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_network_subnet_id");

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("webdeploy_publish_basic_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> WebdeployPublishBasicAuthenticationEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "webdeploy_publish_basic_authentication_enabled");

}

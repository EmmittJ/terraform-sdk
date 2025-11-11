using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxFunctionAppDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_linux_function_app.
/// </summary>
public class AzurermLinuxFunctionAppDataSource : TerraformDataSource
{
    public AzurermLinuxFunctionAppDataSource(string name) : base("azurerm_linux_function_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLinuxFunctionAppDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppSettings => new TerraformReference(this, "app_settings");

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    [TerraformPropertyName("auth_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthSettings => new TerraformReference(this, "auth_settings");

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    [TerraformPropertyName("auth_settings_v2")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthSettingsV2 => new TerraformReference(this, "auth_settings_v2");

    /// <summary>
    /// The availability attribute.
    /// </summary>
    [TerraformPropertyName("availability")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Availability => new TerraformReference(this, "availability");

    /// <summary>
    /// The backup attribute.
    /// </summary>
    [TerraformPropertyName("backup")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Backup => new TerraformReference(this, "backup");

    /// <summary>
    /// The builtin_logging_enabled attribute.
    /// </summary>
    [TerraformPropertyName("builtin_logging_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BuiltinLoggingEnabled => new TerraformReference(this, "builtin_logging_enabled");

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ClientCertificateEnabled => new TerraformReference(this, "client_certificate_enabled");

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformPropertyName("client_certificate_exclusion_paths")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientCertificateExclusionPaths => new TerraformReference(this, "client_certificate_exclusion_paths");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientCertificateMode => new TerraformReference(this, "client_certificate_mode");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> ConnectionString => new TerraformReference(this, "connection_string");

    /// <summary>
    /// The content_share_force_disabled attribute.
    /// </summary>
    [TerraformPropertyName("content_share_force_disabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ContentShareForceDisabled => new TerraformReference(this, "content_share_force_disabled");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainVerificationId => new TerraformReference(this, "custom_domain_verification_id");

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    [TerraformPropertyName("daily_memory_time_quota")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DailyMemoryTimeQuota => new TerraformReference(this, "daily_memory_time_quota");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultHostname => new TerraformReference(this, "default_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ftp_publish_basic_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled => new TerraformReference(this, "ftp_publish_basic_authentication_enabled");

    /// <summary>
    /// The functions_extension_version attribute.
    /// </summary>
    [TerraformPropertyName("functions_extension_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FunctionsExtensionVersion => new TerraformReference(this, "functions_extension_version");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("hosting_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostingEnvironmentId => new TerraformReference(this, "hosting_environment_id");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HttpsOnly => new TerraformReference(this, "https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PublicNetworkAccessEnabled => new TerraformReference(this, "public_network_access_enabled");

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("service_plan_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServicePlanId => new TerraformReference(this, "service_plan_id");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformPropertyName("site_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SiteConfig => new TerraformReference(this, "site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformPropertyName("site_credential")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SiteCredential => new TerraformReference(this, "site_credential");

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    [TerraformPropertyName("sticky_settings")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StickySettings => new TerraformReference(this, "sticky_settings");

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_access_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountAccessKey => new TerraformReference(this, "storage_account_access_key");

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountName => new TerraformReference(this, "storage_account_name");

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String used to connect to the storage account for this Function App.
    /// </summary>
    [TerraformPropertyName("storage_key_vault_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageKeyVaultSecretId => new TerraformReference(this, "storage_key_vault_secret_id");

    /// <summary>
    /// The storage_uses_managed_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_uses_managed_identity")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StorageUsesManagedIdentity => new TerraformReference(this, "storage_uses_managed_identity");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The usage attribute.
    /// </summary>
    [TerraformPropertyName("usage")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Usage => new TerraformReference(this, "usage");

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_backup_restore_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled => new TerraformReference(this, "virtual_network_backup_restore_enabled");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkSubnetId => new TerraformReference(this, "virtual_network_subnet_id");

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("webdeploy_publish_basic_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled => new TerraformReference(this, "webdeploy_publish_basic_authentication_enabled");

}

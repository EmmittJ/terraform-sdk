using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWindowsFunctionAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermWindowsFunctionAppDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_windows_function_app Terraform data source.
/// Retrieves information about a azurerm_windows_function_app.
/// </summary>
public partial class AzurermWindowsFunctionAppDataSource(string name) : TerraformDataSource("azurerm_windows_function_app", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => CreateReference("app_settings");

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettings
        => CreateReference("auth_settings");

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettingsV2
        => CreateReference("auth_settings_v2");

    /// <summary>
    /// The backup attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Backup
        => CreateReference("backup");

    /// <summary>
    /// The builtin_logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BuiltinLoggingEnabled
        => CreateReference("builtin_logging_enabled");

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientCertificateEnabled
        => CreateReference("client_certificate_enabled");

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformValue<string> ClientCertificateExclusionPaths
        => CreateReference("client_certificate_exclusion_paths");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> ClientCertificateMode
        => CreateReference("client_certificate_mode");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConnectionString
        => CreateReference("connection_string");

    /// <summary>
    /// The content_share_force_disabled attribute.
    /// </summary>
    public TerraformValue<bool> ContentShareForceDisabled
        => CreateReference("content_share_force_disabled");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => CreateReference("custom_domain_verification_id");

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformValue<double> DailyMemoryTimeQuota
        => CreateReference("daily_memory_time_quota");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
        => CreateReference("default_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => CreateReference("enabled");

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled
        => CreateReference("ftp_publish_basic_authentication_enabled");

    /// <summary>
    /// The functions_extension_version attribute.
    /// </summary>
    public TerraformValue<string> FunctionsExtensionVersion
        => CreateReference("functions_extension_version");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
        => CreateReference("hosting_environment_id");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => CreateReference("https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => CreateReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => CreateReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => CreateReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => CreateReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => CreateReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => CreateReference("public_network_access_enabled");

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformValue<string> ServicePlanId
        => CreateReference("service_plan_id");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteConfig
        => CreateReference("site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => CreateReference("site_credential");

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StickySettings
        => CreateReference("sticky_settings");

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountAccessKey
        => CreateReference("storage_account_access_key");

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountName
        => CreateReference("storage_account_name");

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String used to connect to the storage account for this Function App.
    /// </summary>
    public TerraformValue<string> StorageKeyVaultSecretId
        => CreateReference("storage_key_vault_secret_id");

    /// <summary>
    /// The storage_uses_managed_identity attribute.
    /// </summary>
    public TerraformValue<bool> StorageUsesManagedIdentity
        => CreateReference("storage_uses_managed_identity");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled
        => CreateReference("virtual_network_backup_restore_enabled");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkSubnetId
        => CreateReference("virtual_network_subnet_id");

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled
        => CreateReference("webdeploy_publish_basic_authentication_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWindowsFunctionAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWindowsFunctionAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

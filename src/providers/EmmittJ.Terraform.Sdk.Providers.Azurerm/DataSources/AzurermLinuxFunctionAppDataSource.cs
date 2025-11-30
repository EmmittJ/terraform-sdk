using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLinuxFunctionAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermLinuxFunctionAppDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_linux_function_app Terraform data source.
/// Retrieves information about a azurerm_linux_function_app.
/// </summary>
public partial class AzurermLinuxFunctionAppDataSource(string name) : TerraformDataSource("azurerm_linux_function_app", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auth_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettingsV2
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auth_settings_v2").ResolveNodes(ctx));
    }

    /// <summary>
    /// The availability attribute.
    /// </summary>
    public TerraformValue<string> Availability
    {
        get => new TerraformReference<string>(this, "availability");
    }

    /// <summary>
    /// The backup attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Backup
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backup").ResolveNodes(ctx));
    }

    /// <summary>
    /// The builtin_logging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BuiltinLoggingEnabled
    {
        get => new TerraformReference<bool>(this, "builtin_logging_enabled");
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformValue<string> ClientCertificateExclusionPaths
    {
        get => new TerraformReference<string>(this, "client_certificate_exclusion_paths");
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConnectionString
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "connection_string").ResolveNodes(ctx));
    }

    /// <summary>
    /// The content_share_force_disabled attribute.
    /// </summary>
    public TerraformValue<bool> ContentShareForceDisabled
    {
        get => new TerraformReference<bool>(this, "content_share_force_disabled");
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The daily_memory_time_quota attribute.
    /// </summary>
    public TerraformValue<double> DailyMemoryTimeQuota
    {
        get => new TerraformReference<double>(this, "daily_memory_time_quota");
    }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
    {
        get => new TerraformReference<string>(this, "default_hostname");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "ftp_publish_basic_authentication_enabled");
    }

    /// <summary>
    /// The functions_extension_version attribute.
    /// </summary>
    public TerraformValue<string> FunctionsExtensionVersion
    {
        get => new TerraformReference<string>(this, "functions_extension_version");
    }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
    {
        get => new TerraformReference<string>(this, "hosting_environment_id");
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "outbound_ip_addresses");
    }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "possible_outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "possible_outbound_ip_addresses");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformValue<string> ServicePlanId
    {
        get => new TerraformReference<string>(this, "service_plan_id");
    }

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "site_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "site_credential").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StickySettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sticky_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountAccessKey
    {
        get => new TerraformReference<string>(this, "storage_account_access_key");
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
    }

    /// <summary>
    /// The Key Vault Secret ID, including version, that contains the Connection String used to connect to the storage account for this Function App.
    /// </summary>
    public TerraformValue<string> StorageKeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "storage_key_vault_secret_id");
    }

    /// <summary>
    /// The storage_uses_managed_identity attribute.
    /// </summary>
    public TerraformValue<bool> StorageUsesManagedIdentity
    {
        get => new TerraformReference<bool>(this, "storage_uses_managed_identity");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The usage attribute.
    /// </summary>
    public TerraformValue<string> Usage
    {
        get => new TerraformReference<string>(this, "usage");
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_backup_restore_enabled");
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "webdeploy_publish_basic_authentication_enabled");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLinuxFunctionAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLinuxFunctionAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

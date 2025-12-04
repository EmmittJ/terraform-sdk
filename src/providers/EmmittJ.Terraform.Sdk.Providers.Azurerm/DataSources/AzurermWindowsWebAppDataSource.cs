using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWindowsWebAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermWindowsWebAppDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_windows_web_app Terraform data source.
/// Retrieves information about a azurerm_windows_web_app.
/// </summary>
public partial class AzurermWindowsWebAppDataSource(string name) : TerraformDataSource("azurerm_windows_web_app", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMap<string> AppSettings
        => AsReference("app_settings");

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettings
        => AsReference("auth_settings");

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthSettingsV2
        => AsReference("auth_settings_v2");

    /// <summary>
    /// The backup attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Backup
        => AsReference("backup");

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientAffinityEnabled
        => AsReference("client_affinity_enabled");

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ClientCertificateEnabled
        => AsReference("client_certificate_enabled");

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformValue<string> ClientCertificateExclusionPaths
        => AsReference("client_certificate_exclusion_paths");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> ClientCertificateMode
        => AsReference("client_certificate_mode");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ConnectionString
        => AsReference("connection_string");

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformValue<string> CustomDomainVerificationId
        => AsReference("custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformValue<string> DefaultHostname
        => AsReference("default_hostname");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled
        => AsReference("ftp_publish_basic_authentication_enabled");

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentId
        => AsReference("hosting_environment_id");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => AsReference("https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Logs
        => AsReference("logs");

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> OutboundIpAddressList
        => AsReference("outbound_ip_address_list");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> OutboundIpAddresses
        => AsReference("outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformList<string> PossibleOutboundIpAddressList
        => AsReference("possible_outbound_ip_address_list");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformValue<string> PossibleOutboundIpAddresses
        => AsReference("possible_outbound_ip_addresses");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    public TerraformValue<string> ServicePlanId
        => AsReference("service_plan_id");

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteConfig
        => AsReference("site_config");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SiteCredential
        => AsReference("site_credential");

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StickySettings
        => AsReference("sticky_settings");

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageAccount
        => AsReference("storage_account");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled
        => AsReference("virtual_network_backup_restore_enabled");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkSubnetId
        => AsReference("virtual_network_subnet_id");

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled
        => AsReference("webdeploy_publish_basic_authentication_enabled");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWindowsWebAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWindowsWebAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

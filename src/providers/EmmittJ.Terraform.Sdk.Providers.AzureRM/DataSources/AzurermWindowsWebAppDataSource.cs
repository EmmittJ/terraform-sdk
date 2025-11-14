using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_windows_web_app.
/// </summary>
public class AzurermWindowsWebAppDataSource : TerraformDataSource
{
    public AzurermWindowsWebAppDataSource(string name) : base("azurerm_windows_web_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWindowsWebAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformArgument("app_settings")]
    public TerraformMap<string> AppSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "app_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    [TerraformArgument("auth_settings")]
    public TerraformList<object> AuthSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "auth_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    [TerraformArgument("auth_settings_v2")]
    public TerraformList<object> AuthSettingsV2
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "auth_settings_v2").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backup attribute.
    /// </summary>
    [TerraformArgument("backup")]
    public TerraformList<object> Backup
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "backup").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformArgument("client_affinity_enabled")]
    public TerraformValue<bool> ClientAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "client_affinity_enabled");
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformArgument("client_certificate_enabled")]
    public TerraformValue<bool> ClientCertificateEnabled
    {
        get => new TerraformReference<bool>(this, "client_certificate_enabled");
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformArgument("client_certificate_exclusion_paths")]
    public TerraformValue<string> ClientCertificateExclusionPaths
    {
        get => new TerraformReference<string>(this, "client_certificate_exclusion_paths");
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformArgument("client_certificate_mode")]
    public TerraformValue<string> ClientCertificateMode
    {
        get => new TerraformReference<string>(this, "client_certificate_mode");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformSet<object> ConnectionString
    {
        get => TerraformSet<object>.Lazy(ctx => new TerraformReference<TerraformSet<object>>(this, "connection_string").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformArgument("custom_domain_verification_id")]
    public TerraformValue<string> CustomDomainVerificationId
    {
        get => new TerraformReference<string>(this, "custom_domain_verification_id");
    }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformArgument("default_hostname")]
    public TerraformValue<string> DefaultHostname
    {
        get => new TerraformReference<string>(this, "default_hostname");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("ftp_publish_basic_authentication_enabled")]
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "ftp_publish_basic_authentication_enabled");
    }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformArgument("hosting_environment_id")]
    public TerraformValue<string> HostingEnvironmentId
    {
        get => new TerraformReference<string>(this, "hosting_environment_id");
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformArgument("https_only")]
    public TerraformValue<bool> HttpsOnly
    {
        get => new TerraformReference<bool>(this, "https_only");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The logs attribute.
    /// </summary>
    [TerraformArgument("logs")]
    public TerraformList<object> Logs
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "logs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformArgument("outbound_ip_address_list")]
    public TerraformList<string> OutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("outbound_ip_addresses")]
    public TerraformValue<string> OutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "outbound_ip_addresses");
    }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformArgument("possible_outbound_ip_address_list")]
    public TerraformList<string> PossibleOutboundIpAddressList
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "possible_outbound_ip_address_list").ResolveNodes(ctx));
    }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("possible_outbound_ip_addresses")]
    public TerraformValue<string> PossibleOutboundIpAddresses
    {
        get => new TerraformReference<string>(this, "possible_outbound_ip_addresses");
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool> PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
    }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformArgument("service_plan_id")]
    public TerraformValue<string> ServicePlanId
    {
        get => new TerraformReference<string>(this, "service_plan_id");
    }

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformArgument("site_config")]
    public TerraformList<object> SiteConfig
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "site_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformArgument("site_credential")]
    public TerraformList<object> SiteCredential
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "site_credential").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    [TerraformArgument("sticky_settings")]
    public TerraformList<object> StickySettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sticky_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    [TerraformArgument("storage_account")]
    public TerraformList<object> StorageAccount
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage_account").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformArgument("virtual_network_backup_restore_enabled")]
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_network_backup_restore_enabled");
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_subnet_id")]
    public TerraformValue<string> VirtualNetworkSubnetId
    {
        get => new TerraformReference<string>(this, "virtual_network_subnet_id");
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("webdeploy_publish_basic_authentication_enabled")]
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "webdeploy_publish_basic_authentication_enabled");
    }

}

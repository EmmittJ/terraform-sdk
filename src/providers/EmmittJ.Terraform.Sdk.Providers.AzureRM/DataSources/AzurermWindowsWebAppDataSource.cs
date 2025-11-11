using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermWindowsWebAppDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_windows_web_app.
/// </summary>
public partial class AzurermWindowsWebAppDataSource : TerraformDataSource
{
    public AzurermWindowsWebAppDataSource(string name) : base("azurerm_windows_web_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermWindowsWebAppDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> AppSettings { get; }

    /// <summary>
    /// The auth_settings attribute.
    /// </summary>
    [TerraformProperty("auth_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AuthSettings { get; }

    /// <summary>
    /// The auth_settings_v2 attribute.
    /// </summary>
    [TerraformProperty("auth_settings_v2")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AuthSettingsV2 { get; }

    /// <summary>
    /// The backup attribute.
    /// </summary>
    [TerraformProperty("backup")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Backup { get; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("client_affinity_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ClientAffinityEnabled { get; }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    [TerraformProperty("client_certificate_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ClientCertificateEnabled { get; }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    [TerraformProperty("client_certificate_exclusion_paths")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClientCertificateExclusionPaths { get; }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClientCertificateMode { get; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> ConnectionString { get; }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformProperty("default_hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultHostname { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("ftp_publish_basic_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> FtpPublishBasicAuthenticationEnabled { get; }

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    [TerraformProperty("hosting_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostingEnvironmentId { get; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HttpsOnly { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The logs attribute.
    /// </summary>
    [TerraformProperty("logs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Logs { get; }

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OutboundIpAddressList { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_address_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> PossibleOutboundIpAddressList { get; }

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("possible_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PossibleOutboundIpAddresses { get; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PublicNetworkAccessEnabled { get; }

    /// <summary>
    /// The service_plan_id attribute.
    /// </summary>
    [TerraformProperty("service_plan_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServicePlanId { get; }

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformProperty("site_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SiteConfig { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SiteCredential { get; }

    /// <summary>
    /// The sticky_settings attribute.
    /// </summary>
    [TerraformProperty("sticky_settings")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StickySettings { get; }

    /// <summary>
    /// The storage_account attribute.
    /// </summary>
    [TerraformProperty("storage_account")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StorageAccount { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The virtual_network_backup_restore_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_network_backup_restore_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> VirtualNetworkBackupRestoreEnabled { get; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkSubnetId { get; }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("webdeploy_publish_basic_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> WebdeployPublishBasicAuthenticationEnabled { get; }

}

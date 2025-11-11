using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppStandardDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_logic_app_standard.
/// </summary>
public partial class AzurermLogicAppStandardDataSource : TerraformDataSource
{
    public AzurermLogicAppStandardDataSource(string name) : base("azurerm_logic_app_standard", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLogicAppStandardDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformProperty("app_service_plan_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AppServicePlanId { get; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> AppSettings { get; }

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    [TerraformProperty("bundle_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BundleVersion { get; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("client_affinity_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ClientAffinityEnabled { get; }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientCertificateMode { get; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> ConnectionString { get; }

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
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("ftp_publish_basic_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> FtpPublishBasicAuthenticationEnabled { get; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HttpsOnly { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

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
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicNetworkAccess { get; }

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("scm_publish_basic_authentication_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ScmPublishBasicAuthenticationEnabled { get; }

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    [TerraformProperty("site_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteConfig { get; }

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteCredential { get; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_access_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountAccessKey { get; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountName { get; }

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_share_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageAccountShareName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    [TerraformProperty("use_extension_bundle")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> UseExtensionBundle { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VirtualNetworkSubnetId { get; }

}

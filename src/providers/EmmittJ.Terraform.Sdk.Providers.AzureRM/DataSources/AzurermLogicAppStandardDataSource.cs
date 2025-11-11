using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppStandardDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_logic_app_standard.
/// </summary>
public class AzurermLogicAppStandardDataSource : TerraformDataSource
{
    public AzurermLogicAppStandardDataSource(string name) : base("azurerm_logic_app_standard", name)
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
    public TerraformBlock<AzurermLogicAppStandardDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformPropertyName("app_service_plan_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AppServicePlanId => new TerraformReference(this, "app_service_plan_id");

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AppSettings => new TerraformReference(this, "app_settings");

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    [TerraformPropertyName("bundle_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BundleVersion => new TerraformReference(this, "bundle_version");

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_affinity_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ClientAffinityEnabled => new TerraformReference(this, "client_affinity_enabled");

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
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainVerificationId => new TerraformReference(this, "custom_domain_verification_id");

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
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutboundIpAddresses => new TerraformReference(this, "outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PossibleOutboundIpAddresses => new TerraformReference(this, "possible_outbound_ip_addresses");

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicNetworkAccess => new TerraformReference(this, "public_network_access");

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("scm_publish_basic_authentication_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ScmPublishBasicAuthenticationEnabled => new TerraformReference(this, "scm_publish_basic_authentication_enabled");

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
    /// The storage_account_share_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_share_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageAccountShareName => new TerraformReference(this, "storage_account_share_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    [TerraformPropertyName("use_extension_bundle")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> UseExtensionBundle => new TerraformReference(this, "use_extension_bundle");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkSubnetId => new TerraformReference(this, "virtual_network_subnet_id");

}

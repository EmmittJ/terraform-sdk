using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLogicAppStandardConnectionStringBlock() : TerraformBlock("connection_string")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppStandardIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppStandardSiteConfigBlock() : TerraformBlock("site_config")
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformProperty("always_on")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AlwaysOn { get; set; }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    [TerraformProperty("app_scale_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AppScaleLimit { get; set; }


    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformProperty("dotnet_framework_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DotnetFrameworkVersion { get; set; }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    [TerraformProperty("elastic_instance_minimum")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ElasticInstanceMinimum { get; set; }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformProperty("ftps_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FtpsState { get; set; }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformProperty("health_check_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformProperty("http2_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Http2Enabled { get; set; }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformProperty("linux_fx_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LinuxFxVersion { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinTlsVersion { get; set; }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    [TerraformProperty("pre_warmed_instance_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PreWarmedInstanceCount { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("public_network_access_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("runtime_scale_monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_min_tls_version attribute.
    /// </summary>
    [TerraformProperty("scm_min_tls_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScmMinTlsVersion { get; set; }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformProperty("scm_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScmType { get; set; }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformProperty("scm_use_main_ip_restriction")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    [TerraformProperty("use_32_bit_worker_process")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Use32BitWorkerProcess { get; set; }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    [TerraformProperty("vnet_route_all_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> VnetRouteAllEnabled { get; set; }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformProperty("websockets_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WebsocketsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppStandardTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_standard resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogicAppStandard : TerraformResource
{
    public AzurermLogicAppStandard(string name) : base("azurerm_logic_app_standard", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    [TerraformProperty("app_service_plan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppServicePlanId { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> AppSettings { get; set; }

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    [TerraformProperty("bundle_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BundleVersion { get; set; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("client_affinity_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ClientAffinityEnabled { get; set; }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformProperty("client_certificate_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("ftp_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformProperty("https_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformProperty("public_network_access")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicNetworkAccess { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("scm_publish_basic_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ScmPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformProperty("storage_account_access_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformProperty("storage_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageAccountName { get; set; }

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    [TerraformProperty("storage_account_share_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageAccountShareName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    [TerraformProperty("use_extension_bundle")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseExtensionBundle { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The vnet_content_share_enabled attribute.
    /// </summary>
    [TerraformProperty("vnet_content_share_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VnetContentShareEnabled { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("connection_string")]
    public TerraformSet<AzurermLogicAppStandardConnectionStringBlock> ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermLogicAppStandardIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformProperty("site_config")]
    public TerraformList<AzurermLogicAppStandardSiteConfigBlock> SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLogicAppStandardTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

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
    /// The site_credential attribute.
    /// </summary>
    [TerraformProperty("site_credential")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SiteCredential { get; }

}

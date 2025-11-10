using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppStandardConnectionStringBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppStandardIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppStandardSiteConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    [TerraformPropertyName("always_on")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AlwaysOn { get; set; }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    [TerraformPropertyName("app_scale_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AppScaleLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "app_scale_limit");

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    [TerraformPropertyName("auto_swap_slot_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AutoSwapSlotName => new TerraformReferenceProperty<TerraformProperty<string>>("", "auto_swap_slot_name");

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    [TerraformPropertyName("dotnet_framework_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DotnetFrameworkVersion { get; set; }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    [TerraformPropertyName("elastic_instance_minimum")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ElasticInstanceMinimum { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "elastic_instance_minimum");

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    [TerraformPropertyName("ftps_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> FtpsState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "ftps_state");

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    [TerraformPropertyName("health_check_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HealthCheckPath { get; set; }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    [TerraformPropertyName("http2_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Http2Enabled { get; set; }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    [TerraformPropertyName("linux_fx_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LinuxFxVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "linux_fx_version");

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinTlsVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_tls_version");

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    [TerraformPropertyName("pre_warmed_instance_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PreWarmedInstanceCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "pre_warmed_instance_count");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PublicNetworkAccessEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "public_network_access_enabled");

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("runtime_scale_monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RuntimeScaleMonitoringEnabled { get; set; }

    /// <summary>
    /// The scm_min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("scm_min_tls_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScmMinTlsVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scm_min_tls_version");

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    [TerraformPropertyName("scm_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ScmType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "scm_type");

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    [TerraformPropertyName("scm_use_main_ip_restriction")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ScmUseMainIpRestriction { get; set; }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    [TerraformPropertyName("use_32_bit_worker_process")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Use32BitWorkerProcess { get; set; }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vnet_route_all_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> VnetRouteAllEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "vnet_route_all_enabled");

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    [TerraformPropertyName("websockets_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WebsocketsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppStandardTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_standard resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppStandard : TerraformResource
{
    public AzurermLogicAppStandard(string name) : base("azurerm_logic_app_standard", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    [TerraformPropertyName("app_service_plan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppServicePlanId { get; set; }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformPropertyName("app_settings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AppSettings { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "app_settings");

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    [TerraformPropertyName("bundle_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BundleVersion { get; set; }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("client_affinity_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ClientAffinityEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "client_affinity_enabled");

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    [TerraformPropertyName("client_certificate_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientCertificateMode { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ftp_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FtpPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    [TerraformPropertyName("https_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HttpsOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicNetworkAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_network_access");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("scm_publish_basic_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ScmPublishBasicAuthenticationEnabled { get; set; }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    [TerraformPropertyName("storage_account_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountAccessKey { get; set; }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    [TerraformPropertyName("storage_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountName { get; set; }

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_share_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageAccountShareName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_account_share_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    [TerraformPropertyName("use_extension_bundle")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseExtensionBundle { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkSubnetId { get; set; }

    /// <summary>
    /// The vnet_content_share_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vnet_content_share_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VnetContentShareEnabled { get; set; }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("connection_string")]
    public TerraformSet<TerraformBlock<AzurermLogicAppStandardConnectionStringBlock>>? ConnectionString { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLogicAppStandardIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    [TerraformPropertyName("site_config")]
    public TerraformList<TerraformBlock<AzurermLogicAppStandardSiteConfigBlock>>? SiteConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogicAppStandardTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    [TerraformPropertyName("default_hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultHostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_hostname");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutboundIpAddresses => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "outbound_ip_addresses");

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("possible_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PossibleOutboundIpAddresses => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "possible_outbound_ip_addresses");

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    [TerraformPropertyName("site_credential")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SiteCredential => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "site_credential");

}

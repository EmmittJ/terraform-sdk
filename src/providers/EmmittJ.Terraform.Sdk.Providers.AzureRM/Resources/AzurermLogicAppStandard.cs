using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for connection_string in .
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppStandardConnectionStringBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppStandardIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for site_config in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppStandardSiteConfigBlock : TerraformBlock
{
    /// <summary>
    /// The always_on attribute.
    /// </summary>
    public TerraformProperty<bool>? AlwaysOn
    {
        get => GetProperty<TerraformProperty<bool>>("always_on");
        set => WithProperty("always_on", value);
    }

    /// <summary>
    /// The app_scale_limit attribute.
    /// </summary>
    public TerraformProperty<double>? AppScaleLimit
    {
        get => GetProperty<TerraformProperty<double>>("app_scale_limit");
        set => WithProperty("app_scale_limit", value);
    }

    /// <summary>
    /// The auto_swap_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutoSwapSlotName
    {
        get => GetProperty<TerraformProperty<string>>("auto_swap_slot_name");
        set => WithProperty("auto_swap_slot_name", value);
    }

    /// <summary>
    /// The dotnet_framework_version attribute.
    /// </summary>
    public TerraformProperty<string>? DotnetFrameworkVersion
    {
        get => GetProperty<TerraformProperty<string>>("dotnet_framework_version");
        set => WithProperty("dotnet_framework_version", value);
    }

    /// <summary>
    /// The elastic_instance_minimum attribute.
    /// </summary>
    public TerraformProperty<double>? ElasticInstanceMinimum
    {
        get => GetProperty<TerraformProperty<double>>("elastic_instance_minimum");
        set => WithProperty("elastic_instance_minimum", value);
    }

    /// <summary>
    /// The ftps_state attribute.
    /// </summary>
    public TerraformProperty<string>? FtpsState
    {
        get => GetProperty<TerraformProperty<string>>("ftps_state");
        set => WithProperty("ftps_state", value);
    }

    /// <summary>
    /// The health_check_path attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckPath
    {
        get => GetProperty<TerraformProperty<string>>("health_check_path");
        set => WithProperty("health_check_path", value);
    }

    /// <summary>
    /// The http2_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Http2Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("http2_enabled");
        set => WithProperty("http2_enabled", value);
    }

    /// <summary>
    /// The linux_fx_version attribute.
    /// </summary>
    public TerraformProperty<string>? LinuxFxVersion
    {
        get => GetProperty<TerraformProperty<string>>("linux_fx_version");
        set => WithProperty("linux_fx_version", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// The pre_warmed_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? PreWarmedInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("pre_warmed_instance_count");
        set => WithProperty("pre_warmed_instance_count", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The runtime_scale_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RuntimeScaleMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("runtime_scale_monitoring_enabled");
        set => WithProperty("runtime_scale_monitoring_enabled", value);
    }

    /// <summary>
    /// The scm_min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? ScmMinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("scm_min_tls_version");
        set => WithProperty("scm_min_tls_version", value);
    }

    /// <summary>
    /// The scm_type attribute.
    /// </summary>
    public TerraformProperty<string>? ScmType
    {
        get => GetProperty<TerraformProperty<string>>("scm_type");
        set => WithProperty("scm_type", value);
    }

    /// <summary>
    /// The scm_use_main_ip_restriction attribute.
    /// </summary>
    public TerraformProperty<bool>? ScmUseMainIpRestriction
    {
        get => GetProperty<TerraformProperty<bool>>("scm_use_main_ip_restriction");
        set => WithProperty("scm_use_main_ip_restriction", value);
    }

    /// <summary>
    /// The use_32_bit_worker_process attribute.
    /// </summary>
    public TerraformProperty<bool>? Use32BitWorkerProcess
    {
        get => GetProperty<TerraformProperty<bool>>("use_32_bit_worker_process");
        set => WithProperty("use_32_bit_worker_process", value);
    }

    /// <summary>
    /// The vnet_route_all_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VnetRouteAllEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_route_all_enabled");
        set => WithProperty("vnet_route_all_enabled", value);
    }

    /// <summary>
    /// The websockets_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebsocketsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("websockets_enabled");
        set => WithProperty("websockets_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppStandardTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_logic_app_standard resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppStandard : TerraformResource
{
    public AzurermLogicAppStandard(string name) : base("azurerm_logic_app_standard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("custom_domain_verification_id");
        this.WithOutput("default_hostname");
        this.WithOutput("kind");
        this.WithOutput("outbound_ip_addresses");
        this.WithOutput("possible_outbound_ip_addresses");
        this.WithOutput("site_credential");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServicePlanId is required")]
    public required TerraformProperty<string> AppServicePlanId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_service_plan_id");
        set => this.WithProperty("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AppSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    public TerraformProperty<string>? BundleVersion
    {
        get => GetProperty<TerraformProperty<string>>("bundle_version");
        set => this.WithProperty("bundle_version", value);
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientAffinityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_affinity_enabled");
        set => this.WithProperty("client_affinity_enabled", value);
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => this.WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FtpPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ftp_publish_basic_authentication_enabled");
        set => this.WithProperty("ftp_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ScmPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("scm_publish_basic_authentication_enabled");
        set => this.WithProperty("scm_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountAccessKey is required")]
    public required TerraformProperty<string> StorageAccountAccessKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformProperty<string> StorageAccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_name");
        set => this.WithProperty("storage_account_name", value);
    }

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountShareName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_share_name");
        set => this.WithProperty("storage_account_share_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    public TerraformProperty<bool>? UseExtensionBundle
    {
        get => GetProperty<TerraformProperty<bool>>("use_extension_bundle");
        set => this.WithProperty("use_extension_bundle", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_subnet_id");
        set => this.WithProperty("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// The vnet_content_share_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VnetContentShareEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vnet_content_share_enabled");
        set => this.WithProperty("vnet_content_share_enabled", value);
    }

    /// <summary>
    /// Block for connection_string.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLogicAppStandardConnectionStringBlock>? ConnectionString
    {
        get => GetProperty<HashSet<AzurermLogicAppStandardConnectionStringBlock>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLogicAppStandardIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermLogicAppStandardIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for site_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteConfig block(s) allowed")]
    public List<AzurermLogicAppStandardSiteConfigBlock>? SiteConfig
    {
        get => GetProperty<List<AzurermLogicAppStandardSiteConfigBlock>>("site_config");
        set => this.WithProperty("site_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppStandardTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppStandardTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}

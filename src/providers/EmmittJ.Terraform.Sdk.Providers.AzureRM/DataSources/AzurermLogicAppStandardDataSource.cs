using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppStandardDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_logic_app_standard.
/// </summary>
public class AzurermLogicAppStandardDataSource : TerraformDataSource
{
    public AzurermLogicAppStandardDataSource(string name) : base("azurerm_logic_app_standard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("app_service_plan_id");
        this.WithOutput("app_settings");
        this.WithOutput("bundle_version");
        this.WithOutput("client_affinity_enabled");
        this.WithOutput("client_certificate_mode");
        this.WithOutput("connection_string");
        this.WithOutput("custom_domain_verification_id");
        this.WithOutput("default_hostname");
        this.WithOutput("enabled");
        this.WithOutput("ftp_publish_basic_authentication_enabled");
        this.WithOutput("https_only");
        this.WithOutput("identity");
        this.WithOutput("kind");
        this.WithOutput("location");
        this.WithOutput("outbound_ip_addresses");
        this.WithOutput("possible_outbound_ip_addresses");
        this.WithOutput("public_network_access");
        this.WithOutput("scm_publish_basic_authentication_enabled");
        this.WithOutput("site_config");
        this.WithOutput("site_credential");
        this.WithOutput("storage_account_access_key");
        this.WithOutput("storage_account_name");
        this.WithOutput("storage_account_share_name");
        this.WithOutput("tags");
        this.WithOutput("use_extension_bundle");
        this.WithOutput("version");
        this.WithOutput("virtual_network_subnet_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppStandardDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppStandardDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformExpression AppServicePlanId => this["app_service_plan_id"];

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformExpression AppSettings => this["app_settings"];

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    public TerraformExpression BundleVersion => this["bundle_version"];

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public TerraformExpression ClientAffinityEnabled => this["client_affinity_enabled"];

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public TerraformExpression ClientCertificateMode => this["client_certificate_mode"];

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformExpression ConnectionString => this["connection_string"];

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression FtpPublishBasicAuthenticationEnabled => this["ftp_publish_basic_authentication_enabled"];

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformExpression HttpsOnly => this["https_only"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccess => this["public_network_access"];

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformExpression ScmPublishBasicAuthenticationEnabled => this["scm_publish_basic_authentication_enabled"];

    /// <summary>
    /// The site_config attribute.
    /// </summary>
    public TerraformExpression SiteConfig => this["site_config"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public TerraformExpression StorageAccountAccessKey => this["storage_account_access_key"];

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformExpression StorageAccountName => this["storage_account_name"];

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    public TerraformExpression StorageAccountShareName => this["storage_account_share_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    public TerraformExpression UseExtensionBundle => this["use_extension_bundle"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkSubnetId => this["virtual_network_subnet_id"];

}

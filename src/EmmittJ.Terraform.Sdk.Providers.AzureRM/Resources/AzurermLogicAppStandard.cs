using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_standard resource.
/// </summary>
public class AzurermLogicAppStandard : TerraformResource
{
    public AzurermLogicAppStandard(string name) : base("azurerm_logic_app_standard", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("kind");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? AppServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_plan_id");
        set => this.WithProperty("app_service_plan_id", value);
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public TerraformMapProperty<string>? AppSettings
    {
        get => GetProperty<TerraformMapProperty<string>>("app_settings");
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
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
    public TerraformProperty<string>? StorageAccountAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_access_key");
        set => this.WithProperty("storage_account_access_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_name");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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

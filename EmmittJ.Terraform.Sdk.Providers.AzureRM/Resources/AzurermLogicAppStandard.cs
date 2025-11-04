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
    public string? AppServicePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_plan_id")?.Value;
        set => this.WithProperty("app_service_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The bundle_version attribute.
    /// </summary>
    public string? BundleVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_version")?.Value;
        set => this.WithProperty("bundle_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_affinity_enabled attribute.
    /// </summary>
    public bool? ClientAffinityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_affinity_enabled")?.Value;
        set => this.WithProperty("client_affinity_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The client_certificate_mode attribute.
    /// </summary>
    public string? ClientCertificateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_mode")?.Value;
        set => this.WithProperty("client_certificate_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ftp_publish_basic_authentication_enabled attribute.
    /// </summary>
    public bool? FtpPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ftp_publish_basic_authentication_enabled")?.Value;
        set => this.WithProperty("ftp_publish_basic_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public string? PublicNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_network_access")?.Value;
        set => this.WithProperty("public_network_access", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scm_publish_basic_authentication_enabled attribute.
    /// </summary>
    public bool? ScmPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("scm_publish_basic_authentication_enabled")?.Value;
        set => this.WithProperty("scm_publish_basic_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_account_access_key attribute.
    /// </summary>
    public string? StorageAccountAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_access_key")?.Value;
        set => this.WithProperty("storage_account_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public string? StorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_name")?.Value;
        set => this.WithProperty("storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_share_name attribute.
    /// </summary>
    public string? StorageAccountShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_share_name")?.Value;
        set => this.WithProperty("storage_account_share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The use_extension_bundle attribute.
    /// </summary>
    public bool? UseExtensionBundle
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_extension_bundle")?.Value;
        set => this.WithProperty("use_extension_bundle", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public string? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_subnet_id")?.Value;
        set => this.WithProperty("virtual_network_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vnet_content_share_enabled attribute.
    /// </summary>
    public bool? VnetContentShareEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("vnet_content_share_enabled")?.Value;
        set => this.WithProperty("vnet_content_share_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

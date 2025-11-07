using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management resource.
/// </summary>
public class AzurermApiManagement : TerraformResource
{
    public AzurermApiManagement(string name) : base("azurerm_api_management", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("developer_portal_url");
        this.DeclareOutput("gateway_regional_url");
        this.DeclareOutput("gateway_url");
        this.DeclareOutput("management_api_url");
        this.DeclareOutput("portal_url");
        this.DeclareOutput("private_ip_addresses");
        this.DeclareOutput("public_ip_addresses");
        this.DeclareOutput("scm_url");
    }

    /// <summary>
    /// The client_certificate_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClientCertificateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_certificate_enabled");
        set => this.WithProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GatewayDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("gateway_disabled");
        set => this.WithProperty("gateway_disabled", value);
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
    /// The min_api_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_api_version");
        set => this.WithProperty("min_api_version", value);
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
    /// The notification_sender_email attribute.
    /// </summary>
    public TerraformProperty<string>? NotificationSenderEmail
    {
        get => GetProperty<TerraformProperty<string>>("notification_sender_email");
        set => this.WithProperty("notification_sender_email", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => this.WithProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    public TerraformProperty<string>? PublisherEmail
    {
        get => GetProperty<TerraformProperty<string>>("publisher_email");
        set => this.WithProperty("publisher_email", value);
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    public TerraformProperty<string>? PublisherName
    {
        get => GetProperty<TerraformProperty<string>>("publisher_name");
        set => this.WithProperty("publisher_name", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_type attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkType
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_type");
        set => this.WithProperty("virtual_network_type", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The developer_portal_url attribute.
    /// </summary>
    public TerraformExpression DeveloperPortalUrl => this["developer_portal_url"];

    /// <summary>
    /// The gateway_regional_url attribute.
    /// </summary>
    public TerraformExpression GatewayRegionalUrl => this["gateway_regional_url"];

    /// <summary>
    /// The gateway_url attribute.
    /// </summary>
    public TerraformExpression GatewayUrl => this["gateway_url"];

    /// <summary>
    /// The management_api_url attribute.
    /// </summary>
    public TerraformExpression ManagementApiUrl => this["management_api_url"];

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformExpression PortalUrl => this["portal_url"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PublicIpAddresses => this["public_ip_addresses"];

    /// <summary>
    /// The scm_url attribute.
    /// </summary>
    public TerraformExpression ScmUrl => this["scm_url"];

}

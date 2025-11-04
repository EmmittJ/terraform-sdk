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
    public bool? ClientCertificateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_certificate_enabled")?.Value;
        set => this.WithProperty("client_certificate_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The gateway_disabled attribute.
    /// </summary>
    public bool? GatewayDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("gateway_disabled")?.Value;
        set => this.WithProperty("gateway_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The min_api_version attribute.
    /// </summary>
    public string? MinApiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("min_api_version")?.Value;
        set => this.WithProperty("min_api_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The notification_sender_email attribute.
    /// </summary>
    public string? NotificationSenderEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_sender_email")?.Value;
        set => this.WithProperty("notification_sender_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public string? PublicIpAddressId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_address_id")?.Value;
        set => this.WithProperty("public_ip_address_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The publisher_email attribute.
    /// </summary>
    public string? PublisherEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher_email")?.Value;
        set => this.WithProperty("publisher_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publisher_name attribute.
    /// </summary>
    public string? PublisherName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher_name")?.Value;
        set => this.WithProperty("publisher_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The virtual_network_type attribute.
    /// </summary>
    public string? VirtualNetworkType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_type")?.Value;
        set => this.WithProperty("virtual_network_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<string>? Zones
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("zones")?.Value;
        set => this.WithProperty("zones", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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

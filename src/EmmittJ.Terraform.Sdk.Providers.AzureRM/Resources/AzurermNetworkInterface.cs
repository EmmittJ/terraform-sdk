using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_interface resource.
/// </summary>
public class AzurermNetworkInterface : TerraformResource
{
    public AzurermNetworkInterface(string name) : base("azurerm_network_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("applied_dns_servers");
        this.DeclareOutput("internal_domain_name_suffix");
        this.DeclareOutput("mac_address");
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("private_ip_addresses");
        this.DeclareOutput("virtual_machine_id");
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public bool? AcceleratedNetworkingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("accelerated_networking_enabled")?.Value;
        set => this.WithProperty("accelerated_networking_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public string? AuxiliaryMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auxiliary_mode")?.Value;
        set => this.WithProperty("auxiliary_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public string? AuxiliarySku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auxiliary_sku")?.Value;
        set => this.WithProperty("auxiliary_sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<string>? DnsServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_servers")?.Value;
        set => this.WithProperty("dns_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The internal_dns_name_label attribute.
    /// </summary>
    public string? InternalDnsNameLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internal_dns_name_label")?.Value;
        set => this.WithProperty("internal_dns_name_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public bool? IpForwardingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ip_forwarding_enabled")?.Value;
        set => this.WithProperty("ip_forwarding_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The applied_dns_servers attribute.
    /// </summary>
    public TerraformExpression AppliedDnsServers => this["applied_dns_servers"];

    /// <summary>
    /// The internal_domain_name_suffix attribute.
    /// </summary>
    public TerraformExpression InternalDomainNameSuffix => this["internal_domain_name_suffix"];

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformExpression MacAddress => this["mac_address"];

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformExpression VirtualMachineId => this["virtual_machine_id"];

}

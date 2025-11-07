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
    public TerraformProperty<bool>? AcceleratedNetworkingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("accelerated_networking_enabled");
        set => this.WithProperty("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliaryMode
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_mode");
        set => this.WithProperty("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliarySku
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_sku");
        set => this.WithProperty("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DnsServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("dns_servers");
        set => this.WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
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
    /// The internal_dns_name_label attribute.
    /// </summary>
    public TerraformProperty<string>? InternalDnsNameLabel
    {
        get => GetProperty<TerraformProperty<string>>("internal_dns_name_label");
        set => this.WithProperty("internal_dns_name_label", value);
    }

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IpForwardingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ip_forwarding_enabled");
        set => this.WithProperty("ip_forwarding_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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

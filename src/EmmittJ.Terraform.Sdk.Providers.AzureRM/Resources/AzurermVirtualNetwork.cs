using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_network resource.
/// </summary>
public class AzurermVirtualNetwork : TerraformResource
{
    public AzurermVirtualNetwork(string name) : base("azurerm_virtual_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("guid");
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AddressSpace
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("address_space");
        set => this.WithProperty("address_space", value);
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public TerraformProperty<string>? BgpCommunity
    {
        get => GetProperty<TerraformProperty<string>>("bgp_community");
        set => this.WithProperty("bgp_community", value);
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
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? FlowTimeoutInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("flow_timeout_in_minutes");
        set => this.WithProperty("flow_timeout_in_minutes", value);
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateEndpointVnetPolicies
    {
        get => GetProperty<TerraformProperty<string>>("private_endpoint_vnet_policies");
        set => this.WithProperty("private_endpoint_vnet_policies", value);
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
    /// The subnet attribute.
    /// </summary>
    public TerraformProperty<HashSet<object>>? Subnet
    {
        get => GetProperty<TerraformProperty<HashSet<object>>>("subnet");
        set => this.WithProperty("subnet", value);
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
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

}

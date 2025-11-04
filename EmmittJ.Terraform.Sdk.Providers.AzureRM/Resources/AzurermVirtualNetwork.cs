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
    public HashSet<string>? AddressSpace
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("address_space")?.Value;
        set => this.WithProperty("address_space", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The bgp_community attribute.
    /// </summary>
    public string? BgpCommunity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bgp_community")?.Value;
        set => this.WithProperty("bgp_community", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The flow_timeout_in_minutes attribute.
    /// </summary>
    public double? FlowTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("flow_timeout_in_minutes")?.Value;
        set => this.WithProperty("flow_timeout_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The private_endpoint_vnet_policies attribute.
    /// </summary>
    public string? PrivateEndpointVnetPolicies
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_endpoint_vnet_policies")?.Value;
        set => this.WithProperty("private_endpoint_vnet_policies", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The subnet attribute.
    /// </summary>
    public HashSet<object>? Subnet
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("subnet")?.Value;
        set => this.WithProperty("subnet", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
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
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

}

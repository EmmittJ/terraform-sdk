using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_circuit_connection resource.
/// </summary>
public class AzurermExpressRouteCircuitConnection : TerraformResource
{
    public AzurermExpressRouteCircuitConnection(string name) : base("azurerm_express_route_circuit_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefix_ipv4 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddressPrefixIpv4
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_prefix_ipv4");
        set => this.WithProperty("address_prefix_ipv4", value);
    }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddressPrefixIpv6
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_prefix_ipv6");
        set => this.WithProperty("address_prefix_ipv6", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_peering_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerPeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_peering_id");
        set => this.WithProperty("peer_peering_id", value);
    }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_id");
        set => this.WithProperty("peering_id", value);
    }

}

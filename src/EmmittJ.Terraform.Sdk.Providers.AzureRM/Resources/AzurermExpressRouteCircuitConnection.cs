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
    public string? AddressPrefixIpv4
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_prefix_ipv4")?.Value;
        set => this.WithProperty("address_prefix_ipv4", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    public string? AddressPrefixIpv6
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_prefix_ipv6")?.Value;
        set => this.WithProperty("address_prefix_ipv6", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public string? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key")?.Value;
        set => this.WithProperty("authorization_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The peer_peering_id attribute.
    /// </summary>
    public string? PeerPeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_peering_id")?.Value;
        set => this.WithProperty("peer_peering_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    public string? PeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_id")?.Value;
        set => this.WithProperty("peering_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

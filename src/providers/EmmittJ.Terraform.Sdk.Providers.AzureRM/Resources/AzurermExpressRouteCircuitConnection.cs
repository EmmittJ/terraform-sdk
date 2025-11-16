using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_express_route_circuit_connection Terraform resource.
/// Manages a azurerm_express_route_circuit_connection resource.
/// </summary>
public partial class AzurermExpressRouteCircuitConnection(string name) : TerraformResource("azurerm_express_route_circuit_connection", name)
{
    /// <summary>
    /// The address_prefix_ipv4 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixIpv4 is required")]
    public required TerraformValue<string> AddressPrefixIpv4
    {
        get => new TerraformReference<string>(this, "address_prefix_ipv4");
        set => SetArgument("address_prefix_ipv4", value);
    }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? AddressPrefixIpv6
    {
        get => new TerraformReference<string>(this, "address_prefix_ipv6");
        set => SetArgument("address_prefix_ipv6", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The peer_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerPeeringId is required")]
    public required TerraformValue<string> PeerPeeringId
    {
        get => new TerraformReference<string>(this, "peer_peering_id");
        set => SetArgument("peer_peering_id", value);
    }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringId is required")]
    public required TerraformValue<string> PeeringId
    {
        get => new TerraformReference<string>(this, "peering_id");
        set => SetArgument("peering_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

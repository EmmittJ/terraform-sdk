using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLbBackendAddressPool.
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for tunnel_interface in AzurermLbBackendAddressPool.
/// Nesting mode: list
/// </summary>
public class AzurermLbBackendAddressPoolTunnelInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tunnel_interface";

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<double> Identifier
    {
        get => GetRequiredArgument<TerraformValue<double>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a azurerm_lb_backend_address_pool Terraform resource.
/// Manages a azurerm_lb_backend_address_pool resource.
/// </summary>
public partial class AzurermLbBackendAddressPool(string name) : TerraformResource("azurerm_lb_backend_address_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformValue<string> LoadbalancerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("loadbalancer_id");
        set => SetArgument("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The synchronous_mode attribute.
    /// </summary>
    public TerraformValue<string>? SynchronousMode
    {
        get => GetArgument<TerraformValue<string>>("synchronous_mode");
        set => SetArgument("synchronous_mode", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    public TerraformList<string> BackendIpConfigurations
        => AsReference("backend_ip_configurations");

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    public TerraformList<string> InboundNatRules
        => AsReference("inbound_nat_rules");

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    public TerraformList<string> LoadBalancingRules
        => AsReference("load_balancing_rules");

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    public TerraformList<string> OutboundRules
        => AsReference("outbound_rules");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLbBackendAddressPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLbBackendAddressPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TunnelInterface block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermLbBackendAddressPoolTunnelInterfaceBlock>? TunnelInterface
    {
        get => GetArgument<TerraformList<AzurermLbBackendAddressPoolTunnelInterfaceBlock>>("tunnel_interface");
        set => SetArgument("tunnel_interface", value);
    }

}

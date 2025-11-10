using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for tunnel_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermLbBackendAddressPoolTunnelInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformProperty<double> Identifier
    {
        set => SetProperty("identifier", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Manages a azurerm_lb_backend_address_pool resource.
/// </summary>
public class AzurermLbBackendAddressPool : TerraformResource
{
    public AzurermLbBackendAddressPool(string name) : base("azurerm_lb_backend_address_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backend_ip_configurations");
        SetOutput("inbound_nat_rules");
        SetOutput("load_balancing_rules");
        SetOutput("outbound_rules");
        SetOutput("id");
        SetOutput("loadbalancer_id");
        SetOutput("name");
        SetOutput("synchronous_mode");
        SetOutput("virtual_network_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    public required TerraformProperty<string> LoadbalancerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("loadbalancer_id");
        set => SetProperty("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The synchronous_mode attribute.
    /// </summary>
    public TerraformProperty<string> SynchronousMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("synchronous_mode");
        set => SetProperty("synchronous_mode", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbBackendAddressPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for tunnel_interface.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLbBackendAddressPoolTunnelInterfaceBlock>? TunnelInterface
    {
        set => SetProperty("tunnel_interface", value);
    }

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    public TerraformExpression BackendIpConfigurations => this["backend_ip_configurations"];

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    public TerraformExpression InboundNatRules => this["inbound_nat_rules"];

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    public TerraformExpression LoadBalancingRules => this["load_balancing_rules"];

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    public TerraformExpression OutboundRules => this["outbound_rules"];

}

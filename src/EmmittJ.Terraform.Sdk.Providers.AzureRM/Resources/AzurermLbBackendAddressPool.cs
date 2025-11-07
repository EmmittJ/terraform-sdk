using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("backend_ip_configurations");
        this.DeclareOutput("inbound_nat_rules");
        this.DeclareOutput("load_balancing_rules");
        this.DeclareOutput("outbound_rules");
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
    /// The loadbalancer_id attribute.
    /// </summary>
    public TerraformProperty<string>? LoadbalancerId
    {
        get => GetProperty<TerraformProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
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
    /// The synchronous_mode attribute.
    /// </summary>
    public TerraformProperty<string>? SynchronousMode
    {
        get => GetProperty<TerraformProperty<string>>("synchronous_mode");
        set => this.WithProperty("synchronous_mode", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
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

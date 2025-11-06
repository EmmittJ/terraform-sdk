using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_lb_backend_address_pool.
/// </summary>
public class AzurermLbBackendAddressPoolDataSource : TerraformDataSource
{
    public AzurermLbBackendAddressPoolDataSource(string name) : base("azurerm_lb_backend_address_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backend_address");
        this.DeclareOutput("backend_ip_configurations");
        this.DeclareOutput("inbound_nat_rules");
        this.DeclareOutput("load_balancing_rules");
        this.DeclareOutput("outbound_rules");
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
    /// The loadbalancer_id attribute.
    /// </summary>
    public string? LoadbalancerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("loadbalancer_id")?.Value;
        set => this.WithProperty("loadbalancer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The backend_address attribute.
    /// </summary>
    public TerraformExpression BackendAddress => this["backend_address"];

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

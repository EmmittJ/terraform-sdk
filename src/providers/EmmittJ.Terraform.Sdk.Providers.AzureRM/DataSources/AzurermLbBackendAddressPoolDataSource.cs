using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("backend_address");
        SetOutput("backend_ip_configurations");
        SetOutput("inbound_nat_rules");
        SetOutput("load_balancing_rules");
        SetOutput("outbound_rules");
        SetOutput("id");
        SetOutput("loadbalancer_id");
        SetOutput("name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbBackendAddressPoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

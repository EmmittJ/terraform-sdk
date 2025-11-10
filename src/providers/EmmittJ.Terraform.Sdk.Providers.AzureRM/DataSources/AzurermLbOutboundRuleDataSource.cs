using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbOutboundRuleDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_lb_outbound_rule.
/// </summary>
public class AzurermLbOutboundRuleDataSource : TerraformDataSource
{
    public AzurermLbOutboundRuleDataSource(string name) : base("azurerm_lb_outbound_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocated_outbound_ports");
        SetOutput("backend_address_pool_id");
        SetOutput("enable_tcp_reset");
        SetOutput("frontend_ip_configuration");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("protocol");
        SetOutput("tcp_reset_enabled");
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
    public AzurermLbOutboundRuleDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    public TerraformExpression AllocatedOutboundPorts => this["allocated_outbound_ports"];

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public TerraformExpression BackendAddressPoolId => this["backend_address_pool_id"];

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    public TerraformExpression EnableTcpReset => this["enable_tcp_reset"];

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfiguration => this["frontend_ip_configuration"];

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression IdleTimeoutInMinutes => this["idle_timeout_in_minutes"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformExpression TcpResetEnabled => this["tcp_reset_enabled"];

}

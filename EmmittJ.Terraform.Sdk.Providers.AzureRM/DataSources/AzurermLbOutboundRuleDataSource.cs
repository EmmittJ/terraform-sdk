using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("allocated_outbound_ports");
        this.DeclareOutput("backend_address_pool_id");
        this.DeclareOutput("enable_tcp_reset");
        this.DeclareOutput("frontend_ip_configuration");
        this.DeclareOutput("idle_timeout_in_minutes");
        this.DeclareOutput("protocol");
        this.DeclareOutput("tcp_reset_enabled");
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

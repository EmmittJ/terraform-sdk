using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lb_outbound_rule resource.
/// </summary>
public class AzurermLbOutboundRule : TerraformResource
{
    public AzurermLbOutboundRule(string name) : base("azurerm_lb_outbound_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    public double? AllocatedOutboundPorts
    {
        get => GetProperty<TerraformLiteralProperty<double>>("allocated_outbound_ports")?.Value;
        set => this.WithProperty("allocated_outbound_ports", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public string? BackendAddressPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend_address_pool_id")?.Value;
        set => this.WithProperty("backend_address_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableTcpReset
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_tcp_reset")?.Value;
        set => this.WithProperty("enable_tcp_reset", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public double? IdleTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout_in_minutes")?.Value;
        set => this.WithProperty("idle_timeout_in_minutes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public bool? TcpResetEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tcp_reset_enabled")?.Value;
        set => this.WithProperty("tcp_reset_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}

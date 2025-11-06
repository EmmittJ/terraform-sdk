using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lb_nat_rule resource.
/// </summary>
public class AzurermLbNatRule : TerraformResource
{
    public AzurermLbNatRule(string name) : base("azurerm_lb_nat_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backend_ip_configuration_id");
        this.DeclareOutput("frontend_ip_configuration_id");
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
    /// The backend_port attribute.
    /// </summary>
    public double? BackendPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backend_port")?.Value;
        set => this.WithProperty("backend_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableFloatingIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_floating_ip")?.Value;
        set => this.WithProperty("enable_floating_ip", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The floating_ip_enabled attribute.
    /// </summary>
    public bool? FloatingIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("floating_ip_enabled")?.Value;
        set => this.WithProperty("floating_ip_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    public string? FrontendIpConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frontend_ip_configuration_name")?.Value;
        set => this.WithProperty("frontend_ip_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    public double? FrontendPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port")?.Value;
        set => this.WithProperty("frontend_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    public double? FrontendPortEnd
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port_end")?.Value;
        set => this.WithProperty("frontend_port_end", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    public double? FrontendPortStart
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port_start")?.Value;
        set => this.WithProperty("frontend_port_start", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public bool? TcpResetEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tcp_reset_enabled")?.Value;
        set => this.WithProperty("tcp_reset_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression BackendIpConfigurationId => this["backend_ip_configuration_id"];

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationId => this["frontend_ip_configuration_id"];

}

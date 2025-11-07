using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lb_nat_pool resource.
/// </summary>
public class AzurermLbNatPool : TerraformResource
{
    public AzurermLbNatPool(string name) : base("azurerm_lb_nat_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frontend_ip_configuration_id");
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BackendPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("backend_port");
        set => this.WithProperty("backend_port", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FloatingIpEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("floating_ip_enabled");
        set => this.WithProperty("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FrontendIpConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frontend_ip_configuration_name");
        set => this.WithProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FrontendPortEnd
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port_end");
        set => this.WithProperty("frontend_port_end", value);
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FrontendPortStart
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port_start");
        set => this.WithProperty("frontend_port_start", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdleTimeoutInMinutes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout_in_minutes");
        set => this.WithProperty("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadbalancerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? TcpResetEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("tcp_reset_enabled");
        set => this.WithProperty("tcp_reset_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationId => this["frontend_ip_configuration_id"];

}

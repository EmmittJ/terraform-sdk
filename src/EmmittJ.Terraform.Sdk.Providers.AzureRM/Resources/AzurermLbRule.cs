using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_lb_rule resource.
/// </summary>
public class AzurermLbRule : TerraformResource
{
    public AzurermLbRule(string name) : base("azurerm_lb_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("frontend_ip_configuration_id");
    }

    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? BackendAddressPoolIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("backend_address_pool_ids");
        set => this.WithProperty("backend_address_pool_ids", value);
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
    /// The disable_outbound_snat attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableOutboundSnat
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_outbound_snat");
        set => this.WithProperty("disable_outbound_snat", value);
    }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<bool>? EnableFloatingIp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_floating_ip");
        set => this.WithProperty("enable_floating_ip", value);
    }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<bool>? EnableTcpReset
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_tcp_reset");
        set => this.WithProperty("enable_tcp_reset", value);
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
    /// The frontend_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FrontendPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("frontend_port");
        set => this.WithProperty("frontend_port", value);
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
    /// The load_distribution attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadDistribution
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_distribution");
        set => this.WithProperty("load_distribution", value);
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
    /// The probe_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProbeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("probe_id");
        set => this.WithProperty("probe_id", value);
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

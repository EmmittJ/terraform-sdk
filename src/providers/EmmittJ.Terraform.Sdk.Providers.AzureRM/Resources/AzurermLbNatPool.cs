using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbNatPoolTimeoutsBlock : TerraformBlock
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
        SetOutput("frontend_ip_configuration_id");
        SetOutput("backend_port");
        SetOutput("floating_ip_enabled");
        SetOutput("frontend_ip_configuration_name");
        SetOutput("frontend_port_end");
        SetOutput("frontend_port_start");
        SetOutput("id");
        SetOutput("idle_timeout_in_minutes");
        SetOutput("loadbalancer_id");
        SetOutput("name");
        SetOutput("protocol");
        SetOutput("resource_group_name");
        SetOutput("tcp_reset_enabled");
    }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformProperty<double> BackendPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("backend_port");
        set => SetProperty("backend_port", value);
    }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> FloatingIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("floating_ip_enabled");
        set => SetProperty("floating_ip_enabled", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    public required TerraformProperty<string> FrontendIpConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frontend_ip_configuration_name");
        set => SetProperty("frontend_ip_configuration_name", value);
    }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortEnd is required")]
    public required TerraformProperty<double> FrontendPortEnd
    {
        get => GetRequiredOutput<TerraformProperty<double>>("frontend_port_end");
        set => SetProperty("frontend_port_end", value);
    }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortStart is required")]
    public required TerraformProperty<double> FrontendPortStart
    {
        get => GetRequiredOutput<TerraformProperty<double>>("frontend_port_start");
        set => SetProperty("frontend_port_start", value);
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> IdleTimeoutInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_timeout_in_minutes");
        set => SetProperty("idle_timeout_in_minutes", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TcpResetEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("tcp_reset_enabled");
        set => SetProperty("tcp_reset_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbNatPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    public TerraformExpression FrontendIpConfigurationId => this["frontend_ip_configuration_id"];

}

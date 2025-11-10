using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbProbeTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_lb_probe resource.
/// </summary>
public class AzurermLbProbe : TerraformResource
{
    public AzurermLbProbe(string name) : base("azurerm_lb_probe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("load_balancer_rules");
        SetOutput("id");
        SetOutput("interval_in_seconds");
        SetOutput("loadbalancer_id");
        SetOutput("name");
        SetOutput("number_of_probes");
        SetOutput("port");
        SetOutput("probe_threshold");
        SetOutput("protocol");
        SetOutput("request_path");
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
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> IntervalInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("interval_in_seconds");
        set => SetProperty("interval_in_seconds", value);
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
    /// The number_of_probes attribute.
    /// </summary>
    public TerraformProperty<double> NumberOfProbes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("number_of_probes");
        set => SetProperty("number_of_probes", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The probe_threshold attribute.
    /// </summary>
    public TerraformProperty<double> ProbeThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("probe_threshold");
        set => SetProperty("probe_threshold", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The request_path attribute.
    /// </summary>
    public TerraformProperty<string> RequestPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_path");
        set => SetProperty("request_path", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLbProbeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    public TerraformExpression LoadBalancerRules => this["load_balancer_rules"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("load_balancer_rules");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => this.WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    public TerraformProperty<string>? LoadbalancerId
    {
        get => GetProperty<TerraformProperty<string>>("loadbalancer_id");
        set => this.WithProperty("loadbalancer_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The number_of_probes attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfProbes
    {
        get => GetProperty<TerraformProperty<double>>("number_of_probes");
        set => this.WithProperty("number_of_probes", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The probe_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? ProbeThreshold
    {
        get => GetProperty<TerraformProperty<double>>("probe_threshold");
        set => this.WithProperty("probe_threshold", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The request_path attribute.
    /// </summary>
    public TerraformProperty<string>? RequestPath
    {
        get => GetProperty<TerraformProperty<string>>("request_path");
        set => this.WithProperty("request_path", value);
    }

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    public TerraformExpression LoadBalancerRules => this["load_balancer_rules"];

}

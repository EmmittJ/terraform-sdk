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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("interval_in_seconds");
        set => this.WithProperty("interval_in_seconds", value);
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
    /// The number_of_probes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? NumberOfProbes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_probes");
        set => this.WithProperty("number_of_probes", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The probe_threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ProbeThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("probe_threshold");
        set => this.WithProperty("probe_threshold", value);
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
    /// The request_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_path");
        set => this.WithProperty("request_path", value);
    }

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    public TerraformExpression LoadBalancerRules => this["load_balancer_rules"];

}

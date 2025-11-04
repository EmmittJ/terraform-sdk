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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public double? IntervalInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("interval_in_seconds")?.Value;
        set => this.WithProperty("interval_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The number_of_probes attribute.
    /// </summary>
    public double? NumberOfProbes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("number_of_probes")?.Value;
        set => this.WithProperty("number_of_probes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The probe_threshold attribute.
    /// </summary>
    public double? ProbeThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("probe_threshold")?.Value;
        set => this.WithProperty("probe_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The request_path attribute.
    /// </summary>
    public string? RequestPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_path")?.Value;
        set => this.WithProperty("request_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    public TerraformExpression LoadBalancerRules => this["load_balancer_rules"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_load_balancer_listener_policy resource.
/// </summary>
public class AwsLoadBalancerListenerPolicy : TerraformResource
{
    public AwsLoadBalancerListenerPolicy(string name) : base("aws_load_balancer_listener_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The load_balancer_name attribute.
    /// </summary>
    public string? LoadBalancerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_name")?.Value;
        set => this.WithProperty("load_balancer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancer_port attribute.
    /// </summary>
    public double? LoadBalancerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("load_balancer_port")?.Value;
        set => this.WithProperty("load_balancer_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public HashSet<string>? PolicyNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_names")?.Value;
        set => this.WithProperty("policy_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}

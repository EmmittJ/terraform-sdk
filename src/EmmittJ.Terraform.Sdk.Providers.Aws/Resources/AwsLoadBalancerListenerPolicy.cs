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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerName
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_name");
        set => this.WithProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The load_balancer_port attribute.
    /// </summary>
    public TerraformProperty<double>? LoadBalancerPort
    {
        get => GetProperty<TerraformProperty<double>>("load_balancer_port");
        set => this.WithProperty("load_balancer_port", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? PolicyNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("policy_names");
        set => this.WithProperty("policy_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

}

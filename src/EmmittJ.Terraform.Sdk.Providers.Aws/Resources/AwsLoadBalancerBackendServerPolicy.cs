using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_load_balancer_backend_server_policy resource.
/// </summary>
public class AwsLoadBalancerBackendServerPolicy : TerraformResource
{
    public AwsLoadBalancerBackendServerPolicy(string name) : base("aws_load_balancer_backend_server_policy", name)
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
    /// The instance_port attribute.
    /// </summary>
    public TerraformProperty<double>? InstancePort
    {
        get => GetProperty<TerraformProperty<double>>("instance_port");
        set => this.WithProperty("instance_port", value);
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

}

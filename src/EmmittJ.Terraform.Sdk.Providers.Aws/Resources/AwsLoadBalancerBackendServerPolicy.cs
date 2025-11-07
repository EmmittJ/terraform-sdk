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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? InstancePort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_port");
        set => this.WithProperty("instance_port", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_name");
        set => this.WithProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PolicyNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_names");
        set => this.WithProperty("policy_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    public double? InstancePort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_port")?.Value;
        set => this.WithProperty("instance_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The policy_names attribute.
    /// </summary>
    public HashSet<string>? PolicyNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("policy_names")?.Value;
        set => this.WithProperty("policy_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

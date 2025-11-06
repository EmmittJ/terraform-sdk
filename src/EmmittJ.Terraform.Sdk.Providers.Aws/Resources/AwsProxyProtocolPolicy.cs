using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_proxy_protocol_policy resource.
/// </summary>
public class AwsProxyProtocolPolicy : TerraformResource
{
    public AwsProxyProtocolPolicy(string name) : base("aws_proxy_protocol_policy", name)
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
    /// The instance_ports attribute.
    /// </summary>
    public HashSet<string>? InstancePorts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("instance_ports")?.Value;
        set => this.WithProperty("instance_ports", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public string? LoadBalancer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer")?.Value;
        set => this.WithProperty("load_balancer", value == null ? null : new TerraformLiteralProperty<string>(value));
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

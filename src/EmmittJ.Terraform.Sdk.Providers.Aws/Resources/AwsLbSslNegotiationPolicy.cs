using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_ssl_negotiation_policy resource.
/// </summary>
public class AwsLbSslNegotiationPolicy : TerraformResource
{
    public AwsLbSslNegotiationPolicy(string name) : base("aws_lb_ssl_negotiation_policy", name)
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
    /// The lb_port attribute.
    /// </summary>
    public TerraformProperty<double>? LbPort
    {
        get => GetProperty<TerraformProperty<double>>("lb_port");
        set => this.WithProperty("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancer
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
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

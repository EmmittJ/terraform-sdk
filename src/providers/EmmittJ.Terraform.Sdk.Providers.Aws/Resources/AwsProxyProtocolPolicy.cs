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
        SetOutput("id");
        SetOutput("instance_ports");
        SetOutput("load_balancer");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePorts is required")]
    public HashSet<TerraformProperty<string>> InstancePorts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("instance_ports");
        set => SetProperty("instance_ports", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    public required TerraformProperty<string> LoadBalancer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer");
        set => SetProperty("load_balancer", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}

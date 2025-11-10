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
        SetOutput("id");
        SetOutput("instance_port");
        SetOutput("load_balancer_name");
        SetOutput("policy_names");
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
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    public required TerraformProperty<double> InstancePort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instance_port");
        set => SetProperty("instance_port", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformProperty<string> LoadBalancerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_name");
        set => SetProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> PolicyNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("policy_names");
        set => SetProperty("policy_names", value);
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

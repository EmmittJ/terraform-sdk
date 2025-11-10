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
        SetOutput("id");
        SetOutput("load_balancer_name");
        SetOutput("load_balancer_port");
        SetOutput("policy_names");
        SetOutput("region");
        SetOutput("triggers");
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
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformProperty<string> LoadBalancerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_name");
        set => SetProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The load_balancer_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerPort is required")]
    public required TerraformProperty<double> LoadBalancerPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("load_balancer_port");
        set => SetProperty("load_balancer_port", value);
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

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

}

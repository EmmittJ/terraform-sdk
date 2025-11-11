using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_load_balancer_listener_policy resource.
/// </summary>
public partial class AwsLoadBalancerListenerPolicy : TerraformResource
{
    public AwsLoadBalancerListenerPolicy(string name) : base("aws_load_balancer_listener_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    [TerraformProperty("load_balancer_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LoadBalancerName { get; set; }

    /// <summary>
    /// The load_balancer_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerPort is required")]
    [TerraformProperty("load_balancer_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> LoadBalancerPort { get; set; }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    [TerraformProperty("policy_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? PolicyNames { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Triggers { get; set; }

}

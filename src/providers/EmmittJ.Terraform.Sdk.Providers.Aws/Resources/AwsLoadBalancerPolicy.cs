using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_attribute in .
/// Nesting mode: set
/// </summary>
public partial class AwsLoadBalancerPolicyPolicyAttributeBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Manages a aws_load_balancer_policy resource.
/// </summary>
public partial class AwsLoadBalancerPolicy : TerraformResource
{
    public AwsLoadBalancerPolicy(string name) : base("aws_load_balancer_policy", name)
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
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    [TerraformProperty("policy_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyName { get; set; }

    /// <summary>
    /// The policy_type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTypeName is required")]
    [TerraformProperty("policy_type_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyTypeName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for policy_attribute.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("policy_attribute")]
    public TerraformSet<TerraformBlock<AwsLoadBalancerPolicyPolicyAttributeBlock>>? PolicyAttribute { get; set; }

}

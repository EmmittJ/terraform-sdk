using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_attribute in AwsLoadBalancerPolicy.
/// Nesting mode: set
/// </summary>
public class AwsLoadBalancerPolicyPolicyAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_attribute";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_load_balancer_policy Terraform resource.
/// Manages a aws_load_balancer_policy resource.
/// </summary>
public partial class AwsLoadBalancerPolicy(string name) : TerraformResource("aws_load_balancer_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformValue<string> LoadBalancerName
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_name");
        set => SetArgument("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformValue<string> PolicyName
    {
        get => GetArgument<TerraformValue<string>>("policy_name");
        set => SetArgument("policy_name", value);
    }

    /// <summary>
    /// The policy_type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTypeName is required")]
    public required TerraformValue<string> PolicyTypeName
    {
        get => GetArgument<TerraformValue<string>>("policy_type_name");
        set => SetArgument("policy_type_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// PolicyAttribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLoadBalancerPolicyPolicyAttributeBlock>? PolicyAttribute
    {
        get => GetArgument<TerraformSet<AwsLoadBalancerPolicyPolicyAttributeBlock>>("policy_attribute");
        set => SetArgument("policy_attribute", value);
    }

}

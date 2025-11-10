using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_attribute in .
/// Nesting mode: set
/// </summary>
public class AwsLoadBalancerPolicyPolicyAttributeBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_load_balancer_policy resource.
/// </summary>
public class AwsLoadBalancerPolicy : TerraformResource
{
    public AwsLoadBalancerPolicy(string name) : base("aws_load_balancer_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("load_balancer_name");
        SetOutput("policy_name");
        SetOutput("policy_type_name");
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
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformProperty<string> LoadBalancerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_name");
        set => SetProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformProperty<string> PolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_name");
        set => SetProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTypeName is required")]
    public required TerraformProperty<string> PolicyTypeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_type_name");
        set => SetProperty("policy_type_name", value);
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
    /// Block for policy_attribute.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLoadBalancerPolicyPolicyAttributeBlock>? PolicyAttribute
    {
        set => SetProperty("policy_attribute", value);
    }

}

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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformProperty<string> LoadBalancerName
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_name");
        set => this.WithProperty("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformProperty<string> PolicyName
    {
        get => GetProperty<TerraformProperty<string>>("policy_name");
        set => this.WithProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTypeName is required")]
    public required TerraformProperty<string> PolicyTypeName
    {
        get => GetProperty<TerraformProperty<string>>("policy_type_name");
        set => this.WithProperty("policy_type_name", value);
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
    /// Block for policy_attribute.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLoadBalancerPolicyPolicyAttributeBlock>? PolicyAttribute
    {
        get => GetProperty<HashSet<AwsLoadBalancerPolicyPolicyAttributeBlock>>("policy_attribute");
        set => this.WithProperty("policy_attribute", value);
    }

}

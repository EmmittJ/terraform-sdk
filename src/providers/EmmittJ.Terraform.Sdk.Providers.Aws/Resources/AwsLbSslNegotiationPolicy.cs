using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attribute in AwsLbSslNegotiationPolicy.
/// Nesting mode: set
/// </summary>
public class AwsLbSslNegotiationPolicyAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attribute";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_lb_ssl_negotiation_policy Terraform resource.
/// Manages a aws_lb_ssl_negotiation_policy resource.
/// </summary>
public partial class AwsLbSslNegotiationPolicy(string name) : TerraformResource("aws_lb_ssl_negotiation_policy", name)
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
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformValue<double> LbPort
    {
        get => GetArgument<TerraformValue<double>>("lb_port");
        set => SetArgument("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    public required TerraformValue<string> LoadBalancer
    {
        get => GetArgument<TerraformValue<string>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string>? Triggers
    {
        get => GetArgument<TerraformMap<string>>("triggers");
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// Attribute block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbSslNegotiationPolicyAttributeBlock>? Attribute
    {
        get => GetArgument<TerraformSet<AwsLbSslNegotiationPolicyAttributeBlock>>("attribute");
        set => SetArgument("attribute", value);
    }

}

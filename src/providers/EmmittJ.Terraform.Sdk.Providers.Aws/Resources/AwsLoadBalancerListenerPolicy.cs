using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_load_balancer_listener_policy Terraform resource.
/// Manages a aws_load_balancer_listener_policy resource.
/// </summary>
public partial class AwsLoadBalancerListenerPolicy(string name) : TerraformResource("aws_load_balancer_listener_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformValue<string> LoadBalancerName
    {
        get => new TerraformReference<string>(this, "load_balancer_name");
        set => SetArgument("load_balancer_name", value);
    }

    /// <summary>
    /// The load_balancer_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerPort is required")]
    public required TerraformValue<double> LoadBalancerPort
    {
        get => new TerraformReference<double>(this, "load_balancer_port");
        set => SetArgument("load_balancer_port", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public TerraformSet<string>? PolicyNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_names").ResolveNodes(ctx));
        set => SetArgument("policy_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string>? Triggers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "triggers").ResolveNodes(ctx));
        set => SetArgument("triggers", value);
    }

}

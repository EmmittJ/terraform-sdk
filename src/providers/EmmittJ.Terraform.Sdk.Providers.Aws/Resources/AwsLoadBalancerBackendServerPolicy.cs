using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_load_balancer_backend_server_policy Terraform resource.
/// Manages a aws_load_balancer_backend_server_policy resource.
/// </summary>
public partial class AwsLoadBalancerBackendServerPolicy(string name) : TerraformResource("aws_load_balancer_backend_server_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    public required TerraformValue<double> InstancePort
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_port");
        set => SetArgument("instance_port", value);
    }

    /// <summary>
    /// The load_balancer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerName is required")]
    public required TerraformValue<string> LoadBalancerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancer_name");
        set => SetArgument("load_balancer_name", value);
    }

    /// <summary>
    /// The policy_names attribute.
    /// </summary>
    public TerraformSet<string>? PolicyNames
    {
        get => GetArgument<TerraformSet<string>>("policy_names");
        set => SetArgument("policy_names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

}

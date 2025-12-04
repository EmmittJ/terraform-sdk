using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_proxy_protocol_policy Terraform resource.
/// Manages a aws_proxy_protocol_policy resource.
/// </summary>
public partial class AwsProxyProtocolPolicy(string name) : TerraformResource("aws_proxy_protocol_policy", name)
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
    /// The instance_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePorts is required")]
    public required TerraformSet<string> InstancePorts
    {
        get => GetArgument<TerraformSet<string>>("instance_ports");
        set => SetArgument("instance_ports", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}

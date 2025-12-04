using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lb_cookie_stickiness_policy Terraform resource.
/// Manages a aws_lb_cookie_stickiness_policy resource.
/// </summary>
public partial class AwsLbCookieStickinessPolicy(string name) : TerraformResource("aws_lb_cookie_stickiness_policy", name)
{
    /// <summary>
    /// The cookie_expiration_period attribute.
    /// </summary>
    public TerraformValue<double>? CookieExpirationPeriod
    {
        get => GetArgument<TerraformValue<double>>("cookie_expiration_period");
        set => SetArgument("cookie_expiration_period", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformValue<double> LbPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("lb_port");
        set => SetArgument("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    public required TerraformValue<string> LoadBalancer
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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

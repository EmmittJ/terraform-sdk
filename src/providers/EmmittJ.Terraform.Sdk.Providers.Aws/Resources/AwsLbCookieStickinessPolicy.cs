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
        get => new TerraformReference<double>(this, "cookie_expiration_period");
        set => SetArgument("cookie_expiration_period", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformValue<double> LbPort
    {
        get => new TerraformReference<double>(this, "lb_port");
        set => SetArgument("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    public required TerraformValue<string> LoadBalancer
    {
        get => new TerraformReference<string>(this, "load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}

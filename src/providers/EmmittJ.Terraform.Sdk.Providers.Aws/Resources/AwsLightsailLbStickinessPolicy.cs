using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_lb_stickiness_policy Terraform resource.
/// Manages a aws_lightsail_lb_stickiness_policy resource.
/// </summary>
public partial class AwsLightsailLbStickinessPolicy(string name) : TerraformResource("aws_lightsail_lb_stickiness_policy", name)
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieDuration is required")]
    public required TerraformValue<double> CookieDuration
    {
        get => GetArgument<TerraformValue<double>>("cookie_duration");
        set => SetArgument("cookie_duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lb_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbName is required")]
    public required TerraformValue<string> LbName
    {
        get => GetArgument<TerraformValue<string>>("lb_name");
        set => SetArgument("lb_name", value);
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

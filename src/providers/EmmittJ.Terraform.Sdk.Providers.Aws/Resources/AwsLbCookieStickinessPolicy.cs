using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_cookie_stickiness_policy resource.
/// </summary>
public partial class AwsLbCookieStickinessPolicy : TerraformResource
{
    public AwsLbCookieStickinessPolicy(string name) : base("aws_lb_cookie_stickiness_policy", name)
    {
    }

    /// <summary>
    /// The cookie_expiration_period attribute.
    /// </summary>
    [TerraformProperty("cookie_expiration_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CookieExpirationPeriod { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    [TerraformProperty("lb_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> LbPort { get; set; }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    [TerraformProperty("load_balancer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadBalancer { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}

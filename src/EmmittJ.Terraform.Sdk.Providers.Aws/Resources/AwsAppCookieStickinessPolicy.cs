using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_app_cookie_stickiness_policy resource.
/// </summary>
public class AwsAppCookieStickinessPolicy : TerraformResource
{
    public AwsAppCookieStickinessPolicy(string name) : base("aws_app_cookie_stickiness_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieName is required")]
    public required TerraformProperty<string> CookieName
    {
        get => GetProperty<TerraformProperty<string>>("cookie_name");
        set => this.WithProperty("cookie_name", value);
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
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformProperty<double> LbPort
    {
        get => GetProperty<TerraformProperty<double>>("lb_port");
        set => this.WithProperty("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancer is required")]
    public required TerraformProperty<string> LoadBalancer
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}

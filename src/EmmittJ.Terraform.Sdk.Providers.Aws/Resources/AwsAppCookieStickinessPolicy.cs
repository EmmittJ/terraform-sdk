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
    public TerraformLiteralProperty<string>? CookieName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cookie_name");
        set => this.WithProperty("cookie_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? LbPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lb_port");
        set => this.WithProperty("lb_port", value);
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer");
        set => this.WithProperty("load_balancer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}

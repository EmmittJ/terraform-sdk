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
    public string? CookieName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cookie_name")?.Value;
        set => this.WithProperty("cookie_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    public double? LbPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("lb_port")?.Value;
        set => this.WithProperty("lb_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The load_balancer attribute.
    /// </summary>
    public string? LoadBalancer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer")?.Value;
        set => this.WithProperty("load_balancer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb_cookie_stickiness_policy resource.
/// </summary>
public class AwsLbCookieStickinessPolicy : TerraformResource
{
    public AwsLbCookieStickinessPolicy(string name) : base("aws_lb_cookie_stickiness_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cookie_expiration_period attribute.
    /// </summary>
    public double? CookieExpirationPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cookie_expiration_period")?.Value;
        set => this.WithProperty("cookie_expiration_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_lb_stickiness_policy resource.
/// </summary>
public class AwsLightsailLbStickinessPolicy : TerraformResource
{
    public AwsLightsailLbStickinessPolicy(string name) : base("aws_lightsail_lb_stickiness_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CookieDuration
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cookie_duration");
        set => this.WithProperty("cookie_duration", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The lb_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lb_name");
        set => this.WithProperty("lb_name", value);
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_alb_listener.
/// </summary>
public class AwsAlbListenerDataSource : TerraformDataSource
{
    public AwsAlbListenerDataSource(string name) : base("aws_alb_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alpn_policy");
        this.DeclareOutput("certificate_arn");
        this.DeclareOutput("default_action");
        this.DeclareOutput("mutual_authentication");
        this.DeclareOutput("protocol");
        this.DeclareOutput("ssl_policy");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The load_balancer_arn attribute.
    /// </summary>
    public string? LoadBalancerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_arn")?.Value;
        set => this.WithProperty("load_balancer_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformExpression AlpnPolicy => this["alpn_policy"];

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformExpression CertificateArn => this["certificate_arn"];

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformExpression DefaultAction => this["default_action"];

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    public TerraformExpression MutualAuthentication => this["mutual_authentication"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformExpression SslPolicy => this["ssl_policy"];

}

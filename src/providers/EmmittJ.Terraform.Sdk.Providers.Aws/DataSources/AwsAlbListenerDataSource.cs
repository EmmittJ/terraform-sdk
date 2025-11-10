using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbListenerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("alpn_policy");
        this.WithOutput("certificate_arn");
        this.WithOutput("default_action");
        this.WithOutput("mutual_authentication");
        this.WithOutput("protocol");
        this.WithOutput("ssl_policy");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerArn
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_arn");
        set => this.WithProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAlbListenerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAlbListenerDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

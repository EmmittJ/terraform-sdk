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
        set => SetProperty("read", value);
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
        SetOutput("alpn_policy");
        SetOutput("certificate_arn");
        SetOutput("default_action");
        SetOutput("mutual_authentication");
        SetOutput("protocol");
        SetOutput("ssl_policy");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("load_balancer_arn");
        SetOutput("port");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_arn");
        set => SetProperty("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAlbListenerDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

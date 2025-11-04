using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        DeclareOutput("alpn_policy");
        DeclareOutput("certificate_arn");
        DeclareOutput("default_action");
        DeclareOutput("mutual_authentication");
        DeclareOutput("protocol");
        DeclareOutput("ssl_policy");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("arn")?.Value;
        set => WithPropertyInternal("arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public string? LoadBalancerArn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("load_balancer_arn")?.Value;
        set => WithPropertyInternal("load_balancer_arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty&lt;double&gt;>("port")?.Value;
        set => WithPropertyInternal("port", value == null ? null : new TerraformLiteralProperty&lt;double&gt;(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbListenerDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_alb_listener.
/// </summary>
public class AwsAlbListenerDataSource : TerraformDataSource
{
    public AwsAlbListenerDataSource(string name) : base("aws_alb_listener", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoadBalancerArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancer_arn");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAlbListenerDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformPropertyName("alpn_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AlpnPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alpn_policy");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformPropertyName("default_action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DefaultAction => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "default_action");

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    [TerraformPropertyName("mutual_authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MutualAuthentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mutual_authentication");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Protocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SslPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ssl_policy");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbListenerDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_lb_listener.
/// </summary>
public class AwsLbListenerDataSource : TerraformDataSource
{
    public AwsLbListenerDataSource(string name) : base("aws_lb_listener", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoadBalancerArn { get; set; } = default!;

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Port { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbListenerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformPropertyName("alpn_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AlpnPolicy => new TerraformReference(this, "alpn_policy");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateArn => new TerraformReference(this, "certificate_arn");

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformPropertyName("default_action")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DefaultAction => new TerraformReference(this, "default_action");

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    [TerraformPropertyName("mutual_authentication")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MutualAuthentication => new TerraformReference(this, "mutual_authentication");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Protocol => new TerraformReference(this, "protocol");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformPropertyName("ssl_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SslPolicy => new TerraformReference(this, "ssl_policy");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAlbListenerDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_alb_listener.
/// </summary>
public partial class AwsAlbListenerDataSource : TerraformDataSource
{
    public AwsAlbListenerDataSource(string name) : base("aws_alb_listener", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformProperty("load_balancer_arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsAlbListenerDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformProperty("alpn_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AlpnPolicy { get; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DefaultAction { get; }

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    [TerraformProperty("mutual_authentication")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MutualAuthentication { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SslPolicy { get; }

}

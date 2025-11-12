using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLbListenerDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_lb_listener.
/// </summary>
public partial class AwsLbListenerDataSource : TerraformDataSource
{
    public AwsLbListenerDataSource(string name) : base("aws_lb_listener", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    [TerraformProperty("load_balancer_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoadBalancerArn { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsLbListenerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    [TerraformProperty("alpn_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AlpnPolicy { get; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DefaultAction { get; }

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    [TerraformProperty("mutual_authentication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MutualAuthentication { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    [TerraformProperty("ssl_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SslPolicy { get; }

}

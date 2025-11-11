using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbTargetGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_alb_target_group.
/// </summary>
public class AwsAlbTargetGroupDataSource : TerraformDataSource
{
    public AwsAlbTargetGroupDataSource(string name) : base("aws_alb_target_group", name)
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
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_anomaly_mitigation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoadBalancingAnomalyMitigation { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

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
    public TerraformBlock<AwsAlbTargetGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnSuffix => new TerraformReference(this, "arn_suffix");

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    [TerraformPropertyName("connection_termination")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ConnectionTermination => new TerraformReference(this, "connection_termination");

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformPropertyName("deregistration_delay")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeregistrationDelay => new TerraformReference(this, "deregistration_delay");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformPropertyName("health_check")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HealthCheck => new TerraformReference(this, "health_check");

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lambda_multi_value_headers_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LambdaMultiValueHeadersEnabled => new TerraformReference(this, "lambda_multi_value_headers_enabled");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LoadBalancerArns => new TerraformReference(this, "load_balancer_arns");

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_algorithm_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancingAlgorithmType => new TerraformReference(this, "load_balancing_algorithm_type");

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_cross_zone_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancingCrossZoneEnabled => new TerraformReference(this, "load_balancing_cross_zone_enabled");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Port => new TerraformReference(this, "port");

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformPropertyName("preserve_client_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreserveClientIp => new TerraformReference(this, "preserve_client_ip");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Protocol => new TerraformReference(this, "protocol");

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("protocol_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProtocolVersion => new TerraformReference(this, "protocol_version");

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformPropertyName("proxy_protocol_v2")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ProxyProtocolV2 => new TerraformReference(this, "proxy_protocol_v2");

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformPropertyName("slow_start")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SlowStart => new TerraformReference(this, "slow_start");

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    [TerraformPropertyName("stickiness")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Stickiness => new TerraformReference(this, "stickiness");

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TargetType => new TerraformReference(this, "target_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAlbTargetGroupDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_alb_target_group.
/// </summary>
public partial class AwsAlbTargetGroupDataSource : TerraformDataSource
{
    public AwsAlbTargetGroupDataSource(string name) : base("aws_alb_target_group", name)
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
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformProperty("load_balancing_anomaly_mitigation")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LoadBalancingAnomalyMitigation { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

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
    public partial TerraformBlock<AwsAlbTargetGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformProperty("arn_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnSuffix { get; }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    [TerraformProperty("connection_termination")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ConnectionTermination { get; }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformProperty("deregistration_delay")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeregistrationDelay { get; }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformProperty("health_check")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthCheck { get; }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformProperty("lambda_multi_value_headers_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LambdaMultiValueHeadersEnabled { get; }

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformProperty("load_balancer_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> LoadBalancerArns { get; }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformProperty("load_balancing_algorithm_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoadBalancingAlgorithmType { get; }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformProperty("load_balancing_cross_zone_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LoadBalancingCrossZoneEnabled { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformProperty("preserve_client_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreserveClientIp { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformProperty("protocol_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProtocolVersion { get; }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformProperty("proxy_protocol_v2")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ProxyProtocolV2 { get; }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformProperty("slow_start")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SlowStart { get; }

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    [TerraformProperty("stickiness")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Stickiness { get; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformProperty("target_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetType { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

}

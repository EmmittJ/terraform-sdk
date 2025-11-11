using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbTargetGroupHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformProperty("healthy_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    [TerraformProperty("matcher")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Matcher { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformProperty("unhealthy_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for stickiness in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbTargetGroupStickinessBlock : TerraformBlockBase
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    [TerraformProperty("cookie_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CookieDuration { get; set; }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    [TerraformProperty("cookie_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CookieName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for target_failover in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbTargetGroupTargetFailoverBlock : TerraformBlockBase
{
    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    [TerraformProperty("on_deregistration")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OnDeregistration { get; set; }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    [TerraformProperty("on_unhealthy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OnUnhealthy { get; set; }

}

/// <summary>
/// Block type for target_group_health in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbTargetGroupTargetGroupHealthBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for target_health_state in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbTargetGroupTargetHealthStateBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    [TerraformProperty("enable_unhealthy_connection_termination")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> EnableUnhealthyConnectionTermination { get; set; }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    [TerraformProperty("unhealthy_draining_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? UnhealthyDrainingInterval { get; set; }

}

/// <summary>
/// Manages a aws_alb_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAlbTargetGroup : TerraformResource
{
    public AwsAlbTargetGroup(string name) : base("aws_alb_target_group", name)
    {
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    [TerraformProperty("connection_termination")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ConnectionTermination { get; set; }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformProperty("deregistration_delay")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeregistrationDelay { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformProperty("lambda_multi_value_headers_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformProperty("load_balancing_algorithm_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoadBalancingAlgorithmType { get; set; }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformProperty("load_balancing_anomaly_mitigation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoadBalancingAnomalyMitigation { get; set; }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformProperty("load_balancing_cross_zone_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LoadBalancingCrossZoneEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformProperty("preserve_client_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreserveClientIp { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformProperty("protocol_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ProtocolVersion { get; set; }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformProperty("proxy_protocol_v2")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ProxyProtocolV2 { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformProperty("slow_start")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SlowStart { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformProperty("target_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TargetType { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpcId { get; set; }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    [TerraformProperty("health_check")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupHealthCheckBlock>>? HealthCheck { get; set; }

    /// <summary>
    /// Block for stickiness.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    [TerraformProperty("stickiness")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupStickinessBlock>>? Stickiness { get; set; }

    /// <summary>
    /// Block for target_failover.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("target_failover")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetFailoverBlock>>? TargetFailover { get; set; }

    /// <summary>
    /// Block for target_group_health.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    [TerraformProperty("target_group_health")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetGroupHealthBlock>>? TargetGroupHealth { get; set; }

    /// <summary>
    /// Block for target_health_state.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("target_health_state")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetHealthStateBlock>>? TargetHealthState { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformProperty("arn_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ArnSuffix { get; }

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformProperty("load_balancer_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> LoadBalancerArns { get; }

}

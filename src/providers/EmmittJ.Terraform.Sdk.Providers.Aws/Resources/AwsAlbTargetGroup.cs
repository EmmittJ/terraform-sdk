using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupHealthCheckBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Interval { get; set; }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    [TerraformPropertyName("matcher")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Matcher { get; set; } = default!;

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Path { get; set; } = default!;

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Timeout { get; set; } = default!;

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for stickiness in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupStickinessBlock
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    [TerraformPropertyName("cookie_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CookieDuration { get; set; }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    [TerraformPropertyName("cookie_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CookieName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for target_failover in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetFailoverBlock
{
    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    [TerraformPropertyName("on_deregistration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OnDeregistration { get; set; }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    [TerraformPropertyName("on_unhealthy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OnUnhealthy { get; set; }

}

/// <summary>
/// Block type for target_group_health in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlock
{
}

/// <summary>
/// Block type for target_health_state in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetHealthStateBlock
{
    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    [TerraformPropertyName("enable_unhealthy_connection_termination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EnableUnhealthyConnectionTermination { get; set; }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_draining_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UnhealthyDrainingInterval { get; set; }

}

/// <summary>
/// Manages a aws_alb_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlbTargetGroup : TerraformResource
{
    public AwsAlbTargetGroup(string name) : base("aws_alb_target_group", name)
    {
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    [TerraformPropertyName("connection_termination")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ConnectionTermination { get; set; } = default!;

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformPropertyName("deregistration_delay")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeregistrationDelay { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpAddressType { get; set; } = default!;

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lambda_multi_value_headers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_algorithm_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoadBalancingAlgorithmType { get; set; } = default!;

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_anomaly_mitigation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoadBalancingAnomalyMitigation { get; set; } = default!;

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_cross_zone_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LoadBalancingCrossZoneEnabled { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformPropertyName("preserve_client_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreserveClientIp { get; set; } = default!;

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("protocol_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProtocolVersion { get; set; } = default!;

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformPropertyName("proxy_protocol_v2")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ProxyProtocolV2 { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformPropertyName("slow_start")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SlowStart { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetType { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcId { get; set; }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    [TerraformPropertyName("health_check")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupHealthCheckBlock>>? HealthCheck { get; set; }

    /// <summary>
    /// Block for stickiness.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    [TerraformPropertyName("stickiness")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupStickinessBlock>>? Stickiness { get; set; }

    /// <summary>
    /// Block for target_failover.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_failover")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetFailoverBlock>>? TargetFailover { get; set; }

    /// <summary>
    /// Block for target_group_health.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    [TerraformPropertyName("target_group_health")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetGroupHealthBlock>>? TargetGroupHealth { get; set; }

    /// <summary>
    /// Block for target_health_state.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_health_state")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetHealthStateBlock>>? TargetHealthState { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnSuffix => new TerraformReference(this, "arn_suffix");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LoadBalancerArns => new TerraformReference(this, "load_balancer_arns");

}

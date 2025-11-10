using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupHealthCheckBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("healthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Interval { get; set; }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    [TerraformPropertyName("matcher")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Matcher { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "matcher");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Path { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "path");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Timeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "timeout");

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for stickiness in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupStickinessBlock : ITerraformBlock
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    [TerraformPropertyName("cookie_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? CookieDuration { get; set; }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    [TerraformPropertyName("cookie_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CookieName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for target_failover in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetFailoverBlock : ITerraformBlock
{
    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    [TerraformPropertyName("on_deregistration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OnDeregistration { get; set; }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    [TerraformPropertyName("on_unhealthy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OnUnhealthy { get; set; }

}

/// <summary>
/// Block type for target_group_health in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for target_health_state in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetHealthStateBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    [TerraformPropertyName("enable_unhealthy_connection_termination")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableUnhealthyConnectionTermination { get; set; }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_draining_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UnhealthyDrainingInterval { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ConnectionTermination { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "connection_termination");

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformPropertyName("deregistration_delay")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeregistrationDelay { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lambda_multi_value_headers_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LambdaMultiValueHeadersEnabled { get; set; }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_algorithm_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoadBalancingAlgorithmType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_algorithm_type");

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_anomaly_mitigation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoadBalancingAnomalyMitigation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_anomaly_mitigation");

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_cross_zone_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoadBalancingCrossZoneEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_cross_zone_enabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformPropertyName("preserve_client_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreserveClientIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preserve_client_ip");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("protocol_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProtocolVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol_version");

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformPropertyName("proxy_protocol_v2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ProxyProtocolV2 { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformPropertyName("slow_start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SlowStart { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetType { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcId { get; set; }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    [TerraformPropertyName("health_check")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupHealthCheckBlock>>? HealthCheck { get; set; } = new();

    /// <summary>
    /// Block for stickiness.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    [TerraformPropertyName("stickiness")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupStickinessBlock>>? Stickiness { get; set; } = new();

    /// <summary>
    /// Block for target_failover.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_failover")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetFailoverBlock>>? TargetFailover { get; set; } = new();

    /// <summary>
    /// Block for target_group_health.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    [TerraformPropertyName("target_group_health")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetGroupHealthBlock>>? TargetGroupHealth { get; set; } = new();

    /// <summary>
    /// Block for target_health_state.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("target_health_state")]
    public TerraformList<TerraformBlock<AwsAlbTargetGroupTargetHealthStateBlock>>? TargetHealthState { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_suffix");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancerArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "load_balancer_arns");

}

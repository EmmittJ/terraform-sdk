using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbTargetGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_lb_target_group.
/// </summary>
public class AwsLbTargetGroupDataSource : TerraformDataSource
{
    public AwsLbTargetGroupDataSource(string name) : base("aws_lb_target_group", name)
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
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_anomaly_mitigation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LoadBalancingAnomalyMitigation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_anomaly_mitigation");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    public TerraformBlock<AwsLbTargetGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_suffix");

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    [TerraformPropertyName("connection_termination")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ConnectionTermination => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "connection_termination");

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    [TerraformPropertyName("deregistration_delay")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeregistrationDelay => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deregistration_delay");

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    [TerraformPropertyName("health_check")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HealthCheck => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "health_check");

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    [TerraformPropertyName("lambda_multi_value_headers_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LambdaMultiValueHeadersEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "lambda_multi_value_headers_enabled");

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancerArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "load_balancer_arns");

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_algorithm_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadBalancingAlgorithmType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_algorithm_type");

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_cross_zone_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadBalancingCrossZoneEnabled => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancing_cross_zone_enabled");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    [TerraformPropertyName("preserve_client_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreserveClientIp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preserve_client_ip");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Protocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    [TerraformPropertyName("protocol_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProtocolVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol_version");

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    [TerraformPropertyName("proxy_protocol_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ProxyProtocolV2 => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "proxy_protocol_v2");

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    [TerraformPropertyName("slow_start")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SlowStart => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "slow_start");

    /// <summary>
    /// The stickiness attribute.
    /// </summary>
    [TerraformPropertyName("stickiness")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Stickiness => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "stickiness");

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformPropertyName("target_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}

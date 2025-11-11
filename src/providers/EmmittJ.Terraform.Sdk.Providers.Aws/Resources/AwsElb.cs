using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsElbAccessLogsBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformPropertyName("bucket_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketPrefix { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Interval { get; set; }

}

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsElbHealthCheckBlock
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthyThreshold is required")]
    [TerraformPropertyName("healthy_threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformPropertyName("target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Target { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformPropertyName("timeout")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformPropertyName("unhealthy_threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for listener in .
/// Nesting mode: set
/// </summary>
public class AwsElbListenerBlock
{
    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    [TerraformPropertyName("instance_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> InstancePort { get; set; }

    /// <summary>
    /// The instance_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProtocol is required")]
    [TerraformPropertyName("instance_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceProtocol { get; set; }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    [TerraformPropertyName("lb_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> LbPort { get; set; }

    /// <summary>
    /// The lb_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbProtocol is required")]
    [TerraformPropertyName("lb_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LbProtocol { get; set; }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("ssl_certificate_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SslCertificateId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElbTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElb : TerraformResource
{
    public AwsElb(string name) : base("aws_elb", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AvailabilityZones { get; set; } = default!;

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ConnectionDraining { get; set; }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    [TerraformPropertyName("connection_draining_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ConnectionDrainingTimeout { get; set; }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("cross_zone_load_balancing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CrossZoneLoadBalancing { get; set; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesyncMitigationMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleTimeout { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Instances { get; set; } = default!;

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Internal { get; set; } = default!;

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroups { get; set; } = default!;

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SourceSecurityGroup { get; set; } = default!;

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Subnets { get; set; } = default!;

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
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformPropertyName("access_logs")]
    public TerraformList<TerraformBlock<AwsElbAccessLogsBlock>>? AccessLogs { get; set; }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    [TerraformPropertyName("health_check")]
    public TerraformList<TerraformBlock<AwsElbHealthCheckBlock>>? HealthCheck { get; set; }

    /// <summary>
    /// Block for listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Listener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    [TerraformPropertyName("listener")]
    public TerraformSet<TerraformBlock<AwsElbListenerBlock>>? Listener { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElbTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("source_security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceSecurityGroupId => new TerraformReference(this, "source_security_group_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneId => new TerraformReference(this, "zone_id");

}

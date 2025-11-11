using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public partial class AwsElbAccessLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [TerraformProperty("bucket_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketPrefix { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Interval { get; set; }

}

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public partial class AwsElbHealthCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthyThreshold is required")]
    [TerraformProperty("healthy_threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> HealthyThreshold { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformProperty("interval")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Interval { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Target { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    [TerraformProperty("timeout")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Timeout { get; set; }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    [TerraformProperty("unhealthy_threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> UnhealthyThreshold { get; set; }

}

/// <summary>
/// Block type for listener in .
/// Nesting mode: set
/// </summary>
public partial class AwsElbListenerBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    [TerraformProperty("instance_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InstancePort { get; set; }

    /// <summary>
    /// The instance_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProtocol is required")]
    [TerraformProperty("instance_protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceProtocol { get; set; }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    [TerraformProperty("lb_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> LbPort { get; set; }

    /// <summary>
    /// The lb_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbProtocol is required")]
    [TerraformProperty("lb_protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LbProtocol { get; set; }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    [TerraformProperty("ssl_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SslCertificateId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsElbTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_elb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElb : TerraformResource
{
    public AwsElb(string name) : base("aws_elb", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AvailabilityZones { get; set; }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    [TerraformProperty("connection_draining")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ConnectionDraining { get; set; }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    [TerraformProperty("connection_draining_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ConnectionDrainingTimeout { get; set; }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformProperty("cross_zone_load_balancing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CrossZoneLoadBalancing { get; set; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformProperty("desync_mitigation_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesyncMitigationMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeout { get; set; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Instances { get; set; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformProperty("internal")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Internal { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    [TerraformProperty("source_security_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceSecurityGroup { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformProperty("access_logs")]
    public partial TerraformList<TerraformBlock<AwsElbAccessLogsBlock>>? AccessLogs { get; set; }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    [TerraformProperty("health_check")]
    public partial TerraformList<TerraformBlock<AwsElbHealthCheckBlock>>? HealthCheck { get; set; }

    /// <summary>
    /// Block for listener.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Listener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    [TerraformProperty("listener")]
    public partial TerraformSet<TerraformBlock<AwsElbListenerBlock>>? Listener { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsElbTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    [TerraformProperty("source_security_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceSecurityGroupId { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZoneId { get; }

}

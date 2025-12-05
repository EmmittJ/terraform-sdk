using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in AwsElb.
/// Nesting mode: list
/// </summary>
public class AwsElbAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_logs";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => GetArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

}


/// <summary>
/// Block type for health_check in AwsElb.
/// Nesting mode: list
/// </summary>
public class AwsElbHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check";

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthyThreshold is required")]
    public required TerraformValue<double> HealthyThreshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetRequiredArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Timeout is required")]
    public required TerraformValue<double> Timeout
    {
        get => GetRequiredArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformValue<double> UnhealthyThreshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}


/// <summary>
/// Block type for listener in AwsElb.
/// Nesting mode: set
/// </summary>
public class AwsElbListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "listener";

    /// <summary>
    /// The instance_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstancePort is required")]
    public required TerraformValue<double> InstancePort
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_port");
        set => SetArgument("instance_port", value);
    }

    /// <summary>
    /// The instance_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProtocol is required")]
    public required TerraformValue<string> InstanceProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_protocol");
        set => SetArgument("instance_protocol", value);
    }

    /// <summary>
    /// The lb_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbPort is required")]
    public required TerraformValue<double> LbPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("lb_port");
        set => SetArgument("lb_port", value);
    }

    /// <summary>
    /// The lb_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbProtocol is required")]
    public required TerraformValue<string> LbProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("lb_protocol");
        set => SetArgument("lb_protocol", value);
    }

    /// <summary>
    /// The ssl_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? SslCertificateId
    {
        get => GetArgument<TerraformValue<string>>("ssl_certificate_id");
        set => SetArgument("ssl_certificate_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsElb.
/// Nesting mode: single
/// </summary>
public class AwsElbTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_elb Terraform resource.
/// Manages a aws_elb resource.
/// </summary>
public partial class AwsElb(string name) : TerraformResource("aws_elb", name)
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
    {
        get => GetArgument<TerraformSet<string>>("availability_zones") ?? CreateReference("availability_zones");
        set => SetArgument("availability_zones", value);
    }

    /// <summary>
    /// The connection_draining attribute.
    /// </summary>
    public TerraformValue<bool>? ConnectionDraining
    {
        get => GetArgument<TerraformValue<bool>>("connection_draining");
        set => SetArgument("connection_draining", value);
    }

    /// <summary>
    /// The connection_draining_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionDrainingTimeout
    {
        get => GetArgument<TerraformValue<double>>("connection_draining_timeout");
        set => SetArgument("connection_draining_timeout", value);
    }

    /// <summary>
    /// The cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool>? CrossZoneLoadBalancing
    {
        get => GetArgument<TerraformValue<bool>>("cross_zone_load_balancing");
        set => SetArgument("cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string>? DesyncMitigationMode
    {
        get => GetArgument<TerraformValue<string>>("desync_mitigation_mode");
        set => SetArgument("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeout
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformSet<string> Instances
    {
        get => GetArgument<TerraformSet<string>>("instances") ?? CreateReference("instances");
        set => SetArgument("instances", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
    {
        get => GetArgument<TerraformValue<bool>>("internal") ?? CreateReference("internal");
        set => SetArgument("internal", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups") ?? CreateReference("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The source_security_group attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroup
    {
        get => GetArgument<TerraformValue<string>>("source_security_group") ?? CreateReference("source_security_group");
        set => SetArgument("source_security_group", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets") ?? CreateReference("subnets");
        set => SetArgument("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The source_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> SourceSecurityGroupId
        => CreateReference("source_security_group_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => CreateReference("zone_id");

    /// <summary>
    /// AccessLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public TerraformList<AwsElbAccessLogsBlock>? AccessLogs
    {
        get => GetArgument<TerraformList<AwsElbAccessLogsBlock>>("access_logs");
        set => SetArgument("access_logs", value);
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public TerraformList<AwsElbHealthCheckBlock>? HealthCheck
    {
        get => GetArgument<TerraformList<AwsElbHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// Listener block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Listener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    public required TerraformSet<AwsElbListenerBlock> Listener
    {
        get => GetRequiredArgument<TerraformSet<AwsElbListenerBlock>>("listener");
        set => SetArgument("listener", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElbTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElbTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

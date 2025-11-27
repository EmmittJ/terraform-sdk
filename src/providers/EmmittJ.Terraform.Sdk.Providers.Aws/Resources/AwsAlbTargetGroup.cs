using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in AwsAlbTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? HealthyThreshold
    {
        get => new TerraformReference<double>(this, "healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<double>? Interval
    {
        get => new TerraformReference<double>(this, "interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    public TerraformValue<string> Matcher
    {
        get => new TerraformReference<string>(this, "matcher");
        set => SetArgument("matcher", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => new TerraformReference<string>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double> Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyThreshold
    {
        get => new TerraformReference<double>(this, "unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}


/// <summary>
/// Block type for stickiness in AwsAlbTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupStickinessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stickiness";

    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    public TerraformValue<double>? CookieDuration
    {
        get => new TerraformReference<double>(this, "cookie_duration");
        set => SetArgument("cookie_duration", value);
    }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    public TerraformValue<string>? CookieName
    {
        get => new TerraformReference<string>(this, "cookie_name");
        set => SetArgument("cookie_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for target_failover in AwsAlbTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetFailoverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_failover";

    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    public required TerraformValue<string> OnDeregistration
    {
        get => new TerraformReference<string>(this, "on_deregistration");
        set => SetArgument("on_deregistration", value);
    }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    public required TerraformValue<string> OnUnhealthy
    {
        get => new TerraformReference<string>(this, "on_unhealthy");
        set => SetArgument("on_unhealthy", value);
    }

}


/// <summary>
/// Block type for target_group_health in AwsAlbTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_group_health";

    /// <summary>
    /// DnsFailover block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsFailover block(s) allowed")]
    public TerraformList<AwsAlbTargetGroupTargetGroupHealthBlockDnsFailoverBlock>? DnsFailover
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupTargetGroupHealthBlockDnsFailoverBlock>>("dns_failover");
        set => SetArgument("dns_failover", value);
    }

    /// <summary>
    /// UnhealthyStateRouting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UnhealthyStateRouting block(s) allowed")]
    public TerraformList<AwsAlbTargetGroupTargetGroupHealthBlockUnhealthyStateRoutingBlock>? UnhealthyStateRouting
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupTargetGroupHealthBlockUnhealthyStateRoutingBlock>>("unhealthy_state_routing");
        set => SetArgument("unhealthy_state_routing", value);
    }

}

/// <summary>
/// Block type for dns_failover in AwsAlbTargetGroupTargetGroupHealthBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlockDnsFailoverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_failover";

    /// <summary>
    /// The minimum_healthy_targets_count attribute.
    /// </summary>
    public TerraformValue<string>? MinimumHealthyTargetsCount
    {
        get => new TerraformReference<string>(this, "minimum_healthy_targets_count");
        set => SetArgument("minimum_healthy_targets_count", value);
    }

    /// <summary>
    /// The minimum_healthy_targets_percentage attribute.
    /// </summary>
    public TerraformValue<string>? MinimumHealthyTargetsPercentage
    {
        get => new TerraformReference<string>(this, "minimum_healthy_targets_percentage");
        set => SetArgument("minimum_healthy_targets_percentage", value);
    }

}

/// <summary>
/// Block type for unhealthy_state_routing in AwsAlbTargetGroupTargetGroupHealthBlock.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlockUnhealthyStateRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unhealthy_state_routing";

    /// <summary>
    /// The minimum_healthy_targets_count attribute.
    /// </summary>
    public TerraformValue<double>? MinimumHealthyTargetsCount
    {
        get => new TerraformReference<double>(this, "minimum_healthy_targets_count");
        set => SetArgument("minimum_healthy_targets_count", value);
    }

    /// <summary>
    /// The minimum_healthy_targets_percentage attribute.
    /// </summary>
    public TerraformValue<string>? MinimumHealthyTargetsPercentage
    {
        get => new TerraformReference<string>(this, "minimum_healthy_targets_percentage");
        set => SetArgument("minimum_healthy_targets_percentage", value);
    }

}


/// <summary>
/// Block type for target_health_state in AwsAlbTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetHealthStateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_health_state";

    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    public required TerraformValue<bool> EnableUnhealthyConnectionTermination
    {
        get => new TerraformReference<bool>(this, "enable_unhealthy_connection_termination");
        set => SetArgument("enable_unhealthy_connection_termination", value);
    }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    public TerraformValue<double>? UnhealthyDrainingInterval
    {
        get => new TerraformReference<double>(this, "unhealthy_draining_interval");
        set => SetArgument("unhealthy_draining_interval", value);
    }

}


/// <summary>
/// Represents a aws_alb_target_group Terraform resource.
/// Manages a aws_alb_target_group resource.
/// </summary>
public partial class AwsAlbTargetGroup(string name) : TerraformResource("aws_alb_target_group", name)
{
    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformValue<bool> ConnectionTermination
    {
        get => new TerraformReference<bool>(this, "connection_termination");
        set => SetArgument("connection_termination", value);
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformValue<string>? DeregistrationDelay
    {
        get => new TerraformReference<string>(this, "deregistration_delay");
        set => SetArgument("deregistration_delay", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LambdaMultiValueHeadersEnabled
    {
        get => new TerraformReference<bool>(this, "lambda_multi_value_headers_enabled");
        set => SetArgument("lambda_multi_value_headers_enabled", value);
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAlgorithmType
    {
        get => new TerraformReference<string>(this, "load_balancing_algorithm_type");
        set => SetArgument("load_balancing_algorithm_type", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingAnomalyMitigation
    {
        get => new TerraformReference<string>(this, "load_balancing_anomaly_mitigation");
        set => SetArgument("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancingCrossZoneEnabled
    {
        get => new TerraformReference<string>(this, "load_balancing_cross_zone_enabled");
        set => SetArgument("load_balancing_cross_zone_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformValue<string> PreserveClientIp
    {
        get => new TerraformReference<string>(this, "preserve_client_ip");
        set => SetArgument("preserve_client_ip", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformValue<string> ProtocolVersion
    {
        get => new TerraformReference<string>(this, "protocol_version");
        set => SetArgument("protocol_version", value);
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformValue<bool>? ProxyProtocolV2
    {
        get => new TerraformReference<bool>(this, "proxy_protocol_v2");
        set => SetArgument("proxy_protocol_v2", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformValue<double>? SlowStart
    {
        get => new TerraformReference<double>(this, "slow_start");
        set => SetArgument("slow_start", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetType
    {
        get => new TerraformReference<string>(this, "target_type");
        set => SetArgument("target_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
    {
        get => new TerraformReference<string>(this, "arn_suffix");
    }

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformSet<string> LoadBalancerArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "load_balancer_arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public TerraformList<AwsAlbTargetGroupHealthCheckBlock>? HealthCheck
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// Stickiness block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public TerraformList<AwsAlbTargetGroupStickinessBlock>? Stickiness
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupStickinessBlock>>("stickiness");
        set => SetArgument("stickiness", value);
    }

    /// <summary>
    /// TargetFailover block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAlbTargetGroupTargetFailoverBlock>? TargetFailover
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupTargetFailoverBlock>>("target_failover");
        set => SetArgument("target_failover", value);
    }

    /// <summary>
    /// TargetGroupHealth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    public TerraformList<AwsAlbTargetGroupTargetGroupHealthBlock>? TargetGroupHealth
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupTargetGroupHealthBlock>>("target_group_health");
        set => SetArgument("target_group_health", value);
    }

    /// <summary>
    /// TargetHealthState block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAlbTargetGroupTargetHealthStateBlock>? TargetHealthState
    {
        get => GetArgument<TerraformList<AwsAlbTargetGroupTargetHealthStateBlock>>("target_health_state");
        set => SetArgument("target_health_state", value);
    }

}

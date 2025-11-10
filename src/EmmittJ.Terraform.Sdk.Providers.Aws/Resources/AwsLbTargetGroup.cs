using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsLbTargetGroupHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? HealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("healthy_threshold");
        set => WithProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        get => GetProperty<TerraformProperty<double>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    public TerraformProperty<string>? Matcher
    {
        get => GetProperty<TerraformProperty<string>>("matcher");
        set => WithProperty("matcher", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<string>? Port
    {
        get => GetProperty<TerraformProperty<string>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => WithProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyThreshold
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_threshold");
        set => WithProperty("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for stickiness in .
/// Nesting mode: list
/// </summary>
public class AwsLbTargetGroupStickinessBlock : TerraformBlock
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    public TerraformProperty<double>? CookieDuration
    {
        get => GetProperty<TerraformProperty<double>>("cookie_duration");
        set => WithProperty("cookie_duration", value);
    }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    public TerraformProperty<string>? CookieName
    {
        get => GetProperty<TerraformProperty<string>>("cookie_name");
        set => WithProperty("cookie_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for target_failover in .
/// Nesting mode: list
/// </summary>
public class AwsLbTargetGroupTargetFailoverBlock : TerraformBlock
{
    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    public required TerraformProperty<string> OnDeregistration
    {
        get => GetProperty<TerraformProperty<string>>("on_deregistration");
        set => WithProperty("on_deregistration", value);
    }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    public required TerraformProperty<string> OnUnhealthy
    {
        get => GetProperty<TerraformProperty<string>>("on_unhealthy");
        set => WithProperty("on_unhealthy", value);
    }

}

/// <summary>
/// Block type for target_group_health in .
/// Nesting mode: list
/// </summary>
public class AwsLbTargetGroupTargetGroupHealthBlock : TerraformBlock
{
}

/// <summary>
/// Block type for target_health_state in .
/// Nesting mode: list
/// </summary>
public class AwsLbTargetGroupTargetHealthStateBlock : TerraformBlock
{
    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    public required TerraformProperty<bool> EnableUnhealthyConnectionTermination
    {
        get => GetProperty<TerraformProperty<bool>>("enable_unhealthy_connection_termination");
        set => WithProperty("enable_unhealthy_connection_termination", value);
    }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyDrainingInterval
    {
        get => GetProperty<TerraformProperty<double>>("unhealthy_draining_interval");
        set => WithProperty("unhealthy_draining_interval", value);
    }

}

/// <summary>
/// Manages a aws_lb_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLbTargetGroup : TerraformResource
{
    public AwsLbTargetGroup(string name) : base("aws_lb_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_suffix");
        this.DeclareOutput("load_balancer_arns");
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? ConnectionTermination
    {
        get => GetProperty<TerraformProperty<bool>>("connection_termination");
        set => this.WithProperty("connection_termination", value);
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformProperty<string>? DeregistrationDelay
    {
        get => GetProperty<TerraformProperty<string>>("deregistration_delay");
        set => this.WithProperty("deregistration_delay", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LambdaMultiValueHeadersEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("lambda_multi_value_headers_enabled");
        set => this.WithProperty("lambda_multi_value_headers_enabled", value);
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingAlgorithmType
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_algorithm_type");
        set => this.WithProperty("load_balancing_algorithm_type", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingAnomalyMitigation
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_anomaly_mitigation");
        set => this.WithProperty("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancingCrossZoneEnabled
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_cross_zone_enabled");
        set => this.WithProperty("load_balancing_cross_zone_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PreserveClientIp
    {
        get => GetProperty<TerraformProperty<string>>("preserve_client_ip");
        set => this.WithProperty("preserve_client_ip", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformProperty<string>? ProtocolVersion
    {
        get => GetProperty<TerraformProperty<string>>("protocol_version");
        set => this.WithProperty("protocol_version", value);
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformProperty<bool>? ProxyProtocolV2
    {
        get => GetProperty<TerraformProperty<bool>>("proxy_protocol_v2");
        set => this.WithProperty("proxy_protocol_v2", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformProperty<double>? SlowStart
    {
        get => GetProperty<TerraformProperty<double>>("slow_start");
        set => this.WithProperty("slow_start", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetType
    {
        get => GetProperty<TerraformProperty<string>>("target_type");
        set => this.WithProperty("target_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public List<AwsLbTargetGroupHealthCheckBlock>? HealthCheck
    {
        get => GetProperty<List<AwsLbTargetGroupHealthCheckBlock>>("health_check");
        set => this.WithProperty("health_check", value);
    }

    /// <summary>
    /// Block for stickiness.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public List<AwsLbTargetGroupStickinessBlock>? Stickiness
    {
        get => GetProperty<List<AwsLbTargetGroupStickinessBlock>>("stickiness");
        set => this.WithProperty("stickiness", value);
    }

    /// <summary>
    /// Block for target_failover.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLbTargetGroupTargetFailoverBlock>? TargetFailover
    {
        get => GetProperty<List<AwsLbTargetGroupTargetFailoverBlock>>("target_failover");
        set => this.WithProperty("target_failover", value);
    }

    /// <summary>
    /// Block for target_group_health.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    public List<AwsLbTargetGroupTargetGroupHealthBlock>? TargetGroupHealth
    {
        get => GetProperty<List<AwsLbTargetGroupTargetGroupHealthBlock>>("target_group_health");
        set => this.WithProperty("target_group_health", value);
    }

    /// <summary>
    /// Block for target_health_state.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLbTargetGroupTargetHealthStateBlock>? TargetHealthState
    {
        get => GetProperty<List<AwsLbTargetGroupTargetHealthStateBlock>>("target_health_state");
        set => this.WithProperty("target_health_state", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

    /// <summary>
    /// The load_balancer_arns attribute.
    /// </summary>
    public TerraformExpression LoadBalancerArns => this["load_balancer_arns"];

}

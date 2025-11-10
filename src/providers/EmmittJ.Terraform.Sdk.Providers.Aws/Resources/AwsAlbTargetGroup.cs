using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_check in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? HealthyThreshold
    {
        set => SetProperty("healthy_threshold", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<double>? Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The matcher attribute.
    /// </summary>
    public TerraformProperty<string>? Matcher
    {
        set => SetProperty("matcher", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<string>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyThreshold
    {
        set => SetProperty("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for stickiness in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupStickinessBlock : TerraformBlock
{
    /// <summary>
    /// The cookie_duration attribute.
    /// </summary>
    public TerraformProperty<double>? CookieDuration
    {
        set => SetProperty("cookie_duration", value);
    }

    /// <summary>
    /// The cookie_name attribute.
    /// </summary>
    public TerraformProperty<string>? CookieName
    {
        set => SetProperty("cookie_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for target_failover in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetFailoverBlock : TerraformBlock
{
    /// <summary>
    /// The on_deregistration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnDeregistration is required")]
    public required TerraformProperty<string> OnDeregistration
    {
        set => SetProperty("on_deregistration", value);
    }

    /// <summary>
    /// The on_unhealthy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OnUnhealthy is required")]
    public required TerraformProperty<string> OnUnhealthy
    {
        set => SetProperty("on_unhealthy", value);
    }

}

/// <summary>
/// Block type for target_group_health in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetGroupHealthBlock : TerraformBlock
{
}

/// <summary>
/// Block type for target_health_state in .
/// Nesting mode: list
/// </summary>
public class AwsAlbTargetGroupTargetHealthStateBlock : TerraformBlock
{
    /// <summary>
    /// The enable_unhealthy_connection_termination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableUnhealthyConnectionTermination is required")]
    public required TerraformProperty<bool> EnableUnhealthyConnectionTermination
    {
        set => SetProperty("enable_unhealthy_connection_termination", value);
    }

    /// <summary>
    /// The unhealthy_draining_interval attribute.
    /// </summary>
    public TerraformProperty<double>? UnhealthyDrainingInterval
    {
        set => SetProperty("unhealthy_draining_interval", value);
    }

}

/// <summary>
/// Manages a aws_alb_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlbTargetGroup : TerraformResource
{
    public AwsAlbTargetGroup(string name) : base("aws_alb_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("arn_suffix");
        SetOutput("load_balancer_arns");
        SetOutput("connection_termination");
        SetOutput("deregistration_delay");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("lambda_multi_value_headers_enabled");
        SetOutput("load_balancing_algorithm_type");
        SetOutput("load_balancing_anomaly_mitigation");
        SetOutput("load_balancing_cross_zone_enabled");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("port");
        SetOutput("preserve_client_ip");
        SetOutput("protocol");
        SetOutput("protocol_version");
        SetOutput("proxy_protocol_v2");
        SetOutput("region");
        SetOutput("slow_start");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_type");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The connection_termination attribute.
    /// </summary>
    public TerraformProperty<bool> ConnectionTermination
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("connection_termination");
        set => SetProperty("connection_termination", value);
    }

    /// <summary>
    /// The deregistration_delay attribute.
    /// </summary>
    public TerraformProperty<string> DeregistrationDelay
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deregistration_delay");
        set => SetProperty("deregistration_delay", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The lambda_multi_value_headers_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LambdaMultiValueHeadersEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("lambda_multi_value_headers_enabled");
        set => SetProperty("lambda_multi_value_headers_enabled", value);
    }

    /// <summary>
    /// The load_balancing_algorithm_type attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancingAlgorithmType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancing_algorithm_type");
        set => SetProperty("load_balancing_algorithm_type", value);
    }

    /// <summary>
    /// The load_balancing_anomaly_mitigation attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancingAnomalyMitigation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancing_anomaly_mitigation");
        set => SetProperty("load_balancing_anomaly_mitigation", value);
    }

    /// <summary>
    /// The load_balancing_cross_zone_enabled attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancingCrossZoneEnabled
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancing_cross_zone_enabled");
        set => SetProperty("load_balancing_cross_zone_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The preserve_client_ip attribute.
    /// </summary>
    public TerraformProperty<string> PreserveClientIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("preserve_client_ip");
        set => SetProperty("preserve_client_ip", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The protocol_version attribute.
    /// </summary>
    public TerraformProperty<string> ProtocolVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol_version");
        set => SetProperty("protocol_version", value);
    }

    /// <summary>
    /// The proxy_protocol_v2 attribute.
    /// </summary>
    public TerraformProperty<bool> ProxyProtocolV2
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("proxy_protocol_v2");
        set => SetProperty("proxy_protocol_v2", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The slow_start attribute.
    /// </summary>
    public TerraformProperty<double> SlowStart
    {
        get => GetRequiredOutput<TerraformProperty<double>>("slow_start");
        set => SetProperty("slow_start", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string> TargetType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_type");
        set => SetProperty("target_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for health_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public List<AwsAlbTargetGroupHealthCheckBlock>? HealthCheck
    {
        set => SetProperty("health_check", value);
    }

    /// <summary>
    /// Block for stickiness.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Stickiness block(s) allowed")]
    public List<AwsAlbTargetGroupStickinessBlock>? Stickiness
    {
        set => SetProperty("stickiness", value);
    }

    /// <summary>
    /// Block for target_failover.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAlbTargetGroupTargetFailoverBlock>? TargetFailover
    {
        set => SetProperty("target_failover", value);
    }

    /// <summary>
    /// Block for target_group_health.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetGroupHealth block(s) allowed")]
    public List<AwsAlbTargetGroupTargetGroupHealthBlock>? TargetGroupHealth
    {
        set => SetProperty("target_group_health", value);
    }

    /// <summary>
    /// Block for target_health_state.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAlbTargetGroupTargetHealthStateBlock>? TargetHealthState
    {
        set => SetProperty("target_health_state", value);
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

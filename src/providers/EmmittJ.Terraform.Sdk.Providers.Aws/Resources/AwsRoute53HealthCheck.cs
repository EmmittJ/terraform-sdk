using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_health_check Terraform resource.
/// Manages a aws_route53_health_check resource.
/// </summary>
public partial class AwsRoute53HealthCheck(string name) : TerraformResource("aws_route53_health_check", name)
{
    /// <summary>
    /// The child_health_threshold attribute.
    /// </summary>
    public TerraformValue<double>? ChildHealthThreshold
    {
        get => GetArgument<TerraformValue<double>>("child_health_threshold");
        set => SetArgument("child_health_threshold", value);
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public TerraformSet<string>? ChildHealthchecks
    {
        get => GetArgument<TerraformSet<string>>("child_healthchecks");
        set => SetArgument("child_healthchecks", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchAlarmName
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_alarm_name");
        set => SetArgument("cloudwatch_alarm_name", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchAlarmRegion
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_alarm_region");
        set => SetArgument("cloudwatch_alarm_region", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public TerraformValue<bool> EnableSni
    {
        get => GetArgument<TerraformValue<bool>>("enable_sni") ?? AsReference("enable_sni");
        set => SetArgument("enable_sni", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformValue<double> FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold") ?? AsReference("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => GetArgument<TerraformValue<string>>("fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public TerraformValue<string>? InsufficientDataHealthStatus
    {
        get => GetArgument<TerraformValue<string>>("insufficient_data_health_status");
        set => SetArgument("insufficient_data_health_status", value);
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public TerraformValue<bool>? InvertHealthcheck
    {
        get => GetArgument<TerraformValue<bool>>("invert_healthcheck");
        set => SetArgument("invert_healthcheck", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public TerraformValue<bool>? MeasureLatency
    {
        get => GetArgument<TerraformValue<bool>>("measure_latency");
        set => SetArgument("measure_latency", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceName
    {
        get => GetArgument<TerraformValue<string>>("reference_name");
        set => SetArgument("reference_name", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public TerraformValue<double>? RequestInterval
    {
        get => GetArgument<TerraformValue<double>>("request_interval");
        set => SetArgument("request_interval", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformValue<string>? ResourcePath
    {
        get => GetArgument<TerraformValue<string>>("resource_path");
        set => SetArgument("resource_path", value);
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoutingControlArn
    {
        get => GetArgument<TerraformValue<string>>("routing_control_arn");
        set => SetArgument("routing_control_arn", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformValue<string>? SearchString
    {
        get => GetArgument<TerraformValue<string>>("search_string");
        set => SetArgument("search_string", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string> Triggers
    {
        get => GetArgument<TerraformMap<string>>("triggers") ?? AsReference("triggers");
        set => SetArgument("triggers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}

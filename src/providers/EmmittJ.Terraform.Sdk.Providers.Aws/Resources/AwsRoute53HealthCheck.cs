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
        get => new TerraformReference<double>(this, "child_health_threshold");
        set => SetArgument("child_health_threshold", value);
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public TerraformSet<string>? ChildHealthchecks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "child_healthchecks").ResolveNodes(ctx));
        set => SetArgument("child_healthchecks", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchAlarmName
    {
        get => new TerraformReference<string>(this, "cloudwatch_alarm_name");
        set => SetArgument("cloudwatch_alarm_name", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public TerraformValue<string>? CloudwatchAlarmRegion
    {
        get => new TerraformReference<string>(this, "cloudwatch_alarm_region");
        set => SetArgument("cloudwatch_alarm_region", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public TerraformValue<bool> EnableSni
    {
        get => new TerraformReference<bool>(this, "enable_sni");
        set => SetArgument("enable_sni", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformValue<double> FailureThreshold
    {
        get => new TerraformReference<double>(this, "failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string>? Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
        set => SetArgument("fqdn", value);
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
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public TerraformValue<string>? InsufficientDataHealthStatus
    {
        get => new TerraformReference<string>(this, "insufficient_data_health_status");
        set => SetArgument("insufficient_data_health_status", value);
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public TerraformValue<bool>? InvertHealthcheck
    {
        get => new TerraformReference<bool>(this, "invert_healthcheck");
        set => SetArgument("invert_healthcheck", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string>? IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public TerraformValue<bool>? MeasureLatency
    {
        get => new TerraformReference<bool>(this, "measure_latency");
        set => SetArgument("measure_latency", value);
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
    /// The reference_name attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceName
    {
        get => new TerraformReference<string>(this, "reference_name");
        set => SetArgument("reference_name", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public TerraformValue<double>? RequestInterval
    {
        get => new TerraformReference<double>(this, "request_interval");
        set => SetArgument("request_interval", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformValue<string>? ResourcePath
    {
        get => new TerraformReference<string>(this, "resource_path");
        set => SetArgument("resource_path", value);
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoutingControlArn
    {
        get => new TerraformReference<string>(this, "routing_control_arn");
        set => SetArgument("routing_control_arn", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformValue<string>? SearchString
    {
        get => new TerraformReference<string>(this, "search_string");
        set => SetArgument("search_string", value);
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
    /// The triggers attribute.
    /// </summary>
    public TerraformMap<string> Triggers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "triggers").ResolveNodes(ctx));
        set => SetArgument("triggers", value);
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

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}

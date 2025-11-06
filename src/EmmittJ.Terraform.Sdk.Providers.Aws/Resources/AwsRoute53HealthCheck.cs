using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_health_check resource.
/// </summary>
public class AwsRoute53HealthCheck : TerraformResource
{
    public AwsRoute53HealthCheck(string name) : base("aws_route53_health_check", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The child_health_threshold attribute.
    /// </summary>
    public double? ChildHealthThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("child_health_threshold")?.Value;
        set => this.WithProperty("child_health_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public HashSet<string>? ChildHealthchecks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("child_healthchecks")?.Value;
        set => this.WithProperty("child_healthchecks", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public string? CloudwatchAlarmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_alarm_name")?.Value;
        set => this.WithProperty("cloudwatch_alarm_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public string? CloudwatchAlarmRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_alarm_region")?.Value;
        set => this.WithProperty("cloudwatch_alarm_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public bool? EnableSni
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_sni")?.Value;
        set => this.WithProperty("enable_sni", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public double? FailureThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failure_threshold")?.Value;
        set => this.WithProperty("failure_threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public string? Fqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fqdn")?.Value;
        set => this.WithProperty("fqdn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public string? InsufficientDataHealthStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("insufficient_data_health_status")?.Value;
        set => this.WithProperty("insufficient_data_health_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public bool? InvertHealthcheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("invert_healthcheck")?.Value;
        set => this.WithProperty("invert_healthcheck", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public string? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address")?.Value;
        set => this.WithProperty("ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public bool? MeasureLatency
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("measure_latency")?.Value;
        set => this.WithProperty("measure_latency", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    public string? ReferenceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reference_name")?.Value;
        set => this.WithProperty("reference_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<string>? Regions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("regions")?.Value;
        set => this.WithProperty("regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public double? RequestInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("request_interval")?.Value;
        set => this.WithProperty("request_interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public string? ResourcePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_path")?.Value;
        set => this.WithProperty("resource_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public string? RoutingControlArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_control_arn")?.Value;
        set => this.WithProperty("routing_control_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public string? SearchString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("search_string")?.Value;
        set => this.WithProperty("search_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

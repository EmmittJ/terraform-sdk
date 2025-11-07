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
    public TerraformLiteralProperty<double>? ChildHealthThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("child_health_threshold");
        set => this.WithProperty("child_health_threshold", value);
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ChildHealthchecks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("child_healthchecks");
        set => this.WithProperty("child_healthchecks", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CloudwatchAlarmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_alarm_name");
        set => this.WithProperty("cloudwatch_alarm_name", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CloudwatchAlarmRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloudwatch_alarm_region");
        set => this.WithProperty("cloudwatch_alarm_region", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableSni
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_sni");
        set => this.WithProperty("enable_sni", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? FailureThreshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("failure_threshold");
        set => this.WithProperty("failure_threshold", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Fqdn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fqdn");
        set => this.WithProperty("fqdn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InsufficientDataHealthStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("insufficient_data_health_status");
        set => this.WithProperty("insufficient_data_health_status", value);
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InvertHealthcheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("invert_healthcheck");
        set => this.WithProperty("invert_healthcheck", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MeasureLatency
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("measure_latency");
        set => this.WithProperty("measure_latency", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReferenceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reference_name");
        set => this.WithProperty("reference_name", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Regions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RequestInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("request_interval");
        set => this.WithProperty("request_interval", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourcePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_path");
        set => this.WithProperty("resource_path", value);
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoutingControlArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_control_arn");
        set => this.WithProperty("routing_control_arn", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SearchString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("search_string");
        set => this.WithProperty("search_string", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

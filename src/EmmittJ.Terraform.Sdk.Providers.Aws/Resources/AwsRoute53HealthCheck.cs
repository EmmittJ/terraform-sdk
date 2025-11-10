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
    public TerraformProperty<double>? ChildHealthThreshold
    {
        get => GetProperty<TerraformProperty<double>>("child_health_threshold");
        set => this.WithProperty("child_health_threshold", value);
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ChildHealthchecks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("child_healthchecks");
        set => this.WithProperty("child_healthchecks", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchAlarmName
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_alarm_name");
        set => this.WithProperty("cloudwatch_alarm_name", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchAlarmRegion
    {
        get => GetProperty<TerraformProperty<string>>("cloudwatch_alarm_region");
        set => this.WithProperty("cloudwatch_alarm_region", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSni
    {
        get => GetProperty<TerraformProperty<bool>>("enable_sni");
        set => this.WithProperty("enable_sni", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? FailureThreshold
    {
        get => GetProperty<TerraformProperty<double>>("failure_threshold");
        set => this.WithProperty("failure_threshold", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        get => GetProperty<TerraformProperty<string>>("fqdn");
        set => this.WithProperty("fqdn", value);
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
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public TerraformProperty<string>? InsufficientDataHealthStatus
    {
        get => GetProperty<TerraformProperty<string>>("insufficient_data_health_status");
        set => this.WithProperty("insufficient_data_health_status", value);
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public TerraformProperty<bool>? InvertHealthcheck
    {
        get => GetProperty<TerraformProperty<bool>>("invert_healthcheck");
        set => this.WithProperty("invert_healthcheck", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public TerraformProperty<bool>? MeasureLatency
    {
        get => GetProperty<TerraformProperty<bool>>("measure_latency");
        set => this.WithProperty("measure_latency", value);
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
    /// The reference_name attribute.
    /// </summary>
    public TerraformProperty<string>? ReferenceName
    {
        get => GetProperty<TerraformProperty<string>>("reference_name");
        set => this.WithProperty("reference_name", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Regions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public TerraformProperty<double>? RequestInterval
    {
        get => GetProperty<TerraformProperty<double>>("request_interval");
        set => this.WithProperty("request_interval", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformProperty<string>? ResourcePath
    {
        get => GetProperty<TerraformProperty<string>>("resource_path");
        set => this.WithProperty("resource_path", value);
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingControlArn
    {
        get => GetProperty<TerraformProperty<string>>("routing_control_arn");
        set => this.WithProperty("routing_control_arn", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformProperty<string>? SearchString
    {
        get => GetProperty<TerraformProperty<string>>("search_string");
        set => this.WithProperty("search_string", value);
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
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Triggers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

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
        SetOutput("arn");
        SetOutput("child_health_threshold");
        SetOutput("child_healthchecks");
        SetOutput("cloudwatch_alarm_name");
        SetOutput("cloudwatch_alarm_region");
        SetOutput("disabled");
        SetOutput("enable_sni");
        SetOutput("failure_threshold");
        SetOutput("fqdn");
        SetOutput("id");
        SetOutput("insufficient_data_health_status");
        SetOutput("invert_healthcheck");
        SetOutput("ip_address");
        SetOutput("measure_latency");
        SetOutput("port");
        SetOutput("reference_name");
        SetOutput("regions");
        SetOutput("request_interval");
        SetOutput("resource_path");
        SetOutput("routing_control_arn");
        SetOutput("search_string");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("triggers");
        SetOutput("type");
    }

    /// <summary>
    /// The child_health_threshold attribute.
    /// </summary>
    public TerraformProperty<double> ChildHealthThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("child_health_threshold");
        set => SetProperty("child_health_threshold", value);
    }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ChildHealthchecks
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("child_healthchecks");
        set => SetProperty("child_healthchecks", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    public TerraformProperty<string> CloudwatchAlarmName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudwatch_alarm_name");
        set => SetProperty("cloudwatch_alarm_name", value);
    }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    public TerraformProperty<string> CloudwatchAlarmRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloudwatch_alarm_region");
        set => SetProperty("cloudwatch_alarm_region", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    public TerraformProperty<bool> EnableSni
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_sni");
        set => SetProperty("enable_sni", value);
    }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    public TerraformProperty<double> FailureThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("failure_threshold");
        set => SetProperty("failure_threshold", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformProperty<string> Fqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fqdn");
        set => SetProperty("fqdn", value);
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
    /// The insufficient_data_health_status attribute.
    /// </summary>
    public TerraformProperty<string> InsufficientDataHealthStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("insufficient_data_health_status");
        set => SetProperty("insufficient_data_health_status", value);
    }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    public TerraformProperty<bool> InvertHealthcheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("invert_healthcheck");
        set => SetProperty("invert_healthcheck", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
    }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    public TerraformProperty<bool> MeasureLatency
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("measure_latency");
        set => SetProperty("measure_latency", value);
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
    /// The reference_name attribute.
    /// </summary>
    public TerraformProperty<string> ReferenceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reference_name");
        set => SetProperty("reference_name", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Regions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("regions");
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    public TerraformProperty<double> RequestInterval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("request_interval");
        set => SetProperty("request_interval", value);
    }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    public TerraformProperty<string> ResourcePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_path");
        set => SetProperty("resource_path", value);
    }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoutingControlArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_control_arn");
        set => SetProperty("routing_control_arn", value);
    }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    public TerraformProperty<string> SearchString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("search_string");
        set => SetProperty("search_string", value);
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
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_events_config in .
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorHealthEventsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The availability_score_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? AvailabilityScoreThreshold
    {
        get => GetProperty<TerraformProperty<double>>("availability_score_threshold");
        set => WithProperty("availability_score_threshold", value);
    }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? PerformanceScoreThreshold
    {
        get => GetProperty<TerraformProperty<double>>("performance_score_threshold");
        set => WithProperty("performance_score_threshold", value);
    }

}

/// <summary>
/// Block type for internet_measurements_log_delivery in .
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_internetmonitor_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsInternetmonitorMonitor : TerraformResource
{
    public AwsInternetmonitorMonitor(string name) : base("aws_internetmonitor_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCityNetworksToMonitor
    {
        get => GetProperty<TerraformProperty<double>>("max_city_networks_to_monitor");
        set => this.WithProperty("max_city_networks_to_monitor", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformProperty<string> MonitorName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("monitor_name");
        set => this.WithProperty("monitor_name", value);
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
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Resources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resources");
        set => this.WithProperty("resources", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double>? TrafficPercentageToMonitor
    {
        get => GetProperty<TerraformProperty<double>>("traffic_percentage_to_monitor");
        set => this.WithProperty("traffic_percentage_to_monitor", value);
    }

    /// <summary>
    /// Block for health_events_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthEventsConfig block(s) allowed")]
    public List<AwsInternetmonitorMonitorHealthEventsConfigBlock>? HealthEventsConfig
    {
        get => GetProperty<List<AwsInternetmonitorMonitorHealthEventsConfigBlock>>("health_events_config");
        set => this.WithProperty("health_events_config", value);
    }

    /// <summary>
    /// Block for internet_measurements_log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetMeasurementsLogDelivery block(s) allowed")]
    public List<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>? InternetMeasurementsLogDelivery
    {
        get => GetProperty<List<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>>("internet_measurements_log_delivery");
        set => this.WithProperty("internet_measurements_log_delivery", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

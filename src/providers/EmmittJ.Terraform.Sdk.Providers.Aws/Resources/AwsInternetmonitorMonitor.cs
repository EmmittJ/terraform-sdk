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
        set => SetProperty("availability_score_threshold", value);
    }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? PerformanceScoreThreshold
    {
        set => SetProperty("performance_score_threshold", value);
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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("max_city_networks_to_monitor");
        SetOutput("monitor_name");
        SetOutput("region");
        SetOutput("resources");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("traffic_percentage_to_monitor");
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
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double> MaxCityNetworksToMonitor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_city_networks_to_monitor");
        set => SetProperty("max_city_networks_to_monitor", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformProperty<string> MonitorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_name");
        set => SetProperty("monitor_name", value);
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
    /// The resources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Resources
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resources");
        set => SetProperty("resources", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double> TrafficPercentageToMonitor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("traffic_percentage_to_monitor");
        set => SetProperty("traffic_percentage_to_monitor", value);
    }

    /// <summary>
    /// Block for health_events_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthEventsConfig block(s) allowed")]
    public List<AwsInternetmonitorMonitorHealthEventsConfigBlock>? HealthEventsConfig
    {
        set => SetProperty("health_events_config", value);
    }

    /// <summary>
    /// Block for internet_measurements_log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetMeasurementsLogDelivery block(s) allowed")]
    public List<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>? InternetMeasurementsLogDelivery
    {
        set => SetProperty("internet_measurements_log_delivery", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

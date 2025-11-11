using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_events_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsInternetmonitorMonitorHealthEventsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The availability_score_threshold attribute.
    /// </summary>
    [TerraformProperty("availability_score_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? AvailabilityScoreThreshold { get; set; }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    [TerraformProperty("performance_score_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PerformanceScoreThreshold { get; set; }

}

/// <summary>
/// Block type for internet_measurements_log_delivery in .
/// Nesting mode: list
/// </summary>
public partial class AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_internetmonitor_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsInternetmonitorMonitor : TerraformResource
{
    public AwsInternetmonitorMonitor(string name) : base("aws_internetmonitor_monitor", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    [TerraformProperty("max_city_networks_to_monitor")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxCityNetworksToMonitor { get; set; }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    [TerraformProperty("monitor_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MonitorName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformProperty("resources")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    [TerraformProperty("traffic_percentage_to_monitor")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TrafficPercentageToMonitor { get; set; }

    /// <summary>
    /// Block for health_events_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthEventsConfig block(s) allowed")]
    [TerraformProperty("health_events_config")]
    public TerraformList<TerraformBlock<AwsInternetmonitorMonitorHealthEventsConfigBlock>>? HealthEventsConfig { get; set; }

    /// <summary>
    /// Block for internet_measurements_log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetMeasurementsLogDelivery block(s) allowed")]
    [TerraformProperty("internet_measurements_log_delivery")]
    public TerraformList<TerraformBlock<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>>? InternetMeasurementsLogDelivery { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}

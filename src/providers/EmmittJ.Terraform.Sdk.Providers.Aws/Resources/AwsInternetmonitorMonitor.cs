using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_events_config in .
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorHealthEventsConfigBlock
{
    /// <summary>
    /// The availability_score_threshold attribute.
    /// </summary>
    [TerraformPropertyName("availability_score_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AvailabilityScoreThreshold { get; set; }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    [TerraformPropertyName("performance_score_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PerformanceScoreThreshold { get; set; }

}

/// <summary>
/// Block type for internet_measurements_log_delivery in .
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    [TerraformPropertyName("max_city_networks_to_monitor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxCityNetworksToMonitor { get; set; }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    [TerraformPropertyName("monitor_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MonitorName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resources attribute.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Resources { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    [TerraformPropertyName("traffic_percentage_to_monitor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TrafficPercentageToMonitor { get; set; }

    /// <summary>
    /// Block for health_events_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthEventsConfig block(s) allowed")]
    [TerraformPropertyName("health_events_config")]
    public TerraformList<TerraformBlock<AwsInternetmonitorMonitorHealthEventsConfigBlock>>? HealthEventsConfig { get; set; }

    /// <summary>
    /// Block for internet_measurements_log_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetMeasurementsLogDelivery block(s) allowed")]
    [TerraformPropertyName("internet_measurements_log_delivery")]
    public TerraformList<TerraformBlock<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>>? InternetMeasurementsLogDelivery { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}

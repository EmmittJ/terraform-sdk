using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStreamAnalyticsJobDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_stream_analytics_job.
/// </summary>
public partial class AzurermStreamAnalyticsJobDataSource : TerraformDataSource
{
    public AzurermStreamAnalyticsJobDataSource(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsJobDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformProperty("compatibility_level")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CompatibilityLevel { get; }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformProperty("data_locale")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataLocale { get; }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformProperty("events_late_arrival_max_delay_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EventsLateArrivalMaxDelayInSeconds { get; }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformProperty("events_out_of_order_max_delay_in_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EventsOutOfOrderMaxDelayInSeconds { get; }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformProperty("events_out_of_order_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EventsOutOfOrderPolicy { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformProperty("job_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JobId { get; }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    [TerraformProperty("last_output_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastOutputTime { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformProperty("output_error_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutputErrorPolicy { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    [TerraformProperty("start_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StartMode { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformProperty("streaming_units")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StreamingUnits { get; }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [TerraformProperty("transformation_query")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TransformationQuery { get; }

}

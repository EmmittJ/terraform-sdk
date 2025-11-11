using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_stream_analytics_job.
/// </summary>
public class AzurermStreamAnalyticsJobDataSource : TerraformDataSource
{
    public AzurermStreamAnalyticsJobDataSource(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsJobDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformPropertyName("compatibility_level")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompatibilityLevel => new TerraformReference(this, "compatibility_level");

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformPropertyName("data_locale")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataLocale => new TerraformReference(this, "data_locale");

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_late_arrival_max_delay_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EventsLateArrivalMaxDelayInSeconds => new TerraformReference(this, "events_late_arrival_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_max_delay_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EventsOutOfOrderMaxDelayInSeconds => new TerraformReference(this, "events_out_of_order_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventsOutOfOrderPolicy => new TerraformReference(this, "events_out_of_order_policy");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobId => new TerraformReference(this, "job_id");

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    [TerraformPropertyName("last_output_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastOutputTime => new TerraformReference(this, "last_output_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformPropertyName("output_error_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutputErrorPolicy => new TerraformReference(this, "output_error_policy");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    [TerraformPropertyName("start_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartMode => new TerraformReference(this, "start_mode");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartTime => new TerraformReference(this, "start_time");

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformPropertyName("streaming_units")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StreamingUnits => new TerraformReference(this, "streaming_units");

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [TerraformPropertyName("transformation_query")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TransformationQuery => new TerraformReference(this, "transformation_query");

}

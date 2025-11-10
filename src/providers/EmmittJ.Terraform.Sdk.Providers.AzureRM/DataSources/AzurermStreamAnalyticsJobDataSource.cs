using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStreamAnalyticsJobDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformPropertyName("compatibility_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompatibilityLevel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compatibility_level");

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformPropertyName("data_locale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataLocale => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_locale");

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_late_arrival_max_delay_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EventsLateArrivalMaxDelayInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "events_late_arrival_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_max_delay_in_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EventsOutOfOrderMaxDelayInSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "events_out_of_order_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformPropertyName("events_out_of_order_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EventsOutOfOrderPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "events_out_of_order_policy");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_id");

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    [TerraformPropertyName("last_output_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastOutputTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_output_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformPropertyName("output_error_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutputErrorPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_error_policy");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    [TerraformPropertyName("start_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_mode");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformPropertyName("streaming_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StreamingUnits => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "streaming_units");

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [TerraformPropertyName("transformation_query")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TransformationQuery => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "transformation_query");

}

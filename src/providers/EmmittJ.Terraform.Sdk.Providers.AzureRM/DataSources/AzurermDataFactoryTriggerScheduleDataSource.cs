using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_data_factory_trigger_schedule.
/// </summary>
public class AzurermDataFactoryTriggerScheduleDataSource : TerraformDataSource
{
    public AzurermDataFactoryTriggerScheduleDataSource(string name) : base("azurerm_data_factory_trigger_schedule", name)
    {
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryTriggerScheduleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformPropertyName("activated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Activated => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "activated");

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Annotations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "annotations");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_time");

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Frequency => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "frequency");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Interval => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "interval");

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    [TerraformPropertyName("pipeline_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PipelineName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pipeline_name");

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Schedule => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schedule");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for pipeline in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowPipelineBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

}

/// <summary>
/// Block type for retry in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowRetryBlock : ITerraformBlock
{
    /// <summary>
    /// The count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Interval { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for trigger_dependency in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock : ITerraformBlock
{
    /// <summary>
    /// The offset attribute.
    /// </summary>
    [TerraformPropertyName("offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Offset { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Size { get; set; }

    /// <summary>
    /// The trigger_name attribute.
    /// </summary>
    [TerraformPropertyName("trigger_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TriggerName { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_trigger_tumbling_window resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactoryTriggerTumblingWindow : TerraformResource
{
    public AzurermDataFactoryTriggerTumblingWindow(string name) : base("azurerm_data_factory_trigger_tumbling_window", name)
    {
    }

    /// <summary>
    /// The activated attribute.
    /// </summary>
    [TerraformPropertyName("activated")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Activated { get; set; }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformPropertyName("data_factory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataFactoryId { get; set; }

    /// <summary>
    /// The delay attribute.
    /// </summary>
    [TerraformPropertyName("delay")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delay { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndTime { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    [TerraformPropertyName("frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [TerraformPropertyName("interval")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Interval { get; set; }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrency { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartTime { get; set; }

    /// <summary>
    /// Block for pipeline.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pipeline is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Pipeline block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pipeline block(s) allowed")]
    [TerraformPropertyName("pipeline")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowPipelineBlock>>? Pipeline { get; set; } = new();

    /// <summary>
    /// Block for retry.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    [TerraformPropertyName("retry")]
    public TerraformList<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowRetryBlock>>? Retry { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataFactoryTriggerTumblingWindowTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for trigger_dependency.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("trigger_dependency")]
    public TerraformSet<TerraformBlock<AzurermDataFactoryTriggerTumblingWindowTriggerDependencyBlock>>? TriggerDependency { get; set; } = new();

}

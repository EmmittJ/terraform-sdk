using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The start_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDay is required")]
    [TerraformPropertyName("start_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartDay { get; set; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [TerraformPropertyName("start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StartTime { get; set; }

    /// <summary>
    /// The stop_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopDay is required")]
    [TerraformPropertyName("stop_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StopDay { get; set; }

    /// <summary>
    /// The stop_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopTime is required")]
    [TerraformPropertyName("stop_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StopTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstanceStartStopSchedule : TerraformResource
{
    public AzurermMssqlManagedInstanceStartStopSchedule(string name) : base("azurerm_mssql_managed_instance_start_stop_schedule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformPropertyName("managed_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ManagedInstanceId { get; set; }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    [TerraformPropertyName("timezone_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimezoneId { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    [TerraformPropertyName("next_execution_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextExecutionTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_execution_time");

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    [TerraformPropertyName("next_run_action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextRunAction => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "next_run_action");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock : TerraformBlock
{
    /// <summary>
    /// The start_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDay is required")]
    public required TerraformProperty<string> StartDay
    {
        get => GetRequiredProperty<TerraformProperty<string>>("start_day");
        set => WithProperty("start_day", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformProperty<string> StartTime
    {
        get => GetRequiredProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

    /// <summary>
    /// The stop_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopDay is required")]
    public required TerraformProperty<string> StopDay
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stop_day");
        set => WithProperty("stop_day", value);
    }

    /// <summary>
    /// The stop_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StopTime is required")]
    public required TerraformProperty<string> StopTime
    {
        get => GetRequiredProperty<TerraformProperty<string>>("stop_time");
        set => WithProperty("stop_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlManagedInstanceStartStopSchedule : TerraformResource
{
    public AzurermMssqlManagedInstanceStartStopSchedule(string name) : base("azurerm_mssql_managed_instance_start_stop_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("next_execution_time");
        this.WithOutput("next_run_action");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformProperty<string> ManagedInstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformProperty<string>? TimezoneId
    {
        get => GetProperty<TerraformProperty<string>>("timezone_id");
        set => this.WithProperty("timezone_id", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    public List<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock>? Schedule
    {
        get => GetProperty<List<AzurermMssqlManagedInstanceStartStopScheduleScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlManagedInstanceStartStopScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    public TerraformExpression NextExecutionTime => this["next_execution_time"];

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    public TerraformExpression NextRunAction => this["next_run_action"];

}

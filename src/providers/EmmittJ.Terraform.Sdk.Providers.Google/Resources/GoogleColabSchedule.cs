using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for create_notebook_execution_job_request in .
/// Nesting mode: list
/// </summary>
public class GoogleColabScheduleCreateNotebookExecutionJobRequestBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_colab_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabSchedule : TerraformResource
{
    public GoogleColabSchedule(string name) : base("google_colab_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("state");
        SetOutput("allow_queueing");
        SetOutput("cron");
        SetOutput("desired_state");
        SetOutput("display_name");
        SetOutput("end_time");
        SetOutput("id");
        SetOutput("location");
        SetOutput("max_concurrent_run_count");
        SetOutput("max_run_count");
        SetOutput("project");
        SetOutput("start_time");
    }

    /// <summary>
    /// Whether new scheduled runs can be queued when max_concurrent_runs limit is reached. If set to true, new runs will be queued instead of skipped. Default to false.
    /// </summary>
    public TerraformProperty<bool> AllowQueueing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_queueing");
        set => SetProperty("allow_queueing", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cron is required")]
    public required TerraformProperty<string> Cron
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cron");
        set => SetProperty("cron", value);
    }

    /// <summary>
    /// Desired state of the Colab Schedule. Set this field to &#39;ACTIVE&#39; to start/resume the schedule, and &#39;PAUSED&#39; to pause the schedule.
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Schedule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Timestamp after which no new runs can be scheduled. If specified, the schedule will be completed when either end_time is reached or when scheduled_run_count &amp;gt;= max_run_count. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformProperty<string> EndTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("end_time");
        set => SetProperty("end_time", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Maximum number of runs that can be started concurrently for this Schedule. This is the limit for starting the scheduled requests and not the execution of the notebook execution jobs created by the requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConcurrentRunCount is required")]
    public required TerraformProperty<string> MaxConcurrentRunCount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_concurrent_run_count");
        set => SetProperty("max_concurrent_run_count", value);
    }

    /// <summary>
    /// Maximum run count of the schedule. If specified, The schedule will be completed when either startedRunCount &amp;gt;= maxRunCount or when endTime is reached. If not specified, new runs will keep getting scheduled until this Schedule is paused or deleted. Already scheduled runs will be allowed to complete. Unset if not specified.
    /// </summary>
    public TerraformProperty<string> MaxRunCount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_run_count");
        set => SetProperty("max_run_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The timestamp after which the first run can be scheduled. Defaults to the schedule creation time. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformProperty<string> StartTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_time");
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// Block for create_notebook_execution_job_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateNotebookExecutionJobRequest is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CreateNotebookExecutionJobRequest block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateNotebookExecutionJobRequest block(s) allowed")]
    public List<GoogleColabScheduleCreateNotebookExecutionJobRequestBlock>? CreateNotebookExecutionJobRequest
    {
        set => SetProperty("create_notebook_execution_job_request", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabScheduleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the Schedule
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The state of the schedule.
    /// </summary>
    public TerraformExpression State => this["state"];

}

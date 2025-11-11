using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for create_notebook_execution_job_request in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabScheduleCreateNotebookExecutionJobRequestBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleColabScheduleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_colab_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleColabSchedule : TerraformResource
{
    public GoogleColabSchedule(string name) : base("google_colab_schedule", name)
    {
    }

    /// <summary>
    /// Whether new scheduled runs can be queued when max_concurrent_runs limit is reached. If set to true, new runs will be queued instead of skipped. Default to false.
    /// </summary>
    [TerraformProperty("allow_queueing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowQueueing { get; set; }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cron is required")]
    [TerraformProperty("cron")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Cron { get; set; }

    /// <summary>
    /// Desired state of the Colab Schedule. Set this field to &#39;ACTIVE&#39; to start/resume the schedule, and &#39;PAUSED&#39; to pause the schedule.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Required. The display name of the Schedule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Timestamp after which no new runs can be scheduled. If specified, the schedule will be completed when either end_time is reached or when scheduled_run_count &amp;gt;= max_run_count. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Maximum number of runs that can be started concurrently for this Schedule. This is the limit for starting the scheduled requests and not the execution of the notebook execution jobs created by the requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConcurrentRunCount is required")]
    [TerraformProperty("max_concurrent_run_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MaxConcurrentRunCount { get; set; }

    /// <summary>
    /// Maximum run count of the schedule. If specified, The schedule will be completed when either startedRunCount &amp;gt;= maxRunCount or when endTime is reached. If not specified, new runs will keep getting scheduled until this Schedule is paused or deleted. Already scheduled runs will be allowed to complete. Unset if not specified.
    /// </summary>
    [TerraformProperty("max_run_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxRunCount { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The timestamp after which the first run can be scheduled. Defaults to the schedule creation time. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StartTime { get; set; }

    /// <summary>
    /// Block for create_notebook_execution_job_request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateNotebookExecutionJobRequest is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CreateNotebookExecutionJobRequest block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateNotebookExecutionJobRequest block(s) allowed")]
    [TerraformProperty("create_notebook_execution_job_request")]
    public TerraformList<TerraformBlock<GoogleColabScheduleCreateNotebookExecutionJobRequestBlock>>? CreateNotebookExecutionJobRequest { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleColabScheduleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the Schedule
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The state of the schedule.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}

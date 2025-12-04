using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for create_notebook_execution_job_request in GoogleColabSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleColabScheduleCreateNotebookExecutionJobRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_notebook_execution_job_request";

    /// <summary>
    /// NotebookExecutionJob block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookExecutionJob is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotebookExecutionJob block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookExecutionJob block(s) allowed")]
    public required TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlock> NotebookExecutionJob
    {
        get => GetRequiredArgument<TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlock>>("notebook_execution_job");
        set => SetArgument("notebook_execution_job", value);
    }

}

/// <summary>
/// Block type for notebook_execution_job in GoogleColabScheduleCreateNotebookExecutionJobRequestBlock.
/// Nesting mode: list
/// </summary>
public class GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notebook_execution_job";

    /// <summary>
    /// Required. The display name of the Notebook Execution.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Max running time of the execution job in seconds (default 86400s / 24 hrs). A duration in seconds with up to nine fractional digits, ending with &amp;quot;s&amp;quot;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ExecutionTimeout
    {
        get => GetArgument<TerraformValue<string>>("execution_timeout");
        set => SetArgument("execution_timeout", value);
    }

    /// <summary>
    /// The user email to run the execution as.
    /// </summary>
    public TerraformValue<string>? ExecutionUser
    {
        get => GetArgument<TerraformValue<string>>("execution_user");
        set => SetArgument("execution_user", value);
    }

    /// <summary>
    /// The Cloud Storage location to upload the result to. Format:&#39;gs://bucket-name&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcsOutputUri is required")]
    public required TerraformValue<string> GcsOutputUri
    {
        get => GetArgument<TerraformValue<string>>("gcs_output_uri");
        set => SetArgument("gcs_output_uri", value);
    }

    /// <summary>
    /// The NotebookRuntimeTemplate to source compute configuration from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookRuntimeTemplateResourceName is required")]
    public required TerraformValue<string> NotebookRuntimeTemplateResourceName
    {
        get => GetArgument<TerraformValue<string>>("notebook_runtime_template_resource_name");
        set => SetArgument("notebook_runtime_template_resource_name", value);
    }

    /// <summary>
    /// The service account to run the execution as.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// DataformRepositorySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataformRepositorySource block(s) allowed")]
    public TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockDataformRepositorySourceBlock>? DataformRepositorySource
    {
        get => GetArgument<TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockDataformRepositorySourceBlock>>("dataform_repository_source");
        set => SetArgument("dataform_repository_source", value);
    }

    /// <summary>
    /// GcsNotebookSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsNotebookSource block(s) allowed")]
    public TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockGcsNotebookSourceBlock>? GcsNotebookSource
    {
        get => GetArgument<TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockGcsNotebookSourceBlock>>("gcs_notebook_source");
        set => SetArgument("gcs_notebook_source", value);
    }

}

/// <summary>
/// Block type for dataform_repository_source in GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockDataformRepositorySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataform_repository_source";

    /// <summary>
    /// The commit SHA to read repository with. If unset, the file will be read at HEAD.
    /// </summary>
    public TerraformValue<string>? CommitSha
    {
        get => GetArgument<TerraformValue<string>>("commit_sha");
        set => SetArgument("commit_sha", value);
    }

    /// <summary>
    /// The resource name of the Dataform Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataformRepositoryResourceName is required")]
    public required TerraformValue<string> DataformRepositoryResourceName
    {
        get => GetArgument<TerraformValue<string>>("dataform_repository_resource_name");
        set => SetArgument("dataform_repository_resource_name", value);
    }

}

/// <summary>
/// Block type for gcs_notebook_source in GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleColabScheduleCreateNotebookExecutionJobRequestBlockNotebookExecutionJobBlockGcsNotebookSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_notebook_source";

    /// <summary>
    /// The version of the Cloud Storage object to read. If unset, the current version of the object is read. See https://cloud.google.com/storage/docs/metadata#generation-number.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// The Cloud Storage uri pointing to the ipynb file. Format: gs://bucket/notebook_file.ipynb
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleColabSchedule.
/// Nesting mode: single
/// </summary>
public class GoogleColabScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_colab_schedule Terraform resource.
/// Manages a google_colab_schedule resource.
/// </summary>
public partial class GoogleColabSchedule(string name) : TerraformResource("google_colab_schedule", name)
{
    /// <summary>
    /// Whether new scheduled runs can be queued when max_concurrent_runs limit is reached. If set to true, new runs will be queued instead of skipped. Default to false.
    /// </summary>
    public TerraformValue<bool>? AllowQueueing
    {
        get => GetArgument<TerraformValue<bool>>("allow_queueing");
        set => SetArgument("allow_queueing", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) to launch scheduled runs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cron is required")]
    public required TerraformValue<string> Cron
    {
        get => GetArgument<TerraformValue<string>>("cron");
        set => SetArgument("cron", value);
    }

    /// <summary>
    /// Desired state of the Colab Schedule. Set this field to &#39;ACTIVE&#39; to start/resume the schedule, and &#39;PAUSED&#39; to pause the schedule.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Schedule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Timestamp after which no new runs can be scheduled. If specified, the schedule will be completed when either end_time is reached or when scheduled_run_count &amp;gt;= max_run_count. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Maximum number of runs that can be started concurrently for this Schedule. This is the limit for starting the scheduled requests and not the execution of the notebook execution jobs created by the requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConcurrentRunCount is required")]
    public required TerraformValue<string> MaxConcurrentRunCount
    {
        get => GetArgument<TerraformValue<string>>("max_concurrent_run_count");
        set => SetArgument("max_concurrent_run_count", value);
    }

    /// <summary>
    /// Maximum run count of the schedule. If specified, The schedule will be completed when either startedRunCount &amp;gt;= maxRunCount or when endTime is reached. If not specified, new runs will keep getting scheduled until this Schedule is paused or deleted. Already scheduled runs will be allowed to complete. Unset if not specified.
    /// </summary>
    public TerraformValue<string>? MaxRunCount
    {
        get => GetArgument<TerraformValue<string>>("max_run_count");
        set => SetArgument("max_run_count", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The timestamp after which the first run can be scheduled. Defaults to the schedule creation time. Must be in the RFC 3339 (https://www.ietf.org/rfc/rfc3339.txt) format.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The resource name of the Schedule
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. The state of the schedule.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// CreateNotebookExecutionJobRequest block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateNotebookExecutionJobRequest is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CreateNotebookExecutionJobRequest block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CreateNotebookExecutionJobRequest block(s) allowed")]
    public required TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlock> CreateNotebookExecutionJobRequest
    {
        get => GetRequiredArgument<TerraformList<GoogleColabScheduleCreateNotebookExecutionJobRequestBlock>>("create_notebook_execution_job_request");
        set => SetArgument("create_notebook_execution_job_request", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleColabScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleColabScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

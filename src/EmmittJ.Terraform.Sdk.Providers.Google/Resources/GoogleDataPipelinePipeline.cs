using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for schedule_info in .
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineScheduleInfoBlock : TerraformBlock
{
    /// <summary>
    /// When the next Scheduler job is going to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NextJobTime
    {
        get => GetProperty<TerraformProperty<string>>("next_job_time");
        set => WithProperty("next_job_time", value);
    }

    /// <summary>
    /// Unix-cron format of the schedule. This information is retrieved from the linked Cloud Scheduler.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => WithProperty("schedule", value);
    }

    /// <summary>
    /// Timezone ID. This matches the timezone IDs used by the Cloud Scheduler API. If empty, UTC time is assumed.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataPipelinePipelineTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for workload in .
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_data_pipeline_pipeline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataPipelinePipeline : TerraformResource
{
    public GoogleDataPipelinePipeline(string name) : base("google_data_pipeline_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("job_count");
        this.DeclareOutput("last_update_time");
    }

    /// <summary>
    /// The display name of the pipeline. It can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), and underscores (_).
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// &amp;quot;The pipeline name. For example&#39;: &#39;projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID.&amp;quot;
    /// &amp;quot;- PROJECT_ID can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods (.). For more information, see Identifying projects.&amp;quot;
    /// &amp;quot;LOCATION_ID is the canonical ID for the pipeline&#39;s location. The list of available locations can be obtained by calling google.cloud.location.Locations.ListLocations. Note that the Data Pipelines service is not available in all regions. It depends on Cloud Scheduler, an App Engine application, so it&#39;s only available in App Engine regions.&amp;quot;
    /// &amp;quot;PIPELINE_ID is the ID of the pipeline. Must be unique for the selected project and location.&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sources of the pipeline (for example, Dataplex). The keys and values are set by the corresponding sources during pipeline creation.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? PipelineSources
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("pipeline_sources");
        set => this.WithProperty("pipeline_sources", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A reference to the region
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Optional. A service account email to be used with the Cloud Scheduler job. If not specified, the default compute engine service account will be used.
    /// </summary>
    public TerraformProperty<string>? SchedulerServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("scheduler_service_account_email");
        set => this.WithProperty("scheduler_service_account_email", value);
    }

    /// <summary>
    /// The state of the pipeline. When the pipeline is created, the state is set to &#39;PIPELINE_STATE_ACTIVE&#39; by default. State changes can be requested by setting the state to stopping, paused, or resuming. State cannot be changed through pipelines.patch requests.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#state Possible values: [&amp;quot;STATE_UNSPECIFIED&amp;quot;, &amp;quot;STATE_RESUMING&amp;quot;, &amp;quot;STATE_ACTIVE&amp;quot;, &amp;quot;STATE_STOPPING&amp;quot;, &amp;quot;STATE_ARCHIVED&amp;quot;, &amp;quot;STATE_PAUSED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The type of the pipeline. This field affects the scheduling of the pipeline and the type of metrics to show for the pipeline.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#pipelinetype Possible values: [&amp;quot;PIPELINE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PIPELINE_TYPE_BATCH&amp;quot;, &amp;quot;PIPELINE_TYPE_STREAMING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for schedule_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleInfo block(s) allowed")]
    public List<GoogleDataPipelinePipelineScheduleInfoBlock>? ScheduleInfo
    {
        get => GetProperty<List<GoogleDataPipelinePipelineScheduleInfoBlock>>("schedule_info");
        set => this.WithProperty("schedule_info", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataPipelinePipelineTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataPipelinePipelineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Workload block(s) allowed")]
    public List<GoogleDataPipelinePipelineWorkloadBlock>? Workload
    {
        get => GetProperty<List<GoogleDataPipelinePipelineWorkloadBlock>>("workload");
        set => this.WithProperty("workload", value);
    }

    /// <summary>
    /// The timestamp when the pipeline was initially created. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Number of jobs.
    /// </summary>
    public TerraformExpression JobCount => this["job_count"];

    /// <summary>
    /// The timestamp when the pipeline was last modified. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression LastUpdateTime => this["last_update_time"];

}

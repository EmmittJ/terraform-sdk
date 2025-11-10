using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for schedule_info in .
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineScheduleInfoBlock : ITerraformBlock
{
    /// <summary>
    /// When the next Scheduler job is going to run.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("next_job_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextJobTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_job_time");

    /// <summary>
    /// Unix-cron format of the schedule. This information is retrieved from the linked Cloud Scheduler.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schedule { get; set; }

    /// <summary>
    /// Timezone ID. This matches the timezone IDs used by the Cloud Scheduler API. If empty, UTC time is assumed.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataPipelinePipelineTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for workload in .
/// Nesting mode: list
/// </summary>
public class GoogleDataPipelinePipelineWorkloadBlock : ITerraformBlock
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
    }

    /// <summary>
    /// The display name of the pipeline. It can contain only letters ([A-Za-z]), numbers ([0-9]), hyphens (-), and underscores (_).
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// &amp;quot;The pipeline name. For example&#39;: &#39;projects/PROJECT_ID/locations/LOCATION_ID/pipelines/PIPELINE_ID.&amp;quot;
    /// &amp;quot;- PROJECT_ID can contain letters ([A-Za-z]), numbers ([0-9]), hyphens (-), colons (:), and periods (.). For more information, see Identifying projects.&amp;quot;
    /// &amp;quot;LOCATION_ID is the canonical ID for the pipeline&#39;s location. The list of available locations can be obtained by calling google.cloud.location.Locations.ListLocations. Note that the Data Pipelines service is not available in all regions. It depends on Cloud Scheduler, an App Engine application, so it&#39;s only available in App Engine regions.&amp;quot;
    /// &amp;quot;PIPELINE_ID is the ID of the pipeline. Must be unique for the selected project and location.&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The sources of the pipeline (for example, Dataplex). The keys and values are set by the corresponding sources during pipeline creation.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformPropertyName("pipeline_sources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? PipelineSources { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// A reference to the region
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Optional. A service account email to be used with the Cloud Scheduler job. If not specified, the default compute engine service account will be used.
    /// </summary>
    [TerraformPropertyName("scheduler_service_account_email")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SchedulerServiceAccountEmail { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scheduler_service_account_email");

    /// <summary>
    /// The state of the pipeline. When the pipeline is created, the state is set to &#39;PIPELINE_STATE_ACTIVE&#39; by default. State changes can be requested by setting the state to stopping, paused, or resuming. State cannot be changed through pipelines.patch requests.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#state Possible values: [&amp;quot;STATE_UNSPECIFIED&amp;quot;, &amp;quot;STATE_RESUMING&amp;quot;, &amp;quot;STATE_ACTIVE&amp;quot;, &amp;quot;STATE_STOPPING&amp;quot;, &amp;quot;STATE_ARCHIVED&amp;quot;, &amp;quot;STATE_PAUSED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

    /// <summary>
    /// The type of the pipeline. This field affects the scheduling of the pipeline and the type of metrics to show for the pipeline.
    /// https://cloud.google.com/dataflow/docs/reference/data-pipelines/rest/v1/projects.locations.pipelines#pipelinetype Possible values: [&amp;quot;PIPELINE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PIPELINE_TYPE_BATCH&amp;quot;, &amp;quot;PIPELINE_TYPE_STREAMING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for schedule_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleInfo block(s) allowed")]
    [TerraformPropertyName("schedule_info")]
    public TerraformList<TerraformBlock<GoogleDataPipelinePipelineScheduleInfoBlock>>? ScheduleInfo { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataPipelinePipelineTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Workload block(s) allowed")]
    [TerraformPropertyName("workload")]
    public TerraformList<TerraformBlock<GoogleDataPipelinePipelineWorkloadBlock>>? Workload { get; set; } = new();

    /// <summary>
    /// The timestamp when the pipeline was initially created. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Number of jobs.
    /// </summary>
    [TerraformPropertyName("job_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> JobCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "job_count");

    /// <summary>
    /// The timestamp when the pipeline was last modified. Set by the Data Pipelines service.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("last_update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_update_time");

}

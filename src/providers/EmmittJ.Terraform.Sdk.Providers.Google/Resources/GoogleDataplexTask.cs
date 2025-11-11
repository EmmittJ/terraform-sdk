using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for execution_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexTaskExecutionSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as part of key/value string. These will be interpolated before passing the args to the driver. Currently supported placeholders: - ${taskId} - ${job_time} To pass positional args, set the key as TASK_ARGS. The value should be a comma-separated string of all the positional arguments. To use a delimiter other than comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being present in the args, then TASK_ARGS will be passed as the last argument. An object containing a list of &#39;key&#39;: value pairs. Example: { &#39;name&#39;: &#39;wrench&#39;, &#39;mass&#39;: &#39;1.3kg&#39;, &#39;count&#39;: &#39;3&#39; }.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Args { get; set; }

    /// <summary>
    /// The Cloud KMS key to use for encryption, of the form: projects/{project_number}/locations/{locationId}/keyRings/{key-ring-name}/cryptoKeys/{key-name}.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// The maximum duration after which the job execution is expired. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// </summary>
    [TerraformProperty("max_job_execution_lifetime")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxJobExecutionLifetime { get; set; }

    /// <summary>
    /// The project in which jobs are run. By default, the project containing the Lake is used. If a project is provided, the ExecutionSpec.service_account must belong to this project.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Service account to use to execute a task. If not provided, the default Compute service account for the project is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformProperty("service_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceAccount { get; set; }

}

/// <summary>
/// Block type for notebook in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexTaskNotebookBlock : TerraformBlockBase
{
    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// Path to input notebook. This can be the Cloud Storage URI of the notebook file or the path to a Notebook Content. The execution args are accessible as environment variables (TASK_key=value).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notebook is required")]
    [TerraformProperty("notebook")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Notebook { get; set; }

}

/// <summary>
/// Block type for spark in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexTaskSparkBlock : TerraformBlockBase
{
    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// The name of the driver&#39;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    [TerraformProperty("main_class")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MainClass { get; set; }

    /// <summary>
    /// The Cloud Storage URI of the jar file that contains the main class. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    [TerraformProperty("main_jar_file_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MainJarFileUri { get; set; }

    /// <summary>
    /// The Gcloud Storage URI of the main Python file to use as the driver. Must be a .py file. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    [TerraformProperty("python_script_file")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PythonScriptFile { get; set; }

    /// <summary>
    /// The query text. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    [TerraformProperty("sql_script")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlScript { get; set; }

    /// <summary>
    /// A reference to a query file. This can be the Cloud Storage URI of the query file or it can the path to a SqlScript Content. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    [TerraformProperty("sql_script_file")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SqlScriptFile { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataplexTaskTimeoutsBlock : TerraformBlockBase
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
/// Block type for trigger_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexTaskTriggerSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Prevent the task from executing. This does not cancel already running tasks. It is intended to temporarily disable RECURRING tasks.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// Number of retry attempts before aborting. Set to zero to never attempt to retry a failed task.
    /// </summary>
    [TerraformProperty("max_retries")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxRetries { get; set; }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) for running tasks periodically. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &#39;CRON_TZ=${IANA_TIME_ZONE}&#39; or &#39;TZ=${IANA_TIME_ZONE}&#39;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, CRON_TZ=America/New_York 1 * * * *, or TZ=America/New_York 1 * * * *. This field is required for RECURRING tasks.
    /// </summary>
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// The first run of the task will be after this time. If not specified, the task will run shortly after being submitted if ON_DEMAND and based on the schedule if RECURRING.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartTime { get; set; }

    /// <summary>
    /// Trigger type of the user-specified Task Possible values: [&amp;quot;ON_DEMAND&amp;quot;, &amp;quot;RECURRING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a google_dataplex_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataplexTask : TerraformResource
{
    public GoogleDataplexTask(string name) : base("google_dataplex_task", name)
    {
    }

    /// <summary>
    /// User-provided description of the task.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the task.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The lake in which the task will be created in.
    /// </summary>
    [TerraformProperty("lake")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Lake { get; set; }

    /// <summary>
    /// The location in which the task will be created in.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The task Id of the task.
    /// </summary>
    [TerraformProperty("task_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TaskId { get; set; }

    /// <summary>
    /// Block for execution_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    [TerraformProperty("execution_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexTaskExecutionSpecBlock>>? ExecutionSpec { get; set; }

    /// <summary>
    /// Block for notebook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notebook block(s) allowed")]
    [TerraformProperty("notebook")]
    public TerraformList<TerraformBlock<GoogleDataplexTaskNotebookBlock>>? Notebook { get; set; }

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    [TerraformProperty("spark")]
    public TerraformList<TerraformBlock<GoogleDataplexTaskSparkBlock>>? Spark { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataplexTaskTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for trigger_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerSpec block(s) allowed")]
    [TerraformProperty("trigger_spec")]
    public TerraformList<TerraformBlock<GoogleDataplexTaskTriggerSpecBlock>>? TriggerSpec { get; set; }

    /// <summary>
    /// The time when the task was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Configuration for the cluster
    /// </summary>
    [TerraformProperty("execution_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ExecutionStatus { get; }

    /// <summary>
    /// The relative resource name of the task, of the form: projects/{project_number}/locations/{locationId}/lakes/{lakeId}/ tasks/{name}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Current state of the task.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// The time when the task was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}

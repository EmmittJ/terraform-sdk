using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for execution_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskExecutionSpecBlock : TerraformBlock
{
    /// <summary>
    /// The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as part of key/value string. These will be interpolated before passing the args to the driver. Currently supported placeholders: - ${taskId} - ${job_time} To pass positional args, set the key as TASK_ARGS. The value should be a comma-separated string of all the positional arguments. To use a delimiter other than comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being present in the args, then TASK_ARGS will be passed as the last argument. An object containing a list of &#39;key&#39;: value pairs. Example: { &#39;name&#39;: &#39;wrench&#39;, &#39;mass&#39;: &#39;1.3kg&#39;, &#39;count&#39;: &#39;3&#39; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// The Cloud KMS key to use for encryption, of the form: projects/{project_number}/locations/{locationId}/keyRings/{key-ring-name}/cryptoKeys/{key-name}.
    /// </summary>
    public TerraformProperty<string>? KmsKey
    {
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// The maximum duration after which the job execution is expired. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// </summary>
    public TerraformProperty<string>? MaxJobExecutionLifetime
    {
        set => SetProperty("max_job_execution_lifetime", value);
    }

    /// <summary>
    /// The project in which jobs are run. By default, the project containing the Lake is used. If a project is provided, the ExecutionSpec.service_account must belong to this project.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Service account to use to execute a task. If not provided, the default Compute service account for the project is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformProperty<string> ServiceAccount
    {
        set => SetProperty("service_account", value);
    }

}

/// <summary>
/// Block type for notebook in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlock : TerraformBlock
{
    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// Path to input notebook. This can be the Cloud Storage URI of the notebook file or the path to a Notebook Content. The execution args are accessible as environment variables (TASK_key=value).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notebook is required")]
    public required TerraformProperty<string> Notebook
    {
        set => SetProperty("notebook", value);
    }

}

/// <summary>
/// Block type for spark in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlock : TerraformBlock
{
    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// The name of the driver&#39;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        set => SetProperty("main_class", value);
    }

    /// <summary>
    /// The Cloud Storage URI of the jar file that contains the main class. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        set => SetProperty("main_jar_file_uri", value);
    }

    /// <summary>
    /// The Gcloud Storage URI of the main Python file to use as the driver. Must be a .py file. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformProperty<string>? PythonScriptFile
    {
        set => SetProperty("python_script_file", value);
    }

    /// <summary>
    /// The query text. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    public TerraformProperty<string>? SqlScript
    {
        set => SetProperty("sql_script", value);
    }

    /// <summary>
    /// A reference to a query file. This can be the Cloud Storage URI of the query file or it can the path to a SqlScript Content. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    public TerraformProperty<string>? SqlScriptFile
    {
        set => SetProperty("sql_script_file", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexTaskTimeoutsBlock : TerraformBlock
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
/// Block type for trigger_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskTriggerSpecBlock : TerraformBlock
{
    /// <summary>
    /// Prevent the task from executing. This does not cancel already running tasks. It is intended to temporarily disable RECURRING tasks.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// Number of retry attempts before aborting. Set to zero to never attempt to retry a failed task.
    /// </summary>
    public TerraformProperty<double>? MaxRetries
    {
        set => SetProperty("max_retries", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) for running tasks periodically. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &#39;CRON_TZ=${IANA_TIME_ZONE}&#39; or &#39;TZ=${IANA_TIME_ZONE}&#39;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, CRON_TZ=America/New_York 1 * * * *, or TZ=America/New_York 1 * * * *. This field is required for RECURRING tasks.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// The first run of the task will be after this time. If not specified, the task will run shortly after being submitted if ON_DEMAND and based on the schedule if RECURRING.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        set => SetProperty("start_time", value);
    }

    /// <summary>
    /// Trigger type of the user-specified Task Possible values: [&amp;quot;ON_DEMAND&amp;quot;, &amp;quot;RECURRING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Manages a google_dataplex_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexTask : TerraformResource
{
    public GoogleDataplexTask(string name) : base("google_dataplex_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("execution_status");
        SetOutput("name");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("lake");
        SetOutput("location");
        SetOutput("project");
        SetOutput("task_id");
    }

    /// <summary>
    /// User-provided description of the task.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// User-defined labels for the task.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The lake in which the task will be created in.
    /// </summary>
    public TerraformProperty<string> Lake
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lake");
        set => SetProperty("lake", value);
    }

    /// <summary>
    /// The location in which the task will be created in.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The task Id of the task.
    /// </summary>
    public TerraformProperty<string> TaskId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_id");
        set => SetProperty("task_id", value);
    }

    /// <summary>
    /// Block for execution_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    public List<GoogleDataplexTaskExecutionSpecBlock>? ExecutionSpec
    {
        set => SetProperty("execution_spec", value);
    }

    /// <summary>
    /// Block for notebook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notebook block(s) allowed")]
    public List<GoogleDataplexTaskNotebookBlock>? Notebook
    {
        set => SetProperty("notebook", value);
    }

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public List<GoogleDataplexTaskSparkBlock>? Spark
    {
        set => SetProperty("spark", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexTaskTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for trigger_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerSpec block(s) allowed")]
    public List<GoogleDataplexTaskTriggerSpecBlock>? TriggerSpec
    {
        set => SetProperty("trigger_spec", value);
    }

    /// <summary>
    /// The time when the task was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Configuration for the cluster
    /// </summary>
    public TerraformExpression ExecutionStatus => this["execution_status"];

    /// <summary>
    /// The relative resource name of the task, of the form: projects/{project_number}/locations/{locationId}/lakes/{lakeId}/ tasks/{name}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Current state of the task.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The time when the task was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

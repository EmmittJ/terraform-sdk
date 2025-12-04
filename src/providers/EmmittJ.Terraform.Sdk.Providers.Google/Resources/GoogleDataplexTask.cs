using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for execution_spec in GoogleDataplexTask.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskExecutionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_spec";

    /// <summary>
    /// The arguments to pass to the task. The args can use placeholders of the format ${placeholder} as part of key/value string. These will be interpolated before passing the args to the driver. Currently supported placeholders: - ${taskId} - ${job_time} To pass positional args, set the key as TASK_ARGS. The value should be a comma-separated string of all the positional arguments. To use a delimiter other than comma, refer to https://cloud.google.com/sdk/gcloud/reference/topic/escaping. In case of other keys being present in the args, then TASK_ARGS will be passed as the last argument. An object containing a list of &#39;key&#39;: value pairs. Example: { &#39;name&#39;: &#39;wrench&#39;, &#39;mass&#39;: &#39;1.3kg&#39;, &#39;count&#39;: &#39;3&#39; }.
    /// </summary>
    public TerraformMap<string>? Args
    {
        get => GetArgument<TerraformMap<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The Cloud KMS key to use for encryption, of the form: projects/{project_number}/locations/{locationId}/keyRings/{key-ring-name}/cryptoKeys/{key-name}.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The maximum duration after which the job execution is expired. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// </summary>
    public TerraformValue<string>? MaxJobExecutionLifetime
    {
        get => GetArgument<TerraformValue<string>>("max_job_execution_lifetime");
        set => SetArgument("max_job_execution_lifetime", value);
    }

    /// <summary>
    /// The project in which jobs are run. By default, the project containing the Lake is used. If a project is provided, the ExecutionSpec.service_account must belong to this project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Service account to use to execute a task. If not provided, the default Compute service account for the project is used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}


/// <summary>
/// Block type for notebook in GoogleDataplexTask.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notebook";

    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Path to input notebook. This can be the Cloud Storage URI of the notebook file or the path to a Notebook Content. The execution args are accessible as environment variables (TASK_key=value).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Notebook is required")]
    public required TerraformValue<string> Notebook
    {
        get => GetArgument<TerraformValue<string>>("notebook");
        set => SetArgument("notebook", value);
    }

    /// <summary>
    /// InfrastructureSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfrastructureSpec block(s) allowed")]
    public TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock>? InfrastructureSpec
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock>>("infrastructure_spec");
        set => SetArgument("infrastructure_spec", value);
    }

}

/// <summary>
/// Block type for infrastructure_spec in GoogleDataplexTaskNotebookBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infrastructure_spec";

    /// <summary>
    /// Batch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Batch block(s) allowed")]
    public TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockBatchBlock>? Batch
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockBatchBlock>>("batch");
        set => SetArgument("batch", value);
    }

    /// <summary>
    /// ContainerImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockContainerImageBlock>? ContainerImage
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockContainerImageBlock>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// VpcNetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcNetwork block(s) allowed")]
    public TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockVpcNetworkBlock>? VpcNetwork
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockVpcNetworkBlock>>("vpc_network");
        set => SetArgument("vpc_network", value);
    }

}

/// <summary>
/// Block type for batch in GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batch";

    /// <summary>
    /// Total number of job executors. Executor Count should be between 2 and 100. [Default=2]
    /// </summary>
    public TerraformValue<double>? ExecutorsCount
    {
        get => GetArgument<TerraformValue<double>>("executors_count");
        set => SetArgument("executors_count", value);
    }

    /// <summary>
    /// Max configurable executors. If maxExecutorsCount &amp;gt; executorsCount, then auto-scaling is enabled. Max Executor Count should be between 2 and 1000. [Default=1000]
    /// </summary>
    public TerraformValue<double>? MaxExecutorsCount
    {
        get => GetArgument<TerraformValue<double>>("max_executors_count");
        set => SetArgument("max_executors_count", value);
    }

}

/// <summary>
/// Block type for container_image in GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockContainerImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_image";

    /// <summary>
    /// Container image to use.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// A list of Java JARS to add to the classpath. Valid input includes Cloud Storage URIs to Jar binaries. For example, gs://bucket-name/my/path/to/file.jar
    /// </summary>
    public TerraformList<string>? JavaJars
    {
        get => GetArgument<TerraformList<string>>("java_jars");
        set => SetArgument("java_jars", value);
    }

    /// <summary>
    /// Override to common configuration of open source components installed on the Dataproc cluster. The properties to set on daemon config files. Property keys are specified in prefix:property format, for example core:hadoop.tmp.dir. For more information, see Cluster properties.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz
    /// </summary>
    public TerraformList<string>? PythonPackages
    {
        get => GetArgument<TerraformList<string>>("python_packages");
        set => SetArgument("python_packages", value);
    }

}

/// <summary>
/// Block type for vpc_network in GoogleDataplexTaskNotebookBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskNotebookBlockInfrastructureSpecBlockVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_network";

    /// <summary>
    /// The Cloud VPC network in which the job is run. By default, the Cloud VPC network named Default within the project is used.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// List of network tags to apply to the job.
    /// </summary>
    public TerraformList<string>? NetworkTags
    {
        get => GetArgument<TerraformList<string>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// The Cloud VPC sub-network in which the job is run.
    /// </summary>
    public TerraformValue<string>? SubNetwork
    {
        get => GetArgument<TerraformValue<string>>("sub_network");
        set => SetArgument("sub_network", value);
    }

}


/// <summary>
/// Block type for spark in GoogleDataplexTask.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark";

    /// <summary>
    /// Cloud Storage URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Cloud Storage URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// The name of the driver&#39;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in jar_file_uris. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The Cloud Storage URI of the jar file that contains the main class. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformValue<string>? MainJarFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_jar_file_uri");
        set => SetArgument("main_jar_file_uri", value);
    }

    /// <summary>
    /// The Gcloud Storage URI of the main Python file to use as the driver. Must be a .py file. The execution args are passed in as a sequence of named process arguments (--key=value).
    /// </summary>
    public TerraformValue<string>? PythonScriptFile
    {
        get => GetArgument<TerraformValue<string>>("python_script_file");
        set => SetArgument("python_script_file", value);
    }

    /// <summary>
    /// The query text. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    public TerraformValue<string>? SqlScript
    {
        get => GetArgument<TerraformValue<string>>("sql_script");
        set => SetArgument("sql_script", value);
    }

    /// <summary>
    /// A reference to a query file. This can be the Cloud Storage URI of the query file or it can the path to a SqlScript Content. The execution args are used to declare a set of script variables (set key=&#39;value&#39;;).
    /// </summary>
    public TerraformValue<string>? SqlScriptFile
    {
        get => GetArgument<TerraformValue<string>>("sql_script_file");
        set => SetArgument("sql_script_file", value);
    }

    /// <summary>
    /// InfrastructureSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfrastructureSpec block(s) allowed")]
    public TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlock>? InfrastructureSpec
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlock>>("infrastructure_spec");
        set => SetArgument("infrastructure_spec", value);
    }

}

/// <summary>
/// Block type for infrastructure_spec in GoogleDataplexTaskSparkBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlockInfrastructureSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infrastructure_spec";

    /// <summary>
    /// Batch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Batch block(s) allowed")]
    public TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockBatchBlock>? Batch
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockBatchBlock>>("batch");
        set => SetArgument("batch", value);
    }

    /// <summary>
    /// ContainerImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockContainerImageBlock>? ContainerImage
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockContainerImageBlock>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// VpcNetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcNetwork block(s) allowed")]
    public TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockVpcNetworkBlock>? VpcNetwork
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskSparkBlockInfrastructureSpecBlockVpcNetworkBlock>>("vpc_network");
        set => SetArgument("vpc_network", value);
    }

}

/// <summary>
/// Block type for batch in GoogleDataplexTaskSparkBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlockInfrastructureSpecBlockBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batch";

    /// <summary>
    /// Total number of job executors. Executor Count should be between 2 and 100. [Default=2]
    /// </summary>
    public TerraformValue<double>? ExecutorsCount
    {
        get => GetArgument<TerraformValue<double>>("executors_count");
        set => SetArgument("executors_count", value);
    }

    /// <summary>
    /// Max configurable executors. If maxExecutorsCount &amp;gt; executorsCount, then auto-scaling is enabled. Max Executor Count should be between 2 and 1000. [Default=1000]
    /// </summary>
    public TerraformValue<double>? MaxExecutorsCount
    {
        get => GetArgument<TerraformValue<double>>("max_executors_count");
        set => SetArgument("max_executors_count", value);
    }

}

/// <summary>
/// Block type for container_image in GoogleDataplexTaskSparkBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlockInfrastructureSpecBlockContainerImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_image";

    /// <summary>
    /// Container image to use.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// A list of Java JARS to add to the classpath. Valid input includes Cloud Storage URIs to Jar binaries. For example, gs://bucket-name/my/path/to/file.jar
    /// </summary>
    public TerraformList<string>? JavaJars
    {
        get => GetArgument<TerraformList<string>>("java_jars");
        set => SetArgument("java_jars", value);
    }

    /// <summary>
    /// Override to common configuration of open source components installed on the Dataproc cluster. The properties to set on daemon config files. Property keys are specified in prefix:property format, for example core:hadoop.tmp.dir. For more information, see Cluster properties.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// A list of python packages to be installed. Valid formats include Cloud Storage URI to a PIP installable library. For example, gs://bucket-name/my/path/to/lib.tar.gz
    /// </summary>
    public TerraformList<string>? PythonPackages
    {
        get => GetArgument<TerraformList<string>>("python_packages");
        set => SetArgument("python_packages", value);
    }

}

/// <summary>
/// Block type for vpc_network in GoogleDataplexTaskSparkBlockInfrastructureSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskSparkBlockInfrastructureSpecBlockVpcNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_network";

    /// <summary>
    /// The Cloud VPC network in which the job is run. By default, the Cloud VPC network named Default within the project is used.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// List of network tags to apply to the job.
    /// </summary>
    public TerraformList<string>? NetworkTags
    {
        get => GetArgument<TerraformList<string>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// The Cloud VPC sub-network in which the job is run.
    /// </summary>
    public TerraformValue<string>? SubNetwork
    {
        get => GetArgument<TerraformValue<string>>("sub_network");
        set => SetArgument("sub_network", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexTask.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexTaskTimeoutsBlock : TerraformBlock
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
/// Block type for trigger_spec in GoogleDataplexTask.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexTaskTriggerSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_spec";

    /// <summary>
    /// Prevent the task from executing. This does not cancel already running tasks. It is intended to temporarily disable RECURRING tasks.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Number of retry attempts before aborting. Set to zero to never attempt to retry a failed task.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => GetArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }

    /// <summary>
    /// Cron schedule (https://en.wikipedia.org/wiki/Cron) for running tasks periodically. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &#39;CRON_TZ=${IANA_TIME_ZONE}&#39; or &#39;TZ=${IANA_TIME_ZONE}&#39;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, CRON_TZ=America/New_York 1 * * * *, or TZ=America/New_York 1 * * * *. This field is required for RECURRING tasks.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The first run of the task will be after this time. If not specified, the task will run shortly after being submitted if ON_DEMAND and based on the schedule if RECURRING.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// Trigger type of the user-specified Task Possible values: [&amp;quot;ON_DEMAND&amp;quot;, &amp;quot;RECURRING&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a google_dataplex_task Terraform resource.
/// Manages a google_dataplex_task resource.
/// </summary>
public partial class GoogleDataplexTask(string name) : TerraformResource("google_dataplex_task", name)
{
    /// <summary>
    /// User-provided description of the task.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User friendly display name.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// User-defined labels for the task.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The lake in which the task will be created in.
    /// </summary>
    public TerraformValue<string>? Lake
    {
        get => GetArgument<TerraformValue<string>>("lake");
        set => SetArgument("lake", value);
    }

    /// <summary>
    /// The location in which the task will be created in.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The task Id of the task.
    /// </summary>
    public TerraformValue<string>? TaskId
    {
        get => GetArgument<TerraformValue<string>>("task_id");
        set => SetArgument("task_id", value);
    }

    /// <summary>
    /// The time when the task was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Configuration for the cluster
    /// </summary>
    public TerraformList<TerraformMap<object>> ExecutionStatus
        => AsReference("execution_status");

    /// <summary>
    /// The relative resource name of the task, of the form: projects/{project_number}/locations/{locationId}/lakes/{lakeId}/ tasks/{name}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Current state of the task.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// System generated globally unique ID for the task. This ID will be different if the task is deleted and re-created with the same name.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// The time when the task was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ExecutionSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExecutionSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionSpec block(s) allowed")]
    public required TerraformList<GoogleDataplexTaskExecutionSpecBlock> ExecutionSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexTaskExecutionSpecBlock>>("execution_spec");
        set => SetArgument("execution_spec", value);
    }

    /// <summary>
    /// Notebook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notebook block(s) allowed")]
    public TerraformList<GoogleDataplexTaskNotebookBlock>? Notebook
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskNotebookBlock>>("notebook");
        set => SetArgument("notebook", value);
    }

    /// <summary>
    /// Spark block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public TerraformList<GoogleDataplexTaskSparkBlock>? Spark
    {
        get => GetArgument<TerraformList<GoogleDataplexTaskSparkBlock>>("spark");
        set => SetArgument("spark", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexTaskTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexTaskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TriggerSpec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerSpec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerSpec block(s) allowed")]
    public required TerraformList<GoogleDataplexTaskTriggerSpecBlock> TriggerSpec
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexTaskTriggerSpecBlock>>("trigger_spec");
        set => SetArgument("trigger_spec", value);
    }

}

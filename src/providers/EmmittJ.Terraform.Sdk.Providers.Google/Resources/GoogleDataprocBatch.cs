using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_config";

    /// <summary>
    /// ExecutionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlock>? ExecutionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlock>>("execution_config");
        set => SetArgument("execution_config", value);
    }

    /// <summary>
    /// PeripheralsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PeripheralsConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlock>? PeripheralsConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlock>>("peripherals_config");
        set => SetArgument("peripherals_config", value);
    }

}

/// <summary>
/// Block type for execution_config in GoogleDataprocBatchEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_config";

    /// <summary>
    /// The Cloud KMS key to use for encryption.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Tags used for network traffic control.
    /// </summary>
    public TerraformList<string>? NetworkTags
    {
        get => GetArgument<TerraformList<string>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// Network configuration for workload execution.
    /// </summary>
    public TerraformValue<string>? NetworkUri
    {
        get => GetArgument<TerraformValue<string>>("network_uri");
        set => SetArgument("network_uri", value);
    }

    /// <summary>
    /// Service account that used to execute workload.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// A Cloud Storage bucket used to stage workload dependencies, config files, and store
    /// workload output and other ephemeral data, such as Spark history files. If you do not specify a staging bucket,
    /// Cloud Dataproc will determine a Cloud Storage location according to the region where your workload is running,
    /// and then create and manage project-level, per-location staging and temporary buckets.
    /// This field requires a Cloud Storage bucket name, not a gs://... URI to a Cloud Storage bucket.
    /// </summary>
    public TerraformValue<string>? StagingBucket
    {
        get => GetArgument<TerraformValue<string>>("staging_bucket");
        set => SetArgument("staging_bucket", value);
    }

    /// <summary>
    /// Subnetwork configuration for workload execution.
    /// </summary>
    public TerraformValue<string>? SubnetworkUri
    {
        get => GetArgument<TerraformValue<string>>("subnetwork_uri");
        set => SetArgument("subnetwork_uri", value);
    }

    /// <summary>
    /// The duration after which the workload will be terminated.
    /// When the workload exceeds this duration, it will be unconditionally terminated without waiting for ongoing
    /// work to finish. If ttl is not specified for a batch workload, the workload will be allowed to run until it
    /// exits naturally (or run forever without exiting). If ttl is not specified for an interactive session,
    /// it defaults to 24 hours. If ttl is not specified for a batch that uses 2.1+ runtime version, it defaults to 4 hours.
    /// Minimum value is 10 minutes; maximum value is 14 days. If both ttl and idleTtl are specified (for an interactive session),
    /// the conditions are treated as OR conditions: the workload will be terminated when it has been idle for idleTtl or
    /// when ttl has been exceeded, whichever occurs first.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => GetArgument<TerraformValue<string>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// AuthenticationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock>? AuthenticationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock>>("authentication_config");
        set => SetArgument("authentication_config", value);
    }

}

/// <summary>
/// Block type for authentication_config in GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlockExecutionConfigBlockAuthenticationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_config";

    /// <summary>
    /// Authentication type for the user workload running in containers. Possible values: [&amp;quot;SERVICE_ACCOUNT&amp;quot;, &amp;quot;END_USER_CREDENTIALS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? UserWorkloadAuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("user_workload_authentication_type");
        set => SetArgument("user_workload_authentication_type", value);
    }

}

/// <summary>
/// Block type for peripherals_config in GoogleDataprocBatchEnvironmentConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "peripherals_config";

    /// <summary>
    /// Resource name of an existing Dataproc Metastore service.
    /// </summary>
    public TerraformValue<string>? MetastoreService
    {
        get => GetArgument<TerraformValue<string>>("metastore_service");
        set => SetArgument("metastore_service", value);
    }

    /// <summary>
    /// SparkHistoryServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkHistoryServerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock>? SparkHistoryServerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock>>("spark_history_server_config");
        set => SetArgument("spark_history_server_config", value);
    }

}

/// <summary>
/// Block type for spark_history_server_config in GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlockPeripheralsConfigBlockSparkHistoryServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_history_server_config";

    /// <summary>
    /// Resource name of an existing Dataproc Cluster to act as a Spark History Server for the workload.
    /// </summary>
    public TerraformValue<string>? DataprocCluster
    {
        get => GetArgument<TerraformValue<string>>("dataproc_cluster");
        set => SetArgument("dataproc_cluster", value);
    }

}


/// <summary>
/// Block type for pyspark_batch in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchPysparkBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pyspark_batch";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the Spark driver. Must be a .py file.
    /// </summary>
    public TerraformValue<string>? MainPythonFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_python_file_uri");
        set => SetArgument("main_python_file_uri", value);
    }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework.
    /// Supported file types: .py, .egg, and .zip.
    /// </summary>
    public TerraformList<string>? PythonFileUris
    {
        get => GetArgument<TerraformList<string>>("python_file_uris");
        set => SetArgument("python_file_uris", value);
    }

}


/// <summary>
/// Block type for runtime_config in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchRuntimeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_config";

    /// <summary>
    /// Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.
    /// </summary>
    public TerraformValue<string>? Cohort
    {
        get => GetArgument<TerraformValue<string>>("cohort");
        set => SetArgument("cohort", value);
    }

    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    public TerraformValue<string>? ContainerImage
    {
        get => GetArgument<TerraformValue<string>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public TerraformMap<string> EffectiveProperties
        => AsReference("effective_properties");

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Version of the batch runtime.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// AutotuningConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutotuningConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchRuntimeConfigBlockAutotuningConfigBlock>? AutotuningConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchRuntimeConfigBlockAutotuningConfigBlock>>("autotuning_config");
        set => SetArgument("autotuning_config", value);
    }

}

/// <summary>
/// Block type for autotuning_config in GoogleDataprocBatchRuntimeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchRuntimeConfigBlockAutotuningConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autotuning_config";

    /// <summary>
    /// Optional. Scenarios for which tunings are applied. Possible values: [&amp;quot;SCALING&amp;quot;, &amp;quot;BROADCAST_HASH_JOIN&amp;quot;, &amp;quot;MEMORY&amp;quot;]
    /// </summary>
    public TerraformList<string>? Scenarios
    {
        get => GetArgument<TerraformList<string>>("scenarios");
        set => SetArgument("scenarios", value);
    }

}


/// <summary>
/// Block type for spark_batch in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_batch";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the
    /// classpath or specified in jarFileUris.
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    public TerraformValue<string>? MainJarFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_jar_file_uri");
        set => SetArgument("main_jar_file_uri", value);
    }

}


/// <summary>
/// Block type for spark_r_batch in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkRBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_r_batch";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R or .r file.
    /// </summary>
    public TerraformValue<string>? MainRFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_r_file_uri");
        set => SetArgument("main_r_file_uri", value);
    }

}


/// <summary>
/// Block type for spark_sql_batch in GoogleDataprocBatch.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkSqlBatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_sql_batch";

    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains Spark SQL queries to execute.
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public TerraformMap<string>? QueryVariables
    {
        get => GetArgument<TerraformMap<string>>("query_variables");
        set => SetArgument("query_variables", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocBatch.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocBatchTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataproc_batch Terraform resource.
/// Manages a google_dataproc_batch resource.
/// </summary>
public partial class GoogleDataprocBatch(string name) : TerraformResource("google_dataproc_batch", name)
{
    /// <summary>
    /// The ID to use for the batch, which will become the final component of the batch&#39;s resource name.
    /// This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
    /// </summary>
    public TerraformValue<string>? BatchId
    {
        get => GetArgument<TerraformValue<string>>("batch_id");
        set => SetArgument("batch_id", value);
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
    /// The labels to associate with this batch.
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
    /// The location in which the batch will be created in.
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
    /// The time when the batch was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The email address of the user who created the batch.
    /// </summary>
    public TerraformValue<string> Creator
        => AsReference("creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource name of the batch.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The resource name of the operation associated with this batch.
    /// </summary>
    public TerraformValue<string> Operation
        => AsReference("operation");

    /// <summary>
    /// Runtime information about batch execution.
    /// </summary>
    public TerraformList<TerraformMap<object>> RuntimeInfo
        => AsReference("runtime_info");

    /// <summary>
    /// The state of the batch. For possible values, see the [API documentation](https://cloud.google.com/dataproc-serverless/docs/reference/rest/v1/projects.locations.batches#State).
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Historical state information for the batch.
    /// </summary>
    public TerraformList<TerraformMap<object>> StateHistory
        => AsReference("state_history");

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformValue<string> StateMessage
        => AsReference("state_message");

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformValue<string> StateTime
        => AsReference("state_time");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
    /// </summary>
    public TerraformValue<string> Uuid
        => AsReference("uuid");

    /// <summary>
    /// EnvironmentConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlock>? EnvironmentConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchEnvironmentConfigBlock>>("environment_config");
        set => SetArgument("environment_config", value);
    }

    /// <summary>
    /// PysparkBatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkBatch block(s) allowed")]
    public TerraformList<GoogleDataprocBatchPysparkBatchBlock>? PysparkBatch
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchPysparkBatchBlock>>("pyspark_batch");
        set => SetArgument("pyspark_batch", value);
    }

    /// <summary>
    /// RuntimeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    public TerraformList<GoogleDataprocBatchRuntimeConfigBlock>? RuntimeConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchRuntimeConfigBlock>>("runtime_config");
        set => SetArgument("runtime_config", value);
    }

    /// <summary>
    /// SparkBatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkBatch block(s) allowed")]
    public TerraformList<GoogleDataprocBatchSparkBatchBlock>? SparkBatch
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchSparkBatchBlock>>("spark_batch");
        set => SetArgument("spark_batch", value);
    }

    /// <summary>
    /// SparkRBatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRBatch block(s) allowed")]
    public TerraformList<GoogleDataprocBatchSparkRBatchBlock>? SparkRBatch
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchSparkRBatchBlock>>("spark_r_batch");
        set => SetArgument("spark_r_batch", value);
    }

    /// <summary>
    /// SparkSqlBatch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlBatch block(s) allowed")]
    public TerraformList<GoogleDataprocBatchSparkSqlBatchBlock>? SparkSqlBatch
    {
        get => GetArgument<TerraformList<GoogleDataprocBatchSparkSqlBatchBlock>>("spark_sql_batch");
        set => SetArgument("spark_sql_batch", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocBatchTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocBatchTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

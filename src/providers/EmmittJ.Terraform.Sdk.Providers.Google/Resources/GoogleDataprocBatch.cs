using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchEnvironmentConfigBlock() : TerraformBlock("environment_config")
{
}

/// <summary>
/// Block type for pyspark_batch in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchPysparkBatchBlock() : TerraformBlock("pyspark_batch")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    [TerraformProperty("jar_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the Spark driver. Must be a .py file.
    /// </summary>
    [TerraformProperty("main_python_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainPythonFileUri { get; set; }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework.
    /// Supported file types: .py, .egg, and .zip.
    /// </summary>
    [TerraformProperty("python_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PythonFileUris { get; set; }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchRuntimeConfigBlock() : TerraformBlock("runtime_config")
{
    /// <summary>
    /// Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.
    /// </summary>
    [TerraformProperty("cohort")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cohort { get; set; }

    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    [TerraformProperty("container_image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerImage { get; set; }


    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// Version of the batch runtime.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for spark_batch in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchSparkBatchBlock() : TerraformBlock("spark_batch")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    [TerraformProperty("jar_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the
    /// classpath or specified in jarFileUris.
    /// </summary>
    [TerraformProperty("main_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    [TerraformProperty("main_jar_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainJarFileUri { get; set; }

}

/// <summary>
/// Block type for spark_r_batch in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchSparkRBatchBlock() : TerraformBlock("spark_r_batch")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R or .r file.
    /// </summary>
    [TerraformProperty("main_r_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainRFileUri { get; set; }

}

/// <summary>
/// Block type for spark_sql_batch in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocBatchSparkSqlBatchBlock() : TerraformBlock("spark_sql_batch")
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    [TerraformProperty("jar_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains Spark SQL queries to execute.
    /// </summary>
    [TerraformProperty("query_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryFileUri { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    [TerraformProperty("query_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? QueryVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocBatchTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_batch resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocBatch : TerraformResource
{
    public GoogleDataprocBatch(string name) : base("google_dataproc_batch", name)
    {
    }

    /// <summary>
    /// The ID to use for the batch, which will become the final component of the batch&#39;s resource name.
    /// This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
    /// </summary>
    [TerraformProperty("batch_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BatchId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels to associate with this batch.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location in which the batch will be created in.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    [TerraformProperty("environment_config")]
    public TerraformList<GoogleDataprocBatchEnvironmentConfigBlock> EnvironmentConfig { get; set; } = new();

    /// <summary>
    /// Block for pyspark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkBatch block(s) allowed")]
    [TerraformProperty("pyspark_batch")]
    public TerraformList<GoogleDataprocBatchPysparkBatchBlock> PysparkBatch { get; set; } = new();

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    [TerraformProperty("runtime_config")]
    public TerraformList<GoogleDataprocBatchRuntimeConfigBlock> RuntimeConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkBatch block(s) allowed")]
    [TerraformProperty("spark_batch")]
    public TerraformList<GoogleDataprocBatchSparkBatchBlock> SparkBatch { get; set; } = new();

    /// <summary>
    /// Block for spark_r_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRBatch block(s) allowed")]
    [TerraformProperty("spark_r_batch")]
    public TerraformList<GoogleDataprocBatchSparkRBatchBlock> SparkRBatch { get; set; } = new();

    /// <summary>
    /// Block for spark_sql_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlBatch block(s) allowed")]
    [TerraformProperty("spark_sql_batch")]
    public TerraformList<GoogleDataprocBatchSparkSqlBatchBlock> SparkSqlBatch { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataprocBatchTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the batch was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The email address of the user who created the batch.
    /// </summary>
    [TerraformProperty("creator")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Creator { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource name of the batch.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The resource name of the operation associated with this batch.
    /// </summary>
    [TerraformProperty("operation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Operation { get; }

    /// <summary>
    /// Runtime information about batch execution.
    /// </summary>
    [TerraformProperty("runtime_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RuntimeInfo { get; }

    /// <summary>
    /// The state of the batch. For possible values, see the [API documentation](https://cloud.google.com/dataproc-serverless/docs/reference/rest/v1/projects.locations.batches#State).
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Historical state information for the batch.
    /// </summary>
    [TerraformProperty("state_history")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StateHistory { get; }

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    [TerraformProperty("state_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateTime { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uuid { get; }

}

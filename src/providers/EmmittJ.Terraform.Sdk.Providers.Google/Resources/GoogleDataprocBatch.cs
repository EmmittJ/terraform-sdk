using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlock
{
}

/// <summary>
/// Block type for pyspark_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchPysparkBatchBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the Spark driver. Must be a .py file.
    /// </summary>
    [TerraformPropertyName("main_python_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MainPythonFileUri { get; set; }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework.
    /// Supported file types: .py, .egg, and .zip.
    /// </summary>
    [TerraformPropertyName("python_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PythonFileUris { get; set; }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchRuntimeConfigBlock
{
    /// <summary>
    /// Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.
    /// </summary>
    [TerraformPropertyName("cohort")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cohort { get; set; }

    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    [TerraformPropertyName("container_image")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContainerImage { get; set; }


    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// Version of the batch runtime.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

}

/// <summary>
/// Block type for spark_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkBatchBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the
    /// classpath or specified in jarFileUris.
    /// </summary>
    [TerraformPropertyName("main_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    [TerraformPropertyName("main_jar_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MainJarFileUri { get; set; }

}

/// <summary>
/// Block type for spark_r_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkRBatchBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R or .r file.
    /// </summary>
    [TerraformPropertyName("main_r_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MainRFileUri { get; set; }

}

/// <summary>
/// Block type for spark_sql_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkSqlBatchBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains Spark SQL queries to execute.
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryFileUri { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    [TerraformPropertyName("query_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? QueryVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocBatchTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_batch resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocBatch : TerraformResource
{
    public GoogleDataprocBatch(string name) : base("google_dataproc_batch", name)
    {
    }

    /// <summary>
    /// The ID to use for the batch, which will become the final component of the batch&#39;s resource name.
    /// This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
    /// </summary>
    [TerraformPropertyName("batch_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BatchId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The labels to associate with this batch.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location in which the batch will be created in.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    [TerraformPropertyName("environment_config")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchEnvironmentConfigBlock>>? EnvironmentConfig { get; set; }

    /// <summary>
    /// Block for pyspark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkBatch block(s) allowed")]
    [TerraformPropertyName("pyspark_batch")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchPysparkBatchBlock>>? PysparkBatch { get; set; }

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    [TerraformPropertyName("runtime_config")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchRuntimeConfigBlock>>? RuntimeConfig { get; set; }

    /// <summary>
    /// Block for spark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkBatch block(s) allowed")]
    [TerraformPropertyName("spark_batch")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchSparkBatchBlock>>? SparkBatch { get; set; }

    /// <summary>
    /// Block for spark_r_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRBatch block(s) allowed")]
    [TerraformPropertyName("spark_r_batch")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchSparkRBatchBlock>>? SparkRBatch { get; set; }

    /// <summary>
    /// Block for spark_sql_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlBatch block(s) allowed")]
    [TerraformPropertyName("spark_sql_batch")]
    public TerraformList<TerraformBlock<GoogleDataprocBatchSparkSqlBatchBlock>>? SparkSqlBatch { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocBatchTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the batch was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The email address of the user who created the batch.
    /// </summary>
    [TerraformPropertyName("creator")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Creator => new TerraformReference(this, "creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The resource name of the batch.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The resource name of the operation associated with this batch.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Operation => new TerraformReference(this, "operation");

    /// <summary>
    /// Runtime information about batch execution.
    /// </summary>
    [TerraformPropertyName("runtime_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RuntimeInfo => new TerraformReference(this, "runtime_info");

    /// <summary>
    /// The state of the batch. For possible values, see the [API documentation](https://cloud.google.com/dataproc-serverless/docs/reference/rest/v1/projects.locations.batches#State).
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Historical state information for the batch.
    /// </summary>
    [TerraformPropertyName("state_history")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StateHistory => new TerraformReference(this, "state_history");

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateMessage => new TerraformReference(this, "state_message");

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    [TerraformPropertyName("state_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateTime => new TerraformReference(this, "state_time");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
    /// </summary>
    [TerraformPropertyName("uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uuid => new TerraformReference(this, "uuid");

}

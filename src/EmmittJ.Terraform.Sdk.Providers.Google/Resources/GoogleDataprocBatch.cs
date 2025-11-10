using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for environment_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchEnvironmentConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for pyspark_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchPysparkBatchBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the Spark driver. Must be a .py file.
    /// </summary>
    public TerraformProperty<string>? MainPythonFileUri
    {
        get => GetProperty<TerraformProperty<string>>("main_python_file_uri");
        set => WithProperty("main_python_file_uri", value);
    }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework.
    /// Supported file types: .py, .egg, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? PythonFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("python_file_uris");
        set => WithProperty("python_file_uris", value);
    }

}

/// <summary>
/// Block type for runtime_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchRuntimeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Cohort identifier. Identifies families of the workloads having the same shape, e.g. daily ETL jobs.
    /// </summary>
    public TerraformProperty<string>? Cohort
    {
        get => GetProperty<TerraformProperty<string>>("cohort");
        set => WithProperty("cohort", value);
    }

    /// <summary>
    /// Optional custom container image for the job runtime environment. If not specified, a default container image will be used.
    /// </summary>
    public TerraformProperty<string>? ContainerImage
    {
        get => GetProperty<TerraformProperty<string>>("container_image");
        set => WithProperty("container_image", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EffectiveProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("effective_properties");
        set => WithProperty("effective_properties", value);
    }

    /// <summary>
    /// A mapping of property names to values, which are used to configure workload execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// Version of the batch runtime.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for spark_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkBatchBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the
    /// classpath or specified in jarFileUris.
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        get => GetProperty<TerraformProperty<string>>("main_class");
        set => WithProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        get => GetProperty<TerraformProperty<string>>("main_jar_file_uri");
        set => WithProperty("main_jar_file_uri", value);
    }

}

/// <summary>
/// Block type for spark_r_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkRBatchBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor.
    /// Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as batch
    /// properties, such as --conf, since a collision can occur that causes an incorrect batch submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R or .r file.
    /// </summary>
    public TerraformProperty<string>? MainRFileUri
    {
        get => GetProperty<TerraformProperty<string>>("main_r_file_uri");
        set => WithProperty("main_r_file_uri", value);
    }

}

/// <summary>
/// Block type for spark_sql_batch in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocBatchSparkSqlBatchBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains Spark SQL queries to execute.
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        get => GetProperty<TerraformProperty<string>>("query_file_uri");
        set => WithProperty("query_file_uri", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? QueryVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("query_variables");
        set => WithProperty("query_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocBatchTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataproc_batch resource.
/// </summary>
public class GoogleDataprocBatch : TerraformResource
{
    public GoogleDataprocBatch(string name) : base("google_dataproc_batch", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("creator");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("operation");
        this.DeclareOutput("runtime_info");
        this.DeclareOutput("state");
        this.DeclareOutput("state_history");
        this.DeclareOutput("state_message");
        this.DeclareOutput("state_time");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uuid");
    }

    /// <summary>
    /// The ID to use for the batch, which will become the final component of the batch&#39;s resource name.
    /// This value must be 4-63 characters. Valid characters are /[a-z][0-9]-/.
    /// </summary>
    public TerraformProperty<string>? BatchId
    {
        get => GetProperty<TerraformProperty<string>>("batch_id");
        set => this.WithProperty("batch_id", value);
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
    /// The labels to associate with this batch.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location in which the batch will be created in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Block for environment_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentConfig block(s) allowed")]
    public List<GoogleDataprocBatchEnvironmentConfigBlock>? EnvironmentConfig
    {
        get => GetProperty<List<GoogleDataprocBatchEnvironmentConfigBlock>>("environment_config");
        set => this.WithProperty("environment_config", value);
    }

    /// <summary>
    /// Block for pyspark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkBatch block(s) allowed")]
    public List<GoogleDataprocBatchPysparkBatchBlock>? PysparkBatch
    {
        get => GetProperty<List<GoogleDataprocBatchPysparkBatchBlock>>("pyspark_batch");
        set => this.WithProperty("pyspark_batch", value);
    }

    /// <summary>
    /// Block for runtime_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimeConfig block(s) allowed")]
    public List<GoogleDataprocBatchRuntimeConfigBlock>? RuntimeConfig
    {
        get => GetProperty<List<GoogleDataprocBatchRuntimeConfigBlock>>("runtime_config");
        set => this.WithProperty("runtime_config", value);
    }

    /// <summary>
    /// Block for spark_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkBatch block(s) allowed")]
    public List<GoogleDataprocBatchSparkBatchBlock>? SparkBatch
    {
        get => GetProperty<List<GoogleDataprocBatchSparkBatchBlock>>("spark_batch");
        set => this.WithProperty("spark_batch", value);
    }

    /// <summary>
    /// Block for spark_r_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRBatch block(s) allowed")]
    public List<GoogleDataprocBatchSparkRBatchBlock>? SparkRBatch
    {
        get => GetProperty<List<GoogleDataprocBatchSparkRBatchBlock>>("spark_r_batch");
        set => this.WithProperty("spark_r_batch", value);
    }

    /// <summary>
    /// Block for spark_sql_batch.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlBatch block(s) allowed")]
    public List<GoogleDataprocBatchSparkSqlBatchBlock>? SparkSqlBatch
    {
        get => GetProperty<List<GoogleDataprocBatchSparkSqlBatchBlock>>("spark_sql_batch");
        set => this.WithProperty("spark_sql_batch", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocBatchTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocBatchTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the batch was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The email address of the user who created the batch.
    /// </summary>
    public TerraformExpression Creator => this["creator"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of the batch.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource name of the operation associated with this batch.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

    /// <summary>
    /// Runtime information about batch execution.
    /// </summary>
    public TerraformExpression RuntimeInfo => this["runtime_info"];

    /// <summary>
    /// The state of the batch. For possible values, see the [API documentation](https://cloud.google.com/dataproc-serverless/docs/reference/rest/v1/projects.locations.batches#State).
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Historical state information for the batch.
    /// </summary>
    public TerraformExpression StateHistory => this["state_history"];

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// Batch state details, such as a failure description if the state is FAILED.
    /// </summary>
    public TerraformExpression StateTime => this["state_time"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// A batch UUID (Unique Universal Identifier). The service generates this value when it creates the batch.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}

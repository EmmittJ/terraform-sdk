using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hadoop_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHadoopConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        set => SetProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        set => SetProperty("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

}

/// <summary>
/// Block type for hive_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHiveConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ContinueOnFailure
    {
        set => SetProperty("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        set => SetProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        set => SetProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Hive command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        set => SetProperty("script_variables", value);
    }

}

/// <summary>
/// Block type for pig_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPigConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ContinueOnFailure
    {
        set => SetProperty("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        set => SetProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        set => SetProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Pig command: name=[value]).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        set => SetProperty("script_variables", value);
    }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPlacementBlock : TerraformBlock
{
    /// <summary>
    /// The name of the cluster where the job will be submitted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// Output-only. A cluster UUID generated by the Cloud Dataproc service when the job is submitted
    /// </summary>
    public TerraformProperty<string>? ClusterUuid
    {
        set => SetProperty("cluster_uuid", value);
    }

}

/// <summary>
/// Block type for presto_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPrestoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Presto client tags to attach to this query.
    /// </summary>
    public List<TerraformProperty<string>>? ClientTags
    {
        set => SetProperty("client_tags", value);
    }

    /// <summary>
    /// Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ContinueOnFailure
    {
        set => SetProperty("continue_on_failure", value);
    }

    /// <summary>
    /// The format in which query output will be displayed. See the Presto documentation for supported output formats.
    /// </summary>
    public TerraformProperty<string>? OutputFormat
    {
        set => SetProperty("output_format", value);
    }

    /// <summary>
    /// A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        set => SetProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        set => SetProperty("query_list", value);
    }

}

/// <summary>
/// Block type for pyspark_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPysparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformProperty<string> MainPythonFileUri
    {
        set => SetProperty("main_python_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip
    /// </summary>
    public List<TerraformProperty<string>>? PythonFileUris
    {
        set => SetProperty("python_file_uris", value);
    }

}

/// <summary>
/// Block type for reference in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The job ID, which must be unique within the project. The job ID is generated by the server upon job submission or provided by the user as a means to perform retries without creating duplicate jobs
    /// </summary>
    public TerraformProperty<string>? JobId
    {
        set => SetProperty("job_id", value);
    }

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresPerHour is required")]
    public required TerraformProperty<double> MaxFailuresPerHour
    {
        set => SetProperty("max_failures_per_hour", value);
    }

    /// <summary>
    /// Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresTotal is required")]
    public required TerraformProperty<double> MaxFailuresTotal
    {
        set => SetProperty("max_failures_total", value);
    }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        set => SetProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        set => SetProperty("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

}

/// <summary>
/// Block type for sparksql_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparksqlConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark SQL&#39;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        set => SetProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        set => SetProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        set => SetProperty("script_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocJobTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_dataproc_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocJob : TerraformResource
{
    public GoogleDataprocJob(string name) : base("google_dataproc_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("driver_controls_files_uri");
        SetOutput("driver_output_resource_uri");
        SetOutput("effective_labels");
        SetOutput("status");
        SetOutput("terraform_labels");
        SetOutput("force_delete");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("project");
        SetOutput("region");
    }

    /// <summary>
    /// By default, you can only delete inactive jobs within Dataproc. Setting this to true, and calling destroy, will ensure that the job is first cancelled before issuing the delete.
    /// </summary>
    public TerraformProperty<bool> ForceDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_delete");
        set => SetProperty("force_delete", value);
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
    /// Optional. The labels to associate with this job.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The project in which the cluster can be found and jobs subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for hadoop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HadoopConfig block(s) allowed")]
    public List<GoogleDataprocJobHadoopConfigBlock>? HadoopConfig
    {
        set => SetProperty("hadoop_config", value);
    }

    /// <summary>
    /// Block for hive_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveConfig block(s) allowed")]
    public List<GoogleDataprocJobHiveConfigBlock>? HiveConfig
    {
        set => SetProperty("hive_config", value);
    }

    /// <summary>
    /// Block for pig_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PigConfig block(s) allowed")]
    public List<GoogleDataprocJobPigConfigBlock>? PigConfig
    {
        set => SetProperty("pig_config", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Placement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<GoogleDataprocJobPlacementBlock>? Placement
    {
        set => SetProperty("placement", value);
    }

    /// <summary>
    /// Block for presto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrestoConfig block(s) allowed")]
    public List<GoogleDataprocJobPrestoConfigBlock>? PrestoConfig
    {
        set => SetProperty("presto_config", value);
    }

    /// <summary>
    /// Block for pyspark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkConfig block(s) allowed")]
    public List<GoogleDataprocJobPysparkConfigBlock>? PysparkConfig
    {
        set => SetProperty("pyspark_config", value);
    }

    /// <summary>
    /// Block for reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Reference block(s) allowed")]
    public List<GoogleDataprocJobReferenceBlock>? Reference
    {
        set => SetProperty("reference", value);
    }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public List<GoogleDataprocJobSchedulingBlock>? Scheduling
    {
        set => SetProperty("scheduling", value);
    }

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public List<GoogleDataprocJobSparkConfigBlock>? SparkConfig
    {
        set => SetProperty("spark_config", value);
    }

    /// <summary>
    /// Block for sparksql_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparksqlConfig block(s) allowed")]
    public List<GoogleDataprocJobSparksqlConfigBlock>? SparksqlConfig
    {
        set => SetProperty("sparksql_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output-only. If present, the location of miscellaneous control files which may be used as part of job setup and handling. If not present, control files may be placed in the same location as driver_output_uri.
    /// </summary>
    public TerraformExpression DriverControlsFilesUri => this["driver_controls_files_uri"];

    /// <summary>
    /// Output-only. A URI pointing to the location of the stdout of the job&#39;s driver program
    /// </summary>
    public TerraformExpression DriverOutputResourceUri => this["driver_output_resource_uri"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The status of the job.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}

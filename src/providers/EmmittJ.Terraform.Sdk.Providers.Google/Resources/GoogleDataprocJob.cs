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
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        get => GetProperty<TerraformProperty<string>>("main_class");
        set => WithProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        get => GetProperty<TerraformProperty<string>>("main_jar_file_uri");
        set => WithProperty("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
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
        get => GetProperty<TerraformProperty<bool>>("continue_on_failure");
        set => WithProperty("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        get => GetProperty<TerraformProperty<string>>("query_file_uri");
        set => WithProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        get => GetProperty<List<TerraformProperty<string>>>("query_list");
        set => WithProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Hive command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("script_variables");
        set => WithProperty("script_variables", value);
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
        get => GetProperty<TerraformProperty<bool>>("continue_on_failure");
        set => WithProperty("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        get => GetProperty<TerraformProperty<string>>("query_file_uri");
        set => WithProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        get => GetProperty<List<TerraformProperty<string>>>("query_list");
        set => WithProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Pig command: name=[value]).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("script_variables");
        set => WithProperty("script_variables", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("cluster_name");
        set => WithProperty("cluster_name", value);
    }

    /// <summary>
    /// Output-only. A cluster UUID generated by the Cloud Dataproc service when the job is submitted
    /// </summary>
    public TerraformProperty<string>? ClusterUuid
    {
        get => GetProperty<TerraformProperty<string>>("cluster_uuid");
        set => WithProperty("cluster_uuid", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("client_tags");
        set => WithProperty("client_tags", value);
    }

    /// <summary>
    /// Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? ContinueOnFailure
    {
        get => GetProperty<TerraformProperty<bool>>("continue_on_failure");
        set => WithProperty("continue_on_failure", value);
    }

    /// <summary>
    /// The format in which query output will be displayed. See the Presto documentation for supported output formats.
    /// </summary>
    public TerraformProperty<string>? OutputFormat
    {
        get => GetProperty<TerraformProperty<string>>("output_format");
        set => WithProperty("output_format", value);
    }

    /// <summary>
    /// A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        get => GetProperty<TerraformProperty<string>>("query_file_uri");
        set => WithProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        get => GetProperty<List<TerraformProperty<string>>>("query_list");
        set => WithProperty("query_list", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformProperty<string> MainPythonFileUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("main_python_file_uri");
        set => WithProperty("main_python_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip
    /// </summary>
    public List<TerraformProperty<string>>? PythonFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("python_file_uris");
        set => WithProperty("python_file_uris", value);
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
        get => GetProperty<TerraformProperty<string>>("job_id");
        set => WithProperty("job_id", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("max_failures_per_hour");
        set => WithProperty("max_failures_per_hour", value);
    }

    /// <summary>
    /// Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresTotal is required")]
    public required TerraformProperty<double> MaxFailuresTotal
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_failures_total");
        set => WithProperty("max_failures_total", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("archive_uris");
        set => WithProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_uris");
        set => WithProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        get => GetProperty<TerraformProperty<string>>("main_class");
        set => WithProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        get => GetProperty<TerraformProperty<string>>("main_jar_file_uri");
        set => WithProperty("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("jar_file_uris");
        set => WithProperty("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark SQL&#39;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        get => GetProperty<TerraformProperty<string>>("query_file_uri");
        set => WithProperty("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public List<TerraformProperty<string>>? QueryList
    {
        get => GetProperty<List<TerraformProperty<string>>>("query_list");
        set => WithProperty("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ScriptVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("script_variables");
        set => WithProperty("script_variables", value);
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
        this.WithOutput("driver_controls_files_uri");
        this.WithOutput("driver_output_resource_uri");
        this.WithOutput("effective_labels");
        this.WithOutput("status");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// By default, you can only delete inactive jobs within Dataproc. Setting this to true, and calling destroy, will ensure that the job is first cancelled before issuing the delete.
    /// </summary>
    public TerraformProperty<bool>? ForceDelete
    {
        get => GetProperty<TerraformProperty<bool>>("force_delete");
        set => this.WithProperty("force_delete", value);
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
    /// Optional. The labels to associate with this job.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The project in which the cluster can be found and jobs subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for hadoop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HadoopConfig block(s) allowed")]
    public List<GoogleDataprocJobHadoopConfigBlock>? HadoopConfig
    {
        get => GetProperty<List<GoogleDataprocJobHadoopConfigBlock>>("hadoop_config");
        set => this.WithProperty("hadoop_config", value);
    }

    /// <summary>
    /// Block for hive_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveConfig block(s) allowed")]
    public List<GoogleDataprocJobHiveConfigBlock>? HiveConfig
    {
        get => GetProperty<List<GoogleDataprocJobHiveConfigBlock>>("hive_config");
        set => this.WithProperty("hive_config", value);
    }

    /// <summary>
    /// Block for pig_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PigConfig block(s) allowed")]
    public List<GoogleDataprocJobPigConfigBlock>? PigConfig
    {
        get => GetProperty<List<GoogleDataprocJobPigConfigBlock>>("pig_config");
        set => this.WithProperty("pig_config", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<GoogleDataprocJobPlacementBlock>? Placement
    {
        get => GetProperty<List<GoogleDataprocJobPlacementBlock>>("placement");
        set => this.WithProperty("placement", value);
    }

    /// <summary>
    /// Block for presto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrestoConfig block(s) allowed")]
    public List<GoogleDataprocJobPrestoConfigBlock>? PrestoConfig
    {
        get => GetProperty<List<GoogleDataprocJobPrestoConfigBlock>>("presto_config");
        set => this.WithProperty("presto_config", value);
    }

    /// <summary>
    /// Block for pyspark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkConfig block(s) allowed")]
    public List<GoogleDataprocJobPysparkConfigBlock>? PysparkConfig
    {
        get => GetProperty<List<GoogleDataprocJobPysparkConfigBlock>>("pyspark_config");
        set => this.WithProperty("pyspark_config", value);
    }

    /// <summary>
    /// Block for reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Reference block(s) allowed")]
    public List<GoogleDataprocJobReferenceBlock>? Reference
    {
        get => GetProperty<List<GoogleDataprocJobReferenceBlock>>("reference");
        set => this.WithProperty("reference", value);
    }

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public List<GoogleDataprocJobSchedulingBlock>? Scheduling
    {
        get => GetProperty<List<GoogleDataprocJobSchedulingBlock>>("scheduling");
        set => this.WithProperty("scheduling", value);
    }

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public List<GoogleDataprocJobSparkConfigBlock>? SparkConfig
    {
        get => GetProperty<List<GoogleDataprocJobSparkConfigBlock>>("spark_config");
        set => this.WithProperty("spark_config", value);
    }

    /// <summary>
    /// Block for sparksql_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparksqlConfig block(s) allowed")]
    public List<GoogleDataprocJobSparksqlConfigBlock>? SparksqlConfig
    {
        get => GetProperty<List<GoogleDataprocJobSparksqlConfigBlock>>("sparksql_config");
        set => this.WithProperty("sparksql_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataprocJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

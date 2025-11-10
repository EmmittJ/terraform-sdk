using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hadoop_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHadoopConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    [TerraformPropertyName("main_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    [TerraformPropertyName("main_jar_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainJarFileUri { get; set; }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

}

/// <summary>
/// Block type for hive_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHiveConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    [TerraformPropertyName("continue_on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContinueOnFailure { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    [TerraformPropertyName("query_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? QueryList { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Hive command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    [TerraformPropertyName("script_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ScriptVariables { get; set; }

}

/// <summary>
/// Block type for pig_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPigConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    [TerraformPropertyName("continue_on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContinueOnFailure { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFileUri { get; set; }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    [TerraformPropertyName("query_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? QueryList { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Pig command: name=[value]).
    /// </summary>
    [TerraformPropertyName("script_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ScriptVariables { get; set; }

}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPlacementBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the cluster where the job will be submitted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// Output-only. A cluster UUID generated by the Cloud Dataproc service when the job is submitted
    /// </summary>
    [TerraformPropertyName("cluster_uuid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterUuid => new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_uuid");

}

/// <summary>
/// Block type for presto_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPrestoConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Presto client tags to attach to this query.
    /// </summary>
    [TerraformPropertyName("client_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ClientTags { get; set; }

    /// <summary>
    /// Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    [TerraformPropertyName("continue_on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ContinueOnFailure { get; set; }

    /// <summary>
    /// The format in which query output will be displayed. See the Presto documentation for supported output formats.
    /// </summary>
    [TerraformPropertyName("output_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputFormat { get; set; }

    /// <summary>
    /// A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    [TerraformPropertyName("query_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? QueryList { get; set; }

}

/// <summary>
/// Block type for pyspark_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPysparkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// Optional. HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    [TerraformPropertyName("main_python_file_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MainPythonFileUri { get; set; }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip
    /// </summary>
    [TerraformPropertyName("python_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PythonFileUris { get; set; }

}

/// <summary>
/// Block type for reference in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// The job ID, which must be unique within the project. The job ID is generated by the server upon job submission or provided by the user as a means to perform retries without creating duplicate jobs
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> JobId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "job_id");

}

/// <summary>
/// Block type for scheduling in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSchedulingBlock : ITerraformBlock
{
    /// <summary>
    /// Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresPerHour is required")]
    [TerraformPropertyName("max_failures_per_hour")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxFailuresPerHour { get; set; }

    /// <summary>
    /// Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresTotal is required")]
    [TerraformPropertyName("max_failures_total")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxFailuresTotal { get; set; }

}

/// <summary>
/// Block type for spark_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    [TerraformPropertyName("main_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    [TerraformPropertyName("main_jar_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainJarFileUri { get; set; }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

}

/// <summary>
/// Block type for sparksql_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparksqlConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark SQL&#39;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFileUri { get; set; }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    [TerraformPropertyName("query_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? QueryList { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    [TerraformPropertyName("script_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ScriptVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocJobTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_dataproc_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocJob : TerraformResource
{
    public GoogleDataprocJob(string name) : base("google_dataproc_job", name)
    {
    }

    /// <summary>
    /// By default, you can only delete inactive jobs within Dataproc. Setting this to true, and calling destroy, will ensure that the job is first cancelled before issuing the delete.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDelete { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Optional. The labels to associate with this job.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The project in which the cluster can be found and jobs subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// Block for hadoop_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HadoopConfig block(s) allowed")]
    [TerraformPropertyName("hadoop_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobHadoopConfigBlock>>? HadoopConfig { get; set; } = new();

    /// <summary>
    /// Block for hive_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveConfig block(s) allowed")]
    [TerraformPropertyName("hive_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobHiveConfigBlock>>? HiveConfig { get; set; } = new();

    /// <summary>
    /// Block for pig_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PigConfig block(s) allowed")]
    [TerraformPropertyName("pig_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobPigConfigBlock>>? PigConfig { get; set; } = new();

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Placement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    [TerraformPropertyName("placement")]
    public TerraformList<TerraformBlock<GoogleDataprocJobPlacementBlock>>? Placement { get; set; } = new();

    /// <summary>
    /// Block for presto_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrestoConfig block(s) allowed")]
    [TerraformPropertyName("presto_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobPrestoConfigBlock>>? PrestoConfig { get; set; } = new();

    /// <summary>
    /// Block for pyspark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkConfig block(s) allowed")]
    [TerraformPropertyName("pyspark_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobPysparkConfigBlock>>? PysparkConfig { get; set; } = new();

    /// <summary>
    /// Block for reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Reference block(s) allowed")]
    [TerraformPropertyName("reference")]
    public TerraformList<TerraformBlock<GoogleDataprocJobReferenceBlock>>? Reference { get; set; } = new();

    /// <summary>
    /// Block for scheduling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    [TerraformPropertyName("scheduling")]
    public TerraformList<TerraformBlock<GoogleDataprocJobSchedulingBlock>>? Scheduling { get; set; } = new();

    /// <summary>
    /// Block for spark_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    [TerraformPropertyName("spark_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobSparkConfigBlock>>? SparkConfig { get; set; } = new();

    /// <summary>
    /// Block for sparksql_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparksqlConfig block(s) allowed")]
    [TerraformPropertyName("sparksql_config")]
    public TerraformList<TerraformBlock<GoogleDataprocJobSparksqlConfigBlock>>? SparksqlConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output-only. If present, the location of miscellaneous control files which may be used as part of job setup and handling. If not present, control files may be placed in the same location as driver_output_uri.
    /// </summary>
    [TerraformPropertyName("driver_controls_files_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DriverControlsFilesUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "driver_controls_files_uri");

    /// <summary>
    /// Output-only. A URI pointing to the location of the stdout of the job&#39;s driver program
    /// </summary>
    [TerraformPropertyName("driver_output_resource_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DriverOutputResourceUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "driver_output_resource_uri");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The status of the job.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}

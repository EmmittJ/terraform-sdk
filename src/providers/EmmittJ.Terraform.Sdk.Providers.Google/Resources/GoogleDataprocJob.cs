using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hadoop_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHadoopConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hadoop_config";

    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformValue<string>? MainJarFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_jar_file_uri");
        set => SetArgument("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobHadoopConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobHadoopConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobHadoopConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHadoopConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for hive_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobHiveConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_config";

    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public TerraformList<string>? QueryList
    {
        get => GetArgument<TerraformList<string>>("query_list");
        set => SetArgument("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Hive command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public TerraformMap<string>? ScriptVariables
    {
        get => GetArgument<TerraformMap<string>>("script_variables");
        set => SetArgument("script_variables", value);
    }

}


/// <summary>
/// Block type for pig_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPigConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pig_config";

    /// <summary>
    /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// HCFS URI of file containing Hive script to execute as the job. Conflicts with query_list
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// The list of Hive queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public TerraformList<string>? QueryList
    {
        get => GetArgument<TerraformList<string>>("query_list");
        set => SetArgument("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Pig command: name=[value]).
    /// </summary>
    public TerraformMap<string>? ScriptVariables
    {
        get => GetArgument<TerraformMap<string>>("script_variables");
        set => SetArgument("script_variables", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPigConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPigConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobPigConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPigConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for placement in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement";

    /// <summary>
    /// The name of the cluster where the job will be submitted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// Output-only. A cluster UUID generated by the Cloud Dataproc service when the job is submitted
    /// </summary>
    public TerraformValue<string> ClusterUuid
        => AsReference("cluster_uuid");

}


/// <summary>
/// Block type for presto_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPrestoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "presto_config";

    /// <summary>
    /// Presto client tags to attach to this query.
    /// </summary>
    public TerraformList<string>? ClientTags
    {
        get => GetArgument<TerraformList<string>>("client_tags");
        set => SetArgument("client_tags", value);
    }

    /// <summary>
    /// Whether to continue executing queries if a query fails. Setting to true can be useful when executing independent parallel queries. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// The format in which query output will be displayed. See the Presto documentation for supported output formats.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => GetArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// A mapping of property names to values. Used to set Presto session properties Equivalent to using the --session flag in the Presto CLI.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public TerraformList<string>? QueryList
    {
        get => GetArgument<TerraformList<string>>("query_list");
        set => SetArgument("query_list", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPrestoConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPrestoConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobPrestoConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPrestoConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for pyspark_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPysparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pyspark_config";

    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as --conf, that can be set as job properties, since a collision may occur that causes an incorrect job submission
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be copied to the working directory of Python drivers and distributed tasks. Useful for naively parallel tasks
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformValue<string> MainPythonFileUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("main_python_file_uri");
        set => SetArgument("main_python_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip
    /// </summary>
    public TerraformList<string>? PythonFileUris
    {
        get => GetArgument<TerraformList<string>>("python_file_uris");
        set => SetArgument("python_file_uris", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPysparkConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPysparkConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobPysparkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobPysparkConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for reference in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference";

    /// <summary>
    /// The job ID, which must be unique within the project. The job ID is generated by the server upon job submission or provided by the user as a means to perform retries without creating duplicate jobs
    /// </summary>
    public TerraformValue<string> JobId
    {
        get => GetArgument<TerraformValue<string>>("job_id") ?? AsReference("job_id");
        set => SetArgument("job_id", value);
    }

}


/// <summary>
/// Block type for scheduling in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduling";

    /// <summary>
    /// Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresPerHour is required")]
    public required TerraformValue<double> MaxFailuresPerHour
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_failures_per_hour");
        set => SetArgument("max_failures_per_hour", value);
    }

    /// <summary>
    /// Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFailuresTotal is required")]
    public required TerraformValue<double> MaxFailuresTotal
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_failures_total");
        set => SetArgument("max_failures_total", value);
    }

}


/// <summary>
/// Block type for spark_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_config";

    /// <summary>
    /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be copied to the working directory of Spark drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The class containing the main method of the driver. Must be in a provided jar or jar that is already on the classpath. Conflicts with main_jar_file_uri
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of jar file containing the driver jar. Conflicts with main_class
    /// </summary>
    public TerraformValue<string>? MainJarFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_jar_file_uri");
        set => SetArgument("main_jar_file_uri", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Cloud Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobSparkConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobSparkConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobSparkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparkConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for sparksql_config in GoogleDataprocJob.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparksqlConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sparksql_config";

    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// A mapping of property names to values, used to configure Spark SQL&#39;s SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries. Conflicts with query_list
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// The list of SQL queries or statements to execute as part of the job. Conflicts with query_file_uri
    /// </summary>
    public TerraformList<string>? QueryList
    {
        get => GetArgument<TerraformList<string>>("query_list");
        set => SetArgument("query_list", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET name=&amp;quot;value&amp;quot;;).
    /// </summary>
    public TerraformMap<string>? ScriptVariables
    {
        get => GetArgument<TerraformMap<string>>("script_variables");
        set => SetArgument("script_variables", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobSparksqlConfigBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobSparksqlConfigBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocJobSparksqlConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocJobSparksqlConfigBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// Optional. The per-package log levels for the driver. This may include &#39;root&#39; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DriverLogLevels is required")]
    public required TerraformMap<string> DriverLogLevels
    {
        get => GetRequiredArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocJob.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocJobTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_dataproc_job Terraform resource.
/// Manages a google_dataproc_job resource.
/// </summary>
public partial class GoogleDataprocJob(string name) : TerraformResource("google_dataproc_job", name)
{
    /// <summary>
    /// By default, you can only delete inactive jobs within Dataproc. Setting this to true, and calling destroy, will ensure that the job is first cancelled before issuing the delete.
    /// </summary>
    public TerraformValue<bool>? ForceDelete
    {
        get => GetArgument<TerraformValue<bool>>("force_delete");
        set => SetArgument("force_delete", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. The labels to associate with this job.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The project in which the cluster can be found and jobs subsequently run against. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Cloud Dataproc region. This essentially determines which clusters are available for this job to be submitted to. If not specified, defaults to global.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Output-only. If present, the location of miscellaneous control files which may be used as part of job setup and handling. If not present, control files may be placed in the same location as driver_output_uri.
    /// </summary>
    public TerraformValue<string> DriverControlsFilesUri
        => AsReference("driver_controls_files_uri");

    /// <summary>
    /// Output-only. A URI pointing to the location of the stdout of the job&#39;s driver program
    /// </summary>
    public TerraformValue<string> DriverOutputResourceUri
        => AsReference("driver_output_resource_uri");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The status of the job.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// HadoopConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HadoopConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobHadoopConfigBlock>? HadoopConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobHadoopConfigBlock>>("hadoop_config");
        set => SetArgument("hadoop_config", value);
    }

    /// <summary>
    /// HiveConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobHiveConfigBlock>? HiveConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobHiveConfigBlock>>("hive_config");
        set => SetArgument("hive_config", value);
    }

    /// <summary>
    /// PigConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PigConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPigConfigBlock>? PigConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPigConfigBlock>>("pig_config");
        set => SetArgument("pig_config", value);
    }

    /// <summary>
    /// Placement block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Placement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public required TerraformList<GoogleDataprocJobPlacementBlock> Placement
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocJobPlacementBlock>>("placement");
        set => SetArgument("placement", value);
    }

    /// <summary>
    /// PrestoConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrestoConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPrestoConfigBlock>? PrestoConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPrestoConfigBlock>>("presto_config");
        set => SetArgument("presto_config", value);
    }

    /// <summary>
    /// PysparkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobPysparkConfigBlock>? PysparkConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobPysparkConfigBlock>>("pyspark_config");
        set => SetArgument("pyspark_config", value);
    }

    /// <summary>
    /// Reference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Reference block(s) allowed")]
    public TerraformList<GoogleDataprocJobReferenceBlock>? Reference
    {
        get => GetArgument<TerraformList<GoogleDataprocJobReferenceBlock>>("reference");
        set => SetArgument("reference", value);
    }

    /// <summary>
    /// Scheduling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public TerraformList<GoogleDataprocJobSchedulingBlock>? Scheduling
    {
        get => GetArgument<TerraformList<GoogleDataprocJobSchedulingBlock>>("scheduling");
        set => SetArgument("scheduling", value);
    }

    /// <summary>
    /// SparkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobSparkConfigBlock>? SparkConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobSparkConfigBlock>>("spark_config");
        set => SetArgument("spark_config", value);
    }

    /// <summary>
    /// SparksqlConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparksqlConfig block(s) allowed")]
    public TerraformList<GoogleDataprocJobSparksqlConfigBlock>? SparksqlConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocJobSparksqlConfigBlock>>("sparksql_config");
        set => SetArgument("sparksql_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

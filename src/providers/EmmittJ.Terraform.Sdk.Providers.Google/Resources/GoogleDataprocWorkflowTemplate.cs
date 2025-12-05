using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in GoogleDataprocWorkflowTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// Optional. The Cloud KMS key name to use for encryption.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for jobs in GoogleDataprocWorkflowTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jobs";

    /// <summary>
    /// Optional. The labels to associate with this job. Label keys must be between 1 and 63 characters long, and must conform to the following regular expression: p{Ll}p{Lo}{0,62} Label values must be between 1 and 63 characters long, and must conform to the following regular expression: [p{Ll}p{Lo}p{N}_-]{0,63} No more than 32 labels can be associated with a given job.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Optional. The optional list of prerequisite job step_ids. If not specified, the job will start at the beginning of workflow.
    /// </summary>
    public TerraformList<string>? PrerequisiteStepIds
    {
        get => GetArgument<TerraformList<string>>("prerequisite_step_ids");
        set => SetArgument("prerequisite_step_ids", value);
    }

    /// <summary>
    /// Required. The step id. The id must be unique among all jobs within the template. The step id is used as prefix for job id, as job `goog-dataproc-workflow-step-id` label, and in prerequisiteStepIds field from other steps. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_), and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between 3 and 50 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StepId is required")]
    public required TerraformValue<string> StepId
    {
        get => GetRequiredArgument<TerraformValue<string>>("step_id");
        set => SetArgument("step_id", value);
    }

    /// <summary>
    /// HadoopJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HadoopJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlock>? HadoopJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlock>>("hadoop_job");
        set => SetArgument("hadoop_job", value);
    }

    /// <summary>
    /// HiveJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlock>? HiveJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlock>>("hive_job");
        set => SetArgument("hive_job", value);
    }

    /// <summary>
    /// PigJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PigJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlock>? PigJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlock>>("pig_job");
        set => SetArgument("pig_job", value);
    }

    /// <summary>
    /// PrestoJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrestoJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlock>? PrestoJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlock>>("presto_job");
        set => SetArgument("presto_job", value);
    }

    /// <summary>
    /// PysparkJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlock>? PysparkJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlock>>("pyspark_job");
        set => SetArgument("pyspark_job", value);
    }

    /// <summary>
    /// Scheduling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduling block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSchedulingBlock>? Scheduling
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSchedulingBlock>>("scheduling");
        set => SetArgument("scheduling", value);
    }

    /// <summary>
    /// SparkJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlock>? SparkJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlock>>("spark_job");
        set => SetArgument("spark_job", value);
    }

    /// <summary>
    /// SparkRJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlock>? SparkRJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlock>>("spark_r_job");
        set => SetArgument("spark_r_job", value);
    }

    /// <summary>
    /// SparkSqlJob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlJob block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlock>? SparkSqlJob
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlock>>("spark_sql_job");
        set => SetArgument("spark_sql_job", value);
    }

}

/// <summary>
/// Block type for hadoop_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hadoop_job";

    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted in the working directory of Hadoop drivers and tasks. Supported file types: .jar, .tar, .tar.gz, .tgz, or .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as `-libjars` or `-Dfoo=bar`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Optional. HCFS (Hadoop Compatible Filesystem) URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Optional. Jar file URIs to add to the CLASSPATHs of the Hadoop driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The name of the driver&#39;s main class. The jar file containing the class must be in the default CLASSPATH or specified in `jar_file_uris`.
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of the jar file containing the main class. Examples: &#39;gs://foo-bucket/analytics-binaries/extract-useful-metrics-mr.jar&#39; &#39;hdfs:/tmp/test-samples/custom-wordcount.jar&#39; &#39;file:///home/usr/lib/hadoop-mapreduce/hadoop-mapreduce-examples.jar&#39;
    /// </summary>
    public TerraformValue<string>? MainJarFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_jar_file_uri");
        set => SetArgument("main_jar_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure Hadoop. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site and classes in user code.
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockHadoopJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for hive_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_job";

    /// <summary>
    /// Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATH of the Hive server and Hadoop MapReduce (MR) tasks. Can contain Hive SerDes and UDFs.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// Optional. A mapping of property names and values, used to configure Hive. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/hive/conf/hive-site.xml, and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains Hive queries.
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// Optional. Mapping of query variable names to values (equivalent to the Hive command: `SET name=&amp;quot;value&amp;quot;;`).
    /// </summary>
    public TerraformMap<string>? ScriptVariables
    {
        get => GetArgument<TerraformMap<string>>("script_variables");
        set => SetArgument("script_variables", value);
    }

    /// <summary>
    /// QueryList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryList block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlockQueryListBlock>? QueryList
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlockQueryListBlock>>("query_list");
        set => SetArgument("query_list", value);
    }

}

/// <summary>
/// Block type for query_list in GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockHiveJobBlockQueryListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_list";

    /// <summary>
    /// Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &amp;quot;hiveJob&amp;quot;: { &amp;quot;queryList&amp;quot;: { &amp;quot;queries&amp;quot;: [ &amp;quot;query1&amp;quot;, &amp;quot;query2&amp;quot;, &amp;quot;query3;query4&amp;quot;, ] } }
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queries is required")]
    public TerraformList<string>? Queries
    {
        get => GetArgument<TerraformList<string>>("queries");
        set => SetArgument("queries", value);
    }

}

/// <summary>
/// Block type for pig_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPigJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pig_job";

    /// <summary>
    /// Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATH of the Pig Client and Hadoop MapReduce (MR) tasks. Can contain Pig UDFs.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure Pig. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/hadoop/conf/*-site.xml, /etc/pig/conf/pig.properties, and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains the Pig queries.
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// Optional. Mapping of query variable names to values (equivalent to the Pig command: `name=[value]`).
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// QueryList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryList block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockQueryListBlock>? QueryList
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockQueryListBlock>>("query_list");
        set => SetArgument("query_list", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockPigJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for query_list in GoogleDataprocWorkflowTemplateJobsBlockPigJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPigJobBlockQueryListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_list";

    /// <summary>
    /// Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &amp;quot;hiveJob&amp;quot;: { &amp;quot;queryList&amp;quot;: { &amp;quot;queries&amp;quot;: [ &amp;quot;query1&amp;quot;, &amp;quot;query2&amp;quot;, &amp;quot;query3;query4&amp;quot;, ] } }
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queries is required")]
    public TerraformList<string>? Queries
    {
        get => GetArgument<TerraformList<string>>("queries");
        set => SetArgument("queries", value);
    }

}

/// <summary>
/// Block type for presto_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "presto_job";

    /// <summary>
    /// Optional. Presto client tags to attach to this query
    /// </summary>
    public TerraformList<string>? ClientTags
    {
        get => GetArgument<TerraformList<string>>("client_tags");
        set => SetArgument("client_tags", value);
    }

    /// <summary>
    /// Optional. Whether to continue executing queries if a query fails. The default value is `false`. Setting to `true` can be useful when executing independent parallel queries.
    /// </summary>
    public TerraformValue<bool>? ContinueOnFailure
    {
        get => GetArgument<TerraformValue<bool>>("continue_on_failure");
        set => SetArgument("continue_on_failure", value);
    }

    /// <summary>
    /// Optional. The format in which query output will be displayed. See the Presto documentation for supported output formats
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => GetArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values. Used to set Presto [session properties](https://prestodb.io/docs/current/sql/set-session.html) Equivalent to using the --session flag in the Presto CLI
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// QueryList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryList block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockQueryListBlock>? QueryList
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockQueryListBlock>>("query_list");
        set => SetArgument("query_list", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for query_list in GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPrestoJobBlockQueryListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_list";

    /// <summary>
    /// Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &amp;quot;hiveJob&amp;quot;: { &amp;quot;queryList&amp;quot;: { &amp;quot;queries&amp;quot;: [ &amp;quot;query1&amp;quot;, &amp;quot;query2&amp;quot;, &amp;quot;query3;query4&amp;quot;, ] } }
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queries is required")]
    public TerraformList<string>? Queries
    {
        get => GetArgument<TerraformList<string>>("queries");
        set => SetArgument("queries", value);
    }

}

/// <summary>
/// Block type for pyspark_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pyspark_job";

    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// Required. The HCFS URI of the main Python file to use as the driver. Must be a .py file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformValue<string> MainPythonFileUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("main_python_file_uri");
        set => SetArgument("main_python_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure PySpark. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Optional. HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockPysparkJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for scheduling in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSchedulingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduling";

    /// <summary>
    /// Optional. Maximum number of times per hour a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. A job may be reported as thrashing if driver exits with non-zero code 4 times within 10 minute window. Maximum value is 10.
    /// </summary>
    public TerraformValue<double>? MaxFailuresPerHour
    {
        get => GetArgument<TerraformValue<double>>("max_failures_per_hour");
        set => SetArgument("max_failures_per_hour", value);
    }

    /// <summary>
    /// Optional. Maximum number of times in total a driver may be restarted as a result of driver exiting with non-zero code before job is reported failed. Maximum value is 240.
    /// </summary>
    public TerraformValue<double>? MaxFailuresTotal
    {
        get => GetArgument<TerraformValue<double>>("max_failures_total");
        set => SetArgument("max_failures_total", value);
    }

}

/// <summary>
/// Block type for spark_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_job";

    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of jar files to add to the CLASSPATHs of the Spark driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The name of the driver&#39;s main class. The jar file that contains the class must be in the default CLASSPATH or specified in `jar_file_uris`.
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

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure Spark. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for spark_r_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_r_job";

    /// <summary>
    /// Optional. HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Optional. The arguments to pass to the driver. Do not include arguments, such as `--conf`, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Optional. HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// Required. The HCFS URI of the main R file to use as the driver. Must be a .R file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainRFileUri is required")]
    public required TerraformValue<string> MainRFileUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("main_r_file_uri");
        set => SetArgument("main_r_file_uri", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure SparkR. Properties that conflict with values set by the Dataproc API may be overwritten. Can include properties set in /etc/spark/conf/spark-defaults.conf and classes in user code.
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkRJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for spark_sql_job in GoogleDataprocWorkflowTemplateJobsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_sql_job";

    /// <summary>
    /// Optional. HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// Optional. A mapping of property names to values, used to configure Spark SQL&#39;s SparkConf. Properties that conflict with values set by the Dataproc API may be overwritten.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// </summary>
    public TerraformValue<string>? QueryFileUri
    {
        get => GetArgument<TerraformValue<string>>("query_file_uri");
        set => SetArgument("query_file_uri", value);
    }

    /// <summary>
    /// Optional. Mapping of query variable names to values (equivalent to the Spark SQL command: SET `name=&amp;quot;value&amp;quot;;`).
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
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// QueryList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryList block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockQueryListBlock>? QueryList
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockQueryListBlock>>("query_list");
        set => SetArgument("query_list", value);
    }

}

/// <summary>
/// Block type for logging_config in GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The per-package log levels for the driver. This may include &amp;quot;root&amp;quot; package name to configure rootLogger. Examples: &#39;com.google = FATAL&#39;, &#39;root = INFO&#39;, &#39;org.apache = DEBUG&#39;
    /// </summary>
    public TerraformMap<string>? DriverLogLevels
    {
        get => GetArgument<TerraformMap<string>>("driver_log_levels");
        set => SetArgument("driver_log_levels", value);
    }

}

/// <summary>
/// Block type for query_list in GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateJobsBlockSparkSqlJobBlockQueryListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_list";

    /// <summary>
    /// Required. The queries to execute. You do not need to end a query expression with a semicolon. Multiple queries can be specified in one string by separating each with a semicolon. Here is an example of a Dataproc API snippet that uses a QueryList to specify a HiveJob: &amp;quot;hiveJob&amp;quot;: { &amp;quot;queryList&amp;quot;: { &amp;quot;queries&amp;quot;: [ &amp;quot;query1&amp;quot;, &amp;quot;query2&amp;quot;, &amp;quot;query3;query4&amp;quot;, ] } }
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queries is required")]
    public TerraformList<string>? Queries
    {
        get => GetArgument<TerraformList<string>>("queries");
        set => SetArgument("queries", value);
    }

}


/// <summary>
/// Block type for parameters in GoogleDataprocWorkflowTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// Optional. Brief description of the parameter. Must not exceed 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Required. Paths to all fields that the parameter replaces. A field is allowed to appear in at most one parameter&#39;s list of field paths. A field path is similar in syntax to a google.protobuf.FieldMask. For example, a field path that references the zone field of a workflow template&#39;s cluster selector would be specified as `placement.clusterSelector.zone`. Also, field paths can reference fields using the following syntax: * Values in maps can be referenced by key: * labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * placement.managedCluster.labels[&#39;key&#39;] * placement.clusterSelector.clusterLabels[&#39;key&#39;] * jobs[&#39;step-id&#39;].labels[&#39;key&#39;] * Jobs in the jobs list can be referenced by step-id: * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * jobs[&#39;step-id&#39;].hiveJob.queryFileUri * jobs[&#39;step-id&#39;].pySparkJob.mainPythonFileUri * jobs[&#39;step-id&#39;].hadoopJob.jarFileUris[0] * jobs[&#39;step-id&#39;].hadoopJob.archiveUris[0] * jobs[&#39;step-id&#39;].hadoopJob.fileUris[0] * jobs[&#39;step-id&#39;].pySparkJob.pythonFileUris[0] * Items in repeated fields can be referenced by a zero-based index: * jobs[&#39;step-id&#39;].sparkJob.args[0] * Other examples: * jobs[&#39;step-id&#39;].hadoopJob.properties[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.args[0] * jobs[&#39;step-id&#39;].hiveJob.scriptVariables[&#39;key&#39;] * jobs[&#39;step-id&#39;].hadoopJob.mainJarFileUri * placement.clusterSelector.zone It may not be possible to parameterize maps and repeated fields in their entirety since only individual map values and individual items in repeated fields can be referenced. For example, the following field paths are invalid: - placement.clusterSelector.clusterLabels - jobs[&#39;step-id&#39;].sparkJob.args
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    public TerraformList<string>? Fields
    {
        get => GetArgument<TerraformList<string>>("fields");
        set => SetArgument("fields", value);
    }

    /// <summary>
    /// Required. Parameter name. The parameter name is used as the key, and paired with the parameter value, which are passed to the template when the template is instantiated. The name must contain only capital letters (A-Z), numbers (0-9), and underscores (_), and must not start with a number. The maximum length is 40 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlock>? Validation
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for validation in GoogleDataprocWorkflowTemplateParametersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateParametersBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlockRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlockRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// ValuesAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValuesAttribute block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlockValuesAttributeBlock>? ValuesAttribute
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateParametersBlockValidationBlockValuesAttributeBlock>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for regex in GoogleDataprocWorkflowTemplateParametersBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateParametersBlockValidationBlockRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// Required. RE2 regular expressions used to validate the parameter&#39;s value. The value must match the regex in its entirety (substring matches are not sufficient).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regexes is required")]
    public TerraformList<string>? Regexes
    {
        get => GetArgument<TerraformList<string>>("regexes");
        set => SetArgument("regexes", value);
    }

}

/// <summary>
/// Block type for values in GoogleDataprocWorkflowTemplateParametersBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplateParametersBlockValidationBlockValuesAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "values";

    /// <summary>
    /// Required. List of allowed values for the parameter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for placement in GoogleDataprocWorkflowTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement";

    /// <summary>
    /// ClusterSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterSelector block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockClusterSelectorBlock>? ClusterSelector
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockClusterSelectorBlock>>("cluster_selector");
        set => SetArgument("cluster_selector", value);
    }

    /// <summary>
    /// ManagedCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedCluster block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlock>? ManagedCluster
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlock>>("managed_cluster");
        set => SetArgument("managed_cluster", value);
    }

}

/// <summary>
/// Block type for cluster_selector in GoogleDataprocWorkflowTemplatePlacementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockClusterSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_selector";

    /// <summary>
    /// Required. The cluster labels. Cluster must have all labels to match.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterLabels is required")]
    public required TerraformMap<string> ClusterLabels
    {
        get => GetRequiredArgument<TerraformMap<string>>("cluster_labels");
        set => SetArgument("cluster_labels", value);
    }

    /// <summary>
    /// Optional. The zone where workflow process executes. This parameter does not affect the selection of the cluster. If unspecified, the zone of the first cluster matching the selector is used.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? CreateReference("zone");
        set => SetArgument("zone", value);
    }

}

/// <summary>
/// Block type for managed_cluster in GoogleDataprocWorkflowTemplatePlacementBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_cluster";

    /// <summary>
    /// Required. The cluster name prefix. A unique cluster name will be formed by appending a random suffix. The name must contain only lower-case letters (a-z), numbers (0-9), and hyphens (-). Must begin with a letter. Cannot begin or end with hyphen. Must consist of between 2 and 35 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// Optional. The labels to associate with this cluster. Label keys must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: p{Ll}p{Lo}{0,62} Label values must be between 1 and 63 characters long, and must conform to the following PCRE regular expression: [p{Ll}p{Lo}p{N}_-]{0,63} No more than 32 labels can be associated with a given cluster.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public required TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock> Config
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock>>("config");
        set => SetArgument("config", value);
    }

}

/// <summary>
/// Block type for config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// Optional. A Cloud Storage bucket used to stage job dependencies, config files, and job driver console output. If you do not specify a staging bucket, Cloud Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s staging bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket (see [Dataproc staging bucket](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/staging-bucket)). **This field requires a Cloud Storage bucket name, not a URI to a Cloud Storage bucket.**
    /// </summary>
    public TerraformValue<string>? StagingBucket
    {
        get => GetArgument<TerraformValue<string>>("staging_bucket");
        set => SetArgument("staging_bucket", value);
    }

    /// <summary>
    /// Optional. A Cloud Storage bucket used to store ephemeral cluster and jobs data, such as Spark and MapReduce history files. If you do not specify a temp bucket, Dataproc will determine a Cloud Storage location (US, ASIA, or EU) for your cluster&#39;s temp bucket according to the Compute Engine zone where your cluster is deployed, and then create and manage this project-level, per-location bucket. The default bucket has a TTL of 90 days, but you can use any TTL (or none) if you specify a bucket. **This field requires a Cloud Storage bucket name, not a URI to a Cloud Storage bucket.**
    /// </summary>
    public TerraformValue<string>? TempBucket
    {
        get => GetArgument<TerraformValue<string>>("temp_bucket");
        set => SetArgument("temp_bucket", value);
    }

    /// <summary>
    /// AutoscalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockAutoscalingConfigBlock>>("autoscaling_config");
        set => SetArgument("autoscaling_config", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// EndpointConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEndpointConfigBlock>? EndpointConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEndpointConfigBlock>>("endpoint_config");
        set => SetArgument("endpoint_config", value);
    }

    /// <summary>
    /// GceClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceClusterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock>? GceClusterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock>>("gce_cluster_config");
        set => SetArgument("gce_cluster_config", value);
    }

    /// <summary>
    /// InitializationActions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockInitializationActionsBlock>? InitializationActions
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockInitializationActionsBlock>>("initialization_actions");
        set => SetArgument("initialization_actions", value);
    }

    /// <summary>
    /// LifecycleConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LifecycleConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockLifecycleConfigBlock>? LifecycleConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockLifecycleConfigBlock>>("lifecycle_config");
        set => SetArgument("lifecycle_config", value);
    }

    /// <summary>
    /// MasterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlock>? MasterConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlock>>("master_config");
        set => SetArgument("master_config", value);
    }

    /// <summary>
    /// SecondaryWorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryWorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlock>? SecondaryWorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlock>>("secondary_worker_config");
        set => SetArgument("secondary_worker_config", value);
    }

    /// <summary>
    /// SecurityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlock>? SecurityConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlock>>("security_config");
        set => SetArgument("security_config", value);
    }

    /// <summary>
    /// SoftwareConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSoftwareConfigBlock>>("software_config");
        set => SetArgument("software_config", value);
    }

    /// <summary>
    /// WorkerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlock>? WorkerConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlock>>("worker_config");
        set => SetArgument("worker_config", value);
    }

}

/// <summary>
/// Block type for autoscaling_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockAutoscalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_config";

    /// <summary>
    /// Optional. The autoscaling policy used by the cluster. Only resource names including projectid and location (region) are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]` * `projects/[project_id]/locations/[dataproc_region]/autoscalingPolicies/[policy_id]` Note that the policy must be in the same project and Dataproc region.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// Optional. The Cloud KMS key name to use for PD disk encryption for all instances in the cluster.
    /// </summary>
    public TerraformValue<string>? GcePdKmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("gce_pd_kms_key_name");
        set => SetArgument("gce_pd_kms_key_name", value);
    }

}

/// <summary>
/// Block type for endpoint_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockEndpointConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_config";

    /// <summary>
    /// Optional. If true, enable http access to specific ports on the cluster from external sources. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? EnableHttpPortAccess
    {
        get => GetArgument<TerraformValue<bool>>("enable_http_port_access");
        set => SetArgument("enable_http_port_access", value);
    }

    /// <summary>
    /// Output only. The map of port descriptions to URLs. Will only be populated if enable_http_port_access is true.
    /// </summary>
    public TerraformMap<string> HttpPorts
        => CreateReference("http_ports");

}

/// <summary>
/// Block type for gce_cluster_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gce_cluster_config";

    /// <summary>
    /// Optional. If true, all instances in the cluster will only have internal IP addresses. By default, clusters are not restricted to internal IP addresses, and will have ephemeral external IP addresses assigned to each instance. This `internal_ip_only` restriction can only be enabled for subnetwork enabled networks, and all off-cluster dependencies must be configured to be accessible without external IP addresses.
    /// </summary>
    public TerraformValue<bool> InternalIpOnly
    {
        get => GetArgument<TerraformValue<bool>>("internal_ip_only") ?? CreateReference("internal_ip_only");
        set => SetArgument("internal_ip_only", value);
    }

    /// <summary>
    /// The Compute Engine metadata entries to add to all instances (see [Project and instance metadata](https://cloud.google.com/compute/docs/storing-retrieving-metadata#project_and_instance_metadata)).
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Optional. The Compute Engine network to be used for machine communications. Cannot be specified with subnetwork_uri. If neither `network_uri` nor `subnetwork_uri` is specified, the &amp;quot;default&amp;quot; network of the project is used, if it exists. Cannot be a &amp;quot;Custom Subnet Network&amp;quot; (see [Using Subnetworks](https://cloud.google.com/compute/docs/subnetworks) for more information). A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/global/default` * `projects/[project_id]/regions/global/default` * `default`
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Optional. The type of IPv6 access for a cluster. Possible values: PRIVATE_IPV6_GOOGLE_ACCESS_UNSPECIFIED, INHERIT_FROM_SUBNETWORK, OUTBOUND, BIDIRECTIONAL
    /// </summary>
    public TerraformValue<string>? PrivateIpv6GoogleAccess
    {
        get => GetArgument<TerraformValue<string>>("private_ipv6_google_access");
        set => SetArgument("private_ipv6_google_access", value);
    }

    /// <summary>
    /// Optional. The [Dataproc service account](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/service-accounts#service_accounts_in_dataproc) (also see [VM Data Plane identity](https://cloud.google.com/dataproc/docs/concepts/iam/dataproc-principals#vm_service_account_data_plane_identity)) used by Dataproc cluster VM instances to access Google Cloud Platform services. If not specified, the [Compute Engine default service account](https://cloud.google.com/compute/docs/access/service-accounts#default_service_account) is used.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Optional. The URIs of service account scopes to be included in Compute Engine instances. The following base set of scopes is always included: * https://www.googleapis.com/auth/cloud.useraccounts.readonly * https://www.googleapis.com/auth/devstorage.read_write * https://www.googleapis.com/auth/logging.write If no scopes are specified, the following defaults are also provided: * https://www.googleapis.com/auth/bigquery * https://www.googleapis.com/auth/bigtable.admin.table * https://www.googleapis.com/auth/bigtable.data * https://www.googleapis.com/auth/devstorage.full_control
    /// </summary>
    public TerraformList<string>? ServiceAccountScopes
    {
        get => GetArgument<TerraformList<string>>("service_account_scopes");
        set => SetArgument("service_account_scopes", value);
    }

    /// <summary>
    /// Optional. The Compute Engine subnetwork to be used for machine communications. Cannot be specified with network_uri. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/regions/us-east1/subnetworks/sub0` * `projects/[project_id]/regions/us-east1/subnetworks/sub0` * `sub0`
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

    /// <summary>
    /// The Compute Engine tags to add to all instances (see [Tagging instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
    /// </summary>
    public TerraformSet<string>? Tags
    {
        get => GetArgument<TerraformSet<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Optional. The zone where the Compute Engine cluster will be located. On a create request, it is required in the &amp;quot;global&amp;quot; region. If omitted in a non-global Dataproc region, the service will pick a zone in the corresponding Compute Engine region. On a get request, zone will always be present. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/[zone]` * `projects/[project_id]/zones/[zone]` * `us-central1-f`
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? CreateReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// NodeGroupAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeGroupAffinity block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock>? NodeGroupAffinity
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock>>("node_group_affinity");
        set => SetArgument("node_group_affinity", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

}

/// <summary>
/// Block type for node_group_affinity in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockNodeGroupAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_group_affinity";

    /// <summary>
    /// Required. The URI of a sole-tenant [node group resource](https://cloud.google.com/compute/docs/reference/rest/v1/nodeGroups) that the cluster will be created on. A full URL, partial URI, or node group name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1` * `projects/[project_id]/zones/us-central1-a/nodeGroups/node-group-1` * `node-group-1`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeGroup is required")]
    public required TerraformValue<string> NodeGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_group");
        set => SetArgument("node_group", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Optional. Type of reservation to consume Possible values: TYPE_UNSPECIFIED, NO_RESERVATION, ANY_RESERVATION, SPECIFIC_RESERVATION
    /// </summary>
    public TerraformValue<string>? ConsumeReservationType
    {
        get => GetArgument<TerraformValue<string>>("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// Optional. Corresponds to the label key of reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Optional. Corresponds to the label values of reservation resource.
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockGceClusterConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Optional. Defines whether instances have integrity monitoring enabled. Integrity monitoring compares the most recent boot measurements to the integrity policy baseline and returns a pair of pass/fail results depending on whether they match or not.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Optional. Defines whether the instances have Secure Boot enabled. Secure Boot helps ensure that the system only runs authentic software by verifying the digital signature of all boot components, and halting the boot process if signature verification fails.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Optional. Defines whether the instance have the vTPM enabled. Virtual Trusted Platform Module protects objects like keys, certificates and enables Measured Boot by performing the measurements needed to create a known good boot baseline, called the integrity policy baseline.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}

/// <summary>
/// Block type for initialization_actions in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockInitializationActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initialization_actions";

    /// <summary>
    /// Required. Cloud Storage URI of executable file.
    /// </summary>
    public TerraformValue<string>? ExecutableFile
    {
        get => GetArgument<TerraformValue<string>>("executable_file");
        set => SetArgument("executable_file", value);
    }

    /// <summary>
    /// Optional. Amount of time executable has to complete. Default is 10 minutes (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). Cluster creation fails with an explanatory error message (the name of the executable that caused the error and the exceeded timeout period) if the executable is not completed at end of the timeout period.
    /// </summary>
    public TerraformValue<string>? ExecutionTimeout
    {
        get => GetArgument<TerraformValue<string>>("execution_timeout");
        set => SetArgument("execution_timeout", value);
    }

}

/// <summary>
/// Block type for lifecycle_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockLifecycleConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_config";

    /// <summary>
    /// Optional. The time when cluster will be auto-deleted (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).
    /// </summary>
    public TerraformValue<string>? AutoDeleteTime
    {
        get => GetArgument<TerraformValue<string>>("auto_delete_time");
        set => SetArgument("auto_delete_time", value);
    }

    /// <summary>
    /// Optional. The lifetime duration of cluster. The cluster will be auto-deleted at the end of this period. Minimum value is 10 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
    /// </summary>
    public TerraformValue<string>? AutoDeleteTtl
    {
        get => GetArgument<TerraformValue<string>>("auto_delete_ttl");
        set => SetArgument("auto_delete_ttl", value);
    }

    /// <summary>
    /// Optional. The duration to keep the cluster alive while idling (when no jobs are running). Passing this threshold will cause the cluster to be deleted. Minimum value is 5 minutes; maximum value is 14 days (see JSON representation of [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
    /// </summary>
    public TerraformValue<string>? IdleDeleteTtl
    {
        get => GetArgument<TerraformValue<string>>("idle_delete_ttl");
        set => SetArgument("idle_delete_ttl", value);
    }

    /// <summary>
    /// Output only. The time when cluster became idle (most recent job finished) and became eligible for deletion due to idleness (see JSON representation of [Timestamp](https://developers.google.com/protocol-buffers/docs/proto3#json)).
    /// </summary>
    public TerraformValue<string> IdleStartTime
        => CreateReference("idle_start_time");

}

/// <summary>
/// Block type for master_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_config";

    /// <summary>
    /// Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// Output only. Specifies that this instance group contains preemptible instances.
    /// </summary>
    public TerraformValue<bool> IsPreemptible
        => CreateReference("is_preemptible");

    /// <summary>
    /// Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedGroupConfig
        => CreateReference("managed_group_config");

    /// <summary>
    /// Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&amp;gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.
    /// </summary>
    public TerraformValue<double>? NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE
    /// </summary>
    public TerraformValue<string>? Preemptibility
    {
        get => GetArgument<TerraformValue<string>>("preemptibility");
        set => SetArgument("preemptibility", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance.
    /// </summary>
    public TerraformValue<double>? AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockMasterConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Optional. Size in GB of the boot disk (default is 500GB).
    /// </summary>
    public TerraformValue<double>? BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// Optional. Type of the boot disk (default is &amp;quot;pd-standard&amp;quot;). Valid values: &amp;quot;pd-balanced&amp;quot; (Persistent Disk Balanced Solid State Drive), &amp;quot;pd-ssd&amp;quot; (Persistent Disk Solid State Drive), or &amp;quot;pd-standard&amp;quot; (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}

/// <summary>
/// Block type for secondary_worker_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary_worker_config";

    /// <summary>
    /// Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// Output only. Specifies that this instance group contains preemptible instances.
    /// </summary>
    public TerraformValue<bool> IsPreemptible
        => CreateReference("is_preemptible");

    /// <summary>
    /// Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedGroupConfig
        => CreateReference("managed_group_config");

    /// <summary>
    /// Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&amp;gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.
    /// </summary>
    public TerraformValue<double>? NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE
    /// </summary>
    public TerraformValue<string>? Preemptibility
    {
        get => GetArgument<TerraformValue<string>>("preemptibility");
        set => SetArgument("preemptibility", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance.
    /// </summary>
    public TerraformValue<double>? AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecondaryWorkerConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Optional. Size in GB of the boot disk (default is 500GB).
    /// </summary>
    public TerraformValue<double>? BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// Optional. Type of the boot disk (default is &amp;quot;pd-standard&amp;quot;). Valid values: &amp;quot;pd-balanced&amp;quot; (Persistent Disk Balanced Solid State Drive), &amp;quot;pd-ssd&amp;quot; (Persistent Disk Solid State Drive), or &amp;quot;pd-standard&amp;quot; (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}

/// <summary>
/// Block type for security_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_config";

    /// <summary>
    /// KerberosConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlockKerberosConfigBlock>? KerberosConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlockKerberosConfigBlock>>("kerberos_config");
        set => SetArgument("kerberos_config", value);
    }

}

/// <summary>
/// Block type for kerberos_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSecurityConfigBlockKerberosConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kerberos_config";

    /// <summary>
    /// Optional. The admin server (IP or hostname) for the remote trusted realm in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustAdminServer
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_admin_server");
        set => SetArgument("cross_realm_trust_admin_server", value);
    }

    /// <summary>
    /// Optional. The KDC (IP or hostname) for the remote trusted realm in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustKdc
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_kdc");
        set => SetArgument("cross_realm_trust_kdc", value);
    }

    /// <summary>
    /// Optional. The remote realm the Dataproc on-cluster KDC will trust, should the user enable cross realm trust.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustRealm
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_realm");
        set => SetArgument("cross_realm_trust_realm", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the shared password between the on-cluster Kerberos realm and the remote trusted realm, in a cross realm trust relationship.
    /// </summary>
    public TerraformValue<string>? CrossRealmTrustSharedPassword
    {
        get => GetArgument<TerraformValue<string>>("cross_realm_trust_shared_password");
        set => SetArgument("cross_realm_trust_shared_password", value);
    }

    /// <summary>
    /// Optional. Flag to indicate whether to Kerberize the cluster (default: false). Set this field to true to enable Kerberos on a cluster.
    /// </summary>
    public TerraformValue<bool>? EnableKerberos
    {
        get => GetArgument<TerraformValue<bool>>("enable_kerberos");
        set => SetArgument("enable_kerberos", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the master key of the KDC database.
    /// </summary>
    public TerraformValue<string>? KdcDbKey
    {
        get => GetArgument<TerraformValue<string>>("kdc_db_key");
        set => SetArgument("kdc_db_key", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided key. For the self-signed certificate, this password is generated by Dataproc.
    /// </summary>
    public TerraformValue<string>? KeyPassword
    {
        get => GetArgument<TerraformValue<string>>("key_password");
        set => SetArgument("key_password", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of the keystore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    public TerraformValue<string>? Keystore
    {
        get => GetArgument<TerraformValue<string>>("keystore");
        set => SetArgument("keystore", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided keystore. For the self-signed certificate, this password is generated by Dataproc.
    /// </summary>
    public TerraformValue<string>? KeystorePassword
    {
        get => GetArgument<TerraformValue<string>>("keystore_password");
        set => SetArgument("keystore_password", value);
    }

    /// <summary>
    /// Optional. The uri of the KMS key used to encrypt various sensitive files.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Optional. The name of the on-cluster Kerberos realm. If not specified, the uppercased domain of hostnames will be the realm.
    /// </summary>
    public TerraformValue<string>? Realm
    {
        get => GetArgument<TerraformValue<string>>("realm");
        set => SetArgument("realm", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the root principal password.
    /// </summary>
    public TerraformValue<string>? RootPrincipalPassword
    {
        get => GetArgument<TerraformValue<string>>("root_principal_password");
        set => SetArgument("root_principal_password", value);
    }

    /// <summary>
    /// Optional. The lifetime of the ticket granting ticket, in hours. If not specified, or user specifies 0, then default value 10 will be used.
    /// </summary>
    public TerraformValue<double>? TgtLifetimeHours
    {
        get => GetArgument<TerraformValue<double>>("tgt_lifetime_hours");
        set => SetArgument("tgt_lifetime_hours", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of the truststore file used for SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
    /// </summary>
    public TerraformValue<string>? Truststore
    {
        get => GetArgument<TerraformValue<string>>("truststore");
        set => SetArgument("truststore", value);
    }

    /// <summary>
    /// Optional. The Cloud Storage URI of a KMS encrypted file containing the password to the user provided truststore. For the self-signed certificate, this password is generated by Dataproc.
    /// </summary>
    public TerraformValue<string>? TruststorePassword
    {
        get => GetArgument<TerraformValue<string>>("truststore_password");
        set => SetArgument("truststore_password", value);
    }

}

/// <summary>
/// Block type for software_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_config";

    /// <summary>
    /// Optional. The version of software inside the cluster. It must be one of the supported [Dataproc Versions](https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#supported_dataproc_versions), such as &amp;quot;1.2&amp;quot; (including a subminor version, such as &amp;quot;1.2.29&amp;quot;), or the [&amp;quot;preview&amp;quot; version](https://cloud.google.com/dataproc/docs/concepts/versioning/dataproc-versions#other_versions). If unspecified, it defaults to the latest Debian version.
    /// </summary>
    public TerraformValue<string>? ImageVersion
    {
        get => GetArgument<TerraformValue<string>>("image_version");
        set => SetArgument("image_version", value);
    }

    /// <summary>
    /// Optional. The set of components to activate on the cluster.
    /// </summary>
    public TerraformList<string>? OptionalComponents
    {
        get => GetArgument<TerraformList<string>>("optional_components");
        set => SetArgument("optional_components", value);
    }

    /// <summary>
    /// Optional. The properties to set on daemon config files. Property keys are specified in `prefix:property` format, for example `core:hadoop.tmp.dir`. The following are supported prefixes and their mappings: * capacity-scheduler: `capacity-scheduler.xml` * core: `core-site.xml` * distcp: `distcp-default.xml` * hdfs: `hdfs-site.xml` * hive: `hive-site.xml` * mapred: `mapred-site.xml` * pig: `pig.properties` * spark: `spark-defaults.conf` * yarn: `yarn-site.xml` For more information, see [Cluster properties](https://cloud.google.com/dataproc/docs/concepts/cluster-properties).
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for worker_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_config";

    /// <summary>
    /// Optional. The Compute Engine image resource used for cluster instances. The URI can represent an image or image family. Image examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/[image-id]` * `projects/[project_id]/global/images/[image-id]` * `image-id` Image family examples. Dataproc will use the most recent image from the family: * `https://www.googleapis.com/compute/beta/projects/[project_id]/global/images/family/[custom-image-family-name]` * `projects/[project_id]/global/images/family/[custom-image-family-name]` If the URI is unspecified, it will be inferred from `SoftwareConfig.image_version` or the system default.
    /// </summary>
    public TerraformValue<string>? Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// Output only. The list of instance names. Dataproc derives the names from `cluster_name`, `num_instances`, and the instance group.
    /// </summary>
    public TerraformList<string> InstanceNames
        => CreateReference("instance_names");

    /// <summary>
    /// Output only. Specifies that this instance group contains preemptible instances.
    /// </summary>
    public TerraformValue<bool> IsPreemptible
        => CreateReference("is_preemptible");

    /// <summary>
    /// Optional. The Compute Engine machine type used for cluster instances. A full URL, partial URI, or short name are valid. Examples: * `https://www.googleapis.com/compute/v1/projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `projects/[project_id]/zones/us-east1-a/machineTypes/n1-standard-2` * `n1-standard-2` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the machine type resource, for example, `n1-standard-2`.
    /// </summary>
    public TerraformValue<string>? MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Output only. The config for Compute Engine Instance Group Manager that manages this group. This is only used for preemptible instance groups.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedGroupConfig
        => CreateReference("managed_group_config");

    /// <summary>
    /// Optional. Specifies the minimum cpu platform for the Instance Group. See [Dataproc -&amp;gt; Minimum CPU Platform](https://cloud.google.com/dataproc/docs/concepts/compute/dataproc-min-cpu).
    /// </summary>
    public TerraformValue<string> MinCpuPlatform
    {
        get => GetArgument<TerraformValue<string>>("min_cpu_platform") ?? CreateReference("min_cpu_platform");
        set => SetArgument("min_cpu_platform", value);
    }

    /// <summary>
    /// Optional. The number of VM instances in the instance group. For [HA cluster](/dataproc/docs/concepts/configuring-clusters/high-availability) [master_config](#FIELDS.master_config) groups, **must be set to 3**. For standard cluster [master_config](#FIELDS.master_config) groups, **must be set to 1**.
    /// </summary>
    public TerraformValue<double>? NumInstances
    {
        get => GetArgument<TerraformValue<double>>("num_instances");
        set => SetArgument("num_instances", value);
    }

    /// <summary>
    /// Optional. Specifies the preemptibility of the instance group. The default value for master and worker groups is `NON_PREEMPTIBLE`. This default cannot be changed. The default value for secondary instances is `PREEMPTIBLE`. Possible values: PREEMPTIBILITY_UNSPECIFIED, NON_PREEMPTIBLE, PREEMPTIBLE
    /// </summary>
    public TerraformValue<string>? Preemptibility
    {
        get => GetArgument<TerraformValue<string>>("preemptibility");
        set => SetArgument("preemptibility", value);
    }

    /// <summary>
    /// Accelerators block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockAcceleratorsBlock>? Accelerators
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockAcceleratorsBlock>>("accelerators");
        set => SetArgument("accelerators", value);
    }

    /// <summary>
    /// DiskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockDiskConfigBlock>? DiskConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockDiskConfigBlock>>("disk_config");
        set => SetArgument("disk_config", value);
    }

}

/// <summary>
/// Block type for accelerators in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerators";

    /// <summary>
    /// The number of the accelerator cards of this type exposed to this instance.
    /// </summary>
    public TerraformValue<double>? AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// Full URL, partial URI, or short name of the accelerator type resource to expose to this instance. See [Compute Engine AcceleratorTypes](https://cloud.google.com/compute/docs/reference/beta/acceleratorTypes). Examples: * `https://www.googleapis.com/compute/beta/projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `projects/[project_id]/zones/us-east1-a/acceleratorTypes/nvidia-tesla-k80` * `nvidia-tesla-k80` **Auto Zone Exception**: If you are using the Dataproc [Auto Zone Placement](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/auto-zone#using_auto_zone_placement) feature, you must use the short name of the accelerator type resource, for example, `nvidia-tesla-k80`.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

}

/// <summary>
/// Block type for disk_config in GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocWorkflowTemplatePlacementBlockManagedClusterBlockConfigBlockWorkerConfigBlockDiskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_config";

    /// <summary>
    /// Optional. Size in GB of the boot disk (default is 500GB).
    /// </summary>
    public TerraformValue<double>? BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// Optional. Type of the boot disk (default is &amp;quot;pd-standard&amp;quot;). Valid values: &amp;quot;pd-balanced&amp;quot; (Persistent Disk Balanced Solid State Drive), &amp;quot;pd-ssd&amp;quot; (Persistent Disk Solid State Drive), or &amp;quot;pd-standard&amp;quot; (Persistent Disk Hard Disk Drive). See [Disk types](https://cloud.google.com/compute/docs/disks#disk-types).
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Optional. Number of attached SSDs, from 0 to 4 (default is 0). If SSDs are not attached, the boot disk is used to store runtime logs and [HDFS](https://hadoop.apache.org/docs/r1.2.1/hdfs_user_guide.html) data. If one or more SSDs are attached, this runtime bulk data is spread across them, and the boot disk contains only basic config and installed binaries.
    /// </summary>
    public TerraformValue<double> NumLocalSsds
    {
        get => GetArgument<TerraformValue<double>>("num_local_ssds") ?? CreateReference("num_local_ssds");
        set => SetArgument("num_local_ssds", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocWorkflowTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocWorkflowTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataproc_workflow_template Terraform resource.
/// Manages a google_dataproc_workflow_template resource.
/// </summary>
public partial class GoogleDataprocWorkflowTemplate(string name) : TerraformResource("google_dataproc_workflow_template", name)
{
    /// <summary>
    /// Optional. Timeout duration for the DAG of jobs, expressed in seconds (see [JSON representation of duration](https://developers.google.com/protocol-buffers/docs/proto3#json)). The timeout duration must be from 10 minutes (&amp;quot;600s&amp;quot;) to 24 hours (&amp;quot;86400s&amp;quot;). The timer begins when the first job is submitted. If the workflow is running at the end of the timeout period, any remaining jobs are cancelled, the workflow is ended, and if the workflow was running on a [managed cluster](/dataproc/docs/concepts/workflows/using-workflows#configuring_or_selecting_a_cluster), the cluster is deleted.
    /// </summary>
    public TerraformValue<string>? DagTimeout
    {
        get => GetArgument<TerraformValue<string>>("dag_timeout");
        set => SetArgument("dag_timeout", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. The labels to associate with this template. These labels will be propagated to all jobs and clusters created by the workflow instance. Label **keys** must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be empty, but, if present, must contain 1 to 63 characters, and must conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be associated with a template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Output only. The resource name of the workflow template, as described in https://cloud.google.com/apis/design/resource_names. * For `projects.regions.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/regions/{region}/workflowTemplates/{template_id}` * For `projects.locations.workflowTemplates`, the resource name of the template has the following format: `projects/{project_id}/locations/{location}/workflowTemplates/{template_id}`
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The current version of this workflow template.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<double> Version
    {
        get => GetArgument<TerraformValue<double>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Output only. The time template was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Output only. The time template was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocWorkflowTemplateEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// Jobs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Jobs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Jobs block(s) required")]
    public required TerraformList<GoogleDataprocWorkflowTemplateJobsBlock> Jobs
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocWorkflowTemplateJobsBlock>>("jobs");
        set => SetArgument("jobs", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataprocWorkflowTemplateParametersBlock>? Parameters
    {
        get => GetArgument<TerraformList<GoogleDataprocWorkflowTemplateParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Placement block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Placement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Placement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public required TerraformList<GoogleDataprocWorkflowTemplatePlacementBlock> Placement
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocWorkflowTemplatePlacementBlock>>("placement");
        set => SetArgument("placement", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocWorkflowTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocWorkflowTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

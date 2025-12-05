using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pyspark_application_config in GoogleDataprocGdcSparkApplication.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pyspark_application_config";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the driver. Must be a .py file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformValue<string> MainPythonFileUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("main_python_file_uri");
        set => SetArgument("main_python_file_uri", value);
    }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
    /// </summary>
    public TerraformList<string>? PythonFileUris
    {
        get => GetArgument<TerraformList<string>>("python_file_uris");
        set => SetArgument("python_file_uris", value);
    }

}


/// <summary>
/// Block type for spark_application_config in GoogleDataprocGdcSparkApplication.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_application_config";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: &#39;.jar&#39;, &#39;.tar&#39;, &#39;.tar.gz&#39;, &#39;.tgz&#39;, and &#39;.zip&#39;.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as application properties, such as &#39;--conf&#39;, since a collision can occur that causes an incorrect application submission.
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
    /// The name of the driver main class. The jar file that contains the class must be in the classpath or specified in &#39;jar_file_uris&#39;.
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
/// Block type for spark_r_application_config in GoogleDataprocGdcSparkApplication.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_r_application_config";

    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainRFileUri is required")]
    public required TerraformValue<string> MainRFileUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("main_r_file_uri");
        set => SetArgument("main_r_file_uri", value);
    }

}


/// <summary>
/// Block type for spark_sql_application_config in GoogleDataprocGdcSparkApplication.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_sql_application_config";

    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public TerraformList<string>? JarFileUris
    {
        get => GetArgument<TerraformList<string>>("jar_file_uris");
        set => SetArgument("jar_file_uris", value);
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
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET &#39;name=&amp;quot;value&amp;quot;;&#39;).
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
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlockQueryListBlock>? QueryList
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlockQueryListBlock>>("query_list");
        set => SetArgument("query_list", value);
    }

}

/// <summary>
/// Block type for query_list in GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlockQueryListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_list";

    /// <summary>
    /// The queries to run.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Queries is required")]
    public TerraformList<string>? Queries
    {
        get => GetArgument<TerraformList<string>>("queries");
        set => SetArgument("queries", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocGdcSparkApplication.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcSparkApplicationTimeoutsBlock : TerraformBlock
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
/// Represents a google_dataproc_gdc_spark_application Terraform resource.
/// Manages a google_dataproc_gdc_spark_application resource.
/// </summary>
public partial class GoogleDataprocGdcSparkApplication(string name) : TerraformResource("google_dataproc_gdc_spark_application", name)
{
    /// <summary>
    /// The annotations to associate with this application. Annotations may be used to store client information, but are not used by the server. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// An ApplicationEnvironment from which to inherit configuration properties.
    /// </summary>
    public TerraformValue<string>? ApplicationEnvironment
    {
        get => GetArgument<TerraformValue<string>>("application_environment");
        set => SetArgument("application_environment", value);
    }

    /// <summary>
    /// List of container image uris for additional file dependencies. Dependent files are sequentially copied from each image. If a file with the same name exists in 2 images then the file from later image is used.
    /// </summary>
    public TerraformList<string>? DependencyImages
    {
        get => GetArgument<TerraformList<string>>("dependency_images");
        set => SetArgument("dependency_images", value);
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The labels to associate with this application. Labels may be used for filtering and billing tracking. 
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
    /// The location of the spark application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The Kubernetes namespace in which to create the application. This namespace must already exist on the cluster.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// application-specific properties.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The id of the service instance to which this spark application belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    public required TerraformValue<string> Serviceinstance
    {
        get => GetRequiredArgument<TerraformValue<string>>("serviceinstance");
        set => SetArgument("serviceinstance", value);
    }

    /// <summary>
    /// The id of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkApplicationId is required")]
    public required TerraformValue<string> SparkApplicationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("spark_application_id");
        set => SetArgument("spark_application_id", value);
    }

    /// <summary>
    /// The Dataproc version of this application.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => CreateReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// URL for a monitoring UI for this application (for eventual Spark PHS/UI support) Out of scope for private GA
    /// </summary>
    public TerraformValue<string> MonitoringEndpoint
        => CreateReference("monitoring_endpoint");

    /// <summary>
    /// Identifier. The name of the application. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/sparkApplications/{application}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// An HCFS URI pointing to the location of stdout and stdout of the application Mainly useful for Pantheon and gcloud Not in scope for private GA
    /// </summary>
    public TerraformValue<string> OutputUri
        => CreateReference("output_uri");

    /// <summary>
    /// Whether the application is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => CreateReference("reconciling");

    /// <summary>
    /// The current state.
    /// Possible values:
    /// * &#39;STATE_UNSPECIFIED&#39;
    /// * &#39;PENDING&#39;
    /// * &#39;RUNNING&#39;
    /// * &#39;CANCELLING&#39;
    /// * &#39;CANCELLED&#39;
    /// * &#39;SUCCEEDED&#39;
    /// * &#39;FAILED&#39;
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    public TerraformValue<string> StateMessage
        => CreateReference("state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// System generated unique identifier for this application, formatted as UUID4.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// PysparkApplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkApplicationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock>? PysparkApplicationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock>>("pyspark_application_config");
        set => SetArgument("pyspark_application_config", value);
    }

    /// <summary>
    /// SparkApplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock>? SparkApplicationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock>>("spark_application_config");
        set => SetArgument("spark_application_config", value);
    }

    /// <summary>
    /// SparkRApplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRApplicationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock>? SparkRApplicationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock>>("spark_r_application_config");
        set => SetArgument("spark_r_application_config", value);
    }

    /// <summary>
    /// SparkSqlApplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlApplicationConfig block(s) allowed")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock>? SparkSqlApplicationConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock>>("spark_sql_application_config");
        set => SetArgument("spark_sql_application_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocGdcSparkApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocGdcSparkApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

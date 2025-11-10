using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pyspark_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the driver. Must be a .py file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    public required TerraformProperty<string> MainPythonFileUri
    {
        set => SetProperty("main_python_file_uri", value);
    }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? PythonFileUris
    {
        set => SetProperty("python_file_uris", value);
    }

}

/// <summary>
/// Block type for spark_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: &#39;.jar&#39;, &#39;.tar&#39;, &#39;.tar.gz&#39;, &#39;.tgz&#39;, and &#39;.zip&#39;.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as application properties, such as &#39;--conf&#39;, since a collision can occur that causes an incorrect application submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the classpath or specified in &#39;jar_file_uris&#39;.
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        set => SetProperty("main_class", value);
    }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    public TerraformProperty<string>? MainJarFileUri
    {
        set => SetProperty("main_jar_file_uri", value);
    }

}

/// <summary>
/// Block type for spark_r_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        set => SetProperty("args", value);
    }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainRFileUri is required")]
    public required TerraformProperty<string> MainRFileUri
    {
        set => SetProperty("main_r_file_uri", value);
    }

}

/// <summary>
/// Block type for spark_sql_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    public List<TerraformProperty<string>>? JarFileUris
    {
        set => SetProperty("jar_file_uris", value);
    }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// </summary>
    public TerraformProperty<string>? QueryFileUri
    {
        set => SetProperty("query_file_uri", value);
    }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET &#39;name=&amp;quot;value&amp;quot;;&#39;).
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
public class GoogleDataprocGdcSparkApplicationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataproc_gdc_spark_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocGdcSparkApplication : TerraformResource
{
    public GoogleDataprocGdcSparkApplication(string name) : base("google_dataproc_gdc_spark_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("monitoring_endpoint");
        SetOutput("name");
        SetOutput("output_uri");
        SetOutput("reconciling");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("application_environment");
        SetOutput("dependency_images");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("namespace");
        SetOutput("project");
        SetOutput("properties");
        SetOutput("serviceinstance");
        SetOutput("spark_application_id");
        SetOutput("version");
    }

    /// <summary>
    /// The annotations to associate with this application. Annotations may be used to store client information, but are not used by the server. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// An ApplicationEnvironment from which to inherit configuration properties.
    /// </summary>
    public TerraformProperty<string> ApplicationEnvironment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_environment");
        set => SetProperty("application_environment", value);
    }

    /// <summary>
    /// List of container image uris for additional file dependencies. Dependent files are sequentially copied from each image. If a file with the same name exists in 2 images then the file from later image is used.
    /// </summary>
    public List<TerraformProperty<string>> DependencyImages
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("dependency_images");
        set => SetProperty("dependency_images", value);
    }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The labels to associate with this application. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location of the spark application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The Kubernetes namespace in which to create the application. This namespace must already exist on the cluster.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// application-specific properties.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Properties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("properties");
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The id of the service instance to which this spark application belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    public required TerraformProperty<string> Serviceinstance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("serviceinstance");
        set => SetProperty("serviceinstance", value);
    }

    /// <summary>
    /// The id of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkApplicationId is required")]
    public required TerraformProperty<string> SparkApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spark_application_id");
        set => SetProperty("spark_application_id", value);
    }

    /// <summary>
    /// The Dataproc version of this application.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for pyspark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkApplicationConfig block(s) allowed")]
    public List<GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock>? PysparkApplicationConfig
    {
        set => SetProperty("pyspark_application_config", value);
    }

    /// <summary>
    /// Block for spark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationConfig block(s) allowed")]
    public List<GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock>? SparkApplicationConfig
    {
        set => SetProperty("spark_application_config", value);
    }

    /// <summary>
    /// Block for spark_r_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRApplicationConfig block(s) allowed")]
    public List<GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock>? SparkRApplicationConfig
    {
        set => SetProperty("spark_r_application_config", value);
    }

    /// <summary>
    /// Block for spark_sql_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlApplicationConfig block(s) allowed")]
    public List<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock>? SparkSqlApplicationConfig
    {
        set => SetProperty("spark_sql_application_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocGdcSparkApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// URL for a monitoring UI for this application (for eventual Spark PHS/UI support) Out of scope for private GA
    /// </summary>
    public TerraformExpression MonitoringEndpoint => this["monitoring_endpoint"];

    /// <summary>
    /// Identifier. The name of the application. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/sparkApplications/{application}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// An HCFS URI pointing to the location of stdout and stdout of the application Mainly useful for Pantheon and gcloud Not in scope for private GA
    /// </summary>
    public TerraformExpression OutputUri => this["output_uri"];

    /// <summary>
    /// Whether the application is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

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
    public TerraformExpression State => this["state"];

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// System generated unique identifier for this application, formatted as UUID4.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

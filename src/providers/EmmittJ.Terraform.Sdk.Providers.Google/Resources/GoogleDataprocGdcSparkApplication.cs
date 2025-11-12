using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pyspark_application_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock() : TerraformBlock("pyspark_application_config")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.
    /// </summary>
    [TerraformProperty("jar_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the driver. Must be a .py file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    [TerraformProperty("main_python_file_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MainPythonFileUri { get; set; }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
    /// </summary>
    [TerraformProperty("python_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PythonFileUris { get; set; }

}

/// <summary>
/// Block type for spark_application_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock() : TerraformBlock("spark_application_config")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: &#39;.jar&#39;, &#39;.tar&#39;, &#39;.tar.gz&#39;, &#39;.tgz&#39;, and &#39;.zip&#39;.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as application properties, such as &#39;--conf&#39;, since a collision can occur that causes an incorrect application submission.
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
    /// The name of the driver main class. The jar file that contains the class must be in the classpath or specified in &#39;jar_file_uris&#39;.
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
/// Block type for spark_r_application_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock() : TerraformBlock("spark_r_application_config")
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? FileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainRFileUri is required")]
    [TerraformProperty("main_r_file_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MainRFileUri { get; set; }

}

/// <summary>
/// Block type for spark_sql_application_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock() : TerraformBlock("spark_sql_application_config")
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    [TerraformProperty("jar_file_uris")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// </summary>
    [TerraformProperty("query_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryFileUri { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET &#39;name=&amp;quot;value&amp;quot;;&#39;).
    /// </summary>
    [TerraformProperty("script_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ScriptVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocGdcSparkApplicationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_dataproc_gdc_spark_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocGdcSparkApplication : TerraformResource
{
    public GoogleDataprocGdcSparkApplication(string name) : base("google_dataproc_gdc_spark_application", name)
    {
    }

    /// <summary>
    /// The annotations to associate with this application. Annotations may be used to store client information, but are not used by the server. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// An ApplicationEnvironment from which to inherit configuration properties.
    /// </summary>
    [TerraformProperty("application_environment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationEnvironment { get; set; }

    /// <summary>
    /// List of container image uris for additional file dependencies. Dependent files are sequentially copied from each image. If a file with the same name exists in 2 images then the file from later image is used.
    /// </summary>
    [TerraformProperty("dependency_images")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? DependencyImages { get; set; }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels to associate with this application. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the spark application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The Kubernetes namespace in which to create the application. This namespace must already exist on the cluster.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// application-specific properties.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The id of the service instance to which this spark application belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    [TerraformProperty("serviceinstance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Serviceinstance { get; set; }

    /// <summary>
    /// The id of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkApplicationId is required")]
    [TerraformProperty("spark_application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SparkApplicationId { get; set; }

    /// <summary>
    /// The Dataproc version of this application.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for pyspark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkApplicationConfig block(s) allowed")]
    [TerraformProperty("pyspark_application_config")]
    public TerraformList<GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock> PysparkApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationConfig block(s) allowed")]
    [TerraformProperty("spark_application_config")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock> SparkApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_r_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRApplicationConfig block(s) allowed")]
    [TerraformProperty("spark_r_application_config")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock> SparkRApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_sql_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlApplicationConfig block(s) allowed")]
    [TerraformProperty("spark_sql_application_config")]
    public TerraformList<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock> SparkSqlApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataprocGdcSparkApplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// URL for a monitoring UI for this application (for eventual Spark PHS/UI support) Out of scope for private GA
    /// </summary>
    [TerraformProperty("monitoring_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MonitoringEndpoint { get; }

    /// <summary>
    /// Identifier. The name of the application. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/sparkApplications/{application}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// An HCFS URI pointing to the location of stdout and stdout of the application Mainly useful for Pantheon and gcloud Not in scope for private GA
    /// </summary>
    [TerraformProperty("output_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutputUri { get; }

    /// <summary>
    /// Whether the application is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reconciling { get; }

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
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// System generated unique identifier for this application, formatted as UUID4.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}

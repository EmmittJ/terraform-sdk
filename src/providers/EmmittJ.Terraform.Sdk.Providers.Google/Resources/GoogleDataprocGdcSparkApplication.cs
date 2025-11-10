using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for pyspark_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the CLASSPATHs of the Python driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main Python file to use as the driver. Must be a .py file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainPythonFileUri is required")]
    [TerraformPropertyName("main_python_file_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MainPythonFileUri { get; set; }

    /// <summary>
    /// HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
    /// </summary>
    [TerraformPropertyName("python_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? PythonFileUris { get; set; }

}

/// <summary>
/// Block type for spark_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: &#39;.jar&#39;, &#39;.tar&#39;, &#39;.tar.gz&#39;, &#39;.tgz&#39;, and &#39;.zip&#39;.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver. Do not include arguments that can be set as application properties, such as &#39;--conf&#39;, since a collision can occur that causes an incorrect application submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// HCFS URIs of jar files to add to the classpath of the Spark driver and tasks.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// The name of the driver main class. The jar file that contains the class must be in the classpath or specified in &#39;jar_file_uris&#39;.
    /// </summary>
    [TerraformPropertyName("main_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainClass { get; set; }

    /// <summary>
    /// The HCFS URI of the jar file that contains the main class.
    /// </summary>
    [TerraformPropertyName("main_jar_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MainJarFileUri { get; set; }

}

/// <summary>
/// Block type for spark_r_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of archives to be extracted into the working directory of each executor. Supported file types: .jar, .tar, .tar.gz, .tgz, and .zip.
    /// </summary>
    [TerraformPropertyName("archive_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ArchiveUris { get; set; }

    /// <summary>
    /// The arguments to pass to the driver.  Do not include arguments, such as &#39;--conf&#39;, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Args { get; set; }

    /// <summary>
    /// HCFS URIs of files to be placed in the working directory of each executor. Useful for naively parallel tasks.
    /// </summary>
    [TerraformPropertyName("file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? FileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the main R file to use as the driver. Must be a .R file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MainRFileUri is required")]
    [TerraformPropertyName("main_r_file_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MainRFileUri { get; set; }

}

/// <summary>
/// Block type for spark_sql_application_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
    /// </summary>
    [TerraformPropertyName("jar_file_uris")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? JarFileUris { get; set; }

    /// <summary>
    /// The HCFS URI of the script that contains SQL queries.
    /// </summary>
    [TerraformPropertyName("query_file_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFileUri { get; set; }

    /// <summary>
    /// Mapping of query variable names to values (equivalent to the Spark SQL command: SET &#39;name=&amp;quot;value&amp;quot;;&#39;).
    /// </summary>
    [TerraformPropertyName("script_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ScriptVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocGdcSparkApplicationTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_gdc_spark_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocGdcSparkApplication : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// An ApplicationEnvironment from which to inherit configuration properties.
    /// </summary>
    [TerraformPropertyName("application_environment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationEnvironment { get; set; }

    /// <summary>
    /// List of container image uris for additional file dependencies. Dependent files are sequentially copied from each image. If a file with the same name exists in 2 images then the file from later image is used.
    /// </summary>
    [TerraformPropertyName("dependency_images")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DependencyImages { get; set; }

    /// <summary>
    /// User-provided human-readable name to be used in user interfaces.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels to associate with this application. Labels may be used for filtering and billing tracking. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location of the spark application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The Kubernetes namespace in which to create the application. This namespace must already exist on the cluster.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Namespace { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// application-specific properties.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The id of the service instance to which this spark application belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serviceinstance is required")]
    [TerraformPropertyName("serviceinstance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Serviceinstance { get; set; }

    /// <summary>
    /// The id of the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SparkApplicationId is required")]
    [TerraformPropertyName("spark_application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SparkApplicationId { get; set; }

    /// <summary>
    /// The Dataproc version of this application.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for pyspark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PysparkApplicationConfig block(s) allowed")]
    [TerraformPropertyName("pyspark_application_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcSparkApplicationPysparkApplicationConfigBlock>>? PysparkApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkApplicationConfig block(s) allowed")]
    [TerraformPropertyName("spark_application_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcSparkApplicationSparkApplicationConfigBlock>>? SparkApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_r_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkRApplicationConfig block(s) allowed")]
    [TerraformPropertyName("spark_r_application_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcSparkApplicationSparkRApplicationConfigBlock>>? SparkRApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for spark_sql_application_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlApplicationConfig block(s) allowed")]
    [TerraformPropertyName("spark_sql_application_config")]
    public TerraformList<TerraformBlock<GoogleDataprocGdcSparkApplicationSparkSqlApplicationConfigBlock>>? SparkSqlApplicationConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocGdcSparkApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// URL for a monitoring UI for this application (for eventual Spark PHS/UI support) Out of scope for private GA
    /// </summary>
    [TerraformPropertyName("monitoring_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonitoringEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_endpoint");

    /// <summary>
    /// Identifier. The name of the application. Format: projects/{project}/locations/{location}/serviceInstances/{service_instance}/sparkApplications/{application}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// An HCFS URI pointing to the location of stdout and stdout of the application Mainly useful for Pantheon and gcloud Not in scope for private GA
    /// </summary>
    [TerraformPropertyName("output_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutputUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_uri");

    /// <summary>
    /// Whether the application is currently reconciling. True if the current state of the resource does not match the intended state, and the system is working to reconcile them, whether or not the change was user initiated.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// A message explaining the current state.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// System generated unique identifier for this application, formatted as UUID4.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}

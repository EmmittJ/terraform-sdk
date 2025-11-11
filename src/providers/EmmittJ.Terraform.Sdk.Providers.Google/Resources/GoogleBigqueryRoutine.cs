using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for arguments in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryRoutineArgumentsBlock : TerraformBlockBase
{
    /// <summary>
    /// Defaults to FIXED_TYPE. Default value: &amp;quot;FIXED_TYPE&amp;quot; Possible values: [&amp;quot;FIXED_TYPE&amp;quot;, &amp;quot;ANY_TYPE&amp;quot;]
    /// </summary>
    [TerraformProperty("argument_kind")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArgumentKind { get; set; }

    /// <summary>
    /// A JSON schema for the data type. Required unless argumentKind = ANY_TYPE.
    /// ~&amp;gt;**NOTE**: Because this field expects a JSON string, any changes to the string
    /// will create a diff, even if the JSON itself hasn&#39;t changed. If the API returns
    /// a different value for the same schema, e.g. it switched the order of values
    /// or replaced STRUCT field type with RECORD field type, we currently cannot
    /// suppress the recurring diff this causes. As a workaround, we recommend using
    /// the schema as returned by the API.
    /// </summary>
    [TerraformProperty("data_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataType { get; set; }

    /// <summary>
    /// Specifies whether the argument is input or output. Can be set for procedures only. Possible values: [&amp;quot;IN&amp;quot;, &amp;quot;OUT&amp;quot;, &amp;quot;INOUT&amp;quot;]
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The name of this argument. Can be absent for function return argument.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for remote_function_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryRoutineRemoteFunctionOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Fully qualified name of the user-provided connection object which holds
    /// the authentication information to send requests to the remote service.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    [TerraformProperty("connection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Connection { get; set; }

    /// <summary>
    /// Endpoint of the user-provided remote service, e.g.
    /// &#39;https://us-east1-my_gcf_project.cloudfunctions.net/remote_add&#39;
    /// </summary>
    [TerraformProperty("endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Endpoint { get; set; }

    /// <summary>
    /// Max number of rows in each batch sent to the remote service. If absent or if 0,
    /// BigQuery dynamically decides the number of rows in a batch.
    /// </summary>
    [TerraformProperty("max_batching_rows")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MaxBatchingRows { get; set; }

    /// <summary>
    /// User-defined context as a set of key/value pairs, which will be sent as function
    /// invocation context together with batched arguments in the requests to the remote
    /// service. The total number of bytes of keys and values must be less than 8KB.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    [TerraformProperty("user_defined_context")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> UserDefinedContext { get; set; }

}

/// <summary>
/// Block type for spark_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryRoutineSparkOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    [TerraformProperty("archive_uris")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ArchiveUris { get; set; }

    /// <summary>
    /// Fully qualified name of the user-provided Spark connection object.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    [TerraformProperty("connection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Connection { get; set; }

    /// <summary>
    /// Custom container image for the runtime environment.
    /// </summary>
    [TerraformProperty("container_image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerImage { get; set; }

    /// <summary>
    /// Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    [TerraformProperty("file_uris")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> FileUris { get; set; }

    /// <summary>
    /// JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    [TerraformProperty("jar_uris")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> JarUris { get; set; }

    /// <summary>
    /// The fully qualified name of a class in jarUris, for example, com.example.wordcount.
    /// Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.
    /// </summary>
    [TerraformProperty("main_class")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainClass { get; set; }

    /// <summary>
    /// The main file/jar URI of the Spark application.
    /// Exactly one of the definitionBody field and the mainFileUri field must be set for Python.
    /// Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.
    /// </summary>
    [TerraformProperty("main_file_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MainFileUri { get; set; }

    /// <summary>
    /// Configuration properties as a set of key/value pairs, which will be passed on to the Spark application.
    /// For more information, see Apache Spark and the procedure option list.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Properties { get; set; }

    /// <summary>
    /// Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    [TerraformProperty("py_file_uris")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> PyFileUris { get; set; }

    /// <summary>
    /// Runtime version. If not specified, the default runtime version is used.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryRoutineTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_bigquery_routine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryRoutine : TerraformResource
{
    public GoogleBigqueryRoutine(string name) : base("google_bigquery_routine", name)
    {
    }

    /// <summary>
    /// If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values: [&amp;quot;DATA_MASKING&amp;quot;]
    /// </summary>
    [TerraformProperty("data_governance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataGovernanceType { get; set; }

    /// <summary>
    /// The ID of the dataset containing this routine
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The body of the routine. For functions, this is the expression in the AS clause.
    /// If language=SQL, it is the substring inside (but excluding) the parentheses.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefinitionBody is required")]
    [TerraformProperty("definition_body")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefinitionBody { get; set; }

    /// <summary>
    /// The description of the routine if defined.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The determinism level of the JavaScript UDF if defined. Possible values: [&amp;quot;DETERMINISM_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;DETERMINISTIC&amp;quot;, &amp;quot;NOT_DETERMINISTIC&amp;quot;]
    /// </summary>
    [TerraformProperty("determinism_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeterminismLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. If language = &amp;quot;JAVASCRIPT&amp;quot;, this field stores the path of the
    /// imported JAVASCRIPT libraries.
    /// </summary>
    [TerraformProperty("imported_libraries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ImportedLibraries { get; set; }

    /// <summary>
    /// The language of the routine. Possible values: [&amp;quot;SQL&amp;quot;, &amp;quot;JAVASCRIPT&amp;quot;, &amp;quot;PYTHON&amp;quot;, &amp;quot;JAVA&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Language { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. Can be set only if routineType = &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;.
    /// 
    /// If absent, the return table type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the columns in the evaluated table result will
    /// be cast to match the column types specificed in return table type, at query time.
    /// </summary>
    [TerraformProperty("return_table_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReturnTableType { get; set; }

    /// <summary>
    /// A JSON schema for the return type. Optional if language = &amp;quot;SQL&amp;quot;; required otherwise.
    /// If absent, the return type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the evaluated result will be cast to
    /// the specified returned type at query time. ~&amp;gt;**NOTE**: Because this field expects a JSON
    /// string, any changes to the string will create a diff, even if the JSON itself hasn&#39;t
    /// changed. If the API returns a different value for the same schema, e.g. it switche
    /// d the order of values or replaced STRUCT field type with RECORD field type, we currently
    /// cannot suppress the recurring diff this causes. As a workaround, we recommend using
    /// the schema as returned by the API.
    /// </summary>
    [TerraformProperty("return_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReturnType { get; set; }

    /// <summary>
    /// The ID of the the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    [TerraformProperty("routine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoutineId { get; set; }

    /// <summary>
    /// The type of routine. Possible values: [&amp;quot;SCALAR_FUNCTION&amp;quot;, &amp;quot;PROCEDURE&amp;quot;, &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineType is required")]
    [TerraformProperty("routine_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoutineType { get; set; }

    /// <summary>
    /// Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine&#39;s configuration. Possible values: [&amp;quot;DEFINER&amp;quot;, &amp;quot;INVOKER&amp;quot;]
    /// </summary>
    [TerraformProperty("security_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityMode { get; set; }

    /// <summary>
    /// Block for arguments.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("arguments")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryRoutineArgumentsBlock>>? Arguments { get; set; }

    /// <summary>
    /// Block for remote_function_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteFunctionOptions block(s) allowed")]
    [TerraformProperty("remote_function_options")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryRoutineRemoteFunctionOptionsBlock>>? RemoteFunctionOptions { get; set; }

    /// <summary>
    /// Block for spark_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkOptions block(s) allowed")]
    [TerraformProperty("spark_options")]
    public partial TerraformList<TerraformBlock<GoogleBigqueryRoutineSparkOptionsBlock>>? SparkOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBigqueryRoutineTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when this routine was created, in milliseconds since the
    /// epoch.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CreationTime { get; }

    /// <summary>
    /// The time when this routine was modified, in milliseconds since the
    /// epoch.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LastModifiedTime { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for arguments in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineArgumentsBlock : TerraformBlock
{
    /// <summary>
    /// Defaults to FIXED_TYPE. Default value: &amp;quot;FIXED_TYPE&amp;quot; Possible values: [&amp;quot;FIXED_TYPE&amp;quot;, &amp;quot;ANY_TYPE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ArgumentKind
    {
        set => SetProperty("argument_kind", value);
    }

    /// <summary>
    /// A JSON schema for the data type. Required unless argumentKind = ANY_TYPE.
    /// ~&amp;gt;**NOTE**: Because this field expects a JSON string, any changes to the string
    /// will create a diff, even if the JSON itself hasn&#39;t changed. If the API returns
    /// a different value for the same schema, e.g. it switched the order of values
    /// or replaced STRUCT field type with RECORD field type, we currently cannot
    /// suppress the recurring diff this causes. As a workaround, we recommend using
    /// the schema as returned by the API.
    /// </summary>
    public TerraformProperty<string>? DataType
    {
        set => SetProperty("data_type", value);
    }

    /// <summary>
    /// Specifies whether the argument is input or output. Can be set for procedures only. Possible values: [&amp;quot;IN&amp;quot;, &amp;quot;OUT&amp;quot;, &amp;quot;INOUT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The name of this argument. Can be absent for function return argument.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for remote_function_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineRemoteFunctionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Fully qualified name of the user-provided connection object which holds
    /// the authentication information to send requests to the remote service.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Connection
    {
        set => SetProperty("connection", value);
    }

    /// <summary>
    /// Endpoint of the user-provided remote service, e.g.
    /// &#39;https://us-east1-my_gcf_project.cloudfunctions.net/remote_add&#39;
    /// </summary>
    public TerraformProperty<string>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// Max number of rows in each batch sent to the remote service. If absent or if 0,
    /// BigQuery dynamically decides the number of rows in a batch.
    /// </summary>
    public TerraformProperty<string>? MaxBatchingRows
    {
        set => SetProperty("max_batching_rows", value);
    }

    /// <summary>
    /// User-defined context as a set of key/value pairs, which will be sent as function
    /// invocation context together with batched arguments in the requests to the remote
    /// service. The total number of bytes of keys and values must be less than 8KB.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? UserDefinedContext
    {
        set => SetProperty("user_defined_context", value);
    }

}

/// <summary>
/// Block type for spark_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineSparkOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public List<TerraformProperty<string>>? ArchiveUris
    {
        set => SetProperty("archive_uris", value);
    }

    /// <summary>
    /// Fully qualified name of the user-provided Spark connection object.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Connection
    {
        set => SetProperty("connection", value);
    }

    /// <summary>
    /// Custom container image for the runtime environment.
    /// </summary>
    public TerraformProperty<string>? ContainerImage
    {
        set => SetProperty("container_image", value);
    }

    /// <summary>
    /// Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public List<TerraformProperty<string>>? FileUris
    {
        set => SetProperty("file_uris", value);
    }

    /// <summary>
    /// JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public List<TerraformProperty<string>>? JarUris
    {
        set => SetProperty("jar_uris", value);
    }

    /// <summary>
    /// The fully qualified name of a class in jarUris, for example, com.example.wordcount.
    /// Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.
    /// </summary>
    public TerraformProperty<string>? MainClass
    {
        set => SetProperty("main_class", value);
    }

    /// <summary>
    /// The main file/jar URI of the Spark application.
    /// Exactly one of the definitionBody field and the mainFileUri field must be set for Python.
    /// Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.
    /// </summary>
    public TerraformProperty<string>? MainFileUri
    {
        set => SetProperty("main_file_uri", value);
    }

    /// <summary>
    /// Configuration properties as a set of key/value pairs, which will be passed on to the Spark application.
    /// For more information, see Apache Spark and the procedure option list.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public List<TerraformProperty<string>>? PyFileUris
    {
        set => SetProperty("py_file_uris", value);
    }

    /// <summary>
    /// Runtime version. If not specified, the default runtime version is used.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryRoutineTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_routine resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryRoutine : TerraformResource
{
    public GoogleBigqueryRoutine(string name) : base("google_bigquery_routine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_time");
        SetOutput("last_modified_time");
        SetOutput("data_governance_type");
        SetOutput("dataset_id");
        SetOutput("definition_body");
        SetOutput("description");
        SetOutput("determinism_level");
        SetOutput("id");
        SetOutput("imported_libraries");
        SetOutput("language");
        SetOutput("project");
        SetOutput("return_table_type");
        SetOutput("return_type");
        SetOutput("routine_id");
        SetOutput("routine_type");
        SetOutput("security_mode");
    }

    /// <summary>
    /// If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values: [&amp;quot;DATA_MASKING&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DataGovernanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_governance_type");
        set => SetProperty("data_governance_type", value);
    }

    /// <summary>
    /// The ID of the dataset containing this routine
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset_id");
        set => SetProperty("dataset_id", value);
    }

    /// <summary>
    /// The body of the routine. For functions, this is the expression in the AS clause.
    /// If language=SQL, it is the substring inside (but excluding) the parentheses.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefinitionBody is required")]
    public required TerraformProperty<string> DefinitionBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("definition_body");
        set => SetProperty("definition_body", value);
    }

    /// <summary>
    /// The description of the routine if defined.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The determinism level of the JavaScript UDF if defined. Possible values: [&amp;quot;DETERMINISM_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;DETERMINISTIC&amp;quot;, &amp;quot;NOT_DETERMINISTIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DeterminismLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("determinism_level");
        set => SetProperty("determinism_level", value);
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
    /// Optional. If language = &amp;quot;JAVASCRIPT&amp;quot;, this field stores the path of the
    /// imported JAVASCRIPT libraries.
    /// </summary>
    public List<TerraformProperty<string>> ImportedLibraries
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("imported_libraries");
        set => SetProperty("imported_libraries", value);
    }

    /// <summary>
    /// The language of the routine. Possible values: [&amp;quot;SQL&amp;quot;, &amp;quot;JAVASCRIPT&amp;quot;, &amp;quot;PYTHON&amp;quot;, &amp;quot;JAVA&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Language
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language");
        set => SetProperty("language", value);
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
    /// Optional. Can be set only if routineType = &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;.
    /// 
    /// If absent, the return table type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the columns in the evaluated table result will
    /// be cast to match the column types specificed in return table type, at query time.
    /// </summary>
    public TerraformProperty<string> ReturnTableType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("return_table_type");
        set => SetProperty("return_table_type", value);
    }

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
    public TerraformProperty<string> ReturnType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("return_type");
        set => SetProperty("return_type", value);
    }

    /// <summary>
    /// The ID of the the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    public required TerraformProperty<string> RoutineId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routine_id");
        set => SetProperty("routine_id", value);
    }

    /// <summary>
    /// The type of routine. Possible values: [&amp;quot;SCALAR_FUNCTION&amp;quot;, &amp;quot;PROCEDURE&amp;quot;, &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineType is required")]
    public required TerraformProperty<string> RoutineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routine_type");
        set => SetProperty("routine_type", value);
    }

    /// <summary>
    /// Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine&#39;s configuration. Possible values: [&amp;quot;DEFINER&amp;quot;, &amp;quot;INVOKER&amp;quot;]
    /// </summary>
    public TerraformProperty<string> SecurityMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_mode");
        set => SetProperty("security_mode", value);
    }

    /// <summary>
    /// Block for arguments.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigqueryRoutineArgumentsBlock>? Arguments
    {
        set => SetProperty("arguments", value);
    }

    /// <summary>
    /// Block for remote_function_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteFunctionOptions block(s) allowed")]
    public List<GoogleBigqueryRoutineRemoteFunctionOptionsBlock>? RemoteFunctionOptions
    {
        set => SetProperty("remote_function_options", value);
    }

    /// <summary>
    /// Block for spark_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkOptions block(s) allowed")]
    public List<GoogleBigqueryRoutineSparkOptionsBlock>? SparkOptions
    {
        set => SetProperty("spark_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryRoutineTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when this routine was created, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The time when this routine was modified, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

}

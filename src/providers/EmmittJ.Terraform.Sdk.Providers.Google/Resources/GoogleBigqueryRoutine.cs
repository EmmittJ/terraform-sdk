using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for arguments in GoogleBigqueryRoutine.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineArgumentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "arguments";

    /// <summary>
    /// Defaults to FIXED_TYPE. Default value: &amp;quot;FIXED_TYPE&amp;quot; Possible values: [&amp;quot;FIXED_TYPE&amp;quot;, &amp;quot;ANY_TYPE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ArgumentKind
    {
        get => GetArgument<TerraformValue<string>>("argument_kind");
        set => SetArgument("argument_kind", value);
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
    public TerraformValue<string>? DataType
    {
        get => GetArgument<TerraformValue<string>>("data_type");
        set => SetArgument("data_type", value);
    }

    /// <summary>
    /// Specifies whether the argument is input or output. Can be set for procedures only. Possible values: [&amp;quot;IN&amp;quot;, &amp;quot;OUT&amp;quot;, &amp;quot;INOUT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name of this argument. Can be absent for function return argument.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for remote_function_options in GoogleBigqueryRoutine.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineRemoteFunctionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_function_options";

    /// <summary>
    /// Fully qualified name of the user-provided connection object which holds
    /// the authentication information to send requests to the remote service.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformValue<string>? ConnectionAttribute
    {
        get => GetArgument<TerraformValue<string>>("connection");
        set => SetArgument("connection", value);
    }

    /// <summary>
    /// Endpoint of the user-provided remote service, e.g.
    /// &#39;https://us-east1-my_gcf_project.cloudfunctions.net/remote_add&#39;
    /// </summary>
    public TerraformValue<string>? Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// Max number of rows in each batch sent to the remote service. If absent or if 0,
    /// BigQuery dynamically decides the number of rows in a batch.
    /// </summary>
    public TerraformValue<string>? MaxBatchingRows
    {
        get => GetArgument<TerraformValue<string>>("max_batching_rows");
        set => SetArgument("max_batching_rows", value);
    }

    /// <summary>
    /// User-defined context as a set of key/value pairs, which will be sent as function
    /// invocation context together with batched arguments in the requests to the remote
    /// service. The total number of bytes of keys and values must be less than 8KB.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    public TerraformMap<string>? UserDefinedContext
    {
        get => GetArgument<TerraformMap<string>>("user_defined_context");
        set => SetArgument("user_defined_context", value);
    }

}


/// <summary>
/// Block type for spark_options in GoogleBigqueryRoutine.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryRoutineSparkOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_options";

    /// <summary>
    /// Archive files to be extracted into the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public TerraformList<string>? ArchiveUris
    {
        get => GetArgument<TerraformList<string>>("archive_uris");
        set => SetArgument("archive_uris", value);
    }

    /// <summary>
    /// Fully qualified name of the user-provided Spark connection object.
    /// Format: &amp;quot;projects/{projectId}/locations/{locationId}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformValue<string>? ConnectionAttribute
    {
        get => GetArgument<TerraformValue<string>>("connection");
        set => SetArgument("connection", value);
    }

    /// <summary>
    /// Custom container image for the runtime environment.
    /// </summary>
    public TerraformValue<string>? ContainerImage
    {
        get => GetArgument<TerraformValue<string>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// Files to be placed in the working directory of each executor. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public TerraformList<string>? FileUris
    {
        get => GetArgument<TerraformList<string>>("file_uris");
        set => SetArgument("file_uris", value);
    }

    /// <summary>
    /// JARs to include on the driver and executor CLASSPATH. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public TerraformList<string>? JarUris
    {
        get => GetArgument<TerraformList<string>>("jar_uris");
        set => SetArgument("jar_uris", value);
    }

    /// <summary>
    /// The fully qualified name of a class in jarUris, for example, com.example.wordcount.
    /// Exactly one of mainClass and main_jar_uri field should be set for Java/Scala language type.
    /// </summary>
    public TerraformValue<string>? MainClass
    {
        get => GetArgument<TerraformValue<string>>("main_class");
        set => SetArgument("main_class", value);
    }

    /// <summary>
    /// The main file/jar URI of the Spark application.
    /// Exactly one of the definitionBody field and the mainFileUri field must be set for Python.
    /// Exactly one of mainClass and mainFileUri field should be set for Java/Scala language type.
    /// </summary>
    public TerraformValue<string>? MainFileUri
    {
        get => GetArgument<TerraformValue<string>>("main_file_uri");
        set => SetArgument("main_file_uri", value);
    }

    /// <summary>
    /// Configuration properties as a set of key/value pairs, which will be passed on to the Spark application.
    /// For more information, see Apache Spark and the procedure option list.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Python files to be placed on the PYTHONPATH for PySpark application. Supported file types: .py, .egg, and .zip. For more information about Apache Spark, see Apache Spark.
    /// </summary>
    public TerraformList<string>? PyFileUris
    {
        get => GetArgument<TerraformList<string>>("py_file_uris");
        set => SetArgument("py_file_uris", value);
    }

    /// <summary>
    /// Runtime version. If not specified, the default runtime version is used.
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryRoutine.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryRoutineTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigquery_routine Terraform resource.
/// Manages a google_bigquery_routine resource.
/// </summary>
public partial class GoogleBigqueryRoutine(string name) : TerraformResource("google_bigquery_routine", name)
{
    /// <summary>
    /// If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values: [&amp;quot;DATA_MASKING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DataGovernanceType
    {
        get => GetArgument<TerraformValue<string>>("data_governance_type");
        set => SetArgument("data_governance_type", value);
    }

    /// <summary>
    /// The ID of the dataset containing this routine
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The body of the routine. For functions, this is the expression in the AS clause.
    /// If language=SQL, it is the substring inside (but excluding) the parentheses.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefinitionBody is required")]
    public required TerraformValue<string> DefinitionBody
    {
        get => GetArgument<TerraformValue<string>>("definition_body");
        set => SetArgument("definition_body", value);
    }

    /// <summary>
    /// The description of the routine if defined.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The determinism level of the JavaScript UDF if defined. Possible values: [&amp;quot;DETERMINISM_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;DETERMINISTIC&amp;quot;, &amp;quot;NOT_DETERMINISTIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DeterminismLevel
    {
        get => GetArgument<TerraformValue<string>>("determinism_level");
        set => SetArgument("determinism_level", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. If language = &amp;quot;JAVASCRIPT&amp;quot;, this field stores the path of the
    /// imported JAVASCRIPT libraries.
    /// </summary>
    public TerraformList<string>? ImportedLibraries
    {
        get => GetArgument<TerraformList<string>>("imported_libraries");
        set => SetArgument("imported_libraries", value);
    }

    /// <summary>
    /// The language of the routine. Possible values: [&amp;quot;SQL&amp;quot;, &amp;quot;JAVASCRIPT&amp;quot;, &amp;quot;PYTHON&amp;quot;, &amp;quot;JAVA&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Language
    {
        get => GetArgument<TerraformValue<string>>("language");
        set => SetArgument("language", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. Can be set only if routineType = &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;.
    /// 
    /// If absent, the return table type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the columns in the evaluated table result will
    /// be cast to match the column types specificed in return table type, at query time.
    /// </summary>
    public TerraformValue<string>? ReturnTableType
    {
        get => GetArgument<TerraformValue<string>>("return_table_type");
        set => SetArgument("return_table_type", value);
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
    public TerraformValue<string>? ReturnType
    {
        get => GetArgument<TerraformValue<string>>("return_type");
        set => SetArgument("return_type", value);
    }

    /// <summary>
    /// The ID of the the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    public required TerraformValue<string> RoutineId
    {
        get => GetArgument<TerraformValue<string>>("routine_id");
        set => SetArgument("routine_id", value);
    }

    /// <summary>
    /// The type of routine. Possible values: [&amp;quot;SCALAR_FUNCTION&amp;quot;, &amp;quot;PROCEDURE&amp;quot;, &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineType is required")]
    public required TerraformValue<string> RoutineType
    {
        get => GetArgument<TerraformValue<string>>("routine_type");
        set => SetArgument("routine_type", value);
    }

    /// <summary>
    /// Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine&#39;s configuration. Possible values: [&amp;quot;DEFINER&amp;quot;, &amp;quot;INVOKER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SecurityMode
    {
        get => GetArgument<TerraformValue<string>>("security_mode");
        set => SetArgument("security_mode", value);
    }

    /// <summary>
    /// The time when this routine was created, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformValue<double> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The time when this routine was modified, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformValue<double> LastModifiedTime
        => AsReference("last_modified_time");

    /// <summary>
    /// Arguments block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryRoutineArgumentsBlock>? Arguments
    {
        get => GetArgument<TerraformList<GoogleBigqueryRoutineArgumentsBlock>>("arguments");
        set => SetArgument("arguments", value);
    }

    /// <summary>
    /// RemoteFunctionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteFunctionOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryRoutineRemoteFunctionOptionsBlock>? RemoteFunctionOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryRoutineRemoteFunctionOptionsBlock>>("remote_function_options");
        set => SetArgument("remote_function_options", value);
    }

    /// <summary>
    /// SparkOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryRoutineSparkOptionsBlock>? SparkOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryRoutineSparkOptionsBlock>>("spark_options");
        set => SetArgument("spark_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryRoutineTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryRoutineTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

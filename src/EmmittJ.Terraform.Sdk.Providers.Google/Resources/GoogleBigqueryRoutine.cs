using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_routine resource.
/// </summary>
public class GoogleBigqueryRoutine : TerraformResource
{
    public GoogleBigqueryRoutine(string name) : base("google_bigquery_routine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_time");
        this.DeclareOutput("last_modified_time");
    }

    /// <summary>
    /// If set to DATA_MASKING, the function is validated and made available as a masking function. For more information, see https://cloud.google.com/bigquery/docs/user-defined-functions#custom-mask Possible values: [&amp;quot;DATA_MASKING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DataGovernanceType
    {
        get => GetProperty<TerraformProperty<string>>("data_governance_type");
        set => this.WithProperty("data_governance_type", value);
    }

    /// <summary>
    /// The ID of the dataset containing this routine
    /// </summary>
    public TerraformProperty<string>? DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => this.WithProperty("dataset_id", value);
    }

    /// <summary>
    /// The body of the routine. For functions, this is the expression in the AS clause.
    /// If language=SQL, it is the substring inside (but excluding) the parentheses.
    /// </summary>
    public TerraformProperty<string>? DefinitionBody
    {
        get => GetProperty<TerraformProperty<string>>("definition_body");
        set => this.WithProperty("definition_body", value);
    }

    /// <summary>
    /// The description of the routine if defined.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The determinism level of the JavaScript UDF if defined. Possible values: [&amp;quot;DETERMINISM_LEVEL_UNSPECIFIED&amp;quot;, &amp;quot;DETERMINISTIC&amp;quot;, &amp;quot;NOT_DETERMINISTIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DeterminismLevel
    {
        get => GetProperty<TerraformProperty<string>>("determinism_level");
        set => this.WithProperty("determinism_level", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Optional. If language = &amp;quot;JAVASCRIPT&amp;quot;, this field stores the path of the
    /// imported JAVASCRIPT libraries.
    /// </summary>
    public TerraformProperty<List<string>>? ImportedLibraries
    {
        get => GetProperty<TerraformProperty<List<string>>>("imported_libraries");
        set => this.WithProperty("imported_libraries", value);
    }

    /// <summary>
    /// The language of the routine. Possible values: [&amp;quot;SQL&amp;quot;, &amp;quot;JAVASCRIPT&amp;quot;, &amp;quot;PYTHON&amp;quot;, &amp;quot;JAVA&amp;quot;, &amp;quot;SCALA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Language
    {
        get => GetProperty<TerraformProperty<string>>("language");
        set => this.WithProperty("language", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Optional. Can be set only if routineType = &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;.
    /// 
    /// If absent, the return table type is inferred from definitionBody at query time in each query
    /// that references this routine. If present, then the columns in the evaluated table result will
    /// be cast to match the column types specificed in return table type, at query time.
    /// </summary>
    public TerraformProperty<string>? ReturnTableType
    {
        get => GetProperty<TerraformProperty<string>>("return_table_type");
        set => this.WithProperty("return_table_type", value);
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
    public TerraformProperty<string>? ReturnType
    {
        get => GetProperty<TerraformProperty<string>>("return_type");
        set => this.WithProperty("return_type", value);
    }

    /// <summary>
    /// The ID of the the routine. The ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_). The maximum length is 256 characters.
    /// </summary>
    public TerraformProperty<string>? RoutineId
    {
        get => GetProperty<TerraformProperty<string>>("routine_id");
        set => this.WithProperty("routine_id", value);
    }

    /// <summary>
    /// The type of routine. Possible values: [&amp;quot;SCALAR_FUNCTION&amp;quot;, &amp;quot;PROCEDURE&amp;quot;, &amp;quot;TABLE_VALUED_FUNCTION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RoutineType
    {
        get => GetProperty<TerraformProperty<string>>("routine_type");
        set => this.WithProperty("routine_type", value);
    }

    /// <summary>
    /// Optional. The security mode of the routine, if defined. If not defined, the security mode is automatically determined from the routine&#39;s configuration. Possible values: [&amp;quot;DEFINER&amp;quot;, &amp;quot;INVOKER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SecurityMode
    {
        get => GetProperty<TerraformProperty<string>>("security_mode");
        set => this.WithProperty("security_mode", value);
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

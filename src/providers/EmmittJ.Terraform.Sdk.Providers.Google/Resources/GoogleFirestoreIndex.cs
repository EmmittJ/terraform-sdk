using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreIndexFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and
    /// &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;CONTAINS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ArrayConfig
    {
        set => SetProperty("array_config", value);
    }

    /// <summary>
    /// Name of the field.
    /// </summary>
    public TerraformProperty<string>? FieldPath
    {
        set => SetProperty("field_path", value);
    }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;, &amp;lt;=, &amp;gt;, &amp;gt;=.
    /// Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;ASCENDING&amp;quot;, &amp;quot;DESCENDING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Order
    {
        set => SetProperty("order", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreIndexTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_firestore_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreIndex : TerraformResource
{
    public GoogleFirestoreIndex(string name) : base("google_firestore_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("api_scope");
        SetOutput("collection");
        SetOutput("database");
        SetOutput("density");
        SetOutput("id");
        SetOutput("multikey");
        SetOutput("project");
        SetOutput("query_scope");
        SetOutput("unique");
    }

    /// <summary>
    /// The API scope at which a query is run. Default value: &amp;quot;ANY_API&amp;quot; Possible values: [&amp;quot;ANY_API&amp;quot;, &amp;quot;DATASTORE_MODE_API&amp;quot;, &amp;quot;MONGODB_COMPATIBLE_API&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ApiScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_scope");
        set => SetProperty("api_scope", value);
    }

    /// <summary>
    /// The collection being indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformProperty<string> Collection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection");
        set => SetProperty("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The density configuration for this index. Possible values: [&amp;quot;SPARSE_ALL&amp;quot;, &amp;quot;SPARSE_ANY&amp;quot;, &amp;quot;DENSE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Density
    {
        get => GetRequiredOutput<TerraformProperty<string>>("density");
        set => SetProperty("density", value);
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
    /// Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.
    /// </summary>
    public TerraformProperty<bool> Multikey
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multikey");
        set => SetProperty("multikey", value);
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
    /// The scope at which a query is run. Default value: &amp;quot;COLLECTION&amp;quot; Possible values: [&amp;quot;COLLECTION&amp;quot;, &amp;quot;COLLECTION_GROUP&amp;quot;, &amp;quot;COLLECTION_RECURSIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> QueryScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_scope");
        set => SetProperty("query_scope", value);
    }

    /// <summary>
    /// Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.
    /// </summary>
    public TerraformProperty<bool> Unique
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("unique");
        set => SetProperty("unique", value);
    }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public List<GoogleFirestoreIndexFieldsBlock>? Fields
    {
        set => SetProperty("fields", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirestoreIndexTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A server defined name for this index. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}

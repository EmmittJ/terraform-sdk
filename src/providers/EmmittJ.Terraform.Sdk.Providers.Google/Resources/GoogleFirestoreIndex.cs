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
        get => GetProperty<TerraformProperty<string>>("array_config");
        set => WithProperty("array_config", value);
    }

    /// <summary>
    /// Name of the field.
    /// </summary>
    public TerraformProperty<string>? FieldPath
    {
        get => GetProperty<TerraformProperty<string>>("field_path");
        set => WithProperty("field_path", value);
    }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;, &amp;lt;=, &amp;gt;, &amp;gt;=.
    /// Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;ASCENDING&amp;quot;, &amp;quot;DESCENDING&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Order
    {
        get => GetProperty<TerraformProperty<string>>("order");
        set => WithProperty("order", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.WithOutput("name");
    }

    /// <summary>
    /// The API scope at which a query is run. Default value: &amp;quot;ANY_API&amp;quot; Possible values: [&amp;quot;ANY_API&amp;quot;, &amp;quot;DATASTORE_MODE_API&amp;quot;, &amp;quot;MONGODB_COMPATIBLE_API&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ApiScope
    {
        get => GetProperty<TerraformProperty<string>>("api_scope");
        set => this.WithProperty("api_scope", value);
    }

    /// <summary>
    /// The collection being indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformProperty<string> Collection
    {
        get => GetRequiredProperty<TerraformProperty<string>>("collection");
        set => this.WithProperty("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The density configuration for this index. Possible values: [&amp;quot;SPARSE_ALL&amp;quot;, &amp;quot;SPARSE_ANY&amp;quot;, &amp;quot;DENSE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Density
    {
        get => GetProperty<TerraformProperty<string>>("density");
        set => this.WithProperty("density", value);
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
    /// Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.
    /// </summary>
    public TerraformProperty<bool>? Multikey
    {
        get => GetProperty<TerraformProperty<bool>>("multikey");
        set => this.WithProperty("multikey", value);
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
    /// The scope at which a query is run. Default value: &amp;quot;COLLECTION&amp;quot; Possible values: [&amp;quot;COLLECTION&amp;quot;, &amp;quot;COLLECTION_GROUP&amp;quot;, &amp;quot;COLLECTION_RECURSIVE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? QueryScope
    {
        get => GetProperty<TerraformProperty<string>>("query_scope");
        set => this.WithProperty("query_scope", value);
    }

    /// <summary>
    /// Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.
    /// </summary>
    public TerraformProperty<bool>? Unique
    {
        get => GetProperty<TerraformProperty<bool>>("unique");
        set => this.WithProperty("unique", value);
    }

    /// <summary>
    /// Block for fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public List<GoogleFirestoreIndexFieldsBlock>? Fields
    {
        get => GetProperty<List<GoogleFirestoreIndexFieldsBlock>>("fields");
        set => this.WithProperty("fields", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirestoreIndexTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirestoreIndexTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// A server defined name for this index. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}

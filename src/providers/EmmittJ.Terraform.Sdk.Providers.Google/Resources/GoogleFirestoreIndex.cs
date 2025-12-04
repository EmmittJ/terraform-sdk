using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in GoogleFirestoreIndex.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreIndexFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and
    /// &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;CONTAINS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ArrayConfig
    {
        get => GetArgument<TerraformValue<string>>("array_config");
        set => SetArgument("array_config", value);
    }

    /// <summary>
    /// Name of the field.
    /// </summary>
    public TerraformValue<string>? FieldPath
    {
        get => GetArgument<TerraformValue<string>>("field_path");
        set => SetArgument("field_path", value);
    }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;, &amp;lt;=, &amp;gt;, &amp;gt;=.
    /// Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;ASCENDING&amp;quot;, &amp;quot;DESCENDING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Order
    {
        get => GetArgument<TerraformValue<string>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// VectorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VectorConfig block(s) allowed")]
    public TerraformList<GoogleFirestoreIndexFieldsBlockVectorConfigBlock>? VectorConfig
    {
        get => GetArgument<TerraformList<GoogleFirestoreIndexFieldsBlockVectorConfigBlock>>("vector_config");
        set => SetArgument("vector_config", value);
    }

}

/// <summary>
/// Block type for vector_config in GoogleFirestoreIndexFieldsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreIndexFieldsBlockVectorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vector_config";

    /// <summary>
    /// The resulting index will only include vectors of this dimension, and can be used for vector search
    /// with the same dimension.
    /// </summary>
    public TerraformValue<double>? Dimension
    {
        get => GetArgument<TerraformValue<double>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Flat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Flat block(s) allowed")]
    public TerraformList<GoogleFirestoreIndexFieldsBlockVectorConfigBlockFlatBlock>? Flat
    {
        get => GetArgument<TerraformList<GoogleFirestoreIndexFieldsBlockVectorConfigBlockFlatBlock>>("flat");
        set => SetArgument("flat", value);
    }

}

/// <summary>
/// Block type for flat in GoogleFirestoreIndexFieldsBlockVectorConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreIndexFieldsBlockVectorConfigBlockFlatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flat";

}


/// <summary>
/// Block type for timeouts in GoogleFirestoreIndex.
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreIndexTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_firestore_index Terraform resource.
/// Manages a google_firestore_index resource.
/// </summary>
public partial class GoogleFirestoreIndex(string name) : TerraformResource("google_firestore_index", name)
{
    /// <summary>
    /// The API scope at which a query is run. Default value: &amp;quot;ANY_API&amp;quot; Possible values: [&amp;quot;ANY_API&amp;quot;, &amp;quot;DATASTORE_MODE_API&amp;quot;, &amp;quot;MONGODB_COMPATIBLE_API&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ApiScope
    {
        get => GetArgument<TerraformValue<string>>("api_scope");
        set => SetArgument("api_scope", value);
    }

    /// <summary>
    /// The collection being indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    public required TerraformValue<string> Collection
    {
        get => GetRequiredArgument<TerraformValue<string>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The density configuration for this index. Possible values: [&amp;quot;SPARSE_ALL&amp;quot;, &amp;quot;SPARSE_ANY&amp;quot;, &amp;quot;DENSE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Density
    {
        get => GetArgument<TerraformValue<string>>("density") ?? AsReference("density");
        set => SetArgument("density", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.
    /// </summary>
    public TerraformValue<bool>? Multikey
    {
        get => GetArgument<TerraformValue<bool>>("multikey");
        set => SetArgument("multikey", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The scope at which a query is run. Default value: &amp;quot;COLLECTION&amp;quot; Possible values: [&amp;quot;COLLECTION&amp;quot;, &amp;quot;COLLECTION_GROUP&amp;quot;, &amp;quot;COLLECTION_RECURSIVE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? QueryScope
    {
        get => GetArgument<TerraformValue<string>>("query_scope");
        set => SetArgument("query_scope", value);
    }

    /// <summary>
    /// Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.
    /// </summary>
    public TerraformValue<bool> Unique
    {
        get => GetArgument<TerraformValue<bool>>("unique") ?? AsReference("unique");
        set => SetArgument("unique", value);
    }

    /// <summary>
    /// A server defined name for this index. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Fields block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public required TerraformList<GoogleFirestoreIndexFieldsBlock> Fields
    {
        get => GetRequiredArgument<TerraformList<GoogleFirestoreIndexFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirestoreIndexTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirestoreIndexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

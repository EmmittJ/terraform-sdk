using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for fields in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreIndexFieldsBlock
{
    /// <summary>
    /// Indicates that this field supports operations on arrayValues. Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and
    /// &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;CONTAINS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("array_config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ArrayConfig { get; set; }

    /// <summary>
    /// Name of the field.
    /// </summary>
    [TerraformPropertyName("field_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FieldPath { get; set; }

    /// <summary>
    /// Indicates that this field supports ordering by the specified order or comparing using =, &amp;lt;, &amp;lt;=, &amp;gt;, &amp;gt;=.
    /// Only one of &#39;order&#39;, &#39;arrayConfig&#39;, and &#39;vectorConfig&#39; can be specified. Possible values: [&amp;quot;ASCENDING&amp;quot;, &amp;quot;DESCENDING&amp;quot;]
    /// </summary>
    [TerraformPropertyName("order")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Order { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreIndexTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_firestore_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreIndex : TerraformResource
{
    public GoogleFirestoreIndex(string name) : base("google_firestore_index", name)
    {
    }

    /// <summary>
    /// The API scope at which a query is run. Default value: &amp;quot;ANY_API&amp;quot; Possible values: [&amp;quot;ANY_API&amp;quot;, &amp;quot;DATASTORE_MODE_API&amp;quot;, &amp;quot;MONGODB_COMPATIBLE_API&amp;quot;]
    /// </summary>
    [TerraformPropertyName("api_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiScope { get; set; }

    /// <summary>
    /// The collection being indexed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    [TerraformPropertyName("collection")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Collection { get; set; }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    [TerraformPropertyName("database")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Database { get; set; }

    /// <summary>
    /// The density configuration for this index. Possible values: [&amp;quot;SPARSE_ALL&amp;quot;, &amp;quot;SPARSE_ANY&amp;quot;, &amp;quot;DENSE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("density")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Density { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Optional. Whether the index is multikey. By default, the index is not multikey. For non-multikey indexes, none of the paths in the index definition reach or traverse an array, except via an explicit array index. For multikey indexes, at most one of the paths in the index definition reach or traverse an array, except via an explicit array index. Violations will result in errors. Note this field only applies to indexes with MONGODB_COMPATIBLE_API ApiScope.
    /// </summary>
    [TerraformPropertyName("multikey")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Multikey { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The scope at which a query is run. Default value: &amp;quot;COLLECTION&amp;quot; Possible values: [&amp;quot;COLLECTION&amp;quot;, &amp;quot;COLLECTION_GROUP&amp;quot;, &amp;quot;COLLECTION_RECURSIVE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("query_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryScope { get; set; }

    /// <summary>
    /// Whether it is an unique index. Unique index ensures all values for the indexed field(s) are unique across documents.
    /// </summary>
    [TerraformPropertyName("unique")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Unique { get; set; } = default!;

    /// <summary>
    /// Block for fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    [TerraformPropertyName("fields")]
    public TerraformList<TerraformBlock<GoogleFirestoreIndexFieldsBlock>>? Fields { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirestoreIndexTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// A server defined name for this index. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/indexes/{{server_generated_id}}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}

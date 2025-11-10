using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for index_config in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldIndexConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreFieldTimeoutsBlock : ITerraformBlock
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
/// Block type for ttl_config in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreFieldTtlConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The state of TTL (time-to-live) configuration for documents that have this Field set.
    /// </summary>
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

}

/// <summary>
/// Manages a google_firestore_field resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreField : TerraformResource
{
    public GoogleFirestoreField(string name) : base("google_firestore_field", name)
    {
    }

    /// <summary>
    /// The id of the collection group to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    [TerraformPropertyName("collection")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Collection { get; set; }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    [TerraformPropertyName("database")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Database { get; set; }

    /// <summary>
    /// The id of the field to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformPropertyName("field")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Field { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for index_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexConfig block(s) allowed")]
    [TerraformPropertyName("index_config")]
    public TerraformList<TerraformBlock<GoogleFirestoreFieldIndexConfigBlock>>? IndexConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirestoreFieldTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for ttl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtlConfig block(s) allowed")]
    [TerraformPropertyName("ttl_config")]
    public TerraformList<TerraformBlock<GoogleFirestoreFieldTtlConfigBlock>>? TtlConfig { get; set; } = new();

    /// <summary>
    /// The name of this field. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}

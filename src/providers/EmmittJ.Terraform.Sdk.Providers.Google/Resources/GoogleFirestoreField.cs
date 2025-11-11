using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for index_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirestoreFieldIndexConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirestoreFieldTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for ttl_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirestoreFieldTtlConfigBlock : TerraformBlockBase
{

}

/// <summary>
/// Manages a google_firestore_field resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFirestoreField : TerraformResource
{
    public GoogleFirestoreField(string name) : base("google_firestore_field", name)
    {
    }

    /// <summary>
    /// The id of the collection group to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Collection is required")]
    [TerraformProperty("collection")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Collection { get; set; }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    [TerraformProperty("database")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Database { get; set; }

    /// <summary>
    /// The id of the field to configure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformProperty("field")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Field { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for index_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IndexConfig block(s) allowed")]
    [TerraformProperty("index_config")]
    public TerraformList<TerraformBlock<GoogleFirestoreFieldIndexConfigBlock>>? IndexConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleFirestoreFieldTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for ttl_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtlConfig block(s) allowed")]
    [TerraformProperty("ttl_config")]
    public TerraformList<TerraformBlock<GoogleFirestoreFieldTtlConfigBlock>>? TtlConfig { get; set; }

    /// <summary>
    /// The name of this field. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/collectionGroups/{{collection}}/fields/{{field}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}

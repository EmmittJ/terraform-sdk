using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlock : ITerraformBlock
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied. Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;]
    /// </summary>
    [TerraformPropertyName("combining_function")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CombiningFunction { get; set; }

}

/// <summary>
/// Block type for custom in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelCustomBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelTimeoutsBlock : ITerraformBlock
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
/// Manages a google_access_context_manager_access_level resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerAccessLevel : TerraformResource
{
    public GoogleAccessContextManagerAccessLevel(string name) : base("google_access_context_manager_access_level", name)
    {
    }

    /// <summary>
    /// Description of the AccessLevel and its use. Does not affect behavior.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformPropertyName("title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Title { get; set; }

    /// <summary>
    /// Block for basic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    [TerraformPropertyName("basic")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelBasicBlock>>? Basic { get; set; } = new();

    /// <summary>
    /// Block for custom.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Custom block(s) allowed")]
    [TerraformPropertyName("custom")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelCustomBlock>>? Custom { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerAccessLevelTimeoutsBlock>? Timeouts { get; set; } = new();

}

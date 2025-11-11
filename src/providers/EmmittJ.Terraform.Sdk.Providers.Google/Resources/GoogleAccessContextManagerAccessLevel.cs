using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelBasicBlock : TerraformBlockBase
{
    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied. Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;]
    /// </summary>
    [TerraformProperty("combining_function")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CombiningFunction { get; set; }

}

/// <summary>
/// Block type for custom in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelCustomBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_access_context_manager_access_level resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAccessContextManagerAccessLevel : TerraformResource
{
    public GoogleAccessContextManagerAccessLevel(string name) : base("google_access_context_manager_access_level", name)
    {
    }

    /// <summary>
    /// Description of the AccessLevel and its use. Does not affect behavior.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformProperty("title")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Title { get; set; }

    /// <summary>
    /// Block for basic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    [TerraformProperty("basic")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelBasicBlock>>? Basic { get; set; }

    /// <summary>
    /// Block for custom.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Custom block(s) allowed")]
    [TerraformProperty("custom")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelCustomBlock>>? Custom { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerAccessLevelTimeoutsBlock>? Timeouts { get; set; }

}

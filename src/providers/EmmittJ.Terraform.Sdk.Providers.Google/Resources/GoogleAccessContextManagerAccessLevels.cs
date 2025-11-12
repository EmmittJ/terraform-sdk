using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_levels in .
/// Nesting mode: set
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelsAccessLevelsBlock() : TerraformBlock("access_levels")
{
    /// <summary>
    /// Description of the AccessLevel and its use. Does not affect behavior.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformProperty("title")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelsTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_access_context_manager_access_levels resource.
/// </summary>
public partial class GoogleAccessContextManagerAccessLevels : TerraformResource
{
    public GoogleAccessContextManagerAccessLevels(string name) : base("google_access_context_manager_access_levels", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for access_levels.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("access_levels")]
    public TerraformSet<GoogleAccessContextManagerAccessLevelsAccessLevelsBlock> AccessLevels { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleAccessContextManagerAccessLevelsTimeoutsBlock Timeouts { get; set; } = new();

}

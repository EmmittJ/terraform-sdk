using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirebaserulesReleaseTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_firebaserules_release resource.
/// </summary>
public partial class GoogleFirebaserulesRelease : TerraformResource
{
    public GoogleFirebaserulesRelease(string name) : base("google_firebaserules_release", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Format: `projects/{project_id}/releases/{release_id}`\Firestore Rules Releases will **always** have the name &#39;cloud.firestore&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project for the resource
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist for the `Release` to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesetName is required")]
    [TerraformProperty("ruleset_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RulesetName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleFirebaserulesReleaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Time the release was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Disable the release to keep it from being served. The response code of NOT_FOUND will be given for executables generated from this Release.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// Output only. Time the release was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}

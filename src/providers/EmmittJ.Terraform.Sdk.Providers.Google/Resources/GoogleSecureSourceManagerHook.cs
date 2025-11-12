using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for push_option in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSecureSourceManagerHookPushOptionBlock() : TerraformBlock("push_option")
{
    /// <summary>
    /// Trigger hook for matching branches only.
    /// Specified as glob pattern. If empty or *, events for all branches are
    /// reported. Examples: main, {main,release*}.
    /// See https://pkg.go.dev/github.com/gobwas/glob documentation.
    /// </summary>
    [TerraformProperty("branch_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BranchFilter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSecureSourceManagerHookTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_secure_source_manager_hook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSecureSourceManagerHook : TerraformResource
{
    public GoogleSecureSourceManagerHook(string name) : base("google_secure_source_manager_hook", name)
    {
    }

    /// <summary>
    /// Determines if the hook disabled or not.
    /// Set to true to stop sending traffic.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    [TerraformProperty("events")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Events { get; set; }

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookId is required")]
    [TerraformProperty("hook_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HookId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformProperty("repository_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryId { get; set; }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    [TerraformProperty("sensitive_query_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SensitiveQueryString { get; set; }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    [TerraformProperty("target_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetUri { get; set; }

    /// <summary>
    /// Block for push_option.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushOption block(s) allowed")]
    [TerraformProperty("push_option")]
    public TerraformList<GoogleSecureSourceManagerHookPushOptionBlock> PushOption { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleSecureSourceManagerHookTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Create timestamp.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// A unique identifier for a Hook. The name should be of the format:
    /// &#39;projects/{project}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Unique identifier of the hook.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Update timestamp.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}

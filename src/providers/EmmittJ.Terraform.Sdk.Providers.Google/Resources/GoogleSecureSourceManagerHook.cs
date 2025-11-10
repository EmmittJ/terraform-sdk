using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for push_option in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerHookPushOptionBlock : ITerraformBlock
{
    /// <summary>
    /// Trigger hook for matching branches only.
    /// Specified as glob pattern. If empty or *, events for all branches are
    /// reported. Examples: main, {main,release*}.
    /// See https://pkg.go.dev/github.com/gobwas/glob documentation.
    /// </summary>
    [TerraformPropertyName("branch_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BranchFilter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerHookTimeoutsBlock : ITerraformBlock
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
/// Manages a google_secure_source_manager_hook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecureSourceManagerHook : TerraformResource
{
    public GoogleSecureSourceManagerHook(string name) : base("google_secure_source_manager_hook", name)
    {
    }

    /// <summary>
    /// Determines if the hook disabled or not.
    /// Set to true to stop sending traffic.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    [TerraformPropertyName("events")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Events { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "events");

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookId is required")]
    [TerraformPropertyName("hook_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HookId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    [TerraformPropertyName("repository_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryId { get; set; }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    [TerraformPropertyName("sensitive_query_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SensitiveQueryString { get; set; }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    [TerraformPropertyName("target_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetUri { get; set; }

    /// <summary>
    /// Block for push_option.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushOption block(s) allowed")]
    [TerraformPropertyName("push_option")]
    public TerraformList<TerraformBlock<GoogleSecureSourceManagerHookPushOptionBlock>>? PushOption { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSecureSourceManagerHookTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create timestamp.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// A unique identifier for a Hook. The name should be of the format:
    /// &#39;projects/{project}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Unique identifier of the hook.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Update timestamp.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}

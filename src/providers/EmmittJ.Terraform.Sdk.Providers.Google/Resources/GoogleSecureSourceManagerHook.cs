using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for push_option in GoogleSecureSourceManagerHook.
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerHookPushOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "push_option";

    /// <summary>
    /// Trigger hook for matching branches only.
    /// Specified as glob pattern. If empty or *, events for all branches are
    /// reported. Examples: main, {main,release*}.
    /// See https://pkg.go.dev/github.com/gobwas/glob documentation.
    /// </summary>
    public TerraformValue<string>? BranchFilter
    {
        get => new TerraformReference<string>(this, "branch_filter");
        set => SetArgument("branch_filter", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSecureSourceManagerHook.
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerHookTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_secure_source_manager_hook Terraform resource.
/// Manages a google_secure_source_manager_hook resource.
/// </summary>
public partial class GoogleSecureSourceManagerHook(string name) : TerraformResource("google_secure_source_manager_hook", name)
{
    /// <summary>
    /// Determines if the hook disabled or not.
    /// Set to true to stop sending traffic.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    public TerraformList<string> Events
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "events").ResolveNodes(ctx));
        set => SetArgument("events", value);
    }

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookId is required")]
    public required TerraformValue<string> HookId
    {
        get => new TerraformReference<string>(this, "hook_id");
        set => SetArgument("hook_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => new TerraformReference<string>(this, "repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    public TerraformValue<string>? SensitiveQueryString
    {
        get => new TerraformReference<string>(this, "sensitive_query_string");
        set => SetArgument("sensitive_query_string", value);
    }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    public required TerraformValue<string> TargetUri
    {
        get => new TerraformReference<string>(this, "target_uri");
        set => SetArgument("target_uri", value);
    }

    /// <summary>
    /// Create timestamp.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// A unique identifier for a Hook. The name should be of the format:
    /// &#39;projects/{project}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Unique identifier of the hook.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Update timestamp.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// PushOption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushOption block(s) allowed")]
    public TerraformList<GoogleSecureSourceManagerHookPushOptionBlock>? PushOption
    {
        get => GetArgument<TerraformList<GoogleSecureSourceManagerHookPushOptionBlock>>("push_option");
        set => SetArgument("push_option", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecureSourceManagerHookTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecureSourceManagerHookTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

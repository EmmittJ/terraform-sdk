using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for push_option in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerHookPushOptionBlock : TerraformBlock
{
    /// <summary>
    /// Trigger hook for matching branches only.
    /// Specified as glob pattern. If empty or *, events for all branches are
    /// reported. Examples: main, {main,release*}.
    /// See https://pkg.go.dev/github.com/gobwas/glob documentation.
    /// </summary>
    public TerraformProperty<string>? BranchFilter
    {
        get => GetProperty<TerraformProperty<string>>("branch_filter");
        set => WithProperty("branch_filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerHookTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_secure_source_manager_hook resource.
/// </summary>
public class GoogleSecureSourceManagerHook : TerraformResource
{
    public GoogleSecureSourceManagerHook(string name) : base("google_secure_source_manager_hook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Determines if the hook disabled or not.
    /// Set to true to stop sending traffic.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? Events
    {
        get => GetProperty<List<TerraformProperty<string>>>("events");
        set => this.WithProperty("events", value);
    }

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookId is required")]
    public required TerraformProperty<string> HookId
    {
        get => GetProperty<TerraformProperty<string>>("hook_id");
        set => this.WithProperty("hook_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetProperty<TerraformProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    public TerraformProperty<string>? SensitiveQueryString
    {
        get => GetProperty<TerraformProperty<string>>("sensitive_query_string");
        set => this.WithProperty("sensitive_query_string", value);
    }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    public required TerraformProperty<string> TargetUri
    {
        get => GetProperty<TerraformProperty<string>>("target_uri");
        set => this.WithProperty("target_uri", value);
    }

    /// <summary>
    /// Block for push_option.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushOption block(s) allowed")]
    public List<GoogleSecureSourceManagerHookPushOptionBlock>? PushOption
    {
        get => GetProperty<List<GoogleSecureSourceManagerHookPushOptionBlock>>("push_option");
        set => this.WithProperty("push_option", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerHookTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSecureSourceManagerHookTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Create timestamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// A unique identifier for a Hook. The name should be of the format:
    /// &#39;projects/{project}/locations/{location_id}/repositories/{repository_id}/hooks/{hook_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Unique identifier of the hook.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Update timestamp.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

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
        set => SetProperty("branch_filter", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_secure_source_manager_hook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecureSourceManagerHook : TerraformResource
{
    public GoogleSecureSourceManagerHook(string name) : base("google_secure_source_manager_hook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("disabled");
        SetOutput("events");
        SetOutput("hook_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("repository_id");
        SetOutput("sensitive_query_string");
        SetOutput("target_uri");
    }

    /// <summary>
    /// Determines if the hook disabled or not.
    /// Set to true to stop sending traffic.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>> Events
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("events");
        set => SetProperty("events", value);
    }

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HookId is required")]
    public required TerraformProperty<string> HookId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hook_id");
        set => SetProperty("hook_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformProperty<string> RepositoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_id");
        set => SetProperty("repository_id", value);
    }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    public TerraformProperty<string> SensitiveQueryString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sensitive_query_string");
        set => SetProperty("sensitive_query_string", value);
    }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    public required TerraformProperty<string> TargetUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_uri");
        set => SetProperty("target_uri", value);
    }

    /// <summary>
    /// Block for push_option.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PushOption block(s) allowed")]
    public List<GoogleSecureSourceManagerHookPushOptionBlock>? PushOption
    {
        set => SetProperty("push_option", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerHookTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

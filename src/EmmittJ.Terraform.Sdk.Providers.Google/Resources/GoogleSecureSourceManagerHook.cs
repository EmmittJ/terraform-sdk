using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The events that trigger hook on. Possible values: [&amp;quot;PUSH&amp;quot;, &amp;quot;PULL_REQUEST&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Events
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("events");
        set => this.WithProperty("events", value);
    }

    /// <summary>
    /// The ID for the Hook.
    /// </summary>
    public TerraformLiteralProperty<string>? HookId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hook_id");
        set => this.WithProperty("hook_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location for the Repository.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID for the Repository.
    /// </summary>
    public TerraformLiteralProperty<string>? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id");
        set => this.WithProperty("repository_id", value);
    }

    /// <summary>
    /// The sensitive query string to be appended to the target URI.
    /// </summary>
    public TerraformLiteralProperty<string>? SensitiveQueryString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sensitive_query_string");
        set => this.WithProperty("sensitive_query_string", value);
    }

    /// <summary>
    /// The target URI to which the payloads will be delivered.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_uri");
        set => this.WithProperty("target_uri", value);
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

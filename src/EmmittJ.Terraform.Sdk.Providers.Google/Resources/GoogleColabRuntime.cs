using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notebook_runtime_template_ref in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeNotebookRuntimeTemplateRefBlock : TerraformBlock
{
    /// <summary>
    /// The resource name of the NotebookRuntimeTemplate based on which a NotebookRuntime will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookRuntimeTemplate is required")]
    public required TerraformProperty<string> NotebookRuntimeTemplate
    {
        get => GetProperty<TerraformProperty<string>>("notebook_runtime_template");
        set => WithProperty("notebook_runtime_template", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTimeoutsBlock : TerraformBlock
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
/// Manages a google_colab_runtime resource.
/// </summary>
public class GoogleColabRuntime : TerraformResource
{
    public GoogleColabRuntime(string name) : base("google_colab_runtime", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration_time");
        this.DeclareOutput("is_upgradable");
        this.DeclareOutput("notebook_runtime_type");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade");
        set => this.WithProperty("auto_upgrade", value);
    }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    public TerraformProperty<string>? DesiredState
    {
        get => GetProperty<TerraformProperty<string>>("desired_state");
        set => this.WithProperty("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The user email of the NotebookRuntime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeUser is required")]
    public required TerraformProperty<string> RuntimeUser
    {
        get => GetProperty<TerraformProperty<string>>("runtime_user");
        set => this.WithProperty("runtime_user", value);
    }

    /// <summary>
    /// Block for notebook_runtime_template_ref.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookRuntimeTemplateRef block(s) allowed")]
    public List<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>? NotebookRuntimeTemplateRef
    {
        get => GetProperty<List<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>>("notebook_runtime_template_ref");
        set => this.WithProperty("notebook_runtime_template_ref", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabRuntimeTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleColabRuntimeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Timestamp when this NotebookRuntime will be expired.
    /// </summary>
    public TerraformExpression ExpirationTime => this["expiration_time"];

    /// <summary>
    /// Output only. Checks if the NotebookRuntime is upgradable.
    /// </summary>
    public TerraformExpression IsUpgradable => this["is_upgradable"];

    /// <summary>
    /// Output only. The type of the notebook runtime.
    /// </summary>
    public TerraformExpression NotebookRuntimeType => this["notebook_runtime_type"];

    /// <summary>
    /// Output only. The state of the runtime.
    /// </summary>
    public TerraformExpression State => this["state"];

}

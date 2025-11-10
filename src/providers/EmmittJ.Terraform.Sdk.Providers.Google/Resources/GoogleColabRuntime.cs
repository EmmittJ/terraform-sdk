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
        set => SetProperty("notebook_runtime_template", value);
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
/// Manages a google_colab_runtime resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabRuntime : TerraformResource
{
    public GoogleColabRuntime(string name) : base("google_colab_runtime", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("expiration_time");
        SetOutput("is_upgradable");
        SetOutput("notebook_runtime_type");
        SetOutput("state");
        SetOutput("auto_upgrade");
        SetOutput("description");
        SetOutput("desired_state");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("runtime_user");
    }

    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    public TerraformProperty<bool> AutoUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_upgrade");
        set => SetProperty("auto_upgrade", value);
    }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The user email of the NotebookRuntime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeUser is required")]
    public required TerraformProperty<string> RuntimeUser
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_user");
        set => SetProperty("runtime_user", value);
    }

    /// <summary>
    /// Block for notebook_runtime_template_ref.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookRuntimeTemplateRef block(s) allowed")]
    public List<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>? NotebookRuntimeTemplateRef
    {
        set => SetProperty("notebook_runtime_template_ref", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabRuntimeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

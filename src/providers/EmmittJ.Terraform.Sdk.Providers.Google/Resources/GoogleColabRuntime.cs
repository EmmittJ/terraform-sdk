using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notebook_runtime_template_ref in GoogleColabRuntime.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeNotebookRuntimeTemplateRefBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notebook_runtime_template_ref";

    /// <summary>
    /// The resource name of the NotebookRuntimeTemplate based on which a NotebookRuntime will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookRuntimeTemplate is required")]
    public required TerraformValue<string> NotebookRuntimeTemplate
    {
        get => new TerraformReference<string>(this, "notebook_runtime_template");
        set => SetArgument("notebook_runtime_template", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleColabRuntime.
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTimeoutsBlock : TerraformBlock
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
/// Represents a google_colab_runtime Terraform resource.
/// Manages a google_colab_runtime resource.
/// </summary>
public partial class GoogleColabRuntime(string name) : TerraformResource("google_colab_runtime", name)
{
    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    public TerraformValue<bool>? AutoUpgrade
    {
        get => new TerraformReference<bool>(this, "auto_upgrade");
        set => SetArgument("auto_upgrade", value);
    }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => new TerraformReference<string>(this, "desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The user email of the NotebookRuntime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeUser is required")]
    public required TerraformValue<string> RuntimeUser
    {
        get => new TerraformReference<string>(this, "runtime_user");
        set => SetArgument("runtime_user", value);
    }

    /// <summary>
    /// Output only. Timestamp when this NotebookRuntime will be expired.
    /// </summary>
    public TerraformValue<string> ExpirationTime
    {
        get => new TerraformReference<string>(this, "expiration_time");
    }

    /// <summary>
    /// Output only. Checks if the NotebookRuntime is upgradable.
    /// </summary>
    public TerraformValue<bool> IsUpgradable
    {
        get => new TerraformReference<bool>(this, "is_upgradable");
    }

    /// <summary>
    /// Output only. The type of the notebook runtime.
    /// </summary>
    public TerraformValue<string> NotebookRuntimeType
    {
        get => new TerraformReference<string>(this, "notebook_runtime_type");
    }

    /// <summary>
    /// Output only. The state of the runtime.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// NotebookRuntimeTemplateRef block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookRuntimeTemplateRef block(s) allowed")]
    public TerraformList<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>? NotebookRuntimeTemplateRef
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>>("notebook_runtime_template_ref");
        set => SetArgument("notebook_runtime_template_ref", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleColabRuntimeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleColabRuntimeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

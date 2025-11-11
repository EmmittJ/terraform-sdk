using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notebook_runtime_template_ref in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeNotebookRuntimeTemplateRefBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name of the NotebookRuntimeTemplate based on which a NotebookRuntime will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookRuntimeTemplate is required")]
    [TerraformProperty("notebook_runtime_template")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NotebookRuntimeTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleColabRuntimeTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_colab_runtime resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleColabRuntime : TerraformResource
{
    public GoogleColabRuntime(string name) : base("google_colab_runtime", name)
    {
    }

    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    [TerraformProperty("auto_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoUpgrade { get; set; }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Required. The display name of the Runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user email of the NotebookRuntime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeUser is required")]
    [TerraformProperty("runtime_user")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuntimeUser { get; set; }

    /// <summary>
    /// Block for notebook_runtime_template_ref.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookRuntimeTemplateRef block(s) allowed")]
    [TerraformProperty("notebook_runtime_template_ref")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>>? NotebookRuntimeTemplateRef { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleColabRuntimeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Timestamp when this NotebookRuntime will be expired.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpirationTime { get; }

    /// <summary>
    /// Output only. Checks if the NotebookRuntime is upgradable.
    /// </summary>
    [TerraformProperty("is_upgradable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsUpgradable { get; }

    /// <summary>
    /// Output only. The type of the notebook runtime.
    /// </summary>
    [TerraformProperty("notebook_runtime_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NotebookRuntimeType { get; }

    /// <summary>
    /// Output only. The state of the runtime.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}

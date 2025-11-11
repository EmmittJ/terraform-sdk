using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notebook_runtime_template_ref in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeNotebookRuntimeTemplateRefBlock
{
    /// <summary>
    /// The resource name of the NotebookRuntimeTemplate based on which a NotebookRuntime will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotebookRuntimeTemplate is required")]
    [TerraformPropertyName("notebook_runtime_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NotebookRuntimeTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_colab_runtime resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabRuntime : TerraformResource
{
    public GoogleColabRuntime(string name) : base("google_colab_runtime", name)
    {
    }

    /// <summary>
    /// Triggers an upgrade anytime the runtime is started if it is upgradable.
    /// </summary>
    [TerraformPropertyName("auto_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoUpgrade { get; set; }

    /// <summary>
    /// The description of the Runtime.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Desired state of the Colab Runtime. Set this field to &#39;RUNNING&#39; to start the runtime, and &#39;STOPPED&#39; to stop it.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Required. The display name of the Runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Runtime
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The user email of the NotebookRuntime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeUser is required")]
    [TerraformPropertyName("runtime_user")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuntimeUser { get; set; }

    /// <summary>
    /// Block for notebook_runtime_template_ref.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotebookRuntimeTemplateRef block(s) allowed")]
    [TerraformPropertyName("notebook_runtime_template_ref")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeNotebookRuntimeTemplateRefBlock>>? NotebookRuntimeTemplateRef { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleColabRuntimeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Timestamp when this NotebookRuntime will be expired.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationTime => new TerraformReference(this, "expiration_time");

    /// <summary>
    /// Output only. Checks if the NotebookRuntime is upgradable.
    /// </summary>
    [TerraformPropertyName("is_upgradable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsUpgradable => new TerraformReference(this, "is_upgradable");

    /// <summary>
    /// Output only. The type of the notebook runtime.
    /// </summary>
    [TerraformPropertyName("notebook_runtime_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotebookRuntimeType => new TerraformReference(this, "notebook_runtime_type");

    /// <summary>
    /// Output only. The state of the runtime.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}

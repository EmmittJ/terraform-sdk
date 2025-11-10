using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_job in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerInspectJobBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the template to run when this job is triggered.
    /// </summary>
    [TerraformPropertyName("inspect_template_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InspectTemplateName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionJobTriggerTimeoutsBlock : ITerraformBlock
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
/// Block type for triggers in .
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionJobTriggerTriggersBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a google_data_loss_prevention_job_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataLossPreventionJobTrigger : TerraformResource
{
    public GoogleDataLossPreventionJobTrigger(string name) : base("google_data_loss_prevention_job_trigger", name)
    {
    }

    /// <summary>
    /// A description of the job trigger.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// User set display name of the job trigger.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parent of the trigger, either in the format &#39;projects/{{project}}&#39;
    /// or &#39;projects/{{project}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Whether the trigger is currently active. Default value: &amp;quot;HEALTHY&amp;quot; Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;HEALTHY&amp;quot;, &amp;quot;CANCELLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformPropertyName("trigger_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TriggerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trigger_id");

    /// <summary>
    /// Block for inspect_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectJob block(s) allowed")]
    [TerraformPropertyName("inspect_job")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionJobTriggerInspectJobBlock>>? InspectJob { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataLossPreventionJobTriggerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for triggers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Triggers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Triggers block(s) required")]
    [TerraformPropertyName("triggers")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionJobTriggerTriggersBlock>>? Triggers { get; set; } = new();

    /// <summary>
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The timestamp of the last time this trigger executed.
    /// </summary>
    [TerraformPropertyName("last_run_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastRunTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_run_time");

    /// <summary>
    /// The resource name of the job trigger. Set by the server.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The last update timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}

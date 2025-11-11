using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_job in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionJobTriggerInspectJobBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the template to run when this job is triggered.
    /// </summary>
    [TerraformProperty("inspect_template_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InspectTemplateName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataLossPreventionJobTriggerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for triggers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionJobTriggerTriggersBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a google_data_loss_prevention_job_trigger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataLossPreventionJobTrigger : TerraformResource
{
    public GoogleDataLossPreventionJobTrigger(string name) : base("google_data_loss_prevention_job_trigger", name)
    {
    }

    /// <summary>
    /// A description of the job trigger.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User set display name of the job trigger.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent of the trigger, either in the format &#39;projects/{{project}}&#39;
    /// or &#39;projects/{{project}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Whether the trigger is currently active. Default value: &amp;quot;HEALTHY&amp;quot; Possible values: [&amp;quot;PAUSED&amp;quot;, &amp;quot;HEALTHY&amp;quot;, &amp;quot;CANCELLED&amp;quot;]
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+.
    /// The maximum length is 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformProperty("trigger_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TriggerId { get; set; }

    /// <summary>
    /// Block for inspect_job.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectJob block(s) allowed")]
    [TerraformProperty("inspect_job")]
    public partial TerraformList<TerraformBlock<GoogleDataLossPreventionJobTriggerInspectJobBlock>>? InspectJob { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataLossPreventionJobTriggerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for triggers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Triggers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Triggers block(s) required")]
    [TerraformProperty("triggers")]
    public partial TerraformList<TerraformBlock<GoogleDataLossPreventionJobTriggerTriggersBlock>>? Triggers { get; set; }

    /// <summary>
    /// The creation timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The timestamp of the last time this trigger executed.
    /// </summary>
    [TerraformProperty("last_run_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastRunTime { get; }

    /// <summary>
    /// The resource name of the job trigger. Set by the server.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The last update timestamp of an inspectTemplate. Set by the server.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}

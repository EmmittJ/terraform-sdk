using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleRuleDeploymentTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_chronicle_rule_deployment resource.
/// </summary>
public partial class GoogleChronicleRuleDeployment : TerraformResource
{
    public GoogleChronicleRuleDeployment(string name) : base("google_chronicle_rule_deployment", name)
    {
    }

    /// <summary>
    /// Whether detections resulting from this deployment should be considered
    /// alerts.
    /// </summary>
    [TerraformProperty("alerting")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Alerting { get; set; }

    /// <summary>
    /// The archive state of the rule deployment.
    /// Cannot be set to true unless enabled is set to false i.e.
    /// archiving requires a two-step process: first, disable the rule by
    /// setting &#39;enabled&#39; to false, then set &#39;archive&#39; to true.
    /// If set to true, alerting will automatically be set to false.
    /// If currently set to true, enabled, alerting, and run_frequency cannot be
    /// updated.
    /// </summary>
    [TerraformProperty("archived")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Archived { get; set; }

    /// <summary>
    /// Whether the rule is currently deployed continuously against incoming data.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [TerraformProperty("rule")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Rule { get; set; }

    /// <summary>
    /// The run frequency of the rule deployment.
    /// Possible values:
    /// LIVE
    /// HOURLY
    /// DAILY
    /// </summary>
    [TerraformProperty("run_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RunFrequency { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleChronicleRuleDeploymentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The timestamp when the rule deployment archive state was last set to true. If the rule deployment&#39;s current archive state is not set to true, the field will be empty.
    /// </summary>
    [TerraformProperty("archive_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArchiveTime { get; }

    /// <summary>
    /// Output only. The names of the associated/chained consumer rules. Rules are considered
    /// consumers of this rule if their rule text explicitly filters on this rule&#39;s ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    [TerraformProperty("consumer_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ConsumerRules { get; }

    /// <summary>
    /// The execution state of the rule deployment.
    /// Possible values:
    /// DEFAULT
    /// LIMITED
    /// PAUSED
    /// </summary>
    [TerraformProperty("execution_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExecutionState { get; }

    /// <summary>
    /// Output only. The timestamp when the rule deployment alert state was lastly changed. This is filled regardless of the current alert state.E.g. if the current alert status is false, this timestamp will be the timestamp when the alert status was changed to false.
    /// </summary>
    [TerraformProperty("last_alert_status_change_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastAlertStatusChangeTime { get; }

    /// <summary>
    /// The resource name of the rule deployment.
    /// Note that RuleDeployment is a child of the overall Rule, not any individual
    /// revision, so the resource ID segment for the Rule resource must not
    /// reference a specific revision.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The names of the associated/chained producer rules. Rules are considered
    /// producers for this rule if this rule explicitly filters on their ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    [TerraformProperty("producer_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ProducerRules { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleRuleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_chronicle_rule resource.
/// </summary>
public partial class GoogleChronicleRule : TerraformResource
{
    public GoogleChronicleRule(string name) : base("google_chronicle_rule", name)
    {
    }

    /// <summary>
    /// Policy to determine if the rule should be deleted forcefully.
    /// If deletion_policy = &amp;quot;FORCE&amp;quot;, any retrohunts and any detections associated with the rule
    /// will also be deleted. If deletion_policy = &amp;quot;DEFAULT&amp;quot;, the call will only succeed if the
    /// rule has no associated retrohunts, including completed retrohunts, and no
    /// associated detections. Regardless of this field&#39;s value, the rule
    /// deployment associated with this rule will also be deleted.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The etag for this rule.
    /// If this is provided on update, the request will succeed if and only if it
    /// matches the server-computed value, and will fail with an ABORTED error
    /// otherwise.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

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
    /// Rule Id is the ID of the Rule.
    /// </summary>
    [TerraformProperty("rule_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RuleId { get; set; }

    /// <summary>
    /// Resource name of the DataAccessScope bound to this rule.
    /// Populated in BASIC view and FULL view.
    /// If reference lists are used in the rule, validations will be performed
    /// against this scope to ensure that the reference lists are compatible with
    /// both the user&#39;s and the rule&#39;s scopes.
    /// The scope should be in the format:
    /// &amp;quot;projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{scope}&amp;quot;.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The YARA-L content of the rule.
    /// Populated in FULL view.
    /// </summary>
    [TerraformProperty("text")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Text { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleChronicleRuleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The run frequencies that are allowed for the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformProperty("allowed_run_frequencies")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AllowedRunFrequencies { get; }

    /// <summary>
    /// Output only. The author of the rule. Extracted from the meta section of text.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformProperty("author")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Author { get; }

    /// <summary>
    /// Output only. A list of a rule&#39;s corresponding compilation diagnostic messages
    /// such as compilation errors and compilation warnings.
    /// Populated in FULL view.
    /// </summary>
    [TerraformProperty("compilation_diagnostics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CompilationDiagnostics { get; }

    /// <summary>
    /// Output only. The current compilation state of the rule.
    /// Populated in FULL view.
    /// Possible values:
    /// COMPILATION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    [TerraformProperty("compilation_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CompilationState { get; }

    /// <summary>
    /// Output only. The timestamp of when the rule was created.
    /// Populated in FULL view.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. Resource names of the data tables used in this rule.
    /// </summary>
    [TerraformProperty("data_tables")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DataTables { get; }

    /// <summary>
    /// Output only. Display name of the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. Additional metadata specified in the meta section of text.
    /// Populated in FULL view.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Metadata { get; }

    /// <summary>
    /// Full resource name for the rule. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Indicate the rule can run in near real time live rule.
    /// If this is true, the rule uses the near real time live rule when the run
    /// frequency is set to LIVE.
    /// </summary>
    [TerraformProperty("near_real_time_live_rule_eligible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> NearRealTimeLiveRuleEligible { get; }

    /// <summary>
    /// Output only. Resource names of the reference lists used in this rule.
    /// Populated in FULL view.
    /// </summary>
    [TerraformProperty("reference_lists")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ReferenceLists { get; }

    /// <summary>
    /// Output only. The timestamp of when the rule revision was created.
    /// Populated in FULL, REVISION_METADATA_ONLY views.
    /// </summary>
    [TerraformProperty("revision_create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionCreateTime { get; }

    /// <summary>
    /// Output only. The revision ID of the rule.
    /// A new revision is created whenever the rule text is changed in any way.
    /// Format: v_{10 digits}_{9 digits}
    /// Populated in REVISION_METADATA_ONLY view and FULL view.
    /// </summary>
    [TerraformProperty("revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionId { get; }

    /// <summary>
    /// Severity represents the severity level of the rule.
    /// </summary>
    [TerraformProperty("severity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Severity { get; }

    /// <summary>
    /// Possible values:
    /// RULE_TYPE_UNSPECIFIED
    /// SINGLE_EVENT
    /// MULTI_EVENT
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}

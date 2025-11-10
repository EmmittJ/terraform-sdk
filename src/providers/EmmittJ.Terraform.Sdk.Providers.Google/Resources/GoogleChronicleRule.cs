using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a google_chronicle_rule resource.
/// </summary>
public class GoogleChronicleRule : TerraformResource
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
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The etag for this rule.
    /// If this is provided on update, the request will succeed if and only if it
    /// matches the server-computed value, and will fail with an ABORTED error
    /// otherwise.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Etag { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Rule Id is the ID of the Rule.
    /// </summary>
    [TerraformPropertyName("rule_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RuleId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rule_id");

    /// <summary>
    /// Resource name of the DataAccessScope bound to this rule.
    /// Populated in BASIC view and FULL view.
    /// If reference lists are used in the rule, validations will be performed
    /// against this scope to ensure that the reference lists are compatible with
    /// both the user&#39;s and the rule&#39;s scopes.
    /// The scope should be in the format:
    /// &amp;quot;projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{scope}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

    /// <summary>
    /// The YARA-L content of the rule.
    /// Populated in FULL view.
    /// </summary>
    [TerraformPropertyName("text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Text { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleChronicleRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The run frequencies that are allowed for the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformPropertyName("allowed_run_frequencies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AllowedRunFrequencies => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "allowed_run_frequencies");

    /// <summary>
    /// Output only. The author of the rule. Extracted from the meta section of text.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformPropertyName("author")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Author => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "author");

    /// <summary>
    /// Output only. A list of a rule&#39;s corresponding compilation diagnostic messages
    /// such as compilation errors and compilation warnings.
    /// Populated in FULL view.
    /// </summary>
    [TerraformPropertyName("compilation_diagnostics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CompilationDiagnostics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "compilation_diagnostics");

    /// <summary>
    /// Output only. The current compilation state of the rule.
    /// Populated in FULL view.
    /// Possible values:
    /// COMPILATION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    [TerraformPropertyName("compilation_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompilationState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compilation_state");

    /// <summary>
    /// Output only. The timestamp of when the rule was created.
    /// Populated in FULL view.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Output only. Resource names of the data tables used in this rule.
    /// </summary>
    [TerraformPropertyName("data_tables")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DataTables => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "data_tables");

    /// <summary>
    /// Output only. Display name of the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// Output only. Additional metadata specified in the meta section of text.
    /// Populated in FULL view.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// Full resource name for the rule. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Indicate the rule can run in near real time live rule.
    /// If this is true, the rule uses the near real time live rule when the run
    /// frequency is set to LIVE.
    /// </summary>
    [TerraformPropertyName("near_real_time_live_rule_eligible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> NearRealTimeLiveRuleEligible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "near_real_time_live_rule_eligible");

    /// <summary>
    /// Output only. Resource names of the reference lists used in this rule.
    /// Populated in FULL view.
    /// </summary>
    [TerraformPropertyName("reference_lists")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReferenceLists => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "reference_lists");

    /// <summary>
    /// Output only. The timestamp of when the rule revision was created.
    /// Populated in FULL, REVISION_METADATA_ONLY views.
    /// </summary>
    [TerraformPropertyName("revision_create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionCreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_create_time");

    /// <summary>
    /// Output only. The revision ID of the rule.
    /// A new revision is created whenever the rule text is changed in any way.
    /// Format: v_{10 digits}_{9 digits}
    /// Populated in REVISION_METADATA_ONLY view and FULL view.
    /// </summary>
    [TerraformPropertyName("revision_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_id");

    /// <summary>
    /// Severity represents the severity level of the rule.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Severity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "severity");

    /// <summary>
    /// Possible values:
    /// RULE_TYPE_UNSPECIFIED
    /// SINGLE_EVENT
    /// MULTI_EVENT
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}

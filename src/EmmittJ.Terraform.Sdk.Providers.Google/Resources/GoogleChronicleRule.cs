using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRuleTimeoutsBlock : TerraformBlock
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
/// Manages a google_chronicle_rule resource.
/// </summary>
public class GoogleChronicleRule : TerraformResource
{
    public GoogleChronicleRule(string name) : base("google_chronicle_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allowed_run_frequencies");
        this.DeclareOutput("author");
        this.DeclareOutput("compilation_diagnostics");
        this.DeclareOutput("compilation_state");
        this.DeclareOutput("create_time");
        this.DeclareOutput("data_tables");
        this.DeclareOutput("display_name");
        this.DeclareOutput("metadata");
        this.DeclareOutput("name");
        this.DeclareOutput("near_real_time_live_rule_eligible");
        this.DeclareOutput("reference_lists");
        this.DeclareOutput("revision_create_time");
        this.DeclareOutput("revision_id");
        this.DeclareOutput("severity");
        this.DeclareOutput("type");
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
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The etag for this rule.
    /// If this is provided on update, the request will succeed if and only if it
    /// matches the server-computed value, and will fail with an ABORTED error
    /// otherwise.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Rule Id is the ID of the Rule.
    /// </summary>
    public TerraformProperty<string>? RuleId
    {
        get => GetProperty<TerraformProperty<string>>("rule_id");
        set => this.WithProperty("rule_id", value);
    }

    /// <summary>
    /// Resource name of the DataAccessScope bound to this rule.
    /// Populated in BASIC view and FULL view.
    /// If reference lists are used in the rule, validations will be performed
    /// against this scope to ensure that the reference lists are compatible with
    /// both the user&#39;s and the rule&#39;s scopes.
    /// The scope should be in the format:
    /// &amp;quot;projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{scope}&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The YARA-L content of the rule.
    /// Populated in FULL view.
    /// </summary>
    public TerraformProperty<string>? Text
    {
        get => GetProperty<TerraformProperty<string>>("text");
        set => this.WithProperty("text", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleRuleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleChronicleRuleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The run frequencies that are allowed for the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformExpression AllowedRunFrequencies => this["allowed_run_frequencies"];

    /// <summary>
    /// Output only. The author of the rule. Extracted from the meta section of text.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformExpression Author => this["author"];

    /// <summary>
    /// Output only. A list of a rule&#39;s corresponding compilation diagnostic messages
    /// such as compilation errors and compilation warnings.
    /// Populated in FULL view.
    /// </summary>
    public TerraformExpression CompilationDiagnostics => this["compilation_diagnostics"];

    /// <summary>
    /// Output only. The current compilation state of the rule.
    /// Populated in FULL view.
    /// Possible values:
    /// COMPILATION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    public TerraformExpression CompilationState => this["compilation_state"];

    /// <summary>
    /// Output only. The timestamp of when the rule was created.
    /// Populated in FULL view.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Resource names of the data tables used in this rule.
    /// </summary>
    public TerraformExpression DataTables => this["data_tables"];

    /// <summary>
    /// Output only. Display name of the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// Output only. Additional metadata specified in the meta section of text.
    /// Populated in FULL view.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// Full resource name for the rule. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Indicate the rule can run in near real time live rule.
    /// If this is true, the rule uses the near real time live rule when the run
    /// frequency is set to LIVE.
    /// </summary>
    public TerraformExpression NearRealTimeLiveRuleEligible => this["near_real_time_live_rule_eligible"];

    /// <summary>
    /// Output only. Resource names of the reference lists used in this rule.
    /// Populated in FULL view.
    /// </summary>
    public TerraformExpression ReferenceLists => this["reference_lists"];

    /// <summary>
    /// Output only. The timestamp of when the rule revision was created.
    /// Populated in FULL, REVISION_METADATA_ONLY views.
    /// </summary>
    public TerraformExpression RevisionCreateTime => this["revision_create_time"];

    /// <summary>
    /// Output only. The revision ID of the rule.
    /// A new revision is created whenever the rule text is changed in any way.
    /// Format: v_{10 digits}_{9 digits}
    /// Populated in REVISION_METADATA_ONLY view and FULL view.
    /// </summary>
    public TerraformExpression RevisionId => this["revision_id"];

    /// <summary>
    /// Severity represents the severity level of the rule.
    /// </summary>
    public TerraformExpression Severity => this["severity"];

    /// <summary>
    /// Possible values:
    /// RULE_TYPE_UNSPECIFIED
    /// SINGLE_EVENT
    /// MULTI_EVENT
    /// </summary>
    public TerraformExpression Type => this["type"];

}

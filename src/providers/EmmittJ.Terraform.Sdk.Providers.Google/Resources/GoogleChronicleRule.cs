using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleChronicleRule.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_chronicle_rule Terraform resource.
/// Manages a google_chronicle_rule resource.
/// </summary>
public partial class GoogleChronicleRule(string name) : TerraformResource("google_chronicle_rule", name)
{
    /// <summary>
    /// Policy to determine if the rule should be deleted forcefully.
    /// If deletion_policy = &amp;quot;FORCE&amp;quot;, any retrohunts and any detections associated with the rule
    /// will also be deleted. If deletion_policy = &amp;quot;DEFAULT&amp;quot;, the call will only succeed if the
    /// rule has no associated retrohunts, including completed retrohunts, and no
    /// associated detections. Regardless of this field&#39;s value, the rule
    /// deployment associated with this rule will also be deleted.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The etag for this rule.
    /// If this is provided on update, the request will succeed if and only if it
    /// matches the server-computed value, and will fail with an ABORTED error
    /// otherwise.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// Rule Id is the ID of the Rule.
    /// </summary>
    public TerraformValue<string> RuleId
    {
        get => new TerraformReference<string>(this, "rule_id");
        set => SetArgument("rule_id", value);
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
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The YARA-L content of the rule.
    /// Populated in FULL view.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => new TerraformReference<string>(this, "text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// Output only. The run frequencies that are allowed for the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformList<string> AllowedRunFrequencies
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_run_frequencies").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The author of the rule. Extracted from the meta section of text.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformValue<string> Author
    {
        get => new TerraformReference<string>(this, "author");
    }

    /// <summary>
    /// Output only. A list of a rule&#39;s corresponding compilation diagnostic messages
    /// such as compilation errors and compilation warnings.
    /// Populated in FULL view.
    /// </summary>
    public TerraformList<TerraformMap<object>> CompilationDiagnostics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "compilation_diagnostics").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The current compilation state of the rule.
    /// Populated in FULL view.
    /// Possible values:
    /// COMPILATION_STATE_UNSPECIFIED
    /// SUCCEEDED
    /// FAILED
    /// </summary>
    public TerraformValue<string> CompilationState
    {
        get => new TerraformReference<string>(this, "compilation_state");
    }

    /// <summary>
    /// Output only. The timestamp of when the rule was created.
    /// Populated in FULL view.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Resource names of the data tables used in this rule.
    /// </summary>
    public TerraformList<string> DataTables
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "data_tables").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Display name of the rule.
    /// Populated in BASIC view and FULL view.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// Output only. Additional metadata specified in the meta section of text.
    /// Populated in FULL view.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// Full resource name for the rule. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Indicate the rule can run in near real time live rule.
    /// If this is true, the rule uses the near real time live rule when the run
    /// frequency is set to LIVE.
    /// </summary>
    public TerraformValue<bool> NearRealTimeLiveRuleEligible
    {
        get => new TerraformReference<bool>(this, "near_real_time_live_rule_eligible");
    }

    /// <summary>
    /// Output only. Resource names of the reference lists used in this rule.
    /// Populated in FULL view.
    /// </summary>
    public TerraformList<string> ReferenceLists
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "reference_lists").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. The timestamp of when the rule revision was created.
    /// Populated in FULL, REVISION_METADATA_ONLY views.
    /// </summary>
    public TerraformValue<string> RevisionCreateTime
    {
        get => new TerraformReference<string>(this, "revision_create_time");
    }

    /// <summary>
    /// Output only. The revision ID of the rule.
    /// A new revision is created whenever the rule text is changed in any way.
    /// Format: v_{10 digits}_{9 digits}
    /// Populated in REVISION_METADATA_ONLY view and FULL view.
    /// </summary>
    public TerraformValue<string> RevisionId
    {
        get => new TerraformReference<string>(this, "revision_id");
    }

    /// <summary>
    /// Severity represents the severity level of the rule.
    /// </summary>
    public TerraformList<TerraformMap<object>> Severity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "severity").ResolveNodes(ctx));
    }

    /// <summary>
    /// Possible values:
    /// RULE_TYPE_UNSPECIFIED
    /// SINGLE_EVENT
    /// MULTI_EVENT
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

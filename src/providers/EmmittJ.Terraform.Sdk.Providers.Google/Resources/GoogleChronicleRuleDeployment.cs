using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleChronicleRuleDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRuleDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a google_chronicle_rule_deployment Terraform resource.
/// Manages a google_chronicle_rule_deployment resource.
/// </summary>
public partial class GoogleChronicleRuleDeployment(string name) : TerraformResource("google_chronicle_rule_deployment", name)
{
    /// <summary>
    /// Whether detections resulting from this deployment should be considered
    /// alerts.
    /// </summary>
    public TerraformValue<bool>? Alerting
    {
        get => new TerraformReference<bool>(this, "alerting");
        set => SetArgument("alerting", value);
    }

    /// <summary>
    /// The archive state of the rule deployment.
    /// Cannot be set to true unless enabled is set to false i.e.
    /// archiving requires a two-step process: first, disable the rule by
    /// setting &#39;enabled&#39; to false, then set &#39;archive&#39; to true.
    /// If set to true, alerting will automatically be set to false.
    /// If currently set to true, enabled, alerting, and run_frequency cannot be
    /// updated.
    /// </summary>
    public TerraformValue<bool>? Archived
    {
        get => new TerraformReference<bool>(this, "archived");
        set => SetArgument("archived", value);
    }

    /// <summary>
    /// Whether the rule is currently deployed continuously against incoming data.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformValue<string> Rule
    {
        get => new TerraformReference<string>(this, "rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// The run frequency of the rule deployment.
    /// Possible values:
    /// LIVE
    /// HOURLY
    /// DAILY
    /// </summary>
    public TerraformValue<string>? RunFrequency
    {
        get => new TerraformReference<string>(this, "run_frequency");
        set => SetArgument("run_frequency", value);
    }

    /// <summary>
    /// Output only. The timestamp when the rule deployment archive state was last set to true. If the rule deployment&#39;s current archive state is not set to true, the field will be empty.
    /// </summary>
    public TerraformValue<string> ArchiveTime
    {
        get => new TerraformReference<string>(this, "archive_time");
    }

    /// <summary>
    /// Output only. The names of the associated/chained consumer rules. Rules are considered
    /// consumers of this rule if their rule text explicitly filters on this rule&#39;s ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformList<string> ConsumerRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "consumer_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// The execution state of the rule deployment.
    /// Possible values:
    /// DEFAULT
    /// LIMITED
    /// PAUSED
    /// </summary>
    public TerraformValue<string> ExecutionState
    {
        get => new TerraformReference<string>(this, "execution_state");
    }

    /// <summary>
    /// Output only. The timestamp when the rule deployment alert state was lastly changed. This is filled regardless of the current alert state.E.g. if the current alert status is false, this timestamp will be the timestamp when the alert status was changed to false.
    /// </summary>
    public TerraformValue<string> LastAlertStatusChangeTime
    {
        get => new TerraformReference<string>(this, "last_alert_status_change_time");
    }

    /// <summary>
    /// The resource name of the rule deployment.
    /// Note that RuleDeployment is a child of the overall Rule, not any individual
    /// revision, so the resource ID segment for the Rule resource must not
    /// reference a specific revision.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The names of the associated/chained producer rules. Rules are considered
    /// producers for this rule if this rule explicitly filters on their ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformList<string> ProducerRules
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "producer_rules").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleRuleDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleRuleDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleRuleDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_chronicle_rule_deployment resource.
/// </summary>
public class GoogleChronicleRuleDeployment : TerraformResource
{
    public GoogleChronicleRuleDeployment(string name) : base("google_chronicle_rule_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("archive_time");
        SetOutput("consumer_rules");
        SetOutput("execution_state");
        SetOutput("last_alert_status_change_time");
        SetOutput("name");
        SetOutput("producer_rules");
        SetOutput("alerting");
        SetOutput("archived");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("location");
        SetOutput("project");
        SetOutput("rule");
        SetOutput("run_frequency");
    }

    /// <summary>
    /// Whether detections resulting from this deployment should be considered
    /// alerts.
    /// </summary>
    public TerraformProperty<bool> Alerting
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("alerting");
        set => SetProperty("alerting", value);
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
    public TerraformProperty<bool> Archived
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("archived");
        set => SetProperty("archived", value);
    }

    /// <summary>
    /// Whether the rule is currently deployed continuously against incoming data.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The Rule ID of the rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    public required TerraformProperty<string> Rule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule");
        set => SetProperty("rule", value);
    }

    /// <summary>
    /// The run frequency of the rule deployment.
    /// Possible values:
    /// LIVE
    /// HOURLY
    /// DAILY
    /// </summary>
    public TerraformProperty<string> RunFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("run_frequency");
        set => SetProperty("run_frequency", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleRuleDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The timestamp when the rule deployment archive state was last set to true. If the rule deployment&#39;s current archive state is not set to true, the field will be empty.
    /// </summary>
    public TerraformExpression ArchiveTime => this["archive_time"];

    /// <summary>
    /// Output only. The names of the associated/chained consumer rules. Rules are considered
    /// consumers of this rule if their rule text explicitly filters on this rule&#39;s ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformExpression ConsumerRules => this["consumer_rules"];

    /// <summary>
    /// The execution state of the rule deployment.
    /// Possible values:
    /// DEFAULT
    /// LIMITED
    /// PAUSED
    /// </summary>
    public TerraformExpression ExecutionState => this["execution_state"];

    /// <summary>
    /// Output only. The timestamp when the rule deployment alert state was lastly changed. This is filled regardless of the current alert state.E.g. if the current alert status is false, this timestamp will be the timestamp when the alert status was changed to false.
    /// </summary>
    public TerraformExpression LastAlertStatusChangeTime => this["last_alert_status_change_time"];

    /// <summary>
    /// The resource name of the rule deployment.
    /// Note that RuleDeployment is a child of the overall Rule, not any individual
    /// revision, so the resource ID segment for the Rule resource must not
    /// reference a specific revision.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The names of the associated/chained producer rules. Rules are considered
    /// producers for this rule if this rule explicitly filters on their ruleid.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/rules/{rule}
    /// </summary>
    public TerraformExpression ProducerRules => this["producer_rules"];

}

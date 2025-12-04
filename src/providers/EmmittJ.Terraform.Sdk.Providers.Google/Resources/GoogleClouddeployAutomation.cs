using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in GoogleClouddeployAutomation.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// AdvanceRolloutRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvanceRolloutRule block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockAdvanceRolloutRuleBlock>? AdvanceRolloutRule
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockAdvanceRolloutRuleBlock>>("advance_rollout_rule");
        set => SetArgument("advance_rollout_rule", value);
    }

    /// <summary>
    /// PromoteReleaseRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PromoteReleaseRule block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockPromoteReleaseRuleBlock>? PromoteReleaseRule
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockPromoteReleaseRuleBlock>>("promote_release_rule");
        set => SetArgument("promote_release_rule", value);
    }

    /// <summary>
    /// RepairRolloutRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RepairRolloutRule block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlock>? RepairRolloutRule
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlock>>("repair_rollout_rule");
        set => SetArgument("repair_rollout_rule", value);
    }

    /// <summary>
    /// TimedPromoteReleaseRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimedPromoteReleaseRule block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockTimedPromoteReleaseRuleBlock>? TimedPromoteReleaseRule
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockTimedPromoteReleaseRuleBlock>>("timed_promote_release_rule");
        set => SetArgument("timed_promote_release_rule", value);
    }

}

/// <summary>
/// Block type for advance_rollout_rule in GoogleClouddeployAutomationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockAdvanceRolloutRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advance_rollout_rule";

    /// <summary>
    /// Required. ID of the rule. This id must be unique in the &#39;Automation&#39; resource to which this rule belongs. The format is &#39;a-z{0,62}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Proceeds only after phase name matched any one in the list. This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters. In other words, it must match the following regex: &#39;^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$&#39;.
    /// </summary>
    public TerraformList<string>? SourcePhases
    {
        get => GetArgument<TerraformList<string>>("source_phases");
        set => SetArgument("source_phases", value);
    }

    /// <summary>
    /// Optional. How long to wait after a rollout is finished.
    /// </summary>
    public TerraformValue<string>? Wait
    {
        get => GetArgument<TerraformValue<string>>("wait");
        set => SetArgument("wait", value);
    }

}

/// <summary>
/// Block type for promote_release_rule in GoogleClouddeployAutomationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockPromoteReleaseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "promote_release_rule";

    /// <summary>
    /// Optional. The starting phase of the rollout created by this operation. Default to the first phase.
    /// </summary>
    public TerraformValue<string>? DestinationPhase
    {
        get => GetArgument<TerraformValue<string>>("destination_phase");
        set => SetArgument("destination_phase", value);
    }

    /// <summary>
    /// Optional. The ID of the stage in the pipeline to which this &#39;Release&#39; is deploying. If unspecified, default it to the next stage in the promotion flow. The value of this field could be one of the following: * The last segment of a target name. It only needs the ID to determine if the target is one of the stages in the promotion sequence defined in the pipeline. * &amp;quot;@next&amp;quot;, the next target in the promotion sequence.
    /// </summary>
    public TerraformValue<string>? DestinationTargetId
    {
        get => GetArgument<TerraformValue<string>>("destination_target_id");
        set => SetArgument("destination_target_id", value);
    }

    /// <summary>
    /// Required. ID of the rule. This id must be unique in the &#39;Automation&#39; resource to which this rule belongs. The format is &#39;a-z{0,62}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. How long the release need to be paused until being promoted to the next target.
    /// </summary>
    public TerraformValue<string>? Wait
    {
        get => GetArgument<TerraformValue<string>>("wait");
        set => SetArgument("wait", value);
    }

}

/// <summary>
/// Block type for repair_rollout_rule in GoogleClouddeployAutomationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repair_rollout_rule";

    /// <summary>
    /// Required. ID of the rule. This id must be unique in the &#39;Automation&#39; resource to which this rule belongs. The format is &#39;a-z{0,62}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Jobs to repair. Proceeds only after job name matched any one in the list, or for all jobs if unspecified or empty. The phase that includes the job must match the phase ID specified in sourcePhase. This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters. In other words, it must match the following regex: ^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$.
    /// </summary>
    public TerraformList<string>? Jobs
    {
        get => GetArgument<TerraformList<string>>("jobs");
        set => SetArgument("jobs", value);
    }

    /// <summary>
    /// Optional. Phases within which jobs are subject to automatic repair actions on failure. Proceeds only after phase name matched any one in the list, or for all phases if unspecified. This value must consist of lower-case letters, numbers, and hyphens, start with a letter and end with a letter or a number, and have a max length of 63 characters. In other words, it must match the following regex: ^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$.
    /// </summary>
    public TerraformList<string>? Phases
    {
        get => GetArgument<TerraformList<string>>("phases");
        set => SetArgument("phases", value);
    }

    /// <summary>
    /// RepairPhases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlock>? RepairPhases
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlock>>("repair_phases");
        set => SetArgument("repair_phases", value);
    }

}

/// <summary>
/// Block type for repair_phases in GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repair_phases";

    /// <summary>
    /// Retry block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retry block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRetryBlock>? Retry
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRetryBlock>>("retry");
        set => SetArgument("retry", value);
    }

    /// <summary>
    /// Rollback block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollback block(s) allowed")]
    public TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRollbackBlock>? Rollback
    {
        get => GetArgument<TerraformList<GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRollbackBlock>>("rollback");
        set => SetArgument("rollback", value);
    }

}

/// <summary>
/// Block type for retry in GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRetryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry";

    /// <summary>
    /// Required. Total number of retries. Retry is skipped if set to 0; The minimum value is 1, and the maximum value is 10.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attempts is required")]
    public required TerraformValue<string> Attempts
    {
        get => GetArgument<TerraformValue<string>>("attempts");
        set => SetArgument("attempts", value);
    }

    /// <summary>
    /// Optional. The pattern of how wait time will be increased. Default is linear. Backoff mode will be ignored if wait is 0. Possible values: [&amp;quot;BACKOFF_MODE_UNSPECIFIED&amp;quot;, &amp;quot;BACKOFF_MODE_LINEAR&amp;quot;, &amp;quot;BACKOFF_MODE_EXPONENTIAL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? BackoffMode
    {
        get => GetArgument<TerraformValue<string>>("backoff_mode");
        set => SetArgument("backoff_mode", value);
    }

    /// <summary>
    /// Optional. How long to wait for the first retry. Default is 0, and the maximum value is 14d. A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &#39;3.5s&#39;.
    /// </summary>
    public TerraformValue<string>? Wait
    {
        get => GetArgument<TerraformValue<string>>("wait");
        set => SetArgument("wait", value);
    }

}

/// <summary>
/// Block type for rollback in GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockRepairRolloutRuleBlockRepairPhasesBlockRollbackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollback";

    /// <summary>
    /// Optional. The starting phase ID for the Rollout. If unspecified, the Rollout will start in the stable phase.
    /// </summary>
    public TerraformValue<string>? DestinationPhase
    {
        get => GetArgument<TerraformValue<string>>("destination_phase");
        set => SetArgument("destination_phase", value);
    }

    /// <summary>
    /// Optional. If pending rollout exists on the target, the rollback operation will be aborted.
    /// </summary>
    public TerraformValue<bool>? DisableRollbackIfRolloutPending
    {
        get => GetArgument<TerraformValue<bool>>("disable_rollback_if_rollout_pending");
        set => SetArgument("disable_rollback_if_rollout_pending", value);
    }

}

/// <summary>
/// Block type for timed_promote_release_rule in GoogleClouddeployAutomationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationRulesBlockTimedPromoteReleaseRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timed_promote_release_rule";

    /// <summary>
    /// Optional. The starting phase of the rollout created by this rule. Default to the first phase.
    /// </summary>
    public TerraformValue<string>? DestinationPhase
    {
        get => GetArgument<TerraformValue<string>>("destination_phase");
        set => SetArgument("destination_phase", value);
    }

    /// <summary>
    /// Optional. The ID of the stage in the pipeline to which this Release is deploying. If unspecified, default it to the next stage in the promotion flow. The value of this field could be one of the following:
    ///   - The last segment of a target name
    ///   - &amp;quot;@next&amp;quot;, the next target in the promotion sequence&amp;quot;
    /// </summary>
    public TerraformValue<string>? DestinationTargetId
    {
        get => GetArgument<TerraformValue<string>>("destination_target_id");
        set => SetArgument("destination_target_id", value);
    }

    /// <summary>
    /// Required. ID of the rule. This id must be unique in the &#39;Automation&#39; resource to which this rule belongs. The format is &#39;a-z{0,62}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. Schedule in crontab format. e.g. &#39;0 9 * * 1&#39; for every Monday at 9am.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Required. The time zone in IANA format IANA Time Zone Database (e.g. America/New_York).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for selector in GoogleClouddeployAutomation.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selector";

    /// <summary>
    /// Targets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Targets block(s) required")]
    public required TerraformList<GoogleClouddeployAutomationSelectorBlockTargetsBlock> Targets
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployAutomationSelectorBlockTargetsBlock>>("targets");
        set => SetArgument("targets", value);
    }

}

/// <summary>
/// Block type for targets in GoogleClouddeployAutomationSelectorBlock.
/// Nesting mode: list
/// </summary>
public class GoogleClouddeployAutomationSelectorBlockTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "targets";

    /// <summary>
    /// ID of the &#39;Target&#39;. The value of this field could be one of the following: * The last segment of a target name. It only needs the ID to determine which target is being referred to * &amp;quot;*&amp;quot;, all targets in a location.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Target labels.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleClouddeployAutomation.
/// Nesting mode: single
/// </summary>
public class GoogleClouddeployAutomationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_clouddeploy_automation Terraform resource.
/// Manages a google_clouddeploy_automation resource.
/// </summary>
public partial class GoogleClouddeployAutomation(string name) : TerraformResource("google_clouddeploy_automation", name)
{
    /// <summary>
    /// Optional. User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. Annotations must meet the following constraints: * Annotations are key/value pairs. * Valid annotation keys have two segments: an optional prefix and name, separated by a slash (&#39;/&#39;). * The name segment is required and must be 63 characters or less, beginning and ending with an alphanumeric character (&#39;[a-z0-9A-Z]&#39;) with dashes (&#39;-&#39;), underscores (&#39;_&#39;), dots (&#39;.&#39;), and alphanumerics between. * The prefix is optional. If specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots(&#39;.&#39;), not longer than 253 characters in total, followed by a slash (&#39;/&#39;). See https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations/#syntax-and-character-set for more details.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The delivery_pipeline for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryPipeline is required")]
    public required TerraformValue<string> DeliveryPipeline
    {
        get => GetArgument<TerraformValue<string>>("delivery_pipeline");
        set => SetArgument("delivery_pipeline", value);
    }

    /// <summary>
    /// Optional. Description of the &#39;Automation&#39;. Max length is 255 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 63 characters.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the &#39;Automation&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Required. Email address of the user-managed IAM service account that creates Cloud Deploy release and rollout resources.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Optional. When Suspended, automation is deactivated from execution.
    /// </summary>
    public TerraformValue<bool>? Suspended
    {
        get => GetArgument<TerraformValue<bool>>("suspended");
        set => SetArgument("suspended", value);
    }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Optional. The weak etag of the &#39;Automation&#39; resource. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Output only. Unique identifier of the &#39;Automation&#39;.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleClouddeployAutomationRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployAutomationRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Selector block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Selector block(s) allowed")]
    public required TerraformList<GoogleClouddeployAutomationSelectorBlock> Selector
    {
        get => GetRequiredArgument<TerraformList<GoogleClouddeployAutomationSelectorBlock>>("selector");
        set => SetArgument("selector", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleClouddeployAutomationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleClouddeployAutomationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

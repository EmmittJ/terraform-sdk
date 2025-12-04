using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instruction in GoogleDialogflowCxPlaybook.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookInstructionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instruction";

    /// <summary>
    /// General guidelines for the playbook. These are unstructured instructions that are not directly part of the goal, e.g. &amp;quot;Always be polite&amp;quot;. It&#39;s valid for this text to be long and used instead of steps altogether.
    /// </summary>
    public TerraformValue<string>? Guidelines
    {
        get => GetArgument<TerraformValue<string>>("guidelines");
        set => SetArgument("guidelines", value);
    }

    /// <summary>
    /// Steps block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxPlaybookInstructionBlockStepsBlock>? Steps
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPlaybookInstructionBlockStepsBlock>>("steps");
        set => SetArgument("steps", value);
    }

}

/// <summary>
/// Block type for steps in GoogleDialogflowCxPlaybookInstructionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookInstructionBlockStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "steps";

    /// <summary>
    /// Sub-processing needed to execute the current step.
    /// 
    /// This field uses JSON data as a string. The value provided must be a valid JSON representation documented in [Step](https://cloud.google.com/dialogflow/cx/docs/reference/rest/v3/projects.locations.agents.playbooks#step).
    /// </summary>
    public TerraformValue<string>? Steps
    {
        get => GetArgument<TerraformValue<string>>("steps");
        set => SetArgument("steps", value);
    }

    /// <summary>
    /// Step instruction in text format.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}


/// <summary>
/// Block type for llm_model_settings in GoogleDialogflowCxPlaybook.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "llm_model_settings";

    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformValue<string>? Model
    {
        get => GetArgument<TerraformValue<string>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformValue<string>? PromptText
    {
        get => GetArgument<TerraformValue<string>>("prompt_text");
        set => SetArgument("prompt_text", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxPlaybook.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPlaybookTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_cx_playbook Terraform resource.
/// Manages a google_dialogflow_cx_playbook resource.
/// </summary>
public partial class GoogleDialogflowCxPlaybook(string name) : TerraformResource("google_dialogflow_cx_playbook", name)
{
    /// <summary>
    /// The human-readable name of the playbook, unique within an agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// High level description of the goal the playbook intend to accomplish. A goal should be concise since it&#39;s visible to other playbooks that may reference this playbook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    public required TerraformValue<string> Goal
    {
        get => GetRequiredArgument<TerraformValue<string>>("goal");
        set => SetArgument("goal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The agent to create a Playbook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Type of the playbook. Possible values: [&amp;quot;PLAYBOOK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;TASK&amp;quot;, &amp;quot;ROUTINE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PlaybookType
    {
        get => GetArgument<TerraformValue<string>>("playbook_type");
        set => SetArgument("playbook_type", value);
    }

    /// <summary>
    /// The resource name of tools referenced by the current playbook in the instructions. If not provided explicitly, they are will be implied using the tool being referenced in goal and steps.
    /// </summary>
    public TerraformList<string>? ReferencedTools
    {
        get => GetArgument<TerraformList<string>>("referenced_tools");
        set => SetArgument("referenced_tools", value);
    }

    /// <summary>
    /// The timestamp of initial playbook creation.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The unique identifier of the Playbook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/playbooks/&amp;lt;Playbook ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The resource name of flows referenced by the current playbook in the instructions.
    /// </summary>
    public TerraformList<string> ReferencedFlows
        => AsReference("referenced_flows");

    /// <summary>
    /// The resource name of other playbooks referenced by the current playbook in the instructions.
    /// </summary>
    public TerraformList<string> ReferencedPlaybooks
        => AsReference("referenced_playbooks");

    /// <summary>
    /// Estimated number of tokes current playbook takes when sent to the LLM.
    /// </summary>
    public TerraformValue<string> TokenCount
        => AsReference("token_count");

    /// <summary>
    /// Last time the playbook version was updated.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Instruction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instruction block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPlaybookInstructionBlock>? Instruction
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPlaybookInstructionBlock>>("instruction");
        set => SetArgument("instruction", value);
    }

    /// <summary>
    /// LlmModelSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public TerraformList<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>>("llm_model_settings");
        set => SetArgument("llm_model_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxPlaybookTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxPlaybookTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

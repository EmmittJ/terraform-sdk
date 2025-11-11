using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instruction in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPlaybookInstructionBlock : TerraformBlockBase
{
    /// <summary>
    /// General guidelines for the playbook. These are unstructured instructions that are not directly part of the goal, e.g. &amp;quot;Always be polite&amp;quot;. It&#39;s valid for this text to be long and used instead of steps altogether.
    /// </summary>
    [TerraformProperty("guidelines")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Guidelines { get; set; }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDialogflowCxPlaybookLlmModelSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformProperty("model")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformProperty("prompt_text")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PromptText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDialogflowCxPlaybookTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dialogflow_cx_playbook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDialogflowCxPlaybook : TerraformResource
{
    public GoogleDialogflowCxPlaybook(string name) : base("google_dialogflow_cx_playbook", name)
    {
    }

    /// <summary>
    /// The human-readable name of the playbook, unique within an agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// High level description of the goal the playbook intend to accomplish. A goal should be concise since it&#39;s visible to other playbooks that may reference this playbook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    [TerraformProperty("goal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Goal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The agent to create a Playbook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// Type of the playbook. Possible values: [&amp;quot;PLAYBOOK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;TASK&amp;quot;, &amp;quot;ROUTINE&amp;quot;]
    /// </summary>
    [TerraformProperty("playbook_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PlaybookType { get; set; }

    /// <summary>
    /// The resource name of tools referenced by the current playbook in the instructions. If not provided explicitly, they are will be implied using the tool being referenced in goal and steps.
    /// </summary>
    [TerraformProperty("referenced_tools")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ReferencedTools { get; set; }

    /// <summary>
    /// Block for instruction.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instruction block(s) allowed")]
    [TerraformProperty("instruction")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPlaybookInstructionBlock>>? Instruction { get; set; }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformProperty("llm_model_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>>? LlmModelSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDialogflowCxPlaybookTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The timestamp of initial playbook creation.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The unique identifier of the Playbook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/playbooks/&amp;lt;Playbook ID&amp;gt;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The resource name of flows referenced by the current playbook in the instructions.
    /// </summary>
    [TerraformProperty("referenced_flows")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReferencedFlows { get; }

    /// <summary>
    /// The resource name of other playbooks referenced by the current playbook in the instructions.
    /// </summary>
    [TerraformProperty("referenced_playbooks")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReferencedPlaybooks { get; }

    /// <summary>
    /// Estimated number of tokes current playbook takes when sent to the LLM.
    /// </summary>
    [TerraformProperty("token_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TokenCount { get; }

    /// <summary>
    /// Last time the playbook version was updated.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}

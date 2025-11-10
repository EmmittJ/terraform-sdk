using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instruction in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookInstructionBlock : ITerraformBlock
{
    /// <summary>
    /// General guidelines for the playbook. These are unstructured instructions that are not directly part of the goal, e.g. &amp;quot;Always be polite&amp;quot;. It&#39;s valid for this text to be long and used instead of steps altogether.
    /// </summary>
    [TerraformPropertyName("guidelines")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Guidelines { get; set; }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookLlmModelSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    [TerraformPropertyName("model")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Model { get; set; }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    [TerraformPropertyName("prompt_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PromptText { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPlaybookTimeoutsBlock : ITerraformBlock
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
/// Manages a google_dialogflow_cx_playbook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxPlaybook : TerraformResource
{
    public GoogleDialogflowCxPlaybook(string name) : base("google_dialogflow_cx_playbook", name)
    {
    }

    /// <summary>
    /// The human-readable name of the playbook, unique within an agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// High level description of the goal the playbook intend to accomplish. A goal should be concise since it&#39;s visible to other playbooks that may reference this playbook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    [TerraformPropertyName("goal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Goal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The agent to create a Playbook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Parent { get; set; }

    /// <summary>
    /// Type of the playbook. Possible values: [&amp;quot;PLAYBOOK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;TASK&amp;quot;, &amp;quot;ROUTINE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("playbook_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlaybookType { get; set; }

    /// <summary>
    /// The resource name of tools referenced by the current playbook in the instructions. If not provided explicitly, they are will be implied using the tool being referenced in goal and steps.
    /// </summary>
    [TerraformPropertyName("referenced_tools")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ReferencedTools { get; set; }

    /// <summary>
    /// Block for instruction.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instruction block(s) allowed")]
    [TerraformPropertyName("instruction")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPlaybookInstructionBlock>>? Instruction { get; set; } = new();

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    [TerraformPropertyName("llm_model_settings")]
    public TerraformList<TerraformBlock<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>>? LlmModelSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDialogflowCxPlaybookTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The timestamp of initial playbook creation.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The unique identifier of the Playbook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/playbooks/&amp;lt;Playbook ID&amp;gt;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The resource name of flows referenced by the current playbook in the instructions.
    /// </summary>
    [TerraformPropertyName("referenced_flows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReferencedFlows => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "referenced_flows");

    /// <summary>
    /// The resource name of other playbooks referenced by the current playbook in the instructions.
    /// </summary>
    [TerraformPropertyName("referenced_playbooks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ReferencedPlaybooks => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "referenced_playbooks");

    /// <summary>
    /// Estimated number of tokes current playbook takes when sent to the LLM.
    /// </summary>
    [TerraformPropertyName("token_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TokenCount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token_count");

    /// <summary>
    /// Last time the playbook version was updated.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}

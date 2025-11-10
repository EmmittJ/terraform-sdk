using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instruction in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookInstructionBlock : TerraformBlock
{
    /// <summary>
    /// General guidelines for the playbook. These are unstructured instructions that are not directly part of the goal, e.g. &amp;quot;Always be polite&amp;quot;. It&#39;s valid for this text to be long and used instead of steps altogether.
    /// </summary>
    public TerraformProperty<string>? Guidelines
    {
        get => GetProperty<TerraformProperty<string>>("guidelines");
        set => WithProperty("guidelines", value);
    }

}

/// <summary>
/// Block type for llm_model_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxPlaybookLlmModelSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The selected LLM model.
    /// </summary>
    public TerraformProperty<string>? Model
    {
        get => GetProperty<TerraformProperty<string>>("model");
        set => WithProperty("model", value);
    }

    /// <summary>
    /// The custom prompt to use.
    /// </summary>
    public TerraformProperty<string>? PromptText
    {
        get => GetProperty<TerraformProperty<string>>("prompt_text");
        set => WithProperty("prompt_text", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxPlaybookTimeoutsBlock : TerraformBlock
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
/// Manages a google_dialogflow_cx_playbook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDialogflowCxPlaybook : TerraformResource
{
    public GoogleDialogflowCxPlaybook(string name) : base("google_dialogflow_cx_playbook", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("name");
        this.WithOutput("referenced_flows");
        this.WithOutput("referenced_playbooks");
        this.WithOutput("token_count");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The human-readable name of the playbook, unique within an agent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// High level description of the goal the playbook intend to accomplish. A goal should be concise since it&#39;s visible to other playbooks that may reference this playbook.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    public required TerraformProperty<string> Goal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("goal");
        set => this.WithProperty("goal", value);
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
    /// The agent to create a Playbook for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Type of the playbook. Possible values: [&amp;quot;PLAYBOOK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;TASK&amp;quot;, &amp;quot;ROUTINE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PlaybookType
    {
        get => GetProperty<TerraformProperty<string>>("playbook_type");
        set => this.WithProperty("playbook_type", value);
    }

    /// <summary>
    /// The resource name of tools referenced by the current playbook in the instructions. If not provided explicitly, they are will be implied using the tool being referenced in goal and steps.
    /// </summary>
    public List<TerraformProperty<string>>? ReferencedTools
    {
        get => GetProperty<List<TerraformProperty<string>>>("referenced_tools");
        set => this.WithProperty("referenced_tools", value);
    }

    /// <summary>
    /// Block for instruction.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instruction block(s) allowed")]
    public List<GoogleDialogflowCxPlaybookInstructionBlock>? Instruction
    {
        get => GetProperty<List<GoogleDialogflowCxPlaybookInstructionBlock>>("instruction");
        set => this.WithProperty("instruction", value);
    }

    /// <summary>
    /// Block for llm_model_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LlmModelSettings block(s) allowed")]
    public List<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>? LlmModelSettings
    {
        get => GetProperty<List<GoogleDialogflowCxPlaybookLlmModelSettingsBlock>>("llm_model_settings");
        set => this.WithProperty("llm_model_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDialogflowCxPlaybookTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDialogflowCxPlaybookTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp of initial playbook creation.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The unique identifier of the Playbook.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/playbooks/&amp;lt;Playbook ID&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The resource name of flows referenced by the current playbook in the instructions.
    /// </summary>
    public TerraformExpression ReferencedFlows => this["referenced_flows"];

    /// <summary>
    /// The resource name of other playbooks referenced by the current playbook in the instructions.
    /// </summary>
    public TerraformExpression ReferencedPlaybooks => this["referenced_playbooks"];

    /// <summary>
    /// Estimated number of tokes current playbook takes when sent to the LLM.
    /// </summary>
    public TerraformExpression TokenCount => this["token_count"];

    /// <summary>
    /// Last time the playbook version was updated.
    /// 
    /// Uses RFC 3339, where generated output will always be Z-normalized and uses 0, 3, 6 or 9 fractional digits. Offsets other than &amp;quot;Z&amp;quot; are also accepted. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot;, &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot; or &amp;quot;2014-10-02T15:01:23+05:30&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_policy in GoogleDiscoveryEngineAssistant.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantCustomerPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_policy";

    /// <summary>
    /// BannedPhrases block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlockBannedPhrasesBlock>? BannedPhrases
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlockBannedPhrasesBlock>>("banned_phrases");
        set => SetArgument("banned_phrases", value);
    }

    /// <summary>
    /// ModelArmorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ModelArmorConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlockModelArmorConfigBlock>? ModelArmorConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlockModelArmorConfigBlock>>("model_armor_config");
        set => SetArgument("model_armor_config", value);
    }

}

/// <summary>
/// Block type for banned_phrases in GoogleDiscoveryEngineAssistantCustomerPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantCustomerPolicyBlockBannedPhrasesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "banned_phrases";

    /// <summary>
    /// If true, diacritical marks (e.g., accents, umlauts) are ignored when
    /// matching banned phrases. For example, &amp;quot;cafe&amp;quot; would match &amp;quot;caf&#233;&amp;quot;.
    /// </summary>
    public TerraformValue<bool>? IgnoreDiacritics
    {
        get => new TerraformReference<bool>(this, "ignore_diacritics");
        set => SetArgument("ignore_diacritics", value);
    }

    /// <summary>
    /// Match type for the banned phrase.
    /// The supported values: &#39;SIMPLE_STRING_MATCH&#39;, &#39;WORD_BOUNDARY_STRING_MATCH&#39;.
    /// </summary>
    public TerraformValue<string>? MatchType
    {
        get => new TerraformReference<string>(this, "match_type");
        set => SetArgument("match_type", value);
    }

    /// <summary>
    /// The raw string content to be banned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Phrase is required")]
    public required TerraformValue<string> Phrase
    {
        get => new TerraformReference<string>(this, "phrase");
        set => SetArgument("phrase", value);
    }

}

/// <summary>
/// Block type for model_armor_config in GoogleDiscoveryEngineAssistantCustomerPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantCustomerPolicyBlockModelArmorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model_armor_config";

    /// <summary>
    /// Defines the failure mode for Model Armor sanitization.
    /// The supported values: &#39;FAIL_OPEN&#39;, &#39;FAIL_CLOSED&#39;.
    /// </summary>
    public TerraformValue<string>? FailureMode
    {
        get => new TerraformReference<string>(this, "failure_mode");
        set => SetArgument("failure_mode", value);
    }

    /// <summary>
    /// The resource name of the Model Armor template for sanitizing assistant
    /// responses. Format:
    /// &#39;projects/{project}/locations/{location}/templates/{template_id}&#39;
    /// 
    /// If not specified, no sanitization will be applied to the assistant
    /// response.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponseTemplate is required")]
    public required TerraformValue<string> ResponseTemplate
    {
        get => new TerraformReference<string>(this, "response_template");
        set => SetArgument("response_template", value);
    }

    /// <summary>
    /// The resource name of the Model Armor template for sanitizing user
    /// prompts. Format:
    /// &#39;projects/{project}/locations/{location}/templates/{template_id}&#39;
    /// 
    /// If not specified, no sanitization will be applied to the user prompt.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPromptTemplate is required")]
    public required TerraformValue<string> UserPromptTemplate
    {
        get => new TerraformReference<string>(this, "user_prompt_template");
        set => SetArgument("user_prompt_template", value);
    }

}


/// <summary>
/// Block type for generation_config in GoogleDiscoveryEngineAssistant.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantGenerationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generation_config";

    /// <summary>
    /// The default language to use for the generation of the assistant response.
    /// Use an ISO 639-1 language code such as &#39;en&#39;.
    /// If not specified, the language will be automatically detected.
    /// </summary>
    public TerraformValue<string>? DefaultLanguage
    {
        get => new TerraformReference<string>(this, "default_language");
        set => SetArgument("default_language", value);
    }

    /// <summary>
    /// SystemInstruction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemInstruction block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAssistantGenerationConfigBlockSystemInstructionBlock>? SystemInstruction
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAssistantGenerationConfigBlockSystemInstructionBlock>>("system_instruction");
        set => SetArgument("system_instruction", value);
    }

}

/// <summary>
/// Block type for system_instruction in GoogleDiscoveryEngineAssistantGenerationConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineAssistantGenerationConfigBlockSystemInstructionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "system_instruction";

    /// <summary>
    /// Additional system instruction that will be added to the default system instruction.
    /// </summary>
    public TerraformValue<string>? AdditionalSystemInstruction
    {
        get => new TerraformReference<string>(this, "additional_system_instruction");
        set => SetArgument("additional_system_instruction", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineAssistant.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineAssistantTimeoutsBlock : TerraformBlock
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
/// Represents a google_discovery_engine_assistant Terraform resource.
/// Manages a google_discovery_engine_assistant resource.
/// </summary>
public partial class GoogleDiscoveryEngineAssistant(string name) : TerraformResource("google_discovery_engine_assistant", name)
{
    /// <summary>
    /// The unique id of the assistant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssistantId is required")]
    public required TerraformValue<string> AssistantId
    {
        get => new TerraformReference<string>(this, "assistant_id");
        set => SetArgument("assistant_id", value);
    }

    /// <summary>
    /// The unique id of the collection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformValue<string> CollectionId
    {
        get => new TerraformReference<string>(this, "collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// Description for additional information. Expected to be shown on the
    /// configuration UI, not to the users of the assistant.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The assistant display name.
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 128 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The unique id of the engine.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineId is required")]
    public required TerraformValue<string> EngineId
    {
        get => new TerraformReference<string>(this, "engine_id");
        set => SetArgument("engine_id", value);
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
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
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
    /// The type of web grounding to use.
    /// The supported values: &#39;WEB_GROUNDING_TYPE_DISABLED&#39;, &#39;WEB_GROUNDING_TYPE_GOOGLE_SEARCH&#39;, &#39;WEB_GROUNDING_TYPE_ENTERPRISE_WEB_SEARCH&#39;.
    /// </summary>
    public TerraformValue<string>? WebGroundingType
    {
        get => new TerraformReference<string>(this, "web_grounding_type");
        set => SetArgument("web_grounding_type", value);
    }

    /// <summary>
    /// Resource name of the assistant.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}&#39;
    /// 
    /// It must be a UTF-8 encoded string with a length limit of 1024 characters.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// CustomerPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerPolicy block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>? CustomerPolicy
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAssistantCustomerPolicyBlock>>("customer_policy");
        set => SetArgument("customer_policy", value);
    }

    /// <summary>
    /// GenerationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationConfig block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineAssistantGenerationConfigBlock>? GenerationConfig
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineAssistantGenerationConfigBlock>>("generation_config");
        set => SetArgument("generation_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineAssistantTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineAssistantTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

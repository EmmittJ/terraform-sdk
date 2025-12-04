using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for test_case_conversation_turns in GoogleDialogflowCxTestCase.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_case_conversation_turns";

    /// <summary>
    /// UserInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserInput block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlock>? UserInput
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlock>>("user_input");
        set => SetArgument("user_input", value);
    }

    /// <summary>
    /// VirtualAgentOutput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualAgentOutput block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock>? VirtualAgentOutput
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock>>("virtual_agent_output");
        set => SetArgument("virtual_agent_output", value);
    }

}

/// <summary>
/// Block type for user_input in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_input";

    /// <summary>
    /// Whether sentiment analysis is enabled.
    /// </summary>
    public TerraformValue<bool>? EnableSentimentAnalysis
    {
        get => GetArgument<TerraformValue<bool>>("enable_sentiment_analysis");
        set => SetArgument("enable_sentiment_analysis", value);
    }

    /// <summary>
    /// Parameters that need to be injected into the conversation during intent detection.
    /// </summary>
    public TerraformValue<string>? InjectedParameters
    {
        get => GetArgument<TerraformValue<string>>("injected_parameters");
        set => SetArgument("injected_parameters", value);
    }

    /// <summary>
    /// If webhooks should be allowed to trigger in response to the user utterance. Often if parameters are injected, webhooks should not be enabled.
    /// </summary>
    public TerraformValue<bool>? IsWebhookEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_webhook_enabled");
        set => SetArgument("is_webhook_enabled", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Input block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock>? Input
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock>>("input");
        set => SetArgument("input", value);
    }

}

/// <summary>
/// Block type for input in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

    /// <summary>
    /// The language of the input. See [Language Support](https://cloud.google.com/dialogflow/cx/docs/reference/language) for a list of the currently supported language codes.
    /// Note that queries in the same session do not necessarily need to specify the same language.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Dtmf block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dtmf block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockDtmfBlock>? Dtmf
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockDtmfBlock>>("dtmf");
        set => SetArgument("dtmf", value);
    }

    /// <summary>
    /// EventAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventAttribute block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockEventAttributeBlock>? EventAttribute
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockEventAttributeBlock>>("event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// Text block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Text block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockTextBlock>? Text
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockTextBlock>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for dtmf in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockDtmfBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dtmf";

    /// <summary>
    /// The dtmf digits.
    /// </summary>
    public TerraformValue<string>? Digits
    {
        get => GetArgument<TerraformValue<string>>("digits");
        set => SetArgument("digits", value);
    }

    /// <summary>
    /// The finish digit (if any).
    /// </summary>
    public TerraformValue<string>? FinishDigit
    {
        get => GetArgument<TerraformValue<string>>("finish_digit");
        set => SetArgument("finish_digit", value);
    }

}

/// <summary>
/// Block type for event in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockEventAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event";

    /// <summary>
    /// Name of the event.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventAttribute is required")]
    public required TerraformValue<string> EventAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("event");
        set => SetArgument("event", value);
    }

}

/// <summary>
/// Block type for text in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockUserInputBlockInputBlockTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text";

    /// <summary>
    /// The natural language text to be processed. Text length must not exceed 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Text is required")]
    public required TerraformValue<string> Text
    {
        get => GetRequiredArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for virtual_agent_output in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_agent_output";

    /// <summary>
    /// The session parameters available to the bot at this point.
    /// </summary>
    public TerraformValue<string>? SessionParameters
    {
        get => GetArgument<TerraformValue<string>>("session_parameters");
        set => SetArgument("session_parameters", value);
    }

    /// <summary>
    /// CurrentPage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CurrentPage block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockCurrentPageBlock>? CurrentPage
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockCurrentPageBlock>>("current_page");
        set => SetArgument("current_page", value);
    }

    /// <summary>
    /// TextResponses block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTextResponsesBlock>? TextResponses
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTextResponsesBlock>>("text_responses");
        set => SetArgument("text_responses", value);
    }

    /// <summary>
    /// TriggeredIntent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggeredIntent block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTriggeredIntentBlock>? TriggeredIntent
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTriggeredIntentBlock>>("triggered_intent");
        set => SetArgument("triggered_intent", value);
    }

}

/// <summary>
/// Block type for current_page in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockCurrentPageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "current_page";

    /// <summary>
    /// The human-readable name of the page, unique within the flow.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for text_responses in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTextResponsesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "text_responses";

    /// <summary>
    /// A collection of text responses.
    /// </summary>
    public TerraformList<string>? Text
    {
        get => GetArgument<TerraformList<string>>("text");
        set => SetArgument("text", value);
    }

}

/// <summary>
/// Block type for triggered_intent in GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlockVirtualAgentOutputBlockTriggeredIntentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "triggered_intent";

    /// <summary>
    /// The human-readable name of the intent, unique within the agent.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The unique identifier of the intent.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/intents/&amp;lt;Intent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for test_config in GoogleDialogflowCxTestCase.
/// Nesting mode: list
/// </summary>
public class GoogleDialogflowCxTestCaseTestConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "test_config";

    /// <summary>
    /// Flow name to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    public TerraformValue<string>? Flow
    {
        get => GetArgument<TerraformValue<string>>("flow");
        set => SetArgument("flow", value);
    }

    /// <summary>
    /// The page to start the test case with.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/flows/&amp;lt;Flow ID&amp;gt;/pages/&amp;lt;Page ID&amp;gt;.
    /// Only one of flow and page should be set to indicate the starting point of the test case. If neither is set, the test case will start with start page on the default start flow.
    /// </summary>
    public TerraformValue<string>? Page
    {
        get => GetArgument<TerraformValue<string>>("page");
        set => SetArgument("page", value);
    }

    /// <summary>
    /// Session parameters to be compared when calculating differences.
    /// </summary>
    public TerraformList<string>? TrackingParameters
    {
        get => GetArgument<TerraformList<string>>("tracking_parameters");
        set => SetArgument("tracking_parameters", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDialogflowCxTestCase.
/// Nesting mode: single
/// </summary>
public class GoogleDialogflowCxTestCaseTimeoutsBlock : TerraformBlock
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
/// Represents a google_dialogflow_cx_test_case Terraform resource.
/// Manages a google_dialogflow_cx_test_case resource.
/// </summary>
public partial class GoogleDialogflowCxTestCase(string name) : TerraformResource("google_dialogflow_cx_test_case", name)
{
    /// <summary>
    /// The human-readable name of the test case, unique within the agent. Limit of 200 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// Additional freeform notes about the test case. Limit of 400 characters.
    /// </summary>
    public TerraformValue<string>? Notes
    {
        get => GetArgument<TerraformValue<string>>("notes");
        set => SetArgument("notes", value);
    }

    /// <summary>
    /// The agent to create the test case for.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Tags are short descriptions that users may apply to test cases for organizational and filtering purposes.
    /// Each tag should start with &amp;quot;#&amp;quot; and has a limit of 30 characters
    /// </summary>
    public TerraformList<string>? Tags
    {
        get => GetArgument<TerraformList<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// When the test was created. A timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The latest test result.
    /// </summary>
    public TerraformList<TerraformMap<object>> LastTestResult
        => AsReference("last_test_result");

    /// <summary>
    /// The unique identifier of the test case.
    /// Format: projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;/testCases/&amp;lt;TestCase ID&amp;gt;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// TestCaseConversationTurns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>? TestCaseConversationTurns
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestCaseConversationTurnsBlock>>("test_case_conversation_turns");
        set => SetArgument("test_case_conversation_turns", value);
    }

    /// <summary>
    /// TestConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TestConfig block(s) allowed")]
    public TerraformList<GoogleDialogflowCxTestCaseTestConfigBlock>? TestConfig
    {
        get => GetArgument<TerraformList<GoogleDialogflowCxTestCaseTestConfigBlock>>("test_config");
        set => SetArgument("test_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDialogflowCxTestCaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDialogflowCxTestCaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

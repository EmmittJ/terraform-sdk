using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for abort_statement in AwsLexBot.
/// Nesting mode: list
/// </summary>
public class AwsLexBotAbortStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort_statement";

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformValue<string>? ResponseCard
    {
        get => new TerraformReference<string>(this, "response_card");
        set => SetArgument("response_card", value);
    }

    /// <summary>
    /// Message block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Message block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(15, ErrorMessage = "Maximum 15 Message block(s) allowed")]
    public required TerraformSet<AwsLexBotAbortStatementBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexBotAbortStatementBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexBotAbortStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexBotAbortStatementBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The group_number attribute.
    /// </summary>
    public TerraformValue<double>? GroupNumber
    {
        get => new TerraformReference<double>(this, "group_number");
        set => SetArgument("group_number", value);
    }

}


/// <summary>
/// Block type for clarification_prompt in AwsLexBot.
/// Nesting mode: list
/// </summary>
public class AwsLexBotClarificationPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clarification_prompt";

    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    public required TerraformValue<double> MaxAttempts
    {
        get => new TerraformReference<double>(this, "max_attempts");
        set => SetArgument("max_attempts", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformValue<string>? ResponseCard
    {
        get => new TerraformReference<string>(this, "response_card");
        set => SetArgument("response_card", value);
    }

    /// <summary>
    /// Message block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Message is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Message block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(15, ErrorMessage = "Maximum 15 Message block(s) allowed")]
    public required TerraformSet<AwsLexBotClarificationPromptBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexBotClarificationPromptBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexBotClarificationPromptBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexBotClarificationPromptBlockMessageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "message";

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The group_number attribute.
    /// </summary>
    public TerraformValue<double>? GroupNumber
    {
        get => new TerraformReference<double>(this, "group_number");
        set => SetArgument("group_number", value);
    }

}


/// <summary>
/// Block type for intent in AwsLexBot.
/// Nesting mode: set
/// </summary>
public class AwsLexBotIntentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intent";

    /// <summary>
    /// The intent_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentName is required")]
    public required TerraformValue<string> IntentName
    {
        get => new TerraformReference<string>(this, "intent_name");
        set => SetArgument("intent_name", value);
    }

    /// <summary>
    /// The intent_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntentVersion is required")]
    public required TerraformValue<string> IntentVersion
    {
        get => new TerraformReference<string>(this, "intent_version");
        set => SetArgument("intent_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLexBot.
/// Nesting mode: single
/// </summary>
public class AwsLexBotTimeoutsBlock : TerraformBlock
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
/// Represents a aws_lex_bot Terraform resource.
/// Manages a aws_lex_bot resource.
/// </summary>
public partial class AwsLexBot(string name) : TerraformResource("aws_lex_bot", name)
{
    /// <summary>
    /// The child_directed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChildDirected is required")]
    public required TerraformValue<bool> ChildDirected
    {
        get => new TerraformReference<bool>(this, "child_directed");
        set => SetArgument("child_directed", value);
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformValue<bool>? CreateVersion
    {
        get => new TerraformReference<bool>(this, "create_version");
        set => SetArgument("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The detect_sentiment attribute.
    /// </summary>
    public TerraformValue<bool>? DetectSentiment
    {
        get => new TerraformReference<bool>(this, "detect_sentiment");
        set => SetArgument("detect_sentiment", value);
    }

    /// <summary>
    /// The enable_model_improvements attribute.
    /// </summary>
    public TerraformValue<bool>? EnableModelImprovements
    {
        get => new TerraformReference<bool>(this, "enable_model_improvements");
        set => SetArgument("enable_model_improvements", value);
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
    /// The idle_session_ttl_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IdleSessionTtlInSeconds
    {
        get => new TerraformReference<double>(this, "idle_session_ttl_in_seconds");
        set => SetArgument("idle_session_ttl_in_seconds", value);
    }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    public TerraformValue<string>? Locale
    {
        get => new TerraformReference<string>(this, "locale");
        set => SetArgument("locale", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nlu_intent_confidence_threshold attribute.
    /// </summary>
    public TerraformValue<double>? NluIntentConfidenceThreshold
    {
        get => new TerraformReference<double>(this, "nlu_intent_confidence_threshold");
        set => SetArgument("nlu_intent_confidence_threshold", value);
    }

    /// <summary>
    /// The process_behavior attribute.
    /// </summary>
    public TerraformValue<string>? ProcessBehavior
    {
        get => new TerraformReference<string>(this, "process_behavior");
        set => SetArgument("process_behavior", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The voice_id attribute.
    /// </summary>
    public TerraformValue<string> VoiceId
    {
        get => new TerraformReference<string>(this, "voice_id");
        set => SetArgument("voice_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformValue<string> Checksum
    {
        get => new TerraformReference<string>(this, "checksum");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    public TerraformValue<string> FailureReason
    {
        get => new TerraformReference<string>(this, "failure_reason");
    }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// AbortStatement block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AbortStatement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AbortStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortStatement block(s) allowed")]
    public required TerraformList<AwsLexBotAbortStatementBlock> AbortStatement
    {
        get => GetRequiredArgument<TerraformList<AwsLexBotAbortStatementBlock>>("abort_statement");
        set => SetArgument("abort_statement", value);
    }

    /// <summary>
    /// ClarificationPrompt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClarificationPrompt block(s) allowed")]
    public TerraformList<AwsLexBotClarificationPromptBlock>? ClarificationPrompt
    {
        get => GetArgument<TerraformList<AwsLexBotClarificationPromptBlock>>("clarification_prompt");
        set => SetArgument("clarification_prompt", value);
    }

    /// <summary>
    /// Intent block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Intent is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Intent block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(250, ErrorMessage = "Maximum 250 Intent block(s) allowed")]
    public required TerraformSet<AwsLexBotIntentBlock> Intent
    {
        get => GetRequiredArgument<TerraformSet<AwsLexBotIntentBlock>>("intent");
        set => SetArgument("intent", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexBotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexBotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

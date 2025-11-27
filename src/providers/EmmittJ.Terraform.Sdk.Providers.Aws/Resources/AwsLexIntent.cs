using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for conclusion_statement in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConclusionStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conclusion_statement";

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
    public required TerraformSet<AwsLexIntentConclusionStatementBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentConclusionStatementBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentConclusionStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentConclusionStatementBlockMessageBlock : TerraformBlock
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
/// Block type for confirmation_prompt in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConfirmationPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confirmation_prompt";

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
    public required TerraformSet<AwsLexIntentConfirmationPromptBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentConfirmationPromptBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentConfirmationPromptBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentConfirmationPromptBlockMessageBlock : TerraformBlock
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
/// Block type for dialog_code_hook in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentDialogCodeHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dialog_code_hook";

    /// <summary>
    /// The message_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageVersion is required")]
    public required TerraformValue<string> MessageVersion
    {
        get => new TerraformReference<string>(this, "message_version");
        set => SetArgument("message_version", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for follow_up_prompt in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFollowUpPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "follow_up_prompt";

    /// <summary>
    /// Prompt block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prompt is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Prompt block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Prompt block(s) allowed")]
    public required TerraformList<AwsLexIntentFollowUpPromptBlockPromptBlock> Prompt
    {
        get => GetRequiredArgument<TerraformList<AwsLexIntentFollowUpPromptBlockPromptBlock>>("prompt");
        set => SetArgument("prompt", value);
    }

    /// <summary>
    /// RejectionStatement block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RejectionStatement is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RejectionStatement block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    public required TerraformList<AwsLexIntentFollowUpPromptBlockRejectionStatementBlock> RejectionStatement
    {
        get => GetRequiredArgument<TerraformList<AwsLexIntentFollowUpPromptBlockRejectionStatementBlock>>("rejection_statement");
        set => SetArgument("rejection_statement", value);
    }

}

/// <summary>
/// Block type for prompt in AwsLexIntentFollowUpPromptBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFollowUpPromptBlockPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prompt";

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
    public required TerraformSet<AwsLexIntentFollowUpPromptBlockPromptBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentFollowUpPromptBlockPromptBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentFollowUpPromptBlockPromptBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentFollowUpPromptBlockPromptBlockMessageBlock : TerraformBlock
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
/// Block type for rejection_statement in AwsLexIntentFollowUpPromptBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFollowUpPromptBlockRejectionStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rejection_statement";

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
    public required TerraformSet<AwsLexIntentFollowUpPromptBlockRejectionStatementBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentFollowUpPromptBlockRejectionStatementBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentFollowUpPromptBlockRejectionStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentFollowUpPromptBlockRejectionStatementBlockMessageBlock : TerraformBlock
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
/// Block type for fulfillment_activity in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFulfillmentActivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fulfillment_activity";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// CodeHook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeHook block(s) allowed")]
    public TerraformList<AwsLexIntentFulfillmentActivityBlockCodeHookBlock>? CodeHook
    {
        get => GetArgument<TerraformList<AwsLexIntentFulfillmentActivityBlockCodeHookBlock>>("code_hook");
        set => SetArgument("code_hook", value);
    }

}

/// <summary>
/// Block type for code_hook in AwsLexIntentFulfillmentActivityBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFulfillmentActivityBlockCodeHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_hook";

    /// <summary>
    /// The message_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageVersion is required")]
    public required TerraformValue<string> MessageVersion
    {
        get => new TerraformReference<string>(this, "message_version");
        set => SetArgument("message_version", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for rejection_statement in AwsLexIntent.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentRejectionStatementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rejection_statement";

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
    public required TerraformSet<AwsLexIntentRejectionStatementBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentRejectionStatementBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentRejectionStatementBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentRejectionStatementBlockMessageBlock : TerraformBlock
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
/// Block type for slot in AwsLexIntent.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentSlotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slot";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
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
    /// The sample_utterances attribute.
    /// </summary>
    public TerraformList<string>? SampleUtterances
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sample_utterances").ResolveNodes(ctx));
        set => SetArgument("sample_utterances", value);
    }

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    public required TerraformValue<string> SlotConstraint
    {
        get => new TerraformReference<string>(this, "slot_constraint");
        set => SetArgument("slot_constraint", value);
    }

    /// <summary>
    /// The slot_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotType is required")]
    public required TerraformValue<string> SlotType
    {
        get => new TerraformReference<string>(this, "slot_type");
        set => SetArgument("slot_type", value);
    }

    /// <summary>
    /// The slot_type_version attribute.
    /// </summary>
    public TerraformValue<string>? SlotTypeVersion
    {
        get => new TerraformReference<string>(this, "slot_type_version");
        set => SetArgument("slot_type_version", value);
    }

    /// <summary>
    /// ValueElicitationPrompt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValueElicitationPrompt block(s) allowed")]
    public TerraformList<AwsLexIntentSlotBlockValueElicitationPromptBlock>? ValueElicitationPrompt
    {
        get => GetArgument<TerraformList<AwsLexIntentSlotBlockValueElicitationPromptBlock>>("value_elicitation_prompt");
        set => SetArgument("value_elicitation_prompt", value);
    }

}

/// <summary>
/// Block type for value_elicitation_prompt in AwsLexIntentSlotBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexIntentSlotBlockValueElicitationPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_elicitation_prompt";

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
    public required TerraformSet<AwsLexIntentSlotBlockValueElicitationPromptBlockMessageBlock> Message
    {
        get => GetRequiredArgument<TerraformSet<AwsLexIntentSlotBlockValueElicitationPromptBlockMessageBlock>>("message");
        set => SetArgument("message", value);
    }

}

/// <summary>
/// Block type for message in AwsLexIntentSlotBlockValueElicitationPromptBlock.
/// Nesting mode: set
/// </summary>
public class AwsLexIntentSlotBlockValueElicitationPromptBlockMessageBlock : TerraformBlock
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
/// Block type for timeouts in AwsLexIntent.
/// Nesting mode: single
/// </summary>
public class AwsLexIntentTimeoutsBlock : TerraformBlock
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
/// Represents a aws_lex_intent Terraform resource.
/// Manages a aws_lex_intent resource.
/// </summary>
public partial class AwsLexIntent(string name) : TerraformResource("aws_lex_intent", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The parent_intent_signature attribute.
    /// </summary>
    public TerraformValue<string>? ParentIntentSignature
    {
        get => new TerraformReference<string>(this, "parent_intent_signature");
        set => SetArgument("parent_intent_signature", value);
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
    /// The sample_utterances attribute.
    /// </summary>
    public TerraformSet<string>? SampleUtterances
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "sample_utterances").ResolveNodes(ctx));
        set => SetArgument("sample_utterances", value);
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
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
    {
        get => new TerraformReference<string>(this, "last_updated_date");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// ConclusionStatement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConclusionStatement block(s) allowed")]
    public TerraformList<AwsLexIntentConclusionStatementBlock>? ConclusionStatement
    {
        get => GetArgument<TerraformList<AwsLexIntentConclusionStatementBlock>>("conclusion_statement");
        set => SetArgument("conclusion_statement", value);
    }

    /// <summary>
    /// ConfirmationPrompt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfirmationPrompt block(s) allowed")]
    public TerraformList<AwsLexIntentConfirmationPromptBlock>? ConfirmationPrompt
    {
        get => GetArgument<TerraformList<AwsLexIntentConfirmationPromptBlock>>("confirmation_prompt");
        set => SetArgument("confirmation_prompt", value);
    }

    /// <summary>
    /// DialogCodeHook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogCodeHook block(s) allowed")]
    public TerraformList<AwsLexIntentDialogCodeHookBlock>? DialogCodeHook
    {
        get => GetArgument<TerraformList<AwsLexIntentDialogCodeHookBlock>>("dialog_code_hook");
        set => SetArgument("dialog_code_hook", value);
    }

    /// <summary>
    /// FollowUpPrompt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FollowUpPrompt block(s) allowed")]
    public TerraformList<AwsLexIntentFollowUpPromptBlock>? FollowUpPrompt
    {
        get => GetArgument<TerraformList<AwsLexIntentFollowUpPromptBlock>>("follow_up_prompt");
        set => SetArgument("follow_up_prompt", value);
    }

    /// <summary>
    /// FulfillmentActivity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FulfillmentActivity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FulfillmentActivity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FulfillmentActivity block(s) allowed")]
    public required TerraformList<AwsLexIntentFulfillmentActivityBlock> FulfillmentActivity
    {
        get => GetRequiredArgument<TerraformList<AwsLexIntentFulfillmentActivityBlock>>("fulfillment_activity");
        set => SetArgument("fulfillment_activity", value);
    }

    /// <summary>
    /// RejectionStatement block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    public TerraformList<AwsLexIntentRejectionStatementBlock>? RejectionStatement
    {
        get => GetArgument<TerraformList<AwsLexIntentRejectionStatementBlock>>("rejection_statement");
        set => SetArgument("rejection_statement", value);
    }

    /// <summary>
    /// Slot block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Slot block(s) allowed")]
    public TerraformSet<AwsLexIntentSlotBlock>? Slot
    {
        get => GetArgument<TerraformSet<AwsLexIntentSlotBlock>>("slot");
        set => SetArgument("slot", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexIntentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexIntentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

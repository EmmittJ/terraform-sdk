using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for conclusion_statement in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentConclusionStatementBlock : TerraformBlockBase
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for confirmation_prompt in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentConfirmationPromptBlock : TerraformBlockBase
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    [TerraformProperty("max_attempts")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxAttempts { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentDialogCodeHookBlock : TerraformBlockBase
{
    /// <summary>
    /// The message_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageVersion is required")]
    [TerraformProperty("message_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MessageVersion { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for follow_up_prompt in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentFollowUpPromptBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for fulfillment_activity in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentFulfillmentActivityBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for rejection_statement in .
/// Nesting mode: list
/// </summary>
public partial class AwsLexIntentRejectionStatementBlock : TerraformBlockBase
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for slot in .
/// Nesting mode: set
/// </summary>
public partial class AwsLexIntentSlotBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformProperty("response_card")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResponseCard { get; set; }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    [TerraformProperty("sample_utterances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SampleUtterances { get; set; }

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    [TerraformProperty("slot_constraint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlotConstraint { get; set; }

    /// <summary>
    /// The slot_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotType is required")]
    [TerraformProperty("slot_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SlotType { get; set; }

    /// <summary>
    /// The slot_type_version attribute.
    /// </summary>
    [TerraformProperty("slot_type_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SlotTypeVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsLexIntentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lex_intent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsLexIntent : TerraformResource
{
    public AwsLexIntent(string name) : base("aws_lex_intent", name)
    {
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    [TerraformProperty("create_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    [TerraformProperty("parent_intent_signature")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ParentIntentSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    [TerraformProperty("sample_utterances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SampleUtterances { get; set; }

    /// <summary>
    /// Block for conclusion_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConclusionStatement block(s) allowed")]
    [TerraformProperty("conclusion_statement")]
    public partial TerraformList<TerraformBlock<AwsLexIntentConclusionStatementBlock>>? ConclusionStatement { get; set; }

    /// <summary>
    /// Block for confirmation_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfirmationPrompt block(s) allowed")]
    [TerraformProperty("confirmation_prompt")]
    public partial TerraformList<TerraformBlock<AwsLexIntentConfirmationPromptBlock>>? ConfirmationPrompt { get; set; }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogCodeHook block(s) allowed")]
    [TerraformProperty("dialog_code_hook")]
    public partial TerraformList<TerraformBlock<AwsLexIntentDialogCodeHookBlock>>? DialogCodeHook { get; set; }

    /// <summary>
    /// Block for follow_up_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FollowUpPrompt block(s) allowed")]
    [TerraformProperty("follow_up_prompt")]
    public partial TerraformList<TerraformBlock<AwsLexIntentFollowUpPromptBlock>>? FollowUpPrompt { get; set; }

    /// <summary>
    /// Block for fulfillment_activity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FulfillmentActivity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FulfillmentActivity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FulfillmentActivity block(s) allowed")]
    [TerraformProperty("fulfillment_activity")]
    public partial TerraformList<TerraformBlock<AwsLexIntentFulfillmentActivityBlock>>? FulfillmentActivity { get; set; }

    /// <summary>
    /// Block for rejection_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    [TerraformProperty("rejection_statement")]
    public partial TerraformList<TerraformBlock<AwsLexIntentRejectionStatementBlock>>? RejectionStatement { get; set; }

    /// <summary>
    /// Block for slot.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Slot block(s) allowed")]
    [TerraformProperty("slot")]
    public partial TerraformSet<TerraformBlock<AwsLexIntentSlotBlock>>? Slot { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsLexIntentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformProperty("checksum")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Checksum { get; }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformProperty("last_updated_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedDate { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}

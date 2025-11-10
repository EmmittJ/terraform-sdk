using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for conclusion_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConclusionStatementBlock : ITerraformBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for confirmation_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConfirmationPromptBlock : ITerraformBlock
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    [TerraformPropertyName("max_attempts")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxAttempts { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentDialogCodeHookBlock : ITerraformBlock
{
    /// <summary>
    /// The message_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageVersion is required")]
    [TerraformPropertyName("message_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MessageVersion { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

}

/// <summary>
/// Block type for follow_up_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFollowUpPromptBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for fulfillment_activity in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFulfillmentActivityBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for rejection_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentRejectionStatementBlock : ITerraformBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseCard { get; set; }

}

/// <summary>
/// Block type for slot in .
/// Nesting mode: set
/// </summary>
public class AwsLexIntentSlotBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Priority { get; set; }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    [TerraformPropertyName("response_card")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResponseCard { get; set; }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    [TerraformPropertyName("sample_utterances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SampleUtterances { get; set; }

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    [TerraformPropertyName("slot_constraint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SlotConstraint { get; set; }

    /// <summary>
    /// The slot_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotType is required")]
    [TerraformPropertyName("slot_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SlotType { get; set; }

    /// <summary>
    /// The slot_type_version attribute.
    /// </summary>
    [TerraformPropertyName("slot_type_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SlotTypeVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexIntentTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_lex_intent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexIntent : TerraformResource
{
    public AwsLexIntent(string name) : base("aws_lex_intent", name)
    {
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    [TerraformPropertyName("create_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    [TerraformPropertyName("parent_intent_signature")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParentIntentSignature { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    [TerraformPropertyName("sample_utterances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SampleUtterances { get; set; }

    /// <summary>
    /// Block for conclusion_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConclusionStatement block(s) allowed")]
    [TerraformPropertyName("conclusion_statement")]
    public TerraformList<TerraformBlock<AwsLexIntentConclusionStatementBlock>>? ConclusionStatement { get; set; } = new();

    /// <summary>
    /// Block for confirmation_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfirmationPrompt block(s) allowed")]
    [TerraformPropertyName("confirmation_prompt")]
    public TerraformList<TerraformBlock<AwsLexIntentConfirmationPromptBlock>>? ConfirmationPrompt { get; set; } = new();

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogCodeHook block(s) allowed")]
    [TerraformPropertyName("dialog_code_hook")]
    public TerraformList<TerraformBlock<AwsLexIntentDialogCodeHookBlock>>? DialogCodeHook { get; set; } = new();

    /// <summary>
    /// Block for follow_up_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FollowUpPrompt block(s) allowed")]
    [TerraformPropertyName("follow_up_prompt")]
    public TerraformList<TerraformBlock<AwsLexIntentFollowUpPromptBlock>>? FollowUpPrompt { get; set; } = new();

    /// <summary>
    /// Block for fulfillment_activity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FulfillmentActivity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FulfillmentActivity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FulfillmentActivity block(s) allowed")]
    [TerraformPropertyName("fulfillment_activity")]
    public TerraformList<TerraformBlock<AwsLexIntentFulfillmentActivityBlock>>? FulfillmentActivity { get; set; } = new();

    /// <summary>
    /// Block for rejection_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    [TerraformPropertyName("rejection_statement")]
    public TerraformList<TerraformBlock<AwsLexIntentRejectionStatementBlock>>? RejectionStatement { get; set; } = new();

    /// <summary>
    /// Block for slot.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Slot block(s) allowed")]
    [TerraformPropertyName("slot")]
    public TerraformSet<TerraformBlock<AwsLexIntentSlotBlock>>? Slot { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexIntentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformPropertyName("checksum")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Checksum => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}

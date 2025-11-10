using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for conclusion_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConclusionStatementBlock : TerraformBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

}

/// <summary>
/// Block type for confirmation_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentConfirmationPromptBlock : TerraformBlock
{
    /// <summary>
    /// The max_attempts attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAttempts is required")]
    public required TerraformProperty<double> MaxAttempts
    {
        set => SetProperty("max_attempts", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentDialogCodeHookBlock : TerraformBlock
{
    /// <summary>
    /// The message_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MessageVersion is required")]
    public required TerraformProperty<string> MessageVersion
    {
        set => SetProperty("message_version", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for follow_up_prompt in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFollowUpPromptBlock : TerraformBlock
{
}

/// <summary>
/// Block type for fulfillment_activity in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentFulfillmentActivityBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for rejection_statement in .
/// Nesting mode: list
/// </summary>
public class AwsLexIntentRejectionStatementBlock : TerraformBlock
{
    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

}

/// <summary>
/// Block type for slot in .
/// Nesting mode: set
/// </summary>
public class AwsLexIntentSlotBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        set => SetProperty("response_card", value);
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SampleUtterances
    {
        set => SetProperty("sample_utterances", value);
    }

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    public required TerraformProperty<string> SlotConstraint
    {
        set => SetProperty("slot_constraint", value);
    }

    /// <summary>
    /// The slot_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotType is required")]
    public required TerraformProperty<string> SlotType
    {
        set => SetProperty("slot_type", value);
    }

    /// <summary>
    /// The slot_type_version attribute.
    /// </summary>
    public TerraformProperty<string>? SlotTypeVersion
    {
        set => SetProperty("slot_type_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexIntentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lex_intent resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexIntent : TerraformResource
{
    public AwsLexIntent(string name) : base("aws_lex_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("checksum");
        SetOutput("created_date");
        SetOutput("last_updated_date");
        SetOutput("version");
        SetOutput("create_version");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent_intent_signature");
        SetOutput("region");
        SetOutput("sample_utterances");
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool> CreateVersion
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_version");
        set => SetProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    public TerraformProperty<string> ParentIntentSignature
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_intent_signature");
        set => SetProperty("parent_intent_signature", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SampleUtterances
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("sample_utterances");
        set => SetProperty("sample_utterances", value);
    }

    /// <summary>
    /// Block for conclusion_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConclusionStatement block(s) allowed")]
    public List<AwsLexIntentConclusionStatementBlock>? ConclusionStatement
    {
        set => SetProperty("conclusion_statement", value);
    }

    /// <summary>
    /// Block for confirmation_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfirmationPrompt block(s) allowed")]
    public List<AwsLexIntentConfirmationPromptBlock>? ConfirmationPrompt
    {
        set => SetProperty("confirmation_prompt", value);
    }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogCodeHook block(s) allowed")]
    public List<AwsLexIntentDialogCodeHookBlock>? DialogCodeHook
    {
        set => SetProperty("dialog_code_hook", value);
    }

    /// <summary>
    /// Block for follow_up_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FollowUpPrompt block(s) allowed")]
    public List<AwsLexIntentFollowUpPromptBlock>? FollowUpPrompt
    {
        set => SetProperty("follow_up_prompt", value);
    }

    /// <summary>
    /// Block for fulfillment_activity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FulfillmentActivity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FulfillmentActivity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FulfillmentActivity block(s) allowed")]
    public List<AwsLexIntentFulfillmentActivityBlock>? FulfillmentActivity
    {
        set => SetProperty("fulfillment_activity", value);
    }

    /// <summary>
    /// Block for rejection_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    public List<AwsLexIntentRejectionStatementBlock>? RejectionStatement
    {
        set => SetProperty("rejection_statement", value);
    }

    /// <summary>
    /// Block for slot.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Slot block(s) allowed")]
    public HashSet<AwsLexIntentSlotBlock>? Slot
    {
        set => SetProperty("slot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexIntentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    public TerraformExpression Checksum => this["checksum"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDate => this["last_updated_date"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}

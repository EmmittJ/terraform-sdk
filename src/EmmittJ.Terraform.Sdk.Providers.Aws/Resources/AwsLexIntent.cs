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
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("max_attempts");
        set => WithProperty("max_attempts", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("message_version");
        set => WithProperty("message_version", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
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
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

    /// <summary>
    /// The response_card attribute.
    /// </summary>
    public TerraformProperty<string>? ResponseCard
    {
        get => GetProperty<TerraformProperty<string>>("response_card");
        set => WithProperty("response_card", value);
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SampleUtterances
    {
        get => GetProperty<List<TerraformProperty<string>>>("sample_utterances");
        set => WithProperty("sample_utterances", value);
    }

    /// <summary>
    /// The slot_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotConstraint is required")]
    public required TerraformProperty<string> SlotConstraint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("slot_constraint");
        set => WithProperty("slot_constraint", value);
    }

    /// <summary>
    /// The slot_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotType is required")]
    public required TerraformProperty<string> SlotType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("slot_type");
        set => WithProperty("slot_type", value);
    }

    /// <summary>
    /// The slot_type_version attribute.
    /// </summary>
    public TerraformProperty<string>? SlotTypeVersion
    {
        get => GetProperty<TerraformProperty<string>>("slot_type_version");
        set => WithProperty("slot_type_version", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum");
        this.DeclareOutput("created_date");
        this.DeclareOutput("last_updated_date");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateVersion
    {
        get => GetProperty<TerraformProperty<bool>>("create_version");
        set => this.WithProperty("create_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_intent_signature attribute.
    /// </summary>
    public TerraformProperty<string>? ParentIntentSignature
    {
        get => GetProperty<TerraformProperty<string>>("parent_intent_signature");
        set => this.WithProperty("parent_intent_signature", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sample_utterances attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SampleUtterances
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("sample_utterances");
        set => this.WithProperty("sample_utterances", value);
    }

    /// <summary>
    /// Block for conclusion_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConclusionStatement block(s) allowed")]
    public List<AwsLexIntentConclusionStatementBlock>? ConclusionStatement
    {
        get => GetProperty<List<AwsLexIntentConclusionStatementBlock>>("conclusion_statement");
        set => this.WithProperty("conclusion_statement", value);
    }

    /// <summary>
    /// Block for confirmation_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfirmationPrompt block(s) allowed")]
    public List<AwsLexIntentConfirmationPromptBlock>? ConfirmationPrompt
    {
        get => GetProperty<List<AwsLexIntentConfirmationPromptBlock>>("confirmation_prompt");
        set => this.WithProperty("confirmation_prompt", value);
    }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DialogCodeHook block(s) allowed")]
    public List<AwsLexIntentDialogCodeHookBlock>? DialogCodeHook
    {
        get => GetProperty<List<AwsLexIntentDialogCodeHookBlock>>("dialog_code_hook");
        set => this.WithProperty("dialog_code_hook", value);
    }

    /// <summary>
    /// Block for follow_up_prompt.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FollowUpPrompt block(s) allowed")]
    public List<AwsLexIntentFollowUpPromptBlock>? FollowUpPrompt
    {
        get => GetProperty<List<AwsLexIntentFollowUpPromptBlock>>("follow_up_prompt");
        set => this.WithProperty("follow_up_prompt", value);
    }

    /// <summary>
    /// Block for fulfillment_activity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FulfillmentActivity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FulfillmentActivity block(s) allowed")]
    public List<AwsLexIntentFulfillmentActivityBlock>? FulfillmentActivity
    {
        get => GetProperty<List<AwsLexIntentFulfillmentActivityBlock>>("fulfillment_activity");
        set => this.WithProperty("fulfillment_activity", value);
    }

    /// <summary>
    /// Block for rejection_statement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RejectionStatement block(s) allowed")]
    public List<AwsLexIntentRejectionStatementBlock>? RejectionStatement
    {
        get => GetProperty<List<AwsLexIntentRejectionStatementBlock>>("rejection_statement");
        set => this.WithProperty("rejection_statement", value);
    }

    /// <summary>
    /// Block for slot.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Slot block(s) allowed")]
    public HashSet<AwsLexIntentSlotBlock>? Slot
    {
        get => GetProperty<HashSet<AwsLexIntentSlotBlock>>("slot");
        set => this.WithProperty("slot", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexIntentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLexIntentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for closing_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentClosingSettingBlock : TerraformBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        set => SetProperty("active", value);
    }

}

/// <summary>
/// Block type for confirmation_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentConfirmationSettingBlock : TerraformBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        set => SetProperty("active", value);
    }

}

/// <summary>
/// Block type for dialog_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentDialogCodeHookBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for fulfillment_code_hook in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentFulfillmentCodeHookBlock : TerraformBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        set => SetProperty("active", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for initial_response_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentInitialResponseSettingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for input_context in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentInputContextBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for kendra_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentKendraConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The kendra_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KendraIndex is required")]
    public required TerraformProperty<string> KendraIndex
    {
        set => SetProperty("kendra_index", value);
    }

    /// <summary>
    /// The query_filter_string attribute.
    /// </summary>
    public TerraformProperty<string>? QueryFilterString
    {
        set => SetProperty("query_filter_string", value);
    }

    /// <summary>
    /// The query_filter_string_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? QueryFilterStringEnabled
    {
        set => SetProperty("query_filter_string_enabled", value);
    }

}

/// <summary>
/// Block type for output_context in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentOutputContextBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The time_to_live_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeToLiveInSeconds is required")]
    public required TerraformProperty<double> TimeToLiveInSeconds
    {
        set => SetProperty("time_to_live_in_seconds", value);
    }

    /// <summary>
    /// The turns_to_live attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TurnsToLive is required")]
    public required TerraformProperty<double> TurnsToLive
    {
        set => SetProperty("turns_to_live", value);
    }

}

/// <summary>
/// Block type for sample_utterance in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentSampleUtteranceBlock : TerraformBlock
{
    /// <summary>
    /// The utterance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Utterance is required")]
    public required TerraformProperty<string> Utterance
    {
        set => SetProperty("utterance", value);
    }

}

/// <summary>
/// Block type for slot_priority in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsIntentSlotPriorityBlock : TerraformBlock
{
    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The slot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotId is required")]
    public required TerraformProperty<string> SlotId
    {
        set => SetProperty("slot_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsIntentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_lexv2models_intent resource.
/// </summary>
public class AwsLexv2modelsIntent : TerraformResource
{
    public AwsLexv2modelsIntent(string name) : base("aws_lexv2models_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_date_time");
        SetOutput("id");
        SetOutput("intent_id");
        SetOutput("last_updated_date_time");
        SetOutput("bot_id");
        SetOutput("bot_version");
        SetOutput("description");
        SetOutput("locale_id");
        SetOutput("name");
        SetOutput("parent_intent_signature");
        SetOutput("region");
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformProperty<string> BotId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bot_id");
        set => SetProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformProperty<string> BotVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bot_version");
        set => SetProperty("bot_version", value);
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
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformProperty<string> LocaleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("locale_id");
        set => SetProperty("locale_id", value);
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
    /// Block for closing_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentClosingSettingBlock>? ClosingSetting
    {
        set => SetProperty("closing_setting", value);
    }

    /// <summary>
    /// Block for confirmation_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentConfirmationSettingBlock>? ConfirmationSetting
    {
        set => SetProperty("confirmation_setting", value);
    }

    /// <summary>
    /// Block for dialog_code_hook.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentDialogCodeHookBlock>? DialogCodeHook
    {
        set => SetProperty("dialog_code_hook", value);
    }

    /// <summary>
    /// Block for fulfillment_code_hook.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentFulfillmentCodeHookBlock>? FulfillmentCodeHook
    {
        set => SetProperty("fulfillment_code_hook", value);
    }

    /// <summary>
    /// Block for initial_response_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentInitialResponseSettingBlock>? InitialResponseSetting
    {
        set => SetProperty("initial_response_setting", value);
    }

    /// <summary>
    /// Block for input_context.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentInputContextBlock>? InputContext
    {
        set => SetProperty("input_context", value);
    }

    /// <summary>
    /// Block for kendra_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentKendraConfigurationBlock>? KendraConfiguration
    {
        set => SetProperty("kendra_configuration", value);
    }

    /// <summary>
    /// Block for output_context.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentOutputContextBlock>? OutputContext
    {
        set => SetProperty("output_context", value);
    }

    /// <summary>
    /// Block for sample_utterance.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentSampleUtteranceBlock>? SampleUtterance
    {
        set => SetProperty("sample_utterance", value);
    }

    /// <summary>
    /// Block for slot_priority.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsIntentSlotPriorityBlock>? SlotPriority
    {
        set => SetProperty("slot_priority", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexv2modelsIntentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The creation_date_time attribute.
    /// </summary>
    public TerraformExpression CreationDateTime => this["creation_date_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The intent_id attribute.
    /// </summary>
    public TerraformExpression IntentId => this["intent_id"];

    /// <summary>
    /// The last_updated_date_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedDateTime => this["last_updated_date_time"];

}

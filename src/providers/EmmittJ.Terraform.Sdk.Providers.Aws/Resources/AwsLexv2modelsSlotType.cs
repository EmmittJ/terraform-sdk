using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for composite_slot_type_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for external_source_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeExternalSourceSettingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for slot_type_values in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeSlotTypeValuesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTypeTimeoutsBlock : TerraformBlock
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
/// Block type for value_selection_setting in .
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeValueSelectionSettingBlock : TerraformBlock
{
    /// <summary>
    /// The resolution_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolutionStrategy is required")]
    public required TerraformProperty<string> ResolutionStrategy
    {
        set => SetProperty("resolution_strategy", value);
    }

}

/// <summary>
/// Manages a aws_lexv2models_slot_type resource.
/// </summary>
public class AwsLexv2modelsSlotType : TerraformResource
{
    public AwsLexv2modelsSlotType(string name) : base("aws_lexv2models_slot_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("slot_type_id");
        SetOutput("bot_id");
        SetOutput("bot_version");
        SetOutput("description");
        SetOutput("locale_id");
        SetOutput("name");
        SetOutput("parent_slot_type_signature");
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
    /// The parent_slot_type_signature attribute.
    /// </summary>
    public TerraformProperty<string> ParentSlotTypeSignature
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_slot_type_signature");
        set => SetProperty("parent_slot_type_signature", value);
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
    /// Block for composite_slot_type_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>? CompositeSlotTypeSetting
    {
        set => SetProperty("composite_slot_type_setting", value);
    }

    /// <summary>
    /// Block for external_source_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>? ExternalSourceSetting
    {
        set => SetProperty("external_source_setting", value);
    }

    /// <summary>
    /// Block for slot_type_values.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>? SlotTypeValues
    {
        set => SetProperty("slot_type_values", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexv2modelsSlotTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for value_selection_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>? ValueSelectionSetting
    {
        set => SetProperty("value_selection_setting", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public TerraformExpression SlotTypeId => this["slot_type_id"];

}

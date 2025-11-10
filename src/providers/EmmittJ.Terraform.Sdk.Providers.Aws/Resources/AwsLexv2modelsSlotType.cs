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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("resolution_strategy");
        set => WithProperty("resolution_strategy", value);
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
        this.DeclareOutput("id");
        this.DeclareOutput("slot_type_id");
    }

    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformProperty<string> BotId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bot_id");
        set => this.WithProperty("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformProperty<string> BotVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bot_version");
        set => this.WithProperty("bot_version", value);
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
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformProperty<string> LocaleId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("locale_id");
        set => this.WithProperty("locale_id", value);
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
    /// The parent_slot_type_signature attribute.
    /// </summary>
    public TerraformProperty<string>? ParentSlotTypeSignature
    {
        get => GetProperty<TerraformProperty<string>>("parent_slot_type_signature");
        set => this.WithProperty("parent_slot_type_signature", value);
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
    /// Block for composite_slot_type_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>? CompositeSlotTypeSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>>("composite_slot_type_setting");
        set => this.WithProperty("composite_slot_type_setting", value);
    }

    /// <summary>
    /// Block for external_source_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>? ExternalSourceSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>>("external_source_setting");
        set => this.WithProperty("external_source_setting", value);
    }

    /// <summary>
    /// Block for slot_type_values.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>? SlotTypeValues
    {
        get => GetProperty<List<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>>("slot_type_values");
        set => this.WithProperty("slot_type_values", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLexv2modelsSlotTypeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLexv2modelsSlotTypeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for value_selection_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>? ValueSelectionSetting
    {
        get => GetProperty<List<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>>("value_selection_setting");
        set => this.WithProperty("value_selection_setting", value);
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

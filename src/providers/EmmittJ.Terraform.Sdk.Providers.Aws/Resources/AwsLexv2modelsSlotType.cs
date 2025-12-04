using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for composite_slot_type_setting in AwsLexv2modelsSlotType.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "composite_slot_type_setting";

    /// <summary>
    /// SubSlots block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlockSubSlotsBlock>? SubSlots
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlockSubSlotsBlock>>("sub_slots");
        set => SetArgument("sub_slots", value);
    }

}

/// <summary>
/// Block type for sub_slots in AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlockSubSlotsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sub_slots";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotTypeId is required")]
    public required TerraformValue<string> SlotTypeId
    {
        get => GetArgument<TerraformValue<string>>("slot_type_id");
        set => SetArgument("slot_type_id", value);
    }

}


/// <summary>
/// Block type for external_source_setting in AwsLexv2modelsSlotType.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeExternalSourceSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_source_setting";

    /// <summary>
    /// GrammarSlotTypeSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlock>? GrammarSlotTypeSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlock>>("grammar_slot_type_setting");
        set => SetArgument("grammar_slot_type_setting", value);
    }

}

/// <summary>
/// Block type for grammar_slot_type_setting in AwsLexv2modelsSlotTypeExternalSourceSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grammar_slot_type_setting";

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlockSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeExternalSourceSettingBlockGrammarSlotTypeSettingBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    public required TerraformValue<string> KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_object_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3ObjectKey is required")]
    public required TerraformValue<string> S3ObjectKey
    {
        get => GetArgument<TerraformValue<string>>("s3_object_key");
        set => SetArgument("s3_object_key", value);
    }

}


/// <summary>
/// Block type for slot_type_values in AwsLexv2modelsSlotType.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeSlotTypeValuesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slot_type_values";

    /// <summary>
    /// SampleValue block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlockSampleValueBlock>? SampleValue
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlockSampleValueBlock>>("sample_value");
        set => SetArgument("sample_value", value);
    }

    /// <summary>
    /// Synonyms block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlockSynonymsBlock>? Synonyms
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlockSynonymsBlock>>("synonyms");
        set => SetArgument("synonyms", value);
    }

}

/// <summary>
/// Block type for sample_value in AwsLexv2modelsSlotTypeSlotTypeValuesBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeSlotTypeValuesBlockSampleValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sample_value";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for synonyms in AwsLexv2modelsSlotTypeSlotTypeValuesBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeSlotTypeValuesBlockSynonymsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "synonyms";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLexv2modelsSlotType.
/// Nesting mode: single
/// </summary>
public class AwsLexv2modelsSlotTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for value_selection_setting in AwsLexv2modelsSlotType.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeValueSelectionSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value_selection_setting";

    /// <summary>
    /// The resolution_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolutionStrategy is required")]
    public required TerraformValue<string> ResolutionStrategy
    {
        get => GetArgument<TerraformValue<string>>("resolution_strategy");
        set => SetArgument("resolution_strategy", value);
    }

    /// <summary>
    /// AdvancedRecognitionSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlockAdvancedRecognitionSettingBlock>? AdvancedRecognitionSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlockAdvancedRecognitionSettingBlock>>("advanced_recognition_setting");
        set => SetArgument("advanced_recognition_setting", value);
    }

    /// <summary>
    /// RegexFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlockRegexFilterBlock>? RegexFilter
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlockRegexFilterBlock>>("regex_filter");
        set => SetArgument("regex_filter", value);
    }

}

/// <summary>
/// Block type for advanced_recognition_setting in AwsLexv2modelsSlotTypeValueSelectionSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeValueSelectionSettingBlockAdvancedRecognitionSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_recognition_setting";

    /// <summary>
    /// The audio_recognition_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AudioRecognitionStrategy
    {
        get => GetArgument<TerraformValue<string>>("audio_recognition_strategy");
        set => SetArgument("audio_recognition_strategy", value);
    }

}

/// <summary>
/// Block type for regex_filter in AwsLexv2modelsSlotTypeValueSelectionSettingBlock.
/// Nesting mode: list
/// </summary>
public class AwsLexv2modelsSlotTypeValueSelectionSettingBlockRegexFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex_filter";

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}


/// <summary>
/// Represents a aws_lexv2models_slot_type Terraform resource.
/// Manages a aws_lexv2models_slot_type resource.
/// </summary>
public partial class AwsLexv2modelsSlotType(string name) : TerraformResource("aws_lexv2models_slot_type", name)
{
    /// <summary>
    /// The bot_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotId is required")]
    public required TerraformValue<string> BotId
    {
        get => GetArgument<TerraformValue<string>>("bot_id");
        set => SetArgument("bot_id", value);
    }

    /// <summary>
    /// The bot_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotVersion is required")]
    public required TerraformValue<string> BotVersion
    {
        get => GetArgument<TerraformValue<string>>("bot_version");
        set => SetArgument("bot_version", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The locale_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocaleId is required")]
    public required TerraformValue<string> LocaleId
    {
        get => GetArgument<TerraformValue<string>>("locale_id");
        set => SetArgument("locale_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent_slot_type_signature attribute.
    /// </summary>
    public TerraformValue<string>? ParentSlotTypeSignature
    {
        get => GetArgument<TerraformValue<string>>("parent_slot_type_signature");
        set => SetArgument("parent_slot_type_signature", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The slot_type_id attribute.
    /// </summary>
    public TerraformValue<string> SlotTypeId
        => AsReference("slot_type_id");

    /// <summary>
    /// CompositeSlotTypeSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>? CompositeSlotTypeSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeCompositeSlotTypeSettingBlock>>("composite_slot_type_setting");
        set => SetArgument("composite_slot_type_setting", value);
    }

    /// <summary>
    /// ExternalSourceSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>? ExternalSourceSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeExternalSourceSettingBlock>>("external_source_setting");
        set => SetArgument("external_source_setting", value);
    }

    /// <summary>
    /// SlotTypeValues block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>? SlotTypeValues
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeSlotTypeValuesBlock>>("slot_type_values");
        set => SetArgument("slot_type_values", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLexv2modelsSlotTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLexv2modelsSlotTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ValueSelectionSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>? ValueSelectionSetting
    {
        get => GetArgument<TerraformList<AwsLexv2modelsSlotTypeValueSelectionSettingBlock>>("value_selection_setting");
        set => SetArgument("value_selection_setting", value);
    }

}

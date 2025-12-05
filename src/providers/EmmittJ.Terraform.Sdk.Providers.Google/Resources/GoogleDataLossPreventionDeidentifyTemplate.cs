using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deidentify_config in GoogleDataLossPreventionDeidentifyTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deidentify_config";

    /// <summary>
    /// ImageTransformations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageTransformations block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlock>? ImageTransformations
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlock>>("image_transformations");
        set => SetArgument("image_transformations", value);
    }

    /// <summary>
    /// InfoTypeTransformations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoTypeTransformations block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlock>? InfoTypeTransformations
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlock>>("info_type_transformations");
        set => SetArgument("info_type_transformations", value);
    }

    /// <summary>
    /// RecordTransformations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordTransformations block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlock>? RecordTransformations
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlock>>("record_transformations");
        set => SetArgument("record_transformations", value);
    }

}

/// <summary>
/// Block type for image_transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_transformations";

    /// <summary>
    /// Transforms block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transforms is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Transforms block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock> Transforms
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock>>("transforms");
        set => SetArgument("transforms", value);
    }

}

/// <summary>
/// Block type for transforms in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transforms";

    /// <summary>
    /// AllInfoTypes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInfoTypes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllInfoTypesBlock>? AllInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllInfoTypesBlock>>("all_info_types");
        set => SetArgument("all_info_types", value);
    }

    /// <summary>
    /// AllText block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllText block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllTextBlock>? AllText
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllTextBlock>>("all_text");
        set => SetArgument("all_text", value);
    }

    /// <summary>
    /// RedactionColor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactionColor block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockRedactionColorBlock>? RedactionColor
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockRedactionColorBlock>>("redaction_color");
        set => SetArgument("redaction_color", value);
    }

    /// <summary>
    /// SelectedInfoTypes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedInfoTypes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlock>? SelectedInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlock>>("selected_info_types");
        set => SetArgument("selected_info_types", value);
    }

}

/// <summary>
/// Block type for all_info_types in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all_info_types";

}

/// <summary>
/// Block type for all_text in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockAllTextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all_text";

}

/// <summary>
/// Block type for redaction_color in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockRedactionColorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redaction_color";

    /// <summary>
    /// The amount of blue in the color as a value in the interval [0, 1].
    /// </summary>
    public TerraformValue<double>? Blue
    {
        get => GetArgument<TerraformValue<double>>("blue");
        set => SetArgument("blue", value);
    }

    /// <summary>
    /// The amount of green in the color as a value in the interval [0, 1].
    /// </summary>
    public TerraformValue<double>? Green
    {
        get => GetArgument<TerraformValue<double>>("green");
        set => SetArgument("green", value);
    }

    /// <summary>
    /// The amount of red in the color as a value in the interval [0, 1].
    /// </summary>
    public TerraformValue<double>? Red
    {
        get => GetArgument<TerraformValue<double>>("red");
        set => SetArgument("red", value);
    }

}

/// <summary>
/// Block type for selected_info_types in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_info_types";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoTypes block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlock> InfoTypes
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockImageTransformationsBlockTransformsBlockSelectedInfoTypesBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for info_type_transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type_transformations";

    /// <summary>
    /// Transformations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transformations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Transformations block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlock> Transformations
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlock>>("transformations");
        set => SetArgument("transformations", value);
    }

}

/// <summary>
/// Block type for transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformations";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock>? InfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// PrimitiveTransformation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimitiveTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrimitiveTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimitiveTransformation block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock> PrimitiveTransformation
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock>>("primitive_transformation");
        set => SetArgument("primitive_transformation", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for primitive_transformation in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primitive_transformation";

    /// <summary>
    /// Replace each matching finding with the name of the info type.
    /// </summary>
    public TerraformValue<bool>? ReplaceWithInfoTypeConfig
    {
        get => GetArgument<TerraformValue<bool>>("replace_with_info_type_config");
        set => SetArgument("replace_with_info_type_config", value);
    }

    /// <summary>
    /// BucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>? BucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>>("bucketing_config");
        set => SetArgument("bucketing_config", value);
    }

    /// <summary>
    /// CharacterMaskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CharacterMaskConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>? CharacterMaskConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>>("character_mask_config");
        set => SetArgument("character_mask_config", value);
    }

    /// <summary>
    /// CryptoDeterministicConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoDeterministicConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>? CryptoDeterministicConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>>("crypto_deterministic_config");
        set => SetArgument("crypto_deterministic_config", value);
    }

    /// <summary>
    /// CryptoHashConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoHashConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>? CryptoHashConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>>("crypto_hash_config");
        set => SetArgument("crypto_hash_config", value);
    }

    /// <summary>
    /// CryptoReplaceFfxFpeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoReplaceFfxFpeConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>? CryptoReplaceFfxFpeConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>>("crypto_replace_ffx_fpe_config");
        set => SetArgument("crypto_replace_ffx_fpe_config", value);
    }

    /// <summary>
    /// DateShiftConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateShiftConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>? DateShiftConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>>("date_shift_config");
        set => SetArgument("date_shift_config", value);
    }

    /// <summary>
    /// FixedSizeBucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedSizeBucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>? FixedSizeBucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>>("fixed_size_bucketing_config");
        set => SetArgument("fixed_size_bucketing_config", value);
    }

    /// <summary>
    /// RedactConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>? RedactConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>>("redact_config");
        set => SetArgument("redact_config", value);
    }

    /// <summary>
    /// ReplaceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>? ReplaceConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>>("replace_config");
        set => SetArgument("replace_config", value);
    }

    /// <summary>
    /// ReplaceDictionaryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceDictionaryConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>? ReplaceDictionaryConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>>("replace_dictionary_config");
        set => SetArgument("replace_dictionary_config", value);
    }

    /// <summary>
    /// TimePartConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>? TimePartConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>>("time_part_config");
        set => SetArgument("time_part_config", value);
    }

}

/// <summary>
/// Block type for bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucketing_config";

    /// <summary>
    /// Buckets block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock>? Buckets
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock>>("buckets");
        set => SetArgument("buckets", value);
    }

}

/// <summary>
/// Block type for buckets in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "buckets";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Max block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Min block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>? Min
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>>("min");
        set => SetArgument("min", value);
    }

    /// <summary>
    /// ReplacementValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplacementValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplacementValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplacementValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock> ReplacementValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock>>("replacement_value");
        set => SetArgument("replacement_value", value);
    }

}

/// <summary>
/// Block type for max in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for min in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "min";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replacement_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replacement_value";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for character_mask_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "character_mask_config";

    /// <summary>
    /// Character to use to mask the sensitive values—for example, * for an alphabetic string such as a name, or 0 for a numeric string
    /// such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to * for
    /// strings, and 0 for digits.
    /// </summary>
    public TerraformValue<string>? MaskingCharacter
    {
        get => GetArgument<TerraformValue<string>>("masking_character");
        set => SetArgument("masking_character", value);
    }

    /// <summary>
    /// Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.
    /// </summary>
    public TerraformValue<double>? NumberToMask
    {
        get => GetArgument<TerraformValue<double>>("number_to_mask");
        set => SetArgument("number_to_mask", value);
    }

    /// <summary>
    /// Mask characters in reverse order. For example, if masking_character is 0, number_to_mask is 14, and reverse_order is &#39;false&#39;, then the
    /// input string &#39;1234-5678-9012-3456&#39; is masked as &#39;00000000000000-3456&#39;.
    /// </summary>
    public TerraformValue<bool>? ReverseOrder
    {
        get => GetArgument<TerraformValue<bool>>("reverse_order");
        set => SetArgument("reverse_order", value);
    }

    /// <summary>
    /// CharactersToIgnore block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>? CharactersToIgnore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>>("characters_to_ignore");
        set => SetArgument("characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for characters_to_ignore in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "characters_to_ignore";

    /// <summary>
    /// Characters to not transform when masking.
    /// </summary>
    public TerraformValue<string>? CharactersToSkip
    {
        get => GetArgument<TerraformValue<string>>("characters_to_skip");
        set => SetArgument("characters_to_skip", value);
    }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: [&amp;quot;NUMERIC&amp;quot;, &amp;quot;ALPHA_UPPER_CASE&amp;quot;, &amp;quot;ALPHA_LOWER_CASE&amp;quot;, &amp;quot;PUNCTUATION&amp;quot;, &amp;quot;WHITESPACE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonCharactersToIgnore
    {
        get => GetArgument<TerraformValue<string>>("common_characters_to_ignore");
        set => SetArgument("common_characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for crypto_deterministic_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_deterministic_config";

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock>? SurrogateInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for crypto_hash_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_hash_config";

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for crypto_replace_ffx_fpe_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_replace_ffx_fpe_config";

    /// <summary>
    /// Common alphabets. Possible values: [&amp;quot;FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED&amp;quot;, &amp;quot;NUMERIC&amp;quot;, &amp;quot;HEXADECIMAL&amp;quot;, &amp;quot;UPPER_CASE_ALPHA_NUMERIC&amp;quot;, &amp;quot;ALPHA_NUMERIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonAlphabet
    {
        get => GetArgument<TerraformValue<string>>("common_alphabet");
        set => SetArgument("common_alphabet", value);
    }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range \[2, 95\]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 
    /// &#39;&#39;0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~&#39;!@#$%^&amp;amp;*()_-+={[}]|:;&amp;quot;&#39;&amp;lt;,&amp;gt;.?/&#39;&#39;
    /// </summary>
    public TerraformValue<string>? CustomAlphabet
    {
        get => GetArgument<TerraformValue<string>>("custom_alphabet");
        set => SetArgument("custom_alphabet", value);
    }

    /// <summary>
    /// The native way to select the alphabet. Must be in the range \[2, 95\].
    /// </summary>
    public TerraformValue<double>? Radix
    {
        get => GetArgument<TerraformValue<double>>("radix");
        set => SetArgument("radix", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>? SurrogateInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for date_shift_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_shift_config";

    /// <summary>
    /// Range of shift in days. Negative means shift to earlier in time.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBoundDays is required")]
    public required TerraformValue<double> LowerBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_bound_days");
        set => SetArgument("lower_bound_days", value);
    }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBoundDays is required")]
    public required TerraformValue<double> UpperBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_bound_days");
        set => SetArgument("upper_bound_days", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for fixed_size_bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_size_bucketing_config";

    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketSize is required")]
    public required TerraformValue<double> BucketSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("bucket_size");
        set => SetArgument("bucket_size", value);
    }

    /// <summary>
    /// LowerBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LowerBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LowerBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock> LowerBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock>>("lower_bound");
        set => SetArgument("lower_bound", value);
    }

    /// <summary>
    /// UpperBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UpperBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpperBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock> UpperBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock>>("upper_bound");
        set => SetArgument("upper_bound", value);
    }

}

/// <summary>
/// Block type for lower_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lower_bound";

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

}

/// <summary>
/// Block type for upper_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upper_bound";

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

}

/// <summary>
/// Block type for redact_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redact_config";

}

/// <summary>
/// Block type for replace_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_config";

    /// <summary>
    /// NewValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NewValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NewValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock> NewValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock>>("new_value");
        set => SetArgument("new_value", value);
    }

}

/// <summary>
/// Block type for new_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value.
    /// </summary>
    public TerraformValue<double>? IntegerValue
    {
        get => GetArgument<TerraformValue<double>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replace_dictionary_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_dictionary_config";

    /// <summary>
    /// WordList block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WordList is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WordList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock> WordList
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for time_part_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_part_config";

    /// <summary>
    /// The part of the time to keep. Possible values: [&amp;quot;YEAR&amp;quot;, &amp;quot;MONTH&amp;quot;, &amp;quot;DAY_OF_MONTH&amp;quot;, &amp;quot;DAY_OF_WEEK&amp;quot;, &amp;quot;WEEK_OF_YEAR&amp;quot;, &amp;quot;HOUR_OF_DAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PartToExtract
    {
        get => GetArgument<TerraformValue<string>>("part_to_extract");
        set => SetArgument("part_to_extract", value);
    }

}

/// <summary>
/// Block type for record_transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_transformations";

    /// <summary>
    /// FieldTransformations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock>? FieldTransformations
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock>>("field_transformations");
        set => SetArgument("field_transformations", value);
    }

    /// <summary>
    /// RecordSuppressions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlock>? RecordSuppressions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlock>>("record_suppressions");
        set => SetArgument("record_suppressions", value);
    }

}

/// <summary>
/// Block type for field_transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_transformations";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Fields block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fields is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fields block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockFieldsBlock> Fields
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockFieldsBlock>>("fields");
        set => SetArgument("fields", value);
    }

    /// <summary>
    /// InfoTypeTransformations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoTypeTransformations block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlock>? InfoTypeTransformations
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlock>>("info_type_transformations");
        set => SetArgument("info_type_transformations", value);
    }

    /// <summary>
    /// PrimitiveTransformation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimitiveTransformation block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock>? PrimitiveTransformation
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock>>("primitive_transformation");
        set => SetArgument("primitive_transformation", value);
    }

}

/// <summary>
/// Block type for condition in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Expressions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expressions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlock>? Expressions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlock>>("expressions");
        set => SetArgument("expressions", value);
    }

}

/// <summary>
/// Block type for expressions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expressions";

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LogicalOperator
    {
        get => GetArgument<TerraformValue<string>>("logical_operator");
        set => SetArgument("logical_operator", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Operator used to compare the field or infoType to the value. Possible values: [&amp;quot;EQUAL_TO&amp;quot;, &amp;quot;NOT_EQUAL_TO&amp;quot;, &amp;quot;GREATER_THAN&amp;quot;, &amp;quot;LESS_THAN&amp;quot;, &amp;quot;GREATER_THAN_OR_EQUALS&amp;quot;, &amp;quot;LESS_THAN_OR_EQUALS&amp;quot;, &amp;quot;EXISTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// Field block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Field block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Field block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock> Field
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for field in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for fields in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockFieldsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fields";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for info_type_transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type_transformations";

    /// <summary>
    /// Transformations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Transformations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Transformations block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlock> Transformations
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlock>>("transformations");
        set => SetArgument("transformations", value);
    }

}

/// <summary>
/// Block type for transformations in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformations";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock>? InfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// PrimitiveTransformation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimitiveTransformation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrimitiveTransformation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimitiveTransformation block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock> PrimitiveTransformation
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock>>("primitive_transformation");
        set => SetArgument("primitive_transformation", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for primitive_transformation in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primitive_transformation";

    /// <summary>
    /// BucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>? BucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>>("bucketing_config");
        set => SetArgument("bucketing_config", value);
    }

    /// <summary>
    /// CharacterMaskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CharacterMaskConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>? CharacterMaskConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>>("character_mask_config");
        set => SetArgument("character_mask_config", value);
    }

    /// <summary>
    /// CryptoDeterministicConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoDeterministicConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>? CryptoDeterministicConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>>("crypto_deterministic_config");
        set => SetArgument("crypto_deterministic_config", value);
    }

    /// <summary>
    /// CryptoHashConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoHashConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>? CryptoHashConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>>("crypto_hash_config");
        set => SetArgument("crypto_hash_config", value);
    }

    /// <summary>
    /// CryptoReplaceFfxFpeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoReplaceFfxFpeConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>? CryptoReplaceFfxFpeConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>>("crypto_replace_ffx_fpe_config");
        set => SetArgument("crypto_replace_ffx_fpe_config", value);
    }

    /// <summary>
    /// DateShiftConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateShiftConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>? DateShiftConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>>("date_shift_config");
        set => SetArgument("date_shift_config", value);
    }

    /// <summary>
    /// FixedSizeBucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedSizeBucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>? FixedSizeBucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>>("fixed_size_bucketing_config");
        set => SetArgument("fixed_size_bucketing_config", value);
    }

    /// <summary>
    /// RedactConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>? RedactConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>>("redact_config");
        set => SetArgument("redact_config", value);
    }

    /// <summary>
    /// ReplaceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>? ReplaceConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>>("replace_config");
        set => SetArgument("replace_config", value);
    }

    /// <summary>
    /// ReplaceDictionaryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceDictionaryConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>? ReplaceDictionaryConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>>("replace_dictionary_config");
        set => SetArgument("replace_dictionary_config", value);
    }

    /// <summary>
    /// ReplaceWithInfoTypeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceWithInfoTypeConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceWithInfoTypeConfigBlock>? ReplaceWithInfoTypeConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceWithInfoTypeConfigBlock>>("replace_with_info_type_config");
        set => SetArgument("replace_with_info_type_config", value);
    }

    /// <summary>
    /// TimePartConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>? TimePartConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>>("time_part_config");
        set => SetArgument("time_part_config", value);
    }

}

/// <summary>
/// Block type for bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucketing_config";

    /// <summary>
    /// Buckets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Buckets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Buckets block(s) required")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock> Buckets
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock>>("buckets");
        set => SetArgument("buckets", value);
    }

}

/// <summary>
/// Block type for buckets in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "buckets";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Max block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Min block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>? Min
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>>("min");
        set => SetArgument("min", value);
    }

    /// <summary>
    /// ReplacementValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplacementValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplacementValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplacementValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock> ReplacementValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock>>("replacement_value");
        set => SetArgument("replacement_value", value);
    }

}

/// <summary>
/// Block type for max in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for min in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "min";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replacement_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replacement_value";

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for character_mask_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "character_mask_config";

    /// <summary>
    /// Character to use to mask the sensitive values—for example, * for an alphabetic string such as a name, or 0 for a numeric string
    /// such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to * for
    /// strings, and 0 for digits.
    /// </summary>
    public TerraformValue<string>? MaskingCharacter
    {
        get => GetArgument<TerraformValue<string>>("masking_character");
        set => SetArgument("masking_character", value);
    }

    /// <summary>
    /// Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.
    /// If number_to_mask is negative, this denotes inverse masking. Cloud DLP masks all but a number of characters. For example, suppose you have the following values:
    /// - &#39;masking_character&#39; is *
    /// - &#39;number_to_mask&#39; is -4
    /// - &#39;reverse_order&#39; is false
    /// - &#39;characters_to_ignore&#39; includes -
    /// - Input string is 1234-5678-9012-3456
    /// 
    /// The resulting de-identified string is ****-****-****-3456. Cloud DLP masks all but the last four characters. If reverseOrder is true, all but the first four characters are masked as 1234-****-****-****.
    /// </summary>
    public TerraformValue<double>? NumberToMask
    {
        get => GetArgument<TerraformValue<double>>("number_to_mask");
        set => SetArgument("number_to_mask", value);
    }

    /// <summary>
    /// Mask characters in reverse order. For example, if masking_character is 0, number_to_mask is 14, and reverse_order is &#39;false&#39;, then the
    /// input string &#39;1234-5678-9012-3456&#39; is masked as &#39;00000000000000-3456&#39;.
    /// </summary>
    public TerraformValue<bool>? ReverseOrder
    {
        get => GetArgument<TerraformValue<bool>>("reverse_order");
        set => SetArgument("reverse_order", value);
    }

    /// <summary>
    /// CharactersToIgnore block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>? CharactersToIgnore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>>("characters_to_ignore");
        set => SetArgument("characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for characters_to_ignore in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "characters_to_ignore";

    /// <summary>
    /// Characters to not transform when masking. Only one of this or &#39;common_characters_to_ignore&#39; must be specified.
    /// </summary>
    public TerraformValue<string>? CharactersToSkip
    {
        get => GetArgument<TerraformValue<string>>("characters_to_skip");
        set => SetArgument("characters_to_skip", value);
    }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation. Only one of this or &#39;characters_to_skip&#39; must be specified. Possible values: [&amp;quot;NUMERIC&amp;quot;, &amp;quot;ALPHA_UPPER_CASE&amp;quot;, &amp;quot;ALPHA_LOWER_CASE&amp;quot;, &amp;quot;PUNCTUATION&amp;quot;, &amp;quot;WHITESPACE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonCharactersToIgnore
    {
        get => GetArgument<TerraformValue<string>>("common_characters_to_ignore");
        set => SetArgument("common_characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for crypto_deterministic_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_deterministic_config";

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CryptoKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock> CryptoKey
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SurrogateInfoType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SurrogateInfoType block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock> SurrogateInfoType
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for crypto_hash_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_hash_config";

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CryptoKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock> CryptoKey
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for crypto_replace_ffx_fpe_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_replace_ffx_fpe_config";

    /// <summary>
    /// Common alphabets. Only one of this, &#39;custom_alphabet&#39; or &#39;radix&#39; must be specified. Possible values: [&amp;quot;NUMERIC&amp;quot;, &amp;quot;HEXADECIMAL&amp;quot;, &amp;quot;UPPER_CASE_ALPHA_NUMERIC&amp;quot;, &amp;quot;ALPHA_NUMERIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonAlphabet
    {
        get => GetArgument<TerraformValue<string>>("common_alphabet");
        set => SetArgument("common_alphabet", value);
    }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range \[2, 95\]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 
    /// &#39;&#39;0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~&#39;!@#$%^&amp;amp;*()_-+={[}]|:;&amp;quot;&#39;&amp;lt;,&amp;gt;.?/&#39;&#39;. Only one of this, &#39;common_alphabet&#39; or &#39;radix&#39; must be specified.
    /// </summary>
    public TerraformValue<string>? CustomAlphabet
    {
        get => GetArgument<TerraformValue<string>>("custom_alphabet");
        set => SetArgument("custom_alphabet", value);
    }

    /// <summary>
    /// The native way to select the alphabet. Must be in the range \[2, 95\]. Only one of this, &#39;custom_alphabet&#39; or &#39;common_alphabet&#39; must be specified.
    /// </summary>
    public TerraformValue<double>? Radix
    {
        get => GetArgument<TerraformValue<double>>("radix");
        set => SetArgument("radix", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CryptoKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock> CryptoKey
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>? SurrogateInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for date_shift_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_shift_config";

    /// <summary>
    /// For example, -5 means shift date to at most 5 days back in the past.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBoundDays is required")]
    public required TerraformValue<double> LowerBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_bound_days");
        set => SetArgument("lower_bound_days", value);
    }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// 
    /// For example, 3 means shift date to at most 3 days into the future.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBoundDays is required")]
    public required TerraformValue<double> UpperBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_bound_days");
        set => SetArgument("upper_bound_days", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for fixed_size_bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_size_bucketing_config";

    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketSize is required")]
    public required TerraformValue<double> BucketSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("bucket_size");
        set => SetArgument("bucket_size", value);
    }

    /// <summary>
    /// LowerBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LowerBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LowerBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock> LowerBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock>>("lower_bound");
        set => SetArgument("lower_bound", value);
    }

    /// <summary>
    /// UpperBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UpperBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpperBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock> UpperBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock>>("upper_bound");
        set => SetArgument("upper_bound", value);
    }

}

/// <summary>
/// Block type for lower_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lower_bound";

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

}

/// <summary>
/// Block type for upper_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upper_bound";

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

}

/// <summary>
/// Block type for redact_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redact_config";

}

/// <summary>
/// Block type for replace_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_config";

    /// <summary>
    /// NewValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NewValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NewValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock> NewValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock>>("new_value");
        set => SetArgument("new_value", value);
    }

}

/// <summary>
/// Block type for new_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replace_dictionary_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_dictionary_config";

    /// <summary>
    /// WordList block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WordList is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WordList block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock> WordList
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for replace_with_info_type_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockReplaceWithInfoTypeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_with_info_type_config";

}

/// <summary>
/// Block type for time_part_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockInfoTypeTransformationsBlockTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_part_config";

    /// <summary>
    /// The part of the time to keep. Possible values: [&amp;quot;YEAR&amp;quot;, &amp;quot;MONTH&amp;quot;, &amp;quot;DAY_OF_MONTH&amp;quot;, &amp;quot;DAY_OF_WEEK&amp;quot;, &amp;quot;WEEK_OF_YEAR&amp;quot;, &amp;quot;HOUR_OF_DAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartToExtract is required")]
    public required TerraformValue<string> PartToExtract
    {
        get => GetRequiredArgument<TerraformValue<string>>("part_to_extract");
        set => SetArgument("part_to_extract", value);
    }

}

/// <summary>
/// Block type for primitive_transformation in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primitive_transformation";

    /// <summary>
    /// BucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>? BucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock>>("bucketing_config");
        set => SetArgument("bucketing_config", value);
    }

    /// <summary>
    /// CharacterMaskConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CharacterMaskConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>? CharacterMaskConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock>>("character_mask_config");
        set => SetArgument("character_mask_config", value);
    }

    /// <summary>
    /// CryptoDeterministicConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoDeterministicConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>? CryptoDeterministicConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock>>("crypto_deterministic_config");
        set => SetArgument("crypto_deterministic_config", value);
    }

    /// <summary>
    /// CryptoHashConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoHashConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>? CryptoHashConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock>>("crypto_hash_config");
        set => SetArgument("crypto_hash_config", value);
    }

    /// <summary>
    /// CryptoReplaceFfxFpeConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoReplaceFfxFpeConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>? CryptoReplaceFfxFpeConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock>>("crypto_replace_ffx_fpe_config");
        set => SetArgument("crypto_replace_ffx_fpe_config", value);
    }

    /// <summary>
    /// DateShiftConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateShiftConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>? DateShiftConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock>>("date_shift_config");
        set => SetArgument("date_shift_config", value);
    }

    /// <summary>
    /// FixedSizeBucketingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedSizeBucketingConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>? FixedSizeBucketingConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock>>("fixed_size_bucketing_config");
        set => SetArgument("fixed_size_bucketing_config", value);
    }

    /// <summary>
    /// RedactConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedactConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>? RedactConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock>>("redact_config");
        set => SetArgument("redact_config", value);
    }

    /// <summary>
    /// ReplaceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>? ReplaceConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock>>("replace_config");
        set => SetArgument("replace_config", value);
    }

    /// <summary>
    /// ReplaceDictionaryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplaceDictionaryConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>? ReplaceDictionaryConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock>>("replace_dictionary_config");
        set => SetArgument("replace_dictionary_config", value);
    }

    /// <summary>
    /// TimePartConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimePartConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>? TimePartConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock>>("time_part_config");
        set => SetArgument("time_part_config", value);
    }

}

/// <summary>
/// Block type for bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucketing_config";

    /// <summary>
    /// Buckets block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock>? Buckets
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock>>("buckets");
        set => SetArgument("buckets", value);
    }

}

/// <summary>
/// Block type for buckets in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "buckets";

    /// <summary>
    /// Max block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Max block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>? Max
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Min block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>? Min
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock>>("min");
        set => SetArgument("min", value);
    }

    /// <summary>
    /// ReplacementValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplacementValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReplacementValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplacementValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock> ReplacementValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock>>("replacement_value");
        set => SetArgument("replacement_value", value);
    }

}

/// <summary>
/// Block type for max in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMaxBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for min in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "min";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockMinBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replacement_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replacement_value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockBucketingConfigBlockBucketsBlockReplacementValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for character_mask_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "character_mask_config";

    /// <summary>
    /// Character to use to mask the sensitive values—for example, * for an alphabetic string such as a name, or 0 for a numeric string
    /// such as ZIP code or credit card number. This string must have a length of 1. If not supplied, this value defaults to * for
    /// strings, and 0 for digits.
    /// </summary>
    public TerraformValue<string>? MaskingCharacter
    {
        get => GetArgument<TerraformValue<string>>("masking_character");
        set => SetArgument("masking_character", value);
    }

    /// <summary>
    /// Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count towards this tally.
    /// If number_to_mask is negative, this denotes inverse masking. Cloud DLP masks all but a number of characters. For example, suppose you have the following values:
    /// - &#39;masking_character&#39; is *
    /// - &#39;number_to_mask&#39; is -4
    /// - &#39;reverse_order&#39; is false
    /// - &#39;characters_to_ignore&#39; includes -
    /// - Input string is 1234-5678-9012-3456
    /// 
    /// The resulting de-identified string is ****-****-****-3456. Cloud DLP masks all but the last four characters. If reverseOrder is true, all but the first four characters are masked as 1234-****-****-****.
    /// </summary>
    public TerraformValue<double>? NumberToMask
    {
        get => GetArgument<TerraformValue<double>>("number_to_mask");
        set => SetArgument("number_to_mask", value);
    }

    /// <summary>
    /// Mask characters in reverse order. For example, if masking_character is 0, number_to_mask is 14, and reverse_order is &#39;false&#39;, then the
    /// input string &#39;1234-5678-9012-3456&#39; is masked as &#39;00000000000000-3456&#39;.
    /// </summary>
    public TerraformValue<bool>? ReverseOrder
    {
        get => GetArgument<TerraformValue<bool>>("reverse_order");
        set => SetArgument("reverse_order", value);
    }

    /// <summary>
    /// CharactersToIgnore block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>? CharactersToIgnore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock>>("characters_to_ignore");
        set => SetArgument("characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for characters_to_ignore in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCharacterMaskConfigBlockCharactersToIgnoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "characters_to_ignore";

    /// <summary>
    /// Characters to not transform when masking.
    /// </summary>
    public TerraformValue<string>? CharactersToSkip
    {
        get => GetArgument<TerraformValue<string>>("characters_to_skip");
        set => SetArgument("characters_to_skip", value);
    }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation. Possible values: [&amp;quot;NUMERIC&amp;quot;, &amp;quot;ALPHA_UPPER_CASE&amp;quot;, &amp;quot;ALPHA_LOWER_CASE&amp;quot;, &amp;quot;PUNCTUATION&amp;quot;, &amp;quot;WHITESPACE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonCharactersToIgnore
    {
        get => GetArgument<TerraformValue<string>>("common_characters_to_ignore");
        set => SetArgument("common_characters_to_ignore", value);
    }

}

/// <summary>
/// Block type for crypto_deterministic_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_deterministic_config";

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock>? SurrogateInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoDeterministicConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for crypto_hash_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_hash_config";

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoHashConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for crypto_replace_ffx_fpe_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_replace_ffx_fpe_config";

    /// <summary>
    /// Common alphabets. Possible values: [&amp;quot;FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED&amp;quot;, &amp;quot;NUMERIC&amp;quot;, &amp;quot;HEXADECIMAL&amp;quot;, &amp;quot;UPPER_CASE_ALPHA_NUMERIC&amp;quot;, &amp;quot;ALPHA_NUMERIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CommonAlphabet
    {
        get => GetArgument<TerraformValue<string>>("common_alphabet");
        set => SetArgument("common_alphabet", value);
    }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range \[2, 95\]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 
    /// &#39;&#39;0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~&#39;!@#$%^&amp;amp;*()_-+={[}]|:;&amp;quot;&#39;&amp;lt;,&amp;gt;.?/&#39;&#39;
    /// </summary>
    public TerraformValue<string>? CustomAlphabet
    {
        get => GetArgument<TerraformValue<string>>("custom_alphabet");
        set => SetArgument("custom_alphabet", value);
    }

    /// <summary>
    /// The native way to select the alphabet. Must be in the range \[2, 95\].
    /// </summary>
    public TerraformValue<double>? Radix
    {
        get => GetArgument<TerraformValue<double>>("radix");
        set => SetArgument("radix", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

    /// <summary>
    /// SurrogateInfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateInfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>? SurrogateInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock>>("surrogate_info_type");
        set => SetArgument("surrogate_info_type", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for surrogate_info_type in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed at [https://cloud.google.com/dlp/docs/infotypes-reference](https://cloud.google.com/dlp/docs/infotypes-reference) when specifying a built-in type. When sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern &#39;[A-Za-z0-9$-_]{1,64}&#39;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Optional version name for this InfoType.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockCryptoReplaceFfxFpeConfigBlockSurrogateInfoTypeBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for date_shift_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_shift_config";

    /// <summary>
    /// For example, -5 means shift date to at most 5 days back in the past.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBoundDays is required")]
    public required TerraformValue<double> LowerBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("lower_bound_days");
        set => SetArgument("lower_bound_days", value);
    }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// 
    /// For example, 3 means shift date to at most 3 days into the future.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBoundDays is required")]
    public required TerraformValue<double> UpperBoundDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("upper_bound_days");
        set => SetArgument("upper_bound_days", value);
    }

    /// <summary>
    /// Context block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Context block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>? Context
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// CryptoKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKey block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>? CryptoKey
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock>>("crypto_key");
        set => SetArgument("crypto_key", value);
    }

}

/// <summary>
/// Block type for context in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "context";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for crypto_key in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crypto_key";

    /// <summary>
    /// KmsWrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsWrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>? KmsWrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock>>("kms_wrapped");
        set => SetArgument("kms_wrapped", value);
    }

    /// <summary>
    /// Transient block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Transient block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>? Transient
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock>>("transient");
        set => SetArgument("transient", value);
    }

    /// <summary>
    /// Unwrapped block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Unwrapped block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>? Unwrapped
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock>>("unwrapped");
        set => SetArgument("unwrapped", value);
    }

}

/// <summary>
/// Block type for kms_wrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockKmsWrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_wrapped";

    /// <summary>
    /// The resource name of the KMS CryptoKey to use for unwrapping.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyName is required")]
    public required TerraformValue<string> CryptoKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("crypto_key_name");
        set => SetArgument("crypto_key_name", value);
    }

    /// <summary>
    /// The wrapped data crypto key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WrappedKey is required")]
    public required TerraformValue<string> WrappedKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("wrapped_key");
        set => SetArgument("wrapped_key", value);
    }

}

/// <summary>
/// Block type for transient in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockTransientBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transient";

    /// <summary>
    /// Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate &#39;TransientCryptoKey&#39; protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for unwrapped in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockDateShiftConfigBlockCryptoKeyBlockUnwrappedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "unwrapped";

    /// <summary>
    /// A 128/192/256 bit key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

}

/// <summary>
/// Block type for fixed_size_bucketing_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_size_bucketing_config";

    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketSize is required")]
    public required TerraformValue<double> BucketSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("bucket_size");
        set => SetArgument("bucket_size", value);
    }

    /// <summary>
    /// LowerBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LowerBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LowerBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LowerBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock> LowerBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock>>("lower_bound");
        set => SetArgument("lower_bound", value);
    }

    /// <summary>
    /// UpperBound block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UpperBound is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UpperBound block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpperBound block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock> UpperBound
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock>>("upper_bound");
        set => SetArgument("upper_bound", value);
    }

}

/// <summary>
/// Block type for lower_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lower_bound";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockLowerBoundBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for upper_bound in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upper_bound";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockFixedSizeBucketingConfigBlockUpperBoundBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for redact_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockRedactConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redact_config";

}

/// <summary>
/// Block type for replace_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_config";

    /// <summary>
    /// NewValue block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NewValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NewValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NewValue block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock> NewValue
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock>>("new_value");
        set => SetArgument("new_value", value);
    }

}

/// <summary>
/// Block type for new_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "new_value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceConfigBlockNewValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for replace_dictionary_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replace_dictionary_config";

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockReplaceDictionaryConfigBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for time_part_config in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockFieldTransformationsBlockPrimitiveTransformationBlockTimePartConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_part_config";

    /// <summary>
    /// The part of the time to keep. Possible values: [&amp;quot;YEAR&amp;quot;, &amp;quot;MONTH&amp;quot;, &amp;quot;DAY_OF_MONTH&amp;quot;, &amp;quot;DAY_OF_WEEK&amp;quot;, &amp;quot;WEEK_OF_YEAR&amp;quot;, &amp;quot;HOUR_OF_DAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PartToExtract
    {
        get => GetArgument<TerraformValue<string>>("part_to_extract");
        set => SetArgument("part_to_extract", value);
    }

}

/// <summary>
/// Block type for record_suppressions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_suppressions";

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}

/// <summary>
/// Block type for condition in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Expressions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expressions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlock>? Expressions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlock>>("expressions");
        set => SetArgument("expressions", value);
    }

}

/// <summary>
/// Block type for expressions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expressions";

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND. Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LogicalOperator
    {
        get => GetArgument<TerraformValue<string>>("logical_operator");
        set => SetArgument("logical_operator", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Operator used to compare the field or infoType to the value. Possible values: [&amp;quot;EQUAL_TO&amp;quot;, &amp;quot;NOT_EQUAL_TO&amp;quot;, &amp;quot;GREATER_THAN&amp;quot;, &amp;quot;LESS_THAN&amp;quot;, &amp;quot;GREATER_THAN_OR_EQUALS&amp;quot;, &amp;quot;LESS_THAN_OR_EQUALS&amp;quot;, &amp;quot;EXISTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// Field block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Field block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Field block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock> Field
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for field in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// Name describing the field.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// A boolean value.
    /// </summary>
    public TerraformValue<bool>? BooleanValue
    {
        get => GetArgument<TerraformValue<bool>>("boolean_value");
        set => SetArgument("boolean_value", value);
    }

    /// <summary>
    /// Represents a day of the week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DayOfWeekValue
    {
        get => GetArgument<TerraformValue<string>>("day_of_week_value");
        set => SetArgument("day_of_week_value", value);
    }

    /// <summary>
    /// A float value.
    /// </summary>
    public TerraformValue<double>? FloatValue
    {
        get => GetArgument<TerraformValue<double>>("float_value");
        set => SetArgument("float_value", value);
    }

    /// <summary>
    /// An integer value (int64 format)
    /// </summary>
    public TerraformValue<string>? IntegerValue
    {
        get => GetArgument<TerraformValue<string>>("integer_value");
        set => SetArgument("integer_value", value);
    }

    /// <summary>
    /// A string value.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? TimestampValue
    {
        get => GetArgument<TerraformValue<string>>("timestamp_value");
        set => SetArgument("timestamp_value", value);
    }

    /// <summary>
    /// DateValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DateValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock>? DateValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// TimeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimeValue block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock>? TimeValue
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock>>("time_value");
        set => SetArgument("time_value", value);
    }

}

/// <summary>
/// Block type for date_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockDateValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "date_value";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time_value in GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlockRecordTransformationsBlockRecordSuppressionsBlockConditionBlockExpressionsBlockConditionsBlockConditionsBlockValueBlockTimeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time_value";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataLossPreventionDeidentifyTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_loss_prevention_deidentify_template Terraform resource.
/// Manages a google_data_loss_prevention_deidentify_template resource.
/// </summary>
public partial class GoogleDataLossPreventionDeidentifyTemplate(string name) : TerraformResource("google_data_loss_prevention_deidentify_template", name)
{
    /// <summary>
    /// A description of the template.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User set display name of the template.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent of the template in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformValue<string> TemplateId
    {
        get => GetArgument<TerraformValue<string>>("template_id") ?? CreateReference("template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The creation timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The resource name of the template. Set by the server.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The last update timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// DeidentifyConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeidentifyConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeidentifyConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeidentifyConfig block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock> DeidentifyConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock>>("deidentify_config");
        set => SetArgument("deidentify_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

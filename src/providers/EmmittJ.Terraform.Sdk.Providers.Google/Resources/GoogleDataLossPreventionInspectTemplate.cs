using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_config in GoogleDataLossPreventionInspectTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_config";

    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included. Possible values: [&amp;quot;CONTENT_TEXT&amp;quot;, &amp;quot;CONTENT_IMAGE&amp;quot;]
    /// </summary>
    public TerraformList<string>? ContentOptions
    {
        get => GetArgument<TerraformList<string>>("content_options");
        set => SetArgument("content_options", value);
    }

    /// <summary>
    /// When true, excludes type information of the findings.
    /// </summary>
    public TerraformValue<bool>? ExcludeInfoTypes
    {
        get => GetArgument<TerraformValue<bool>>("exclude_info_types");
        set => SetArgument("exclude_info_types", value);
    }

    /// <summary>
    /// When true, a contextual quote from the data that triggered a finding is included in the response.
    /// </summary>
    public TerraformValue<bool>? IncludeQuote
    {
        get => GetArgument<TerraformValue<bool>>("include_quote");
        set => SetArgument("include_quote", value);
    }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value: &amp;quot;POSSIBLE&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinLikelihood
    {
        get => GetArgument<TerraformValue<string>>("min_likelihood");
        set => SetArgument("min_likelihood", value);
    }

    /// <summary>
    /// CustomInfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock>? CustomInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock>>("custom_info_types");
        set => SetArgument("custom_info_types", value);
    }

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlock>? InfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// Limits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Limits block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlock>? Limits
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlock>>("limits");
        set => SetArgument("limits", value);
    }

    /// <summary>
    /// RuleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlock>? RuleSet
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlock>>("rule_set");
        set => SetArgument("rule_set", value);
    }

}

/// <summary>
/// Block type for custom_info_types in GoogleDataLossPreventionInspectTemplateInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_info_types";

    /// <summary>
    /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used for rules matching. Possible values: [&amp;quot;EXCLUSION_TYPE_EXCLUDE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ExclusionType
    {
        get => GetArgument<TerraformValue<string>>("exclusion_type");
        set => SetArgument("exclusion_type", value);
    }

    /// <summary>
    /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the finding meets the criteria
    /// specified by the rule. Default value: &amp;quot;VERY_LIKELY&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Likelihood
    {
        get => GetArgument<TerraformValue<string>>("likelihood");
        set => SetArgument("likelihood", value);
    }

    /// <summary>
    /// Dictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlock>? Dictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlock>>("dictionary");
        set => SetArgument("dictionary", value);
    }

    /// <summary>
    /// InfoType block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoType is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoType block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoType block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock> InfoType
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock>>("info_type");
        set => SetArgument("info_type", value);
    }

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

    /// <summary>
    /// StoredType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoredType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock>? StoredType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock>>("stored_type");
        set => SetArgument("stored_type", value);
    }

    /// <summary>
    /// SurrogateType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SurrogateType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock>? SurrogateType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock>>("surrogate_type");
        set => SetArgument("surrogate_type", value);
    }

}

/// <summary>
/// Block type for dictionary in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dictionary";

    /// <summary>
    /// CloudStoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock>? CloudStoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock>>("cloud_storage_path");
        set => SetArgument("cloud_storage_path", value);
    }

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for cloud_storage_path in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockCloudStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockDictionaryBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for info_type in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names
    /// listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockInfoTypeBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for regex in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for stored_type in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockStoredTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stored_type";

    /// <summary>
    /// Resource name of the requested StoredInfoType, for example &#39;organizations/433245324/storedInfoTypes/432452342&#39;
    /// or &#39;projects/project-id/storedInfoTypes/432452342&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for surrogate_type in GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockCustomInfoTypesBlockSurrogateTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "surrogate_type";

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionInspectTemplateInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the information type to use. By default, the version is set to stable
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
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for limits in GoogleDataLossPreventionInspectTemplateInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limits";

    /// <summary>
    /// Max number of findings that will be returned for each item scanned. The maximum returned is 2000.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFindingsPerItem is required")]
    public required TerraformValue<double> MaxFindingsPerItem
    {
        get => GetArgument<TerraformValue<double>>("max_findings_per_item");
        set => SetArgument("max_findings_per_item", value);
    }

    /// <summary>
    /// Max number of findings that will be returned per request/job. The maximum returned is 2000.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFindingsPerRequest is required")]
    public required TerraformValue<double> MaxFindingsPerRequest
    {
        get => GetArgument<TerraformValue<double>>("max_findings_per_request");
        set => SetArgument("max_findings_per_request", value);
    }

    /// <summary>
    /// MaxFindingsPerInfoType block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock>? MaxFindingsPerInfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock>>("max_findings_per_info_type");
        set => SetArgument("max_findings_per_info_type", value);
    }

}

/// <summary>
/// Block type for max_findings_per_info_type in GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "max_findings_per_info_type";

    /// <summary>
    /// Max findings limit for the given infoType.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxFindings is required")]
    public required TerraformValue<double> MaxFindings
    {
        get => GetArgument<TerraformValue<double>>("max_findings");
        set => SetArgument("max_findings", value);
    }

    /// <summary>
    /// InfoType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InfoType block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock>? InfoType
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock>>("info_type");
        set => SetArgument("info_type", value);
    }

}

/// <summary>
/// Block type for info_type in GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_type";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockLimitsBlockMaxFindingsPerInfoTypeBlockInfoTypeBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for rule_set in GoogleDataLossPreventionInspectTemplateInspectConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_set";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoTypes block(s) required")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlock> InfoTypes
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for rules in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// ExclusionRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExclusionRule block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock>? ExclusionRule
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock>>("exclusion_rule");
        set => SetArgument("exclusion_rule", value);
    }

    /// <summary>
    /// HotwordRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRule block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock>? HotwordRule
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock>>("hotword_rule");
        set => SetArgument("hotword_rule", value);
    }

}

/// <summary>
/// Block type for exclusion_rule in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_rule";

    /// <summary>
    /// How the rule is applied. See the documentation for more information: https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#MatchingType Possible values: [&amp;quot;MATCHING_TYPE_FULL_MATCH&amp;quot;, &amp;quot;MATCHING_TYPE_PARTIAL_MATCH&amp;quot;, &amp;quot;MATCHING_TYPE_INVERSE_MATCH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingType is required")]
    public required TerraformValue<string> MatchingType
    {
        get => GetArgument<TerraformValue<string>>("matching_type");
        set => SetArgument("matching_type", value);
    }

    /// <summary>
    /// Dictionary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dictionary block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock>? Dictionary
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock>>("dictionary");
        set => SetArgument("dictionary", value);
    }

    /// <summary>
    /// ExcludeByHotword block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeByHotword block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock>? ExcludeByHotword
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock>>("exclude_by_hotword");
        set => SetArgument("exclude_by_hotword", value);
    }

    /// <summary>
    /// ExcludeInfoTypes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeInfoTypes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock>? ExcludeInfoTypes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock>>("exclude_info_types");
        set => SetArgument("exclude_info_types", value);
    }

    /// <summary>
    /// Regex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Regex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock>? Regex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock>>("regex");
        set => SetArgument("regex", value);
    }

}

/// <summary>
/// Block type for dictionary in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dictionary";

    /// <summary>
    /// CloudStoragePath block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStoragePath block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock>? CloudStoragePath
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock>>("cloud_storage_path");
        set => SetArgument("cloud_storage_path", value);
    }

    /// <summary>
    /// WordList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WordList block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock>? WordList
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock>>("word_list");
        set => SetArgument("word_list", value);
    }

}

/// <summary>
/// Block type for cloud_storage_path in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockCloudStoragePathBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_path";

    /// <summary>
    /// A url representing a file or path (no wildcards) in Cloud Storage. Example: &#39;gs://[BUCKET_NAME]/dictionary.txt&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for word_list in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockDictionaryBlockWordListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "word_list";

    /// <summary>
    /// Words or phrases defining the dictionary. The dictionary must contain at least one
    /// phrase and every phrase must contain at least 2 characters that are letters or digits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Words is required")]
    public TerraformList<string>? Words
    {
        get => GetArgument<TerraformList<string>>("words");
        set => SetArgument("words", value);
    }

}

/// <summary>
/// Block type for exclude_by_hotword in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_by_hotword";

    /// <summary>
    /// HotwordRegex block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HotwordRegex is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HotwordRegex block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRegex block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock> HotwordRegex
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock>>("hotword_regex");
        set => SetArgument("hotword_regex", value);
    }

    /// <summary>
    /// Proximity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Proximity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Proximity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proximity block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock> Proximity
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock>>("proximity");
        set => SetArgument("proximity", value);
    }

}

/// <summary>
/// Block type for hotword_regex in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockHotwordRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified,
    /// the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression. Its syntax
    /// (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for proximity in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeByHotwordBlockProximityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proximity";

    /// <summary>
    /// Number of characters after the finding to consider.
    /// </summary>
    public TerraformValue<double>? WindowAfter
    {
        get => GetArgument<TerraformValue<double>>("window_after");
        set => SetArgument("window_after", value);
    }

    /// <summary>
    /// Number of characters before the finding to consider.
    /// </summary>
    public TerraformValue<double>? WindowBefore
    {
        get => GetArgument<TerraformValue<double>>("window_before");
        set => SetArgument("window_before", value);
    }

}

/// <summary>
/// Block type for exclude_info_types in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_info_types";

    /// <summary>
    /// InfoTypes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InfoTypes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InfoTypes block(s) required")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock> InfoTypes
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock>>("info_types");
        set => SetArgument("info_types", value);
    }

}

/// <summary>
/// Block type for info_types in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "info_types";

    /// <summary>
    /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the names listed
    /// at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
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
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockExcludeInfoTypesBlockInfoTypesBlockSensitivityScoreBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for regex in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockExclusionRuleBlockRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression.
    /// Its syntax (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for hotword_rule in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_rule";

    /// <summary>
    /// HotwordRegex block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HotwordRegex is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HotwordRegex block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HotwordRegex block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock> HotwordRegex
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock>>("hotword_regex");
        set => SetArgument("hotword_regex", value);
    }

    /// <summary>
    /// LikelihoodAdjustment block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LikelihoodAdjustment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LikelihoodAdjustment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LikelihoodAdjustment block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock> LikelihoodAdjustment
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock>>("likelihood_adjustment");
        set => SetArgument("likelihood_adjustment", value);
    }

    /// <summary>
    /// Proximity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Proximity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Proximity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Proximity block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock> Proximity
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock>>("proximity");
        set => SetArgument("proximity", value);
    }

}

/// <summary>
/// Block type for hotword_regex in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockHotwordRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hotword_regex";

    /// <summary>
    /// The index of the submatch to extract as findings. When not specified,
    /// the entire match is returned. No more than 3 may be included.
    /// </summary>
    public TerraformList<double>? GroupIndexes
    {
        get => GetArgument<TerraformList<double>>("group_indexes");
        set => SetArgument("group_indexes", value);
    }

    /// <summary>
    /// Pattern defining the regular expression. Its syntax
    /// (https://github.com/google/re2/wiki/Syntax) can be found under the google/re2 repository on GitHub.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for likelihood_adjustment in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockLikelihoodAdjustmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "likelihood_adjustment";

    /// <summary>
    /// Set the likelihood of a finding to a fixed value. Either this or relative_likelihood can be set. Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? FixedLikelihood
    {
        get => GetArgument<TerraformValue<string>>("fixed_likelihood");
        set => SetArgument("fixed_likelihood", value);
    }

    /// <summary>
    /// Increase or decrease the likelihood by the specified number of levels. For example,
    /// if a finding would be POSSIBLE without the detection rule and relativeLikelihood is 1,
    /// then it is upgraded to LIKELY, while a value of -1 would downgrade it to UNLIKELY.
    /// Likelihood may never drop below VERY_UNLIKELY or exceed VERY_LIKELY, so applying an
    /// adjustment of 1 followed by an adjustment of -1 when base likelihood is VERY_LIKELY
    /// will result in a final likelihood of LIKELY. Either this or fixed_likelihood can be set.
    /// </summary>
    public TerraformValue<double>? RelativeLikelihood
    {
        get => GetArgument<TerraformValue<double>>("relative_likelihood");
        set => SetArgument("relative_likelihood", value);
    }

}

/// <summary>
/// Block type for proximity in GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionInspectTemplateInspectConfigBlockRuleSetBlockRulesBlockHotwordRuleBlockProximityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proximity";

    /// <summary>
    /// Number of characters after the finding to consider. Either this or window_before must be specified
    /// </summary>
    public TerraformValue<double>? WindowAfter
    {
        get => GetArgument<TerraformValue<double>>("window_after");
        set => SetArgument("window_after", value);
    }

    /// <summary>
    /// Number of characters before the finding to consider. Either this or window_after must be specified
    /// </summary>
    public TerraformValue<double>? WindowBefore
    {
        get => GetArgument<TerraformValue<double>>("window_before");
        set => SetArgument("window_before", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataLossPreventionInspectTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionInspectTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_data_loss_prevention_inspect_template Terraform resource.
/// Manages a google_data_loss_prevention_inspect_template resource.
/// </summary>
public partial class GoogleDataLossPreventionInspectTemplate(string name) : TerraformResource("google_data_loss_prevention_inspect_template", name)
{
    /// <summary>
    /// A description of the inspect template.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// User set display name of the inspect template.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parent of the inspect template in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    public TerraformValue<string>? TemplateId
    {
        get => GetArgument<TerraformValue<string>>("template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The resource name of the inspect template. Set by the server.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// InspectConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlock>? InspectConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionInspectTemplateInspectConfigBlock>>("inspect_config");
        set => SetArgument("inspect_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataLossPreventionInspectTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataLossPreventionInspectTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

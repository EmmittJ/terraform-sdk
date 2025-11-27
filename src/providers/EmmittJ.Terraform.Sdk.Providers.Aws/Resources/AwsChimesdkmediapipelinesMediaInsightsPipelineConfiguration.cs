using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elements in AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elements";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// AmazonTranscribeCallAnalyticsProcessorConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonTranscribeCallAnalyticsProcessorConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlock>? AmazonTranscribeCallAnalyticsProcessorConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlock>>("amazon_transcribe_call_analytics_processor_configuration");
        set => SetArgument("amazon_transcribe_call_analytics_processor_configuration", value);
    }

    /// <summary>
    /// AmazonTranscribeProcessorConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonTranscribeProcessorConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeProcessorConfigurationBlock>? AmazonTranscribeProcessorConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeProcessorConfigurationBlock>>("amazon_transcribe_processor_configuration");
        set => SetArgument("amazon_transcribe_processor_configuration", value);
    }

    /// <summary>
    /// KinesisDataStreamSinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisDataStreamSinkConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockKinesisDataStreamSinkConfigurationBlock>? KinesisDataStreamSinkConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockKinesisDataStreamSinkConfigurationBlock>>("kinesis_data_stream_sink_configuration");
        set => SetArgument("kinesis_data_stream_sink_configuration", value);
    }

    /// <summary>
    /// LambdaFunctionSinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaFunctionSinkConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockLambdaFunctionSinkConfigurationBlock>? LambdaFunctionSinkConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockLambdaFunctionSinkConfigurationBlock>>("lambda_function_sink_configuration");
        set => SetArgument("lambda_function_sink_configuration", value);
    }

    /// <summary>
    /// S3RecordingSinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3RecordingSinkConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockS3RecordingSinkConfigurationBlock>? S3RecordingSinkConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockS3RecordingSinkConfigurationBlock>>("s3_recording_sink_configuration");
        set => SetArgument("s3_recording_sink_configuration", value);
    }

    /// <summary>
    /// SnsTopicSinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnsTopicSinkConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSnsTopicSinkConfigurationBlock>? SnsTopicSinkConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSnsTopicSinkConfigurationBlock>>("sns_topic_sink_configuration");
        set => SetArgument("sns_topic_sink_configuration", value);
    }

    /// <summary>
    /// SqsQueueSinkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsQueueSinkConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSqsQueueSinkConfigurationBlock>? SqsQueueSinkConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSqsQueueSinkConfigurationBlock>>("sqs_queue_sink_configuration");
        set => SetArgument("sqs_queue_sink_configuration", value);
    }

    /// <summary>
    /// VoiceAnalyticsProcessorConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VoiceAnalyticsProcessorConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockVoiceAnalyticsProcessorConfigurationBlock>? VoiceAnalyticsProcessorConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockVoiceAnalyticsProcessorConfigurationBlock>>("voice_analytics_processor_configuration");
        set => SetArgument("voice_analytics_processor_configuration", value);
    }

}

/// <summary>
/// Block type for amazon_transcribe_call_analytics_processor_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_transcribe_call_analytics_processor_configuration";

    /// <summary>
    /// The call_analytics_stream_categories attribute.
    /// </summary>
    public TerraformList<string>? CallAnalyticsStreamCategories
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "call_analytics_stream_categories").ResolveNodes(ctx));
        set => SetArgument("call_analytics_stream_categories", value);
    }

    /// <summary>
    /// The content_identification_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentIdentificationType
    {
        get => new TerraformReference<string>(this, "content_identification_type");
        set => SetArgument("content_identification_type", value);
    }

    /// <summary>
    /// The content_redaction_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentRedactionType
    {
        get => new TerraformReference<string>(this, "content_redaction_type");
        set => SetArgument("content_redaction_type", value);
    }

    /// <summary>
    /// The enable_partial_results_stabilization attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePartialResultsStabilization
    {
        get => new TerraformReference<bool>(this, "enable_partial_results_stabilization");
        set => SetArgument("enable_partial_results_stabilization", value);
    }

    /// <summary>
    /// The filter_partial_results attribute.
    /// </summary>
    public TerraformValue<bool>? FilterPartialResults
    {
        get => new TerraformReference<bool>(this, "filter_partial_results");
        set => SetArgument("filter_partial_results", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_model_name attribute.
    /// </summary>
    public TerraformValue<string>? LanguageModelName
    {
        get => new TerraformReference<string>(this, "language_model_name");
        set => SetArgument("language_model_name", value);
    }

    /// <summary>
    /// The partial_results_stability attribute.
    /// </summary>
    public TerraformValue<string>? PartialResultsStability
    {
        get => new TerraformReference<string>(this, "partial_results_stability");
        set => SetArgument("partial_results_stability", value);
    }

    /// <summary>
    /// The pii_entity_types attribute.
    /// </summary>
    public TerraformValue<string>? PiiEntityTypes
    {
        get => new TerraformReference<string>(this, "pii_entity_types");
        set => SetArgument("pii_entity_types", value);
    }

    /// <summary>
    /// The vocabulary_filter_method attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterMethod
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_method");
        set => SetArgument("vocabulary_filter_method", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterName
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_name");
        set => SetArgument("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The vocabulary_name attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyName
    {
        get => new TerraformReference<string>(this, "vocabulary_name");
        set => SetArgument("vocabulary_name", value);
    }

    /// <summary>
    /// PostCallAnalyticsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostCallAnalyticsSettings block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlockPostCallAnalyticsSettingsBlock>? PostCallAnalyticsSettings
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlockPostCallAnalyticsSettingsBlock>>("post_call_analytics_settings");
        set => SetArgument("post_call_analytics_settings", value);
    }

}

/// <summary>
/// Block type for post_call_analytics_settings in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeCallAnalyticsProcessorConfigurationBlockPostCallAnalyticsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_call_analytics_settings";

    /// <summary>
    /// The content_redaction_output attribute.
    /// </summary>
    public TerraformValue<string>? ContentRedactionOutput
    {
        get => new TerraformReference<string>(this, "content_redaction_output");
        set => SetArgument("content_redaction_output", value);
    }

    /// <summary>
    /// The data_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataAccessRoleArn is required")]
    public required TerraformValue<string> DataAccessRoleArn
    {
        get => new TerraformReference<string>(this, "data_access_role_arn");
        set => SetArgument("data_access_role_arn", value);
    }

    /// <summary>
    /// The output_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? OutputEncryptionKmsKeyId
    {
        get => new TerraformReference<string>(this, "output_encryption_kms_key_id");
        set => SetArgument("output_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The output_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputLocation is required")]
    public required TerraformValue<string> OutputLocation
    {
        get => new TerraformReference<string>(this, "output_location");
        set => SetArgument("output_location", value);
    }

}

/// <summary>
/// Block type for amazon_transcribe_processor_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockAmazonTranscribeProcessorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_transcribe_processor_configuration";

    /// <summary>
    /// The content_identification_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentIdentificationType
    {
        get => new TerraformReference<string>(this, "content_identification_type");
        set => SetArgument("content_identification_type", value);
    }

    /// <summary>
    /// The content_redaction_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentRedactionType
    {
        get => new TerraformReference<string>(this, "content_redaction_type");
        set => SetArgument("content_redaction_type", value);
    }

    /// <summary>
    /// The enable_partial_results_stabilization attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePartialResultsStabilization
    {
        get => new TerraformReference<bool>(this, "enable_partial_results_stabilization");
        set => SetArgument("enable_partial_results_stabilization", value);
    }

    /// <summary>
    /// The filter_partial_results attribute.
    /// </summary>
    public TerraformValue<bool>? FilterPartialResults
    {
        get => new TerraformReference<bool>(this, "filter_partial_results");
        set => SetArgument("filter_partial_results", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_model_name attribute.
    /// </summary>
    public TerraformValue<string>? LanguageModelName
    {
        get => new TerraformReference<string>(this, "language_model_name");
        set => SetArgument("language_model_name", value);
    }

    /// <summary>
    /// The partial_results_stability attribute.
    /// </summary>
    public TerraformValue<string>? PartialResultsStability
    {
        get => new TerraformReference<string>(this, "partial_results_stability");
        set => SetArgument("partial_results_stability", value);
    }

    /// <summary>
    /// The pii_entity_types attribute.
    /// </summary>
    public TerraformValue<string>? PiiEntityTypes
    {
        get => new TerraformReference<string>(this, "pii_entity_types");
        set => SetArgument("pii_entity_types", value);
    }

    /// <summary>
    /// The show_speaker_label attribute.
    /// </summary>
    public TerraformValue<bool>? ShowSpeakerLabel
    {
        get => new TerraformReference<bool>(this, "show_speaker_label");
        set => SetArgument("show_speaker_label", value);
    }

    /// <summary>
    /// The vocabulary_filter_method attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterMethod
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_method");
        set => SetArgument("vocabulary_filter_method", value);
    }

    /// <summary>
    /// The vocabulary_filter_name attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyFilterName
    {
        get => new TerraformReference<string>(this, "vocabulary_filter_name");
        set => SetArgument("vocabulary_filter_name", value);
    }

    /// <summary>
    /// The vocabulary_name attribute.
    /// </summary>
    public TerraformValue<string>? VocabularyName
    {
        get => new TerraformReference<string>(this, "vocabulary_name");
        set => SetArgument("vocabulary_name", value);
    }

}

/// <summary>
/// Block type for kinesis_data_stream_sink_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockKinesisDataStreamSinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_data_stream_sink_configuration";

    /// <summary>
    /// The insights_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsTarget is required")]
    public required TerraformValue<string> InsightsTarget
    {
        get => new TerraformReference<string>(this, "insights_target");
        set => SetArgument("insights_target", value);
    }

}

/// <summary>
/// Block type for lambda_function_sink_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockLambdaFunctionSinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_sink_configuration";

    /// <summary>
    /// The insights_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsTarget is required")]
    public required TerraformValue<string> InsightsTarget
    {
        get => new TerraformReference<string>(this, "insights_target");
        set => SetArgument("insights_target", value);
    }

}

/// <summary>
/// Block type for s3_recording_sink_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockS3RecordingSinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_recording_sink_configuration";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformValue<string>? Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for sns_topic_sink_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSnsTopicSinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns_topic_sink_configuration";

    /// <summary>
    /// The insights_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsTarget is required")]
    public required TerraformValue<string> InsightsTarget
    {
        get => new TerraformReference<string>(this, "insights_target");
        set => SetArgument("insights_target", value);
    }

}

/// <summary>
/// Block type for sqs_queue_sink_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockSqsQueueSinkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_queue_sink_configuration";

    /// <summary>
    /// The insights_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InsightsTarget is required")]
    public required TerraformValue<string> InsightsTarget
    {
        get => new TerraformReference<string>(this, "insights_target");
        set => SetArgument("insights_target", value);
    }

}

/// <summary>
/// Block type for voice_analytics_processor_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlockVoiceAnalyticsProcessorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voice_analytics_processor_configuration";

    /// <summary>
    /// The speaker_search_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpeakerSearchStatus is required")]
    public required TerraformValue<string> SpeakerSearchStatus
    {
        get => new TerraformReference<string>(this, "speaker_search_status");
        set => SetArgument("speaker_search_status", value);
    }

    /// <summary>
    /// The voice_tone_analysis_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceToneAnalysisStatus is required")]
    public required TerraformValue<string> VoiceToneAnalysisStatus
    {
        get => new TerraformReference<string>(this, "voice_tone_analysis_status");
        set => SetArgument("voice_tone_analysis_status", value);
    }

}


/// <summary>
/// Block type for real_time_alert_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "real_time_alert_configuration";

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool> Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Rules block(s) allowed")]
    public required TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// IssueDetectionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssueDetectionConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockIssueDetectionConfigurationBlock>? IssueDetectionConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockIssueDetectionConfigurationBlock>>("issue_detection_configuration");
        set => SetArgument("issue_detection_configuration", value);
    }

    /// <summary>
    /// KeywordMatchConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeywordMatchConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockKeywordMatchConfigurationBlock>? KeywordMatchConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockKeywordMatchConfigurationBlock>>("keyword_match_configuration");
        set => SetArgument("keyword_match_configuration", value);
    }

    /// <summary>
    /// SentimentConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SentimentConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockSentimentConfigurationBlock>? SentimentConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockSentimentConfigurationBlock>>("sentiment_configuration");
        set => SetArgument("sentiment_configuration", value);
    }

}

/// <summary>
/// Block type for issue_detection_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockIssueDetectionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "issue_detection_configuration";

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

}

/// <summary>
/// Block type for keyword_match_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockKeywordMatchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "keyword_match_configuration";

    /// <summary>
    /// The keywords attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keywords is required")]
    public TerraformList<string>? Keywords
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "keywords").ResolveNodes(ctx));
        set => SetArgument("keywords", value);
    }

    /// <summary>
    /// The negate attribute.
    /// </summary>
    public TerraformValue<bool> Negate
    {
        get => new TerraformReference<bool>(this, "negate");
        set => SetArgument("negate", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

}

/// <summary>
/// Block type for sentiment_configuration in AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlock.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlockRulesBlockSentimentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sentiment_configuration";

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformValue<string> RuleName
    {
        get => new TerraformReference<string>(this, "rule_name");
        set => SetArgument("rule_name", value);
    }

    /// <summary>
    /// The sentiment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SentimentType is required")]
    public required TerraformValue<string> SentimentType
    {
        get => new TerraformReference<string>(this, "sentiment_type");
        set => SetArgument("sentiment_type", value);
    }

    /// <summary>
    /// The time_period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimePeriod is required")]
    public required TerraformValue<double> TimePeriod
    {
        get => new TerraformReference<double>(this, "time_period");
        set => SetArgument("time_period", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_chimesdkmediapipelines_media_insights_pipeline_configuration Terraform resource.
/// Manages a aws_chimesdkmediapipelines_media_insights_pipeline_configuration resource.
/// </summary>
public partial class AwsChimesdkmediapipelinesMediaInsightsPipelineConfiguration(string name) : TerraformResource("aws_chimesdkmediapipelines_media_insights_pipeline_configuration", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceAccessRoleArn is required")]
    public required TerraformValue<string> ResourceAccessRoleArn
    {
        get => new TerraformReference<string>(this, "resource_access_role_arn");
        set => SetArgument("resource_access_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Elements block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Elements is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Elements block(s) required")]
    public required TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock> Elements
    {
        get => GetRequiredArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationElementsBlock>>("elements");
        set => SetArgument("elements", value);
    }

    /// <summary>
    /// RealTimeAlertConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RealTimeAlertConfiguration block(s) allowed")]
    public TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock>? RealTimeAlertConfiguration
    {
        get => GetArgument<TerraformList<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationRealTimeAlertConfigurationBlock>>("real_time_alert_configuration");
        set => SetArgument("real_time_alert_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsChimesdkmediapipelinesMediaInsightsPipelineConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

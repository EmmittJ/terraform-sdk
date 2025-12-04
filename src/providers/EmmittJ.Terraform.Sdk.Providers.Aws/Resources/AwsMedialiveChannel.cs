using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cdi_input_specification in AwsMedialiveChannel.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelCdiInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cdi_input_specification";

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resolution is required")]
    public required TerraformValue<string> Resolution
    {
        get => GetRequiredArgument<TerraformValue<string>>("resolution");
        set => SetArgument("resolution", value);
    }

}


/// <summary>
/// Block type for destinations in AwsMedialiveChannel.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destinations";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// MediaPackageSettings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveChannelDestinationsBlockMediaPackageSettingsBlock>? MediaPackageSettings
    {
        get => GetArgument<TerraformSet<AwsMedialiveChannelDestinationsBlockMediaPackageSettingsBlock>>("media_package_settings");
        set => SetArgument("media_package_settings", value);
    }

    /// <summary>
    /// MultiplexSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelDestinationsBlockMultiplexSettingsBlock>? MultiplexSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelDestinationsBlockMultiplexSettingsBlock>>("multiplex_settings");
        set => SetArgument("multiplex_settings", value);
    }

    /// <summary>
    /// Settings block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveChannelDestinationsBlockSettingsBlock>? Settings
    {
        get => GetArgument<TerraformSet<AwsMedialiveChannelDestinationsBlockSettingsBlock>>("settings");
        set => SetArgument("settings", value);
    }

}

/// <summary>
/// Block type for media_package_settings in AwsMedialiveChannelDestinationsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelDestinationsBlockMediaPackageSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_package_settings";

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelId is required")]
    public required TerraformValue<string> ChannelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("channel_id");
        set => SetArgument("channel_id", value);
    }

}

/// <summary>
/// Block type for multiplex_settings in AwsMedialiveChannelDestinationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelDestinationsBlockMultiplexSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiplex_settings";

    /// <summary>
    /// The multiplex_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MultiplexId is required")]
    public required TerraformValue<string> MultiplexId
    {
        get => GetRequiredArgument<TerraformValue<string>>("multiplex_id");
        set => SetArgument("multiplex_id", value);
    }

    /// <summary>
    /// The program_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramName is required")]
    public required TerraformValue<string> ProgramName
    {
        get => GetRequiredArgument<TerraformValue<string>>("program_name");
        set => SetArgument("program_name", value);
    }

}

/// <summary>
/// Block type for settings in AwsMedialiveChannelDestinationsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelDestinationsBlockSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "settings";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string>? PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    public TerraformValue<string>? StreamName
    {
        get => GetArgument<TerraformValue<string>>("stream_name");
        set => SetArgument("stream_name", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => GetArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for encoder_settings in AwsMedialiveChannel.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encoder_settings";

    /// <summary>
    /// AudioDescriptions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock>? AudioDescriptions
    {
        get => GetArgument<TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock>>("audio_descriptions");
        set => SetArgument("audio_descriptions", value);
    }

    /// <summary>
    /// AvailBlanking block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailBlanking block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlock>? AvailBlanking
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlock>>("avail_blanking");
        set => SetArgument("avail_blanking", value);
    }

    /// <summary>
    /// CaptionDescriptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlock>? CaptionDescriptions
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlock>>("caption_descriptions");
        set => SetArgument("caption_descriptions", value);
    }

    /// <summary>
    /// GlobalConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlobalConfiguration block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlock>? GlobalConfiguration
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlock>>("global_configuration");
        set => SetArgument("global_configuration", value);
    }

    /// <summary>
    /// MotionGraphicsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MotionGraphicsConfiguration block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlock>? MotionGraphicsConfiguration
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlock>>("motion_graphics_configuration");
        set => SetArgument("motion_graphics_configuration", value);
    }

    /// <summary>
    /// NielsenConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NielsenConfiguration block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockNielsenConfigurationBlock>? NielsenConfiguration
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockNielsenConfigurationBlock>>("nielsen_configuration");
        set => SetArgument("nielsen_configuration", value);
    }

    /// <summary>
    /// OutputGroups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputGroups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputGroups block(s) required")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlock> OutputGroups
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlock>>("output_groups");
        set => SetArgument("output_groups", value);
    }

    /// <summary>
    /// TimecodeConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimecodeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TimecodeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimecodeConfig block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockTimecodeConfigBlock> TimecodeConfig
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockTimecodeConfigBlock>>("timecode_config");
        set => SetArgument("timecode_config", value);
    }

    /// <summary>
    /// VideoDescriptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlock>? VideoDescriptions
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlock>>("video_descriptions");
        set => SetArgument("video_descriptions", value);
    }

}

/// <summary>
/// Block type for audio_descriptions in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_descriptions";

    /// <summary>
    /// The audio_selector_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioSelectorName is required")]
    public required TerraformValue<string> AudioSelectorName
    {
        get => GetRequiredArgument<TerraformValue<string>>("audio_selector_name");
        set => SetArgument("audio_selector_name", value);
    }

    /// <summary>
    /// The audio_type attribute.
    /// </summary>
    public TerraformValue<string> AudioType
    {
        get => GetArgument<TerraformValue<string>>("audio_type") ?? AsReference("audio_type");
        set => SetArgument("audio_type", value);
    }

    /// <summary>
    /// The audio_type_control attribute.
    /// </summary>
    public TerraformValue<string> AudioTypeControl
    {
        get => GetArgument<TerraformValue<string>>("audio_type_control") ?? AsReference("audio_type_control");
        set => SetArgument("audio_type_control", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string> LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code") ?? AsReference("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_code_control attribute.
    /// </summary>
    public TerraformValue<string> LanguageCodeControl
    {
        get => GetArgument<TerraformValue<string>>("language_code_control") ?? AsReference("language_code_control");
        set => SetArgument("language_code_control", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    public TerraformValue<string> StreamName
    {
        get => GetArgument<TerraformValue<string>>("stream_name") ?? AsReference("stream_name");
        set => SetArgument("stream_name", value);
    }

    /// <summary>
    /// AudioNormalizationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioNormalizationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioNormalizationSettingsBlock>? AudioNormalizationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioNormalizationSettingsBlock>>("audio_normalization_settings");
        set => SetArgument("audio_normalization_settings", value);
    }

    /// <summary>
    /// AudioWatermarkSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioWatermarkSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlock>? AudioWatermarkSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlock>>("audio_watermark_settings");
        set => SetArgument("audio_watermark_settings", value);
    }

    /// <summary>
    /// CodecSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodecSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock>? CodecSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock>>("codec_settings");
        set => SetArgument("codec_settings", value);
    }

    /// <summary>
    /// RemixSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemixSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlock>? RemixSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlock>>("remix_settings");
        set => SetArgument("remix_settings", value);
    }

}

/// <summary>
/// Block type for audio_normalization_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioNormalizationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_normalization_settings";

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    public TerraformValue<string> Algorithm
    {
        get => GetArgument<TerraformValue<string>>("algorithm") ?? AsReference("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The algorithm_control attribute.
    /// </summary>
    public TerraformValue<string> AlgorithmControl
    {
        get => GetArgument<TerraformValue<string>>("algorithm_control") ?? AsReference("algorithm_control");
        set => SetArgument("algorithm_control", value);
    }

    /// <summary>
    /// The target_lkfs attribute.
    /// </summary>
    public TerraformValue<double> TargetLkfs
    {
        get => GetArgument<TerraformValue<double>>("target_lkfs") ?? AsReference("target_lkfs");
        set => SetArgument("target_lkfs", value);
    }

}

/// <summary>
/// Block type for audio_watermark_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_watermark_settings";

    /// <summary>
    /// NielsenWatermarksSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NielsenWatermarksSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlock>? NielsenWatermarksSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlock>>("nielsen_watermarks_settings");
        set => SetArgument("nielsen_watermarks_settings", value);
    }

}

/// <summary>
/// Block type for nielsen_watermarks_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nielsen_watermarks_settings";

    /// <summary>
    /// The nielsen_distribution_type attribute.
    /// </summary>
    public TerraformValue<string> NielsenDistributionType
    {
        get => GetArgument<TerraformValue<string>>("nielsen_distribution_type") ?? AsReference("nielsen_distribution_type");
        set => SetArgument("nielsen_distribution_type", value);
    }

    /// <summary>
    /// NielsenCbetSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NielsenCbetSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenCbetSettingsBlock>? NielsenCbetSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenCbetSettingsBlock>>("nielsen_cbet_settings");
        set => SetArgument("nielsen_cbet_settings", value);
    }

    /// <summary>
    /// NielsenNaesIiNwSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenNaesIiNwSettingsBlock>? NielsenNaesIiNwSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenNaesIiNwSettingsBlock>>("nielsen_naes_ii_nw_settings");
        set => SetArgument("nielsen_naes_ii_nw_settings", value);
    }

}

/// <summary>
/// Block type for nielsen_cbet_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenCbetSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nielsen_cbet_settings";

    /// <summary>
    /// The cbet_check_digit_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CbetCheckDigitString is required")]
    public required TerraformValue<string> CbetCheckDigitString
    {
        get => GetRequiredArgument<TerraformValue<string>>("cbet_check_digit_string");
        set => SetArgument("cbet_check_digit_string", value);
    }

    /// <summary>
    /// The cbet_stepaside attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CbetStepaside is required")]
    public required TerraformValue<string> CbetStepaside
    {
        get => GetRequiredArgument<TerraformValue<string>>("cbet_stepaside");
        set => SetArgument("cbet_stepaside", value);
    }

    /// <summary>
    /// The csid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Csid is required")]
    public required TerraformValue<string> Csid
    {
        get => GetRequiredArgument<TerraformValue<string>>("csid");
        set => SetArgument("csid", value);
    }

}

/// <summary>
/// Block type for nielsen_naes_ii_nw_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockAudioWatermarkSettingsBlockNielsenWatermarksSettingsBlockNielsenNaesIiNwSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nielsen_naes_ii_nw_settings";

    /// <summary>
    /// The check_digit_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CheckDigitString is required")]
    public required TerraformValue<string> CheckDigitString
    {
        get => GetRequiredArgument<TerraformValue<string>>("check_digit_string");
        set => SetArgument("check_digit_string", value);
    }

    /// <summary>
    /// The sid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sid is required")]
    public required TerraformValue<double> Sid
    {
        get => GetRequiredArgument<TerraformValue<double>>("sid");
        set => SetArgument("sid", value);
    }

}

/// <summary>
/// Block type for codec_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "codec_settings";

    /// <summary>
    /// AacSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AacSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAacSettingsBlock>? AacSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAacSettingsBlock>>("aac_settings");
        set => SetArgument("aac_settings", value);
    }

    /// <summary>
    /// Ac3Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ac3Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAc3SettingsBlock>? Ac3Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAc3SettingsBlock>>("ac3_settings");
        set => SetArgument("ac3_settings", value);
    }

    /// <summary>
    /// Eac3AtmosSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eac3AtmosSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3AtmosSettingsBlock>? Eac3AtmosSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3AtmosSettingsBlock>>("eac3_atmos_settings");
        set => SetArgument("eac3_atmos_settings", value);
    }

    /// <summary>
    /// Eac3Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eac3Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3SettingsBlock>? Eac3Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3SettingsBlock>>("eac3_settings");
        set => SetArgument("eac3_settings", value);
    }

    /// <summary>
    /// Mp2Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mp2Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockMp2SettingsBlock>? Mp2Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockMp2SettingsBlock>>("mp2_settings");
        set => SetArgument("mp2_settings", value);
    }

    /// <summary>
    /// PassThroughSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PassThroughSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockPassThroughSettingsBlock>? PassThroughSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockPassThroughSettingsBlock>>("pass_through_settings");
        set => SetArgument("pass_through_settings", value);
    }

    /// <summary>
    /// WavSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WavSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockWavSettingsBlock>? WavSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockWavSettingsBlock>>("wav_settings");
        set => SetArgument("wav_settings", value);
    }

}

/// <summary>
/// Block type for aac_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAacSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aac_settings";

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The input_type attribute.
    /// </summary>
    public TerraformValue<string> InputType
    {
        get => GetArgument<TerraformValue<string>>("input_type") ?? AsReference("input_type");
        set => SetArgument("input_type", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformValue<string> Profile
    {
        get => GetArgument<TerraformValue<string>>("profile") ?? AsReference("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// The rate_control_mode attribute.
    /// </summary>
    public TerraformValue<string> RateControlMode
    {
        get => GetArgument<TerraformValue<string>>("rate_control_mode") ?? AsReference("rate_control_mode");
        set => SetArgument("rate_control_mode", value);
    }

    /// <summary>
    /// The raw_format attribute.
    /// </summary>
    public TerraformValue<string> RawFormat
    {
        get => GetArgument<TerraformValue<string>>("raw_format") ?? AsReference("raw_format");
        set => SetArgument("raw_format", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<double> SampleRate
    {
        get => GetArgument<TerraformValue<double>>("sample_rate") ?? AsReference("sample_rate");
        set => SetArgument("sample_rate", value);
    }

    /// <summary>
    /// The spec attribute.
    /// </summary>
    public TerraformValue<string> Spec
    {
        get => GetArgument<TerraformValue<string>>("spec") ?? AsReference("spec");
        set => SetArgument("spec", value);
    }

    /// <summary>
    /// The vbr_quality attribute.
    /// </summary>
    public TerraformValue<string> VbrQuality
    {
        get => GetArgument<TerraformValue<string>>("vbr_quality") ?? AsReference("vbr_quality");
        set => SetArgument("vbr_quality", value);
    }

}

/// <summary>
/// Block type for ac3_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockAc3SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ac3_settings";

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The bitstream_mode attribute.
    /// </summary>
    public TerraformValue<string> BitstreamMode
    {
        get => GetArgument<TerraformValue<string>>("bitstream_mode") ?? AsReference("bitstream_mode");
        set => SetArgument("bitstream_mode", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The dialnorm attribute.
    /// </summary>
    public TerraformValue<double> Dialnorm
    {
        get => GetArgument<TerraformValue<double>>("dialnorm") ?? AsReference("dialnorm");
        set => SetArgument("dialnorm", value);
    }

    /// <summary>
    /// The drc_profile attribute.
    /// </summary>
    public TerraformValue<string> DrcProfile
    {
        get => GetArgument<TerraformValue<string>>("drc_profile") ?? AsReference("drc_profile");
        set => SetArgument("drc_profile", value);
    }

    /// <summary>
    /// The lfe_filter attribute.
    /// </summary>
    public TerraformValue<string> LfeFilter
    {
        get => GetArgument<TerraformValue<string>>("lfe_filter") ?? AsReference("lfe_filter");
        set => SetArgument("lfe_filter", value);
    }

    /// <summary>
    /// The metadata_control attribute.
    /// </summary>
    public TerraformValue<string> MetadataControl
    {
        get => GetArgument<TerraformValue<string>>("metadata_control") ?? AsReference("metadata_control");
        set => SetArgument("metadata_control", value);
    }

}

/// <summary>
/// Block type for eac3_atmos_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3AtmosSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eac3_atmos_settings";

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The dialnorm attribute.
    /// </summary>
    public TerraformValue<double> Dialnorm
    {
        get => GetArgument<TerraformValue<double>>("dialnorm") ?? AsReference("dialnorm");
        set => SetArgument("dialnorm", value);
    }

    /// <summary>
    /// The drc_line attribute.
    /// </summary>
    public TerraformValue<string> DrcLine
    {
        get => GetArgument<TerraformValue<string>>("drc_line") ?? AsReference("drc_line");
        set => SetArgument("drc_line", value);
    }

    /// <summary>
    /// The drc_rf attribute.
    /// </summary>
    public TerraformValue<string> DrcRf
    {
        get => GetArgument<TerraformValue<string>>("drc_rf") ?? AsReference("drc_rf");
        set => SetArgument("drc_rf", value);
    }

    /// <summary>
    /// The height_trim attribute.
    /// </summary>
    public TerraformValue<double> HeightTrim
    {
        get => GetArgument<TerraformValue<double>>("height_trim") ?? AsReference("height_trim");
        set => SetArgument("height_trim", value);
    }

    /// <summary>
    /// The surround_trim attribute.
    /// </summary>
    public TerraformValue<double> SurroundTrim
    {
        get => GetArgument<TerraformValue<double>>("surround_trim") ?? AsReference("surround_trim");
        set => SetArgument("surround_trim", value);
    }

}

/// <summary>
/// Block type for eac3_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockEac3SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eac3_settings";

    /// <summary>
    /// The attenuation_control attribute.
    /// </summary>
    public TerraformValue<string> AttenuationControl
    {
        get => GetArgument<TerraformValue<string>>("attenuation_control") ?? AsReference("attenuation_control");
        set => SetArgument("attenuation_control", value);
    }

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The bitstream_mode attribute.
    /// </summary>
    public TerraformValue<string> BitstreamMode
    {
        get => GetArgument<TerraformValue<string>>("bitstream_mode") ?? AsReference("bitstream_mode");
        set => SetArgument("bitstream_mode", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The dc_filter attribute.
    /// </summary>
    public TerraformValue<string> DcFilter
    {
        get => GetArgument<TerraformValue<string>>("dc_filter") ?? AsReference("dc_filter");
        set => SetArgument("dc_filter", value);
    }

    /// <summary>
    /// The dialnorm attribute.
    /// </summary>
    public TerraformValue<double> Dialnorm
    {
        get => GetArgument<TerraformValue<double>>("dialnorm") ?? AsReference("dialnorm");
        set => SetArgument("dialnorm", value);
    }

    /// <summary>
    /// The drc_line attribute.
    /// </summary>
    public TerraformValue<string> DrcLine
    {
        get => GetArgument<TerraformValue<string>>("drc_line") ?? AsReference("drc_line");
        set => SetArgument("drc_line", value);
    }

    /// <summary>
    /// The drc_rf attribute.
    /// </summary>
    public TerraformValue<string> DrcRf
    {
        get => GetArgument<TerraformValue<string>>("drc_rf") ?? AsReference("drc_rf");
        set => SetArgument("drc_rf", value);
    }

    /// <summary>
    /// The lfe_control attribute.
    /// </summary>
    public TerraformValue<string> LfeControl
    {
        get => GetArgument<TerraformValue<string>>("lfe_control") ?? AsReference("lfe_control");
        set => SetArgument("lfe_control", value);
    }

    /// <summary>
    /// The lfe_filter attribute.
    /// </summary>
    public TerraformValue<string> LfeFilter
    {
        get => GetArgument<TerraformValue<string>>("lfe_filter") ?? AsReference("lfe_filter");
        set => SetArgument("lfe_filter", value);
    }

    /// <summary>
    /// The lo_ro_center_mix_level attribute.
    /// </summary>
    public TerraformValue<double> LoRoCenterMixLevel
    {
        get => GetArgument<TerraformValue<double>>("lo_ro_center_mix_level") ?? AsReference("lo_ro_center_mix_level");
        set => SetArgument("lo_ro_center_mix_level", value);
    }

    /// <summary>
    /// The lo_ro_surround_mix_level attribute.
    /// </summary>
    public TerraformValue<double> LoRoSurroundMixLevel
    {
        get => GetArgument<TerraformValue<double>>("lo_ro_surround_mix_level") ?? AsReference("lo_ro_surround_mix_level");
        set => SetArgument("lo_ro_surround_mix_level", value);
    }

    /// <summary>
    /// The lt_rt_center_mix_level attribute.
    /// </summary>
    public TerraformValue<double> LtRtCenterMixLevel
    {
        get => GetArgument<TerraformValue<double>>("lt_rt_center_mix_level") ?? AsReference("lt_rt_center_mix_level");
        set => SetArgument("lt_rt_center_mix_level", value);
    }

    /// <summary>
    /// The lt_rt_surround_mix_level attribute.
    /// </summary>
    public TerraformValue<double> LtRtSurroundMixLevel
    {
        get => GetArgument<TerraformValue<double>>("lt_rt_surround_mix_level") ?? AsReference("lt_rt_surround_mix_level");
        set => SetArgument("lt_rt_surround_mix_level", value);
    }

    /// <summary>
    /// The metadata_control attribute.
    /// </summary>
    public TerraformValue<string> MetadataControl
    {
        get => GetArgument<TerraformValue<string>>("metadata_control") ?? AsReference("metadata_control");
        set => SetArgument("metadata_control", value);
    }

    /// <summary>
    /// The passthrough_control attribute.
    /// </summary>
    public TerraformValue<string> PassthroughControl
    {
        get => GetArgument<TerraformValue<string>>("passthrough_control") ?? AsReference("passthrough_control");
        set => SetArgument("passthrough_control", value);
    }

    /// <summary>
    /// The phase_control attribute.
    /// </summary>
    public TerraformValue<string> PhaseControl
    {
        get => GetArgument<TerraformValue<string>>("phase_control") ?? AsReference("phase_control");
        set => SetArgument("phase_control", value);
    }

    /// <summary>
    /// The stereo_downmix attribute.
    /// </summary>
    public TerraformValue<string> StereoDownmix
    {
        get => GetArgument<TerraformValue<string>>("stereo_downmix") ?? AsReference("stereo_downmix");
        set => SetArgument("stereo_downmix", value);
    }

    /// <summary>
    /// The surround_ex_mode attribute.
    /// </summary>
    public TerraformValue<string> SurroundExMode
    {
        get => GetArgument<TerraformValue<string>>("surround_ex_mode") ?? AsReference("surround_ex_mode");
        set => SetArgument("surround_ex_mode", value);
    }

    /// <summary>
    /// The surround_mode attribute.
    /// </summary>
    public TerraformValue<string> SurroundMode
    {
        get => GetArgument<TerraformValue<string>>("surround_mode") ?? AsReference("surround_mode");
        set => SetArgument("surround_mode", value);
    }

}

/// <summary>
/// Block type for mp2_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockMp2SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mp2_settings";

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<double> SampleRate
    {
        get => GetArgument<TerraformValue<double>>("sample_rate") ?? AsReference("sample_rate");
        set => SetArgument("sample_rate", value);
    }

}

/// <summary>
/// Block type for pass_through_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockPassThroughSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pass_through_settings";

}

/// <summary>
/// Block type for wav_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockCodecSettingsBlockWavSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wav_settings";

    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    public TerraformValue<double> BitDepth
    {
        get => GetArgument<TerraformValue<double>>("bit_depth") ?? AsReference("bit_depth");
        set => SetArgument("bit_depth", value);
    }

    /// <summary>
    /// The coding_mode attribute.
    /// </summary>
    public TerraformValue<string> CodingMode
    {
        get => GetArgument<TerraformValue<string>>("coding_mode") ?? AsReference("coding_mode");
        set => SetArgument("coding_mode", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<double> SampleRate
    {
        get => GetArgument<TerraformValue<double>>("sample_rate") ?? AsReference("sample_rate");
        set => SetArgument("sample_rate", value);
    }

}

/// <summary>
/// Block type for remix_settings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remix_settings";

    /// <summary>
    /// The channels_in attribute.
    /// </summary>
    public TerraformValue<double> ChannelsIn
    {
        get => GetArgument<TerraformValue<double>>("channels_in") ?? AsReference("channels_in");
        set => SetArgument("channels_in", value);
    }

    /// <summary>
    /// The channels_out attribute.
    /// </summary>
    public TerraformValue<double> ChannelsOut
    {
        get => GetArgument<TerraformValue<double>>("channels_out") ?? AsReference("channels_out");
        set => SetArgument("channels_out", value);
    }

    /// <summary>
    /// ChannelMappings block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelMappings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ChannelMappings block(s) required")]
    public required TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlock> ChannelMappings
    {
        get => GetRequiredArgument<TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlock>>("channel_mappings");
        set => SetArgument("channel_mappings", value);
    }

}

/// <summary>
/// Block type for channel_mappings in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "channel_mappings";

    /// <summary>
    /// The output_channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputChannel is required")]
    public required TerraformValue<double> OutputChannel
    {
        get => GetRequiredArgument<TerraformValue<double>>("output_channel");
        set => SetArgument("output_channel", value);
    }

    /// <summary>
    /// InputChannelLevels block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputChannelLevels is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputChannelLevels block(s) required")]
    public required TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlockInputChannelLevelsBlock> InputChannelLevels
    {
        get => GetRequiredArgument<TerraformSet<AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlockInputChannelLevelsBlock>>("input_channel_levels");
        set => SetArgument("input_channel_levels", value);
    }

}

/// <summary>
/// Block type for input_channel_levels in AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAudioDescriptionsBlockRemixSettingsBlockChannelMappingsBlockInputChannelLevelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_channel_levels";

    /// <summary>
    /// The gain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Gain is required")]
    public required TerraformValue<double> Gain
    {
        get => GetRequiredArgument<TerraformValue<double>>("gain");
        set => SetArgument("gain", value);
    }

    /// <summary>
    /// The input_channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputChannel is required")]
    public required TerraformValue<double> InputChannel
    {
        get => GetRequiredArgument<TerraformValue<double>>("input_channel");
        set => SetArgument("input_channel", value);
    }

}

/// <summary>
/// Block type for avail_blanking in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avail_blanking";

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? AsReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// AvailBlankingImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AvailBlankingImage block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlockAvailBlankingImageBlock>? AvailBlankingImage
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlockAvailBlankingImageBlock>>("avail_blanking_image");
        set => SetArgument("avail_blanking_image", value);
    }

}

/// <summary>
/// Block type for avail_blanking_image in AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockAvailBlankingBlockAvailBlankingImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "avail_blanking_image";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for caption_descriptions in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "caption_descriptions";

    /// <summary>
    /// The accessibility attribute.
    /// </summary>
    public TerraformValue<string>? Accessibility
    {
        get => GetArgument<TerraformValue<string>>("accessibility");
        set => SetArgument("accessibility", value);
    }

    /// <summary>
    /// The caption_selector_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaptionSelectorName is required")]
    public required TerraformValue<string> CaptionSelectorName
    {
        get => GetRequiredArgument<TerraformValue<string>>("caption_selector_name");
        set => SetArgument("caption_selector_name", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_description attribute.
    /// </summary>
    public TerraformValue<string>? LanguageDescription
    {
        get => GetArgument<TerraformValue<string>>("language_description");
        set => SetArgument("language_description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// DestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock>? DestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock>>("destination_settings");
        set => SetArgument("destination_settings", value);
    }

}

/// <summary>
/// Block type for destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_settings";

    /// <summary>
    /// AribDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AribDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockAribDestinationSettingsBlock>? AribDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockAribDestinationSettingsBlock>>("arib_destination_settings");
        set => SetArgument("arib_destination_settings", value);
    }

    /// <summary>
    /// BurnInDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BurnInDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlock>? BurnInDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlock>>("burn_in_destination_settings");
        set => SetArgument("burn_in_destination_settings", value);
    }

    /// <summary>
    /// DvbSubDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbSubDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlock>? DvbSubDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlock>>("dvb_sub_destination_settings");
        set => SetArgument("dvb_sub_destination_settings", value);
    }

    /// <summary>
    /// EbuTtDDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbuTtDDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEbuTtDDestinationSettingsBlock>? EbuTtDDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEbuTtDDestinationSettingsBlock>>("ebu_tt_d_destination_settings");
        set => SetArgument("ebu_tt_d_destination_settings", value);
    }

    /// <summary>
    /// EmbeddedDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmbeddedDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedDestinationSettingsBlock>? EmbeddedDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedDestinationSettingsBlock>>("embedded_destination_settings");
        set => SetArgument("embedded_destination_settings", value);
    }

    /// <summary>
    /// EmbeddedPlusScte20DestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmbeddedPlusScte20DestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedPlusScte20DestinationSettingsBlock>? EmbeddedPlusScte20DestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedPlusScte20DestinationSettingsBlock>>("embedded_plus_scte20_destination_settings");
        set => SetArgument("embedded_plus_scte20_destination_settings", value);
    }

    /// <summary>
    /// RtmpCaptionInfoDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RtmpCaptionInfoDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockRtmpCaptionInfoDestinationSettingsBlock>? RtmpCaptionInfoDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockRtmpCaptionInfoDestinationSettingsBlock>>("rtmp_caption_info_destination_settings");
        set => SetArgument("rtmp_caption_info_destination_settings", value);
    }

    /// <summary>
    /// Scte20PlusEmbeddedDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scte20PlusEmbeddedDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte20PlusEmbeddedDestinationSettingsBlock>? Scte20PlusEmbeddedDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte20PlusEmbeddedDestinationSettingsBlock>>("scte20_plus_embedded_destination_settings");
        set => SetArgument("scte20_plus_embedded_destination_settings", value);
    }

    /// <summary>
    /// Scte27DestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scte27DestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte27DestinationSettingsBlock>? Scte27DestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte27DestinationSettingsBlock>>("scte27_destination_settings");
        set => SetArgument("scte27_destination_settings", value);
    }

    /// <summary>
    /// SmpteTtDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmpteTtDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockSmpteTtDestinationSettingsBlock>? SmpteTtDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockSmpteTtDestinationSettingsBlock>>("smpte_tt_destination_settings");
        set => SetArgument("smpte_tt_destination_settings", value);
    }

    /// <summary>
    /// TeletextDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TeletextDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTeletextDestinationSettingsBlock>? TeletextDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTeletextDestinationSettingsBlock>>("teletext_destination_settings");
        set => SetArgument("teletext_destination_settings", value);
    }

    /// <summary>
    /// TtmlDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TtmlDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTtmlDestinationSettingsBlock>? TtmlDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTtmlDestinationSettingsBlock>>("ttml_destination_settings");
        set => SetArgument("ttml_destination_settings", value);
    }

    /// <summary>
    /// WebvttDestinationSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebvttDestinationSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockWebvttDestinationSettingsBlock>? WebvttDestinationSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockWebvttDestinationSettingsBlock>>("webvtt_destination_settings");
        set => SetArgument("webvtt_destination_settings", value);
    }

}

/// <summary>
/// Block type for arib_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockAribDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "arib_destination_settings";

}

/// <summary>
/// Block type for burn_in_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "burn_in_destination_settings";

    /// <summary>
    /// The alignment attribute.
    /// </summary>
    public TerraformValue<string>? Alignment
    {
        get => GetArgument<TerraformValue<string>>("alignment");
        set => SetArgument("alignment", value);
    }

    /// <summary>
    /// The background_color attribute.
    /// </summary>
    public TerraformValue<string>? BackgroundColor
    {
        get => GetArgument<TerraformValue<string>>("background_color");
        set => SetArgument("background_color", value);
    }

    /// <summary>
    /// The background_opacity attribute.
    /// </summary>
    public TerraformValue<double>? BackgroundOpacity
    {
        get => GetArgument<TerraformValue<double>>("background_opacity");
        set => SetArgument("background_opacity", value);
    }

    /// <summary>
    /// The font_color attribute.
    /// </summary>
    public TerraformValue<string>? FontColor
    {
        get => GetArgument<TerraformValue<string>>("font_color");
        set => SetArgument("font_color", value);
    }

    /// <summary>
    /// The font_opacity attribute.
    /// </summary>
    public TerraformValue<double>? FontOpacity
    {
        get => GetArgument<TerraformValue<double>>("font_opacity");
        set => SetArgument("font_opacity", value);
    }

    /// <summary>
    /// The font_resolution attribute.
    /// </summary>
    public TerraformValue<double>? FontResolution
    {
        get => GetArgument<TerraformValue<double>>("font_resolution");
        set => SetArgument("font_resolution", value);
    }

    /// <summary>
    /// The font_size attribute.
    /// </summary>
    public TerraformValue<string>? FontSize
    {
        get => GetArgument<TerraformValue<string>>("font_size");
        set => SetArgument("font_size", value);
    }

    /// <summary>
    /// The outline_color attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutlineColor is required")]
    public required TerraformValue<string> OutlineColor
    {
        get => GetRequiredArgument<TerraformValue<string>>("outline_color");
        set => SetArgument("outline_color", value);
    }

    /// <summary>
    /// The outline_size attribute.
    /// </summary>
    public TerraformValue<double>? OutlineSize
    {
        get => GetArgument<TerraformValue<double>>("outline_size");
        set => SetArgument("outline_size", value);
    }

    /// <summary>
    /// The shadow_color attribute.
    /// </summary>
    public TerraformValue<string>? ShadowColor
    {
        get => GetArgument<TerraformValue<string>>("shadow_color");
        set => SetArgument("shadow_color", value);
    }

    /// <summary>
    /// The shadow_opacity attribute.
    /// </summary>
    public TerraformValue<double>? ShadowOpacity
    {
        get => GetArgument<TerraformValue<double>>("shadow_opacity");
        set => SetArgument("shadow_opacity", value);
    }

    /// <summary>
    /// The shadow_x_offset attribute.
    /// </summary>
    public TerraformValue<double>? ShadowXOffset
    {
        get => GetArgument<TerraformValue<double>>("shadow_x_offset");
        set => SetArgument("shadow_x_offset", value);
    }

    /// <summary>
    /// The shadow_y_offset attribute.
    /// </summary>
    public TerraformValue<double>? ShadowYOffset
    {
        get => GetArgument<TerraformValue<double>>("shadow_y_offset");
        set => SetArgument("shadow_y_offset", value);
    }

    /// <summary>
    /// The teletext_grid_control attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TeletextGridControl is required")]
    public required TerraformValue<string> TeletextGridControl
    {
        get => GetRequiredArgument<TerraformValue<string>>("teletext_grid_control");
        set => SetArgument("teletext_grid_control", value);
    }

    /// <summary>
    /// The x_position attribute.
    /// </summary>
    public TerraformValue<double>? XPosition
    {
        get => GetArgument<TerraformValue<double>>("x_position");
        set => SetArgument("x_position", value);
    }

    /// <summary>
    /// The y_position attribute.
    /// </summary>
    public TerraformValue<double>? YPosition
    {
        get => GetArgument<TerraformValue<double>>("y_position");
        set => SetArgument("y_position", value);
    }

    /// <summary>
    /// Font block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Font block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlockFontBlock>? Font
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlockFontBlock>>("font");
        set => SetArgument("font", value);
    }

}

/// <summary>
/// Block type for font in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockBurnInDestinationSettingsBlockFontBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "font";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for dvb_sub_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_sub_destination_settings";

    /// <summary>
    /// The alignment attribute.
    /// </summary>
    public TerraformValue<string>? Alignment
    {
        get => GetArgument<TerraformValue<string>>("alignment");
        set => SetArgument("alignment", value);
    }

    /// <summary>
    /// The background_color attribute.
    /// </summary>
    public TerraformValue<string>? BackgroundColor
    {
        get => GetArgument<TerraformValue<string>>("background_color");
        set => SetArgument("background_color", value);
    }

    /// <summary>
    /// The background_opacity attribute.
    /// </summary>
    public TerraformValue<double>? BackgroundOpacity
    {
        get => GetArgument<TerraformValue<double>>("background_opacity");
        set => SetArgument("background_opacity", value);
    }

    /// <summary>
    /// The font_color attribute.
    /// </summary>
    public TerraformValue<string>? FontColor
    {
        get => GetArgument<TerraformValue<string>>("font_color");
        set => SetArgument("font_color", value);
    }

    /// <summary>
    /// The font_opacity attribute.
    /// </summary>
    public TerraformValue<double>? FontOpacity
    {
        get => GetArgument<TerraformValue<double>>("font_opacity");
        set => SetArgument("font_opacity", value);
    }

    /// <summary>
    /// The font_resolution attribute.
    /// </summary>
    public TerraformValue<double>? FontResolution
    {
        get => GetArgument<TerraformValue<double>>("font_resolution");
        set => SetArgument("font_resolution", value);
    }

    /// <summary>
    /// The font_size attribute.
    /// </summary>
    public TerraformValue<string> FontSize
    {
        get => GetArgument<TerraformValue<string>>("font_size") ?? AsReference("font_size");
        set => SetArgument("font_size", value);
    }

    /// <summary>
    /// The outline_color attribute.
    /// </summary>
    public TerraformValue<string>? OutlineColor
    {
        get => GetArgument<TerraformValue<string>>("outline_color");
        set => SetArgument("outline_color", value);
    }

    /// <summary>
    /// The outline_size attribute.
    /// </summary>
    public TerraformValue<double>? OutlineSize
    {
        get => GetArgument<TerraformValue<double>>("outline_size");
        set => SetArgument("outline_size", value);
    }

    /// <summary>
    /// The shadow_color attribute.
    /// </summary>
    public TerraformValue<string>? ShadowColor
    {
        get => GetArgument<TerraformValue<string>>("shadow_color");
        set => SetArgument("shadow_color", value);
    }

    /// <summary>
    /// The shadow_opacity attribute.
    /// </summary>
    public TerraformValue<double>? ShadowOpacity
    {
        get => GetArgument<TerraformValue<double>>("shadow_opacity");
        set => SetArgument("shadow_opacity", value);
    }

    /// <summary>
    /// The shadow_x_offset attribute.
    /// </summary>
    public TerraformValue<double>? ShadowXOffset
    {
        get => GetArgument<TerraformValue<double>>("shadow_x_offset");
        set => SetArgument("shadow_x_offset", value);
    }

    /// <summary>
    /// The shadow_y_offset attribute.
    /// </summary>
    public TerraformValue<double>? ShadowYOffset
    {
        get => GetArgument<TerraformValue<double>>("shadow_y_offset");
        set => SetArgument("shadow_y_offset", value);
    }

    /// <summary>
    /// The teletext_grid_control attribute.
    /// </summary>
    public TerraformValue<string>? TeletextGridControl
    {
        get => GetArgument<TerraformValue<string>>("teletext_grid_control");
        set => SetArgument("teletext_grid_control", value);
    }

    /// <summary>
    /// The x_position attribute.
    /// </summary>
    public TerraformValue<double>? XPosition
    {
        get => GetArgument<TerraformValue<double>>("x_position");
        set => SetArgument("x_position", value);
    }

    /// <summary>
    /// The y_position attribute.
    /// </summary>
    public TerraformValue<double>? YPosition
    {
        get => GetArgument<TerraformValue<double>>("y_position");
        set => SetArgument("y_position", value);
    }

    /// <summary>
    /// Font block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Font block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlockFontBlock>? Font
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlockFontBlock>>("font");
        set => SetArgument("font", value);
    }

}

/// <summary>
/// Block type for font in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockDvbSubDestinationSettingsBlockFontBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "font";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for ebu_tt_d_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEbuTtDDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebu_tt_d_destination_settings";

    /// <summary>
    /// The copyright_holder attribute.
    /// </summary>
    public TerraformValue<string>? CopyrightHolder
    {
        get => GetArgument<TerraformValue<string>>("copyright_holder");
        set => SetArgument("copyright_holder", value);
    }

    /// <summary>
    /// The fill_line_gap attribute.
    /// </summary>
    public TerraformValue<string>? FillLineGap
    {
        get => GetArgument<TerraformValue<string>>("fill_line_gap");
        set => SetArgument("fill_line_gap", value);
    }

    /// <summary>
    /// The font_family attribute.
    /// </summary>
    public TerraformValue<string>? FontFamily
    {
        get => GetArgument<TerraformValue<string>>("font_family");
        set => SetArgument("font_family", value);
    }

    /// <summary>
    /// The style_control attribute.
    /// </summary>
    public TerraformValue<string> StyleControl
    {
        get => GetArgument<TerraformValue<string>>("style_control") ?? AsReference("style_control");
        set => SetArgument("style_control", value);
    }

}

/// <summary>
/// Block type for embedded_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "embedded_destination_settings";

}

/// <summary>
/// Block type for embedded_plus_scte20_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockEmbeddedPlusScte20DestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "embedded_plus_scte20_destination_settings";

}

/// <summary>
/// Block type for rtmp_caption_info_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockRtmpCaptionInfoDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rtmp_caption_info_destination_settings";

}

/// <summary>
/// Block type for scte20_plus_embedded_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte20PlusEmbeddedDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scte20_plus_embedded_destination_settings";

}

/// <summary>
/// Block type for scte27_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockScte27DestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scte27_destination_settings";

}

/// <summary>
/// Block type for smpte_tt_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockSmpteTtDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smpte_tt_destination_settings";

}

/// <summary>
/// Block type for teletext_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTeletextDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "teletext_destination_settings";

}

/// <summary>
/// Block type for ttml_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockTtmlDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ttml_destination_settings";

    /// <summary>
    /// The style_control attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StyleControl is required")]
    public required TerraformValue<string> StyleControl
    {
        get => GetRequiredArgument<TerraformValue<string>>("style_control");
        set => SetArgument("style_control", value);
    }

}

/// <summary>
/// Block type for webvtt_destination_settings in AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockCaptionDescriptionsBlockDestinationSettingsBlockWebvttDestinationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webvtt_destination_settings";

    /// <summary>
    /// The style_control attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StyleControl is required")]
    public required TerraformValue<string> StyleControl
    {
        get => GetRequiredArgument<TerraformValue<string>>("style_control");
        set => SetArgument("style_control", value);
    }

}

/// <summary>
/// Block type for global_configuration in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_configuration";

    /// <summary>
    /// The initial_audio_gain attribute.
    /// </summary>
    public TerraformValue<double>? InitialAudioGain
    {
        get => GetArgument<TerraformValue<double>>("initial_audio_gain");
        set => SetArgument("initial_audio_gain", value);
    }

    /// <summary>
    /// The input_end_action attribute.
    /// </summary>
    public TerraformValue<string>? InputEndAction
    {
        get => GetArgument<TerraformValue<string>>("input_end_action");
        set => SetArgument("input_end_action", value);
    }

    /// <summary>
    /// The output_locking_mode attribute.
    /// </summary>
    public TerraformValue<string>? OutputLockingMode
    {
        get => GetArgument<TerraformValue<string>>("output_locking_mode");
        set => SetArgument("output_locking_mode", value);
    }

    /// <summary>
    /// The output_timing_source attribute.
    /// </summary>
    public TerraformValue<string>? OutputTimingSource
    {
        get => GetArgument<TerraformValue<string>>("output_timing_source");
        set => SetArgument("output_timing_source", value);
    }

    /// <summary>
    /// The support_low_framerate_inputs attribute.
    /// </summary>
    public TerraformValue<string>? SupportLowFramerateInputs
    {
        get => GetArgument<TerraformValue<string>>("support_low_framerate_inputs");
        set => SetArgument("support_low_framerate_inputs", value);
    }

    /// <summary>
    /// InputLossBehavior block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputLossBehavior block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlock>? InputLossBehavior
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlock>>("input_loss_behavior");
        set => SetArgument("input_loss_behavior", value);
    }

}

/// <summary>
/// Block type for input_loss_behavior in AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_loss_behavior";

    /// <summary>
    /// The black_frame_msec attribute.
    /// </summary>
    public TerraformValue<double>? BlackFrameMsec
    {
        get => GetArgument<TerraformValue<double>>("black_frame_msec");
        set => SetArgument("black_frame_msec", value);
    }

    /// <summary>
    /// The input_loss_image_color attribute.
    /// </summary>
    public TerraformValue<string>? InputLossImageColor
    {
        get => GetArgument<TerraformValue<string>>("input_loss_image_color");
        set => SetArgument("input_loss_image_color", value);
    }

    /// <summary>
    /// The input_loss_image_type attribute.
    /// </summary>
    public TerraformValue<string>? InputLossImageType
    {
        get => GetArgument<TerraformValue<string>>("input_loss_image_type");
        set => SetArgument("input_loss_image_type", value);
    }

    /// <summary>
    /// The repeat_frame_msec attribute.
    /// </summary>
    public TerraformValue<double>? RepeatFrameMsec
    {
        get => GetArgument<TerraformValue<double>>("repeat_frame_msec");
        set => SetArgument("repeat_frame_msec", value);
    }

    /// <summary>
    /// InputLossImageSlate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputLossImageSlate block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlockInputLossImageSlateBlock>? InputLossImageSlate
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlockInputLossImageSlateBlock>>("input_loss_image_slate");
        set => SetArgument("input_loss_image_slate", value);
    }

}

/// <summary>
/// Block type for input_loss_image_slate in AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockGlobalConfigurationBlockInputLossBehaviorBlockInputLossImageSlateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_loss_image_slate";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for motion_graphics_configuration in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "motion_graphics_configuration";

    /// <summary>
    /// The motion_graphics_insertion attribute.
    /// </summary>
    public TerraformValue<string>? MotionGraphicsInsertion
    {
        get => GetArgument<TerraformValue<string>>("motion_graphics_insertion");
        set => SetArgument("motion_graphics_insertion", value);
    }

    /// <summary>
    /// MotionGraphicsSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MotionGraphicsSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MotionGraphicsSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MotionGraphicsSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlock> MotionGraphicsSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlock>>("motion_graphics_settings");
        set => SetArgument("motion_graphics_settings", value);
    }

}

/// <summary>
/// Block type for motion_graphics_settings in AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "motion_graphics_settings";

    /// <summary>
    /// HtmlMotionGraphicsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HtmlMotionGraphicsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlockHtmlMotionGraphicsSettingsBlock>? HtmlMotionGraphicsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlockHtmlMotionGraphicsSettingsBlock>>("html_motion_graphics_settings");
        set => SetArgument("html_motion_graphics_settings", value);
    }

}

/// <summary>
/// Block type for html_motion_graphics_settings in AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockMotionGraphicsConfigurationBlockMotionGraphicsSettingsBlockHtmlMotionGraphicsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "html_motion_graphics_settings";

}

/// <summary>
/// Block type for nielsen_configuration in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockNielsenConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nielsen_configuration";

    /// <summary>
    /// The distributor_id attribute.
    /// </summary>
    public TerraformValue<string>? DistributorId
    {
        get => GetArgument<TerraformValue<string>>("distributor_id");
        set => SetArgument("distributor_id", value);
    }

    /// <summary>
    /// The nielsen_pcm_to_id3_tagging attribute.
    /// </summary>
    public TerraformValue<string>? NielsenPcmToId3Tagging
    {
        get => GetArgument<TerraformValue<string>>("nielsen_pcm_to_id3_tagging");
        set => SetArgument("nielsen_pcm_to_id3_tagging", value);
    }

}

/// <summary>
/// Block type for output_groups in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_groups";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// OutputGroupSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputGroupSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputGroupSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputGroupSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock> OutputGroupSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock>>("output_group_settings");
        set => SetArgument("output_group_settings", value);
    }

    /// <summary>
    /// Outputs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Outputs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Outputs block(s) required")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlock> Outputs
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlock>>("outputs");
        set => SetArgument("outputs", value);
    }

}

/// <summary>
/// Block type for output_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_group_settings";

    /// <summary>
    /// ArchiveGroupSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlock>? ArchiveGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlock>>("archive_group_settings");
        set => SetArgument("archive_group_settings", value);
    }

    /// <summary>
    /// FrameCaptureGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlock>? FrameCaptureGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlock>>("frame_capture_group_settings");
        set => SetArgument("frame_capture_group_settings", value);
    }

    /// <summary>
    /// HlsGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock>? HlsGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock>>("hls_group_settings");
        set => SetArgument("hls_group_settings", value);
    }

    /// <summary>
    /// MediaPackageGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaPackageGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlock>? MediaPackageGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlock>>("media_package_group_settings");
        set => SetArgument("media_package_group_settings", value);
    }

    /// <summary>
    /// MsSmoothGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MsSmoothGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlock>? MsSmoothGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlock>>("ms_smooth_group_settings");
        set => SetArgument("ms_smooth_group_settings", value);
    }

    /// <summary>
    /// MultiplexGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMultiplexGroupSettingsBlock>? MultiplexGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMultiplexGroupSettingsBlock>>("multiplex_group_settings");
        set => SetArgument("multiplex_group_settings", value);
    }

    /// <summary>
    /// RtmpGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RtmpGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockRtmpGroupSettingsBlock>? RtmpGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockRtmpGroupSettingsBlock>>("rtmp_group_settings");
        set => SetArgument("rtmp_group_settings", value);
    }

    /// <summary>
    /// UdpGroupSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UdpGroupSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockUdpGroupSettingsBlock>? UdpGroupSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockUdpGroupSettingsBlock>>("udp_group_settings");
        set => SetArgument("udp_group_settings", value);
    }

}

/// <summary>
/// Block type for archive_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_group_settings";

    /// <summary>
    /// The rollover_interval attribute.
    /// </summary>
    public TerraformValue<double>? RolloverInterval
    {
        get => GetArgument<TerraformValue<double>>("rollover_interval");
        set => SetArgument("rollover_interval", value);
    }

    /// <summary>
    /// ArchiveCdnSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchiveCdnSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlock>? ArchiveCdnSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlock>>("archive_cdn_settings");
        set => SetArgument("archive_cdn_settings", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for archive_cdn_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_cdn_settings";

    /// <summary>
    /// ArchiveS3Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchiveS3Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlockArchiveS3SettingsBlock>? ArchiveS3Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlockArchiveS3SettingsBlock>>("archive_s3_settings");
        set => SetArgument("archive_s3_settings", value);
    }

}

/// <summary>
/// Block type for archive_s3_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockArchiveCdnSettingsBlockArchiveS3SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_s3_settings";

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformValue<string>? CannedAcl
    {
        get => GetArgument<TerraformValue<string>>("canned_acl");
        set => SetArgument("canned_acl", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockArchiveGroupSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for frame_capture_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_group_settings";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// FrameCaptureCdnSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureCdnSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlock>? FrameCaptureCdnSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlock>>("frame_capture_cdn_settings");
        set => SetArgument("frame_capture_cdn_settings", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for frame_capture_cdn_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_cdn_settings";

    /// <summary>
    /// FrameCaptureS3Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureS3Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlockFrameCaptureS3SettingsBlock>? FrameCaptureS3Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlockFrameCaptureS3SettingsBlock>>("frame_capture_s3_settings");
        set => SetArgument("frame_capture_s3_settings", value);
    }

}

/// <summary>
/// Block type for frame_capture_s3_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockFrameCaptureGroupSettingsBlockFrameCaptureCdnSettingsBlockFrameCaptureS3SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_s3_settings";

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformValue<string>? CannedAcl
    {
        get => GetArgument<TerraformValue<string>>("canned_acl");
        set => SetArgument("canned_acl", value);
    }

}

/// <summary>
/// Block type for hls_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_group_settings";

    /// <summary>
    /// The ad_markers attribute.
    /// </summary>
    public TerraformList<string> AdMarkers
    {
        get => GetArgument<TerraformList<string>>("ad_markers") ?? AsReference("ad_markers");
        set => SetArgument("ad_markers", value);
    }

    /// <summary>
    /// The base_url_content attribute.
    /// </summary>
    public TerraformValue<string> BaseUrlContent
    {
        get => GetArgument<TerraformValue<string>>("base_url_content") ?? AsReference("base_url_content");
        set => SetArgument("base_url_content", value);
    }

    /// <summary>
    /// The base_url_content1 attribute.
    /// </summary>
    public TerraformValue<string> BaseUrlContent1
    {
        get => GetArgument<TerraformValue<string>>("base_url_content1") ?? AsReference("base_url_content1");
        set => SetArgument("base_url_content1", value);
    }

    /// <summary>
    /// The base_url_manifest attribute.
    /// </summary>
    public TerraformValue<string> BaseUrlManifest
    {
        get => GetArgument<TerraformValue<string>>("base_url_manifest") ?? AsReference("base_url_manifest");
        set => SetArgument("base_url_manifest", value);
    }

    /// <summary>
    /// The base_url_manifest1 attribute.
    /// </summary>
    public TerraformValue<string> BaseUrlManifest1
    {
        get => GetArgument<TerraformValue<string>>("base_url_manifest1") ?? AsReference("base_url_manifest1");
        set => SetArgument("base_url_manifest1", value);
    }

    /// <summary>
    /// The caption_language_setting attribute.
    /// </summary>
    public TerraformValue<string> CaptionLanguageSetting
    {
        get => GetArgument<TerraformValue<string>>("caption_language_setting") ?? AsReference("caption_language_setting");
        set => SetArgument("caption_language_setting", value);
    }

    /// <summary>
    /// The client_cache attribute.
    /// </summary>
    public TerraformValue<string> ClientCache
    {
        get => GetArgument<TerraformValue<string>>("client_cache") ?? AsReference("client_cache");
        set => SetArgument("client_cache", value);
    }

    /// <summary>
    /// The codec_specification attribute.
    /// </summary>
    public TerraformValue<string> CodecSpecification
    {
        get => GetArgument<TerraformValue<string>>("codec_specification") ?? AsReference("codec_specification");
        set => SetArgument("codec_specification", value);
    }

    /// <summary>
    /// The constant_iv attribute.
    /// </summary>
    public TerraformValue<string> ConstantIv
    {
        get => GetArgument<TerraformValue<string>>("constant_iv") ?? AsReference("constant_iv");
        set => SetArgument("constant_iv", value);
    }

    /// <summary>
    /// The directory_structure attribute.
    /// </summary>
    public TerraformValue<string> DirectoryStructure
    {
        get => GetArgument<TerraformValue<string>>("directory_structure") ?? AsReference("directory_structure");
        set => SetArgument("directory_structure", value);
    }

    /// <summary>
    /// The discontinuity_tags attribute.
    /// </summary>
    public TerraformValue<string> DiscontinuityTags
    {
        get => GetArgument<TerraformValue<string>>("discontinuity_tags") ?? AsReference("discontinuity_tags");
        set => SetArgument("discontinuity_tags", value);
    }

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string> EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type") ?? AsReference("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The hls_id3_segment_tagging attribute.
    /// </summary>
    public TerraformValue<string> HlsId3SegmentTagging
    {
        get => GetArgument<TerraformValue<string>>("hls_id3_segment_tagging") ?? AsReference("hls_id3_segment_tagging");
        set => SetArgument("hls_id3_segment_tagging", value);
    }

    /// <summary>
    /// The iframe_only_playlists attribute.
    /// </summary>
    public TerraformValue<string> IframeOnlyPlaylists
    {
        get => GetArgument<TerraformValue<string>>("iframe_only_playlists") ?? AsReference("iframe_only_playlists");
        set => SetArgument("iframe_only_playlists", value);
    }

    /// <summary>
    /// The incomplete_segment_behavior attribute.
    /// </summary>
    public TerraformValue<string> IncompleteSegmentBehavior
    {
        get => GetArgument<TerraformValue<string>>("incomplete_segment_behavior") ?? AsReference("incomplete_segment_behavior");
        set => SetArgument("incomplete_segment_behavior", value);
    }

    /// <summary>
    /// The index_n_segments attribute.
    /// </summary>
    public TerraformValue<double> IndexNSegments
    {
        get => GetArgument<TerraformValue<double>>("index_n_segments") ?? AsReference("index_n_segments");
        set => SetArgument("index_n_segments", value);
    }

    /// <summary>
    /// The input_loss_action attribute.
    /// </summary>
    public TerraformValue<string> InputLossAction
    {
        get => GetArgument<TerraformValue<string>>("input_loss_action") ?? AsReference("input_loss_action");
        set => SetArgument("input_loss_action", value);
    }

    /// <summary>
    /// The iv_in_manifest attribute.
    /// </summary>
    public TerraformValue<string> IvInManifest
    {
        get => GetArgument<TerraformValue<string>>("iv_in_manifest") ?? AsReference("iv_in_manifest");
        set => SetArgument("iv_in_manifest", value);
    }

    /// <summary>
    /// The iv_source attribute.
    /// </summary>
    public TerraformValue<string> IvSource
    {
        get => GetArgument<TerraformValue<string>>("iv_source") ?? AsReference("iv_source");
        set => SetArgument("iv_source", value);
    }

    /// <summary>
    /// The keep_segments attribute.
    /// </summary>
    public TerraformValue<double> KeepSegments
    {
        get => GetArgument<TerraformValue<double>>("keep_segments") ?? AsReference("keep_segments");
        set => SetArgument("keep_segments", value);
    }

    /// <summary>
    /// The key_format attribute.
    /// </summary>
    public TerraformValue<string> KeyFormat
    {
        get => GetArgument<TerraformValue<string>>("key_format") ?? AsReference("key_format");
        set => SetArgument("key_format", value);
    }

    /// <summary>
    /// The key_format_versions attribute.
    /// </summary>
    public TerraformValue<string> KeyFormatVersions
    {
        get => GetArgument<TerraformValue<string>>("key_format_versions") ?? AsReference("key_format_versions");
        set => SetArgument("key_format_versions", value);
    }

    /// <summary>
    /// The manifest_compression attribute.
    /// </summary>
    public TerraformValue<string> ManifestCompression
    {
        get => GetArgument<TerraformValue<string>>("manifest_compression") ?? AsReference("manifest_compression");
        set => SetArgument("manifest_compression", value);
    }

    /// <summary>
    /// The manifest_duration_format attribute.
    /// </summary>
    public TerraformValue<string> ManifestDurationFormat
    {
        get => GetArgument<TerraformValue<string>>("manifest_duration_format") ?? AsReference("manifest_duration_format");
        set => SetArgument("manifest_duration_format", value);
    }

    /// <summary>
    /// The min_segment_length attribute.
    /// </summary>
    public TerraformValue<double> MinSegmentLength
    {
        get => GetArgument<TerraformValue<double>>("min_segment_length") ?? AsReference("min_segment_length");
        set => SetArgument("min_segment_length", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? AsReference("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The output_selection attribute.
    /// </summary>
    public TerraformValue<string> OutputSelection
    {
        get => GetArgument<TerraformValue<string>>("output_selection") ?? AsReference("output_selection");
        set => SetArgument("output_selection", value);
    }

    /// <summary>
    /// The program_date_time attribute.
    /// </summary>
    public TerraformValue<string> ProgramDateTime
    {
        get => GetArgument<TerraformValue<string>>("program_date_time") ?? AsReference("program_date_time");
        set => SetArgument("program_date_time", value);
    }

    /// <summary>
    /// The program_date_time_clock attribute.
    /// </summary>
    public TerraformValue<string> ProgramDateTimeClock
    {
        get => GetArgument<TerraformValue<string>>("program_date_time_clock") ?? AsReference("program_date_time_clock");
        set => SetArgument("program_date_time_clock", value);
    }

    /// <summary>
    /// The program_date_time_period attribute.
    /// </summary>
    public TerraformValue<double> ProgramDateTimePeriod
    {
        get => GetArgument<TerraformValue<double>>("program_date_time_period") ?? AsReference("program_date_time_period");
        set => SetArgument("program_date_time_period", value);
    }

    /// <summary>
    /// The redundant_manifest attribute.
    /// </summary>
    public TerraformValue<string> RedundantManifest
    {
        get => GetArgument<TerraformValue<string>>("redundant_manifest") ?? AsReference("redundant_manifest");
        set => SetArgument("redundant_manifest", value);
    }

    /// <summary>
    /// The segment_length attribute.
    /// </summary>
    public TerraformValue<double> SegmentLength
    {
        get => GetArgument<TerraformValue<double>>("segment_length") ?? AsReference("segment_length");
        set => SetArgument("segment_length", value);
    }

    /// <summary>
    /// The segments_per_subdirectory attribute.
    /// </summary>
    public TerraformValue<double> SegmentsPerSubdirectory
    {
        get => GetArgument<TerraformValue<double>>("segments_per_subdirectory") ?? AsReference("segments_per_subdirectory");
        set => SetArgument("segments_per_subdirectory", value);
    }

    /// <summary>
    /// The stream_inf_resolution attribute.
    /// </summary>
    public TerraformValue<string> StreamInfResolution
    {
        get => GetArgument<TerraformValue<string>>("stream_inf_resolution") ?? AsReference("stream_inf_resolution");
        set => SetArgument("stream_inf_resolution", value);
    }

    /// <summary>
    /// The timed_metadata_id3_frame attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataId3Frame
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_id3_frame") ?? AsReference("timed_metadata_id3_frame");
        set => SetArgument("timed_metadata_id3_frame", value);
    }

    /// <summary>
    /// The timed_metadata_id3_period attribute.
    /// </summary>
    public TerraformValue<double> TimedMetadataId3Period
    {
        get => GetArgument<TerraformValue<double>>("timed_metadata_id3_period") ?? AsReference("timed_metadata_id3_period");
        set => SetArgument("timed_metadata_id3_period", value);
    }

    /// <summary>
    /// The timestamp_delta_milliseconds attribute.
    /// </summary>
    public TerraformValue<double> TimestampDeltaMilliseconds
    {
        get => GetArgument<TerraformValue<double>>("timestamp_delta_milliseconds") ?? AsReference("timestamp_delta_milliseconds");
        set => SetArgument("timestamp_delta_milliseconds", value);
    }

    /// <summary>
    /// The ts_file_mode attribute.
    /// </summary>
    public TerraformValue<string> TsFileMode
    {
        get => GetArgument<TerraformValue<string>>("ts_file_mode") ?? AsReference("ts_file_mode");
        set => SetArgument("ts_file_mode", value);
    }

    /// <summary>
    /// CaptionLanguageMappings block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 CaptionLanguageMappings block(s) allowed")]
    public TerraformSet<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockCaptionLanguageMappingsBlock>? CaptionLanguageMappings
    {
        get => GetArgument<TerraformSet<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockCaptionLanguageMappingsBlock>>("caption_language_mappings");
        set => SetArgument("caption_language_mappings", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// HlsCdnSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock>? HlsCdnSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock>>("hls_cdn_settings");
        set => SetArgument("hls_cdn_settings", value);
    }

    /// <summary>
    /// KeyProviderSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyProviderSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlock>? KeyProviderSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlock>>("key_provider_settings");
        set => SetArgument("key_provider_settings", value);
    }

}

/// <summary>
/// Block type for caption_language_mappings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockCaptionLanguageMappingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "caption_language_mappings";

    /// <summary>
    /// The caption_channel attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CaptionChannel is required")]
    public required TerraformValue<double> CaptionChannel
    {
        get => GetRequiredArgument<TerraformValue<double>>("caption_channel");
        set => SetArgument("caption_channel", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageDescription is required")]
    public required TerraformValue<string> LanguageDescription
    {
        get => GetRequiredArgument<TerraformValue<string>>("language_description");
        set => SetArgument("language_description", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for hls_cdn_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_cdn_settings";

    /// <summary>
    /// HlsAkamaiSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsAkamaiSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsAkamaiSettingsBlock>? HlsAkamaiSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsAkamaiSettingsBlock>>("hls_akamai_settings");
        set => SetArgument("hls_akamai_settings", value);
    }

    /// <summary>
    /// HlsBasicPutSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsBasicPutSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsBasicPutSettingsBlock>? HlsBasicPutSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsBasicPutSettingsBlock>>("hls_basic_put_settings");
        set => SetArgument("hls_basic_put_settings", value);
    }

    /// <summary>
    /// HlsMediaStoreSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsMediaStoreSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsMediaStoreSettingsBlock>? HlsMediaStoreSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsMediaStoreSettingsBlock>>("hls_media_store_settings");
        set => SetArgument("hls_media_store_settings", value);
    }

    /// <summary>
    /// HlsS3Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsS3Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsS3SettingsBlock>? HlsS3Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsS3SettingsBlock>>("hls_s3_settings");
        set => SetArgument("hls_s3_settings", value);
    }

    /// <summary>
    /// HlsWebdavSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsWebdavSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsWebdavSettingsBlock>? HlsWebdavSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsWebdavSettingsBlock>>("hls_webdav_settings");
        set => SetArgument("hls_webdav_settings", value);
    }

}

/// <summary>
/// Block type for hls_akamai_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsAkamaiSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_akamai_settings";

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The filecache_duration attribute.
    /// </summary>
    public TerraformValue<double>? FilecacheDuration
    {
        get => GetArgument<TerraformValue<double>>("filecache_duration");
        set => SetArgument("filecache_duration", value);
    }

    /// <summary>
    /// The http_transfer_mode attribute.
    /// </summary>
    public TerraformValue<string> HttpTransferMode
    {
        get => GetArgument<TerraformValue<string>>("http_transfer_mode") ?? AsReference("http_transfer_mode");
        set => SetArgument("http_transfer_mode", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

    /// <summary>
    /// The salt attribute.
    /// </summary>
    public TerraformValue<string> Salt
    {
        get => GetArgument<TerraformValue<string>>("salt") ?? AsReference("salt");
        set => SetArgument("salt", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformValue<string> Token
    {
        get => GetArgument<TerraformValue<string>>("token") ?? AsReference("token");
        set => SetArgument("token", value);
    }

}

/// <summary>
/// Block type for hls_basic_put_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsBasicPutSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_basic_put_settings";

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The filecache_duration attribute.
    /// </summary>
    public TerraformValue<double>? FilecacheDuration
    {
        get => GetArgument<TerraformValue<double>>("filecache_duration");
        set => SetArgument("filecache_duration", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

}

/// <summary>
/// Block type for hls_media_store_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsMediaStoreSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_media_store_settings";

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The filecache_duration attribute.
    /// </summary>
    public TerraformValue<double>? FilecacheDuration
    {
        get => GetArgument<TerraformValue<double>>("filecache_duration");
        set => SetArgument("filecache_duration", value);
    }

    /// <summary>
    /// The media_store_storage_class attribute.
    /// </summary>
    public TerraformValue<string> MediaStoreStorageClass
    {
        get => GetArgument<TerraformValue<string>>("media_store_storage_class") ?? AsReference("media_store_storage_class");
        set => SetArgument("media_store_storage_class", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

}

/// <summary>
/// Block type for hls_s3_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsS3SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_s3_settings";

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformValue<string>? CannedAcl
    {
        get => GetArgument<TerraformValue<string>>("canned_acl");
        set => SetArgument("canned_acl", value);
    }

}

/// <summary>
/// Block type for hls_webdav_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockHlsCdnSettingsBlockHlsWebdavSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_webdav_settings";

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The filecache_duration attribute.
    /// </summary>
    public TerraformValue<double>? FilecacheDuration
    {
        get => GetArgument<TerraformValue<double>>("filecache_duration");
        set => SetArgument("filecache_duration", value);
    }

    /// <summary>
    /// The http_transfer_mode attribute.
    /// </summary>
    public TerraformValue<string> HttpTransferMode
    {
        get => GetArgument<TerraformValue<string>>("http_transfer_mode") ?? AsReference("http_transfer_mode");
        set => SetArgument("http_transfer_mode", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

}

/// <summary>
/// Block type for key_provider_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_provider_settings";

    /// <summary>
    /// StaticKeySettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlock>? StaticKeySettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlock>>("static_key_settings");
        set => SetArgument("static_key_settings", value);
    }

}

/// <summary>
/// Block type for static_key_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_key_settings";

    /// <summary>
    /// The static_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticKeyValue is required")]
    public required TerraformValue<string> StaticKeyValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("static_key_value");
        set => SetArgument("static_key_value", value);
    }

    /// <summary>
    /// KeyProviderServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyProviderServer block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlockKeyProviderServerBlock>? KeyProviderServer
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlockKeyProviderServerBlock>>("key_provider_server");
        set => SetArgument("key_provider_server", value);
    }

}

/// <summary>
/// Block type for key_provider_server in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockHlsGroupSettingsBlockKeyProviderSettingsBlockStaticKeySettingsBlockKeyProviderServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_provider_server";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for media_package_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_package_group_settings";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMediaPackageGroupSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for ms_smooth_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ms_smooth_group_settings";

    /// <summary>
    /// The acquisition_point_id attribute.
    /// </summary>
    public TerraformValue<string> AcquisitionPointId
    {
        get => GetArgument<TerraformValue<string>>("acquisition_point_id") ?? AsReference("acquisition_point_id");
        set => SetArgument("acquisition_point_id", value);
    }

    /// <summary>
    /// The audio_only_timecode_control attribute.
    /// </summary>
    public TerraformValue<string> AudioOnlyTimecodeControl
    {
        get => GetArgument<TerraformValue<string>>("audio_only_timecode_control") ?? AsReference("audio_only_timecode_control");
        set => SetArgument("audio_only_timecode_control", value);
    }

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> CertificateMode
    {
        get => GetArgument<TerraformValue<string>>("certificate_mode") ?? AsReference("certificate_mode");
        set => SetArgument("certificate_mode", value);
    }

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double> ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval") ?? AsReference("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The event_id attribute.
    /// </summary>
    public TerraformValue<string> EventId
    {
        get => GetArgument<TerraformValue<string>>("event_id") ?? AsReference("event_id");
        set => SetArgument("event_id", value);
    }

    /// <summary>
    /// The event_id_mode attribute.
    /// </summary>
    public TerraformValue<string> EventIdMode
    {
        get => GetArgument<TerraformValue<string>>("event_id_mode") ?? AsReference("event_id_mode");
        set => SetArgument("event_id_mode", value);
    }

    /// <summary>
    /// The event_stop_behavior attribute.
    /// </summary>
    public TerraformValue<string> EventStopBehavior
    {
        get => GetArgument<TerraformValue<string>>("event_stop_behavior") ?? AsReference("event_stop_behavior");
        set => SetArgument("event_stop_behavior", value);
    }

    /// <summary>
    /// The filecache_duration attribute.
    /// </summary>
    public TerraformValue<double>? FilecacheDuration
    {
        get => GetArgument<TerraformValue<double>>("filecache_duration");
        set => SetArgument("filecache_duration", value);
    }

    /// <summary>
    /// The fragment_length attribute.
    /// </summary>
    public TerraformValue<double> FragmentLength
    {
        get => GetArgument<TerraformValue<double>>("fragment_length") ?? AsReference("fragment_length");
        set => SetArgument("fragment_length", value);
    }

    /// <summary>
    /// The input_loss_action attribute.
    /// </summary>
    public TerraformValue<string> InputLossAction
    {
        get => GetArgument<TerraformValue<string>>("input_loss_action") ?? AsReference("input_loss_action");
        set => SetArgument("input_loss_action", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double>? NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

    /// <summary>
    /// The segmentation_mode attribute.
    /// </summary>
    public TerraformValue<string> SegmentationMode
    {
        get => GetArgument<TerraformValue<string>>("segmentation_mode") ?? AsReference("segmentation_mode");
        set => SetArgument("segmentation_mode", value);
    }

    /// <summary>
    /// The send_delay_ms attribute.
    /// </summary>
    public TerraformValue<double> SendDelayMs
    {
        get => GetArgument<TerraformValue<double>>("send_delay_ms") ?? AsReference("send_delay_ms");
        set => SetArgument("send_delay_ms", value);
    }

    /// <summary>
    /// The sparse_track_type attribute.
    /// </summary>
    public TerraformValue<string> SparseTrackType
    {
        get => GetArgument<TerraformValue<string>>("sparse_track_type") ?? AsReference("sparse_track_type");
        set => SetArgument("sparse_track_type", value);
    }

    /// <summary>
    /// The stream_manifest_behavior attribute.
    /// </summary>
    public TerraformValue<string> StreamManifestBehavior
    {
        get => GetArgument<TerraformValue<string>>("stream_manifest_behavior") ?? AsReference("stream_manifest_behavior");
        set => SetArgument("stream_manifest_behavior", value);
    }

    /// <summary>
    /// The timestamp_offset attribute.
    /// </summary>
    public TerraformValue<string> TimestampOffset
    {
        get => GetArgument<TerraformValue<string>>("timestamp_offset") ?? AsReference("timestamp_offset");
        set => SetArgument("timestamp_offset", value);
    }

    /// <summary>
    /// The timestamp_offset_mode attribute.
    /// </summary>
    public TerraformValue<string> TimestampOffsetMode
    {
        get => GetArgument<TerraformValue<string>>("timestamp_offset_mode") ?? AsReference("timestamp_offset_mode");
        set => SetArgument("timestamp_offset_mode", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMsSmoothGroupSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for multiplex_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockMultiplexGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiplex_group_settings";

}

/// <summary>
/// Block type for rtmp_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockRtmpGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rtmp_group_settings";

    /// <summary>
    /// The ad_markers attribute.
    /// </summary>
    public TerraformList<string>? AdMarkers
    {
        get => GetArgument<TerraformList<string>>("ad_markers");
        set => SetArgument("ad_markers", value);
    }

    /// <summary>
    /// The authentication_scheme attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationScheme
    {
        get => GetArgument<TerraformValue<string>>("authentication_scheme") ?? AsReference("authentication_scheme");
        set => SetArgument("authentication_scheme", value);
    }

    /// <summary>
    /// The cache_full_behavior attribute.
    /// </summary>
    public TerraformValue<string> CacheFullBehavior
    {
        get => GetArgument<TerraformValue<string>>("cache_full_behavior") ?? AsReference("cache_full_behavior");
        set => SetArgument("cache_full_behavior", value);
    }

    /// <summary>
    /// The cache_length attribute.
    /// </summary>
    public TerraformValue<double> CacheLength
    {
        get => GetArgument<TerraformValue<double>>("cache_length") ?? AsReference("cache_length");
        set => SetArgument("cache_length", value);
    }

    /// <summary>
    /// The caption_data attribute.
    /// </summary>
    public TerraformValue<string> CaptionData
    {
        get => GetArgument<TerraformValue<string>>("caption_data") ?? AsReference("caption_data");
        set => SetArgument("caption_data", value);
    }

    /// <summary>
    /// The input_loss_action attribute.
    /// </summary>
    public TerraformValue<string> InputLossAction
    {
        get => GetArgument<TerraformValue<string>>("input_loss_action") ?? AsReference("input_loss_action");
        set => SetArgument("input_loss_action", value);
    }

    /// <summary>
    /// The restart_delay attribute.
    /// </summary>
    public TerraformValue<double>? RestartDelay
    {
        get => GetArgument<TerraformValue<double>>("restart_delay");
        set => SetArgument("restart_delay", value);
    }

}

/// <summary>
/// Block type for udp_group_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputGroupSettingsBlockUdpGroupSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "udp_group_settings";

    /// <summary>
    /// The input_loss_action attribute.
    /// </summary>
    public TerraformValue<string> InputLossAction
    {
        get => GetArgument<TerraformValue<string>>("input_loss_action") ?? AsReference("input_loss_action");
        set => SetArgument("input_loss_action", value);
    }

    /// <summary>
    /// The timed_metadata_id3_frame attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataId3Frame
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_id3_frame") ?? AsReference("timed_metadata_id3_frame");
        set => SetArgument("timed_metadata_id3_frame", value);
    }

    /// <summary>
    /// The timed_metadata_id3_period attribute.
    /// </summary>
    public TerraformValue<double> TimedMetadataId3Period
    {
        get => GetArgument<TerraformValue<double>>("timed_metadata_id3_period") ?? AsReference("timed_metadata_id3_period");
        set => SetArgument("timed_metadata_id3_period", value);
    }

}

/// <summary>
/// Block type for outputs in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outputs";

    /// <summary>
    /// The audio_description_names attribute.
    /// </summary>
    public TerraformSet<string>? AudioDescriptionNames
    {
        get => GetArgument<TerraformSet<string>>("audio_description_names");
        set => SetArgument("audio_description_names", value);
    }

    /// <summary>
    /// The caption_description_names attribute.
    /// </summary>
    public TerraformSet<string> CaptionDescriptionNames
    {
        get => GetArgument<TerraformSet<string>>("caption_description_names") ?? AsReference("caption_description_names");
        set => SetArgument("caption_description_names", value);
    }

    /// <summary>
    /// The output_name attribute.
    /// </summary>
    public TerraformValue<string>? OutputName
    {
        get => GetArgument<TerraformValue<string>>("output_name");
        set => SetArgument("output_name", value);
    }

    /// <summary>
    /// The video_description_name attribute.
    /// </summary>
    public TerraformValue<string>? VideoDescriptionName
    {
        get => GetArgument<TerraformValue<string>>("video_description_name");
        set => SetArgument("video_description_name", value);
    }

    /// <summary>
    /// OutputSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock> OutputSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock>>("output_settings");
        set => SetArgument("output_settings", value);
    }

}

/// <summary>
/// Block type for output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_settings";

    /// <summary>
    /// ArchiveOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArchiveOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlock>? ArchiveOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlock>>("archive_output_settings");
        set => SetArgument("archive_output_settings", value);
    }

    /// <summary>
    /// FrameCaptureOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockFrameCaptureOutputSettingsBlock>? FrameCaptureOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockFrameCaptureOutputSettingsBlock>>("frame_capture_output_settings");
        set => SetArgument("frame_capture_output_settings", value);
    }

    /// <summary>
    /// HlsOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlock>? HlsOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlock>>("hls_output_settings");
        set => SetArgument("hls_output_settings", value);
    }

    /// <summary>
    /// MediaPackageOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MediaPackageOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMediaPackageOutputSettingsBlock>? MediaPackageOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMediaPackageOutputSettingsBlock>>("media_package_output_settings");
        set => SetArgument("media_package_output_settings", value);
    }

    /// <summary>
    /// MsSmoothOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MsSmoothOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMsSmoothOutputSettingsBlock>? MsSmoothOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMsSmoothOutputSettingsBlock>>("ms_smooth_output_settings");
        set => SetArgument("ms_smooth_output_settings", value);
    }

    /// <summary>
    /// MultiplexOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlock>? MultiplexOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlock>>("multiplex_output_settings");
        set => SetArgument("multiplex_output_settings", value);
    }

    /// <summary>
    /// RtmpOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RtmpOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlock>? RtmpOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlock>>("rtmp_output_settings");
        set => SetArgument("rtmp_output_settings", value);
    }

    /// <summary>
    /// UdpOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UdpOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock>? UdpOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock>>("udp_output_settings");
        set => SetArgument("udp_output_settings", value);
    }

}

/// <summary>
/// Block type for archive_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "archive_output_settings";

    /// <summary>
    /// The extension attribute.
    /// </summary>
    public TerraformValue<string>? Extension
    {
        get => GetArgument<TerraformValue<string>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The name_modifier attribute.
    /// </summary>
    public TerraformValue<string>? NameModifier
    {
        get => GetArgument<TerraformValue<string>>("name_modifier");
        set => SetArgument("name_modifier", value);
    }

    /// <summary>
    /// ContainerSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlock>? ContainerSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlock>>("container_settings");
        set => SetArgument("container_settings", value);
    }

}

/// <summary>
/// Block type for container_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_settings";

    /// <summary>
    /// M2tsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 M2tsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock>? M2tsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock>>("m2ts_settings");
        set => SetArgument("m2ts_settings", value);
    }

    /// <summary>
    /// RawSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RawSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockRawSettingsBlock>? RawSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockRawSettingsBlock>>("raw_settings");
        set => SetArgument("raw_settings", value);
    }

}

/// <summary>
/// Block type for m2ts_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "m2ts_settings";

    /// <summary>
    /// The absent_input_audio_behavior attribute.
    /// </summary>
    public TerraformValue<string> AbsentInputAudioBehavior
    {
        get => GetArgument<TerraformValue<string>>("absent_input_audio_behavior") ?? AsReference("absent_input_audio_behavior");
        set => SetArgument("absent_input_audio_behavior", value);
    }

    /// <summary>
    /// The arib attribute.
    /// </summary>
    public TerraformValue<string>? Arib
    {
        get => GetArgument<TerraformValue<string>>("arib");
        set => SetArgument("arib", value);
    }

    /// <summary>
    /// The arib_captions_pid attribute.
    /// </summary>
    public TerraformValue<string> AribCaptionsPid
    {
        get => GetArgument<TerraformValue<string>>("arib_captions_pid") ?? AsReference("arib_captions_pid");
        set => SetArgument("arib_captions_pid", value);
    }

    /// <summary>
    /// The arib_captions_pid_control attribute.
    /// </summary>
    public TerraformValue<string>? AribCaptionsPidControl
    {
        get => GetArgument<TerraformValue<string>>("arib_captions_pid_control");
        set => SetArgument("arib_captions_pid_control", value);
    }

    /// <summary>
    /// The audio_buffer_model attribute.
    /// </summary>
    public TerraformValue<string>? AudioBufferModel
    {
        get => GetArgument<TerraformValue<string>>("audio_buffer_model");
        set => SetArgument("audio_buffer_model", value);
    }

    /// <summary>
    /// The audio_frames_per_pes attribute.
    /// </summary>
    public TerraformValue<double>? AudioFramesPerPes
    {
        get => GetArgument<TerraformValue<double>>("audio_frames_per_pes");
        set => SetArgument("audio_frames_per_pes", value);
    }

    /// <summary>
    /// The audio_pids attribute.
    /// </summary>
    public TerraformValue<string> AudioPids
    {
        get => GetArgument<TerraformValue<string>>("audio_pids") ?? AsReference("audio_pids");
        set => SetArgument("audio_pids", value);
    }

    /// <summary>
    /// The audio_stream_type attribute.
    /// </summary>
    public TerraformValue<string>? AudioStreamType
    {
        get => GetArgument<TerraformValue<string>>("audio_stream_type");
        set => SetArgument("audio_stream_type", value);
    }

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double>? Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The buffer_model attribute.
    /// </summary>
    public TerraformValue<string>? BufferModel
    {
        get => GetArgument<TerraformValue<string>>("buffer_model");
        set => SetArgument("buffer_model", value);
    }

    /// <summary>
    /// The cc_descriptor attribute.
    /// </summary>
    public TerraformValue<string>? CcDescriptor
    {
        get => GetArgument<TerraformValue<string>>("cc_descriptor");
        set => SetArgument("cc_descriptor", value);
    }

    /// <summary>
    /// The dvb_sub_pids attribute.
    /// </summary>
    public TerraformValue<string> DvbSubPids
    {
        get => GetArgument<TerraformValue<string>>("dvb_sub_pids") ?? AsReference("dvb_sub_pids");
        set => SetArgument("dvb_sub_pids", value);
    }

    /// <summary>
    /// The dvb_teletext_pid attribute.
    /// </summary>
    public TerraformValue<string> DvbTeletextPid
    {
        get => GetArgument<TerraformValue<string>>("dvb_teletext_pid") ?? AsReference("dvb_teletext_pid");
        set => SetArgument("dvb_teletext_pid", value);
    }

    /// <summary>
    /// The ebif attribute.
    /// </summary>
    public TerraformValue<string>? Ebif
    {
        get => GetArgument<TerraformValue<string>>("ebif");
        set => SetArgument("ebif", value);
    }

    /// <summary>
    /// The ebp_audio_interval attribute.
    /// </summary>
    public TerraformValue<string>? EbpAudioInterval
    {
        get => GetArgument<TerraformValue<string>>("ebp_audio_interval");
        set => SetArgument("ebp_audio_interval", value);
    }

    /// <summary>
    /// The ebp_lookahead_ms attribute.
    /// </summary>
    public TerraformValue<double>? EbpLookaheadMs
    {
        get => GetArgument<TerraformValue<double>>("ebp_lookahead_ms");
        set => SetArgument("ebp_lookahead_ms", value);
    }

    /// <summary>
    /// The ebp_placement attribute.
    /// </summary>
    public TerraformValue<string>? EbpPlacement
    {
        get => GetArgument<TerraformValue<string>>("ebp_placement");
        set => SetArgument("ebp_placement", value);
    }

    /// <summary>
    /// The ecm_pid attribute.
    /// </summary>
    public TerraformValue<string>? EcmPid
    {
        get => GetArgument<TerraformValue<string>>("ecm_pid");
        set => SetArgument("ecm_pid", value);
    }

    /// <summary>
    /// The es_rate_in_pes attribute.
    /// </summary>
    public TerraformValue<string>? EsRateInPes
    {
        get => GetArgument<TerraformValue<string>>("es_rate_in_pes");
        set => SetArgument("es_rate_in_pes", value);
    }

    /// <summary>
    /// The etv_platform_pid attribute.
    /// </summary>
    public TerraformValue<string> EtvPlatformPid
    {
        get => GetArgument<TerraformValue<string>>("etv_platform_pid") ?? AsReference("etv_platform_pid");
        set => SetArgument("etv_platform_pid", value);
    }

    /// <summary>
    /// The etv_signal_pid attribute.
    /// </summary>
    public TerraformValue<string> EtvSignalPid
    {
        get => GetArgument<TerraformValue<string>>("etv_signal_pid") ?? AsReference("etv_signal_pid");
        set => SetArgument("etv_signal_pid", value);
    }

    /// <summary>
    /// The fragment_time attribute.
    /// </summary>
    public TerraformValue<double>? FragmentTime
    {
        get => GetArgument<TerraformValue<double>>("fragment_time");
        set => SetArgument("fragment_time", value);
    }

    /// <summary>
    /// The klv attribute.
    /// </summary>
    public TerraformValue<string>? Klv
    {
        get => GetArgument<TerraformValue<string>>("klv");
        set => SetArgument("klv", value);
    }

    /// <summary>
    /// The klv_data_pids attribute.
    /// </summary>
    public TerraformValue<string> KlvDataPids
    {
        get => GetArgument<TerraformValue<string>>("klv_data_pids") ?? AsReference("klv_data_pids");
        set => SetArgument("klv_data_pids", value);
    }

    /// <summary>
    /// The nielsen_id3_behavior attribute.
    /// </summary>
    public TerraformValue<string>? NielsenId3Behavior
    {
        get => GetArgument<TerraformValue<string>>("nielsen_id3_behavior");
        set => SetArgument("nielsen_id3_behavior", value);
    }

    /// <summary>
    /// The null_packet_bitrate attribute.
    /// </summary>
    public TerraformValue<double>? NullPacketBitrate
    {
        get => GetArgument<TerraformValue<double>>("null_packet_bitrate");
        set => SetArgument("null_packet_bitrate", value);
    }

    /// <summary>
    /// The pat_interval attribute.
    /// </summary>
    public TerraformValue<double>? PatInterval
    {
        get => GetArgument<TerraformValue<double>>("pat_interval");
        set => SetArgument("pat_interval", value);
    }

    /// <summary>
    /// The pcr_control attribute.
    /// </summary>
    public TerraformValue<string>? PcrControl
    {
        get => GetArgument<TerraformValue<string>>("pcr_control");
        set => SetArgument("pcr_control", value);
    }

    /// <summary>
    /// The pcr_period attribute.
    /// </summary>
    public TerraformValue<double>? PcrPeriod
    {
        get => GetArgument<TerraformValue<double>>("pcr_period");
        set => SetArgument("pcr_period", value);
    }

    /// <summary>
    /// The pcr_pid attribute.
    /// </summary>
    public TerraformValue<string>? PcrPid
    {
        get => GetArgument<TerraformValue<string>>("pcr_pid");
        set => SetArgument("pcr_pid", value);
    }

    /// <summary>
    /// The pmt_interval attribute.
    /// </summary>
    public TerraformValue<double>? PmtInterval
    {
        get => GetArgument<TerraformValue<double>>("pmt_interval");
        set => SetArgument("pmt_interval", value);
    }

    /// <summary>
    /// The pmt_pid attribute.
    /// </summary>
    public TerraformValue<string> PmtPid
    {
        get => GetArgument<TerraformValue<string>>("pmt_pid") ?? AsReference("pmt_pid");
        set => SetArgument("pmt_pid", value);
    }

    /// <summary>
    /// The program_num attribute.
    /// </summary>
    public TerraformValue<double>? ProgramNum
    {
        get => GetArgument<TerraformValue<double>>("program_num");
        set => SetArgument("program_num", value);
    }

    /// <summary>
    /// The rate_mode attribute.
    /// </summary>
    public TerraformValue<string>? RateMode
    {
        get => GetArgument<TerraformValue<string>>("rate_mode");
        set => SetArgument("rate_mode", value);
    }

    /// <summary>
    /// The scte27_pids attribute.
    /// </summary>
    public TerraformValue<string> Scte27Pids
    {
        get => GetArgument<TerraformValue<string>>("scte27_pids") ?? AsReference("scte27_pids");
        set => SetArgument("scte27_pids", value);
    }

    /// <summary>
    /// The scte35_control attribute.
    /// </summary>
    public TerraformValue<string>? Scte35Control
    {
        get => GetArgument<TerraformValue<string>>("scte35_control");
        set => SetArgument("scte35_control", value);
    }

    /// <summary>
    /// The scte35_pid attribute.
    /// </summary>
    public TerraformValue<string> Scte35Pid
    {
        get => GetArgument<TerraformValue<string>>("scte35_pid") ?? AsReference("scte35_pid");
        set => SetArgument("scte35_pid", value);
    }

    /// <summary>
    /// The segmentation_markers attribute.
    /// </summary>
    public TerraformValue<string>? SegmentationMarkers
    {
        get => GetArgument<TerraformValue<string>>("segmentation_markers");
        set => SetArgument("segmentation_markers", value);
    }

    /// <summary>
    /// The segmentation_style attribute.
    /// </summary>
    public TerraformValue<string>? SegmentationStyle
    {
        get => GetArgument<TerraformValue<string>>("segmentation_style");
        set => SetArgument("segmentation_style", value);
    }

    /// <summary>
    /// The segmentation_time attribute.
    /// </summary>
    public TerraformValue<double>? SegmentationTime
    {
        get => GetArgument<TerraformValue<double>>("segmentation_time");
        set => SetArgument("segmentation_time", value);
    }

    /// <summary>
    /// The timed_metadata_behavior attribute.
    /// </summary>
    public TerraformValue<string>? TimedMetadataBehavior
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_behavior");
        set => SetArgument("timed_metadata_behavior", value);
    }

    /// <summary>
    /// The timed_metadata_pid attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataPid
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_pid") ?? AsReference("timed_metadata_pid");
        set => SetArgument("timed_metadata_pid", value);
    }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    public TerraformValue<double>? TransportStreamId
    {
        get => GetArgument<TerraformValue<double>>("transport_stream_id");
        set => SetArgument("transport_stream_id", value);
    }

    /// <summary>
    /// The video_pid attribute.
    /// </summary>
    public TerraformValue<string> VideoPid
    {
        get => GetArgument<TerraformValue<string>>("video_pid") ?? AsReference("video_pid");
        set => SetArgument("video_pid", value);
    }

    /// <summary>
    /// DvbNitSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbNitSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock>? DvbNitSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock>>("dvb_nit_settings");
        set => SetArgument("dvb_nit_settings", value);
    }

    /// <summary>
    /// DvbSdtSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbSdtSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock>? DvbSdtSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock>>("dvb_sdt_settings");
        set => SetArgument("dvb_sdt_settings", value);
    }

    /// <summary>
    /// DvbTdtSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbTdtSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock>? DvbTdtSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock>>("dvb_tdt_settings");
        set => SetArgument("dvb_tdt_settings", value);
    }

}

/// <summary>
/// Block type for dvb_nit_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_nit_settings";

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkId is required")]
    public required TerraformValue<double> NetworkId
    {
        get => GetRequiredArgument<TerraformValue<double>>("network_id");
        set => SetArgument("network_id", value);
    }

    /// <summary>
    /// The network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkName is required")]
    public required TerraformValue<string> NetworkName
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_name");
        set => SetArgument("network_name", value);
    }

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

}

/// <summary>
/// Block type for dvb_sdt_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_sdt_settings";

    /// <summary>
    /// The output_sdt attribute.
    /// </summary>
    public TerraformValue<string>? OutputSdt
    {
        get => GetArgument<TerraformValue<string>>("output_sdt");
        set => SetArgument("output_sdt", value);
    }

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceProviderName
    {
        get => GetArgument<TerraformValue<string>>("service_provider_name");
        set => SetArgument("service_provider_name", value);
    }

}

/// <summary>
/// Block type for dvb_tdt_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_tdt_settings";

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

}

/// <summary>
/// Block type for raw_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockArchiveOutputSettingsBlockContainerSettingsBlockRawSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "raw_settings";

}

/// <summary>
/// Block type for frame_capture_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockFrameCaptureOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_output_settings";

    /// <summary>
    /// The name_modifier attribute.
    /// </summary>
    public TerraformValue<string> NameModifier
    {
        get => GetArgument<TerraformValue<string>>("name_modifier") ?? AsReference("name_modifier");
        set => SetArgument("name_modifier", value);
    }

}

/// <summary>
/// Block type for hls_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_output_settings";

    /// <summary>
    /// The h265_packaging_type attribute.
    /// </summary>
    public TerraformValue<string> H265PackagingType
    {
        get => GetArgument<TerraformValue<string>>("h265_packaging_type") ?? AsReference("h265_packaging_type");
        set => SetArgument("h265_packaging_type", value);
    }

    /// <summary>
    /// The name_modifier attribute.
    /// </summary>
    public TerraformValue<string> NameModifier
    {
        get => GetArgument<TerraformValue<string>>("name_modifier") ?? AsReference("name_modifier");
        set => SetArgument("name_modifier", value);
    }

    /// <summary>
    /// The segment_modifier attribute.
    /// </summary>
    public TerraformValue<string> SegmentModifier
    {
        get => GetArgument<TerraformValue<string>>("segment_modifier") ?? AsReference("segment_modifier");
        set => SetArgument("segment_modifier", value);
    }

    /// <summary>
    /// HlsSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HlsSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HlsSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock> HlsSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock>>("hls_settings");
        set => SetArgument("hls_settings", value);
    }

}

/// <summary>
/// Block type for hls_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_settings";

    /// <summary>
    /// AudioOnlyHlsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioOnlyHlsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlock>? AudioOnlyHlsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlock>>("audio_only_hls_settings");
        set => SetArgument("audio_only_hls_settings", value);
    }

    /// <summary>
    /// Fmp4HlsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fmp4HlsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFmp4HlsSettingsBlock>? Fmp4HlsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFmp4HlsSettingsBlock>>("fmp4_hls_settings");
        set => SetArgument("fmp4_hls_settings", value);
    }

    /// <summary>
    /// FrameCaptureHlsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureHlsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFrameCaptureHlsSettingsBlock>? FrameCaptureHlsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFrameCaptureHlsSettingsBlock>>("frame_capture_hls_settings");
        set => SetArgument("frame_capture_hls_settings", value);
    }

    /// <summary>
    /// StandardHlsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardHlsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlock>? StandardHlsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlock>>("standard_hls_settings");
        set => SetArgument("standard_hls_settings", value);
    }

}

/// <summary>
/// Block type for audio_only_hls_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_only_hls_settings";

    /// <summary>
    /// The audio_group_id attribute.
    /// </summary>
    public TerraformValue<string> AudioGroupId
    {
        get => GetArgument<TerraformValue<string>>("audio_group_id") ?? AsReference("audio_group_id");
        set => SetArgument("audio_group_id", value);
    }

    /// <summary>
    /// The audio_track_type attribute.
    /// </summary>
    public TerraformValue<string> AudioTrackType
    {
        get => GetArgument<TerraformValue<string>>("audio_track_type") ?? AsReference("audio_track_type");
        set => SetArgument("audio_track_type", value);
    }

    /// <summary>
    /// The segment_type attribute.
    /// </summary>
    public TerraformValue<string> SegmentType
    {
        get => GetArgument<TerraformValue<string>>("segment_type") ?? AsReference("segment_type");
        set => SetArgument("segment_type", value);
    }

    /// <summary>
    /// AudioOnlyImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioOnlyImage block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlockAudioOnlyImageBlock>? AudioOnlyImage
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlockAudioOnlyImageBlock>>("audio_only_image");
        set => SetArgument("audio_only_image", value);
    }

}

/// <summary>
/// Block type for audio_only_image in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockAudioOnlyHlsSettingsBlockAudioOnlyImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_only_image";

    /// <summary>
    /// The password_param attribute.
    /// </summary>
    public TerraformValue<string> PasswordParam
    {
        get => GetArgument<TerraformValue<string>>("password_param") ?? AsReference("password_param");
        set => SetArgument("password_param", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string> Username
    {
        get => GetArgument<TerraformValue<string>>("username") ?? AsReference("username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for fmp4_hls_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFmp4HlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fmp4_hls_settings";

    /// <summary>
    /// The audio_rendition_sets attribute.
    /// </summary>
    public TerraformValue<string> AudioRenditionSets
    {
        get => GetArgument<TerraformValue<string>>("audio_rendition_sets") ?? AsReference("audio_rendition_sets");
        set => SetArgument("audio_rendition_sets", value);
    }

    /// <summary>
    /// The nielsen_id3_behavior attribute.
    /// </summary>
    public TerraformValue<string> NielsenId3Behavior
    {
        get => GetArgument<TerraformValue<string>>("nielsen_id3_behavior") ?? AsReference("nielsen_id3_behavior");
        set => SetArgument("nielsen_id3_behavior", value);
    }

    /// <summary>
    /// The timed_metadata_behavior attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataBehavior
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_behavior") ?? AsReference("timed_metadata_behavior");
        set => SetArgument("timed_metadata_behavior", value);
    }

}

/// <summary>
/// Block type for frame_capture_hls_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockFrameCaptureHlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_hls_settings";

}

/// <summary>
/// Block type for standard_hls_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_hls_settings";

    /// <summary>
    /// The audio_rendition_sets attribute.
    /// </summary>
    public TerraformValue<string> AudioRenditionSets
    {
        get => GetArgument<TerraformValue<string>>("audio_rendition_sets") ?? AsReference("audio_rendition_sets");
        set => SetArgument("audio_rendition_sets", value);
    }

    /// <summary>
    /// M3u8Settings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "M3u8Settings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 M3u8Settings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 M3u8Settings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlockM3u8SettingsBlock> M3u8Settings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlockM3u8SettingsBlock>>("m3u8_settings");
        set => SetArgument("m3u8_settings", value);
    }

}

/// <summary>
/// Block type for m3u8_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockHlsOutputSettingsBlockHlsSettingsBlockStandardHlsSettingsBlockM3u8SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "m3u8_settings";

    /// <summary>
    /// The audio_frames_per_pes attribute.
    /// </summary>
    public TerraformValue<double> AudioFramesPerPes
    {
        get => GetArgument<TerraformValue<double>>("audio_frames_per_pes") ?? AsReference("audio_frames_per_pes");
        set => SetArgument("audio_frames_per_pes", value);
    }

    /// <summary>
    /// The audio_pids attribute.
    /// </summary>
    public TerraformValue<string> AudioPids
    {
        get => GetArgument<TerraformValue<string>>("audio_pids") ?? AsReference("audio_pids");
        set => SetArgument("audio_pids", value);
    }

    /// <summary>
    /// The ecm_pid attribute.
    /// </summary>
    public TerraformValue<string> EcmPid
    {
        get => GetArgument<TerraformValue<string>>("ecm_pid") ?? AsReference("ecm_pid");
        set => SetArgument("ecm_pid", value);
    }

    /// <summary>
    /// The nielsen_id3_behavior attribute.
    /// </summary>
    public TerraformValue<string> NielsenId3Behavior
    {
        get => GetArgument<TerraformValue<string>>("nielsen_id3_behavior") ?? AsReference("nielsen_id3_behavior");
        set => SetArgument("nielsen_id3_behavior", value);
    }

    /// <summary>
    /// The pat_interval attribute.
    /// </summary>
    public TerraformValue<double> PatInterval
    {
        get => GetArgument<TerraformValue<double>>("pat_interval") ?? AsReference("pat_interval");
        set => SetArgument("pat_interval", value);
    }

    /// <summary>
    /// The pcr_control attribute.
    /// </summary>
    public TerraformValue<string> PcrControl
    {
        get => GetArgument<TerraformValue<string>>("pcr_control") ?? AsReference("pcr_control");
        set => SetArgument("pcr_control", value);
    }

    /// <summary>
    /// The pcr_period attribute.
    /// </summary>
    public TerraformValue<double> PcrPeriod
    {
        get => GetArgument<TerraformValue<double>>("pcr_period") ?? AsReference("pcr_period");
        set => SetArgument("pcr_period", value);
    }

    /// <summary>
    /// The pcr_pid attribute.
    /// </summary>
    public TerraformValue<string> PcrPid
    {
        get => GetArgument<TerraformValue<string>>("pcr_pid") ?? AsReference("pcr_pid");
        set => SetArgument("pcr_pid", value);
    }

    /// <summary>
    /// The pmt_interval attribute.
    /// </summary>
    public TerraformValue<double> PmtInterval
    {
        get => GetArgument<TerraformValue<double>>("pmt_interval") ?? AsReference("pmt_interval");
        set => SetArgument("pmt_interval", value);
    }

    /// <summary>
    /// The pmt_pid attribute.
    /// </summary>
    public TerraformValue<string> PmtPid
    {
        get => GetArgument<TerraformValue<string>>("pmt_pid") ?? AsReference("pmt_pid");
        set => SetArgument("pmt_pid", value);
    }

    /// <summary>
    /// The program_num attribute.
    /// </summary>
    public TerraformValue<double> ProgramNum
    {
        get => GetArgument<TerraformValue<double>>("program_num") ?? AsReference("program_num");
        set => SetArgument("program_num", value);
    }

    /// <summary>
    /// The scte35_behavior attribute.
    /// </summary>
    public TerraformValue<string> Scte35Behavior
    {
        get => GetArgument<TerraformValue<string>>("scte35_behavior") ?? AsReference("scte35_behavior");
        set => SetArgument("scte35_behavior", value);
    }

    /// <summary>
    /// The scte35_pid attribute.
    /// </summary>
    public TerraformValue<string> Scte35Pid
    {
        get => GetArgument<TerraformValue<string>>("scte35_pid") ?? AsReference("scte35_pid");
        set => SetArgument("scte35_pid", value);
    }

    /// <summary>
    /// The timed_metadata_behavior attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataBehavior
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_behavior") ?? AsReference("timed_metadata_behavior");
        set => SetArgument("timed_metadata_behavior", value);
    }

    /// <summary>
    /// The timed_metadata_pid attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataPid
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_pid") ?? AsReference("timed_metadata_pid");
        set => SetArgument("timed_metadata_pid", value);
    }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    public TerraformValue<double> TransportStreamId
    {
        get => GetArgument<TerraformValue<double>>("transport_stream_id") ?? AsReference("transport_stream_id");
        set => SetArgument("transport_stream_id", value);
    }

    /// <summary>
    /// The video_pid attribute.
    /// </summary>
    public TerraformValue<string> VideoPid
    {
        get => GetArgument<TerraformValue<string>>("video_pid") ?? AsReference("video_pid");
        set => SetArgument("video_pid", value);
    }

}

/// <summary>
/// Block type for media_package_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMediaPackageOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "media_package_output_settings";

}

/// <summary>
/// Block type for ms_smooth_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMsSmoothOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ms_smooth_output_settings";

    /// <summary>
    /// The h265_packaging_type attribute.
    /// </summary>
    public TerraformValue<string> H265PackagingType
    {
        get => GetArgument<TerraformValue<string>>("h265_packaging_type") ?? AsReference("h265_packaging_type");
        set => SetArgument("h265_packaging_type", value);
    }

    /// <summary>
    /// The name_modifier attribute.
    /// </summary>
    public TerraformValue<string> NameModifier
    {
        get => GetArgument<TerraformValue<string>>("name_modifier") ?? AsReference("name_modifier");
        set => SetArgument("name_modifier", value);
    }

}

/// <summary>
/// Block type for multiplex_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiplex_output_settings";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockMultiplexOutputSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for rtmp_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rtmp_output_settings";

    /// <summary>
    /// The certificate_mode attribute.
    /// </summary>
    public TerraformValue<string> CertificateMode
    {
        get => GetArgument<TerraformValue<string>>("certificate_mode") ?? AsReference("certificate_mode");
        set => SetArgument("certificate_mode", value);
    }

    /// <summary>
    /// The connection_retry_interval attribute.
    /// </summary>
    public TerraformValue<double> ConnectionRetryInterval
    {
        get => GetArgument<TerraformValue<double>>("connection_retry_interval") ?? AsReference("connection_retry_interval");
        set => SetArgument("connection_retry_interval", value);
    }

    /// <summary>
    /// The num_retries attribute.
    /// </summary>
    public TerraformValue<double> NumRetries
    {
        get => GetArgument<TerraformValue<double>>("num_retries") ?? AsReference("num_retries");
        set => SetArgument("num_retries", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockRtmpOutputSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for udp_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "udp_output_settings";

    /// <summary>
    /// The buffer_msec attribute.
    /// </summary>
    public TerraformValue<double> BufferMsec
    {
        get => GetArgument<TerraformValue<double>>("buffer_msec") ?? AsReference("buffer_msec");
        set => SetArgument("buffer_msec", value);
    }

    /// <summary>
    /// ContainerSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContainerSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlock> ContainerSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlock>>("container_settings");
        set => SetArgument("container_settings", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// FecOutputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FecOutputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockFecOutputSettingsBlock>? FecOutputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockFecOutputSettingsBlock>>("fec_output_settings");
        set => SetArgument("fec_output_settings", value);
    }

}

/// <summary>
/// Block type for container_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_settings";

    /// <summary>
    /// M2tsSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 M2tsSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock>? M2tsSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock>>("m2ts_settings");
        set => SetArgument("m2ts_settings", value);
    }

}

/// <summary>
/// Block type for m2ts_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "m2ts_settings";

    /// <summary>
    /// The absent_input_audio_behavior attribute.
    /// </summary>
    public TerraformValue<string> AbsentInputAudioBehavior
    {
        get => GetArgument<TerraformValue<string>>("absent_input_audio_behavior") ?? AsReference("absent_input_audio_behavior");
        set => SetArgument("absent_input_audio_behavior", value);
    }

    /// <summary>
    /// The arib attribute.
    /// </summary>
    public TerraformValue<string>? Arib
    {
        get => GetArgument<TerraformValue<string>>("arib");
        set => SetArgument("arib", value);
    }

    /// <summary>
    /// The arib_captions_pid attribute.
    /// </summary>
    public TerraformValue<string> AribCaptionsPid
    {
        get => GetArgument<TerraformValue<string>>("arib_captions_pid") ?? AsReference("arib_captions_pid");
        set => SetArgument("arib_captions_pid", value);
    }

    /// <summary>
    /// The arib_captions_pid_control attribute.
    /// </summary>
    public TerraformValue<string>? AribCaptionsPidControl
    {
        get => GetArgument<TerraformValue<string>>("arib_captions_pid_control");
        set => SetArgument("arib_captions_pid_control", value);
    }

    /// <summary>
    /// The audio_buffer_model attribute.
    /// </summary>
    public TerraformValue<string>? AudioBufferModel
    {
        get => GetArgument<TerraformValue<string>>("audio_buffer_model");
        set => SetArgument("audio_buffer_model", value);
    }

    /// <summary>
    /// The audio_frames_per_pes attribute.
    /// </summary>
    public TerraformValue<double>? AudioFramesPerPes
    {
        get => GetArgument<TerraformValue<double>>("audio_frames_per_pes");
        set => SetArgument("audio_frames_per_pes", value);
    }

    /// <summary>
    /// The audio_pids attribute.
    /// </summary>
    public TerraformValue<string> AudioPids
    {
        get => GetArgument<TerraformValue<string>>("audio_pids") ?? AsReference("audio_pids");
        set => SetArgument("audio_pids", value);
    }

    /// <summary>
    /// The audio_stream_type attribute.
    /// </summary>
    public TerraformValue<string>? AudioStreamType
    {
        get => GetArgument<TerraformValue<string>>("audio_stream_type");
        set => SetArgument("audio_stream_type", value);
    }

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double>? Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The buffer_model attribute.
    /// </summary>
    public TerraformValue<string>? BufferModel
    {
        get => GetArgument<TerraformValue<string>>("buffer_model");
        set => SetArgument("buffer_model", value);
    }

    /// <summary>
    /// The cc_descriptor attribute.
    /// </summary>
    public TerraformValue<string>? CcDescriptor
    {
        get => GetArgument<TerraformValue<string>>("cc_descriptor");
        set => SetArgument("cc_descriptor", value);
    }

    /// <summary>
    /// The dvb_sub_pids attribute.
    /// </summary>
    public TerraformValue<string> DvbSubPids
    {
        get => GetArgument<TerraformValue<string>>("dvb_sub_pids") ?? AsReference("dvb_sub_pids");
        set => SetArgument("dvb_sub_pids", value);
    }

    /// <summary>
    /// The dvb_teletext_pid attribute.
    /// </summary>
    public TerraformValue<string> DvbTeletextPid
    {
        get => GetArgument<TerraformValue<string>>("dvb_teletext_pid") ?? AsReference("dvb_teletext_pid");
        set => SetArgument("dvb_teletext_pid", value);
    }

    /// <summary>
    /// The ebif attribute.
    /// </summary>
    public TerraformValue<string>? Ebif
    {
        get => GetArgument<TerraformValue<string>>("ebif");
        set => SetArgument("ebif", value);
    }

    /// <summary>
    /// The ebp_audio_interval attribute.
    /// </summary>
    public TerraformValue<string>? EbpAudioInterval
    {
        get => GetArgument<TerraformValue<string>>("ebp_audio_interval");
        set => SetArgument("ebp_audio_interval", value);
    }

    /// <summary>
    /// The ebp_lookahead_ms attribute.
    /// </summary>
    public TerraformValue<double>? EbpLookaheadMs
    {
        get => GetArgument<TerraformValue<double>>("ebp_lookahead_ms");
        set => SetArgument("ebp_lookahead_ms", value);
    }

    /// <summary>
    /// The ebp_placement attribute.
    /// </summary>
    public TerraformValue<string>? EbpPlacement
    {
        get => GetArgument<TerraformValue<string>>("ebp_placement");
        set => SetArgument("ebp_placement", value);
    }

    /// <summary>
    /// The ecm_pid attribute.
    /// </summary>
    public TerraformValue<string>? EcmPid
    {
        get => GetArgument<TerraformValue<string>>("ecm_pid");
        set => SetArgument("ecm_pid", value);
    }

    /// <summary>
    /// The es_rate_in_pes attribute.
    /// </summary>
    public TerraformValue<string>? EsRateInPes
    {
        get => GetArgument<TerraformValue<string>>("es_rate_in_pes");
        set => SetArgument("es_rate_in_pes", value);
    }

    /// <summary>
    /// The etv_platform_pid attribute.
    /// </summary>
    public TerraformValue<string> EtvPlatformPid
    {
        get => GetArgument<TerraformValue<string>>("etv_platform_pid") ?? AsReference("etv_platform_pid");
        set => SetArgument("etv_platform_pid", value);
    }

    /// <summary>
    /// The etv_signal_pid attribute.
    /// </summary>
    public TerraformValue<string> EtvSignalPid
    {
        get => GetArgument<TerraformValue<string>>("etv_signal_pid") ?? AsReference("etv_signal_pid");
        set => SetArgument("etv_signal_pid", value);
    }

    /// <summary>
    /// The fragment_time attribute.
    /// </summary>
    public TerraformValue<double>? FragmentTime
    {
        get => GetArgument<TerraformValue<double>>("fragment_time");
        set => SetArgument("fragment_time", value);
    }

    /// <summary>
    /// The klv attribute.
    /// </summary>
    public TerraformValue<string>? Klv
    {
        get => GetArgument<TerraformValue<string>>("klv");
        set => SetArgument("klv", value);
    }

    /// <summary>
    /// The klv_data_pids attribute.
    /// </summary>
    public TerraformValue<string> KlvDataPids
    {
        get => GetArgument<TerraformValue<string>>("klv_data_pids") ?? AsReference("klv_data_pids");
        set => SetArgument("klv_data_pids", value);
    }

    /// <summary>
    /// The nielsen_id3_behavior attribute.
    /// </summary>
    public TerraformValue<string>? NielsenId3Behavior
    {
        get => GetArgument<TerraformValue<string>>("nielsen_id3_behavior");
        set => SetArgument("nielsen_id3_behavior", value);
    }

    /// <summary>
    /// The null_packet_bitrate attribute.
    /// </summary>
    public TerraformValue<double>? NullPacketBitrate
    {
        get => GetArgument<TerraformValue<double>>("null_packet_bitrate");
        set => SetArgument("null_packet_bitrate", value);
    }

    /// <summary>
    /// The pat_interval attribute.
    /// </summary>
    public TerraformValue<double>? PatInterval
    {
        get => GetArgument<TerraformValue<double>>("pat_interval");
        set => SetArgument("pat_interval", value);
    }

    /// <summary>
    /// The pcr_control attribute.
    /// </summary>
    public TerraformValue<string>? PcrControl
    {
        get => GetArgument<TerraformValue<string>>("pcr_control");
        set => SetArgument("pcr_control", value);
    }

    /// <summary>
    /// The pcr_period attribute.
    /// </summary>
    public TerraformValue<double>? PcrPeriod
    {
        get => GetArgument<TerraformValue<double>>("pcr_period");
        set => SetArgument("pcr_period", value);
    }

    /// <summary>
    /// The pcr_pid attribute.
    /// </summary>
    public TerraformValue<string>? PcrPid
    {
        get => GetArgument<TerraformValue<string>>("pcr_pid");
        set => SetArgument("pcr_pid", value);
    }

    /// <summary>
    /// The pmt_interval attribute.
    /// </summary>
    public TerraformValue<double>? PmtInterval
    {
        get => GetArgument<TerraformValue<double>>("pmt_interval");
        set => SetArgument("pmt_interval", value);
    }

    /// <summary>
    /// The pmt_pid attribute.
    /// </summary>
    public TerraformValue<string> PmtPid
    {
        get => GetArgument<TerraformValue<string>>("pmt_pid") ?? AsReference("pmt_pid");
        set => SetArgument("pmt_pid", value);
    }

    /// <summary>
    /// The program_num attribute.
    /// </summary>
    public TerraformValue<double>? ProgramNum
    {
        get => GetArgument<TerraformValue<double>>("program_num");
        set => SetArgument("program_num", value);
    }

    /// <summary>
    /// The rate_mode attribute.
    /// </summary>
    public TerraformValue<string>? RateMode
    {
        get => GetArgument<TerraformValue<string>>("rate_mode");
        set => SetArgument("rate_mode", value);
    }

    /// <summary>
    /// The scte27_pids attribute.
    /// </summary>
    public TerraformValue<string> Scte27Pids
    {
        get => GetArgument<TerraformValue<string>>("scte27_pids") ?? AsReference("scte27_pids");
        set => SetArgument("scte27_pids", value);
    }

    /// <summary>
    /// The scte35_control attribute.
    /// </summary>
    public TerraformValue<string>? Scte35Control
    {
        get => GetArgument<TerraformValue<string>>("scte35_control");
        set => SetArgument("scte35_control", value);
    }

    /// <summary>
    /// The scte35_pid attribute.
    /// </summary>
    public TerraformValue<string> Scte35Pid
    {
        get => GetArgument<TerraformValue<string>>("scte35_pid") ?? AsReference("scte35_pid");
        set => SetArgument("scte35_pid", value);
    }

    /// <summary>
    /// The segmentation_markers attribute.
    /// </summary>
    public TerraformValue<string>? SegmentationMarkers
    {
        get => GetArgument<TerraformValue<string>>("segmentation_markers");
        set => SetArgument("segmentation_markers", value);
    }

    /// <summary>
    /// The segmentation_style attribute.
    /// </summary>
    public TerraformValue<string>? SegmentationStyle
    {
        get => GetArgument<TerraformValue<string>>("segmentation_style");
        set => SetArgument("segmentation_style", value);
    }

    /// <summary>
    /// The segmentation_time attribute.
    /// </summary>
    public TerraformValue<double>? SegmentationTime
    {
        get => GetArgument<TerraformValue<double>>("segmentation_time");
        set => SetArgument("segmentation_time", value);
    }

    /// <summary>
    /// The timed_metadata_behavior attribute.
    /// </summary>
    public TerraformValue<string>? TimedMetadataBehavior
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_behavior");
        set => SetArgument("timed_metadata_behavior", value);
    }

    /// <summary>
    /// The timed_metadata_pid attribute.
    /// </summary>
    public TerraformValue<string> TimedMetadataPid
    {
        get => GetArgument<TerraformValue<string>>("timed_metadata_pid") ?? AsReference("timed_metadata_pid");
        set => SetArgument("timed_metadata_pid", value);
    }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    public TerraformValue<double>? TransportStreamId
    {
        get => GetArgument<TerraformValue<double>>("transport_stream_id");
        set => SetArgument("transport_stream_id", value);
    }

    /// <summary>
    /// The video_pid attribute.
    /// </summary>
    public TerraformValue<string> VideoPid
    {
        get => GetArgument<TerraformValue<string>>("video_pid") ?? AsReference("video_pid");
        set => SetArgument("video_pid", value);
    }

    /// <summary>
    /// DvbNitSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbNitSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock>? DvbNitSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock>>("dvb_nit_settings");
        set => SetArgument("dvb_nit_settings", value);
    }

    /// <summary>
    /// DvbSdtSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbSdtSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock>? DvbSdtSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock>>("dvb_sdt_settings");
        set => SetArgument("dvb_sdt_settings", value);
    }

    /// <summary>
    /// DvbTdtSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbTdtSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock>? DvbTdtSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock>>("dvb_tdt_settings");
        set => SetArgument("dvb_tdt_settings", value);
    }

}

/// <summary>
/// Block type for dvb_nit_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbNitSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_nit_settings";

    /// <summary>
    /// The network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkId is required")]
    public required TerraformValue<double> NetworkId
    {
        get => GetRequiredArgument<TerraformValue<double>>("network_id");
        set => SetArgument("network_id", value);
    }

    /// <summary>
    /// The network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkName is required")]
    public required TerraformValue<string> NetworkName
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_name");
        set => SetArgument("network_name", value);
    }

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

}

/// <summary>
/// Block type for dvb_sdt_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbSdtSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_sdt_settings";

    /// <summary>
    /// The output_sdt attribute.
    /// </summary>
    public TerraformValue<string>? OutputSdt
    {
        get => GetArgument<TerraformValue<string>>("output_sdt");
        set => SetArgument("output_sdt", value);
    }

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceProviderName
    {
        get => GetArgument<TerraformValue<string>>("service_provider_name");
        set => SetArgument("service_provider_name", value);
    }

}

/// <summary>
/// Block type for dvb_tdt_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockContainerSettingsBlockM2tsSettingsBlockDvbTdtSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_tdt_settings";

    /// <summary>
    /// The rep_interval attribute.
    /// </summary>
    public TerraformValue<double>? RepInterval
    {
        get => GetArgument<TerraformValue<double>>("rep_interval");
        set => SetArgument("rep_interval", value);
    }

}

/// <summary>
/// Block type for destination in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The destination_ref_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationRefId is required")]
    public required TerraformValue<string> DestinationRefId
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_ref_id");
        set => SetArgument("destination_ref_id", value);
    }

}

/// <summary>
/// Block type for fec_output_settings in AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockOutputGroupsBlockOutputsBlockOutputSettingsBlockUdpOutputSettingsBlockFecOutputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fec_output_settings";

    /// <summary>
    /// The column_depth attribute.
    /// </summary>
    public TerraformValue<double> ColumnDepth
    {
        get => GetArgument<TerraformValue<double>>("column_depth") ?? AsReference("column_depth");
        set => SetArgument("column_depth", value);
    }

    /// <summary>
    /// The include_fec attribute.
    /// </summary>
    public TerraformValue<string> IncludeFec
    {
        get => GetArgument<TerraformValue<string>>("include_fec") ?? AsReference("include_fec");
        set => SetArgument("include_fec", value);
    }

    /// <summary>
    /// The row_length attribute.
    /// </summary>
    public TerraformValue<double> RowLength
    {
        get => GetArgument<TerraformValue<double>>("row_length") ?? AsReference("row_length");
        set => SetArgument("row_length", value);
    }

}

/// <summary>
/// Block type for timecode_config in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockTimecodeConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timecode_config";

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The sync_threshold attribute.
    /// </summary>
    public TerraformValue<double> SyncThreshold
    {
        get => GetArgument<TerraformValue<double>>("sync_threshold") ?? AsReference("sync_threshold");
        set => SetArgument("sync_threshold", value);
    }

}

/// <summary>
/// Block type for video_descriptions in AwsMedialiveChannelEncoderSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_descriptions";

    /// <summary>
    /// The height attribute.
    /// </summary>
    public TerraformValue<double> Height
    {
        get => GetArgument<TerraformValue<double>>("height") ?? AsReference("height");
        set => SetArgument("height", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The respond_to_afd attribute.
    /// </summary>
    public TerraformValue<string> RespondToAfd
    {
        get => GetArgument<TerraformValue<string>>("respond_to_afd") ?? AsReference("respond_to_afd");
        set => SetArgument("respond_to_afd", value);
    }

    /// <summary>
    /// The scaling_behavior attribute.
    /// </summary>
    public TerraformValue<string> ScalingBehavior
    {
        get => GetArgument<TerraformValue<string>>("scaling_behavior") ?? AsReference("scaling_behavior");
        set => SetArgument("scaling_behavior", value);
    }

    /// <summary>
    /// The sharpness attribute.
    /// </summary>
    public TerraformValue<double> Sharpness
    {
        get => GetArgument<TerraformValue<double>>("sharpness") ?? AsReference("sharpness");
        set => SetArgument("sharpness", value);
    }

    /// <summary>
    /// The width attribute.
    /// </summary>
    public TerraformValue<double> Width
    {
        get => GetArgument<TerraformValue<double>>("width") ?? AsReference("width");
        set => SetArgument("width", value);
    }

    /// <summary>
    /// CodecSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodecSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock>? CodecSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock>>("codec_settings");
        set => SetArgument("codec_settings", value);
    }

}

/// <summary>
/// Block type for codec_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "codec_settings";

    /// <summary>
    /// FrameCaptureSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrameCaptureSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockFrameCaptureSettingsBlock>? FrameCaptureSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockFrameCaptureSettingsBlock>>("frame_capture_settings");
        set => SetArgument("frame_capture_settings", value);
    }

    /// <summary>
    /// H264Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 H264Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlock>? H264Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlock>>("h264_settings");
        set => SetArgument("h264_settings", value);
    }

    /// <summary>
    /// H265Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 H265Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock>? H265Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock>>("h265_settings");
        set => SetArgument("h265_settings", value);
    }

}

/// <summary>
/// Block type for frame_capture_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockFrameCaptureSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frame_capture_settings";

    /// <summary>
    /// The capture_interval attribute.
    /// </summary>
    public TerraformValue<double> CaptureInterval
    {
        get => GetArgument<TerraformValue<double>>("capture_interval") ?? AsReference("capture_interval");
        set => SetArgument("capture_interval", value);
    }

    /// <summary>
    /// The capture_interval_units attribute.
    /// </summary>
    public TerraformValue<string> CaptureIntervalUnits
    {
        get => GetArgument<TerraformValue<string>>("capture_interval_units") ?? AsReference("capture_interval_units");
        set => SetArgument("capture_interval_units", value);
    }

}

/// <summary>
/// Block type for h264_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "h264_settings";

    /// <summary>
    /// The adaptive_quantization attribute.
    /// </summary>
    public TerraformValue<string> AdaptiveQuantization
    {
        get => GetArgument<TerraformValue<string>>("adaptive_quantization") ?? AsReference("adaptive_quantization");
        set => SetArgument("adaptive_quantization", value);
    }

    /// <summary>
    /// The afd_signaling attribute.
    /// </summary>
    public TerraformValue<string> AfdSignaling
    {
        get => GetArgument<TerraformValue<string>>("afd_signaling") ?? AsReference("afd_signaling");
        set => SetArgument("afd_signaling", value);
    }

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    public TerraformValue<double> Bitrate
    {
        get => GetArgument<TerraformValue<double>>("bitrate") ?? AsReference("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The buf_fill_pct attribute.
    /// </summary>
    public TerraformValue<double> BufFillPct
    {
        get => GetArgument<TerraformValue<double>>("buf_fill_pct") ?? AsReference("buf_fill_pct");
        set => SetArgument("buf_fill_pct", value);
    }

    /// <summary>
    /// The buf_size attribute.
    /// </summary>
    public TerraformValue<double> BufSize
    {
        get => GetArgument<TerraformValue<double>>("buf_size") ?? AsReference("buf_size");
        set => SetArgument("buf_size", value);
    }

    /// <summary>
    /// The color_metadata attribute.
    /// </summary>
    public TerraformValue<string> ColorMetadata
    {
        get => GetArgument<TerraformValue<string>>("color_metadata") ?? AsReference("color_metadata");
        set => SetArgument("color_metadata", value);
    }

    /// <summary>
    /// The entropy_encoding attribute.
    /// </summary>
    public TerraformValue<string> EntropyEncoding
    {
        get => GetArgument<TerraformValue<string>>("entropy_encoding") ?? AsReference("entropy_encoding");
        set => SetArgument("entropy_encoding", value);
    }

    /// <summary>
    /// The fixed_afd attribute.
    /// </summary>
    public TerraformValue<string> FixedAfd
    {
        get => GetArgument<TerraformValue<string>>("fixed_afd") ?? AsReference("fixed_afd");
        set => SetArgument("fixed_afd", value);
    }

    /// <summary>
    /// The flicker_aq attribute.
    /// </summary>
    public TerraformValue<string> FlickerAq
    {
        get => GetArgument<TerraformValue<string>>("flicker_aq") ?? AsReference("flicker_aq");
        set => SetArgument("flicker_aq", value);
    }

    /// <summary>
    /// The force_field_pictures attribute.
    /// </summary>
    public TerraformValue<string> ForceFieldPictures
    {
        get => GetArgument<TerraformValue<string>>("force_field_pictures") ?? AsReference("force_field_pictures");
        set => SetArgument("force_field_pictures", value);
    }

    /// <summary>
    /// The framerate_control attribute.
    /// </summary>
    public TerraformValue<string> FramerateControl
    {
        get => GetArgument<TerraformValue<string>>("framerate_control") ?? AsReference("framerate_control");
        set => SetArgument("framerate_control", value);
    }

    /// <summary>
    /// The framerate_denominator attribute.
    /// </summary>
    public TerraformValue<double> FramerateDenominator
    {
        get => GetArgument<TerraformValue<double>>("framerate_denominator") ?? AsReference("framerate_denominator");
        set => SetArgument("framerate_denominator", value);
    }

    /// <summary>
    /// The framerate_numerator attribute.
    /// </summary>
    public TerraformValue<double> FramerateNumerator
    {
        get => GetArgument<TerraformValue<double>>("framerate_numerator") ?? AsReference("framerate_numerator");
        set => SetArgument("framerate_numerator", value);
    }

    /// <summary>
    /// The gop_b_reference attribute.
    /// </summary>
    public TerraformValue<string> GopBReference
    {
        get => GetArgument<TerraformValue<string>>("gop_b_reference") ?? AsReference("gop_b_reference");
        set => SetArgument("gop_b_reference", value);
    }

    /// <summary>
    /// The gop_closed_cadence attribute.
    /// </summary>
    public TerraformValue<double> GopClosedCadence
    {
        get => GetArgument<TerraformValue<double>>("gop_closed_cadence") ?? AsReference("gop_closed_cadence");
        set => SetArgument("gop_closed_cadence", value);
    }

    /// <summary>
    /// The gop_num_b_frames attribute.
    /// </summary>
    public TerraformValue<double> GopNumBFrames
    {
        get => GetArgument<TerraformValue<double>>("gop_num_b_frames") ?? AsReference("gop_num_b_frames");
        set => SetArgument("gop_num_b_frames", value);
    }

    /// <summary>
    /// The gop_size attribute.
    /// </summary>
    public TerraformValue<double> GopSize
    {
        get => GetArgument<TerraformValue<double>>("gop_size") ?? AsReference("gop_size");
        set => SetArgument("gop_size", value);
    }

    /// <summary>
    /// The gop_size_units attribute.
    /// </summary>
    public TerraformValue<string> GopSizeUnits
    {
        get => GetArgument<TerraformValue<string>>("gop_size_units") ?? AsReference("gop_size_units");
        set => SetArgument("gop_size_units", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string> Level
    {
        get => GetArgument<TerraformValue<string>>("level") ?? AsReference("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The look_ahead_rate_control attribute.
    /// </summary>
    public TerraformValue<string> LookAheadRateControl
    {
        get => GetArgument<TerraformValue<string>>("look_ahead_rate_control") ?? AsReference("look_ahead_rate_control");
        set => SetArgument("look_ahead_rate_control", value);
    }

    /// <summary>
    /// The max_bitrate attribute.
    /// </summary>
    public TerraformValue<double> MaxBitrate
    {
        get => GetArgument<TerraformValue<double>>("max_bitrate") ?? AsReference("max_bitrate");
        set => SetArgument("max_bitrate", value);
    }

    /// <summary>
    /// The min_i_interval attribute.
    /// </summary>
    public TerraformValue<double> MinIInterval
    {
        get => GetArgument<TerraformValue<double>>("min_i_interval") ?? AsReference("min_i_interval");
        set => SetArgument("min_i_interval", value);
    }

    /// <summary>
    /// The num_ref_frames attribute.
    /// </summary>
    public TerraformValue<double> NumRefFrames
    {
        get => GetArgument<TerraformValue<double>>("num_ref_frames") ?? AsReference("num_ref_frames");
        set => SetArgument("num_ref_frames", value);
    }

    /// <summary>
    /// The par_control attribute.
    /// </summary>
    public TerraformValue<string> ParControl
    {
        get => GetArgument<TerraformValue<string>>("par_control") ?? AsReference("par_control");
        set => SetArgument("par_control", value);
    }

    /// <summary>
    /// The par_denominator attribute.
    /// </summary>
    public TerraformValue<double> ParDenominator
    {
        get => GetArgument<TerraformValue<double>>("par_denominator") ?? AsReference("par_denominator");
        set => SetArgument("par_denominator", value);
    }

    /// <summary>
    /// The par_numerator attribute.
    /// </summary>
    public TerraformValue<double> ParNumerator
    {
        get => GetArgument<TerraformValue<double>>("par_numerator") ?? AsReference("par_numerator");
        set => SetArgument("par_numerator", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformValue<string> Profile
    {
        get => GetArgument<TerraformValue<string>>("profile") ?? AsReference("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// The quality_level attribute.
    /// </summary>
    public TerraformValue<string> QualityLevel
    {
        get => GetArgument<TerraformValue<string>>("quality_level") ?? AsReference("quality_level");
        set => SetArgument("quality_level", value);
    }

    /// <summary>
    /// The qvbr_quality_level attribute.
    /// </summary>
    public TerraformValue<double> QvbrQualityLevel
    {
        get => GetArgument<TerraformValue<double>>("qvbr_quality_level") ?? AsReference("qvbr_quality_level");
        set => SetArgument("qvbr_quality_level", value);
    }

    /// <summary>
    /// The rate_control_mode attribute.
    /// </summary>
    public TerraformValue<string> RateControlMode
    {
        get => GetArgument<TerraformValue<string>>("rate_control_mode") ?? AsReference("rate_control_mode");
        set => SetArgument("rate_control_mode", value);
    }

    /// <summary>
    /// The scan_type attribute.
    /// </summary>
    public TerraformValue<string> ScanType
    {
        get => GetArgument<TerraformValue<string>>("scan_type") ?? AsReference("scan_type");
        set => SetArgument("scan_type", value);
    }

    /// <summary>
    /// The scene_change_detect attribute.
    /// </summary>
    public TerraformValue<string> SceneChangeDetect
    {
        get => GetArgument<TerraformValue<string>>("scene_change_detect") ?? AsReference("scene_change_detect");
        set => SetArgument("scene_change_detect", value);
    }

    /// <summary>
    /// The slices attribute.
    /// </summary>
    public TerraformValue<double> Slices
    {
        get => GetArgument<TerraformValue<double>>("slices") ?? AsReference("slices");
        set => SetArgument("slices", value);
    }

    /// <summary>
    /// The softness attribute.
    /// </summary>
    public TerraformValue<double> Softness
    {
        get => GetArgument<TerraformValue<double>>("softness") ?? AsReference("softness");
        set => SetArgument("softness", value);
    }

    /// <summary>
    /// The spatial_aq attribute.
    /// </summary>
    public TerraformValue<string> SpatialAq
    {
        get => GetArgument<TerraformValue<string>>("spatial_aq") ?? AsReference("spatial_aq");
        set => SetArgument("spatial_aq", value);
    }

    /// <summary>
    /// The subgop_length attribute.
    /// </summary>
    public TerraformValue<string> SubgopLength
    {
        get => GetArgument<TerraformValue<string>>("subgop_length") ?? AsReference("subgop_length");
        set => SetArgument("subgop_length", value);
    }

    /// <summary>
    /// The syntax attribute.
    /// </summary>
    public TerraformValue<string> Syntax
    {
        get => GetArgument<TerraformValue<string>>("syntax") ?? AsReference("syntax");
        set => SetArgument("syntax", value);
    }

    /// <summary>
    /// The temporal_aq attribute.
    /// </summary>
    public TerraformValue<string> TemporalAq
    {
        get => GetArgument<TerraformValue<string>>("temporal_aq") ?? AsReference("temporal_aq");
        set => SetArgument("temporal_aq", value);
    }

    /// <summary>
    /// The timecode_insertion attribute.
    /// </summary>
    public TerraformValue<string> TimecodeInsertion
    {
        get => GetArgument<TerraformValue<string>>("timecode_insertion") ?? AsReference("timecode_insertion");
        set => SetArgument("timecode_insertion", value);
    }

    /// <summary>
    /// FilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlock>? FilterSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlock>>("filter_settings");
        set => SetArgument("filter_settings", value);
    }

}

/// <summary>
/// Block type for filter_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_settings";

    /// <summary>
    /// TemporalFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemporalFilterSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock>? TemporalFilterSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock>>("temporal_filter_settings");
        set => SetArgument("temporal_filter_settings", value);
    }

}

/// <summary>
/// Block type for temporal_filter_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH264SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "temporal_filter_settings";

    /// <summary>
    /// The post_filter_sharpening attribute.
    /// </summary>
    public TerraformValue<string>? PostFilterSharpening
    {
        get => GetArgument<TerraformValue<string>>("post_filter_sharpening");
        set => SetArgument("post_filter_sharpening", value);
    }

    /// <summary>
    /// The strength attribute.
    /// </summary>
    public TerraformValue<string>? Strength
    {
        get => GetArgument<TerraformValue<string>>("strength");
        set => SetArgument("strength", value);
    }

}

/// <summary>
/// Block type for h265_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "h265_settings";

    /// <summary>
    /// The adaptive_quantization attribute.
    /// </summary>
    public TerraformValue<string> AdaptiveQuantization
    {
        get => GetArgument<TerraformValue<string>>("adaptive_quantization") ?? AsReference("adaptive_quantization");
        set => SetArgument("adaptive_quantization", value);
    }

    /// <summary>
    /// The afd_signaling attribute.
    /// </summary>
    public TerraformValue<string> AfdSignaling
    {
        get => GetArgument<TerraformValue<string>>("afd_signaling") ?? AsReference("afd_signaling");
        set => SetArgument("afd_signaling", value);
    }

    /// <summary>
    /// The alternative_transfer_function attribute.
    /// </summary>
    public TerraformValue<string> AlternativeTransferFunction
    {
        get => GetArgument<TerraformValue<string>>("alternative_transfer_function") ?? AsReference("alternative_transfer_function");
        set => SetArgument("alternative_transfer_function", value);
    }

    /// <summary>
    /// The bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bitrate is required")]
    public required TerraformValue<double> Bitrate
    {
        get => GetRequiredArgument<TerraformValue<double>>("bitrate");
        set => SetArgument("bitrate", value);
    }

    /// <summary>
    /// The buf_size attribute.
    /// </summary>
    public TerraformValue<double>? BufSize
    {
        get => GetArgument<TerraformValue<double>>("buf_size");
        set => SetArgument("buf_size", value);
    }

    /// <summary>
    /// The color_metadata attribute.
    /// </summary>
    public TerraformValue<string> ColorMetadata
    {
        get => GetArgument<TerraformValue<string>>("color_metadata") ?? AsReference("color_metadata");
        set => SetArgument("color_metadata", value);
    }

    /// <summary>
    /// The fixed_afd attribute.
    /// </summary>
    public TerraformValue<string> FixedAfd
    {
        get => GetArgument<TerraformValue<string>>("fixed_afd") ?? AsReference("fixed_afd");
        set => SetArgument("fixed_afd", value);
    }

    /// <summary>
    /// The flicker_aq attribute.
    /// </summary>
    public TerraformValue<string> FlickerAq
    {
        get => GetArgument<TerraformValue<string>>("flicker_aq") ?? AsReference("flicker_aq");
        set => SetArgument("flicker_aq", value);
    }

    /// <summary>
    /// The framerate_denominator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FramerateDenominator is required")]
    public required TerraformValue<double> FramerateDenominator
    {
        get => GetRequiredArgument<TerraformValue<double>>("framerate_denominator");
        set => SetArgument("framerate_denominator", value);
    }

    /// <summary>
    /// The framerate_numerator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FramerateNumerator is required")]
    public required TerraformValue<double> FramerateNumerator
    {
        get => GetRequiredArgument<TerraformValue<double>>("framerate_numerator");
        set => SetArgument("framerate_numerator", value);
    }

    /// <summary>
    /// The gop_closed_cadence attribute.
    /// </summary>
    public TerraformValue<double>? GopClosedCadence
    {
        get => GetArgument<TerraformValue<double>>("gop_closed_cadence");
        set => SetArgument("gop_closed_cadence", value);
    }

    /// <summary>
    /// The gop_size attribute.
    /// </summary>
    public TerraformValue<double>? GopSize
    {
        get => GetArgument<TerraformValue<double>>("gop_size");
        set => SetArgument("gop_size", value);
    }

    /// <summary>
    /// The gop_size_units attribute.
    /// </summary>
    public TerraformValue<string> GopSizeUnits
    {
        get => GetArgument<TerraformValue<string>>("gop_size_units") ?? AsReference("gop_size_units");
        set => SetArgument("gop_size_units", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<string> Level
    {
        get => GetArgument<TerraformValue<string>>("level") ?? AsReference("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// The look_ahead_rate_control attribute.
    /// </summary>
    public TerraformValue<string> LookAheadRateControl
    {
        get => GetArgument<TerraformValue<string>>("look_ahead_rate_control") ?? AsReference("look_ahead_rate_control");
        set => SetArgument("look_ahead_rate_control", value);
    }

    /// <summary>
    /// The max_bitrate attribute.
    /// </summary>
    public TerraformValue<double>? MaxBitrate
    {
        get => GetArgument<TerraformValue<double>>("max_bitrate");
        set => SetArgument("max_bitrate", value);
    }

    /// <summary>
    /// The min_i_interval attribute.
    /// </summary>
    public TerraformValue<double>? MinIInterval
    {
        get => GetArgument<TerraformValue<double>>("min_i_interval");
        set => SetArgument("min_i_interval", value);
    }

    /// <summary>
    /// The min_qp attribute.
    /// </summary>
    public TerraformValue<double>? MinQp
    {
        get => GetArgument<TerraformValue<double>>("min_qp");
        set => SetArgument("min_qp", value);
    }

    /// <summary>
    /// The mv_over_picture_boundaries attribute.
    /// </summary>
    public TerraformValue<string> MvOverPictureBoundaries
    {
        get => GetArgument<TerraformValue<string>>("mv_over_picture_boundaries") ?? AsReference("mv_over_picture_boundaries");
        set => SetArgument("mv_over_picture_boundaries", value);
    }

    /// <summary>
    /// The mv_temporal_predictor attribute.
    /// </summary>
    public TerraformValue<string> MvTemporalPredictor
    {
        get => GetArgument<TerraformValue<string>>("mv_temporal_predictor") ?? AsReference("mv_temporal_predictor");
        set => SetArgument("mv_temporal_predictor", value);
    }

    /// <summary>
    /// The par_denominator attribute.
    /// </summary>
    public TerraformValue<double>? ParDenominator
    {
        get => GetArgument<TerraformValue<double>>("par_denominator");
        set => SetArgument("par_denominator", value);
    }

    /// <summary>
    /// The par_numerator attribute.
    /// </summary>
    public TerraformValue<double>? ParNumerator
    {
        get => GetArgument<TerraformValue<double>>("par_numerator");
        set => SetArgument("par_numerator", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformValue<string> Profile
    {
        get => GetArgument<TerraformValue<string>>("profile") ?? AsReference("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// The qvbr_quality_level attribute.
    /// </summary>
    public TerraformValue<double>? QvbrQualityLevel
    {
        get => GetArgument<TerraformValue<double>>("qvbr_quality_level");
        set => SetArgument("qvbr_quality_level", value);
    }

    /// <summary>
    /// The rate_control_mode attribute.
    /// </summary>
    public TerraformValue<string> RateControlMode
    {
        get => GetArgument<TerraformValue<string>>("rate_control_mode") ?? AsReference("rate_control_mode");
        set => SetArgument("rate_control_mode", value);
    }

    /// <summary>
    /// The scan_type attribute.
    /// </summary>
    public TerraformValue<string> ScanType
    {
        get => GetArgument<TerraformValue<string>>("scan_type") ?? AsReference("scan_type");
        set => SetArgument("scan_type", value);
    }

    /// <summary>
    /// The scene_change_detect attribute.
    /// </summary>
    public TerraformValue<string> SceneChangeDetect
    {
        get => GetArgument<TerraformValue<string>>("scene_change_detect") ?? AsReference("scene_change_detect");
        set => SetArgument("scene_change_detect", value);
    }

    /// <summary>
    /// The slices attribute.
    /// </summary>
    public TerraformValue<double>? Slices
    {
        get => GetArgument<TerraformValue<double>>("slices");
        set => SetArgument("slices", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier") ?? AsReference("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The tile_height attribute.
    /// </summary>
    public TerraformValue<double>? TileHeight
    {
        get => GetArgument<TerraformValue<double>>("tile_height");
        set => SetArgument("tile_height", value);
    }

    /// <summary>
    /// The tile_padding attribute.
    /// </summary>
    public TerraformValue<string> TilePadding
    {
        get => GetArgument<TerraformValue<string>>("tile_padding") ?? AsReference("tile_padding");
        set => SetArgument("tile_padding", value);
    }

    /// <summary>
    /// The tile_width attribute.
    /// </summary>
    public TerraformValue<double>? TileWidth
    {
        get => GetArgument<TerraformValue<double>>("tile_width");
        set => SetArgument("tile_width", value);
    }

    /// <summary>
    /// The timecode_insertion attribute.
    /// </summary>
    public TerraformValue<string> TimecodeInsertion
    {
        get => GetArgument<TerraformValue<string>>("timecode_insertion") ?? AsReference("timecode_insertion");
        set => SetArgument("timecode_insertion", value);
    }

    /// <summary>
    /// The treeblock_size attribute.
    /// </summary>
    public TerraformValue<string> TreeblockSize
    {
        get => GetArgument<TerraformValue<string>>("treeblock_size") ?? AsReference("treeblock_size");
        set => SetArgument("treeblock_size", value);
    }

    /// <summary>
    /// ColorSpaceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ColorSpaceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock>? ColorSpaceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock>>("color_space_settings");
        set => SetArgument("color_space_settings", value);
    }

    /// <summary>
    /// FilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlock>? FilterSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlock>>("filter_settings");
        set => SetArgument("filter_settings", value);
    }

    /// <summary>
    /// TimecodeBurninSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TimecodeBurninSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockTimecodeBurninSettingsBlock>? TimecodeBurninSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockTimecodeBurninSettingsBlock>>("timecode_burnin_settings");
        set => SetArgument("timecode_burnin_settings", value);
    }

}

/// <summary>
/// Block type for color_space_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "color_space_settings";

    /// <summary>
    /// ColorSpacePassthroughSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ColorSpacePassthroughSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockColorSpacePassthroughSettingsBlock>? ColorSpacePassthroughSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockColorSpacePassthroughSettingsBlock>>("color_space_passthrough_settings");
        set => SetArgument("color_space_passthrough_settings", value);
    }

    /// <summary>
    /// DolbyVision81Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DolbyVision81Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockDolbyVision81SettingsBlock>? DolbyVision81Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockDolbyVision81SettingsBlock>>("dolby_vision81_settings");
        set => SetArgument("dolby_vision81_settings", value);
    }

    /// <summary>
    /// Hdr10Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hdr10Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockHdr10SettingsBlock>? Hdr10Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockHdr10SettingsBlock>>("hdr10_settings");
        set => SetArgument("hdr10_settings", value);
    }

    /// <summary>
    /// Rec601Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rec601Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec601SettingsBlock>? Rec601Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec601SettingsBlock>>("rec601_settings");
        set => SetArgument("rec601_settings", value);
    }

    /// <summary>
    /// Rec709Settings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rec709Settings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec709SettingsBlock>? Rec709Settings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec709SettingsBlock>>("rec709_settings");
        set => SetArgument("rec709_settings", value);
    }

}

/// <summary>
/// Block type for color_space_passthrough_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockColorSpacePassthroughSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "color_space_passthrough_settings";

}

/// <summary>
/// Block type for dolby_vision81_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockDolbyVision81SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dolby_vision81_settings";

}

/// <summary>
/// Block type for hdr10_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockHdr10SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hdr10_settings";

    /// <summary>
    /// The max_cll attribute.
    /// </summary>
    public TerraformValue<double>? MaxCll
    {
        get => GetArgument<TerraformValue<double>>("max_cll");
        set => SetArgument("max_cll", value);
    }

    /// <summary>
    /// The max_fall attribute.
    /// </summary>
    public TerraformValue<double>? MaxFall
    {
        get => GetArgument<TerraformValue<double>>("max_fall");
        set => SetArgument("max_fall", value);
    }

}

/// <summary>
/// Block type for rec601_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec601SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rec601_settings";

}

/// <summary>
/// Block type for rec709_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockColorSpaceSettingsBlockRec709SettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rec709_settings";

}

/// <summary>
/// Block type for filter_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_settings";

    /// <summary>
    /// TemporalFilterSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemporalFilterSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock>? TemporalFilterSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock>>("temporal_filter_settings");
        set => SetArgument("temporal_filter_settings", value);
    }

}

/// <summary>
/// Block type for temporal_filter_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockFilterSettingsBlockTemporalFilterSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "temporal_filter_settings";

    /// <summary>
    /// The post_filter_sharpening attribute.
    /// </summary>
    public TerraformValue<string>? PostFilterSharpening
    {
        get => GetArgument<TerraformValue<string>>("post_filter_sharpening");
        set => SetArgument("post_filter_sharpening", value);
    }

    /// <summary>
    /// The strength attribute.
    /// </summary>
    public TerraformValue<string>? Strength
    {
        get => GetArgument<TerraformValue<string>>("strength");
        set => SetArgument("strength", value);
    }

}

/// <summary>
/// Block type for timecode_burnin_settings in AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlockVideoDescriptionsBlockCodecSettingsBlockH265SettingsBlockTimecodeBurninSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timecode_burnin_settings";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string> Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix") ?? AsReference("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The timecode_burnin_font_size attribute.
    /// </summary>
    public TerraformValue<string> TimecodeBurninFontSize
    {
        get => GetArgument<TerraformValue<string>>("timecode_burnin_font_size") ?? AsReference("timecode_burnin_font_size");
        set => SetArgument("timecode_burnin_font_size", value);
    }

    /// <summary>
    /// The timecode_burnin_position attribute.
    /// </summary>
    public TerraformValue<string> TimecodeBurninPosition
    {
        get => GetArgument<TerraformValue<string>>("timecode_burnin_position") ?? AsReference("timecode_burnin_position");
        set => SetArgument("timecode_burnin_position", value);
    }

}


/// <summary>
/// Block type for input_attachments in AwsMedialiveChannel.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_attachments";

    /// <summary>
    /// The input_attachment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachmentName is required")]
    public required TerraformValue<string> InputAttachmentName
    {
        get => GetRequiredArgument<TerraformValue<string>>("input_attachment_name");
        set => SetArgument("input_attachment_name", value);
    }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputId is required")]
    public required TerraformValue<string> InputId
    {
        get => GetRequiredArgument<TerraformValue<string>>("input_id");
        set => SetArgument("input_id", value);
    }

    /// <summary>
    /// AutomaticInputFailoverSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInputFailoverSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlock>? AutomaticInputFailoverSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlock>>("automatic_input_failover_settings");
        set => SetArgument("automatic_input_failover_settings", value);
    }

    /// <summary>
    /// InputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock>? InputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock>>("input_settings");
        set => SetArgument("input_settings", value);
    }

}

/// <summary>
/// Block type for automatic_input_failover_settings in AwsMedialiveChannelInputAttachmentsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_input_failover_settings";

    /// <summary>
    /// The error_clear_time_msec attribute.
    /// </summary>
    public TerraformValue<double>? ErrorClearTimeMsec
    {
        get => GetArgument<TerraformValue<double>>("error_clear_time_msec");
        set => SetArgument("error_clear_time_msec", value);
    }

    /// <summary>
    /// The input_preference attribute.
    /// </summary>
    public TerraformValue<string>? InputPreference
    {
        get => GetArgument<TerraformValue<string>>("input_preference");
        set => SetArgument("input_preference", value);
    }

    /// <summary>
    /// The secondary_input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryInputId is required")]
    public required TerraformValue<string> SecondaryInputId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secondary_input_id");
        set => SetArgument("secondary_input_id", value);
    }

    /// <summary>
    /// FailoverCondition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlock>? FailoverCondition
    {
        get => GetArgument<TerraformSet<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlock>>("failover_condition");
        set => SetArgument("failover_condition", value);
    }

}

/// <summary>
/// Block type for failover_condition in AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_condition";

    /// <summary>
    /// FailoverConditionSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverConditionSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock>? FailoverConditionSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock>>("failover_condition_settings");
        set => SetArgument("failover_condition_settings", value);
    }

}

/// <summary>
/// Block type for failover_condition_settings in AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_condition_settings";

    /// <summary>
    /// AudioSilenceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioSilenceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockAudioSilenceSettingsBlock>? AudioSilenceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockAudioSilenceSettingsBlock>>("audio_silence_settings");
        set => SetArgument("audio_silence_settings", value);
    }

    /// <summary>
    /// InputLossSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputLossSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockInputLossSettingsBlock>? InputLossSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockInputLossSettingsBlock>>("input_loss_settings");
        set => SetArgument("input_loss_settings", value);
    }

    /// <summary>
    /// VideoBlackSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VideoBlackSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockVideoBlackSettingsBlock>? VideoBlackSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockVideoBlackSettingsBlock>>("video_black_settings");
        set => SetArgument("video_black_settings", value);
    }

}

/// <summary>
/// Block type for audio_silence_settings in AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockAudioSilenceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_silence_settings";

    /// <summary>
    /// The audio_selector_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AudioSelectorName is required")]
    public required TerraformValue<string> AudioSelectorName
    {
        get => GetRequiredArgument<TerraformValue<string>>("audio_selector_name");
        set => SetArgument("audio_selector_name", value);
    }

    /// <summary>
    /// The audio_silence_threshold_msec attribute.
    /// </summary>
    public TerraformValue<double>? AudioSilenceThresholdMsec
    {
        get => GetArgument<TerraformValue<double>>("audio_silence_threshold_msec");
        set => SetArgument("audio_silence_threshold_msec", value);
    }

}

/// <summary>
/// Block type for input_loss_settings in AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockInputLossSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_loss_settings";

    /// <summary>
    /// The input_loss_threshold_msec attribute.
    /// </summary>
    public TerraformValue<double>? InputLossThresholdMsec
    {
        get => GetArgument<TerraformValue<double>>("input_loss_threshold_msec");
        set => SetArgument("input_loss_threshold_msec", value);
    }

}

/// <summary>
/// Block type for video_black_settings in AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockAutomaticInputFailoverSettingsBlockFailoverConditionBlockFailoverConditionSettingsBlockVideoBlackSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_black_settings";

    /// <summary>
    /// The black_detect_threshold attribute.
    /// </summary>
    public TerraformValue<double>? BlackDetectThreshold
    {
        get => GetArgument<TerraformValue<double>>("black_detect_threshold");
        set => SetArgument("black_detect_threshold", value);
    }

    /// <summary>
    /// The video_black_threshold_msec attribute.
    /// </summary>
    public TerraformValue<double>? VideoBlackThresholdMsec
    {
        get => GetArgument<TerraformValue<double>>("video_black_threshold_msec");
        set => SetArgument("video_black_threshold_msec", value);
    }

}

/// <summary>
/// Block type for input_settings in AwsMedialiveChannelInputAttachmentsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_settings";

    /// <summary>
    /// The deblock_filter attribute.
    /// </summary>
    public TerraformValue<string>? DeblockFilter
    {
        get => GetArgument<TerraformValue<string>>("deblock_filter");
        set => SetArgument("deblock_filter", value);
    }

    /// <summary>
    /// The denoise_filter attribute.
    /// </summary>
    public TerraformValue<string>? DenoiseFilter
    {
        get => GetArgument<TerraformValue<string>>("denoise_filter");
        set => SetArgument("denoise_filter", value);
    }

    /// <summary>
    /// The filter_strength attribute.
    /// </summary>
    public TerraformValue<double>? FilterStrength
    {
        get => GetArgument<TerraformValue<double>>("filter_strength");
        set => SetArgument("filter_strength", value);
    }

    /// <summary>
    /// The input_filter attribute.
    /// </summary>
    public TerraformValue<string> InputFilter
    {
        get => GetArgument<TerraformValue<string>>("input_filter") ?? AsReference("input_filter");
        set => SetArgument("input_filter", value);
    }

    /// <summary>
    /// The scte35_pid attribute.
    /// </summary>
    public TerraformValue<double>? Scte35Pid
    {
        get => GetArgument<TerraformValue<double>>("scte35_pid");
        set => SetArgument("scte35_pid", value);
    }

    /// <summary>
    /// The smpte2038_data_preference attribute.
    /// </summary>
    public TerraformValue<string>? Smpte2038DataPreference
    {
        get => GetArgument<TerraformValue<string>>("smpte2038_data_preference");
        set => SetArgument("smpte2038_data_preference", value);
    }

    /// <summary>
    /// The source_end_behavior attribute.
    /// </summary>
    public TerraformValue<string>? SourceEndBehavior
    {
        get => GetArgument<TerraformValue<string>>("source_end_behavior");
        set => SetArgument("source_end_behavior", value);
    }

    /// <summary>
    /// AudioSelector block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlock>? AudioSelector
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlock>>("audio_selector");
        set => SetArgument("audio_selector", value);
    }

    /// <summary>
    /// CaptionSelector block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlock>? CaptionSelector
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlock>>("caption_selector");
        set => SetArgument("caption_selector", value);
    }

    /// <summary>
    /// NetworkInputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkInputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlock>? NetworkInputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlock>>("network_input_settings");
        set => SetArgument("network_input_settings", value);
    }

    /// <summary>
    /// VideoSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VideoSelector block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockVideoSelectorBlock>? VideoSelector
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockVideoSelectorBlock>>("video_selector");
        set => SetArgument("video_selector", value);
    }

}

/// <summary>
/// Block type for audio_selector in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_selector";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SelectorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectorSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock>? SelectorSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock>>("selector_settings");
        set => SetArgument("selector_settings", value);
    }

}

/// <summary>
/// Block type for selector_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selector_settings";

    /// <summary>
    /// AudioHlsRenditionSelection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioHlsRenditionSelection block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioHlsRenditionSelectionBlock>? AudioHlsRenditionSelection
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioHlsRenditionSelectionBlock>>("audio_hls_rendition_selection");
        set => SetArgument("audio_hls_rendition_selection", value);
    }

    /// <summary>
    /// AudioLanguageSelection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioLanguageSelection block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioLanguageSelectionBlock>? AudioLanguageSelection
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioLanguageSelectionBlock>>("audio_language_selection");
        set => SetArgument("audio_language_selection", value);
    }

    /// <summary>
    /// AudioPidSelection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioPidSelection block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioPidSelectionBlock>? AudioPidSelection
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioPidSelectionBlock>>("audio_pid_selection");
        set => SetArgument("audio_pid_selection", value);
    }

    /// <summary>
    /// AudioTrackSelection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioTrackSelection block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlock>? AudioTrackSelection
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlock>>("audio_track_selection");
        set => SetArgument("audio_track_selection", value);
    }

}

/// <summary>
/// Block type for audio_hls_rendition_selection in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioHlsRenditionSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_hls_rendition_selection";

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for audio_language_selection in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioLanguageSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_language_selection";

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LanguageCode is required")]
    public required TerraformValue<string> LanguageCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The language_selection_policy attribute.
    /// </summary>
    public TerraformValue<string>? LanguageSelectionPolicy
    {
        get => GetArgument<TerraformValue<string>>("language_selection_policy");
        set => SetArgument("language_selection_policy", value);
    }

}

/// <summary>
/// Block type for audio_pid_selection in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioPidSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_pid_selection";

    /// <summary>
    /// The pid attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pid is required")]
    public required TerraformValue<double> Pid
    {
        get => GetRequiredArgument<TerraformValue<double>>("pid");
        set => SetArgument("pid", value);
    }

}

/// <summary>
/// Block type for audio_track_selection in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_track_selection";

    /// <summary>
    /// DolbyEDecode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DolbyEDecode block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockDolbyEDecodeBlock>? DolbyEDecode
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockDolbyEDecodeBlock>>("dolby_e_decode");
        set => SetArgument("dolby_e_decode", value);
    }

    /// <summary>
    /// Tracks block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tracks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Tracks block(s) required")]
    public required TerraformSet<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockTracksBlock> Tracks
    {
        get => GetRequiredArgument<TerraformSet<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockTracksBlock>>("tracks");
        set => SetArgument("tracks", value);
    }

}

/// <summary>
/// Block type for dolby_e_decode in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockDolbyEDecodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dolby_e_decode";

    /// <summary>
    /// The program_selection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProgramSelection is required")]
    public required TerraformValue<string> ProgramSelection
    {
        get => GetRequiredArgument<TerraformValue<string>>("program_selection");
        set => SetArgument("program_selection", value);
    }

}

/// <summary>
/// Block type for tracks in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlock.
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockAudioSelectorBlockSelectorSettingsBlockAudioTrackSelectionBlockTracksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tracks";

    /// <summary>
    /// The track attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Track is required")]
    public required TerraformValue<double> Track
    {
        get => GetRequiredArgument<TerraformValue<double>>("track");
        set => SetArgument("track", value);
    }

}

/// <summary>
/// Block type for caption_selector in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "caption_selector";

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SelectorSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectorSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock>? SelectorSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock>>("selector_settings");
        set => SetArgument("selector_settings", value);
    }

}

/// <summary>
/// Block type for selector_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selector_settings";

    /// <summary>
    /// AncillarySourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AncillarySourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAncillarySourceSettingsBlock>? AncillarySourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAncillarySourceSettingsBlock>>("ancillary_source_settings");
        set => SetArgument("ancillary_source_settings", value);
    }

    /// <summary>
    /// AribSourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AribSourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAribSourceSettingsBlock>? AribSourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAribSourceSettingsBlock>>("arib_source_settings");
        set => SetArgument("arib_source_settings", value);
    }

    /// <summary>
    /// DvbSubSourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DvbSubSourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockDvbSubSourceSettingsBlock>? DvbSubSourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockDvbSubSourceSettingsBlock>>("dvb_sub_source_settings");
        set => SetArgument("dvb_sub_source_settings", value);
    }

    /// <summary>
    /// EmbeddedSourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmbeddedSourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockEmbeddedSourceSettingsBlock>? EmbeddedSourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockEmbeddedSourceSettingsBlock>>("embedded_source_settings");
        set => SetArgument("embedded_source_settings", value);
    }

    /// <summary>
    /// Scte20SourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scte20SourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte20SourceSettingsBlock>? Scte20SourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte20SourceSettingsBlock>>("scte20_source_settings");
        set => SetArgument("scte20_source_settings", value);
    }

    /// <summary>
    /// Scte27SourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scte27SourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte27SourceSettingsBlock>? Scte27SourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte27SourceSettingsBlock>>("scte27_source_settings");
        set => SetArgument("scte27_source_settings", value);
    }

    /// <summary>
    /// TeletextSourceSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TeletextSourceSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlock>? TeletextSourceSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlock>>("teletext_source_settings");
        set => SetArgument("teletext_source_settings", value);
    }

}

/// <summary>
/// Block type for ancillary_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAncillarySourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ancillary_source_settings";

    /// <summary>
    /// The source_ancillary_channel_number attribute.
    /// </summary>
    public TerraformValue<double>? SourceAncillaryChannelNumber
    {
        get => GetArgument<TerraformValue<double>>("source_ancillary_channel_number");
        set => SetArgument("source_ancillary_channel_number", value);
    }

}

/// <summary>
/// Block type for arib_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockAribSourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "arib_source_settings";

}

/// <summary>
/// Block type for dvb_sub_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockDvbSubSourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dvb_sub_source_settings";

    /// <summary>
    /// The ocr_language attribute.
    /// </summary>
    public TerraformValue<string>? OcrLanguage
    {
        get => GetArgument<TerraformValue<string>>("ocr_language");
        set => SetArgument("ocr_language", value);
    }

    /// <summary>
    /// The pid attribute.
    /// </summary>
    public TerraformValue<double>? Pid
    {
        get => GetArgument<TerraformValue<double>>("pid");
        set => SetArgument("pid", value);
    }

}

/// <summary>
/// Block type for embedded_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockEmbeddedSourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "embedded_source_settings";

    /// <summary>
    /// The convert_608_to_708 attribute.
    /// </summary>
    public TerraformValue<string>? Convert608To708
    {
        get => GetArgument<TerraformValue<string>>("convert_608_to_708");
        set => SetArgument("convert_608_to_708", value);
    }

    /// <summary>
    /// The scte20_detection attribute.
    /// </summary>
    public TerraformValue<string>? Scte20Detection
    {
        get => GetArgument<TerraformValue<string>>("scte20_detection");
        set => SetArgument("scte20_detection", value);
    }

    /// <summary>
    /// The source_608_channel_number attribute.
    /// </summary>
    public TerraformValue<double>? Source608ChannelNumber
    {
        get => GetArgument<TerraformValue<double>>("source_608_channel_number");
        set => SetArgument("source_608_channel_number", value);
    }

}

/// <summary>
/// Block type for scte20_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte20SourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scte20_source_settings";

    /// <summary>
    /// The convert_608_to_708 attribute.
    /// </summary>
    public TerraformValue<string>? Convert608To708
    {
        get => GetArgument<TerraformValue<string>>("convert_608_to_708");
        set => SetArgument("convert_608_to_708", value);
    }

    /// <summary>
    /// The source_608_channel_number attribute.
    /// </summary>
    public TerraformValue<double>? Source608ChannelNumber
    {
        get => GetArgument<TerraformValue<double>>("source_608_channel_number");
        set => SetArgument("source_608_channel_number", value);
    }

}

/// <summary>
/// Block type for scte27_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockScte27SourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scte27_source_settings";

    /// <summary>
    /// The ocr_language attribute.
    /// </summary>
    public TerraformValue<string>? OcrLanguage
    {
        get => GetArgument<TerraformValue<string>>("ocr_language");
        set => SetArgument("ocr_language", value);
    }

    /// <summary>
    /// The pid attribute.
    /// </summary>
    public TerraformValue<double>? Pid
    {
        get => GetArgument<TerraformValue<double>>("pid");
        set => SetArgument("pid", value);
    }

}

/// <summary>
/// Block type for teletext_source_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "teletext_source_settings";

    /// <summary>
    /// The page_number attribute.
    /// </summary>
    public TerraformValue<string>? PageNumber
    {
        get => GetArgument<TerraformValue<string>>("page_number");
        set => SetArgument("page_number", value);
    }

    /// <summary>
    /// OutputRectangle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputRectangle block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlockOutputRectangleBlock>? OutputRectangle
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlockOutputRectangleBlock>>("output_rectangle");
        set => SetArgument("output_rectangle", value);
    }

}

/// <summary>
/// Block type for output_rectangle in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockCaptionSelectorBlockSelectorSettingsBlockTeletextSourceSettingsBlockOutputRectangleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_rectangle";

    /// <summary>
    /// The height attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Height is required")]
    public required TerraformValue<double> Height
    {
        get => GetRequiredArgument<TerraformValue<double>>("height");
        set => SetArgument("height", value);
    }

    /// <summary>
    /// The left_offset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LeftOffset is required")]
    public required TerraformValue<double> LeftOffset
    {
        get => GetRequiredArgument<TerraformValue<double>>("left_offset");
        set => SetArgument("left_offset", value);
    }

    /// <summary>
    /// The top_offset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopOffset is required")]
    public required TerraformValue<double> TopOffset
    {
        get => GetRequiredArgument<TerraformValue<double>>("top_offset");
        set => SetArgument("top_offset", value);
    }

    /// <summary>
    /// The width attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Width is required")]
    public required TerraformValue<double> Width
    {
        get => GetRequiredArgument<TerraformValue<double>>("width");
        set => SetArgument("width", value);
    }

}

/// <summary>
/// Block type for network_input_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_input_settings";

    /// <summary>
    /// The server_validation attribute.
    /// </summary>
    public TerraformValue<string>? ServerValidation
    {
        get => GetArgument<TerraformValue<string>>("server_validation");
        set => SetArgument("server_validation", value);
    }

    /// <summary>
    /// HlsInputSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HlsInputSettings block(s) allowed")]
    public TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlockHlsInputSettingsBlock>? HlsInputSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlockHlsInputSettingsBlock>>("hls_input_settings");
        set => SetArgument("hls_input_settings", value);
    }

}

/// <summary>
/// Block type for hls_input_settings in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockNetworkInputSettingsBlockHlsInputSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hls_input_settings";

    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    public TerraformValue<double>? Bandwidth
    {
        get => GetArgument<TerraformValue<double>>("bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// The buffer_segments attribute.
    /// </summary>
    public TerraformValue<double>? BufferSegments
    {
        get => GetArgument<TerraformValue<double>>("buffer_segments");
        set => SetArgument("buffer_segments", value);
    }

    /// <summary>
    /// The retries attribute.
    /// </summary>
    public TerraformValue<double>? Retries
    {
        get => GetArgument<TerraformValue<double>>("retries");
        set => SetArgument("retries", value);
    }

    /// <summary>
    /// The retry_interval attribute.
    /// </summary>
    public TerraformValue<double>? RetryInterval
    {
        get => GetArgument<TerraformValue<double>>("retry_interval");
        set => SetArgument("retry_interval", value);
    }

    /// <summary>
    /// The scte35_source attribute.
    /// </summary>
    public TerraformValue<string>? Scte35Source
    {
        get => GetArgument<TerraformValue<string>>("scte35_source");
        set => SetArgument("scte35_source", value);
    }

}

/// <summary>
/// Block type for video_selector in AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlockInputSettingsBlockVideoSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_selector";

    /// <summary>
    /// The color_space attribute.
    /// </summary>
    public TerraformValue<string>? ColorSpace
    {
        get => GetArgument<TerraformValue<string>>("color_space");
        set => SetArgument("color_space", value);
    }

    /// <summary>
    /// The color_space_usage attribute.
    /// </summary>
    public TerraformValue<string>? ColorSpaceUsage
    {
        get => GetArgument<TerraformValue<string>>("color_space_usage");
        set => SetArgument("color_space_usage", value);
    }

}


/// <summary>
/// Block type for input_specification in AwsMedialiveChannel.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_specification";

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Codec is required")]
    public required TerraformValue<string> Codec
    {
        get => GetRequiredArgument<TerraformValue<string>>("codec");
        set => SetArgument("codec", value);
    }

    /// <summary>
    /// The input_resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputResolution is required")]
    public required TerraformValue<string> InputResolution
    {
        get => GetRequiredArgument<TerraformValue<string>>("input_resolution");
        set => SetArgument("input_resolution", value);
    }

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBitrate is required")]
    public required TerraformValue<string> MaximumBitrate
    {
        get => GetRequiredArgument<TerraformValue<string>>("maximum_bitrate");
        set => SetArgument("maximum_bitrate", value);
    }

}


/// <summary>
/// Block type for maintenance in AwsMedialiveChannel.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelMaintenanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance";

    /// <summary>
    /// The maintenance_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceDay is required")]
    public required TerraformValue<string> MaintenanceDay
    {
        get => GetRequiredArgument<TerraformValue<string>>("maintenance_day");
        set => SetArgument("maintenance_day", value);
    }

    /// <summary>
    /// The maintenance_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceStartTime is required")]
    public required TerraformValue<string> MaintenanceStartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("maintenance_start_time");
        set => SetArgument("maintenance_start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMedialiveChannel.
/// Nesting mode: single
/// </summary>
public class AwsMedialiveChannelTimeoutsBlock : TerraformBlock
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
/// Block type for vpc in AwsMedialiveChannel.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelVpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc";

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
        => AsReference("network_interface_ids");

    /// <summary>
    /// The public_address_allocation_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicAddressAllocationIds is required")]
    public TerraformList<string>? PublicAddressAllocationIds
    {
        get => GetArgument<TerraformList<string>>("public_address_allocation_ids");
        set => SetArgument("public_address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? AsReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Represents a aws_medialive_channel Terraform resource.
/// Manages a aws_medialive_channel resource.
/// </summary>
public partial class AwsMedialiveChannel(string name) : TerraformResource("aws_medialive_channel", name)
{
    /// <summary>
    /// The channel_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelClass is required")]
    public required TerraformValue<string> ChannelClass
    {
        get => GetRequiredArgument<TerraformValue<string>>("channel_class");
        set => SetArgument("channel_class", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? AsReference("log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The start_channel attribute.
    /// </summary>
    public TerraformValue<bool>? StartChannel
    {
        get => GetArgument<TerraformValue<bool>>("start_channel");
        set => SetArgument("start_channel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    public TerraformValue<string> ChannelId
        => AsReference("channel_id");

    /// <summary>
    /// CdiInputSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdiInputSpecification block(s) allowed")]
    public TerraformList<AwsMedialiveChannelCdiInputSpecificationBlock>? CdiInputSpecification
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelCdiInputSpecificationBlock>>("cdi_input_specification");
        set => SetArgument("cdi_input_specification", value);
    }

    /// <summary>
    /// Destinations block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    public required TerraformSet<AwsMedialiveChannelDestinationsBlock> Destinations
    {
        get => GetRequiredArgument<TerraformSet<AwsMedialiveChannelDestinationsBlock>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// EncoderSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncoderSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncoderSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncoderSettings block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelEncoderSettingsBlock> EncoderSettings
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelEncoderSettingsBlock>>("encoder_settings");
        set => SetArgument("encoder_settings", value);
    }

    /// <summary>
    /// InputAttachments block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputAttachments block(s) required")]
    public required TerraformSet<AwsMedialiveChannelInputAttachmentsBlock> InputAttachments
    {
        get => GetRequiredArgument<TerraformSet<AwsMedialiveChannelInputAttachmentsBlock>>("input_attachments");
        set => SetArgument("input_attachments", value);
    }

    /// <summary>
    /// InputSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSpecification block(s) allowed")]
    public required TerraformList<AwsMedialiveChannelInputSpecificationBlock> InputSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsMedialiveChannelInputSpecificationBlock>>("input_specification");
        set => SetArgument("input_specification", value);
    }

    /// <summary>
    /// Maintenance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Maintenance block(s) allowed")]
    public TerraformList<AwsMedialiveChannelMaintenanceBlock>? Maintenance
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelMaintenanceBlock>>("maintenance");
        set => SetArgument("maintenance", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMedialiveChannelTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMedialiveChannelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Vpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public TerraformList<AwsMedialiveChannelVpcBlock>? Vpc
    {
        get => GetArgument<TerraformList<AwsMedialiveChannelVpcBlock>>("vpc");
        set => SetArgument("vpc", value);
    }

}

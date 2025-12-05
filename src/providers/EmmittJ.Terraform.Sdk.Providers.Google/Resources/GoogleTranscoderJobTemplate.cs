using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GoogleTranscoderJobTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// AdBreaks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockAdBreaksBlock>? AdBreaks
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockAdBreaksBlock>>("ad_breaks");
        set => SetArgument("ad_breaks", value);
    }

    /// <summary>
    /// EditList block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEditListBlock>? EditList
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEditListBlock>>("edit_list");
        set => SetArgument("edit_list", value);
    }

    /// <summary>
    /// ElementaryStreams block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlock>? ElementaryStreams
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlock>>("elementary_streams");
        set => SetArgument("elementary_streams", value);
    }

    /// <summary>
    /// Encryptions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock>? Encryptions
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock>>("encryptions");
        set => SetArgument("encryptions", value);
    }

    /// <summary>
    /// Inputs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockInputsBlock>? Inputs
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockInputsBlock>>("inputs");
        set => SetArgument("inputs", value);
    }

    /// <summary>
    /// Manifests block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockManifestsBlock>? Manifests
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockManifestsBlock>>("manifests");
        set => SetArgument("manifests", value);
    }

    /// <summary>
    /// MuxStreams block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlock>? MuxStreams
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlock>>("mux_streams");
        set => SetArgument("mux_streams", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Output block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOutputBlock>? Output
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// Overlays block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlock>? Overlays
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlock>>("overlays");
        set => SetArgument("overlays", value);
    }

    /// <summary>
    /// PubsubDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubDestination block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockPubsubDestinationBlock>? PubsubDestination
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockPubsubDestinationBlock>>("pubsub_destination");
        set => SetArgument("pubsub_destination", value);
    }

}

/// <summary>
/// Block type for ad_breaks in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockAdBreaksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ad_breaks";

    /// <summary>
    /// Start time in seconds for the ad break, relative to the output file timeline
    /// </summary>
    public TerraformValue<string> StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset") ?? CreateReference("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

}

/// <summary>
/// Block type for edit_list in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEditListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "edit_list";

    /// <summary>
    /// List of values identifying files that should be used in this atom.
    /// </summary>
    public TerraformList<string> Inputs
    {
        get => GetArgument<TerraformList<string>>("inputs") ?? CreateReference("inputs");
        set => SetArgument("inputs", value);
    }

    /// <summary>
    /// A unique key for this atom.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? CreateReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Start time in seconds for the atom, relative to the input file timeline.  The default is &#39;0s&#39;.
    /// </summary>
    public TerraformValue<string> StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset") ?? CreateReference("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

}

/// <summary>
/// Block type for elementary_streams in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elementary_streams";

    /// <summary>
    /// A unique key for this atom.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? CreateReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// AudioStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioStream block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockAudioStreamBlock>? AudioStream
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockAudioStreamBlock>>("audio_stream");
        set => SetArgument("audio_stream", value);
    }

    /// <summary>
    /// VideoStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VideoStream block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlock>? VideoStream
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlock>>("video_stream");
        set => SetArgument("video_stream", value);
    }

}

/// <summary>
/// Block type for audio_stream in GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockAudioStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_stream";

    /// <summary>
    /// Audio bitrate in bits per second.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BitrateBps is required")]
    public required TerraformValue<double> BitrateBps
    {
        get => GetRequiredArgument<TerraformValue<double>>("bitrate_bps");
        set => SetArgument("bitrate_bps", value);
    }

    /// <summary>
    /// Number of audio channels. The default is &#39;2&#39;.
    /// </summary>
    public TerraformValue<double> ChannelCount
    {
        get => GetArgument<TerraformValue<double>>("channel_count") ?? CreateReference("channel_count");
        set => SetArgument("channel_count", value);
    }

    /// <summary>
    /// A list of channel names specifying layout of the audio channels.  The default is [&amp;quot;fl&amp;quot;, &amp;quot;fr&amp;quot;].
    /// </summary>
    public TerraformList<string> ChannelLayout
    {
        get => GetArgument<TerraformList<string>>("channel_layout") ?? CreateReference("channel_layout");
        set => SetArgument("channel_layout", value);
    }

    /// <summary>
    /// The codec for this audio stream. The default is &#39;aac&#39;.
    /// </summary>
    public TerraformValue<string> Codec
    {
        get => GetArgument<TerraformValue<string>>("codec") ?? CreateReference("codec");
        set => SetArgument("codec", value);
    }

    /// <summary>
    /// The audio sample rate in Hertz. The default is &#39;48000&#39;.
    /// </summary>
    public TerraformValue<double> SampleRateHertz
    {
        get => GetArgument<TerraformValue<double>>("sample_rate_hertz") ?? CreateReference("sample_rate_hertz");
        set => SetArgument("sample_rate_hertz", value);
    }

}

/// <summary>
/// Block type for video_stream in GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_stream";

    /// <summary>
    /// H264 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 H264 block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block>? H264
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block>>("h264");
        set => SetArgument("h264", value);
    }

}

/// <summary>
/// Block type for h264 in GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "h264";

    /// <summary>
    /// The video bitrate in bits per second.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BitrateBps is required")]
    public required TerraformValue<double> BitrateBps
    {
        get => GetRequiredArgument<TerraformValue<double>>("bitrate_bps");
        set => SetArgument("bitrate_bps", value);
    }

    /// <summary>
    /// Target CRF level. The default is &#39;21&#39;.
    /// </summary>
    public TerraformValue<double> CrfLevel
    {
        get => GetArgument<TerraformValue<double>>("crf_level") ?? CreateReference("crf_level");
        set => SetArgument("crf_level", value);
    }

    /// <summary>
    /// The entropy coder to use. The default is &#39;cabac&#39;.
    /// </summary>
    public TerraformValue<string> EntropyCoder
    {
        get => GetArgument<TerraformValue<string>>("entropy_coder") ?? CreateReference("entropy_coder");
        set => SetArgument("entropy_coder", value);
    }

    /// <summary>
    /// The target video frame rate in frames per second (FPS).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameRate is required")]
    public required TerraformValue<double> FrameRate
    {
        get => GetRequiredArgument<TerraformValue<double>>("frame_rate");
        set => SetArgument("frame_rate", value);
    }

    /// <summary>
    /// Select the GOP size based on the specified duration. The default is &#39;3s&#39;.
    /// </summary>
    public TerraformValue<string> GopDuration
    {
        get => GetArgument<TerraformValue<string>>("gop_duration") ?? CreateReference("gop_duration");
        set => SetArgument("gop_duration", value);
    }

    /// <summary>
    /// The height of the video in pixels.
    /// </summary>
    public TerraformValue<double> HeightPixels
    {
        get => GetArgument<TerraformValue<double>>("height_pixels") ?? CreateReference("height_pixels");
        set => SetArgument("height_pixels", value);
    }

    /// <summary>
    /// Pixel format to use. The default is &#39;yuv420p&#39;.
    /// </summary>
    public TerraformValue<string> PixelFormat
    {
        get => GetArgument<TerraformValue<string>>("pixel_format") ?? CreateReference("pixel_format");
        set => SetArgument("pixel_format", value);
    }

    /// <summary>
    /// Enforces the specified codec preset. The default is &#39;veryfast&#39;.
    /// </summary>
    public TerraformValue<string> Preset
    {
        get => GetArgument<TerraformValue<string>>("preset") ?? CreateReference("preset");
        set => SetArgument("preset", value);
    }

    /// <summary>
    /// Enforces the specified codec profile.
    /// </summary>
    public TerraformValue<string> Profile
    {
        get => GetArgument<TerraformValue<string>>("profile") ?? CreateReference("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// Specify the mode. The default is &#39;vbr&#39;.
    /// </summary>
    public TerraformValue<string> RateControlMode
    {
        get => GetArgument<TerraformValue<string>>("rate_control_mode") ?? CreateReference("rate_control_mode");
        set => SetArgument("rate_control_mode", value);
    }

    /// <summary>
    /// Initial fullness of the Video Buffering Verifier (VBV) buffer in bits.
    /// </summary>
    public TerraformValue<double> VbvFullnessBits
    {
        get => GetArgument<TerraformValue<double>>("vbv_fullness_bits") ?? CreateReference("vbv_fullness_bits");
        set => SetArgument("vbv_fullness_bits", value);
    }

    /// <summary>
    /// Size of the Video Buffering Verifier (VBV) buffer in bits.
    /// </summary>
    public TerraformValue<double> VbvSizeBits
    {
        get => GetArgument<TerraformValue<double>>("vbv_size_bits") ?? CreateReference("vbv_size_bits");
        set => SetArgument("vbv_size_bits", value);
    }

    /// <summary>
    /// The width of the video in pixels.
    /// </summary>
    public TerraformValue<double> WidthPixels
    {
        get => GetArgument<TerraformValue<double>>("width_pixels") ?? CreateReference("width_pixels");
        set => SetArgument("width_pixels", value);
    }

    /// <summary>
    /// Hlg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hlg block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock>? Hlg
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock>>("hlg");
        set => SetArgument("hlg", value);
    }

    /// <summary>
    /// Sdr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sdr block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock>? Sdr
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock>>("sdr");
        set => SetArgument("sdr", value);
    }

}

/// <summary>
/// Block type for hlg in GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hlg";

}

/// <summary>
/// Block type for sdr in GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sdr";

}

/// <summary>
/// Block type for encryptions in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryptions";

    /// <summary>
    /// Identifier for this set of encryption options.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Aes128 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aes128 block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockAes128Block>? Aes128
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockAes128Block>>("aes128");
        set => SetArgument("aes128", value);
    }

    /// <summary>
    /// DrmSystems block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DrmSystems block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock>? DrmSystems
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock>>("drm_systems");
        set => SetArgument("drm_systems", value);
    }

    /// <summary>
    /// MpegCenc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MpegCenc block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockMpegCencBlock>? MpegCenc
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockMpegCencBlock>>("mpeg_cenc");
        set => SetArgument("mpeg_cenc", value);
    }

    /// <summary>
    /// SampleAes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SampleAes block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSampleAesBlock>? SampleAes
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSampleAesBlock>>("sample_aes");
        set => SetArgument("sample_aes", value);
    }

    /// <summary>
    /// SecretManagerKeySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerKeySource block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSecretManagerKeySourceBlock>? SecretManagerKeySource
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSecretManagerKeySourceBlock>>("secret_manager_key_source");
        set => SetArgument("secret_manager_key_source", value);
    }

}

/// <summary>
/// Block type for aes128 in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockAes128Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aes128";

}

/// <summary>
/// Block type for drm_systems in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "drm_systems";

    /// <summary>
    /// Clearkey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clearkey block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock>? Clearkey
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock>>("clearkey");
        set => SetArgument("clearkey", value);
    }

    /// <summary>
    /// Fairplay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fairplay block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock>? Fairplay
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock>>("fairplay");
        set => SetArgument("fairplay", value);
    }

    /// <summary>
    /// Playready block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Playready block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock>? Playready
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock>>("playready");
        set => SetArgument("playready", value);
    }

    /// <summary>
    /// Widevine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Widevine block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock>? Widevine
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock>>("widevine");
        set => SetArgument("widevine", value);
    }

}

/// <summary>
/// Block type for clearkey in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clearkey";

}

/// <summary>
/// Block type for fairplay in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fairplay";

}

/// <summary>
/// Block type for playready in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "playready";

}

/// <summary>
/// Block type for widevine in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "widevine";

}

/// <summary>
/// Block type for mpeg_cenc in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockMpegCencBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mpeg_cenc";

    /// <summary>
    /// Specify the encryption scheme.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scheme is required")]
    public required TerraformValue<string> Scheme
    {
        get => GetRequiredArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

}

/// <summary>
/// Block type for sample_aes in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSampleAesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sample_aes";

}

/// <summary>
/// Block type for secret_manager_key_source in GoogleTranscoderJobTemplateConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockEncryptionsBlockSecretManagerKeySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_manager_key_source";

    /// <summary>
    /// The name of the Secret Version containing the encryption key in the following format: projects/{project}/secrets/{secret_id}/versions/{version_number}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for inputs in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockInputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inputs";

    /// <summary>
    /// A unique key for this input. Must be specified when using advanced mapping and edit lists.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? CreateReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for example, gs://bucket/inputs/file.mp4).
    /// If empty, the value is populated from Job.input_uri.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri") ?? CreateReference("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for manifests in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockManifestsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manifests";

    /// <summary>
    /// The name of the generated file. The default is &#39;manifest&#39;.
    /// </summary>
    public TerraformValue<string> FileName
    {
        get => GetArgument<TerraformValue<string>>("file_name") ?? CreateReference("file_name");
        set => SetArgument("file_name", value);
    }

    /// <summary>
    /// List of user supplied MuxStream.key values that should appear in this manifest.
    /// </summary>
    public TerraformList<string> MuxStreams
    {
        get => GetArgument<TerraformList<string>>("mux_streams") ?? CreateReference("mux_streams");
        set => SetArgument("mux_streams", value);
    }

    /// <summary>
    /// Type of the manifest. Possible values: [&amp;quot;MANIFEST_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;HLS&amp;quot;, &amp;quot;DASH&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? CreateReference("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for mux_streams in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mux_streams";

    /// <summary>
    /// The container format. The default is &#39;mp4&#39;.
    /// </summary>
    public TerraformValue<string> Container
    {
        get => GetArgument<TerraformValue<string>>("container") ?? CreateReference("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// List of ElementaryStream.key values multiplexed in this stream.
    /// </summary>
    public TerraformList<string> ElementaryStreams
    {
        get => GetArgument<TerraformList<string>>("elementary_streams") ?? CreateReference("elementary_streams");
        set => SetArgument("elementary_streams", value);
    }

    /// <summary>
    /// Identifier of the encryption configuration to use.
    /// </summary>
    public TerraformValue<string> EncryptionId
    {
        get => GetArgument<TerraformValue<string>>("encryption_id") ?? CreateReference("encryption_id");
        set => SetArgument("encryption_id", value);
    }

    /// <summary>
    /// The name of the generated file.
    /// </summary>
    public TerraformValue<string> FileName
    {
        get => GetArgument<TerraformValue<string>>("file_name") ?? CreateReference("file_name");
        set => SetArgument("file_name", value);
    }

    /// <summary>
    /// A unique key for this multiplexed stream.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key") ?? CreateReference("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// SegmentSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SegmentSettings block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlockSegmentSettingsBlock>? SegmentSettings
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlockSegmentSettingsBlock>>("segment_settings");
        set => SetArgument("segment_settings", value);
    }

}

/// <summary>
/// Block type for segment_settings in GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockMuxStreamsBlockSegmentSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segment_settings";

    /// <summary>
    /// Duration of the segments in seconds. The default is &#39;6.0s&#39;.
    /// </summary>
    public TerraformValue<string> SegmentDuration
    {
        get => GetArgument<TerraformValue<string>>("segment_duration") ?? CreateReference("segment_duration");
        set => SetArgument("segment_duration", value);
    }

}

/// <summary>
/// Block type for output in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

    /// <summary>
    /// URI for the output file(s). For example, gs://my-bucket/outputs/.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri") ?? CreateReference("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for overlays in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOverlaysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overlays";

    /// <summary>
    /// Animations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlock>? Animations
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlock>>("animations");
        set => SetArgument("animations", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockImageBlock>? Image
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

}

/// <summary>
/// Block type for animations in GoogleTranscoderJobTemplateConfigBlockOverlaysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "animations";

    /// <summary>
    /// AnimationFade block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnimationFade block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock>? AnimationFade
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock>>("animation_fade");
        set => SetArgument("animation_fade", value);
    }

}

/// <summary>
/// Block type for animation_fade in GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "animation_fade";

    /// <summary>
    /// The time to end the fade animation, in seconds.
    /// </summary>
    public TerraformValue<string> EndTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("end_time_offset") ?? CreateReference("end_time_offset");
        set => SetArgument("end_time_offset", value);
    }

    /// <summary>
    /// Required. Type of fade animation: &#39;FADE_IN&#39; or &#39;FADE_OUT&#39;.
    /// The possible values are:
    /// 
    /// * &#39;FADE_TYPE_UNSPECIFIED&#39;: The fade type is not specified.
    /// 
    /// * &#39;FADE_IN&#39;: Fade the overlay object into view.
    /// 
    /// * &#39;FADE_OUT&#39;: Fade the overlay object out of view. Possible values: [&amp;quot;FADE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;FADE_IN&amp;quot;, &amp;quot;FADE_OUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FadeType is required")]
    public required TerraformValue<string> FadeType
    {
        get => GetRequiredArgument<TerraformValue<string>>("fade_type");
        set => SetArgument("fade_type", value);
    }

    /// <summary>
    /// The time to start the fade animation, in seconds.
    /// </summary>
    public TerraformValue<string> StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset") ?? CreateReference("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

    /// <summary>
    /// Xy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Xy block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock>? Xy
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock>>("xy");
        set => SetArgument("xy", value);
    }

}

/// <summary>
/// Block type for xy in GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xy";

    /// <summary>
    /// Normalized x coordinate.
    /// </summary>
    public TerraformValue<double> X
    {
        get => GetArgument<TerraformValue<double>>("x") ?? CreateReference("x");
        set => SetArgument("x", value);
    }

    /// <summary>
    /// Normalized y coordinate.
    /// </summary>
    public TerraformValue<double> Y
    {
        get => GetArgument<TerraformValue<double>>("y") ?? CreateReference("y");
        set => SetArgument("y", value);
    }

}

/// <summary>
/// Block type for image in GoogleTranscoderJobTemplateConfigBlockOverlaysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockOverlaysBlockImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image";

    /// <summary>
    /// URI of the image in Cloud Storage. For example, gs://bucket/inputs/image.png.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetRequiredArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for pubsub_destination in GoogleTranscoderJobTemplateConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobTemplateConfigBlockPubsubDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_destination";

    /// <summary>
    /// The name of the Pub/Sub topic to publish job completion notification to. For example: projects/{project}/topics/{topic}.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleTranscoderJobTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleTranscoderJobTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_transcoder_job_template Terraform resource.
/// Manages a google_transcoder_job_template resource.
/// </summary>
public partial class GoogleTranscoderJobTemplate(string name) : TerraformResource("google_transcoder_job_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID to use for the Transcoding job template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTemplateId is required")]
    public required TerraformValue<string> JobTemplateId
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_template_id");
        set => SetArgument("job_template_id", value);
    }

    /// <summary>
    /// The labels associated with this job template. You can use these to organize and group your job templates.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the transcoding job template resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The resource name of the job template.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleTranscoderJobTemplateConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobTemplateConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleTranscoderJobTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleTranscoderJobTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in GoogleTranscoderJob.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config";

    /// <summary>
    /// AdBreaks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockAdBreaksBlock>? AdBreaks
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockAdBreaksBlock>>("ad_breaks");
        set => SetArgument("ad_breaks", value);
    }

    /// <summary>
    /// EditList block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockEditListBlock>? EditList
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEditListBlock>>("edit_list");
        set => SetArgument("edit_list", value);
    }

    /// <summary>
    /// ElementaryStreams block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlock>? ElementaryStreams
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlock>>("elementary_streams");
        set => SetArgument("elementary_streams", value);
    }

    /// <summary>
    /// Encryptions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlock>? Encryptions
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlock>>("encryptions");
        set => SetArgument("encryptions", value);
    }

    /// <summary>
    /// Inputs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockInputsBlock>? Inputs
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockInputsBlock>>("inputs");
        set => SetArgument("inputs", value);
    }

    /// <summary>
    /// Manifests block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockManifestsBlock>? Manifests
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockManifestsBlock>>("manifests");
        set => SetArgument("manifests", value);
    }

    /// <summary>
    /// MuxStreams block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockMuxStreamsBlock>? MuxStreams
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockMuxStreamsBlock>>("mux_streams");
        set => SetArgument("mux_streams", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Output block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockOutputBlock>? Output
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// Overlays block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlock>? Overlays
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlock>>("overlays");
        set => SetArgument("overlays", value);
    }

    /// <summary>
    /// PubsubDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubDestination block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockPubsubDestinationBlock>? PubsubDestination
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockPubsubDestinationBlock>>("pubsub_destination");
        set => SetArgument("pubsub_destination", value);
    }

}

/// <summary>
/// Block type for ad_breaks in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockAdBreaksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ad_breaks";

    /// <summary>
    /// Start time in seconds for the ad break, relative to the output file timeline
    /// </summary>
    public TerraformValue<string>? StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

}

/// <summary>
/// Block type for edit_list in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEditListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "edit_list";

    /// <summary>
    /// List of values identifying files that should be used in this atom.
    /// </summary>
    public TerraformList<string>? Inputs
    {
        get => GetArgument<TerraformList<string>>("inputs");
        set => SetArgument("inputs", value);
    }

    /// <summary>
    /// A unique key for this atom.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Start time in seconds for the atom, relative to the input file timeline. The default is &#39;0s&#39;.
    /// </summary>
    public TerraformValue<string>? StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

}

/// <summary>
/// Block type for elementary_streams in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elementary_streams";

    /// <summary>
    /// A unique key for this atom.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// AudioStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioStream block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockAudioStreamBlock>? AudioStream
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockAudioStreamBlock>>("audio_stream");
        set => SetArgument("audio_stream", value);
    }

    /// <summary>
    /// VideoStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VideoStream block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlock>? VideoStream
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlock>>("video_stream");
        set => SetArgument("video_stream", value);
    }

}

/// <summary>
/// Block type for audio_stream in GoogleTranscoderJobConfigBlockElementaryStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlockAudioStreamBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("bitrate_bps");
        set => SetArgument("bitrate_bps", value);
    }

    /// <summary>
    /// Number of audio channels. The default is &#39;2&#39;.
    /// </summary>
    public TerraformValue<double>? ChannelCount
    {
        get => GetArgument<TerraformValue<double>>("channel_count");
        set => SetArgument("channel_count", value);
    }

    /// <summary>
    /// A list of channel names specifying layout of the audio channels. The default is [&amp;quot;fl&amp;quot;, &amp;quot;fr&amp;quot;].
    /// </summary>
    public TerraformList<string>? ChannelLayout
    {
        get => GetArgument<TerraformList<string>>("channel_layout");
        set => SetArgument("channel_layout", value);
    }

    /// <summary>
    /// The codec for this audio stream. The default is &#39;aac&#39;.
    /// </summary>
    public TerraformValue<string>? Codec
    {
        get => GetArgument<TerraformValue<string>>("codec");
        set => SetArgument("codec", value);
    }

    /// <summary>
    /// The audio sample rate in Hertz. The default is &#39;48000&#39;.
    /// </summary>
    public TerraformValue<double>? SampleRateHertz
    {
        get => GetArgument<TerraformValue<double>>("sample_rate_hertz");
        set => SetArgument("sample_rate_hertz", value);
    }

}

/// <summary>
/// Block type for video_stream in GoogleTranscoderJobConfigBlockElementaryStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_stream";

    /// <summary>
    /// H264 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 H264 block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block>? H264
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block>>("h264");
        set => SetArgument("h264", value);
    }

}

/// <summary>
/// Block type for h264 in GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("bitrate_bps");
        set => SetArgument("bitrate_bps", value);
    }

    /// <summary>
    /// Target CRF level. The default is &#39;21&#39;.
    /// </summary>
    public TerraformValue<double>? CrfLevel
    {
        get => GetArgument<TerraformValue<double>>("crf_level");
        set => SetArgument("crf_level", value);
    }

    /// <summary>
    /// The entropy coder to use. The default is &#39;cabac&#39;.
    /// </summary>
    public TerraformValue<string>? EntropyCoder
    {
        get => GetArgument<TerraformValue<string>>("entropy_coder");
        set => SetArgument("entropy_coder", value);
    }

    /// <summary>
    /// The target video frame rate in frames per second (FPS).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameRate is required")]
    public required TerraformValue<double> FrameRate
    {
        get => GetArgument<TerraformValue<double>>("frame_rate");
        set => SetArgument("frame_rate", value);
    }

    /// <summary>
    /// Select the GOP size based on the specified duration. The default is &#39;3s&#39;.
    /// </summary>
    public TerraformValue<string>? GopDuration
    {
        get => GetArgument<TerraformValue<string>>("gop_duration");
        set => SetArgument("gop_duration", value);
    }

    /// <summary>
    /// The height of the video in pixels.
    /// </summary>
    public TerraformValue<double>? HeightPixels
    {
        get => GetArgument<TerraformValue<double>>("height_pixels");
        set => SetArgument("height_pixels", value);
    }

    /// <summary>
    /// Pixel format to use. The default is &#39;yuv420p&#39;.
    /// </summary>
    public TerraformValue<string>? PixelFormat
    {
        get => GetArgument<TerraformValue<string>>("pixel_format");
        set => SetArgument("pixel_format", value);
    }

    /// <summary>
    /// Enforces the specified codec preset. The default is &#39;veryfast&#39;.
    /// </summary>
    public TerraformValue<string>? Preset
    {
        get => GetArgument<TerraformValue<string>>("preset");
        set => SetArgument("preset", value);
    }

    /// <summary>
    /// Enforces the specified codec profile.
    /// </summary>
    public TerraformValue<string>? Profile
    {
        get => GetArgument<TerraformValue<string>>("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// Specify the mode. The default is &#39;vbr&#39;.
    /// </summary>
    public TerraformValue<string>? RateControlMode
    {
        get => GetArgument<TerraformValue<string>>("rate_control_mode");
        set => SetArgument("rate_control_mode", value);
    }

    /// <summary>
    /// Initial fullness of the Video Buffering Verifier (VBV) buffer in bits.
    /// </summary>
    public TerraformValue<double>? VbvFullnessBits
    {
        get => GetArgument<TerraformValue<double>>("vbv_fullness_bits");
        set => SetArgument("vbv_fullness_bits", value);
    }

    /// <summary>
    /// Size of the Video Buffering Verifier (VBV) buffer in bits.
    /// </summary>
    public TerraformValue<double>? VbvSizeBits
    {
        get => GetArgument<TerraformValue<double>>("vbv_size_bits");
        set => SetArgument("vbv_size_bits", value);
    }

    /// <summary>
    /// The width of the video in pixels.
    /// </summary>
    public TerraformValue<double>? WidthPixels
    {
        get => GetArgument<TerraformValue<double>>("width_pixels");
        set => SetArgument("width_pixels", value);
    }

    /// <summary>
    /// Hlg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hlg block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock>? Hlg
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock>>("hlg");
        set => SetArgument("hlg", value);
    }

    /// <summary>
    /// Sdr block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sdr block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock>? Sdr
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock>>("sdr");
        set => SetArgument("sdr", value);
    }

}

/// <summary>
/// Block type for hlg in GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockHlgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hlg";

}

/// <summary>
/// Block type for sdr in GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264Block.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockElementaryStreamsBlockVideoStreamBlockH264BlockSdrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sdr";

}

/// <summary>
/// Block type for encryptions in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Aes128 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aes128 block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockAes128Block>? Aes128
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockAes128Block>>("aes128");
        set => SetArgument("aes128", value);
    }

    /// <summary>
    /// DrmSystems block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DrmSystems block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock>? DrmSystems
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock>>("drm_systems");
        set => SetArgument("drm_systems", value);
    }

    /// <summary>
    /// MpegCenc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MpegCenc block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockMpegCencBlock>? MpegCenc
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockMpegCencBlock>>("mpeg_cenc");
        set => SetArgument("mpeg_cenc", value);
    }

    /// <summary>
    /// SampleAes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SampleAes block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockSampleAesBlock>? SampleAes
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockSampleAesBlock>>("sample_aes");
        set => SetArgument("sample_aes", value);
    }

    /// <summary>
    /// SecretManagerKeySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretManagerKeySource block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockSecretManagerKeySourceBlock>? SecretManagerKeySource
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockSecretManagerKeySourceBlock>>("secret_manager_key_source");
        set => SetArgument("secret_manager_key_source", value);
    }

}

/// <summary>
/// Block type for aes128 in GoogleTranscoderJobConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockAes128Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aes128";

}

/// <summary>
/// Block type for drm_systems in GoogleTranscoderJobConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "drm_systems";

    /// <summary>
    /// Clearkey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Clearkey block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock>? Clearkey
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock>>("clearkey");
        set => SetArgument("clearkey", value);
    }

    /// <summary>
    /// Fairplay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fairplay block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock>? Fairplay
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock>>("fairplay");
        set => SetArgument("fairplay", value);
    }

    /// <summary>
    /// Playready block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Playready block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock>? Playready
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock>>("playready");
        set => SetArgument("playready", value);
    }

    /// <summary>
    /// Widevine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Widevine block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock>? Widevine
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock>>("widevine");
        set => SetArgument("widevine", value);
    }

}

/// <summary>
/// Block type for clearkey in GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockClearkeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "clearkey";

}

/// <summary>
/// Block type for fairplay in GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockFairplayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fairplay";

}

/// <summary>
/// Block type for playready in GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockPlayreadyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "playready";

}

/// <summary>
/// Block type for widevine in GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockDrmSystemsBlockWidevineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "widevine";

}

/// <summary>
/// Block type for mpeg_cenc in GoogleTranscoderJobConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockMpegCencBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

}

/// <summary>
/// Block type for sample_aes in GoogleTranscoderJobConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockSampleAesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sample_aes";

}

/// <summary>
/// Block type for secret_manager_key_source in GoogleTranscoderJobConfigBlockEncryptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockEncryptionsBlockSecretManagerKeySourceBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}

/// <summary>
/// Block type for inputs in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockInputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inputs";

    /// <summary>
    /// A unique key for this input. Must be specified when using advanced mapping and edit lists.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// URI of the media. Input files must be at least 5 seconds in duration and stored in Cloud Storage (for example, gs://bucket/inputs/file.mp4).
    /// If empty, the value is populated from Job.input_uri.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for manifests in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockManifestsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manifests";

    /// <summary>
    /// The name of the generated file. The default is &#39;manifest&#39;.
    /// </summary>
    public TerraformValue<string>? FileName
    {
        get => GetArgument<TerraformValue<string>>("file_name");
        set => SetArgument("file_name", value);
    }

    /// <summary>
    /// List of user supplied MuxStream.key values that should appear in this manifest.
    /// </summary>
    public TerraformList<string>? MuxStreams
    {
        get => GetArgument<TerraformList<string>>("mux_streams");
        set => SetArgument("mux_streams", value);
    }

    /// <summary>
    /// Type of the manifest. Possible values: [&amp;quot;MANIFEST_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;HLS&amp;quot;, &amp;quot;DASH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for mux_streams in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockMuxStreamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mux_streams";

    /// <summary>
    /// The container format. The default is &#39;mp4&#39;.
    /// </summary>
    public TerraformValue<string>? Container
    {
        get => GetArgument<TerraformValue<string>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// List of ElementaryStream.key values multiplexed in this stream.
    /// </summary>
    public TerraformList<string>? ElementaryStreams
    {
        get => GetArgument<TerraformList<string>>("elementary_streams");
        set => SetArgument("elementary_streams", value);
    }

    /// <summary>
    /// Identifier of the encryption configuration to use.
    /// </summary>
    public TerraformValue<string>? EncryptionId
    {
        get => GetArgument<TerraformValue<string>>("encryption_id");
        set => SetArgument("encryption_id", value);
    }

    /// <summary>
    /// The name of the generated file.
    /// </summary>
    public TerraformValue<string>? FileName
    {
        get => GetArgument<TerraformValue<string>>("file_name");
        set => SetArgument("file_name", value);
    }

    /// <summary>
    /// A unique key for this multiplexed stream.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// SegmentSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SegmentSettings block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockMuxStreamsBlockSegmentSettingsBlock>? SegmentSettings
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockMuxStreamsBlockSegmentSettingsBlock>>("segment_settings");
        set => SetArgument("segment_settings", value);
    }

}

/// <summary>
/// Block type for segment_settings in GoogleTranscoderJobConfigBlockMuxStreamsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockMuxStreamsBlockSegmentSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segment_settings";

    /// <summary>
    /// Duration of the segments in seconds. The default is &#39;6.0s&#39;.
    /// </summary>
    public TerraformValue<string>? SegmentDuration
    {
        get => GetArgument<TerraformValue<string>>("segment_duration");
        set => SetArgument("segment_duration", value);
    }

}

/// <summary>
/// Block type for output in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

    /// <summary>
    /// URI for the output file(s). For example, gs://my-bucket/outputs/.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for overlays in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOverlaysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overlays";

    /// <summary>
    /// Animations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlock>? Animations
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlock>>("animations");
        set => SetArgument("animations", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockImageBlock>? Image
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

}

/// <summary>
/// Block type for animations in GoogleTranscoderJobConfigBlockOverlaysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "animations";

    /// <summary>
    /// AnimationFade block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AnimationFade block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock>? AnimationFade
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock>>("animation_fade");
        set => SetArgument("animation_fade", value);
    }

}

/// <summary>
/// Block type for animation_fade in GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "animation_fade";

    /// <summary>
    /// The time to end the fade animation, in seconds.
    /// </summary>
    public TerraformValue<string>? EndTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("end_time_offset");
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
        get => GetArgument<TerraformValue<string>>("fade_type");
        set => SetArgument("fade_type", value);
    }

    /// <summary>
    /// The time to start the fade animation, in seconds.
    /// </summary>
    public TerraformValue<string>? StartTimeOffset
    {
        get => GetArgument<TerraformValue<string>>("start_time_offset");
        set => SetArgument("start_time_offset", value);
    }

    /// <summary>
    /// Xy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Xy block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock>? Xy
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock>>("xy");
        set => SetArgument("xy", value);
    }

}

/// <summary>
/// Block type for xy in GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOverlaysBlockAnimationsBlockAnimationFadeBlockXyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xy";

    /// <summary>
    /// Normalized x coordinate.
    /// </summary>
    public TerraformValue<double>? X
    {
        get => GetArgument<TerraformValue<double>>("x");
        set => SetArgument("x", value);
    }

    /// <summary>
    /// Normalized y coordinate.
    /// </summary>
    public TerraformValue<double>? Y
    {
        get => GetArgument<TerraformValue<double>>("y");
        set => SetArgument("y", value);
    }

}

/// <summary>
/// Block type for image in GoogleTranscoderJobConfigBlockOverlaysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockOverlaysBlockImageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for pubsub_destination in GoogleTranscoderJobConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleTranscoderJobConfigBlockPubsubDestinationBlock : TerraformBlock
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
/// Block type for timeouts in GoogleTranscoderJob.
/// Nesting mode: single
/// </summary>
public class GoogleTranscoderJobTimeoutsBlock : TerraformBlock
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
/// Represents a google_transcoder_job Terraform resource.
/// Manages a google_transcoder_job resource.
/// </summary>
public partial class GoogleTranscoderJob(string name) : TerraformResource("google_transcoder_job", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels associated with this job. You can use these to organize and group your jobs.
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
    /// The location of the transcoding job resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Specify the templateId to use for populating Job.config.
    /// The default is preset/web-hd, which is the only supported preset.
    /// </summary>
    public TerraformValue<string>? TemplateId
    {
        get => GetArgument<TerraformValue<string>>("template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The time the job was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The time the transcoding finished.
    /// </summary>
    public TerraformValue<string> EndTime
        => AsReference("end_time");

    /// <summary>
    /// The resource name of the job.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The time the transcoding started.
    /// </summary>
    public TerraformValue<string> StartTime
        => AsReference("start_time");

    /// <summary>
    /// The current state of the job.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    public TerraformList<GoogleTranscoderJobConfigBlock>? Config
    {
        get => GetArgument<TerraformList<GoogleTranscoderJobConfigBlock>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleTranscoderJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleTranscoderJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

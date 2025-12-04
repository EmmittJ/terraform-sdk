using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audio in AwsElastictranscoderPreset.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio";

    /// <summary>
    /// The audio_packing_mode attribute.
    /// </summary>
    public TerraformValue<string>? AudioPackingMode
    {
        get => GetArgument<TerraformValue<string>>("audio_packing_mode");
        set => SetArgument("audio_packing_mode", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformValue<string>? BitRate
    {
        get => GetArgument<TerraformValue<string>>("bit_rate");
        set => SetArgument("bit_rate", value);
    }

    /// <summary>
    /// The channels attribute.
    /// </summary>
    public TerraformValue<string>? Channels
    {
        get => GetArgument<TerraformValue<string>>("channels");
        set => SetArgument("channels", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformValue<string>? Codec
    {
        get => GetArgument<TerraformValue<string>>("codec");
        set => SetArgument("codec", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformValue<string>? SampleRate
    {
        get => GetArgument<TerraformValue<string>>("sample_rate");
        set => SetArgument("sample_rate", value);
    }

}


/// <summary>
/// Block type for audio_codec_options in AwsElastictranscoderPreset.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioCodecOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "audio_codec_options";

    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    public TerraformValue<string>? BitDepth
    {
        get => GetArgument<TerraformValue<string>>("bit_depth");
        set => SetArgument("bit_depth", value);
    }

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    public TerraformValue<string>? BitOrder
    {
        get => GetArgument<TerraformValue<string>>("bit_order");
        set => SetArgument("bit_order", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformValue<string>? Profile
    {
        get => GetArgument<TerraformValue<string>>("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// The signed attribute.
    /// </summary>
    public TerraformValue<string>? Signed
    {
        get => GetArgument<TerraformValue<string>>("signed");
        set => SetArgument("signed", value);
    }

}


/// <summary>
/// Block type for thumbnails in AwsElastictranscoderPreset.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetThumbnailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thumbnails";

    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    public TerraformValue<string>? AspectRatio
    {
        get => GetArgument<TerraformValue<string>>("aspect_ratio");
        set => SetArgument("aspect_ratio", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformValue<string>? Format
    {
        get => GetArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformValue<string>? Interval
    {
        get => GetArgument<TerraformValue<string>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformValue<string>? MaxHeight
    {
        get => GetArgument<TerraformValue<string>>("max_height");
        set => SetArgument("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformValue<string>? MaxWidth
    {
        get => GetArgument<TerraformValue<string>>("max_width");
        set => SetArgument("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformValue<string>? PaddingPolicy
    {
        get => GetArgument<TerraformValue<string>>("padding_policy");
        set => SetArgument("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformValue<string>? Resolution
    {
        get => GetArgument<TerraformValue<string>>("resolution");
        set => SetArgument("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformValue<string>? SizingPolicy
    {
        get => GetArgument<TerraformValue<string>>("sizing_policy");
        set => SetArgument("sizing_policy", value);
    }

}


/// <summary>
/// Block type for video in AwsElastictranscoderPreset.
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetVideoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video";

    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    public TerraformValue<string>? AspectRatio
    {
        get => GetArgument<TerraformValue<string>>("aspect_ratio");
        set => SetArgument("aspect_ratio", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformValue<string>? BitRate
    {
        get => GetArgument<TerraformValue<string>>("bit_rate");
        set => SetArgument("bit_rate", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformValue<string>? Codec
    {
        get => GetArgument<TerraformValue<string>>("codec");
        set => SetArgument("codec", value);
    }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    public TerraformValue<string>? DisplayAspectRatio
    {
        get => GetArgument<TerraformValue<string>>("display_aspect_ratio");
        set => SetArgument("display_aspect_ratio", value);
    }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    public TerraformValue<string>? FixedGop
    {
        get => GetArgument<TerraformValue<string>>("fixed_gop");
        set => SetArgument("fixed_gop", value);
    }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    public TerraformValue<string>? FrameRate
    {
        get => GetArgument<TerraformValue<string>>("frame_rate");
        set => SetArgument("frame_rate", value);
    }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    public TerraformValue<string>? KeyframesMaxDist
    {
        get => GetArgument<TerraformValue<string>>("keyframes_max_dist");
        set => SetArgument("keyframes_max_dist", value);
    }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    public TerraformValue<string>? MaxFrameRate
    {
        get => GetArgument<TerraformValue<string>>("max_frame_rate");
        set => SetArgument("max_frame_rate", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformValue<string>? MaxHeight
    {
        get => GetArgument<TerraformValue<string>>("max_height");
        set => SetArgument("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformValue<string>? MaxWidth
    {
        get => GetArgument<TerraformValue<string>>("max_width");
        set => SetArgument("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformValue<string>? PaddingPolicy
    {
        get => GetArgument<TerraformValue<string>>("padding_policy");
        set => SetArgument("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformValue<string>? Resolution
    {
        get => GetArgument<TerraformValue<string>>("resolution");
        set => SetArgument("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformValue<string>? SizingPolicy
    {
        get => GetArgument<TerraformValue<string>>("sizing_policy");
        set => SetArgument("sizing_policy", value);
    }

}


/// <summary>
/// Block type for video_watermarks in AwsElastictranscoderPreset.
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPresetVideoWatermarksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "video_watermarks";

    /// <summary>
    /// The horizontal_align attribute.
    /// </summary>
    public TerraformValue<string>? HorizontalAlign
    {
        get => GetArgument<TerraformValue<string>>("horizontal_align");
        set => SetArgument("horizontal_align", value);
    }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    public TerraformValue<string>? HorizontalOffset
    {
        get => GetArgument<TerraformValue<string>>("horizontal_offset");
        set => SetArgument("horizontal_offset", value);
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
    /// The max_height attribute.
    /// </summary>
    public TerraformValue<string>? MaxHeight
    {
        get => GetArgument<TerraformValue<string>>("max_height");
        set => SetArgument("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformValue<string>? MaxWidth
    {
        get => GetArgument<TerraformValue<string>>("max_width");
        set => SetArgument("max_width", value);
    }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    public TerraformValue<string>? Opacity
    {
        get => GetArgument<TerraformValue<string>>("opacity");
        set => SetArgument("opacity", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformValue<string>? SizingPolicy
    {
        get => GetArgument<TerraformValue<string>>("sizing_policy");
        set => SetArgument("sizing_policy", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    public TerraformValue<string>? VerticalAlign
    {
        get => GetArgument<TerraformValue<string>>("vertical_align");
        set => SetArgument("vertical_align", value);
    }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    public TerraformValue<string>? VerticalOffset
    {
        get => GetArgument<TerraformValue<string>>("vertical_offset");
        set => SetArgument("vertical_offset", value);
    }

}


/// <summary>
/// Represents a aws_elastictranscoder_preset Terraform resource.
/// Manages a aws_elastictranscoder_preset resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsElastictranscoderPreset(string name) : TerraformResource("aws_elastictranscoder_preset", name)
{
    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformValue<string> Container
    {
        get => GetArgument<TerraformValue<string>>("container");
        set => SetArgument("container", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    public TerraformMap<string>? VideoCodecOptions
    {
        get => GetArgument<TerraformMap<string>>("video_codec_options");
        set => SetArgument("video_codec_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Audio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    public TerraformList<AwsElastictranscoderPresetAudioBlock>? Audio
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPresetAudioBlock>>("audio");
        set => SetArgument("audio", value);
    }

    /// <summary>
    /// AudioCodecOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    public TerraformList<AwsElastictranscoderPresetAudioCodecOptionsBlock>? AudioCodecOptions
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPresetAudioCodecOptionsBlock>>("audio_codec_options");
        set => SetArgument("audio_codec_options", value);
    }

    /// <summary>
    /// Thumbnails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    public TerraformList<AwsElastictranscoderPresetThumbnailsBlock>? Thumbnails
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPresetThumbnailsBlock>>("thumbnails");
        set => SetArgument("thumbnails", value);
    }

    /// <summary>
    /// Video block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    public TerraformList<AwsElastictranscoderPresetVideoBlock>? Video
    {
        get => GetArgument<TerraformList<AwsElastictranscoderPresetVideoBlock>>("video");
        set => SetArgument("video", value);
    }

    /// <summary>
    /// VideoWatermarks block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElastictranscoderPresetVideoWatermarksBlock>? VideoWatermarks
    {
        get => GetArgument<TerraformSet<AwsElastictranscoderPresetVideoWatermarksBlock>>("video_watermarks");
        set => SetArgument("video_watermarks", value);
    }

}

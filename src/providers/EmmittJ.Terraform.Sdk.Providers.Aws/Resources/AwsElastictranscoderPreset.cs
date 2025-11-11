using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audio in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPresetAudioBlock : TerraformBlockBase
{
    /// <summary>
    /// The audio_packing_mode attribute.
    /// </summary>
    [TerraformProperty("audio_packing_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AudioPackingMode { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformProperty("bit_rate")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BitRate { get; set; }

    /// <summary>
    /// The channels attribute.
    /// </summary>
    [TerraformProperty("channels")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Channels { get; set; }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformProperty("codec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Codec { get; set; }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformProperty("sample_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SampleRate { get; set; }

}

/// <summary>
/// Block type for audio_codec_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPresetAudioCodecOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    [TerraformProperty("bit_depth")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BitDepth { get; set; }

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    [TerraformProperty("bit_order")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BitOrder { get; set; }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    [TerraformProperty("profile")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Profile { get; set; }

    /// <summary>
    /// The signed attribute.
    /// </summary>
    [TerraformProperty("signed")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Signed { get; set; }

}

/// <summary>
/// Block type for thumbnails in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPresetThumbnailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformProperty("aspect_ratio")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AspectRatio { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformProperty("format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Format { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformProperty("interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Interval { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformProperty("max_height")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformProperty("max_width")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformProperty("padding_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformProperty("resolution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformProperty("sizing_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPresetVideoBlock : TerraformBlockBase
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformProperty("aspect_ratio")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AspectRatio { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformProperty("bit_rate")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BitRate { get; set; }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformProperty("codec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Codec { get; set; }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    [TerraformProperty("display_aspect_ratio")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayAspectRatio { get; set; }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    [TerraformProperty("fixed_gop")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FixedGop { get; set; }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    [TerraformProperty("frame_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FrameRate { get; set; }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    [TerraformProperty("keyframes_max_dist")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyframesMaxDist { get; set; }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    [TerraformProperty("max_frame_rate")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaxFrameRate { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformProperty("max_height")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformProperty("max_width")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformProperty("padding_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformProperty("resolution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformProperty("sizing_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video_watermarks in .
/// Nesting mode: set
/// </summary>
public partial class AwsElastictranscoderPresetVideoWatermarksBlock : TerraformBlockBase
{
    /// <summary>
    /// The horizontal_align attribute.
    /// </summary>
    [TerraformProperty("horizontal_align")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HorizontalAlign { get; set; }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    [TerraformProperty("horizontal_offset")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HorizontalOffset { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformProperty("max_height")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformProperty("max_width")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    [TerraformProperty("opacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Opacity { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformProperty("sizing_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SizingPolicy { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformProperty("target")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Target { get; set; }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    [TerraformProperty("vertical_align")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VerticalAlign { get; set; }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    [TerraformProperty("vertical_offset")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VerticalOffset { get; set; }

}

/// <summary>
/// Manages a aws_elastictranscoder_preset resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElastictranscoderPreset : TerraformResource
{
    public AwsElastictranscoderPreset(string name) : base("aws_elastictranscoder_preset", name)
    {
    }

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformProperty("container")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Container { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    [TerraformProperty("video_codec_options")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? VideoCodecOptions { get; set; }

    /// <summary>
    /// Block for audio.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    [TerraformProperty("audio")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioBlock>>? Audio { get; set; }

    /// <summary>
    /// Block for audio_codec_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    [TerraformProperty("audio_codec_options")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioCodecOptionsBlock>>? AudioCodecOptions { get; set; }

    /// <summary>
    /// Block for thumbnails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    [TerraformProperty("thumbnails")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetThumbnailsBlock>>? Thumbnails { get; set; }

    /// <summary>
    /// Block for video.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    [TerraformProperty("video")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetVideoBlock>>? Video { get; set; }

    /// <summary>
    /// Block for video_watermarks.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("video_watermarks")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPresetVideoWatermarksBlock>>? VideoWatermarks { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}

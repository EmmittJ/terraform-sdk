using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audio in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioBlock
{
    /// <summary>
    /// The audio_packing_mode attribute.
    /// </summary>
    [TerraformPropertyName("audio_packing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AudioPackingMode { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("bit_rate")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BitRate { get; set; } = default!;

    /// <summary>
    /// The channels attribute.
    /// </summary>
    [TerraformPropertyName("channels")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Channels { get; set; }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformPropertyName("codec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Codec { get; set; }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SampleRate { get; set; }

}

/// <summary>
/// Block type for audio_codec_options in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioCodecOptionsBlock
{
    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    [TerraformPropertyName("bit_depth")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BitDepth { get; set; } = default!;

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    [TerraformPropertyName("bit_order")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BitOrder { get; set; } = default!;

    /// <summary>
    /// The profile attribute.
    /// </summary>
    [TerraformPropertyName("profile")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Profile { get; set; } = default!;

    /// <summary>
    /// The signed attribute.
    /// </summary>
    [TerraformPropertyName("signed")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Signed { get; set; } = default!;

}

/// <summary>
/// Block type for thumbnails in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetThumbnailsBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AspectRatio { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Format { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Interval { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformPropertyName("padding_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformPropertyName("resolution")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetVideoBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AspectRatio { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("bit_rate")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BitRate { get; set; } = default!;

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformPropertyName("codec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Codec { get; set; }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("display_aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayAspectRatio { get; set; }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    [TerraformPropertyName("fixed_gop")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FixedGop { get; set; }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    [TerraformPropertyName("frame_rate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FrameRate { get; set; }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    [TerraformPropertyName("keyframes_max_dist")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyframesMaxDist { get; set; }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    [TerraformPropertyName("max_frame_rate")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxFrameRate { get; set; } = default!;

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformPropertyName("padding_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformPropertyName("resolution")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video_watermarks in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPresetVideoWatermarksBlock
{
    /// <summary>
    /// The horizontal_align attribute.
    /// </summary>
    [TerraformPropertyName("horizontal_align")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HorizontalAlign { get; set; }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    [TerraformPropertyName("horizontal_offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HorizontalOffset { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MaxWidth { get; set; }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    [TerraformPropertyName("opacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Opacity { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SizingPolicy { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformPropertyName("target")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Target { get; set; }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    [TerraformPropertyName("vertical_align")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerticalAlign { get; set; }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    [TerraformPropertyName("vertical_offset")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerticalOffset { get; set; }

}

/// <summary>
/// Manages a aws_elastictranscoder_preset resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElastictranscoderPreset : TerraformResource
{
    public AwsElastictranscoderPreset(string name) : base("aws_elastictranscoder_preset", name)
    {
    }

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [TerraformPropertyName("container")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Container { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    [TerraformPropertyName("video_codec_options")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? VideoCodecOptions { get; set; }

    /// <summary>
    /// Block for audio.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    [TerraformPropertyName("audio")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioBlock>>? Audio { get; set; }

    /// <summary>
    /// Block for audio_codec_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    [TerraformPropertyName("audio_codec_options")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioCodecOptionsBlock>>? AudioCodecOptions { get; set; }

    /// <summary>
    /// Block for thumbnails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    [TerraformPropertyName("thumbnails")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetThumbnailsBlock>>? Thumbnails { get; set; }

    /// <summary>
    /// Block for video.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    [TerraformPropertyName("video")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetVideoBlock>>? Video { get; set; }

    /// <summary>
    /// Block for video_watermarks.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("video_watermarks")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPresetVideoWatermarksBlock>>? VideoWatermarks { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}

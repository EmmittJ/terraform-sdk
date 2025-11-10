using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audio in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioBlock : ITerraformBlock
{
    /// <summary>
    /// The audio_packing_mode attribute.
    /// </summary>
    [TerraformPropertyName("audio_packing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AudioPackingMode { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("bit_rate")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BitRate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bit_rate");

    /// <summary>
    /// The channels attribute.
    /// </summary>
    [TerraformPropertyName("channels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Channels { get; set; }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformPropertyName("codec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Codec { get; set; }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SampleRate { get; set; }

}

/// <summary>
/// Block type for audio_codec_options in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioCodecOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    [TerraformPropertyName("bit_depth")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BitDepth { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bit_depth");

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    [TerraformPropertyName("bit_order")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BitOrder { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bit_order");

    /// <summary>
    /// The profile attribute.
    /// </summary>
    [TerraformPropertyName("profile")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Profile { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "profile");

    /// <summary>
    /// The signed attribute.
    /// </summary>
    [TerraformPropertyName("signed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Signed { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "signed");

}

/// <summary>
/// Block type for thumbnails in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetThumbnailsBlock : ITerraformBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AspectRatio { get; set; }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [TerraformPropertyName("format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Format { get; set; }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    [TerraformPropertyName("interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Interval { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformPropertyName("padding_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformPropertyName("resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetVideoBlock : ITerraformBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AspectRatio { get; set; }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    [TerraformPropertyName("bit_rate")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BitRate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bit_rate");

    /// <summary>
    /// The codec attribute.
    /// </summary>
    [TerraformPropertyName("codec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Codec { get; set; }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    [TerraformPropertyName("display_aspect_ratio")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayAspectRatio { get; set; }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    [TerraformPropertyName("fixed_gop")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FixedGop { get; set; }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    [TerraformPropertyName("frame_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FrameRate { get; set; }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    [TerraformPropertyName("keyframes_max_dist")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyframesMaxDist { get; set; }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    [TerraformPropertyName("max_frame_rate")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxFrameRate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_frame_rate");

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxWidth { get; set; }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    [TerraformPropertyName("padding_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PaddingPolicy { get; set; }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [TerraformPropertyName("resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Resolution { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SizingPolicy { get; set; }

}

/// <summary>
/// Block type for video_watermarks in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPresetVideoWatermarksBlock : ITerraformBlock
{
    /// <summary>
    /// The horizontal_align attribute.
    /// </summary>
    [TerraformPropertyName("horizontal_align")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HorizontalAlign { get; set; }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    [TerraformPropertyName("horizontal_offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HorizontalOffset { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    [TerraformPropertyName("max_height")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxHeight { get; set; }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    [TerraformPropertyName("max_width")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxWidth { get; set; }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    [TerraformPropertyName("opacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Opacity { get; set; }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    [TerraformPropertyName("sizing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SizingPolicy { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [TerraformPropertyName("target")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Target { get; set; }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    [TerraformPropertyName("vertical_align")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VerticalAlign { get; set; }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    [TerraformPropertyName("vertical_offset")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VerticalOffset { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> Container { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    [TerraformPropertyName("video_codec_options")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? VideoCodecOptions { get; set; }

    /// <summary>
    /// Block for audio.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    [TerraformPropertyName("audio")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioBlock>>? Audio { get; set; } = new();

    /// <summary>
    /// Block for audio_codec_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    [TerraformPropertyName("audio_codec_options")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetAudioCodecOptionsBlock>>? AudioCodecOptions { get; set; } = new();

    /// <summary>
    /// Block for thumbnails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    [TerraformPropertyName("thumbnails")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetThumbnailsBlock>>? Thumbnails { get; set; } = new();

    /// <summary>
    /// Block for video.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    [TerraformPropertyName("video")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPresetVideoBlock>>? Video { get; set; } = new();

    /// <summary>
    /// Block for video_watermarks.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("video_watermarks")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPresetVideoWatermarksBlock>>? VideoWatermarks { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}

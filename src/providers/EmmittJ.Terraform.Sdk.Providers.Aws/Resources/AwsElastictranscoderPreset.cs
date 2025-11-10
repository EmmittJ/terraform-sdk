using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for audio in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioBlock : TerraformBlock
{
    /// <summary>
    /// The audio_packing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AudioPackingMode
    {
        get => GetProperty<TerraformProperty<string>>("audio_packing_mode");
        set => WithProperty("audio_packing_mode", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformProperty<string>? BitRate
    {
        get => GetProperty<TerraformProperty<string>>("bit_rate");
        set => WithProperty("bit_rate", value);
    }

    /// <summary>
    /// The channels attribute.
    /// </summary>
    public TerraformProperty<string>? Channels
    {
        get => GetProperty<TerraformProperty<string>>("channels");
        set => WithProperty("channels", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformProperty<string>? Codec
    {
        get => GetProperty<TerraformProperty<string>>("codec");
        set => WithProperty("codec", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformProperty<string>? SampleRate
    {
        get => GetProperty<TerraformProperty<string>>("sample_rate");
        set => WithProperty("sample_rate", value);
    }

}

/// <summary>
/// Block type for audio_codec_options in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetAudioCodecOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The bit_depth attribute.
    /// </summary>
    public TerraformProperty<string>? BitDepth
    {
        get => GetProperty<TerraformProperty<string>>("bit_depth");
        set => WithProperty("bit_depth", value);
    }

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    public TerraformProperty<string>? BitOrder
    {
        get => GetProperty<TerraformProperty<string>>("bit_order");
        set => WithProperty("bit_order", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformProperty<string>? Profile
    {
        get => GetProperty<TerraformProperty<string>>("profile");
        set => WithProperty("profile", value);
    }

    /// <summary>
    /// The signed attribute.
    /// </summary>
    public TerraformProperty<string>? Signed
    {
        get => GetProperty<TerraformProperty<string>>("signed");
        set => WithProperty("signed", value);
    }

}

/// <summary>
/// Block type for thumbnails in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetThumbnailsBlock : TerraformBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    public TerraformProperty<string>? AspectRatio
    {
        get => GetProperty<TerraformProperty<string>>("aspect_ratio");
        set => WithProperty("aspect_ratio", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformProperty<string>? Format
    {
        get => GetProperty<TerraformProperty<string>>("format");
        set => WithProperty("format", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<string>? Interval
    {
        get => GetProperty<TerraformProperty<string>>("interval");
        set => WithProperty("interval", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        get => GetProperty<TerraformProperty<string>>("max_height");
        set => WithProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        get => GetProperty<TerraformProperty<string>>("max_width");
        set => WithProperty("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformProperty<string>? PaddingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("padding_policy");
        set => WithProperty("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformProperty<string>? Resolution
    {
        get => GetProperty<TerraformProperty<string>>("resolution");
        set => WithProperty("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("sizing_policy");
        set => WithProperty("sizing_policy", value);
    }

}

/// <summary>
/// Block type for video in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPresetVideoBlock : TerraformBlock
{
    /// <summary>
    /// The aspect_ratio attribute.
    /// </summary>
    public TerraformProperty<string>? AspectRatio
    {
        get => GetProperty<TerraformProperty<string>>("aspect_ratio");
        set => WithProperty("aspect_ratio", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformProperty<string>? BitRate
    {
        get => GetProperty<TerraformProperty<string>>("bit_rate");
        set => WithProperty("bit_rate", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformProperty<string>? Codec
    {
        get => GetProperty<TerraformProperty<string>>("codec");
        set => WithProperty("codec", value);
    }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayAspectRatio
    {
        get => GetProperty<TerraformProperty<string>>("display_aspect_ratio");
        set => WithProperty("display_aspect_ratio", value);
    }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    public TerraformProperty<string>? FixedGop
    {
        get => GetProperty<TerraformProperty<string>>("fixed_gop");
        set => WithProperty("fixed_gop", value);
    }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    public TerraformProperty<string>? FrameRate
    {
        get => GetProperty<TerraformProperty<string>>("frame_rate");
        set => WithProperty("frame_rate", value);
    }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    public TerraformProperty<string>? KeyframesMaxDist
    {
        get => GetProperty<TerraformProperty<string>>("keyframes_max_dist");
        set => WithProperty("keyframes_max_dist", value);
    }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    public TerraformProperty<string>? MaxFrameRate
    {
        get => GetProperty<TerraformProperty<string>>("max_frame_rate");
        set => WithProperty("max_frame_rate", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        get => GetProperty<TerraformProperty<string>>("max_height");
        set => WithProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        get => GetProperty<TerraformProperty<string>>("max_width");
        set => WithProperty("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformProperty<string>? PaddingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("padding_policy");
        set => WithProperty("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformProperty<string>? Resolution
    {
        get => GetProperty<TerraformProperty<string>>("resolution");
        set => WithProperty("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("sizing_policy");
        set => WithProperty("sizing_policy", value);
    }

}

/// <summary>
/// Block type for video_watermarks in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPresetVideoWatermarksBlock : TerraformBlock
{
    /// <summary>
    /// The horizontal_align attribute.
    /// </summary>
    public TerraformProperty<string>? HorizontalAlign
    {
        get => GetProperty<TerraformProperty<string>>("horizontal_align");
        set => WithProperty("horizontal_align", value);
    }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    public TerraformProperty<string>? HorizontalOffset
    {
        get => GetProperty<TerraformProperty<string>>("horizontal_offset");
        set => WithProperty("horizontal_offset", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        get => GetProperty<TerraformProperty<string>>("max_height");
        set => WithProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        get => GetProperty<TerraformProperty<string>>("max_width");
        set => WithProperty("max_width", value);
    }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    public TerraformProperty<string>? Opacity
    {
        get => GetProperty<TerraformProperty<string>>("opacity");
        set => WithProperty("opacity", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("sizing_policy");
        set => WithProperty("sizing_policy", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    public TerraformProperty<string>? VerticalAlign
    {
        get => GetProperty<TerraformProperty<string>>("vertical_align");
        set => WithProperty("vertical_align", value);
    }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    public TerraformProperty<string>? VerticalOffset
    {
        get => GetProperty<TerraformProperty<string>>("vertical_offset");
        set => WithProperty("vertical_offset", value);
    }

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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformProperty<string> Container
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container");
        set => this.WithProperty("container", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? VideoCodecOptions
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("video_codec_options");
        set => this.WithProperty("video_codec_options", value);
    }

    /// <summary>
    /// Block for audio.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    public List<AwsElastictranscoderPresetAudioBlock>? Audio
    {
        get => GetProperty<List<AwsElastictranscoderPresetAudioBlock>>("audio");
        set => this.WithProperty("audio", value);
    }

    /// <summary>
    /// Block for audio_codec_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    public List<AwsElastictranscoderPresetAudioCodecOptionsBlock>? AudioCodecOptions
    {
        get => GetProperty<List<AwsElastictranscoderPresetAudioCodecOptionsBlock>>("audio_codec_options");
        set => this.WithProperty("audio_codec_options", value);
    }

    /// <summary>
    /// Block for thumbnails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    public List<AwsElastictranscoderPresetThumbnailsBlock>? Thumbnails
    {
        get => GetProperty<List<AwsElastictranscoderPresetThumbnailsBlock>>("thumbnails");
        set => this.WithProperty("thumbnails", value);
    }

    /// <summary>
    /// Block for video.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    public List<AwsElastictranscoderPresetVideoBlock>? Video
    {
        get => GetProperty<List<AwsElastictranscoderPresetVideoBlock>>("video");
        set => this.WithProperty("video", value);
    }

    /// <summary>
    /// Block for video_watermarks.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPresetVideoWatermarksBlock>? VideoWatermarks
    {
        get => GetProperty<HashSet<AwsElastictranscoderPresetVideoWatermarksBlock>>("video_watermarks");
        set => this.WithProperty("video_watermarks", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

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
        set => SetProperty("audio_packing_mode", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformProperty<string>? BitRate
    {
        set => SetProperty("bit_rate", value);
    }

    /// <summary>
    /// The channels attribute.
    /// </summary>
    public TerraformProperty<string>? Channels
    {
        set => SetProperty("channels", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformProperty<string>? Codec
    {
        set => SetProperty("codec", value);
    }

    /// <summary>
    /// The sample_rate attribute.
    /// </summary>
    public TerraformProperty<string>? SampleRate
    {
        set => SetProperty("sample_rate", value);
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
        set => SetProperty("bit_depth", value);
    }

    /// <summary>
    /// The bit_order attribute.
    /// </summary>
    public TerraformProperty<string>? BitOrder
    {
        set => SetProperty("bit_order", value);
    }

    /// <summary>
    /// The profile attribute.
    /// </summary>
    public TerraformProperty<string>? Profile
    {
        set => SetProperty("profile", value);
    }

    /// <summary>
    /// The signed attribute.
    /// </summary>
    public TerraformProperty<string>? Signed
    {
        set => SetProperty("signed", value);
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
        set => SetProperty("aspect_ratio", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformProperty<string>? Format
    {
        set => SetProperty("format", value);
    }

    /// <summary>
    /// The interval attribute.
    /// </summary>
    public TerraformProperty<string>? Interval
    {
        set => SetProperty("interval", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        set => SetProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        set => SetProperty("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformProperty<string>? PaddingPolicy
    {
        set => SetProperty("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformProperty<string>? Resolution
    {
        set => SetProperty("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        set => SetProperty("sizing_policy", value);
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
        set => SetProperty("aspect_ratio", value);
    }

    /// <summary>
    /// The bit_rate attribute.
    /// </summary>
    public TerraformProperty<string>? BitRate
    {
        set => SetProperty("bit_rate", value);
    }

    /// <summary>
    /// The codec attribute.
    /// </summary>
    public TerraformProperty<string>? Codec
    {
        set => SetProperty("codec", value);
    }

    /// <summary>
    /// The display_aspect_ratio attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayAspectRatio
    {
        set => SetProperty("display_aspect_ratio", value);
    }

    /// <summary>
    /// The fixed_gop attribute.
    /// </summary>
    public TerraformProperty<string>? FixedGop
    {
        set => SetProperty("fixed_gop", value);
    }

    /// <summary>
    /// The frame_rate attribute.
    /// </summary>
    public TerraformProperty<string>? FrameRate
    {
        set => SetProperty("frame_rate", value);
    }

    /// <summary>
    /// The keyframes_max_dist attribute.
    /// </summary>
    public TerraformProperty<string>? KeyframesMaxDist
    {
        set => SetProperty("keyframes_max_dist", value);
    }

    /// <summary>
    /// The max_frame_rate attribute.
    /// </summary>
    public TerraformProperty<string>? MaxFrameRate
    {
        set => SetProperty("max_frame_rate", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        set => SetProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        set => SetProperty("max_width", value);
    }

    /// <summary>
    /// The padding_policy attribute.
    /// </summary>
    public TerraformProperty<string>? PaddingPolicy
    {
        set => SetProperty("padding_policy", value);
    }

    /// <summary>
    /// The resolution attribute.
    /// </summary>
    public TerraformProperty<string>? Resolution
    {
        set => SetProperty("resolution", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        set => SetProperty("sizing_policy", value);
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
        set => SetProperty("horizontal_align", value);
    }

    /// <summary>
    /// The horizontal_offset attribute.
    /// </summary>
    public TerraformProperty<string>? HorizontalOffset
    {
        set => SetProperty("horizontal_offset", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_height attribute.
    /// </summary>
    public TerraformProperty<string>? MaxHeight
    {
        set => SetProperty("max_height", value);
    }

    /// <summary>
    /// The max_width attribute.
    /// </summary>
    public TerraformProperty<string>? MaxWidth
    {
        set => SetProperty("max_width", value);
    }

    /// <summary>
    /// The opacity attribute.
    /// </summary>
    public TerraformProperty<string>? Opacity
    {
        set => SetProperty("opacity", value);
    }

    /// <summary>
    /// The sizing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? SizingPolicy
    {
        set => SetProperty("sizing_policy", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    public TerraformProperty<string>? Target
    {
        set => SetProperty("target", value);
    }

    /// <summary>
    /// The vertical_align attribute.
    /// </summary>
    public TerraformProperty<string>? VerticalAlign
    {
        set => SetProperty("vertical_align", value);
    }

    /// <summary>
    /// The vertical_offset attribute.
    /// </summary>
    public TerraformProperty<string>? VerticalOffset
    {
        set => SetProperty("vertical_offset", value);
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
        SetOutput("arn");
        SetOutput("container");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("type");
        SetOutput("video_codec_options");
    }

    /// <summary>
    /// The container attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformProperty<string> Container
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container");
        set => SetProperty("container", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The video_codec_options attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> VideoCodecOptions
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("video_codec_options");
        set => SetProperty("video_codec_options", value);
    }

    /// <summary>
    /// Block for audio.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Audio block(s) allowed")]
    public List<AwsElastictranscoderPresetAudioBlock>? Audio
    {
        set => SetProperty("audio", value);
    }

    /// <summary>
    /// Block for audio_codec_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AudioCodecOptions block(s) allowed")]
    public List<AwsElastictranscoderPresetAudioCodecOptionsBlock>? AudioCodecOptions
    {
        set => SetProperty("audio_codec_options", value);
    }

    /// <summary>
    /// Block for thumbnails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Thumbnails block(s) allowed")]
    public List<AwsElastictranscoderPresetThumbnailsBlock>? Thumbnails
    {
        set => SetProperty("thumbnails", value);
    }

    /// <summary>
    /// Block for video.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Video block(s) allowed")]
    public List<AwsElastictranscoderPresetVideoBlock>? Video
    {
        set => SetProperty("video", value);
    }

    /// <summary>
    /// Block for video_watermarks.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPresetVideoWatermarksBlock>? VideoWatermarks
    {
        set => SetProperty("video_watermarks", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

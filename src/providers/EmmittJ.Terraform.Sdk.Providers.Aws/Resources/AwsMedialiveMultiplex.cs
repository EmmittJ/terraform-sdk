using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexMultiplexSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_video_buffer_delay_milliseconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumVideoBufferDelayMilliseconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_video_buffer_delay_milliseconds");
        set => WithProperty("maximum_video_buffer_delay_milliseconds", value);
    }

    /// <summary>
    /// The transport_stream_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamBitrate is required")]
    public required TerraformProperty<double> TransportStreamBitrate
    {
        get => GetRequiredProperty<TerraformProperty<double>>("transport_stream_bitrate");
        set => WithProperty("transport_stream_bitrate", value);
    }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamId is required")]
    public required TerraformProperty<double> TransportStreamId
    {
        get => GetRequiredProperty<TerraformProperty<double>>("transport_stream_id");
        set => WithProperty("transport_stream_id", value);
    }

    /// <summary>
    /// The transport_stream_reserved_bitrate attribute.
    /// </summary>
    public TerraformProperty<double>? TransportStreamReservedBitrate
    {
        get => GetProperty<TerraformProperty<double>>("transport_stream_reserved_bitrate");
        set => WithProperty("transport_stream_reserved_bitrate", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveMultiplexTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_medialive_multiplex resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMedialiveMultiplex : TerraformResource
{
    public AwsMedialiveMultiplex(string name) : base("aws_medialive_multiplex", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZones is required")]
    public List<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<List<TerraformProperty<string>>>("availability_zones");
        set => this.WithProperty("availability_zones", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The start_multiplex attribute.
    /// </summary>
    public TerraformProperty<bool>? StartMultiplex
    {
        get => GetProperty<TerraformProperty<bool>>("start_multiplex");
        set => this.WithProperty("start_multiplex", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for multiplex_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexSettings block(s) allowed")]
    public List<AwsMedialiveMultiplexMultiplexSettingsBlock>? MultiplexSettings
    {
        get => GetProperty<List<AwsMedialiveMultiplexMultiplexSettingsBlock>>("multiplex_settings");
        set => this.WithProperty("multiplex_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveMultiplexTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMedialiveMultiplexTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

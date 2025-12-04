using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_settings in AwsMedialiveMultiplex.
/// Nesting mode: list
/// </summary>
public class AwsMedialiveMultiplexMultiplexSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multiplex_settings";

    /// <summary>
    /// The maximum_video_buffer_delay_milliseconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumVideoBufferDelayMilliseconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_video_buffer_delay_milliseconds") ?? AsReference("maximum_video_buffer_delay_milliseconds");
        set => SetArgument("maximum_video_buffer_delay_milliseconds", value);
    }

    /// <summary>
    /// The transport_stream_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamBitrate is required")]
    public required TerraformValue<double> TransportStreamBitrate
    {
        get => GetRequiredArgument<TerraformValue<double>>("transport_stream_bitrate");
        set => SetArgument("transport_stream_bitrate", value);
    }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamId is required")]
    public required TerraformValue<double> TransportStreamId
    {
        get => GetRequiredArgument<TerraformValue<double>>("transport_stream_id");
        set => SetArgument("transport_stream_id", value);
    }

    /// <summary>
    /// The transport_stream_reserved_bitrate attribute.
    /// </summary>
    public TerraformValue<double> TransportStreamReservedBitrate
    {
        get => GetArgument<TerraformValue<double>>("transport_stream_reserved_bitrate") ?? AsReference("transport_stream_reserved_bitrate");
        set => SetArgument("transport_stream_reserved_bitrate", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMedialiveMultiplex.
/// Nesting mode: single
/// </summary>
public class AwsMedialiveMultiplexTimeoutsBlock : TerraformBlock
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
/// Represents a aws_medialive_multiplex Terraform resource.
/// Manages a aws_medialive_multiplex resource.
/// </summary>
public partial class AwsMedialiveMultiplex(string name) : TerraformResource("aws_medialive_multiplex", name)
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZones is required")]
    public TerraformList<string>? AvailabilityZones
    {
        get => GetArgument<TerraformList<string>>("availability_zones");
        set => SetArgument("availability_zones", value);
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
    /// The start_multiplex attribute.
    /// </summary>
    public TerraformValue<bool>? StartMultiplex
    {
        get => GetArgument<TerraformValue<bool>>("start_multiplex");
        set => SetArgument("start_multiplex", value);
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
    /// MultiplexSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexSettings block(s) allowed")]
    public TerraformList<AwsMedialiveMultiplexMultiplexSettingsBlock>? MultiplexSettings
    {
        get => GetArgument<TerraformList<AwsMedialiveMultiplexMultiplexSettingsBlock>>("multiplex_settings");
        set => SetArgument("multiplex_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMedialiveMultiplexTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMedialiveMultiplexTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

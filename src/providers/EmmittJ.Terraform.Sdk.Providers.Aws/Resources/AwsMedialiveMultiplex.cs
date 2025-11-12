using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for multiplex_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveMultiplexMultiplexSettingsBlock() : TerraformBlock("multiplex_settings")
{
    /// <summary>
    /// The maximum_video_buffer_delay_milliseconds attribute.
    /// </summary>
    [TerraformProperty("maximum_video_buffer_delay_milliseconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaximumVideoBufferDelayMilliseconds { get; set; }

    /// <summary>
    /// The transport_stream_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamBitrate is required")]
    [TerraformProperty("transport_stream_bitrate")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TransportStreamBitrate { get; set; }

    /// <summary>
    /// The transport_stream_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportStreamId is required")]
    [TerraformProperty("transport_stream_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TransportStreamId { get; set; }

    /// <summary>
    /// The transport_stream_reserved_bitrate attribute.
    /// </summary>
    [TerraformProperty("transport_stream_reserved_bitrate")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TransportStreamReservedBitrate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMedialiveMultiplexTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_medialive_multiplex resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMedialiveMultiplex : TerraformResource
{
    public AwsMedialiveMultiplex(string name) : base("aws_medialive_multiplex", name)
    {
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZones is required")]
    [TerraformProperty("availability_zones")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AvailabilityZones { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The start_multiplex attribute.
    /// </summary>
    [TerraformProperty("start_multiplex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartMultiplex { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for multiplex_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiplexSettings block(s) allowed")]
    [TerraformProperty("multiplex_settings")]
    public TerraformList<AwsMedialiveMultiplexMultiplexSettingsBlock> MultiplexSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMedialiveMultiplexTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}

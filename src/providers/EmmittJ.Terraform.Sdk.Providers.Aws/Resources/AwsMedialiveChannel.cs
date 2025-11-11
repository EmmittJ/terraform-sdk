using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cdi_input_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveChannelCdiInputSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resolution is required")]
    [TerraformProperty("resolution")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Resolution { get; set; }

}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveChannelDestinationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

}

/// <summary>
/// Block type for encoder_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveChannelEncoderSettingsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for input_attachments in .
/// Nesting mode: set
/// </summary>
public partial class AwsMedialiveChannelInputAttachmentsBlock : TerraformBlockBase
{
    /// <summary>
    /// The input_attachment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachmentName is required")]
    [TerraformProperty("input_attachment_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputAttachmentName { get; set; }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputId is required")]
    [TerraformProperty("input_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputId { get; set; }

}

/// <summary>
/// Block type for input_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveChannelInputSpecificationBlock : TerraformBlockBase
{
    /// <summary>
    /// The codec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Codec is required")]
    [TerraformProperty("codec")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Codec { get; set; }

    /// <summary>
    /// The input_resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputResolution is required")]
    [TerraformProperty("input_resolution")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputResolution { get; set; }

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBitrate is required")]
    [TerraformProperty("maximum_bitrate")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaximumBitrate { get; set; }

}

/// <summary>
/// Block type for maintenance in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveChannelMaintenanceBlock : TerraformBlockBase
{
    /// <summary>
    /// The maintenance_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceDay is required")]
    [TerraformProperty("maintenance_day")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaintenanceDay { get; set; }

    /// <summary>
    /// The maintenance_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceStartTime is required")]
    [TerraformProperty("maintenance_start_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaintenanceStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMedialiveChannelTimeoutsBlock : TerraformBlockBase
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
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public partial class AwsMedialiveChannelVpcBlock : TerraformBlockBase
{


    /// <summary>
    /// The public_address_allocation_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicAddressAllocationIds is required")]
    [TerraformProperty("public_address_allocation_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_medialive_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMedialiveChannel : TerraformResource
{
    public AwsMedialiveChannel(string name) : base("aws_medialive_channel", name)
    {
    }

    /// <summary>
    /// The channel_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelClass is required")]
    [TerraformProperty("channel_class")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ChannelClass { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformProperty("log_level")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogLevel { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The start_channel attribute.
    /// </summary>
    [TerraformProperty("start_channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartChannel { get; set; }

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
    /// Block for cdi_input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdiInputSpecification block(s) allowed")]
    [TerraformProperty("cdi_input_specification")]
    public partial TerraformList<TerraformBlock<AwsMedialiveChannelCdiInputSpecificationBlock>>? CdiInputSpecification { get; set; }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [TerraformProperty("destinations")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveChannelDestinationsBlock>>? Destinations { get; set; }

    /// <summary>
    /// Block for encoder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncoderSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncoderSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncoderSettings block(s) allowed")]
    [TerraformProperty("encoder_settings")]
    public partial TerraformList<TerraformBlock<AwsMedialiveChannelEncoderSettingsBlock>>? EncoderSettings { get; set; }

    /// <summary>
    /// Block for input_attachments.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputAttachments block(s) required")]
    [TerraformProperty("input_attachments")]
    public partial TerraformSet<TerraformBlock<AwsMedialiveChannelInputAttachmentsBlock>>? InputAttachments { get; set; }

    /// <summary>
    /// Block for input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSpecification block(s) allowed")]
    [TerraformProperty("input_specification")]
    public partial TerraformList<TerraformBlock<AwsMedialiveChannelInputSpecificationBlock>>? InputSpecification { get; set; }

    /// <summary>
    /// Block for maintenance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Maintenance block(s) allowed")]
    [TerraformProperty("maintenance")]
    public partial TerraformList<TerraformBlock<AwsMedialiveChannelMaintenanceBlock>>? Maintenance { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsMedialiveChannelTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    [TerraformProperty("vpc")]
    public partial TerraformList<TerraformBlock<AwsMedialiveChannelVpcBlock>>? Vpc { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    [TerraformProperty("channel_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ChannelId { get; }

}

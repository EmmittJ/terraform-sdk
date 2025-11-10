using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cdi_input_specification in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelCdiInputSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resolution is required")]
    [TerraformPropertyName("resolution")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Resolution { get; set; }

}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelDestinationsBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

}

/// <summary>
/// Block type for encoder_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for input_attachments in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlock : ITerraformBlock
{
    /// <summary>
    /// The input_attachment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachmentName is required")]
    [TerraformPropertyName("input_attachment_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputAttachmentName { get; set; }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputId is required")]
    [TerraformPropertyName("input_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputId { get; set; }

}

/// <summary>
/// Block type for input_specification in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputSpecificationBlock : ITerraformBlock
{
    /// <summary>
    /// The codec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Codec is required")]
    [TerraformPropertyName("codec")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Codec { get; set; }

    /// <summary>
    /// The input_resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputResolution is required")]
    [TerraformPropertyName("input_resolution")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputResolution { get; set; }

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBitrate is required")]
    [TerraformPropertyName("maximum_bitrate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MaximumBitrate { get; set; }

}

/// <summary>
/// Block type for maintenance in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelMaintenanceBlock : ITerraformBlock
{
    /// <summary>
    /// The maintenance_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceDay is required")]
    [TerraformPropertyName("maintenance_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MaintenanceDay { get; set; }

    /// <summary>
    /// The maintenance_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceStartTime is required")]
    [TerraformPropertyName("maintenance_start_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MaintenanceStartTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveChannelTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelVpcBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "availability_zones");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    [TerraformPropertyName("network_interface_ids")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NetworkInterfaceIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "network_interface_ids");

    /// <summary>
    /// The public_address_allocation_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicAddressAllocationIds is required")]
    [TerraformPropertyName("public_address_allocation_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PublicAddressAllocationIds { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

}

/// <summary>
/// Manages a aws_medialive_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMedialiveChannel : TerraformResource
{
    public AwsMedialiveChannel(string name) : base("aws_medialive_channel", name)
    {
    }

    /// <summary>
    /// The channel_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelClass is required")]
    [TerraformPropertyName("channel_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ChannelClass { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [TerraformPropertyName("log_level")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogLevel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "log_level");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

    /// <summary>
    /// The start_channel attribute.
    /// </summary>
    [TerraformPropertyName("start_channel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StartChannel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for cdi_input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdiInputSpecification block(s) allowed")]
    [TerraformPropertyName("cdi_input_specification")]
    public TerraformList<TerraformBlock<AwsMedialiveChannelCdiInputSpecificationBlock>>? CdiInputSpecification { get; set; } = new();

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    [TerraformPropertyName("destinations")]
    public TerraformSet<TerraformBlock<AwsMedialiveChannelDestinationsBlock>>? Destinations { get; set; } = new();

    /// <summary>
    /// Block for encoder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncoderSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncoderSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncoderSettings block(s) allowed")]
    [TerraformPropertyName("encoder_settings")]
    public TerraformList<TerraformBlock<AwsMedialiveChannelEncoderSettingsBlock>>? EncoderSettings { get; set; } = new();

    /// <summary>
    /// Block for input_attachments.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputAttachments block(s) required")]
    [TerraformPropertyName("input_attachments")]
    public TerraformSet<TerraformBlock<AwsMedialiveChannelInputAttachmentsBlock>>? InputAttachments { get; set; } = new();

    /// <summary>
    /// Block for input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSpecification block(s) allowed")]
    [TerraformPropertyName("input_specification")]
    public TerraformList<TerraformBlock<AwsMedialiveChannelInputSpecificationBlock>>? InputSpecification { get; set; } = new();

    /// <summary>
    /// Block for maintenance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Maintenance block(s) allowed")]
    [TerraformPropertyName("maintenance")]
    public TerraformList<TerraformBlock<AwsMedialiveChannelMaintenanceBlock>>? Maintenance { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMedialiveChannelTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    [TerraformPropertyName("vpc")]
    public TerraformList<TerraformBlock<AwsMedialiveChannelVpcBlock>>? Vpc { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    [TerraformPropertyName("channel_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChannelId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "channel_id");

}

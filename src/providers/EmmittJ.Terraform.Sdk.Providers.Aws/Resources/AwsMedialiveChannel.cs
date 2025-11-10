using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cdi_input_specification in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelCdiInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resolution is required")]
    public required TerraformProperty<string> Resolution
    {
        set => SetProperty("resolution", value);
    }

}

/// <summary>
/// Block type for destinations in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelDestinationsBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

}

/// <summary>
/// Block type for encoder_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelEncoderSettingsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for input_attachments in .
/// Nesting mode: set
/// </summary>
public class AwsMedialiveChannelInputAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// The input_attachment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachmentName is required")]
    public required TerraformProperty<string> InputAttachmentName
    {
        set => SetProperty("input_attachment_name", value);
    }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputId is required")]
    public required TerraformProperty<string> InputId
    {
        set => SetProperty("input_id", value);
    }

}

/// <summary>
/// Block type for input_specification in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelInputSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The codec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Codec is required")]
    public required TerraformProperty<string> Codec
    {
        set => SetProperty("codec", value);
    }

    /// <summary>
    /// The input_resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputResolution is required")]
    public required TerraformProperty<string> InputResolution
    {
        set => SetProperty("input_resolution", value);
    }

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBitrate is required")]
    public required TerraformProperty<string> MaximumBitrate
    {
        set => SetProperty("maximum_bitrate", value);
    }

}

/// <summary>
/// Block type for maintenance in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelMaintenanceBlock : TerraformBlock
{
    /// <summary>
    /// The maintenance_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceDay is required")]
    public required TerraformProperty<string> MaintenanceDay
    {
        set => SetProperty("maintenance_day", value);
    }

    /// <summary>
    /// The maintenance_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceStartTime is required")]
    public required TerraformProperty<string> MaintenanceStartTime
    {
        set => SetProperty("maintenance_start_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMedialiveChannelTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc in .
/// Nesting mode: list
/// </summary>
public class AwsMedialiveChannelVpcBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NetworkInterfaceIds
    {
        set => SetProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The public_address_allocation_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicAddressAllocationIds is required")]
    public List<TerraformProperty<string>>? PublicAddressAllocationIds
    {
        set => SetProperty("public_address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_medialive_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMedialiveChannel : TerraformResource
{
    public AwsMedialiveChannel(string name) : base("aws_medialive_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("channel_id");
        SetOutput("channel_class");
        SetOutput("id");
        SetOutput("log_level");
        SetOutput("name");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("start_channel");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The channel_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelClass is required")]
    public required TerraformProperty<string> ChannelClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("channel_class");
        set => SetProperty("channel_class", value);
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
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string> LogLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_level");
        set => SetProperty("log_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The start_channel attribute.
    /// </summary>
    public TerraformProperty<bool> StartChannel
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_channel");
        set => SetProperty("start_channel", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cdi_input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdiInputSpecification block(s) allowed")]
    public List<AwsMedialiveChannelCdiInputSpecificationBlock>? CdiInputSpecification
    {
        set => SetProperty("cdi_input_specification", value);
    }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    public HashSet<AwsMedialiveChannelDestinationsBlock>? Destinations
    {
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// Block for encoder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncoderSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncoderSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncoderSettings block(s) allowed")]
    public List<AwsMedialiveChannelEncoderSettingsBlock>? EncoderSettings
    {
        set => SetProperty("encoder_settings", value);
    }

    /// <summary>
    /// Block for input_attachments.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputAttachments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputAttachments block(s) required")]
    public HashSet<AwsMedialiveChannelInputAttachmentsBlock>? InputAttachments
    {
        set => SetProperty("input_attachments", value);
    }

    /// <summary>
    /// Block for input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSpecification block(s) allowed")]
    public List<AwsMedialiveChannelInputSpecificationBlock>? InputSpecification
    {
        set => SetProperty("input_specification", value);
    }

    /// <summary>
    /// Block for maintenance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Maintenance block(s) allowed")]
    public List<AwsMedialiveChannelMaintenanceBlock>? Maintenance
    {
        set => SetProperty("maintenance", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveChannelTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public List<AwsMedialiveChannelVpcBlock>? Vpc
    {
        set => SetProperty("vpc", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The channel_id attribute.
    /// </summary>
    public TerraformExpression ChannelId => this["channel_id"];

}

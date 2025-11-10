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
        get => GetProperty<TerraformProperty<string>>("resolution");
        set => WithProperty("resolution", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
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
        get => GetProperty<TerraformProperty<string>>("input_attachment_name");
        set => WithProperty("input_attachment_name", value);
    }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputId is required")]
    public required TerraformProperty<string> InputId
    {
        get => GetProperty<TerraformProperty<string>>("input_id");
        set => WithProperty("input_id", value);
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
        get => GetProperty<TerraformProperty<string>>("codec");
        set => WithProperty("codec", value);
    }

    /// <summary>
    /// The input_resolution attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputResolution is required")]
    public required TerraformProperty<string> InputResolution
    {
        get => GetProperty<TerraformProperty<string>>("input_resolution");
        set => WithProperty("input_resolution", value);
    }

    /// <summary>
    /// The maximum_bitrate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumBitrate is required")]
    public required TerraformProperty<string> MaximumBitrate
    {
        get => GetProperty<TerraformProperty<string>>("maximum_bitrate");
        set => WithProperty("maximum_bitrate", value);
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
        get => GetProperty<TerraformProperty<string>>("maintenance_day");
        set => WithProperty("maintenance_day", value);
    }

    /// <summary>
    /// The maintenance_start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaintenanceStartTime is required")]
    public required TerraformProperty<string> MaintenanceStartTime
    {
        get => GetProperty<TerraformProperty<string>>("maintenance_start_time");
        set => WithProperty("maintenance_start_time", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => WithProperty("availability_zones", value);
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NetworkInterfaceIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("network_interface_ids");
        set => WithProperty("network_interface_ids", value);
    }

    /// <summary>
    /// The public_address_allocation_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicAddressAllocationIds is required")]
    public List<TerraformProperty<string>>? PublicAddressAllocationIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_address_allocation_ids");
        set => WithProperty("public_address_allocation_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

/// <summary>
/// Manages a aws_medialive_channel resource.
/// </summary>
public class AwsMedialiveChannel : TerraformResource
{
    public AwsMedialiveChannel(string name) : base("aws_medialive_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("channel_id");
    }

    /// <summary>
    /// The channel_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelClass is required")]
    public required TerraformProperty<string> ChannelClass
    {
        get => GetProperty<TerraformProperty<string>>("channel_class");
        set => this.WithProperty("channel_class", value);
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
    /// The log_level attribute.
    /// </summary>
    public TerraformProperty<string>? LogLevel
    {
        get => GetProperty<TerraformProperty<string>>("log_level");
        set => this.WithProperty("log_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The start_channel attribute.
    /// </summary>
    public TerraformProperty<bool>? StartChannel
    {
        get => GetProperty<TerraformProperty<bool>>("start_channel");
        set => this.WithProperty("start_channel", value);
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
    /// Block for cdi_input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdiInputSpecification block(s) allowed")]
    public List<AwsMedialiveChannelCdiInputSpecificationBlock>? CdiInputSpecification
    {
        get => GetProperty<List<AwsMedialiveChannelCdiInputSpecificationBlock>>("cdi_input_specification");
        set => this.WithProperty("cdi_input_specification", value);
    }

    /// <summary>
    /// Block for destinations.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destinations block(s) required")]
    public HashSet<AwsMedialiveChannelDestinationsBlock>? Destinations
    {
        get => GetProperty<HashSet<AwsMedialiveChannelDestinationsBlock>>("destinations");
        set => this.WithProperty("destinations", value);
    }

    /// <summary>
    /// Block for encoder_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncoderSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncoderSettings block(s) allowed")]
    public List<AwsMedialiveChannelEncoderSettingsBlock>? EncoderSettings
    {
        get => GetProperty<List<AwsMedialiveChannelEncoderSettingsBlock>>("encoder_settings");
        set => this.WithProperty("encoder_settings", value);
    }

    /// <summary>
    /// Block for input_attachments.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputAttachments block(s) required")]
    public HashSet<AwsMedialiveChannelInputAttachmentsBlock>? InputAttachments
    {
        get => GetProperty<HashSet<AwsMedialiveChannelInputAttachmentsBlock>>("input_attachments");
        set => this.WithProperty("input_attachments", value);
    }

    /// <summary>
    /// Block for input_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSpecification block(s) allowed")]
    public List<AwsMedialiveChannelInputSpecificationBlock>? InputSpecification
    {
        get => GetProperty<List<AwsMedialiveChannelInputSpecificationBlock>>("input_specification");
        set => this.WithProperty("input_specification", value);
    }

    /// <summary>
    /// Block for maintenance.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Maintenance block(s) allowed")]
    public List<AwsMedialiveChannelMaintenanceBlock>? Maintenance
    {
        get => GetProperty<List<AwsMedialiveChannelMaintenanceBlock>>("maintenance");
        set => this.WithProperty("maintenance", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMedialiveChannelTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMedialiveChannelTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public List<AwsMedialiveChannelVpcBlock>? Vpc
    {
        get => GetProperty<List<AwsMedialiveChannelVpcBlock>>("vpc");
        set => this.WithProperty("vpc", value);
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

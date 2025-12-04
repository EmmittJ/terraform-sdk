using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVolumeAttachment.
/// Nesting mode: single
/// </summary>
public class AwsVolumeAttachmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_volume_attachment Terraform resource.
/// Manages a aws_volume_attachment resource.
/// </summary>
public partial class AwsVolumeAttachment(string name) : TerraformResource("aws_volume_attachment", name)
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The force_detach attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDetach
    {
        get => GetArgument<TerraformValue<bool>>("force_detach");
        set => SetArgument("force_detach", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => GetArgument<TerraformValue<bool>>("skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The stop_instance_before_detaching attribute.
    /// </summary>
    public TerraformValue<bool>? StopInstanceBeforeDetaching
    {
        get => GetArgument<TerraformValue<bool>>("stop_instance_before_detaching");
        set => SetArgument("stop_instance_before_detaching", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformValue<string> VolumeId
    {
        get => GetArgument<TerraformValue<string>>("volume_id");
        set => SetArgument("volume_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVolumeAttachmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVolumeAttachmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

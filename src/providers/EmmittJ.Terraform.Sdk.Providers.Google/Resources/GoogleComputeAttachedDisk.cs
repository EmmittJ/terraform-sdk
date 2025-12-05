using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeAttachedDisk.
/// Nesting mode: single
/// </summary>
public class GoogleComputeAttachedDiskTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_attached_disk Terraform resource.
/// Manages a google_compute_attached_disk resource.
/// </summary>
public partial class GoogleComputeAttachedDisk(string name) : TerraformResource("google_compute_attached_disk", name)
{
    /// <summary>
    /// Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-* tree of a Linux operating system running within the instance. This name can be used to reference the device for mounting, resizing, and so on, from within the instance. If not specified, the server chooses a default device name to apply to this disk, in the form persistent-disks-x, where x is a number assigned by Google Compute Engine.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name") ?? CreateReference("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// name or self_link of the disk that will be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    public required TerraformValue<string> Disk
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// name or self_link of the compute instance that the disk will be attached to. If the self_link is provided then zone and project are extracted from the self link. If only the name is used then zone and project must be defined as properties on the resource or provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    public TerraformValue<string>? InterfaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The project that the referenced compute instance is a part of. If instance is referenced by its self_link the project defined in the link will take precedence.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The zone that the referenced compute instance is located within. If instance is referenced by its self_link the zone defined in the link will take precedence.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? CreateReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeAttachedDiskTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeAttachedDiskTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

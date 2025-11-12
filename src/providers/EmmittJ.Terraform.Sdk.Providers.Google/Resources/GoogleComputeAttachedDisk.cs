using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeAttachedDiskTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_compute_attached_disk resource.
/// </summary>
public partial class GoogleComputeAttachedDisk : TerraformResource
{
    public GoogleComputeAttachedDisk(string name) : base("google_compute_attached_disk", name)
    {
    }

    /// <summary>
    /// Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-* tree of a Linux operating system running within the instance. This name can be used to reference the device for mounting, resizing, and so on, from within the instance. If not specified, the server chooses a default device name to apply to this disk, in the form persistent-disks-x, where x is a number assigned by Google Compute Engine.
    /// </summary>
    [TerraformProperty("device_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeviceName { get; set; }

    /// <summary>
    /// name or self_link of the disk that will be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Disk is required")]
    [TerraformProperty("disk")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Disk { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// name or self_link of the compute instance that the disk will be attached to. If the self_link is provided then zone and project are extracted from the self link. If only the name is used then zone and project must be defined as properties on the resource or provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    [TerraformProperty("interface")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Interface { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The project that the referenced compute instance is a part of. If instance is referenced by its self_link the project defined in the link will take precedence.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The zone that the referenced compute instance is located within. If instance is referenced by its self_link the zone defined in the link will take precedence.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeAttachedDiskTimeoutsBlock Timeouts { get; set; } = new();

}

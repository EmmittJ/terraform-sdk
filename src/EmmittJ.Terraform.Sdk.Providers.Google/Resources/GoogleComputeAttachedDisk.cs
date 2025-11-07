using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_attached_disk resource.
/// </summary>
public class GoogleComputeAttachedDisk : TerraformResource
{
    public GoogleComputeAttachedDisk(string name) : base("google_compute_attached_disk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Specifies a unique device name of your choice that is reflected into the /dev/disk/by-id/google-* tree of a Linux operating system running within the instance. This name can be used to reference the device for mounting, resizing, and so on, from within the instance. If not specified, the server chooses a default device name to apply to this disk, in the form persistent-disks-x, where x is a number assigned by Google Compute Engine.
    /// </summary>
    public TerraformLiteralProperty<string>? DeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_name");
        set => this.WithProperty("device_name", value);
    }

    /// <summary>
    /// name or self_link of the disk that will be attached.
    /// </summary>
    public TerraformLiteralProperty<string>? Disk
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk");
        set => this.WithProperty("disk", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// name or self_link of the compute instance that the disk will be attached to. If the self_link is provided then zone and project are extracted from the self link. If only the name is used then zone and project must be defined as properties on the resource or provider.
    /// </summary>
    public TerraformLiteralProperty<string>? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The disk interface used for attaching this disk. One of SCSI or NVME. (This field is only used for specific cases, please don&#39;t specify this field without advice from Google.)
    /// </summary>
    public TerraformLiteralProperty<string>? Interface
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interface");
        set => this.WithProperty("interface", value);
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE or READ_ONLY. If not specified, the default is to attach the disk in READ_WRITE mode.
    /// </summary>
    public TerraformLiteralProperty<string>? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode");
        set => this.WithProperty("mode", value);
    }

    /// <summary>
    /// The project that the referenced compute instance is a part of. If instance is referenced by its self_link the project defined in the link will take precedence.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The zone that the referenced compute instance is located within. If instance is referenced by its self_link the zone defined in the link will take precedence.
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

}

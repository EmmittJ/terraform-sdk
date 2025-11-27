using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_config in GoogleNotebooksRuntime.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeAccessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_config";

    /// <summary>
    /// The type of access mode this instance. For valid values, see
    /// &#39;https://cloud.google.com/vertex-ai/docs/workbench/reference/
    /// rest/v1/projects.locations.runtimes#RuntimeAccessType&#39;.
    /// </summary>
    public TerraformValue<string>? AccessType
    {
        get => new TerraformReference<string>(this, "access_type");
        set => SetArgument("access_type", value);
    }

    /// <summary>
    /// The proxy endpoint that is used to access the runtime.
    /// </summary>
    public TerraformValue<string> ProxyUri
    {
        get => new TerraformReference<string>(this, "proxy_uri");
    }

    /// <summary>
    /// The owner of this runtime after creation. Format: &#39;alias@example.com&#39;.
    /// Currently supports one owner only.
    /// </summary>
    public TerraformValue<string>? RuntimeOwner
    {
        get => new TerraformReference<string>(this, "runtime_owner");
        set => SetArgument("runtime_owner", value);
    }

}


/// <summary>
/// Block type for software_config in GoogleNotebooksRuntime.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_config";

    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    public TerraformValue<string>? CustomGpuDriverPath
    {
        get => new TerraformReference<string>(this, "custom_gpu_driver_path");
        set => SetArgument("custom_gpu_driver_path", value);
    }

    /// <summary>
    /// Verifies core internal services are running. Default: True.
    /// </summary>
    public TerraformValue<bool>? EnableHealthMonitoring
    {
        get => new TerraformReference<bool>(this, "enable_health_monitoring");
        set => SetArgument("enable_health_monitoring", value);
    }

    /// <summary>
    /// Runtime will automatically shutdown after idle_shutdown_time.
    /// Default: True
    /// </summary>
    public TerraformValue<bool>? IdleShutdown
    {
        get => new TerraformReference<bool>(this, "idle_shutdown");
        set => SetArgument("idle_shutdown", value);
    }

    /// <summary>
    /// Time in minutes to wait before shuting down runtime.
    /// Default: 180 minutes
    /// </summary>
    public TerraformValue<double>? IdleShutdownTimeout
    {
        get => new TerraformReference<double>(this, "idle_shutdown_timeout");
        set => SetArgument("idle_shutdown_timeout", value);
    }

    /// <summary>
    /// Install Nvidia Driver automatically.
    /// </summary>
    public TerraformValue<bool>? InstallGpuDriver
    {
        get => new TerraformReference<bool>(this, "install_gpu_driver");
        set => SetArgument("install_gpu_driver", value);
    }

    /// <summary>
    /// Cron expression in UTC timezone for schedule instance auto upgrade.
    /// Please follow the [cron format](https://en.wikipedia.org/wiki/Cron).
    /// </summary>
    public TerraformValue<string>? NotebookUpgradeSchedule
    {
        get => new TerraformReference<string>(this, "notebook_upgrade_schedule");
        set => SetArgument("notebook_upgrade_schedule", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    public TerraformValue<string>? PostStartupScript
    {
        get => new TerraformReference<string>(this, "post_startup_script");
        set => SetArgument("post_startup_script", value);
    }

    /// <summary>
    /// Behavior for the post startup script. Possible values: [&amp;quot;POST_STARTUP_SCRIPT_BEHAVIOR_UNSPECIFIED&amp;quot;, &amp;quot;RUN_EVERY_START&amp;quot;, &amp;quot;DOWNLOAD_AND_RUN_EVERY_START&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PostStartupScriptBehavior
    {
        get => new TerraformReference<string>(this, "post_startup_script_behavior");
        set => SetArgument("post_startup_script_behavior", value);
    }

    /// <summary>
    /// Bool indicating whether an newer image is available in an image family.
    /// </summary>
    public TerraformValue<bool> Upgradeable
    {
        get => new TerraformReference<bool>(this, "upgradeable");
    }

    /// <summary>
    /// Kernels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNotebooksRuntimeSoftwareConfigBlockKernelsBlock>? Kernels
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeSoftwareConfigBlockKernelsBlock>>("kernels");
        set => SetArgument("kernels", value);
    }

}

/// <summary>
/// Block type for kernels in GoogleNotebooksRuntimeSoftwareConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeSoftwareConfigBlockKernelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kernels";

    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => new TerraformReference<string>(this, "repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNotebooksRuntime.
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksRuntimeTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for virtual_machine in GoogleNotebooksRuntime.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// The unique identifier of the Managed Compute Engine instance.
    /// </summary>
    public TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
    }

    /// <summary>
    /// The user-friendly name of the Managed Compute Engine instance.
    /// </summary>
    public TerraformValue<string> InstanceName
    {
        get => new TerraformReference<string>(this, "instance_name");
    }

    /// <summary>
    /// VirtualMachineConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock>? VirtualMachineConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock>>("virtual_machine_config");
        set => SetArgument("virtual_machine_config", value);
    }

}

/// <summary>
/// Block type for virtual_machine_config in GoogleNotebooksRuntimeVirtualMachineBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_config";

    /// <summary>
    /// The Compute Engine guest attributes. (see [Project and instance
    /// guest attributes](https://cloud.google.com/compute/docs/
    /// storing-retrieving-metadata#guest_attributes)).
    /// </summary>
    public TerraformMap<string> GuestAttributes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "guest_attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// If true, runtime will only have internal IP addresses. By default,
    /// runtimes are not restricted to internal IP addresses, and will
    /// have ephemeral external IP addresses assigned to each vm. This
    /// &#39;internal_ip_only&#39; restriction can only be enabled for subnetwork
    /// enabled networks, and all dependencies must be configured to be
    /// accessible without external IP addresses.
    /// </summary>
    public TerraformValue<bool>? InternalIpOnly
    {
        get => new TerraformReference<bool>(this, "internal_ip_only");
        set => SetArgument("internal_ip_only", value);
    }

    /// <summary>
    /// The labels to associate with this runtime. Label **keys** must
    /// contain 1 to 63 characters, and must conform to [RFC 1035]
    /// (https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be
    /// empty, but, if present, must contain 1 to 63 characters, and must
    /// conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No
    /// more than 32 labels can be associated with a cluster.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The Compute Engine machine type used for runtimes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => new TerraformReference<string>(this, "machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// The Compute Engine metadata entries to add to virtual machine.
    /// (see [Project and instance metadata](https://cloud.google.com
    /// /compute/docs/storing-retrieving-metadata#project_and_instance
    /// _metadata)).
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The Compute Engine network to be used for machine communications.
    /// Cannot be specified with subnetwork. If neither &#39;network&#39; nor
    /// &#39;subnet&#39; is specified, the &amp;quot;default&amp;quot; network of the project is
    /// used, if it exists. A full URL or partial URI. Examples:
    ///   * &#39;https://www.googleapis.com/compute/v1/projects/[project_id]/
    ///   regions/global/default&#39;
    ///   * &#39;projects/[project_id]/regions/global/default&#39;
    /// Runtimes are managed resources inside Google Infrastructure.
    /// Runtimes support the following network configurations:
    ///   * Google Managed Network (Network &amp;amp; subnet are empty)
    ///   * Consumer Project VPC (network &amp;amp; subnet are required). Requires
    ///   configuring Private Service Access.
    ///   * Shared VPC (network &amp;amp; subnet are required). Requires
    ///   configuring Private Service Access.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The type of vNIC to be used on this interface. This may be gVNIC
    /// or VirtioNet. Possible values: [&amp;quot;UNSPECIFIED_NIC_TYPE&amp;quot;, &amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NicType
    {
        get => new TerraformReference<string>(this, "nic_type");
        set => SetArgument("nic_type", value);
    }

    /// <summary>
    /// Reserved IP Range name is used for VPC Peering. The
    /// subnetwork allocation will use the range *name* if it&#39;s assigned.
    /// </summary>
    public TerraformValue<string>? ReservedIpRange
    {
        get => new TerraformReference<string>(this, "reserved_ip_range");
        set => SetArgument("reserved_ip_range", value);
    }

    /// <summary>
    /// The Compute Engine subnetwork to be used for machine
    /// communications. Cannot be specified with network. A full URL or
    /// partial URI are valid. Examples:
    ///   * &#39;https://www.googleapis.com/compute/v1/projects/[project_id]/
    ///   regions/us-east1/subnetworks/sub0&#39;
    ///   * &#39;projects/[project_id]/regions/us-east1/subnetworks/sub0&#39;
    /// </summary>
    public TerraformValue<string>? Subnet
    {
        get => new TerraformReference<string>(this, "subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// The Compute Engine tags to add to runtime (see [Tagging instances]
    /// (https://cloud.google.com/compute/docs/
    /// label-or-tag-resources#tags)).
    /// </summary>
    public TerraformList<string> Tags
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone where the virtual machine is located.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
    }

    /// <summary>
    /// AcceleratorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockAcceleratorConfigBlock>? AcceleratorConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockAcceleratorConfigBlock>>("accelerator_config");
        set => SetArgument("accelerator_config", value);
    }

    /// <summary>
    /// ContainerImages block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockContainerImagesBlock>? ContainerImages
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockContainerImagesBlock>>("container_images");
        set => SetArgument("container_images", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDisk block(s) allowed")]
    public required TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlock> DataDisk
    {
        get => GetRequiredArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

}

/// <summary>
/// Block type for accelerator_config in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockAcceleratorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_config";

    /// <summary>
    /// Count of cores of this accelerator.
    /// </summary>
    public TerraformValue<double>? CoreCount
    {
        get => new TerraformReference<double>(this, "core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// Accelerator model. For valid values, see
    /// &#39;https://cloud.google.com/vertex-ai/docs/workbench/reference/
    /// rest/v1/projects.locations.runtimes#AcceleratorType&#39;
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for container_images in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockContainerImagesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_images";

    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => new TerraformReference<string>(this, "repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => new TerraformReference<string>(this, "tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for data_disk in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// Optional. Specifies whether the disk will be auto-deleted
    /// when the instance is deleted (but not when the disk is
    /// detached from the instance).
    /// </summary>
    public TerraformValue<bool> AutoDelete
    {
        get => new TerraformReference<bool>(this, "auto_delete");
    }

    /// <summary>
    /// Optional. Indicates that this is a boot disk. The virtual
    /// machine will use the first partition of the disk for its
    /// root filesystem.
    /// </summary>
    public TerraformValue<bool> Boot
    {
        get => new TerraformReference<bool>(this, "boot");
    }

    /// <summary>
    /// Optional. Specifies a unique device name of your choice
    /// that is reflected into the /dev/disk/by-id/google-* tree
    /// of a Linux operating system running within the instance.
    /// This name can be used to reference the device for mounting,
    /// resizing, and so on, from within the instance.
    /// If not specified, the server chooses a default device name
    /// to apply to this disk, in the form persistent-disk-x, where
    /// x is a number assigned by Google Compute Engine. This field
    /// is only applicable for persistent disks.
    /// </summary>
    public TerraformValue<string> DeviceName
    {
        get => new TerraformReference<string>(this, "device_name");
    }

    /// <summary>
    /// Indicates a list of features to enable on the guest operating
    /// system. Applicable only for bootable images. To see a list of
    /// available features, read &#39;https://cloud.google.com/compute/docs/
    /// images/create-delete-deprecate-private-images#guest-os-features&#39;
    /// options. &#39;&#39;
    /// </summary>
    public TerraformList<string> GuestOsFeatures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "guest_os_features").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. A zero-based index to this disk, where 0 is
    /// reserved for the boot disk. If you have many disks attached
    /// to an instance, each disk would have a unique index number.
    /// </summary>
    public TerraformValue<double> Index
    {
        get => new TerraformReference<double>(this, "index");
    }

    /// <summary>
    /// &amp;quot;Specifies the disk interface to use for attaching this disk,
    /// which is either SCSI or NVME. The default is SCSI. Persistent
    /// disks must always use SCSI and the request will fail if you attempt
    /// to attach a persistent disk in any other format than SCSI. Local SSDs
    /// can use either NVME or SCSI. For performance characteristics of SCSI
    /// over NVMe, see Local SSD performance. Valid values: * NVME * SCSI&amp;quot;.
    /// </summary>
    public TerraformValue<string>? InterfaceAttribute
    {
        get => new TerraformReference<string>(this, "interface");
        set => SetArgument("interface", value);
    }

    /// <summary>
    /// Type of the resource. Always compute#attachedDisk for attached
    /// disks.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// Output only. Any valid publicly visible licenses.
    /// </summary>
    public TerraformList<string> Licenses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "licenses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE
    /// or READ_ONLY. If not specified, the default is to attach
    /// the disk in READ_WRITE mode.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Specifies a valid partial or full URL to an existing
    /// Persistent Disk resource.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Specifies the type of the disk, either SCRATCH or PERSISTENT.
    /// If not specified, the default is PERSISTENT.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// InitializeParams block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitializeParams block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlockInitializeParamsBlock>? InitializeParams
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlockInitializeParamsBlock>>("initialize_params");
        set => SetArgument("initialize_params", value);
    }

}

/// <summary>
/// Block type for initialize_params in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockDataDiskBlockInitializeParamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initialize_params";

    /// <summary>
    /// Provide this property when creating the disk.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies the disk name. If not specified, the default is
    /// to use the name of the instance. If the disk with the
    /// instance name exists already in the given zone/region, a
    /// new name will be automatically generated.
    /// </summary>
    public TerraformValue<string>? DiskName
    {
        get => new TerraformReference<string>(this, "disk_name");
        set => SetArgument("disk_name", value);
    }

    /// <summary>
    /// Specifies the size of the disk in base-2 GB. If not
    /// specified, the disk will be the same size as the image
    /// (usually 10GB). If specified, the size must be equal to
    /// or larger than 10GB. Default 100 GB.
    /// </summary>
    public TerraformValue<double>? DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The type of the boot disk attached to this runtime,
    /// defaults to standard persistent disk. For valid values,
    /// see &#39;https://cloud.google.com/vertex-ai/docs/workbench/
    /// reference/rest/v1/projects.locations.runtimes#disktype&#39;
    /// </summary>
    public TerraformValue<string>? DiskType
    {
        get => new TerraformReference<string>(this, "disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// Labels to apply to this disk. These can be later modified
    /// by the disks.setLabels method. This field is only
    /// applicable for persistent disks.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for encryption_config in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The Cloud KMS resource identifier of the customer-managed
    /// encryption key used to protect a resource, such as a disks.
    /// It has the following format:
    /// &#39;projects/{PROJECT_ID}/locations/{REGION}/keyRings/
    /// {KEY_RING_NAME}/cryptoKeys/{KEY_NAME}&#39;
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

}

/// <summary>
/// Block type for shielded_instance_config in GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksRuntimeVirtualMachineBlockVirtualMachineConfigBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled.
    /// Enables monitoring and attestation of the boot integrity of
    /// the instance. The attestation is performed against the
    /// integrity policy baseline. This baseline is initially derived
    /// from the implicitly trusted boot image when the instance is
    /// created. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => new TerraformReference<bool>(this, "enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled.Secure
    /// Boot helps ensure that the system only runs authentic software
    /// by verifying the digital signature of all boot components, and
    /// halting the boot process if signature verification fails.
    /// Disabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => new TerraformReference<bool>(this, "enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Defines whether the instance has the vTPM enabled. Enabled by
    /// default.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => new TerraformReference<bool>(this, "enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}


/// <summary>
/// Represents a google_notebooks_runtime Terraform resource.
/// Manages a google_notebooks_runtime resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleNotebooksRuntime(string name) : TerraformResource("google_notebooks_runtime", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels to associate with this runtime. Label **keys** must
    /// contain 1 to 63 characters, and must conform to [RFC 1035]
    /// (https://www.ietf.org/rfc/rfc1035.txt). Label **values** may be
    /// empty, but, if present, must contain 1 to 63 characters, and must
    /// conform to [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt). No
    /// more than 32 labels can be associated with a cluster.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name specified for the Notebook runtime.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The health state of this runtime. For a list of possible output
    /// values, see &#39;https://cloud.google.com/vertex-ai/docs/workbench/
    /// reference/rest/v1/projects.locations.runtimes#healthstate&#39;.
    /// </summary>
    public TerraformValue<string> HealthState
    {
        get => new TerraformReference<string>(this, "health_state");
    }

    /// <summary>
    /// Contains Runtime daemon metrics such as Service status and JupyterLab
    /// status
    /// </summary>
    public TerraformList<TerraformMap<object>> Metrics
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state of this runtime.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// AccessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeAccessConfigBlock>? AccessConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeAccessConfigBlock>>("access_config");
        set => SetArgument("access_config", value);
    }

    /// <summary>
    /// SoftwareConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeSoftwareConfigBlock>>("software_config");
        set => SetArgument("software_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNotebooksRuntimeTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNotebooksRuntimeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachine block(s) allowed")]
    public TerraformList<GoogleNotebooksRuntimeVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<GoogleNotebooksRuntimeVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}

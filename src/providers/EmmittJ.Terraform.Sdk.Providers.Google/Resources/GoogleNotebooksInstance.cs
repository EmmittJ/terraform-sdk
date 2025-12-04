using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerator_config in GoogleNotebooksInstance.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceAcceleratorConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_config";

    /// <summary>
    /// Count of cores of this accelerator.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreCount is required")]
    public required TerraformValue<double> CoreCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// Type of this accelerator. Possible values: [&amp;quot;ACCELERATOR_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;NVIDIA_TESLA_K80&amp;quot;, &amp;quot;NVIDIA_TESLA_P100&amp;quot;, &amp;quot;NVIDIA_TESLA_V100&amp;quot;, &amp;quot;NVIDIA_TESLA_P4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P100_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_A100&amp;quot;, &amp;quot;TPU_V2&amp;quot;, &amp;quot;TPU_V3&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for container_image in GoogleNotebooksInstance.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceContainerImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_image";

    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    public TerraformValue<string>? Tag
    {
        get => GetArgument<TerraformValue<string>>("tag");
        set => SetArgument("tag", value);
    }

}


/// <summary>
/// Block type for reservation_affinity in GoogleNotebooksInstance.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// The type of Compute Reservation. Possible values: [&amp;quot;NO_RESERVATION&amp;quot;, &amp;quot;ANY_RESERVATION&amp;quot;, &amp;quot;SPECIFIC_RESERVATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    public required TerraformValue<string> ConsumeReservationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// Corresponds to the label key of reservation resource.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Corresponds to the label values of reservation resource.
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for shielded_instance_config in GoogleNotebooksInstance.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
    /// boot integrity of the instance. The attestation is performed against the integrity policy baseline.
    /// This baseline is initially derived from the implicitly trusted boot image when the instance is created.
    /// Enabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
    /// authentic software by verifying the digital signature of all boot components, and halting the boot process
    /// if signature verification fails.
    /// Disabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Defines whether the instance has the vTPM enabled.
    /// Enabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNotebooksInstance.
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksInstanceTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vm_image in GoogleNotebooksInstance.
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceVmImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_image";

    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    public TerraformValue<string>? ImageFamily
    {
        get => GetArgument<TerraformValue<string>>("image_family");
        set => SetArgument("image_family", value);
    }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    public TerraformValue<string>? ImageName
    {
        get => GetArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Represents a google_notebooks_instance Terraform resource.
/// Manages a google_notebooks_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleNotebooksInstance(string name) : TerraformResource("google_notebooks_instance", name)
{
    /// <summary>
    /// The size of the boot disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
    /// If not specified, this defaults to 100.
    /// </summary>
    public TerraformValue<double>? BootDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("boot_disk_size_gb");
        set => SetArgument("boot_disk_size_gb", value);
    }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? BootDiskType
    {
        get => GetArgument<TerraformValue<string>>("boot_disk_type");
        set => SetArgument("boot_disk_type", value);
    }

    /// <summary>
    /// Instance creation time
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => GetArgument<TerraformValue<string>>("create_time") ?? AsReference("create_time");
        set => SetArgument("create_time", value);
    }

    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    public TerraformValue<string>? CustomGpuDriverPath
    {
        get => GetArgument<TerraformValue<string>>("custom_gpu_driver_path");
        set => SetArgument("custom_gpu_driver_path", value);
    }

    /// <summary>
    /// The size of the data disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB).
    /// You can choose the size of the data disk based on how big your notebooks and data are.
    /// If not specified, this defaults to 100.
    /// </summary>
    public TerraformValue<double>? DataDiskSizeGb
    {
        get => GetArgument<TerraformValue<double>>("data_disk_size_gb");
        set => SetArgument("data_disk_size_gb", value);
    }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DataDiskType
    {
        get => GetArgument<TerraformValue<string>>("data_disk_type");
        set => SetArgument("data_disk_type", value);
    }

    /// <summary>
    /// Desired state of the Notebook Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Disk encryption method used on the boot and data disks, defaults to GMEK. Possible values: [&amp;quot;DISK_ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiskEncryption
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption") ?? AsReference("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Whether the end user authorizes Google Cloud to install GPU driver
    /// on this instance. If this field is empty or set to false, the GPU driver
    /// won&#39;t be installed. Only applicable to instances with GPUs.
    /// </summary>
    public TerraformValue<bool>? InstallGpuDriver
    {
        get => GetArgument<TerraformValue<bool>>("install_gpu_driver");
        set => SetArgument("install_gpu_driver", value);
    }

    /// <summary>
    /// The list of owners of this instance after creation.
    /// Format: alias@example.com.
    /// Currently supports one owner only.
    /// If not specified, all of the service account users of
    /// your VM instance&#39;s service account can use the instance.
    /// </summary>
    public TerraformList<string>? InstanceOwners
    {
        get => GetArgument<TerraformList<string>>("instance_owners");
        set => SetArgument("instance_owners", value);
    }

    /// <summary>
    /// The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
    /// Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Labels to apply to this instance. These can be later modified by the setLabels method.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A reference to a machine type which defines VM kind.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    public required TerraformValue<string> MachineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Custom metadata to apply to this instance.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name specified for the Notebook instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the VPC that this instance is in.
    /// Format: projects/{project_id}/global/networks/{network_id}
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The type of vNIC driver. Possible values: [&amp;quot;UNSPECIFIED_NIC_TYPE&amp;quot;, &amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NicType
    {
        get => GetArgument<TerraformValue<string>>("nic_type");
        set => SetArgument("nic_type", value);
    }

    /// <summary>
    /// The notebook instance will not register with the proxy..
    /// </summary>
    public TerraformValue<bool>? NoProxyAccess
    {
        get => GetArgument<TerraformValue<bool>>("no_proxy_access");
        set => SetArgument("no_proxy_access", value);
    }

    /// <summary>
    /// No public IP will be assigned to this instance.
    /// </summary>
    public TerraformValue<bool>? NoPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("no_public_ip");
        set => SetArgument("no_public_ip", value);
    }

    /// <summary>
    /// If true, the data disk will not be auto deleted when deleting the instance.
    /// </summary>
    public TerraformValue<bool>? NoRemoveDataDisk
    {
        get => GetArgument<TerraformValue<bool>>("no_remove_data_disk");
        set => SetArgument("no_remove_data_disk", value);
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a
    /// notebook instance fully boots up. The path must be a URL
    /// or Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    public TerraformValue<string>? PostStartupScript
    {
        get => GetArgument<TerraformValue<string>>("post_startup_script");
        set => SetArgument("post_startup_script", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The service account on this instance, giving access to other
    /// Google Cloud services. You can use any service account within
    /// the same project, but you must have the service account user
    /// permission to use the instance. If not specified,
    /// the Compute Engine default service account is used.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account") ?? AsReference("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Optional. The URIs of service account scopes to be included in Compute Engine instances.
    /// If not specified, the following scopes are defined:
    /// - https://www.googleapis.com/auth/cloud-platform
    /// - https://www.googleapis.com/auth/userinfo.email
    /// </summary>
    public TerraformList<string> ServiceAccountScopes
    {
        get => GetArgument<TerraformList<string>>("service_account_scopes") ?? AsReference("service_account_scopes");
        set => SetArgument("service_account_scopes", value);
    }

    /// <summary>
    /// The name of the subnet that this instance is in.
    /// Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
    /// </summary>
    public TerraformValue<string> Subnet
    {
        get => GetArgument<TerraformValue<string>>("subnet") ?? AsReference("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// The Compute Engine tags to add to instance.
    /// </summary>
    public TerraformList<string> Tags
    {
        get => GetArgument<TerraformList<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Instance update time.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => GetArgument<TerraformValue<string>>("update_time") ?? AsReference("update_time");
        set => SetArgument("update_time", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The proxy endpoint that is used to access the Jupyter notebook.
    /// Only returned when the resource is in a &#39;PROVISIONED&#39; state. If
    /// needed you can utilize &#39;terraform apply -refresh-only&#39; to await
    /// the population of this value.
    /// </summary>
    public TerraformValue<string> ProxyUri
        => AsReference("proxy_uri");

    /// <summary>
    /// The state of this instance.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// AcceleratorConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksInstanceAcceleratorConfigBlock>? AcceleratorConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksInstanceAcceleratorConfigBlock>>("accelerator_config");
        set => SetArgument("accelerator_config", value);
    }

    /// <summary>
    /// ContainerImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public TerraformList<GoogleNotebooksInstanceContainerImageBlock>? ContainerImage
    {
        get => GetArgument<TerraformList<GoogleNotebooksInstanceContainerImageBlock>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleNotebooksInstanceReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleNotebooksInstanceReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleNotebooksInstanceShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleNotebooksInstanceShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNotebooksInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNotebooksInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VmImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    public TerraformList<GoogleNotebooksInstanceVmImageBlock>? VmImage
    {
        get => GetArgument<TerraformList<GoogleNotebooksInstanceVmImageBlock>>("vm_image");
        set => SetArgument("vm_image", value);
    }

}

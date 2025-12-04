using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gce_setup in GoogleWorkbenchInstance.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gce_setup";

    /// <summary>
    /// Optional. If true, no external IP will be assigned to this VM instance.
    /// </summary>
    public TerraformValue<bool> DisablePublicIp
    {
        get => GetArgument<TerraformValue<bool>>("disable_public_ip") ?? AsReference("disable_public_ip");
        set => SetArgument("disable_public_ip", value);
    }

    /// <summary>
    /// Optional. Flag to enable ip forwarding or not, default false/off.
    /// https://cloud.google.com/vpc/docs/using-routes#canipforward
    /// </summary>
    public TerraformValue<bool>? EnableIpForwarding
    {
        get => GetArgument<TerraformValue<bool>>("enable_ip_forwarding");
        set => SetArgument("enable_ip_forwarding", value);
    }

    /// <summary>
    /// Optional. The machine type of the VM instance. https://cloud.google.com/compute/docs/machine-resource
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? AsReference("machine_type");
        set => SetArgument("machine_type", value);
    }

    /// <summary>
    /// Optional. Custom metadata to apply to this instance.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? AsReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Optional. The Compute Engine tags to add to instance (see [Tagging
    /// instances](https://cloud.google.com/compute/docs/label-or-tag-resources#tags)).
    /// </summary>
    public TerraformList<string> Tags
    {
        get => GetArgument<TerraformList<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AcceleratorConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockAcceleratorConfigsBlock>? AcceleratorConfigs
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockAcceleratorConfigsBlock>>("accelerator_configs");
        set => SetArgument("accelerator_configs", value);
    }

    /// <summary>
    /// BootDisk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDisk block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockBootDiskBlock>? BootDisk
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockBootDiskBlock>>("boot_disk");
        set => SetArgument("boot_disk", value);
    }

    /// <summary>
    /// ConfidentialInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfidentialInstanceConfig block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockConfidentialInstanceConfigBlock>? ConfidentialInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockConfidentialInstanceConfigBlock>>("confidential_instance_config");
        set => SetArgument("confidential_instance_config", value);
    }

    /// <summary>
    /// ContainerImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockContainerImageBlock>? ContainerImage
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockContainerImageBlock>>("container_image");
        set => SetArgument("container_image", value);
    }

    /// <summary>
    /// DataDisks block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDisks block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockDataDisksBlock>? DataDisks
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockDataDisksBlock>>("data_disks");
        set => SetArgument("data_disks", value);
    }

    /// <summary>
    /// NetworkInterfaces block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlock>? NetworkInterfaces
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlock>>("network_interfaces");
        set => SetArgument("network_interfaces", value);
    }

    /// <summary>
    /// ReservationAffinity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockReservationAffinityBlock>? ReservationAffinity
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockReservationAffinityBlock>>("reservation_affinity");
        set => SetArgument("reservation_affinity", value);
    }

    /// <summary>
    /// ServiceAccounts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockServiceAccountsBlock>? ServiceAccounts
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockServiceAccountsBlock>>("service_accounts");
        set => SetArgument("service_accounts", value);
    }

    /// <summary>
    /// ShieldedInstanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockShieldedInstanceConfigBlock>? ShieldedInstanceConfig
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockShieldedInstanceConfigBlock>>("shielded_instance_config");
        set => SetArgument("shielded_instance_config", value);
    }

    /// <summary>
    /// VmImage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockVmImageBlock>? VmImage
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockVmImageBlock>>("vm_image");
        set => SetArgument("vm_image", value);
    }

}

/// <summary>
/// Block type for accelerator_configs in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockAcceleratorConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "accelerator_configs";

    /// <summary>
    /// Optional. Count of cores of this accelerator.
    /// </summary>
    public TerraformValue<string>? CoreCount
    {
        get => GetArgument<TerraformValue<string>>("core_count");
        set => SetArgument("core_count", value);
    }

    /// <summary>
    /// Optional. Type of this accelerator. Possible values: [&amp;quot;NVIDIA_TESLA_P100&amp;quot;, &amp;quot;NVIDIA_TESLA_V100&amp;quot;, &amp;quot;NVIDIA_TESLA_P4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4&amp;quot;, &amp;quot;NVIDIA_TESLA_A100&amp;quot;, &amp;quot;NVIDIA_A100_80GB&amp;quot;, &amp;quot;NVIDIA_L4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P100_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P4_VWS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for boot_disk in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockBootDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boot_disk";

    /// <summary>
    /// Optional. Input only. Disk encryption method used on the boot and
    /// data disks, defaults to GMEK. Possible values: [&amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiskEncryption
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption") ?? AsReference("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Optional. The size of the boot disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB). If not specified, this defaults to the
    /// recommended value of 150GB.
    /// </summary>
    public TerraformValue<string> DiskSizeGb
    {
        get => GetArgument<TerraformValue<string>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Optional. Indicates the type of the disk. Possible values: [&amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? AsReference("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// &#39;Optional. The KMS key used to encrypt the disks, only
    /// applicable if disk_encryption is CMEK. Format: &#39;projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}&#39;
    /// Learn more about using your own encryption keys.&#39;
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}

/// <summary>
/// Block type for confidential_instance_config in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockConfidentialInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confidential_instance_config";

    /// <summary>
    /// Defines the type of technology used by the confidential instance. Possible values: [&amp;quot;SEV&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ConfidentialInstanceType
    {
        get => GetArgument<TerraformValue<string>>("confidential_instance_type");
        set => SetArgument("confidential_instance_type", value);
    }

}

/// <summary>
/// Block type for container_image in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockContainerImageBlock : TerraformBlock
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
/// Block type for data_disks in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockDataDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disks";

    /// <summary>
    /// Optional. Input only. Disk encryption method used on the boot
    /// and data disks, defaults to GMEK. Possible values: [&amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    public TerraformValue<string> DiskEncryption
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption") ?? AsReference("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Optional. The size of the disk in GB attached to this VM instance,
    /// up to a maximum of 64000 GB (64 TB). If not specified, this defaults to
    /// 100.
    /// </summary>
    public TerraformValue<string> DiskSizeGb
    {
        get => GetArgument<TerraformValue<string>>("disk_size_gb") ?? AsReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// Optional. Input only. Indicates the type of the disk. Possible values: [&amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type");
        set => SetArgument("disk_type", value);
    }

    /// <summary>
    /// &#39;Optional. The KMS key used to encrypt the disks,
    /// only applicable if disk_encryption is CMEK. Format: &#39;projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}&#39;
    /// Learn more about using your own encryption keys.&#39;
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}

/// <summary>
/// Block type for network_interfaces in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_interfaces";

    /// <summary>
    /// Optional. The name of the VPC that this VM instance is in.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Optional. The type of vNIC to be used on this interface. This
    /// may be gVNIC or VirtioNet. Possible values: [&amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NicType
    {
        get => GetArgument<TerraformValue<string>>("nic_type");
        set => SetArgument("nic_type", value);
    }

    /// <summary>
    /// Optional. The name of the subnet that this VM instance is in.
    /// </summary>
    public TerraformValue<string> Subnet
    {
        get => GetArgument<TerraformValue<string>>("subnet") ?? AsReference("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// AccessConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlockAccessConfigsBlock>? AccessConfigs
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlockAccessConfigsBlock>>("access_configs");
        set => SetArgument("access_configs", value);
    }

}

/// <summary>
/// Block type for access_configs in GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockNetworkInterfacesBlockAccessConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_configs";

    /// <summary>
    /// An external IP address associated with this instance. Specify an unused
    /// static external IP address available to the project or leave this field
    /// undefined to use an IP from a shared ephemeral IP address pool. If you
    /// specify a static external IP address, it must live in the same region as
    /// the zone of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalIp is required")]
    public required TerraformValue<string> ExternalIp
    {
        get => GetRequiredArgument<TerraformValue<string>>("external_ip");
        set => SetArgument("external_ip", value);
    }

}

/// <summary>
/// Block type for reservation_affinity in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockReservationAffinityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_affinity";

    /// <summary>
    /// Specifies the type of reservation from which this instance can consume resources:
    /// RESERVATION_ANY (default), RESERVATION_SPECIFIC, or RESERVATION_NONE. Possible values: [&amp;quot;RESERVATION_NONE&amp;quot;, &amp;quot;RESERVATION_ANY&amp;quot;, &amp;quot;RESERVATION_SPECIFIC&amp;quot;]
    /// </summary>
    public TerraformValue<string> ConsumeReservationType
    {
        get => GetArgument<TerraformValue<string>>("consume_reservation_type") ?? AsReference("consume_reservation_type");
        set => SetArgument("consume_reservation_type", value);
    }

    /// <summary>
    /// Corresponds to the label key of a reservation resource. To target a
    /// RESERVATION_SPECIFIC by name, use compute.googleapis.com/reservation-name
    /// as the key and specify the name of your reservation as its value.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Corresponds to the label values of a reservation resource. This can be
    /// either a name to a reservation in the same project or
    /// &amp;quot;projects/different-project/reservations/some-reservation-name&amp;quot;
    /// to target a shared reservation in the same zone but in a different project.
    /// </summary>
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for service_accounts in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockServiceAccountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_accounts";

    /// <summary>
    /// Optional. Email address of the service account.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email") ?? AsReference("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// Output only. The list of scopes to be made available for this
    /// service account. Set by the CLH to https://www.googleapis.com/auth/cloud-platform
    /// </summary>
    public TerraformList<string> Scopes
        => AsReference("scopes");

}

/// <summary>
/// Block type for shielded_instance_config in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockShieldedInstanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_instance_config";

    /// <summary>
    /// Optional. Defines whether the VM instance has integrity monitoring
    /// enabled. Enables monitoring and attestation of the boot integrity of the VM
    /// instance. The attestation is performed against the integrity policy baseline.
    /// This baseline is initially derived from the implicitly trusted boot image
    /// when the VM instance is created. Enabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableIntegrityMonitoring
    {
        get => GetArgument<TerraformValue<bool>>("enable_integrity_monitoring");
        set => SetArgument("enable_integrity_monitoring", value);
    }

    /// <summary>
    /// Optional. Defines whether the VM instance has Secure Boot enabled.
    /// Secure Boot helps ensure that the system only runs authentic software by verifying
    /// the digital signature of all boot components, and halting the boot process
    /// if signature verification fails. Disabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

    /// <summary>
    /// Optional. Defines whether the VM instance has the vTPM enabled.
    /// Enabled by default.
    /// </summary>
    public TerraformValue<bool>? EnableVtpm
    {
        get => GetArgument<TerraformValue<bool>>("enable_vtpm");
        set => SetArgument("enable_vtpm", value);
    }

}

/// <summary>
/// Block type for vm_image in GoogleWorkbenchInstanceGceSetupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleWorkbenchInstanceGceSetupBlockVmImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vm_image";

    /// <summary>
    /// Optional. Use this VM image family to find the image; the newest
    /// image in this family will be used.
    /// </summary>
    public TerraformValue<string>? Family
    {
        get => GetArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// Optional. Use VM image name to find the image.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: {project_id}
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleWorkbenchInstance.
/// Nesting mode: single
/// </summary>
public class GoogleWorkbenchInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a google_workbench_instance Terraform resource.
/// Manages a google_workbench_instance resource.
/// </summary>
public partial class GoogleWorkbenchInstance(string name) : TerraformResource("google_workbench_instance", name)
{
    /// <summary>
    /// Desired state of the Workbench Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Optional. If true, the workbench instance will not register with the proxy.
    /// </summary>
    public TerraformValue<bool>? DisableProxyAccess
    {
        get => GetArgument<TerraformValue<bool>>("disable_proxy_access");
        set => SetArgument("disable_proxy_access", value);
    }

    /// <summary>
    /// Flag to enable managed end user credentials for the instance.
    /// </summary>
    public TerraformValue<bool>? EnableManagedEuc
    {
        get => GetArgument<TerraformValue<bool>>("enable_managed_euc");
        set => SetArgument("enable_managed_euc", value);
    }

    /// <summary>
    /// Flag that specifies that a notebook can be accessed with third party
    /// identity provider.
    /// </summary>
    public TerraformValue<bool>? EnableThirdPartyIdentity
    {
        get => GetArgument<TerraformValue<bool>>("enable_third_party_identity");
        set => SetArgument("enable_third_party_identity", value);
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
    /// Required. User-defined unique ID of this instance.
    /// </summary>
    public TerraformValue<string>? InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// &#39;Optional. Input only. The owner of this instance after creation. Format:
    /// &#39;alias@example.com&#39; Currently supports one owner only. If not specified, all of
    /// the service account users of your VM instance&#39;&#39;s service account can use the instance.
    /// If specified, sets the access mode to &#39;Single user&#39;. For more details, see
    /// https://cloud.google.com/vertex-ai/docs/workbench/instances/manage-access-jupyterlab&#39;
    /// </summary>
    public TerraformList<string>? InstanceOwners
    {
        get => GetArgument<TerraformList<string>>("instance_owners");
        set => SetArgument("instance_owners", value);
    }

    /// <summary>
    /// Optional. Labels to apply to this instance. These can be later modified
    /// by the UpdateInstance method.
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
    /// Part of &#39;parent&#39;. See documentation of &#39;projectsId&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of this workbench instance. Format: &#39;projects/{project_id}/locations/{location}/instances/{instance_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Output only. Email address of entity that sent original CreateInstance request.
    /// </summary>
    public TerraformValue<string> Creator
        => AsReference("creator");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// &#39;Output only. Additional information about instance health. Example:
    /// healthInfo&amp;quot;: { &amp;quot;docker_proxy_agent_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;docker_status&amp;quot;: &amp;quot;1&amp;quot;, &amp;quot;jupyterlab_api_status&amp;quot;:
    /// &amp;quot;-1&amp;quot;, &amp;quot;jupyterlab_status&amp;quot;: &amp;quot;-1&amp;quot;, &amp;quot;updated&amp;quot;: &amp;quot;2020-10-18 09:40:03.573409&amp;quot; }&#39;
    /// </summary>
    public TerraformList<TerraformMap<object>> HealthInfo
        => AsReference("health_info");

    /// <summary>
    /// Output only. Instance health_state.
    /// </summary>
    public TerraformValue<string> HealthState
        => AsReference("health_state");

    /// <summary>
    /// Output only. The proxy endpoint that is used to access the Jupyter notebook.
    /// </summary>
    public TerraformValue<string> ProxyUri
        => AsReference("proxy_uri");

    /// <summary>
    /// Output only. The state of this instance.
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
    /// An RFC3339 timestamp in UTC time. This in the format of yyyy-MM-ddTHH:mm:ss.SSSZ.
    /// The milliseconds portion (&amp;quot;.SSS&amp;quot;) is optional.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Output only. The upgrade history of this instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpgradeHistory
        => AsReference("upgrade_history");

    /// <summary>
    /// GceSetup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GceSetup block(s) allowed")]
    public TerraformList<GoogleWorkbenchInstanceGceSetupBlock>? GceSetup
    {
        get => GetArgument<TerraformList<GoogleWorkbenchInstanceGceSetupBlock>>("gce_setup");
        set => SetArgument("gce_setup", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleWorkbenchInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleWorkbenchInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

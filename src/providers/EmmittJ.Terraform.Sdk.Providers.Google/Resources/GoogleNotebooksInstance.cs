using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerator_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksInstanceAcceleratorConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Count of cores of this accelerator.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreCount is required")]
    [TerraformProperty("core_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> CoreCount { get; set; }

    /// <summary>
    /// Type of this accelerator. Possible values: [&amp;quot;ACCELERATOR_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;NVIDIA_TESLA_K80&amp;quot;, &amp;quot;NVIDIA_TESLA_P100&amp;quot;, &amp;quot;NVIDIA_TESLA_V100&amp;quot;, &amp;quot;NVIDIA_TESLA_P4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P100_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_A100&amp;quot;, &amp;quot;TPU_V2&amp;quot;, &amp;quot;TPU_V3&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for container_image in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksInstanceContainerImageBlock : TerraformBlockBase
{
    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformProperty("repository")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Repository { get; set; }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksInstanceReservationAffinityBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of Compute Reservation. Possible values: [&amp;quot;NO_RESERVATION&amp;quot;, &amp;quot;ANY_RESERVATION&amp;quot;, &amp;quot;SPECIFIC_RESERVATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    [TerraformProperty("consume_reservation_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConsumeReservationType { get; set; }

    /// <summary>
    /// Corresponds to the label key of reservation resource.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// Corresponds to the label values of reservation resource.
    /// </summary>
    [TerraformProperty("values")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksInstanceShieldedInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
    /// boot integrity of the instance. The attestation is performed against the integrity policy baseline.
    /// This baseline is initially derived from the implicitly trusted boot image when the instance is created.
    /// Enabled by default.
    /// </summary>
    [TerraformProperty("enable_integrity_monitoring")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
    /// authentic software by verifying the digital signature of all boot components, and halting the boot process
    /// if signature verification fails.
    /// Disabled by default.
    /// </summary>
    [TerraformProperty("enable_secure_boot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Defines whether the instance has the vTPM enabled.
    /// Enabled by default.
    /// </summary>
    [TerraformProperty("enable_vtpm")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNotebooksInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vm_image in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNotebooksInstanceVmImageBlock : TerraformBlockBase
{
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    [TerraformProperty("image_family")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageFamily { get; set; }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    [TerraformProperty("image_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ImageName { get; set; }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Project { get; set; }

}

/// <summary>
/// Manages a google_notebooks_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNotebooksInstance : TerraformResource
{
    public GoogleNotebooksInstance(string name) : base("google_notebooks_instance", name)
    {
    }

    /// <summary>
    /// The size of the boot disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
    /// If not specified, this defaults to 100.
    /// </summary>
    [TerraformProperty("boot_disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? BootDiskSizeGb { get; set; }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    [TerraformProperty("boot_disk_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BootDiskType { get; set; }

    /// <summary>
    /// Instance creation time
    /// </summary>
    [TerraformProperty("create_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CreateTime { get; set; }

    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    [TerraformProperty("custom_gpu_driver_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomGpuDriverPath { get; set; }

    /// <summary>
    /// The size of the data disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB).
    /// You can choose the size of the data disk based on how big your notebooks and data are.
    /// If not specified, this defaults to 100.
    /// </summary>
    [TerraformProperty("data_disk_size_gb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DataDiskSizeGb { get; set; }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    [TerraformProperty("data_disk_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DataDiskType { get; set; }

    /// <summary>
    /// Desired state of the Notebook Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// Disk encryption method used on the boot and data disks, defaults to GMEK. Possible values: [&amp;quot;DISK_ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    [TerraformProperty("disk_encryption")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DiskEncryption { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Whether the end user authorizes Google Cloud to install GPU driver
    /// on this instance. If this field is empty or set to false, the GPU driver
    /// won&#39;t be installed. Only applicable to instances with GPUs.
    /// </summary>
    [TerraformProperty("install_gpu_driver")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? InstallGpuDriver { get; set; }

    /// <summary>
    /// The list of owners of this instance after creation.
    /// Format: alias@example.com.
    /// Currently supports one owner only.
    /// If not specified, all of the service account users of
    /// your VM instance&#39;s service account can use the instance.
    /// </summary>
    [TerraformProperty("instance_owners")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? InstanceOwners { get; set; }

    /// <summary>
    /// The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
    /// Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKey { get; set; }

    /// <summary>
    /// Labels to apply to this instance. These can be later modified by the setLabels method.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// A reference to a machine type which defines VM kind.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformProperty("machine_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MachineType { get; set; }

    /// <summary>
    /// Custom metadata to apply to this instance.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name specified for the Notebook instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of the VPC that this instance is in.
    /// Format: projects/{project_id}/global/networks/{network_id}
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The type of vNIC driver. Possible values: [&amp;quot;UNSPECIFIED_NIC_TYPE&amp;quot;, &amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    [TerraformProperty("nic_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NicType { get; set; }

    /// <summary>
    /// The notebook instance will not register with the proxy..
    /// </summary>
    [TerraformProperty("no_proxy_access")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoProxyAccess { get; set; }

    /// <summary>
    /// No public IP will be assigned to this instance.
    /// </summary>
    [TerraformProperty("no_public_ip")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoPublicIp { get; set; }

    /// <summary>
    /// If true, the data disk will not be auto deleted when deleting the instance.
    /// </summary>
    [TerraformProperty("no_remove_data_disk")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoRemoveDataDisk { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a
    /// notebook instance fully boots up. The path must be a URL
    /// or Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    [TerraformProperty("post_startup_script")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PostStartupScript { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The service account on this instance, giving access to other
    /// Google Cloud services. You can use any service account within
    /// the same project, but you must have the service account user
    /// permission to use the instance. If not specified,
    /// the Compute Engine default service account is used.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Optional. The URIs of service account scopes to be included in Compute Engine instances.
    /// If not specified, the following scopes are defined:
    /// - https://www.googleapis.com/auth/cloud-platform
    /// - https://www.googleapis.com/auth/userinfo.email
    /// </summary>
    [TerraformProperty("service_account_scopes")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> ServiceAccountScopes { get; set; }

    /// <summary>
    /// The name of the subnet that this instance is in.
    /// Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
    /// </summary>
    [TerraformProperty("subnet")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Subnet { get; set; }

    /// <summary>
    /// The Compute Engine tags to add to instance.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> Tags { get; set; }

    /// <summary>
    /// Instance update time.
    /// </summary>
    [TerraformProperty("update_time")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> UpdateTime { get; set; }

    /// <summary>
    /// Block for accelerator_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorConfig block(s) allowed")]
    [TerraformProperty("accelerator_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceAcceleratorConfigBlock>>? AcceleratorConfig { get; set; }

    /// <summary>
    /// Block for container_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    [TerraformProperty("container_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceContainerImageBlock>>? ContainerImage { get; set; }

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformProperty("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceReservationAffinityBlock>>? ReservationAffinity { get; set; }

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformProperty("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNotebooksInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vm_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    [TerraformProperty("vm_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceVmImageBlock>>? VmImage { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The proxy endpoint that is used to access the Jupyter notebook.
    /// Only returned when the resource is in a &#39;PROVISIONED&#39; state. If
    /// needed you can utilize &#39;terraform apply -refresh-only&#39; to await
    /// the population of this value.
    /// </summary>
    [TerraformProperty("proxy_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProxyUri { get; }

    /// <summary>
    /// The state of this instance.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}

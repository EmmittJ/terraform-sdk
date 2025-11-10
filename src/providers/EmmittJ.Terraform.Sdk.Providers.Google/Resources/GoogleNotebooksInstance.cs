using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerator_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceAcceleratorConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Count of cores of this accelerator.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreCount is required")]
    [TerraformPropertyName("core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CoreCount { get; set; }

    /// <summary>
    /// Type of this accelerator. Possible values: [&amp;quot;ACCELERATOR_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;NVIDIA_TESLA_K80&amp;quot;, &amp;quot;NVIDIA_TESLA_P100&amp;quot;, &amp;quot;NVIDIA_TESLA_V100&amp;quot;, &amp;quot;NVIDIA_TESLA_P4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4&amp;quot;, &amp;quot;NVIDIA_TESLA_T4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P100_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_P4_VWS&amp;quot;, &amp;quot;NVIDIA_TESLA_A100&amp;quot;, &amp;quot;TPU_V2&amp;quot;, &amp;quot;TPU_V3&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for container_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceContainerImageBlock : ITerraformBlock
{
    /// <summary>
    /// The path to the container image repository.
    /// For example: gcr.io/{project_id}/{imageName}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformPropertyName("repository")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Repository { get; set; }

    /// <summary>
    /// The tag of the container image. If not specified, this defaults to the latest tag.
    /// </summary>
    [TerraformPropertyName("tag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Tag { get; set; }

}

/// <summary>
/// Block type for reservation_affinity in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceReservationAffinityBlock : ITerraformBlock
{
    /// <summary>
    /// The type of Compute Reservation. Possible values: [&amp;quot;NO_RESERVATION&amp;quot;, &amp;quot;ANY_RESERVATION&amp;quot;, &amp;quot;SPECIFIC_RESERVATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumeReservationType is required")]
    [TerraformPropertyName("consume_reservation_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConsumeReservationType { get; set; }

    /// <summary>
    /// Corresponds to the label key of reservation resource.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// Corresponds to the label values of reservation resource.
    /// </summary>
    [TerraformPropertyName("values")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Block type for shielded_instance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceShieldedInstanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Defines whether the instance has integrity monitoring enabled. Enables monitoring and attestation of the
    /// boot integrity of the instance. The attestation is performed against the integrity policy baseline.
    /// This baseline is initially derived from the implicitly trusted boot image when the instance is created.
    /// Enabled by default.
    /// </summary>
    [TerraformPropertyName("enable_integrity_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableIntegrityMonitoring { get; set; }

    /// <summary>
    /// Defines whether the instance has Secure Boot enabled. Secure Boot helps ensure that the system only runs
    /// authentic software by verifying the digital signature of all boot components, and halting the boot process
    /// if signature verification fails.
    /// Disabled by default.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSecureBoot { get; set; }

    /// <summary>
    /// Defines whether the instance has the vTPM enabled.
    /// Enabled by default.
    /// </summary>
    [TerraformPropertyName("enable_vtpm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableVtpm { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNotebooksInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vm_image in .
/// Nesting mode: list
/// </summary>
public class GoogleNotebooksInstanceVmImageBlock : ITerraformBlock
{
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this family will be used.
    /// </summary>
    [TerraformPropertyName("image_family")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageFamily { get; set; }

    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    [TerraformPropertyName("image_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageName { get; set; }

    /// <summary>
    /// The name of the Google Cloud project that this VM image belongs to.
    /// Format: projects/{project_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformPropertyName("project")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Project { get; set; }

}

/// <summary>
/// Manages a google_notebooks_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNotebooksInstance : TerraformResource
{
    public GoogleNotebooksInstance(string name) : base("google_notebooks_instance", name)
    {
    }

    /// <summary>
    /// The size of the boot disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB). The minimum recommended value is 100 GB.
    /// If not specified, this defaults to 100.
    /// </summary>
    [TerraformPropertyName("boot_disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BootDiskSizeGb { get; set; }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    [TerraformPropertyName("boot_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BootDiskType { get; set; }

    /// <summary>
    /// Instance creation time
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CreateTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Specify a custom Cloud Storage path where the GPU driver is stored.
    /// If not specified, we&#39;ll automatically choose from official GPU drivers.
    /// </summary>
    [TerraformPropertyName("custom_gpu_driver_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomGpuDriverPath { get; set; }

    /// <summary>
    /// The size of the data disk in GB attached to this instance,
    /// up to a maximum of 64000 GB (64 TB).
    /// You can choose the size of the data disk based on how big your notebooks and data are.
    /// If not specified, this defaults to 100.
    /// </summary>
    [TerraformPropertyName("data_disk_size_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DataDiskSizeGb { get; set; }

    /// <summary>
    /// Possible disk types for notebook instances. Possible values: [&amp;quot;DISK_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;PD_STANDARD&amp;quot;, &amp;quot;PD_SSD&amp;quot;, &amp;quot;PD_BALANCED&amp;quot;, &amp;quot;PD_EXTREME&amp;quot;]
    /// </summary>
    [TerraformPropertyName("data_disk_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataDiskType { get; set; }

    /// <summary>
    /// Desired state of the Notebook Instance. Set this field to &#39;ACTIVE&#39; to start the Instance, and &#39;STOPPED&#39; to stop the Instance.
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DesiredState { get; set; }

    /// <summary>
    /// Disk encryption method used on the boot and data disks, defaults to GMEK. Possible values: [&amp;quot;DISK_ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;GMEK&amp;quot;, &amp;quot;CMEK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("disk_encryption")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskEncryption { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_encryption");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Whether the end user authorizes Google Cloud to install GPU driver
    /// on this instance. If this field is empty or set to false, the GPU driver
    /// won&#39;t be installed. Only applicable to instances with GPUs.
    /// </summary>
    [TerraformPropertyName("install_gpu_driver")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InstallGpuDriver { get; set; }

    /// <summary>
    /// The list of owners of this instance after creation.
    /// Format: alias@example.com.
    /// Currently supports one owner only.
    /// If not specified, all of the service account users of
    /// your VM instance&#39;s service account can use the instance.
    /// </summary>
    [TerraformPropertyName("instance_owners")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? InstanceOwners { get; set; }

    /// <summary>
    /// The KMS key used to encrypt the disks, only applicable if diskEncryption is CMEK.
    /// Format: projects/{project_id}/locations/{location}/keyRings/{key_ring_id}/cryptoKeys/{key_id}
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKey { get; set; }

    /// <summary>
    /// Labels to apply to this instance. These can be later modified by the setLabels method.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// A reference to the zone where the machine resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// A reference to a machine type which defines VM kind.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineType is required")]
    [TerraformPropertyName("machine_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MachineType { get; set; }

    /// <summary>
    /// Custom metadata to apply to this instance.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

    /// <summary>
    /// The name specified for the Notebook instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The name of the VPC that this instance is in.
    /// Format: projects/{project_id}/global/networks/{network_id}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Network { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The type of vNIC driver. Possible values: [&amp;quot;UNSPECIFIED_NIC_TYPE&amp;quot;, &amp;quot;VIRTIO_NET&amp;quot;, &amp;quot;GVNIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("nic_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NicType { get; set; }

    /// <summary>
    /// The notebook instance will not register with the proxy..
    /// </summary>
    [TerraformPropertyName("no_proxy_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoProxyAccess { get; set; }

    /// <summary>
    /// No public IP will be assigned to this instance.
    /// </summary>
    [TerraformPropertyName("no_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoPublicIp { get; set; }

    /// <summary>
    /// If true, the data disk will not be auto deleted when deleting the instance.
    /// </summary>
    [TerraformPropertyName("no_remove_data_disk")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? NoRemoveDataDisk { get; set; }

    /// <summary>
    /// Path to a Bash script that automatically runs after a
    /// notebook instance fully boots up. The path must be a URL
    /// or Cloud Storage path (gs://path-to-file/file-name).
    /// </summary>
    [TerraformPropertyName("post_startup_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostStartupScript { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The service account on this instance, giving access to other
    /// Google Cloud services. You can use any service account within
    /// the same project, but you must have the service account user
    /// permission to use the instance. If not specified,
    /// the Compute Engine default service account is used.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_account");

    /// <summary>
    /// Optional. The URIs of service account scopes to be included in Compute Engine instances.
    /// If not specified, the following scopes are defined:
    /// - https://www.googleapis.com/auth/cloud-platform
    /// - https://www.googleapis.com/auth/userinfo.email
    /// </summary>
    [TerraformPropertyName("service_account_scopes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ServiceAccountScopes { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "service_account_scopes");

    /// <summary>
    /// The name of the subnet that this instance is in.
    /// Format: projects/{project_id}/regions/{region}/subnetworks/{subnetwork_id}
    /// </summary>
    [TerraformPropertyName("subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Subnet { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet");

    /// <summary>
    /// The Compute Engine tags to add to instance.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Instance update time.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UpdateTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// Block for accelerator_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AcceleratorConfig block(s) allowed")]
    [TerraformPropertyName("accelerator_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceAcceleratorConfigBlock>>? AcceleratorConfig { get; set; } = new();

    /// <summary>
    /// Block for container_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerImage block(s) allowed")]
    [TerraformPropertyName("container_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceContainerImageBlock>>? ContainerImage { get; set; } = new();

    /// <summary>
    /// Block for reservation_affinity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationAffinity block(s) allowed")]
    [TerraformPropertyName("reservation_affinity")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceReservationAffinityBlock>>? ReservationAffinity { get; set; } = new();

    /// <summary>
    /// Block for shielded_instance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedInstanceConfig block(s) allowed")]
    [TerraformPropertyName("shielded_instance_config")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceShieldedInstanceConfigBlock>>? ShieldedInstanceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNotebooksInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vm_image.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VmImage block(s) allowed")]
    [TerraformPropertyName("vm_image")]
    public TerraformList<TerraformBlock<GoogleNotebooksInstanceVmImageBlock>>? VmImage { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The proxy endpoint that is used to access the Jupyter notebook.
    /// Only returned when the resource is in a &#39;PROVISIONED&#39; state. If
    /// needed you can utilize &#39;terraform apply -refresh-only&#39; to await
    /// the population of this value.
    /// </summary>
    [TerraformPropertyName("proxy_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProxyUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "proxy_uri");

    /// <summary>
    /// The state of this instance.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_persistent_disk_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock() : TerraformBlock("data_persistent_disk_spec")
{
    /// <summary>
    /// The disk size of the runtime in GB. If specified, the diskType must also be specified. The minimum size is 10GB and the maximum is 65536GB.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskSizeGb { get; set; }

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    [TerraformProperty("disk_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskType { get; set; }

}

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateEncryptionSpecBlock() : TerraformBlock("encryption_spec")
{
    /// <summary>
    /// The Cloud KMS encryption key (customer-managed encryption key) used to protect the runtime.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for euc_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateEucConfigBlock() : TerraformBlock("euc_config")
{
    /// <summary>
    /// Disable end user credential access for the runtime.
    /// </summary>
    [TerraformProperty("euc_disabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EucDisabled { get; set; }

}

/// <summary>
/// Block type for idle_shutdown_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateIdleShutdownConfigBlock() : TerraformBlock("idle_shutdown_config")
{
    /// <summary>
    /// The duration after which the runtime is automatically shut down. An input of 0s disables the idle shutdown feature, and a valid range is [10m, 24h].
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IdleTimeout { get; set; }

}

/// <summary>
/// Block type for machine_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateMachineSpecBlock() : TerraformBlock("machine_spec")
{
    /// <summary>
    /// The number of accelerators used by the runtime.
    /// </summary>
    [TerraformProperty("accelerator_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AcceleratorCount { get; set; }

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    [TerraformProperty("machine_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MachineType { get; set; }

}

/// <summary>
/// Block type for network_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateNetworkSpecBlock() : TerraformBlock("network_spec")
{
    /// <summary>
    /// Enable public internet access for the runtime.
    /// </summary>
    [TerraformProperty("enable_internet_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableInternetAccess { get; set; }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Subnetwork { get; set; }

}

/// <summary>
/// Block type for shielded_vm_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateShieldedVmConfigBlock() : TerraformBlock("shielded_vm_config")
{
    /// <summary>
    /// Enables secure boot for the runtime.
    /// </summary>
    [TerraformProperty("enable_secure_boot")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableSecureBoot { get; set; }

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateSoftwareConfigBlock() : TerraformBlock("software_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleColabRuntimeTemplateTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_colab_runtime_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleColabRuntimeTemplate : TerraformResource
{
    public GoogleColabRuntimeTemplate(string name) : base("google_colab_runtime_template", name)
    {
    }

    /// <summary>
    /// The description of the Runtime Template.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Labels { get; set; }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    [TerraformProperty("network_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NetworkTags { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for data_persistent_disk_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    [TerraformProperty("data_persistent_disk_spec")]
    public TerraformList<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock> DataPersistentDiskSpec { get; set; } = new();

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformProperty("encryption_spec")]
    public TerraformList<GoogleColabRuntimeTemplateEncryptionSpecBlock> EncryptionSpec { get; set; } = new();

    /// <summary>
    /// Block for euc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    [TerraformProperty("euc_config")]
    public TerraformList<GoogleColabRuntimeTemplateEucConfigBlock> EucConfig { get; set; } = new();

    /// <summary>
    /// Block for idle_shutdown_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    [TerraformProperty("idle_shutdown_config")]
    public TerraformList<GoogleColabRuntimeTemplateIdleShutdownConfigBlock> IdleShutdownConfig { get; set; } = new();

    /// <summary>
    /// Block for machine_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    [TerraformProperty("machine_spec")]
    public TerraformList<GoogleColabRuntimeTemplateMachineSpecBlock> MachineSpec { get; set; } = new();

    /// <summary>
    /// Block for network_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    [TerraformProperty("network_spec")]
    public TerraformList<GoogleColabRuntimeTemplateNetworkSpecBlock> NetworkSpec { get; set; } = new();

    /// <summary>
    /// Block for shielded_vm_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    [TerraformProperty("shielded_vm_config")]
    public TerraformList<GoogleColabRuntimeTemplateShieldedVmConfigBlock> ShieldedVmConfig { get; set; } = new();

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    [TerraformProperty("software_config")]
    public TerraformList<GoogleColabRuntimeTemplateSoftwareConfigBlock> SoftwareConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleColabRuntimeTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}

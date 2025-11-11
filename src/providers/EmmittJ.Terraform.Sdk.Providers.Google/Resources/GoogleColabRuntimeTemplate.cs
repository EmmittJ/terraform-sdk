using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_persistent_disk_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock
{
    /// <summary>
    /// The disk size of the runtime in GB. If specified, the diskType must also be specified. The minimum size is 10GB and the maximum is 65536GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskSizeGb { get; set; } = default!;

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskType { get; set; } = default!;

}

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEncryptionSpecBlock
{
    /// <summary>
    /// The Cloud KMS encryption key (customer-managed encryption key) used to protect the runtime.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for euc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEucConfigBlock
{
    /// <summary>
    /// Disable end user credential access for the runtime.
    /// </summary>
    [TerraformPropertyName("euc_disabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EucDisabled { get; set; } = default!;

}

/// <summary>
/// Block type for idle_shutdown_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateIdleShutdownConfigBlock
{
    /// <summary>
    /// The duration after which the runtime is automatically shut down. An input of 0s disables the idle shutdown feature, and a valid range is [10m, 24h].
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IdleTimeout { get; set; } = default!;

}

/// <summary>
/// Block type for machine_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateMachineSpecBlock
{
    /// <summary>
    /// The number of accelerators used by the runtime.
    /// </summary>
    [TerraformPropertyName("accelerator_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AcceleratorCount { get; set; } = default!;

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MachineType { get; set; } = default!;

}

/// <summary>
/// Block type for network_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateNetworkSpecBlock
{
    /// <summary>
    /// Enable public internet access for the runtime.
    /// </summary>
    [TerraformPropertyName("enable_internet_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableInternetAccess { get; set; }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Network { get; set; } = default!;

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subnetwork { get; set; }

}

/// <summary>
/// Block type for shielded_vm_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateShieldedVmConfigBlock
{
    /// <summary>
    /// Enables secure boot for the runtime.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableSecureBoot { get; set; } = default!;

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateSoftwareConfigBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTemplateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_colab_runtime_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabRuntimeTemplate : TerraformResource
{
    public GoogleColabRuntimeTemplate(string name) : base("google_colab_runtime_template", name)
    {
    }

    /// <summary>
    /// The description of the Runtime Template.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Labels { get; set; } = default!;

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    [TerraformPropertyName("network_tags")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NetworkTags { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for data_persistent_disk_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    [TerraformPropertyName("data_persistent_disk_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>>? DataPersistentDiskSpec { get; set; }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformPropertyName("encryption_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateEncryptionSpecBlock>>? EncryptionSpec { get; set; }

    /// <summary>
    /// Block for euc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    [TerraformPropertyName("euc_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateEucConfigBlock>>? EucConfig { get; set; }

    /// <summary>
    /// Block for idle_shutdown_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    [TerraformPropertyName("idle_shutdown_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>>? IdleShutdownConfig { get; set; }

    /// <summary>
    /// Block for machine_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    [TerraformPropertyName("machine_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateMachineSpecBlock>>? MachineSpec { get; set; }

    /// <summary>
    /// Block for network_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    [TerraformPropertyName("network_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateNetworkSpecBlock>>? NetworkSpec { get; set; }

    /// <summary>
    /// Block for shielded_vm_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    [TerraformPropertyName("shielded_vm_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateShieldedVmConfigBlock>>? ShieldedVmConfig { get; set; }

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    [TerraformPropertyName("software_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateSoftwareConfigBlock>>? SoftwareConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleColabRuntimeTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}

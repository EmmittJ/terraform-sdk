using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_persistent_disk_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock : ITerraformBlock
{
    /// <summary>
    /// The disk size of the runtime in GB. If specified, the diskType must also be specified. The minimum size is 10GB and the maximum is 65536GB.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_size_gb");

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    [TerraformPropertyName("disk_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_type");

}

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEncryptionSpecBlock : ITerraformBlock
{
    /// <summary>
    /// The Cloud KMS encryption key (customer-managed encryption key) used to protect the runtime.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for euc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEucConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Disable end user credential access for the runtime.
    /// </summary>
    [TerraformPropertyName("euc_disabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EucDisabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "euc_disabled");

}

/// <summary>
/// Block type for idle_shutdown_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateIdleShutdownConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The duration after which the runtime is automatically shut down. An input of 0s disables the idle shutdown feature, and a valid range is [10m, 24h].
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdleTimeout { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "idle_timeout");

}

/// <summary>
/// Block type for machine_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateMachineSpecBlock : ITerraformBlock
{
    /// <summary>
    /// The number of accelerators used by the runtime.
    /// </summary>
    [TerraformPropertyName("accelerator_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AcceleratorCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "accelerator_count");

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    [TerraformPropertyName("machine_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MachineType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "machine_type");

}

/// <summary>
/// Block type for network_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateNetworkSpecBlock : ITerraformBlock
{
    /// <summary>
    /// Enable public internet access for the runtime.
    /// </summary>
    [TerraformPropertyName("enable_internet_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableInternetAccess { get; set; }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Network { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "network");

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Subnetwork { get; set; }

}

/// <summary>
/// Block type for shielded_vm_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateShieldedVmConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Enables secure boot for the runtime.
    /// </summary>
    [TerraformPropertyName("enable_secure_boot")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableSecureBoot { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enable_secure_boot");

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateSoftwareConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTemplateTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    [TerraformPropertyName("network_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NetworkTags { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for data_persistent_disk_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    [TerraformPropertyName("data_persistent_disk_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>>? DataPersistentDiskSpec { get; set; } = new();

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    [TerraformPropertyName("encryption_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateEncryptionSpecBlock>>? EncryptionSpec { get; set; } = new();

    /// <summary>
    /// Block for euc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    [TerraformPropertyName("euc_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateEucConfigBlock>>? EucConfig { get; set; } = new();

    /// <summary>
    /// Block for idle_shutdown_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    [TerraformPropertyName("idle_shutdown_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>>? IdleShutdownConfig { get; set; } = new();

    /// <summary>
    /// Block for machine_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    [TerraformPropertyName("machine_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateMachineSpecBlock>>? MachineSpec { get; set; } = new();

    /// <summary>
    /// Block for network_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    [TerraformPropertyName("network_spec")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateNetworkSpecBlock>>? NetworkSpec { get; set; } = new();

    /// <summary>
    /// Block for shielded_vm_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    [TerraformPropertyName("shielded_vm_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateShieldedVmConfigBlock>>? ShieldedVmConfig { get; set; } = new();

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    [TerraformPropertyName("software_config")]
    public TerraformList<TerraformBlock<GoogleColabRuntimeTemplateSoftwareConfigBlock>>? SoftwareConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleColabRuntimeTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_persistent_disk_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock : TerraformBlock
{
    /// <summary>
    /// The disk size of the runtime in GB. If specified, the diskType must also be specified. The minimum size is 10GB and the maximum is 65536GB.
    /// </summary>
    public TerraformProperty<string>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<string>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        get => GetProperty<TerraformProperty<string>>("disk_type");
        set => WithProperty("disk_type", value);
    }

}

/// <summary>
/// Block type for encryption_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud KMS encryption key (customer-managed encryption key) used to protect the runtime.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for euc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEucConfigBlock : TerraformBlock
{
    /// <summary>
    /// Disable end user credential access for the runtime.
    /// </summary>
    public TerraformProperty<bool>? EucDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("euc_disabled");
        set => WithProperty("euc_disabled", value);
    }

}

/// <summary>
/// Block type for idle_shutdown_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateIdleShutdownConfigBlock : TerraformBlock
{
    /// <summary>
    /// The duration after which the runtime is automatically shut down. An input of 0s disables the idle shutdown feature, and a valid range is [10m, 24h].
    /// </summary>
    public TerraformProperty<string>? IdleTimeout
    {
        get => GetProperty<TerraformProperty<string>>("idle_timeout");
        set => WithProperty("idle_timeout", value);
    }

}

/// <summary>
/// Block type for machine_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateMachineSpecBlock : TerraformBlock
{
    /// <summary>
    /// The number of accelerators used by the runtime.
    /// </summary>
    public TerraformProperty<double>? AcceleratorCount
    {
        get => GetProperty<TerraformProperty<double>>("accelerator_count");
        set => WithProperty("accelerator_count", value);
    }

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        get => GetProperty<TerraformProperty<string>>("machine_type");
        set => WithProperty("machine_type", value);
    }

}

/// <summary>
/// Block type for network_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateNetworkSpecBlock : TerraformBlock
{
    /// <summary>
    /// Enable public internet access for the runtime.
    /// </summary>
    public TerraformProperty<bool>? EnableInternetAccess
    {
        get => GetProperty<TerraformProperty<bool>>("enable_internet_access");
        set => WithProperty("enable_internet_access", value);
    }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        get => GetProperty<TerraformProperty<string>>("subnetwork");
        set => WithProperty("subnetwork", value);
    }

}

/// <summary>
/// Block type for shielded_vm_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateShieldedVmConfigBlock : TerraformBlock
{
    /// <summary>
    /// Enables secure boot for the runtime.
    /// </summary>
    public TerraformProperty<bool>? EnableSecureBoot
    {
        get => GetProperty<TerraformProperty<bool>>("enable_secure_boot");
        set => WithProperty("enable_secure_boot", value);
    }

}

/// <summary>
/// Block type for software_config in .
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateSoftwareConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_colab_runtime_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleColabRuntimeTemplate : TerraformResource
{
    public GoogleColabRuntimeTemplate(string name) : base("google_colab_runtime_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The description of the Runtime Template.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    public List<TerraformProperty<string>>? NetworkTags
    {
        get => GetProperty<List<TerraformProperty<string>>>("network_tags");
        set => this.WithProperty("network_tags", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for data_persistent_disk_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>? DataPersistentDiskSpec
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>>("data_persistent_disk_spec");
        set => this.WithProperty("data_persistent_disk_spec", value);
    }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateEncryptionSpecBlock>>("encryption_spec");
        set => this.WithProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for euc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateEucConfigBlock>? EucConfig
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateEucConfigBlock>>("euc_config");
        set => this.WithProperty("euc_config", value);
    }

    /// <summary>
    /// Block for idle_shutdown_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>? IdleShutdownConfig
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>>("idle_shutdown_config");
        set => this.WithProperty("idle_shutdown_config", value);
    }

    /// <summary>
    /// Block for machine_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateMachineSpecBlock>? MachineSpec
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateMachineSpecBlock>>("machine_spec");
        set => this.WithProperty("machine_spec", value);
    }

    /// <summary>
    /// Block for network_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateNetworkSpecBlock>? NetworkSpec
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateNetworkSpecBlock>>("network_spec");
        set => this.WithProperty("network_spec", value);
    }

    /// <summary>
    /// Block for shielded_vm_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateShieldedVmConfigBlock>? ShieldedVmConfig
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateShieldedVmConfigBlock>>("shielded_vm_config");
        set => this.WithProperty("shielded_vm_config", value);
    }

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetProperty<List<GoogleColabRuntimeTemplateSoftwareConfigBlock>>("software_config");
        set => this.WithProperty("software_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabRuntimeTemplateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleColabRuntimeTemplateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}

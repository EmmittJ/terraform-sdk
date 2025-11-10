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
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    public TerraformProperty<string>? DiskType
    {
        set => SetProperty("disk_type", value);
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
        set => SetProperty("kms_key_name", value);
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
        set => SetProperty("euc_disabled", value);
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
        set => SetProperty("idle_timeout", value);
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
        set => SetProperty("accelerator_count", value);
    }

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        set => SetProperty("accelerator_type", value);
    }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    public TerraformProperty<string>? MachineType
    {
        set => SetProperty("machine_type", value);
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
        set => SetProperty("enable_internet_access", value);
    }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        set => SetProperty("subnetwork", value);
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
        set => SetProperty("enable_secure_boot", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_tags");
        SetOutput("project");
    }

    /// <summary>
    /// The description of the Runtime Template.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    public List<TerraformProperty<string>> NetworkTags
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("network_tags");
        set => SetProperty("network_tags", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for data_persistent_disk_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>? DataPersistentDiskSpec
    {
        set => SetProperty("data_persistent_disk_spec", value);
    }

    /// <summary>
    /// Block for encryption_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateEncryptionSpecBlock>? EncryptionSpec
    {
        set => SetProperty("encryption_spec", value);
    }

    /// <summary>
    /// Block for euc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateEucConfigBlock>? EucConfig
    {
        set => SetProperty("euc_config", value);
    }

    /// <summary>
    /// Block for idle_shutdown_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>? IdleShutdownConfig
    {
        set => SetProperty("idle_shutdown_config", value);
    }

    /// <summary>
    /// Block for machine_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateMachineSpecBlock>? MachineSpec
    {
        set => SetProperty("machine_spec", value);
    }

    /// <summary>
    /// Block for network_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    public List<GoogleColabRuntimeTemplateNetworkSpecBlock>? NetworkSpec
    {
        set => SetProperty("network_spec", value);
    }

    /// <summary>
    /// Block for shielded_vm_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateShieldedVmConfigBlock>? ShieldedVmConfig
    {
        set => SetProperty("shielded_vm_config", value);
    }

    /// <summary>
    /// Block for software_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public List<GoogleColabRuntimeTemplateSoftwareConfigBlock>? SoftwareConfig
    {
        set => SetProperty("software_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleColabRuntimeTemplateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

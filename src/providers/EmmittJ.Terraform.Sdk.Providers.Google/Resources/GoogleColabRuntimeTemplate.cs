using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for data_persistent_disk_spec in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_persistent_disk_spec";

    /// <summary>
    /// The disk size of the runtime in GB. If specified, the diskType must also be specified. The minimum size is 10GB and the maximum is 65536GB.
    /// </summary>
    public TerraformValue<string> DiskSizeGb
    {
        get => GetArgument<TerraformValue<string>>("disk_size_gb") ?? CreateReference("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The type of the persistent disk.
    /// </summary>
    public TerraformValue<string> DiskType
    {
        get => GetArgument<TerraformValue<string>>("disk_type") ?? CreateReference("disk_type");
        set => SetArgument("disk_type", value);
    }

}


/// <summary>
/// Block type for encryption_spec in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEncryptionSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_spec";

    /// <summary>
    /// The Cloud KMS encryption key (customer-managed encryption key) used to protect the runtime.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for euc_config in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateEucConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "euc_config";

    /// <summary>
    /// Disable end user credential access for the runtime.
    /// </summary>
    public TerraformValue<bool> EucDisabled
    {
        get => GetArgument<TerraformValue<bool>>("euc_disabled") ?? CreateReference("euc_disabled");
        set => SetArgument("euc_disabled", value);
    }

}


/// <summary>
/// Block type for idle_shutdown_config in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateIdleShutdownConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle_shutdown_config";

    /// <summary>
    /// The duration after which the runtime is automatically shut down. An input of 0s disables the idle shutdown feature, and a valid range is [10m, 24h].
    /// </summary>
    public TerraformValue<string> IdleTimeout
    {
        get => GetArgument<TerraformValue<string>>("idle_timeout") ?? CreateReference("idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

}


/// <summary>
/// Block type for machine_spec in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateMachineSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "machine_spec";

    /// <summary>
    /// The number of accelerators used by the runtime.
    /// </summary>
    public TerraformValue<double> AcceleratorCount
    {
        get => GetArgument<TerraformValue<double>>("accelerator_count") ?? CreateReference("accelerator_count");
        set => SetArgument("accelerator_count", value);
    }

    /// <summary>
    /// The type of hardware accelerator used by the runtime. If specified, acceleratorCount must also be specified.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => GetArgument<TerraformValue<string>>("accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The Compute Engine machine type selected for the runtime.
    /// </summary>
    public TerraformValue<string> MachineType
    {
        get => GetArgument<TerraformValue<string>>("machine_type") ?? CreateReference("machine_type");
        set => SetArgument("machine_type", value);
    }

}


/// <summary>
/// Block type for network_spec in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateNetworkSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_spec";

    /// <summary>
    /// Enable public internet access for the runtime.
    /// </summary>
    public TerraformValue<bool>? EnableInternetAccess
    {
        get => GetArgument<TerraformValue<bool>>("enable_internet_access");
        set => SetArgument("enable_internet_access", value);
    }

    /// <summary>
    /// The name of the VPC that this runtime is in.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? CreateReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The name of the subnetwork that this runtime is in.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}


/// <summary>
/// Block type for shielded_vm_config in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateShieldedVmConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shielded_vm_config";

    /// <summary>
    /// Enables secure boot for the runtime.
    /// </summary>
    public TerraformValue<bool> EnableSecureBoot
    {
        get => GetArgument<TerraformValue<bool>>("enable_secure_boot") ?? CreateReference("enable_secure_boot");
        set => SetArgument("enable_secure_boot", value);
    }

}


/// <summary>
/// Block type for software_config in GoogleColabRuntimeTemplate.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateSoftwareConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_config";

    /// <summary>
    /// Env block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleColabRuntimeTemplateSoftwareConfigBlockEnvBlock>? Env
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateSoftwareConfigBlockEnvBlock>>("env");
        set => SetArgument("env", value);
    }

}

/// <summary>
/// Block type for env in GoogleColabRuntimeTemplateSoftwareConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleColabRuntimeTemplateSoftwareConfigBlockEnvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "env";

    /// <summary>
    /// Name of the environment variable. Must be a valid C identifier.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Variables that reference a $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleColabRuntimeTemplate.
/// Nesting mode: single
/// </summary>
public class GoogleColabRuntimeTemplateTimeoutsBlock : TerraformBlock
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
/// Represents a google_colab_runtime_template Terraform resource.
/// Manages a google_colab_runtime_template resource.
/// </summary>
public partial class GoogleColabRuntimeTemplate(string name) : TerraformResource("google_colab_runtime_template", name)
{
    /// <summary>
    /// The description of the Runtime Template.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Required. The display name of the Runtime Template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels to identify and group the runtime template.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => GetArgument<TerraformMap<string>>("labels") ?? CreateReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the resource: https://cloud.google.com/colab/docs/locations
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the Runtime Template
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Applies the given Compute Engine tags to the runtime.
    /// </summary>
    public TerraformList<string>? NetworkTags
    {
        get => GetArgument<TerraformList<string>>("network_tags");
        set => SetArgument("network_tags", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// DataPersistentDiskSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataPersistentDiskSpec block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>? DataPersistentDiskSpec
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateDataPersistentDiskSpecBlock>>("data_persistent_disk_spec");
        set => SetArgument("data_persistent_disk_spec", value);
    }

    /// <summary>
    /// EncryptionSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionSpec block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateEncryptionSpecBlock>? EncryptionSpec
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateEncryptionSpecBlock>>("encryption_spec");
        set => SetArgument("encryption_spec", value);
    }

    /// <summary>
    /// EucConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EucConfig block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateEucConfigBlock>? EucConfig
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateEucConfigBlock>>("euc_config");
        set => SetArgument("euc_config", value);
    }

    /// <summary>
    /// IdleShutdownConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdleShutdownConfig block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>? IdleShutdownConfig
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateIdleShutdownConfigBlock>>("idle_shutdown_config");
        set => SetArgument("idle_shutdown_config", value);
    }

    /// <summary>
    /// MachineSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MachineSpec block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateMachineSpecBlock>? MachineSpec
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateMachineSpecBlock>>("machine_spec");
        set => SetArgument("machine_spec", value);
    }

    /// <summary>
    /// NetworkSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSpec block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateNetworkSpecBlock>? NetworkSpec
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateNetworkSpecBlock>>("network_spec");
        set => SetArgument("network_spec", value);
    }

    /// <summary>
    /// ShieldedVmConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShieldedVmConfig block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateShieldedVmConfigBlock>? ShieldedVmConfig
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateShieldedVmConfigBlock>>("shielded_vm_config");
        set => SetArgument("shielded_vm_config", value);
    }

    /// <summary>
    /// SoftwareConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareConfig block(s) allowed")]
    public TerraformList<GoogleColabRuntimeTemplateSoftwareConfigBlock>? SoftwareConfig
    {
        get => GetArgument<TerraformList<GoogleColabRuntimeTemplateSoftwareConfigBlock>>("software_config");
        set => SetArgument("software_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleColabRuntimeTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleColabRuntimeTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

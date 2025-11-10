using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// The evaluation_interval attribute.
    /// </summary>
    public TerraformProperty<string>? EvaluationInterval
    {
        set => SetProperty("evaluation_interval", value);
    }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    public required TerraformProperty<string> Formula
    {
        set => SetProperty("formula", value);
    }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    public required TerraformProperty<string> StoreLocation
    {
        set => SetProperty("store_location", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    public TerraformProperty<string>? StoreName
    {
        set => SetProperty("store_name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Visibility
    {
        set => SetProperty("visibility", value);
    }

}

/// <summary>
/// Block type for container_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolContainerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The container_image_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ContainerImageNames
    {
        set => SetProperty("container_image_names", value);
    }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    public List<TerraformProperty<object>>? ContainerRegistries
    {
        set => SetProperty("container_registries", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for data_disks in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDataDisksBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformProperty<string>? Caching
    {
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformProperty<double> DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        set => SetProperty("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
    }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The disk_encryption_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionTarget is required")]
    public required TerraformProperty<string> DiskEncryptionTarget
    {
        set => SetProperty("disk_encryption_target", value);
    }

}

/// <summary>
/// Block type for extensions in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgradeMinorVersion
    {
        set => SetProperty("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticUpgradeEnabled
    {
        set => SetProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        set => SetProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProvisionAfterExtensions
    {
        set => SetProperty("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    public TerraformProperty<string>? SettingsJson
    {
        set => SetProperty("settings_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformProperty<string>? TypeHandlerVersion
    {
        set => SetProperty("type_handler_version", value);
    }

}

/// <summary>
/// Block type for fixed_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolFixedScaleBlock : TerraformBlock
{
    /// <summary>
    /// The node_deallocation_method attribute.
    /// </summary>
    public TerraformProperty<string>? NodeDeallocationMethod
    {
        set => SetProperty("node_deallocation_method", value);
    }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? ResizeTimeout
    {
        set => SetProperty("resize_timeout", value);
    }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? TargetDedicatedNodes
    {
        set => SetProperty("target_dedicated_nodes", value);
    }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? TargetLowPriorityNodes
    {
        set => SetProperty("target_low_priority_nodes", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for mount in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AcceleratedNetworkingEnabled
    {
        set => SetProperty("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DynamicVnetAssignmentScope
    {
        set => SetProperty("dynamic_vnet_assignment_scope", value);
    }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    public TerraformProperty<string>? PublicAddressProvisioningType
    {
        set => SetProperty("public_address_provisioning_type", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PublicIps
    {
        set => SetProperty("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for node_placement in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNodePlacementBlock : TerraformBlock
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        set => SetProperty("policy", value);
    }

}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HostEncryptionEnabled
    {
        set => SetProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecureBootEnabled
    {
        set => SetProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityType
    {
        set => SetProperty("security_type", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VtpmEnabled
    {
        set => SetProperty("vtpm_enabled", value);
    }

}

/// <summary>
/// Block type for start_task in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlock : TerraformBlock
{
    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLine is required")]
    public required TerraformProperty<string> CommandLine
    {
        set => SetProperty("command_line", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CommonEnvironmentProperties
    {
        set => SetProperty("common_environment_properties", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformProperty<double>? TaskRetryMaximum
    {
        set => SetProperty("task_retry_maximum", value);
    }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForSuccess
    {
        set => SetProperty("wait_for_success", value);
    }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStorageImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformProperty<string>? Offer
    {
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for task_scheduling_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolTaskSchedulingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The node_fill_type attribute.
    /// </summary>
    public TerraformProperty<string>? NodeFillType
    {
        set => SetProperty("node_fill_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Block type for user_accounts in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlock : TerraformBlock
{
    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElevationLevel is required")]
    public required TerraformProperty<string> ElevationLevel
    {
        set => SetProperty("elevation_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolWindowsBlock : TerraformBlock
{
    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutomaticUpdates
    {
        set => SetProperty("enable_automatic_updates", value);
    }

}

/// <summary>
/// Manages a azurerm_batch_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBatchPool : TerraformResource
{
    public AzurermBatchPool(string name) : base("azurerm_batch_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_name");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("inter_node_communication");
        SetOutput("license_type");
        SetOutput("max_tasks_per_node");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("node_agent_sku_id");
        SetOutput("os_disk_placement");
        SetOutput("resource_group_name");
        SetOutput("stop_pending_resize_operation");
        SetOutput("target_node_communication_mode");
        SetOutput("vm_size");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
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
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformProperty<string> InterNodeCommunication
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inter_node_communication");
        set => SetProperty("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformProperty<double> MaxTasksPerNode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_tasks_per_node");
        set => SetProperty("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    public required TerraformProperty<string> NodeAgentSkuId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_agent_sku_id");
        set => SetProperty("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformProperty<string> OsDiskPlacement
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_disk_placement");
        set => SetProperty("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformProperty<bool> StopPendingResizeOperation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("stop_pending_resize_operation");
        set => SetProperty("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformProperty<string> TargetNodeCommunicationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_node_communication_mode");
        set => SetProperty("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vm_size");
        set => SetProperty("vm_size", value);
    }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public List<AzurermBatchPoolAutoScaleBlock>? AutoScale
    {
        set => SetProperty("auto_scale", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolCertificateBlock>? Certificate
    {
        set => SetProperty("certificate", value);
    }

    /// <summary>
    /// Block for container_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public List<AzurermBatchPoolContainerConfigurationBlock>? ContainerConfiguration
    {
        set => SetProperty("container_configuration", value);
    }

    /// <summary>
    /// Block for data_disks.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolDataDisksBlock>? DataDisks
    {
        set => SetProperty("data_disks", value);
    }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolDiskEncryptionBlock>? DiskEncryption
    {
        set => SetProperty("disk_encryption", value);
    }

    /// <summary>
    /// Block for extensions.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolExtensionsBlock>? Extensions
    {
        set => SetProperty("extensions", value);
    }

    /// <summary>
    /// Block for fixed_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    public List<AzurermBatchPoolFixedScaleBlock>? FixedScale
    {
        set => SetProperty("fixed_scale", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermBatchPoolIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for mount.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolMountBlock>? Mount
    {
        set => SetProperty("mount", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AzurermBatchPoolNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for node_placement.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolNodePlacementBlock>? NodePlacement
    {
        set => SetProperty("node_placement", value);
    }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public List<AzurermBatchPoolSecurityProfileBlock>? SecurityProfile
    {
        set => SetProperty("security_profile", value);
    }

    /// <summary>
    /// Block for start_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    public List<AzurermBatchPoolStartTaskBlock>? StartTask
    {
        set => SetProperty("start_task", value);
    }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public List<AzurermBatchPoolStorageImageReferenceBlock>? StorageImageReference
    {
        set => SetProperty("storage_image_reference", value);
    }

    /// <summary>
    /// Block for task_scheduling_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolTaskSchedulingPolicyBlock>? TaskSchedulingPolicy
    {
        set => SetProperty("task_scheduling_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchPoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_accounts.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolUserAccountsBlock>? UserAccounts
    {
        set => SetProperty("user_accounts", value);
    }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolWindowsBlock>? Windows
    {
        set => SetProperty("windows", value);
    }

}

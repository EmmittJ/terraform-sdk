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
        get => GetProperty<TerraformProperty<string>>("evaluation_interval");
        set => WithProperty("evaluation_interval", value);
    }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    public required TerraformProperty<string> Formula
    {
        get => GetProperty<TerraformProperty<string>>("formula");
        set => WithProperty("formula", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    public required TerraformProperty<string> StoreLocation
    {
        get => GetProperty<TerraformProperty<string>>("store_location");
        set => WithProperty("store_location", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    public TerraformProperty<string>? StoreName
    {
        get => GetProperty<TerraformProperty<string>>("store_name");
        set => WithProperty("store_name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Visibility
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("visibility");
        set => WithProperty("visibility", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("container_image_names");
        set => WithProperty("container_image_names", value);
    }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    public List<TerraformProperty<object>>? ContainerRegistries
    {
        get => GetProperty<List<TerraformProperty<object>>>("container_registries");
        set => WithProperty("container_registries", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformProperty<double> DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformProperty<double> Lun
    {
        get => GetProperty<TerraformProperty<double>>("lun");
        set => WithProperty("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
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
        get => GetProperty<TerraformProperty<string>>("disk_encryption_target");
        set => WithProperty("disk_encryption_target", value);
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
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade_minor_version");
        set => WithProperty("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticUpgradeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_upgrade_enabled");
        set => WithProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        get => GetProperty<TerraformProperty<string>>("protected_settings");
        set => WithProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ProvisionAfterExtensions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("provision_after_extensions");
        set => WithProperty("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    public TerraformProperty<string>? SettingsJson
    {
        get => GetProperty<TerraformProperty<string>>("settings_json");
        set => WithProperty("settings_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformProperty<string>? TypeHandlerVersion
    {
        get => GetProperty<TerraformProperty<string>>("type_handler_version");
        set => WithProperty("type_handler_version", value);
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
        get => GetProperty<TerraformProperty<string>>("node_deallocation_method");
        set => WithProperty("node_deallocation_method", value);
    }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    public TerraformProperty<string>? ResizeTimeout
    {
        get => GetProperty<TerraformProperty<string>>("resize_timeout");
        set => WithProperty("resize_timeout", value);
    }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? TargetDedicatedNodes
    {
        get => GetProperty<TerraformProperty<double>>("target_dedicated_nodes");
        set => WithProperty("target_dedicated_nodes", value);
    }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    public TerraformProperty<double>? TargetLowPriorityNodes
    {
        get => GetProperty<TerraformProperty<double>>("target_low_priority_nodes");
        set => WithProperty("target_low_priority_nodes", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("accelerated_networking_enabled");
        set => WithProperty("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    public TerraformProperty<string>? DynamicVnetAssignmentScope
    {
        get => GetProperty<TerraformProperty<string>>("dynamic_vnet_assignment_scope");
        set => WithProperty("dynamic_vnet_assignment_scope", value);
    }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    public TerraformProperty<string>? PublicAddressProvisioningType
    {
        get => GetProperty<TerraformProperty<string>>("public_address_provisioning_type");
        set => WithProperty("public_address_provisioning_type", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? PublicIps
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("public_ips");
        set => WithProperty("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<TerraformProperty<string>>("policy");
        set => WithProperty("policy", value);
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
        get => GetProperty<TerraformProperty<bool>>("host_encryption_enabled");
        set => WithProperty("host_encryption_enabled", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecureBootEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secure_boot_enabled");
        set => WithProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityType
    {
        get => GetProperty<TerraformProperty<string>>("security_type");
        set => WithProperty("security_type", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VtpmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vtpm_enabled");
        set => WithProperty("vtpm_enabled", value);
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
        get => GetProperty<TerraformProperty<string>>("command_line");
        set => WithProperty("command_line", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CommonEnvironmentProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("common_environment_properties");
        set => WithProperty("common_environment_properties", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformProperty<double>? TaskRetryMaximum
    {
        get => GetProperty<TerraformProperty<double>>("task_retry_maximum");
        set => WithProperty("task_retry_maximum", value);
    }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForSuccess
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_success");
        set => WithProperty("wait_for_success", value);
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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformProperty<string>? Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
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
        get => GetProperty<TerraformProperty<string>>("node_fill_type");
        set => WithProperty("node_fill_type", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        get => GetProperty<TerraformProperty<string>>("elevation_level");
        set => WithProperty("elevation_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
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
        get => GetProperty<TerraformProperty<bool>>("enable_automatic_updates");
        set => WithProperty("enable_automatic_updates", value);
    }

}

/// <summary>
/// Manages a azurerm_batch_pool resource.
/// </summary>
public class AzurermBatchPool : TerraformResource
{
    public AzurermBatchPool(string name) : base("azurerm_batch_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
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
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformProperty<string>? InterNodeCommunication
    {
        get => GetProperty<TerraformProperty<string>>("inter_node_communication");
        set => this.WithProperty("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTasksPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_tasks_per_node");
        set => this.WithProperty("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    public required TerraformProperty<string> NodeAgentSkuId
    {
        get => GetProperty<TerraformProperty<string>>("node_agent_sku_id");
        set => this.WithProperty("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskPlacement
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_placement");
        set => this.WithProperty("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformProperty<bool>? StopPendingResizeOperation
    {
        get => GetProperty<TerraformProperty<bool>>("stop_pending_resize_operation");
        set => this.WithProperty("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNodeCommunicationMode
    {
        get => GetProperty<TerraformProperty<string>>("target_node_communication_mode");
        set => this.WithProperty("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformProperty<string> VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public List<AzurermBatchPoolAutoScaleBlock>? AutoScale
    {
        get => GetProperty<List<AzurermBatchPoolAutoScaleBlock>>("auto_scale");
        set => this.WithProperty("auto_scale", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolCertificateBlock>? Certificate
    {
        get => GetProperty<List<AzurermBatchPoolCertificateBlock>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// Block for container_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public List<AzurermBatchPoolContainerConfigurationBlock>? ContainerConfiguration
    {
        get => GetProperty<List<AzurermBatchPoolContainerConfigurationBlock>>("container_configuration");
        set => this.WithProperty("container_configuration", value);
    }

    /// <summary>
    /// Block for data_disks.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolDataDisksBlock>? DataDisks
    {
        get => GetProperty<List<AzurermBatchPoolDataDisksBlock>>("data_disks");
        set => this.WithProperty("data_disks", value);
    }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolDiskEncryptionBlock>? DiskEncryption
    {
        get => GetProperty<List<AzurermBatchPoolDiskEncryptionBlock>>("disk_encryption");
        set => this.WithProperty("disk_encryption", value);
    }

    /// <summary>
    /// Block for extensions.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolExtensionsBlock>? Extensions
    {
        get => GetProperty<List<AzurermBatchPoolExtensionsBlock>>("extensions");
        set => this.WithProperty("extensions", value);
    }

    /// <summary>
    /// Block for fixed_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    public List<AzurermBatchPoolFixedScaleBlock>? FixedScale
    {
        get => GetProperty<List<AzurermBatchPoolFixedScaleBlock>>("fixed_scale");
        set => this.WithProperty("fixed_scale", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermBatchPoolIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermBatchPoolIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for mount.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolMountBlock>? Mount
    {
        get => GetProperty<List<AzurermBatchPoolMountBlock>>("mount");
        set => this.WithProperty("mount", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AzurermBatchPoolNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AzurermBatchPoolNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for node_placement.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolNodePlacementBlock>? NodePlacement
    {
        get => GetProperty<List<AzurermBatchPoolNodePlacementBlock>>("node_placement");
        set => this.WithProperty("node_placement", value);
    }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public List<AzurermBatchPoolSecurityProfileBlock>? SecurityProfile
    {
        get => GetProperty<List<AzurermBatchPoolSecurityProfileBlock>>("security_profile");
        set => this.WithProperty("security_profile", value);
    }

    /// <summary>
    /// Block for start_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    public List<AzurermBatchPoolStartTaskBlock>? StartTask
    {
        get => GetProperty<List<AzurermBatchPoolStartTaskBlock>>("start_task");
        set => this.WithProperty("start_task", value);
    }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public List<AzurermBatchPoolStorageImageReferenceBlock>? StorageImageReference
    {
        get => GetProperty<List<AzurermBatchPoolStorageImageReferenceBlock>>("storage_image_reference");
        set => this.WithProperty("storage_image_reference", value);
    }

    /// <summary>
    /// Block for task_scheduling_policy.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolTaskSchedulingPolicyBlock>? TaskSchedulingPolicy
    {
        get => GetProperty<List<AzurermBatchPoolTaskSchedulingPolicyBlock>>("task_scheduling_policy");
        set => this.WithProperty("task_scheduling_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBatchPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_accounts.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolUserAccountsBlock>? UserAccounts
    {
        get => GetProperty<List<AzurermBatchPoolUserAccountsBlock>>("user_accounts");
        set => this.WithProperty("user_accounts", value);
    }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermBatchPoolWindowsBlock>? Windows
    {
        get => GetProperty<List<AzurermBatchPoolWindowsBlock>>("windows");
        set => this.WithProperty("windows", value);
    }

}

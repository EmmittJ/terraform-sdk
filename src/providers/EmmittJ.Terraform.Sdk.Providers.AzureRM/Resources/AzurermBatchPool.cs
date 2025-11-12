using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolAutoScaleBlock() : TerraformBlock("auto_scale")
{
    /// <summary>
    /// The evaluation_interval attribute.
    /// </summary>
    [TerraformProperty("evaluation_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvaluationInterval { get; set; }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    [TerraformProperty("formula")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Formula { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolCertificateBlock() : TerraformBlock("certificate")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    [TerraformProperty("store_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StoreLocation { get; set; }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [TerraformProperty("store_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StoreName { get; set; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Visibility { get; set; }

}

/// <summary>
/// Block type for container_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolContainerConfigurationBlock() : TerraformBlock("container_configuration")
{
    /// <summary>
    /// The container_image_names attribute.
    /// </summary>
    [TerraformProperty("container_image_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ContainerImageNames { get; set; }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    [TerraformProperty("container_registries")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<object>? ContainerRegistries { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for data_disks in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolDataDisksBlock() : TerraformBlock("data_disks")
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformProperty("caching")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Caching { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformProperty("disk_size_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformProperty("lun")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformProperty("storage_account_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountType { get; set; }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolDiskEncryptionBlock() : TerraformBlock("disk_encryption")
{
    /// <summary>
    /// The disk_encryption_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionTarget is required")]
    [TerraformProperty("disk_encryption_target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DiskEncryptionTarget { get; set; }

}

/// <summary>
/// Block type for extensions in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolExtensionsBlock() : TerraformBlock("extensions")
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformProperty("auto_upgrade_minor_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformProperty("protected_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformProperty("provision_after_extensions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformProperty("publisher")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    [TerraformProperty("settings_json")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SettingsJson { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [TerraformProperty("type_handler_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for fixed_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolFixedScaleBlock() : TerraformBlock("fixed_scale")
{
    /// <summary>
    /// The node_deallocation_method attribute.
    /// </summary>
    [TerraformProperty("node_deallocation_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NodeDeallocationMethod { get; set; }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    [TerraformProperty("resize_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResizeTimeout { get; set; }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    [TerraformProperty("target_dedicated_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetDedicatedNodes { get; set; }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    [TerraformProperty("target_low_priority_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetLowPriorityNodes { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for mount in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolMountBlock() : TerraformBlock("mount")
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolNetworkConfigurationBlock() : TerraformBlock("network_configuration")
{
    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformProperty("accelerated_networking_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AcceleratedNetworkingEnabled { get; set; }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    [TerraformProperty("dynamic_vnet_assignment_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DynamicVnetAssignmentScope { get; set; }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    [TerraformProperty("public_address_provisioning_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicAddressProvisioningType { get; set; }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformProperty("public_ips")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? PublicIps { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for node_placement in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolNodePlacementBlock() : TerraformBlock("node_placement")
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolSecurityProfileBlock() : TerraformBlock("security_profile")
{
    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("host_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? HostEncryptionEnabled { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformProperty("secure_boot_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformProperty("security_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityType { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformProperty("vtpm_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VtpmEnabled { get; set; }

}

/// <summary>
/// Block type for start_task in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolStartTaskBlock() : TerraformBlock("start_task")
{
    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLine is required")]
    [TerraformProperty("command_line")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CommandLine { get; set; }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    [TerraformProperty("common_environment_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CommonEnvironmentProperties { get; set; }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    [TerraformProperty("task_retry_maximum")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TaskRetryMaximum { get; set; }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    [TerraformProperty("wait_for_success")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForSuccess { get; set; }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolStorageImageReferenceBlock() : TerraformBlock("storage_image_reference")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformProperty("offer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformProperty("publisher")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for task_scheduling_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolTaskSchedulingPolicyBlock() : TerraformBlock("task_scheduling_policy")
{
    /// <summary>
    /// The node_fill_type attribute.
    /// </summary>
    [TerraformProperty("node_fill_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeFillType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBatchPoolTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_accounts in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolUserAccountsBlock() : TerraformBlock("user_accounts")
{
    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElevationLevel is required")]
    [TerraformProperty("elevation_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ElevationLevel { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public partial class AzurermBatchPoolWindowsBlock() : TerraformBlock("windows")
{
    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [TerraformProperty("enable_automatic_updates")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAutomaticUpdates { get; set; }

}

/// <summary>
/// Manages a azurerm_batch_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermBatchPool : TerraformResource
{
    public AzurermBatchPool(string name) : base("azurerm_batch_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformProperty("inter_node_communication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InterNodeCommunication { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformProperty("max_tasks_per_node")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxTasksPerNode { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    [TerraformProperty("node_agent_sku_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeAgentSkuId { get; set; }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformProperty("os_disk_placement")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsDiskPlacement { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    [TerraformProperty("stop_pending_resize_operation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StopPendingResizeOperation { get; set; }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    [TerraformProperty("target_node_communication_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetNodeCommunicationMode { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformProperty("vm_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformProperty("auto_scale")]
    public TerraformList<AzurermBatchPoolAutoScaleBlock> AutoScale { get; set; } = new();

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("certificate")]
    public TerraformList<AzurermBatchPoolCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// Block for container_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    [TerraformProperty("container_configuration")]
    public TerraformList<AzurermBatchPoolContainerConfigurationBlock> ContainerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for data_disks.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_disks")]
    public TerraformList<AzurermBatchPoolDataDisksBlock> DataDisks { get; set; } = new();

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("disk_encryption")]
    public TerraformList<AzurermBatchPoolDiskEncryptionBlock> DiskEncryption { get; set; } = new();

    /// <summary>
    /// Block for extensions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("extensions")]
    public TerraformList<AzurermBatchPoolExtensionsBlock> Extensions { get; set; } = new();

    /// <summary>
    /// Block for fixed_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    [TerraformProperty("fixed_scale")]
    public TerraformList<AzurermBatchPoolFixedScaleBlock> FixedScale { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermBatchPoolIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for mount.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("mount")]
    public TerraformList<AzurermBatchPoolMountBlock> Mount { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public TerraformList<AzurermBatchPoolNetworkConfigurationBlock> NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for node_placement.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("node_placement")]
    public TerraformList<AzurermBatchPoolNodePlacementBlock> NodePlacement { get; set; } = new();

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    [TerraformProperty("security_profile")]
    public TerraformList<AzurermBatchPoolSecurityProfileBlock> SecurityProfile { get; set; } = new();

    /// <summary>
    /// Block for start_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    [TerraformProperty("start_task")]
    public TerraformList<AzurermBatchPoolStartTaskBlock> StartTask { get; set; } = new();

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformProperty("storage_image_reference")]
    public required TerraformList<AzurermBatchPoolStorageImageReferenceBlock> StorageImageReference { get; set; } = new();

    /// <summary>
    /// Block for task_scheduling_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("task_scheduling_policy")]
    public TerraformList<AzurermBatchPoolTaskSchedulingPolicyBlock> TaskSchedulingPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBatchPoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_accounts.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("user_accounts")]
    public TerraformList<AzurermBatchPoolUserAccountsBlock> UserAccounts { get; set; } = new();

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("windows")]
    public TerraformList<AzurermBatchPoolWindowsBlock> Windows { get; set; } = new();

}

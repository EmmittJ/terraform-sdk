using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolAutoScaleBlock
{
    /// <summary>
    /// The evaluation_interval attribute.
    /// </summary>
    [TerraformPropertyName("evaluation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EvaluationInterval { get; set; }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    [TerraformPropertyName("formula")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Formula { get; set; }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolCertificateBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    [TerraformPropertyName("store_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StoreLocation { get; set; }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [TerraformPropertyName("store_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StoreName { get; set; }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Visibility { get; set; }

}

/// <summary>
/// Block type for container_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolContainerConfigurationBlock
{
    /// <summary>
    /// The container_image_names attribute.
    /// </summary>
    [TerraformPropertyName("container_image_names")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ContainerImageNames { get; set; }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    [TerraformPropertyName("container_registries")]
    // Optional argument - user may or may not set a value
    public TerraformList<object>? ContainerRegistries { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for data_disks in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDataDisksBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [TerraformPropertyName("caching")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Caching { get; set; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformPropertyName("disk_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> DiskSizeGb { get; set; }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformPropertyName("lun")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Lun { get; set; }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountType { get; set; }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDiskEncryptionBlock
{
    /// <summary>
    /// The disk_encryption_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionTarget is required")]
    [TerraformPropertyName("disk_encryption_target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DiskEncryptionTarget { get; set; }

}

/// <summary>
/// Block type for extensions in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolExtensionsBlock
{
    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    [TerraformPropertyName("auto_upgrade_minor_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoUpgradeMinorVersion { get; set; }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformPropertyName("automatic_upgrade_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutomaticUpgradeEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformPropertyName("protected_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProtectedSettings { get; set; }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformPropertyName("provision_after_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    [TerraformPropertyName("settings_json")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SettingsJson { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [TerraformPropertyName("type_handler_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TypeHandlerVersion { get; set; }

}

/// <summary>
/// Block type for fixed_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolFixedScaleBlock
{
    /// <summary>
    /// The node_deallocation_method attribute.
    /// </summary>
    [TerraformPropertyName("node_deallocation_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NodeDeallocationMethod { get; set; }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    [TerraformPropertyName("resize_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResizeTimeout { get; set; }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    [TerraformPropertyName("target_dedicated_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetDedicatedNodes { get; set; }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    [TerraformPropertyName("target_low_priority_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetLowPriorityNodes { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for mount in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlock
{
}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlock
{
    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    [TerraformPropertyName("accelerated_networking_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AcceleratedNetworkingEnabled { get; set; }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    [TerraformPropertyName("dynamic_vnet_assignment_scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DynamicVnetAssignmentScope { get; set; }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    [TerraformPropertyName("public_address_provisioning_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicAddressProvisioningType { get; set; }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformPropertyName("public_ips")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? PublicIps { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Block type for node_placement in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNodePlacementBlock
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Policy { get; set; }

}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolSecurityProfileBlock
{
    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("host_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? HostEncryptionEnabled { get; set; }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("secure_boot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SecureBootEnabled { get; set; }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformPropertyName("security_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityType { get; set; }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("vtpm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VtpmEnabled { get; set; }

}

/// <summary>
/// Block type for start_task in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlock
{
    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLine is required")]
    [TerraformPropertyName("command_line")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CommandLine { get; set; }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    [TerraformPropertyName("common_environment_properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? CommonEnvironmentProperties { get; set; }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    [TerraformPropertyName("task_retry_maximum")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TaskRetryMaximum { get; set; }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_success")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForSuccess { get; set; }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStorageImageReferenceBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformPropertyName("offer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Offer { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Publisher { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for task_scheduling_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolTaskSchedulingPolicyBlock
{
    /// <summary>
    /// The node_fill_type attribute.
    /// </summary>
    [TerraformPropertyName("node_fill_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NodeFillType { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_accounts in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlock
{
    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElevationLevel is required")]
    [TerraformPropertyName("elevation_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ElevationLevel { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolWindowsBlock
{
    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    [TerraformPropertyName("enable_automatic_updates")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutomaticUpdates { get; set; }

}

/// <summary>
/// Manages a azurerm_batch_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermBatchPool : TerraformResource
{
    public AzurermBatchPool(string name) : base("azurerm_batch_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformPropertyName("inter_node_communication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InterNodeCommunication { get; set; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseType { get; set; }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformPropertyName("max_tasks_per_node")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxTasksPerNode { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    [TerraformPropertyName("node_agent_sku_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NodeAgentSkuId { get; set; }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_placement")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OsDiskPlacement { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    [TerraformPropertyName("stop_pending_resize_operation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? StopPendingResizeOperation { get; set; }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    [TerraformPropertyName("target_node_communication_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TargetNodeCommunicationMode { get; set; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformPropertyName("vm_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VmSize { get; set; }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformPropertyName("auto_scale")]
    public TerraformList<TerraformBlock<AzurermBatchPoolAutoScaleBlock>>? AutoScale { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("certificate")]
    public TerraformList<TerraformBlock<AzurermBatchPoolCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for container_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    [TerraformPropertyName("container_configuration")]
    public TerraformList<TerraformBlock<AzurermBatchPoolContainerConfigurationBlock>>? ContainerConfiguration { get; set; }

    /// <summary>
    /// Block for data_disks.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_disks")]
    public TerraformList<TerraformBlock<AzurermBatchPoolDataDisksBlock>>? DataDisks { get; set; }

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("disk_encryption")]
    public TerraformList<TerraformBlock<AzurermBatchPoolDiskEncryptionBlock>>? DiskEncryption { get; set; }

    /// <summary>
    /// Block for extensions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("extensions")]
    public TerraformList<TerraformBlock<AzurermBatchPoolExtensionsBlock>>? Extensions { get; set; }

    /// <summary>
    /// Block for fixed_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    [TerraformPropertyName("fixed_scale")]
    public TerraformList<TerraformBlock<AzurermBatchPoolFixedScaleBlock>>? FixedScale { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermBatchPoolIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for mount.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("mount")]
    public TerraformList<TerraformBlock<AzurermBatchPoolMountBlock>>? Mount { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AzurermBatchPoolNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for node_placement.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("node_placement")]
    public TerraformList<TerraformBlock<AzurermBatchPoolNodePlacementBlock>>? NodePlacement { get; set; }

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    [TerraformPropertyName("security_profile")]
    public TerraformList<TerraformBlock<AzurermBatchPoolSecurityProfileBlock>>? SecurityProfile { get; set; }

    /// <summary>
    /// Block for start_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    [TerraformPropertyName("start_task")]
    public TerraformList<TerraformBlock<AzurermBatchPoolStartTaskBlock>>? StartTask { get; set; }

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformPropertyName("storage_image_reference")]
    public TerraformList<TerraformBlock<AzurermBatchPoolStorageImageReferenceBlock>>? StorageImageReference { get; set; }

    /// <summary>
    /// Block for task_scheduling_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("task_scheduling_policy")]
    public TerraformList<TerraformBlock<AzurermBatchPoolTaskSchedulingPolicyBlock>>? TaskSchedulingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBatchPoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_accounts.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("user_accounts")]
    public TerraformList<TerraformBlock<AzurermBatchPoolUserAccountsBlock>>? UserAccounts { get; set; }

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("windows")]
    public TerraformList<TerraformBlock<AzurermBatchPoolWindowsBlock>>? Windows { get; set; }

}

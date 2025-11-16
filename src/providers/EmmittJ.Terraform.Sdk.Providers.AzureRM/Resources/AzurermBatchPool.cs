using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scale";

    /// <summary>
    /// The evaluation_interval attribute.
    /// </summary>
    public TerraformValue<string>? EvaluationInterval
    {
        get => new TerraformReference<string>(this, "evaluation_interval");
        set => SetArgument("evaluation_interval", value);
    }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    public required TerraformValue<string> Formula
    {
        get => new TerraformReference<string>(this, "formula");
        set => SetArgument("formula", value);
    }

}

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    public required TerraformValue<string> StoreLocation
    {
        get => new TerraformReference<string>(this, "store_location");
        set => SetArgument("store_location", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    public TerraformValue<string>? StoreName
    {
        get => new TerraformReference<string>(this, "store_name");
        set => SetArgument("store_name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformSet<string>? Visibility
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "visibility").ResolveNodes(ctx));
        set => SetArgument("visibility", value);
    }

}

/// <summary>
/// Block type for container_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolContainerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_configuration";

    /// <summary>
    /// The container_image_names attribute.
    /// </summary>
    public TerraformSet<string>? ContainerImageNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "container_image_names").ResolveNodes(ctx));
        set => SetArgument("container_image_names", value);
    }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? ContainerRegistries
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "container_registries").ResolveNodes(ctx));
        set => SetArgument("container_registries", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for data_disks in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDataDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disks";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformValue<string>? Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => new TerraformReference<string>(this, "storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

}

/// <summary>
/// Block type for disk_encryption in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption";

    /// <summary>
    /// The disk_encryption_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionTarget is required")]
    public required TerraformValue<string> DiskEncryptionTarget
    {
        get => new TerraformReference<string>(this, "disk_encryption_target");
        set => SetArgument("disk_encryption_target", value);
    }

}

/// <summary>
/// Block type for extensions in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extensions";

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformValue<bool>? AutoUpgradeMinorVersion
    {
        get => new TerraformReference<bool>(this, "auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformValue<string>? ProtectedSettings
    {
        get => new TerraformReference<string>(this, "protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformSet<string>? ProvisionAfterExtensions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "provision_after_extensions").ResolveNodes(ctx));
        set => SetArgument("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    public TerraformValue<string>? SettingsJson
    {
        get => new TerraformReference<string>(this, "settings_json");
        set => SetArgument("settings_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformValue<string>? TypeHandlerVersion
    {
        get => new TerraformReference<string>(this, "type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

}

/// <summary>
/// Block type for fixed_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolFixedScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_scale";

    /// <summary>
    /// The node_deallocation_method attribute.
    /// </summary>
    public TerraformValue<string>? NodeDeallocationMethod
    {
        get => new TerraformReference<string>(this, "node_deallocation_method");
        set => SetArgument("node_deallocation_method", value);
    }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    public TerraformValue<string>? ResizeTimeout
    {
        get => new TerraformReference<string>(this, "resize_timeout");
        set => SetArgument("resize_timeout", value);
    }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    public TerraformValue<double>? TargetDedicatedNodes
    {
        get => new TerraformReference<double>(this, "target_dedicated_nodes");
        set => SetArgument("target_dedicated_nodes", value);
    }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    public TerraformValue<double>? TargetLowPriorityNodes
    {
        get => new TerraformReference<double>(this, "target_low_priority_nodes");
        set => SetArgument("target_low_priority_nodes", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for mount in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mount";

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AcceleratedNetworkingEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_networking_enabled");
        set => SetArgument("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    public TerraformValue<string>? DynamicVnetAssignmentScope
    {
        get => new TerraformReference<string>(this, "dynamic_vnet_assignment_scope");
        set => SetArgument("dynamic_vnet_assignment_scope", value);
    }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    public TerraformValue<string>? PublicAddressProvisioningType
    {
        get => new TerraformReference<string>(this, "public_address_provisioning_type");
        set => SetArgument("public_address_provisioning_type", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformSet<string>? PublicIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "public_ips").ResolveNodes(ctx));
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for node_placement in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNodePlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_placement";

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

}

/// <summary>
/// Block type for security_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_profile";

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HostEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "host_encryption_enabled");
        set => SetArgument("host_encryption_enabled", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => new TerraformReference<bool>(this, "secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityType
    {
        get => new TerraformReference<string>(this, "security_type");
        set => SetArgument("security_type", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VtpmEnabled
    {
        get => new TerraformReference<bool>(this, "vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

}

/// <summary>
/// Block type for start_task in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_task";

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLine is required")]
    public required TerraformValue<string> CommandLine
    {
        get => new TerraformReference<string>(this, "command_line");
        set => SetArgument("command_line", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public TerraformMap<string>? CommonEnvironmentProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "common_environment_properties").ResolveNodes(ctx));
        set => SetArgument("common_environment_properties", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformValue<double>? TaskRetryMaximum
    {
        get => new TerraformReference<double>(this, "task_retry_maximum");
        set => SetArgument("task_retry_maximum", value);
    }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForSuccess
    {
        get => new TerraformReference<bool>(this, "wait_for_success");
        set => SetArgument("wait_for_success", value);
    }

}

/// <summary>
/// Block type for storage_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStorageImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_image_reference";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformValue<string>? Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformValue<string>? Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for task_scheduling_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolTaskSchedulingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_scheduling_policy";

    /// <summary>
    /// The node_fill_type attribute.
    /// </summary>
    public TerraformValue<string> NodeFillType
    {
        get => new TerraformReference<string>(this, "node_fill_type");
        set => SetArgument("node_fill_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for user_accounts in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_accounts";

    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElevationLevel is required")]
    public required TerraformValue<string> ElevationLevel
    {
        get => new TerraformReference<string>(this, "elevation_level");
        set => SetArgument("elevation_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for windows in .
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows";

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutomaticUpdates
    {
        get => new TerraformReference<bool>(this, "enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
    }

}

/// <summary>
/// Represents a azurerm_batch_pool Terraform resource.
/// Manages a azurerm_batch_pool resource.
/// </summary>
public partial class AzurermBatchPool(string name) : TerraformResource("azurerm_batch_pool", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformValue<string>? InterNodeCommunication
    {
        get => new TerraformReference<string>(this, "inter_node_communication");
        set => SetArgument("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformValue<double>? MaxTasksPerNode
    {
        get => new TerraformReference<double>(this, "max_tasks_per_node");
        set => SetArgument("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    public required TerraformValue<string> NodeAgentSkuId
    {
        get => new TerraformReference<string>(this, "node_agent_sku_id");
        set => SetArgument("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskPlacement
    {
        get => new TerraformReference<string>(this, "os_disk_placement");
        set => SetArgument("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformValue<bool>? StopPendingResizeOperation
    {
        get => new TerraformReference<bool>(this, "stop_pending_resize_operation");
        set => SetArgument("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformValue<string>? TargetNodeCommunicationMode
    {
        get => new TerraformReference<string>(this, "target_node_communication_mode");
        set => SetArgument("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// AutoScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public AzurermBatchPoolAutoScaleBlock? AutoScale
    {
        get => GetArgument<AzurermBatchPoolAutoScaleBlock>("auto_scale");
        set => SetArgument("auto_scale", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolCertificateBlock? Certificate
    {
        get => GetArgument<AzurermBatchPoolCertificateBlock>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// ContainerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public AzurermBatchPoolContainerConfigurationBlock? ContainerConfiguration
    {
        get => GetArgument<AzurermBatchPoolContainerConfigurationBlock>("container_configuration");
        set => SetArgument("container_configuration", value);
    }

    /// <summary>
    /// DataDisks block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolDataDisksBlock? DataDisks
    {
        get => GetArgument<AzurermBatchPoolDataDisksBlock>("data_disks");
        set => SetArgument("data_disks", value);
    }

    /// <summary>
    /// DiskEncryption block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolDiskEncryptionBlock? DiskEncryption
    {
        get => GetArgument<AzurermBatchPoolDiskEncryptionBlock>("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Extensions block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolExtensionsBlock? Extensions
    {
        get => GetArgument<AzurermBatchPoolExtensionsBlock>("extensions");
        set => SetArgument("extensions", value);
    }

    /// <summary>
    /// FixedScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    public AzurermBatchPoolFixedScaleBlock? FixedScale
    {
        get => GetArgument<AzurermBatchPoolFixedScaleBlock>("fixed_scale");
        set => SetArgument("fixed_scale", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public AzurermBatchPoolIdentityBlock? Identity
    {
        get => GetArgument<AzurermBatchPoolIdentityBlock>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Mount block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolMountBlock? Mount
    {
        get => GetArgument<AzurermBatchPoolMountBlock>("mount");
        set => SetArgument("mount", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public AzurermBatchPoolNetworkConfigurationBlock? NetworkConfiguration
    {
        get => GetArgument<AzurermBatchPoolNetworkConfigurationBlock>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// NodePlacement block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolNodePlacementBlock? NodePlacement
    {
        get => GetArgument<AzurermBatchPoolNodePlacementBlock>("node_placement");
        set => SetArgument("node_placement", value);
    }

    /// <summary>
    /// SecurityProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public AzurermBatchPoolSecurityProfileBlock? SecurityProfile
    {
        get => GetArgument<AzurermBatchPoolSecurityProfileBlock>("security_profile");
        set => SetArgument("security_profile", value);
    }

    /// <summary>
    /// StartTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    public AzurermBatchPoolStartTaskBlock? StartTask
    {
        get => GetArgument<AzurermBatchPoolStartTaskBlock>("start_task");
        set => SetArgument("start_task", value);
    }

    /// <summary>
    /// StorageImageReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public required AzurermBatchPoolStorageImageReferenceBlock StorageImageReference
    {
        get => GetRequiredArgument<AzurermBatchPoolStorageImageReferenceBlock>("storage_image_reference");
        set => SetArgument("storage_image_reference", value);
    }

    /// <summary>
    /// TaskSchedulingPolicy block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolTaskSchedulingPolicyBlock? TaskSchedulingPolicy
    {
        get => GetArgument<AzurermBatchPoolTaskSchedulingPolicyBlock>("task_scheduling_policy");
        set => SetArgument("task_scheduling_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserAccounts block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolUserAccountsBlock? UserAccounts
    {
        get => GetArgument<AzurermBatchPoolUserAccountsBlock>("user_accounts");
        set => SetArgument("user_accounts", value);
    }

    /// <summary>
    /// Windows block (nesting mode: list).
    /// </summary>
    public AzurermBatchPoolWindowsBlock? Windows
    {
        get => GetArgument<AzurermBatchPoolWindowsBlock>("windows");
        set => SetArgument("windows", value);
    }

}

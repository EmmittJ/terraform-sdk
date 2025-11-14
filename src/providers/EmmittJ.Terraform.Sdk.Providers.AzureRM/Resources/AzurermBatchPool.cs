using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("evaluation_interval")]
    public TerraformValue<string>? EvaluationInterval
    {
        get => new TerraformReference<string>(this, "evaluation_interval");
        set => SetArgument("evaluation_interval", value);
    }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    [TerraformArgument("formula")]
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
    [TerraformArgument("id")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    [TerraformArgument("store_location")]
    public required TerraformValue<string> StoreLocation
    {
        get => new TerraformReference<string>(this, "store_location");
        set => SetArgument("store_location", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    [TerraformArgument("store_name")]
    public TerraformValue<string>? StoreName
    {
        get => new TerraformReference<string>(this, "store_name");
        set => SetArgument("store_name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformArgument("visibility")]
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
    [TerraformArgument("container_image_names")]
    public TerraformSet<string>? ContainerImageNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "container_image_names").ResolveNodes(ctx));
        set => SetArgument("container_image_names", value);
    }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    [TerraformArgument("container_registries")]
    public TerraformList<object>? ContainerRegistries
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "container_registries").ResolveNodes(ctx));
        set => SetArgument("container_registries", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
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
    [TerraformArgument("caching")]
    public TerraformValue<string>? Caching
    {
        get => new TerraformReference<string>(this, "caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    [TerraformArgument("disk_size_gb")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => new TerraformReference<double>(this, "disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    [TerraformArgument("lun")]
    public required TerraformValue<double> Lun
    {
        get => new TerraformReference<double>(this, "lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [TerraformArgument("storage_account_type")]
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
    [TerraformArgument("disk_encryption_target")]
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
    [TerraformArgument("auto_upgrade_minor_version")]
    public TerraformValue<bool>? AutoUpgradeMinorVersion
    {
        get => new TerraformReference<bool>(this, "auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    [TerraformArgument("automatic_upgrade_enabled")]
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => new TerraformReference<bool>(this, "automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    [TerraformArgument("protected_settings")]
    public TerraformValue<string>? ProtectedSettings
    {
        get => new TerraformReference<string>(this, "protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    [TerraformArgument("provision_after_extensions")]
    public TerraformSet<string>? ProvisionAfterExtensions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "provision_after_extensions").ResolveNodes(ctx));
        set => SetArgument("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformArgument("publisher")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    [TerraformArgument("settings_json")]
    public TerraformValue<string>? SettingsJson
    {
        get => new TerraformReference<string>(this, "settings_json");
        set => SetArgument("settings_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    [TerraformArgument("type_handler_version")]
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
    [TerraformArgument("node_deallocation_method")]
    public TerraformValue<string>? NodeDeallocationMethod
    {
        get => new TerraformReference<string>(this, "node_deallocation_method");
        set => SetArgument("node_deallocation_method", value);
    }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    [TerraformArgument("resize_timeout")]
    public TerraformValue<string>? ResizeTimeout
    {
        get => new TerraformReference<string>(this, "resize_timeout");
        set => SetArgument("resize_timeout", value);
    }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    [TerraformArgument("target_dedicated_nodes")]
    public TerraformValue<double>? TargetDedicatedNodes
    {
        get => new TerraformReference<double>(this, "target_dedicated_nodes");
        set => SetArgument("target_dedicated_nodes", value);
    }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    [TerraformArgument("target_low_priority_nodes")]
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
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
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
    [TerraformArgument("accelerated_networking_enabled")]
    public TerraformValue<bool>? AcceleratedNetworkingEnabled
    {
        get => new TerraformReference<bool>(this, "accelerated_networking_enabled");
        set => SetArgument("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    [TerraformArgument("dynamic_vnet_assignment_scope")]
    public TerraformValue<string>? DynamicVnetAssignmentScope
    {
        get => new TerraformReference<string>(this, "dynamic_vnet_assignment_scope");
        set => SetArgument("dynamic_vnet_assignment_scope", value);
    }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    [TerraformArgument("public_address_provisioning_type")]
    public TerraformValue<string>? PublicAddressProvisioningType
    {
        get => new TerraformReference<string>(this, "public_address_provisioning_type");
        set => SetArgument("public_address_provisioning_type", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformArgument("public_ips")]
    public TerraformSet<string>? PublicIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "public_ips").ResolveNodes(ctx));
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
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
    [TerraformArgument("policy")]
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
    [TerraformArgument("host_encryption_enabled")]
    public TerraformValue<bool>? HostEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "host_encryption_enabled");
        set => SetArgument("host_encryption_enabled", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    [TerraformArgument("secure_boot_enabled")]
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => new TerraformReference<bool>(this, "secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    [TerraformArgument("security_type")]
    public TerraformValue<string>? SecurityType
    {
        get => new TerraformReference<string>(this, "security_type");
        set => SetArgument("security_type", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    [TerraformArgument("vtpm_enabled")]
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
    [TerraformArgument("command_line")]
    public required TerraformValue<string> CommandLine
    {
        get => new TerraformReference<string>(this, "command_line");
        set => SetArgument("command_line", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    [TerraformArgument("common_environment_properties")]
    public TerraformMap<string>? CommonEnvironmentProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "common_environment_properties").ResolveNodes(ctx));
        set => SetArgument("common_environment_properties", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    [TerraformArgument("task_retry_maximum")]
    public TerraformValue<double>? TaskRetryMaximum
    {
        get => new TerraformReference<double>(this, "task_retry_maximum");
        set => SetArgument("task_retry_maximum", value);
    }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    [TerraformArgument("wait_for_success")]
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
    [TerraformArgument("id")]
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [TerraformArgument("offer")]
    public TerraformValue<string>? Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [TerraformArgument("publisher")]
    public TerraformValue<string>? Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
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
    [TerraformArgument("node_fill_type")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
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
    [TerraformArgument("elevation_level")]
    public required TerraformValue<string> ElevationLevel
    {
        get => new TerraformReference<string>(this, "elevation_level");
        set => SetArgument("elevation_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
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
    [TerraformArgument("enable_automatic_updates")]
    public TerraformValue<bool>? EnableAutomaticUpdates
    {
        get => new TerraformReference<bool>(this, "enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
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
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformArgument("inter_node_communication")]
    public TerraformValue<string>? InterNodeCommunication
    {
        get => new TerraformReference<string>(this, "inter_node_communication");
        set => SetArgument("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string>? LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformArgument("max_tasks_per_node")]
    public TerraformValue<double>? MaxTasksPerNode
    {
        get => new TerraformReference<double>(this, "max_tasks_per_node");
        set => SetArgument("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    [TerraformArgument("node_agent_sku_id")]
    public required TerraformValue<string> NodeAgentSkuId
    {
        get => new TerraformReference<string>(this, "node_agent_sku_id");
        set => SetArgument("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformArgument("os_disk_placement")]
    public TerraformValue<string>? OsDiskPlacement
    {
        get => new TerraformReference<string>(this, "os_disk_placement");
        set => SetArgument("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    [TerraformArgument("stop_pending_resize_operation")]
    public TerraformValue<bool>? StopPendingResizeOperation
    {
        get => new TerraformReference<bool>(this, "stop_pending_resize_operation");
        set => SetArgument("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    [TerraformArgument("target_node_communication_mode")]
    public TerraformValue<string>? TargetNodeCommunicationMode
    {
        get => new TerraformReference<string>(this, "target_node_communication_mode");
        set => SetArgument("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    [TerraformArgument("vm_size")]
    public required TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// Block for auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    [TerraformArgument("auto_scale")]
    public TerraformList<AzurermBatchPoolAutoScaleBlock> AutoScale { get; set; } = new();

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("certificate")]
    public TerraformList<AzurermBatchPoolCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// Block for container_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    [TerraformArgument("container_configuration")]
    public TerraformList<AzurermBatchPoolContainerConfigurationBlock> ContainerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for data_disks.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("data_disks")]
    public TerraformList<AzurermBatchPoolDataDisksBlock> DataDisks { get; set; } = new();

    /// <summary>
    /// Block for disk_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("disk_encryption")]
    public TerraformList<AzurermBatchPoolDiskEncryptionBlock> DiskEncryption { get; set; } = new();

    /// <summary>
    /// Block for extensions.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("extensions")]
    public TerraformList<AzurermBatchPoolExtensionsBlock> Extensions { get; set; } = new();

    /// <summary>
    /// Block for fixed_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    [TerraformArgument("fixed_scale")]
    public TerraformList<AzurermBatchPoolFixedScaleBlock> FixedScale { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermBatchPoolIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for mount.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("mount")]
    public TerraformList<AzurermBatchPoolMountBlock> Mount { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformArgument("network_configuration")]
    public TerraformList<AzurermBatchPoolNetworkConfigurationBlock> NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for node_placement.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("node_placement")]
    public TerraformList<AzurermBatchPoolNodePlacementBlock> NodePlacement { get; set; } = new();

    /// <summary>
    /// Block for security_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    [TerraformArgument("security_profile")]
    public TerraformList<AzurermBatchPoolSecurityProfileBlock> SecurityProfile { get; set; } = new();

    /// <summary>
    /// Block for start_task.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    [TerraformArgument("start_task")]
    public TerraformList<AzurermBatchPoolStartTaskBlock> StartTask { get; set; } = new();

    /// <summary>
    /// Block for storage_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    [TerraformArgument("storage_image_reference")]
    public required TerraformList<AzurermBatchPoolStorageImageReferenceBlock> StorageImageReference { get; set; } = new();

    /// <summary>
    /// Block for task_scheduling_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("task_scheduling_policy")]
    public TerraformList<AzurermBatchPoolTaskSchedulingPolicyBlock> TaskSchedulingPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBatchPoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_accounts.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("user_accounts")]
    public TerraformList<AzurermBatchPoolUserAccountsBlock> UserAccounts { get; set; } = new();

    /// <summary>
    /// Block for windows.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("windows")]
    public TerraformList<AzurermBatchPoolWindowsBlock> Windows { get; set; } = new();

}

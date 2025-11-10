using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_capabilities in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock : TerraformBlock
{
    /// <summary>
    /// The ultra_ssd_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? UltraSsdEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ultra_ssd_enabled");
        set => WithProperty("ultra_ssd_enabled", value);
    }

}

/// <summary>
/// Block type for admin_ssh_key in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock : TerraformBlock
{
    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformProperty<string> PublicKey
    {
        get => GetProperty<TerraformProperty<string>>("public_key");
        set => WithProperty("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for automatic_instance_repair in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    public TerraformProperty<string>? GracePeriod
    {
        get => GetProperty<TerraformProperty<string>>("grace_period");
        set => WithProperty("grace_period", value);
    }

}

/// <summary>
/// Block type for automatic_os_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The disable_automatic_rollback attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisableAutomaticRollback is required")]
    public required TerraformProperty<bool> DisableAutomaticRollback
    {
        get => GetProperty<TerraformProperty<bool>>("disable_automatic_rollback");
        set => WithProperty("disable_automatic_rollback", value);
    }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    public required TerraformProperty<bool> EnableAutomaticOsUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("enable_automatic_os_upgrade");
        set => WithProperty("enable_automatic_os_upgrade", value);
    }

}

/// <summary>
/// Block type for boot_diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// The storage_account_uri attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUri
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_uri");
        set => WithProperty("storage_account_uri", value);
    }

}

/// <summary>
/// Block type for data_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformProperty<string>? CreateOption
    {
        get => GetProperty<TerraformProperty<string>>("create_option");
        set => WithProperty("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskIopsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("ultra_ssd_disk_iops_read_write");
        set => WithProperty("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskMbpsReadWrite
    {
        get => GetProperty<TerraformProperty<double>>("ultra_ssd_disk_mbps_read_write");
        set => WithProperty("ultra_ssd_disk_mbps_read_write", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => WithProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetExtensionBlock : TerraformBlock
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
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformProperty<string>>("force_update_tag");
        set => WithProperty("force_update_tag", value);
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
    public List<TerraformProperty<string>>? ProvisionAfterExtensions
    {
        get => GetProperty<List<TerraformProperty<string>>>("provision_after_extensions");
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
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        get => GetProperty<TerraformProperty<string>>("settings");
        set => WithProperty("settings", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        get => GetProperty<TerraformProperty<string>>("type_handler_version");
        set => WithProperty("type_handler_version", value);
    }

}

/// <summary>
/// Block type for gallery_application in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock : TerraformBlock
{
    /// <summary>
    /// The configuration_blob_uri attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationBlobUri
    {
        get => GetProperty<TerraformProperty<string>>("configuration_blob_uri");
        set => WithProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformProperty<string> VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => WithProperty("version_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
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
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock : TerraformBlock
{
    /// <summary>
    /// The auxiliary_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliaryMode
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_mode");
        set => WithProperty("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliarySku
    {
        get => GetProperty<TerraformProperty<string>>("auxiliary_sku");
        set => WithProperty("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_servers");
        set => WithProperty("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceleratedNetworking
    {
        get => GetProperty<TerraformProperty<bool>>("enable_accelerated_networking");
        set => WithProperty("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableIpForwarding
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ip_forwarding");
        set => WithProperty("enable_ip_forwarding", value);
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
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_security_group_id");
        set => WithProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        get => GetProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
    }

}

/// <summary>
/// Block type for os_disk in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetOsDiskBlock : TerraformBlock
{
    /// <summary>
    /// The caching attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Caching is required")]
    public required TerraformProperty<string> Caching
    {
        get => GetProperty<TerraformProperty<string>>("caching");
        set => WithProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("disk_encryption_set_id");
        set => WithProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("disk_size_gb");
        set => WithProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecureVmDiskEncryptionSetId
    {
        get => GetProperty<TerraformProperty<string>>("secure_vm_disk_encryption_set_id");
        set => WithProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityEncryptionType
    {
        get => GetProperty<TerraformProperty<string>>("security_encryption_type");
        set => WithProperty("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_type");
        set => WithProperty("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("write_accelerator_enabled");
        set => WithProperty("write_accelerator_enabled", value);
    }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetPlanBlock : TerraformBlock
{
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
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
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

}

/// <summary>
/// Block type for rolling_upgrade_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The cross_zone_upgrades_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrossZoneUpgradesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cross_zone_upgrades_enabled");
        set => WithProperty("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    public required TerraformProperty<double> MaxBatchInstancePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_batch_instance_percent");
        set => WithProperty("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyInstancePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_unhealthy_instance_percent");
        set => WithProperty("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyUpgradedInstancePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_unhealthy_upgraded_instance_percent");
        set => WithProperty("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MaximumSurgeInstancesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("maximum_surge_instances_enabled");
        set => WithProperty("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    public required TerraformProperty<string> PauseTimeBetweenBatches
    {
        get => GetProperty<TerraformProperty<string>>("pause_time_between_batches");
        set => WithProperty("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("prioritize_unhealthy_instances_enabled");
        set => WithProperty("prioritize_unhealthy_instances_enabled", value);
    }

}

/// <summary>
/// Block type for scale_in in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetScaleInBlock : TerraformBlock
{
    /// <summary>
    /// The force_deletion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDeletionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("force_deletion_enabled");
        set => WithProperty("force_deletion_enabled", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformProperty<string>? Rule
    {
        get => GetProperty<TerraformProperty<string>>("rule");
        set => WithProperty("rule", value);
    }

}

/// <summary>
/// Block type for secret in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSecretBlock : TerraformBlock
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => WithProperty("key_vault_id", value);
    }

}

/// <summary>
/// Block type for source_image_reference in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => WithProperty("offer", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => WithProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for spot_restore in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for termination_notification in .
/// Nesting mode: list
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => WithProperty("timeout", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLinuxVirtualMachineScaleSetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_linux_virtual_machine_scale_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLinuxVirtualMachineScaleSet : TerraformResource
{
    public AzurermLinuxVirtualMachineScaleSet(string name) : base("azurerm_linux_virtual_machine_scale_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("unique_id");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdminPassword
    {
        get => GetProperty<TerraformProperty<string>>("admin_password");
        set => this.WithProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetProperty<TerraformProperty<string>>("admin_username");
        set => this.WithProperty("admin_username", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? CapacityReservationGroupId
    {
        get => GetProperty<TerraformProperty<string>>("capacity_reservation_group_id");
        set => this.WithProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ComputerNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("computer_name_prefix");
        set => this.WithProperty("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string>? CustomData
    {
        get => GetProperty<TerraformProperty<string>>("custom_data");
        set => this.WithProperty("custom_data", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? DisablePasswordAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("disable_password_authentication");
        set => this.WithProperty("disable_password_authentication", value);
    }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public TerraformProperty<bool>? DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetProperty<TerraformProperty<bool>>("do_not_run_extensions_on_overprovisioned_machines");
        set => this.WithProperty("do_not_run_extensions_on_overprovisioned_machines", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EncryptionAtHostEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => this.WithProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExtensionOperationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("extension_operations_enabled");
        set => this.WithProperty("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformProperty<string>? ExtensionsTimeBudget
    {
        get => GetProperty<TerraformProperty<string>>("extensions_time_budget");
        set => this.WithProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthProbeId
    {
        get => GetProperty<TerraformProperty<string>>("health_probe_id");
        set => this.WithProperty("health_probe_id", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("host_group_id");
        set => this.WithProperty("host_group_id", value);
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
    /// The instances attribute.
    /// </summary>
    public TerraformProperty<double>? Instances
    {
        get => GetProperty<TerraformProperty<double>>("instances");
        set => this.WithProperty("instances", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformProperty<double>? MaxBidPrice
    {
        get => GetProperty<TerraformProperty<double>>("max_bid_price");
        set => this.WithProperty("max_bid_price", value);
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
    /// The overprovision attribute.
    /// </summary>
    public TerraformProperty<bool>? Overprovision
    {
        get => GetProperty<TerraformProperty<bool>>("overprovision");
        set => this.WithProperty("overprovision", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformProperty<double>? PlatformFaultDomainCount
    {
        get => GetProperty<TerraformProperty<double>>("platform_fault_domain_count");
        set => this.WithProperty("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? ProvisionVmAgent
    {
        get => GetProperty<TerraformProperty<bool>>("provision_vm_agent");
        set => this.WithProperty("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("proximity_placement_group_id");
        set => this.WithProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResilientVmCreationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("resilient_vm_creation_enabled");
        set => this.WithProperty("resilient_vm_creation_enabled", value);
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ResilientVmDeletionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("resilient_vm_deletion_enabled");
        set => this.WithProperty("resilient_vm_deletion_enabled", value);
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
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecureBootEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secure_boot_enabled");
        set => this.WithProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool>? SinglePlacementGroup
    {
        get => GetProperty<TerraformProperty<bool>>("single_placement_group");
        set => this.WithProperty("single_placement_group", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceImageId
    {
        get => GetProperty<TerraformProperty<string>>("source_image_id");
        set => this.WithProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string>? UpgradeMode
    {
        get => GetProperty<TerraformProperty<string>>("upgrade_mode");
        set => this.WithProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VtpmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("vtpm_enabled");
        set => this.WithProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneBalance
    {
        get => GetProperty<TerraformProperty<bool>>("zone_balance");
        set => this.WithProperty("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>>("additional_capabilities");
        set => this.WithProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>? AdminSshKey
    {
        get => GetProperty<HashSet<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>>("admin_ssh_key");
        set => this.WithProperty("admin_ssh_key", value);
    }

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>? AutomaticInstanceRepair
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>>("automatic_instance_repair");
        set => this.WithProperty("automatic_instance_repair", value);
    }

    /// <summary>
    /// Block for automatic_os_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>? AutomaticOsUpgradePolicy
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>>("automatic_os_upgrade_policy");
        set => this.WithProperty("automatic_os_upgrade_policy", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>>("boot_diagnostics");
        set => this.WithProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>? DataDisk
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>>("data_disk");
        set => this.WithProperty("data_disk", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxVirtualMachineScaleSetExtensionBlock>? Extension
    {
        get => GetProperty<HashSet<AzurermLinuxVirtualMachineScaleSetExtensionBlock>>("extension");
        set => this.WithProperty("extension", value);
    }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>? GalleryApplication
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>>("gallery_application");
        set => this.WithProperty("gallery_application", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    public List<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>? NetworkInterface
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>>("network_interface");
        set => this.WithProperty("network_interface", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>? OsDisk
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>>("os_disk");
        set => this.WithProperty("os_disk", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>>("rolling_upgrade_policy");
        set => this.WithProperty("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Block for scale_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetScaleInBlock>? ScaleIn
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetScaleInBlock>>("scale_in");
        set => this.WithProperty("scale_in", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLinuxVirtualMachineScaleSetSecretBlock>? Secret
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>? SourceImageReference
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>>("source_image_reference");
        set => this.WithProperty("source_image_reference", value);
    }

    /// <summary>
    /// Block for spot_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>? SpotRestore
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>>("spot_restore");
        set => this.WithProperty("spot_restore", value);
    }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>? TerminationNotification
    {
        get => GetProperty<List<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>>("termination_notification");
        set => this.WithProperty("termination_notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLinuxVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLinuxVirtualMachineScaleSetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}

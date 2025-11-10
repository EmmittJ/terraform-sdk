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
        set => SetProperty("ultra_ssd_enabled", value);
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
        set => SetProperty("public_key", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The grace_period attribute.
    /// </summary>
    public TerraformProperty<string>? GracePeriod
    {
        set => SetProperty("grace_period", value);
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
        set => SetProperty("disable_automatic_rollback", value);
    }

    /// <summary>
    /// The enable_automatic_os_upgrade attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableAutomaticOsUpgrade is required")]
    public required TerraformProperty<bool> EnableAutomaticOsUpgrade
    {
        set => SetProperty("enable_automatic_os_upgrade", value);
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
        set => SetProperty("storage_account_uri", value);
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
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The create_option attribute.
    /// </summary>
    public TerraformProperty<string>? CreateOption
    {
        set => SetProperty("create_option", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        set => SetProperty("disk_encryption_set_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_iops_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskIopsReadWrite
    {
        set => SetProperty("ultra_ssd_disk_iops_read_write", value);
    }

    /// <summary>
    /// The ultra_ssd_disk_mbps_read_write attribute.
    /// </summary>
    public TerraformProperty<double>? UltraSsdDiskMbpsReadWrite
    {
        set => SetProperty("ultra_ssd_disk_mbps_read_write", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        set => SetProperty("write_accelerator_enabled", value);
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
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateTag
    {
        set => SetProperty("force_update_tag", value);
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
    public List<TerraformProperty<string>>? ProvisionAfterExtensions
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
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        set => SetProperty("settings", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeHandlerVersion is required")]
    public required TerraformProperty<string> TypeHandlerVersion
    {
        set => SetProperty("type_handler_version", value);
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
        set => SetProperty("configuration_blob_uri", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    public TerraformProperty<string>? Tag
    {
        set => SetProperty("tag", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionId is required")]
    public required TerraformProperty<string> VersionId
    {
        set => SetProperty("version_id", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("auxiliary_mode", value);
    }

    /// <summary>
    /// The auxiliary_sku attribute.
    /// </summary>
    public TerraformProperty<string>? AuxiliarySku
    {
        set => SetProperty("auxiliary_sku", value);
    }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DnsServers
    {
        set => SetProperty("dns_servers", value);
    }

    /// <summary>
    /// The enable_accelerated_networking attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAcceleratedNetworking
    {
        set => SetProperty("enable_accelerated_networking", value);
    }

    /// <summary>
    /// The enable_ip_forwarding attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableIpForwarding
    {
        set => SetProperty("enable_ip_forwarding", value);
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
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkSecurityGroupId
    {
        set => SetProperty("network_security_group_id", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    public TerraformProperty<bool>? Primary
    {
        set => SetProperty("primary", value);
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
        set => SetProperty("caching", value);
    }

    /// <summary>
    /// The disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? DiskEncryptionSetId
    {
        set => SetProperty("disk_encryption_set_id", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DiskSizeGb
    {
        set => SetProperty("disk_size_gb", value);
    }

    /// <summary>
    /// The secure_vm_disk_encryption_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? SecureVmDiskEncryptionSetId
    {
        set => SetProperty("secure_vm_disk_encryption_set_id", value);
    }

    /// <summary>
    /// The security_encryption_type attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityEncryptionType
    {
        set => SetProperty("security_encryption_type", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountType is required")]
    public required TerraformProperty<string> StorageAccountType
    {
        set => SetProperty("storage_account_type", value);
    }

    /// <summary>
    /// The write_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WriteAcceleratorEnabled
    {
        set => SetProperty("write_accelerator_enabled", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        set => SetProperty("product", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
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
        set => SetProperty("cross_zone_upgrades_enabled", value);
    }

    /// <summary>
    /// The max_batch_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxBatchInstancePercent is required")]
    public required TerraformProperty<double> MaxBatchInstancePercent
    {
        set => SetProperty("max_batch_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyInstancePercent
    {
        set => SetProperty("max_unhealthy_instance_percent", value);
    }

    /// <summary>
    /// The max_unhealthy_upgraded_instance_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxUnhealthyUpgradedInstancePercent is required")]
    public required TerraformProperty<double> MaxUnhealthyUpgradedInstancePercent
    {
        set => SetProperty("max_unhealthy_upgraded_instance_percent", value);
    }

    /// <summary>
    /// The maximum_surge_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MaximumSurgeInstancesEnabled
    {
        set => SetProperty("maximum_surge_instances_enabled", value);
    }

    /// <summary>
    /// The pause_time_between_batches attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PauseTimeBetweenBatches is required")]
    public required TerraformProperty<string> PauseTimeBetweenBatches
    {
        set => SetProperty("pause_time_between_batches", value);
    }

    /// <summary>
    /// The prioritize_unhealthy_instances_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrioritizeUnhealthyInstancesEnabled
    {
        set => SetProperty("prioritize_unhealthy_instances_enabled", value);
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
        set => SetProperty("force_deletion_enabled", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformProperty<string>? Rule
    {
        set => SetProperty("rule", value);
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
        set => SetProperty("key_vault_id", value);
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
        set => SetProperty("offer", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
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
        SetOutput("unique_id");
        SetOutput("admin_password");
        SetOutput("admin_username");
        SetOutput("capacity_reservation_group_id");
        SetOutput("computer_name_prefix");
        SetOutput("custom_data");
        SetOutput("disable_password_authentication");
        SetOutput("do_not_run_extensions_on_overprovisioned_machines");
        SetOutput("edge_zone");
        SetOutput("encryption_at_host_enabled");
        SetOutput("eviction_policy");
        SetOutput("extension_operations_enabled");
        SetOutput("extensions_time_budget");
        SetOutput("health_probe_id");
        SetOutput("host_group_id");
        SetOutput("id");
        SetOutput("instances");
        SetOutput("location");
        SetOutput("max_bid_price");
        SetOutput("name");
        SetOutput("overprovision");
        SetOutput("platform_fault_domain_count");
        SetOutput("priority");
        SetOutput("provision_vm_agent");
        SetOutput("proximity_placement_group_id");
        SetOutput("resilient_vm_creation_enabled");
        SetOutput("resilient_vm_deletion_enabled");
        SetOutput("resource_group_name");
        SetOutput("secure_boot_enabled");
        SetOutput("single_placement_group");
        SetOutput("sku");
        SetOutput("source_image_id");
        SetOutput("tags");
        SetOutput("upgrade_mode");
        SetOutput("user_data");
        SetOutput("vtpm_enabled");
        SetOutput("zone_balance");
        SetOutput("zones");
    }

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    public TerraformProperty<string> AdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_password");
        set => SetProperty("admin_password", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformProperty<string> AdminUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_username");
        set => SetProperty("admin_username", value);
    }

    /// <summary>
    /// The capacity_reservation_group_id attribute.
    /// </summary>
    public TerraformProperty<string> CapacityReservationGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_reservation_group_id");
        set => SetProperty("capacity_reservation_group_id", value);
    }

    /// <summary>
    /// The computer_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> ComputerNamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("computer_name_prefix");
        set => SetProperty("computer_name_prefix", value);
    }

    /// <summary>
    /// The custom_data attribute.
    /// </summary>
    public TerraformProperty<string> CustomData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_data");
        set => SetProperty("custom_data", value);
    }

    /// <summary>
    /// The disable_password_authentication attribute.
    /// </summary>
    public TerraformProperty<bool> DisablePasswordAuthentication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_password_authentication");
        set => SetProperty("disable_password_authentication", value);
    }

    /// <summary>
    /// The do_not_run_extensions_on_overprovisioned_machines attribute.
    /// </summary>
    public TerraformProperty<bool> DoNotRunExtensionsOnOverprovisionedMachines
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("do_not_run_extensions_on_overprovisioned_machines");
        set => SetProperty("do_not_run_extensions_on_overprovisioned_machines", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The encryption_at_host_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> EncryptionAtHostEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("encryption_at_host_enabled");
        set => SetProperty("encryption_at_host_enabled", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string> EvictionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eviction_policy");
        set => SetProperty("eviction_policy", value);
    }

    /// <summary>
    /// The extension_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExtensionOperationsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("extension_operations_enabled");
        set => SetProperty("extension_operations_enabled", value);
    }

    /// <summary>
    /// The extensions_time_budget attribute.
    /// </summary>
    public TerraformProperty<string> ExtensionsTimeBudget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extensions_time_budget");
        set => SetProperty("extensions_time_budget", value);
    }

    /// <summary>
    /// The health_probe_id attribute.
    /// </summary>
    public TerraformProperty<string> HealthProbeId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_probe_id");
        set => SetProperty("health_probe_id", value);
    }

    /// <summary>
    /// The host_group_id attribute.
    /// </summary>
    public TerraformProperty<string> HostGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_group_id");
        set => SetProperty("host_group_id", value);
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
    /// The instances attribute.
    /// </summary>
    public TerraformProperty<double> Instances
    {
        get => GetRequiredOutput<TerraformProperty<double>>("instances");
        set => SetProperty("instances", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The max_bid_price attribute.
    /// </summary>
    public TerraformProperty<double> MaxBidPrice
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_bid_price");
        set => SetProperty("max_bid_price", value);
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
    /// The overprovision attribute.
    /// </summary>
    public TerraformProperty<bool> Overprovision
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("overprovision");
        set => SetProperty("overprovision", value);
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformProperty<double> PlatformFaultDomainCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("platform_fault_domain_count");
        set => SetProperty("platform_fault_domain_count", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string> Priority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The provision_vm_agent attribute.
    /// </summary>
    public TerraformProperty<bool> ProvisionVmAgent
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("provision_vm_agent");
        set => SetProperty("provision_vm_agent", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string> ProximityPlacementGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proximity_placement_group_id");
        set => SetProperty("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The resilient_vm_creation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ResilientVmCreationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("resilient_vm_creation_enabled");
        set => SetProperty("resilient_vm_creation_enabled", value);
    }

    /// <summary>
    /// The resilient_vm_deletion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ResilientVmDeletionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("resilient_vm_deletion_enabled");
        set => SetProperty("resilient_vm_deletion_enabled", value);
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
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SecureBootEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("secure_boot_enabled");
        set => SetProperty("secure_boot_enabled", value);
    }

    /// <summary>
    /// The single_placement_group attribute.
    /// </summary>
    public TerraformProperty<bool> SinglePlacementGroup
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("single_placement_group");
        set => SetProperty("single_placement_group", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceImageId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_image_id");
        set => SetProperty("source_image_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The upgrade_mode attribute.
    /// </summary>
    public TerraformProperty<string> UpgradeMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("upgrade_mode");
        set => SetProperty("upgrade_mode", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string> UserData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_data");
        set => SetProperty("user_data", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> VtpmEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("vtpm_enabled");
        set => SetProperty("vtpm_enabled", value);
    }

    /// <summary>
    /// The zone_balance attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneBalance
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_balance");
        set => SetProperty("zone_balance", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for additional_capabilities.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalCapabilities block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAdditionalCapabilitiesBlock>? AdditionalCapabilities
    {
        set => SetProperty("additional_capabilities", value);
    }

    /// <summary>
    /// Block for admin_ssh_key.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxVirtualMachineScaleSetAdminSshKeyBlock>? AdminSshKey
    {
        set => SetProperty("admin_ssh_key", value);
    }

    /// <summary>
    /// Block for automatic_instance_repair.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticInstanceRepair block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAutomaticInstanceRepairBlock>? AutomaticInstanceRepair
    {
        set => SetProperty("automatic_instance_repair", value);
    }

    /// <summary>
    /// Block for automatic_os_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticOsUpgradePolicy block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyBlock>? AutomaticOsUpgradePolicy
    {
        set => SetProperty("automatic_os_upgrade_policy", value);
    }

    /// <summary>
    /// Block for boot_diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BootDiagnostics block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetBootDiagnosticsBlock>? BootDiagnostics
    {
        set => SetProperty("boot_diagnostics", value);
    }

    /// <summary>
    /// Block for data_disk.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLinuxVirtualMachineScaleSetDataDiskBlock>? DataDisk
    {
        set => SetProperty("data_disk", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermLinuxVirtualMachineScaleSetExtensionBlock>? Extension
    {
        set => SetProperty("extension", value);
    }

    /// <summary>
    /// Block for gallery_application.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 GalleryApplication block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetGalleryApplicationBlock>? GalleryApplication
    {
        set => SetProperty("gallery_application", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterface is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkInterface block(s) required")]
    public List<AzurermLinuxVirtualMachineScaleSetNetworkInterfaceBlock>? NetworkInterface
    {
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// Block for os_disk.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsDisk is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsDisk block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsDisk block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetOsDiskBlock>? OsDisk
    {
        set => SetProperty("os_disk", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetPlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for rolling_upgrade_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RollingUpgradePolicy block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetRollingUpgradePolicyBlock>? RollingUpgradePolicy
    {
        set => SetProperty("rolling_upgrade_policy", value);
    }

    /// <summary>
    /// Block for scale_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleIn block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetScaleInBlock>? ScaleIn
    {
        set => SetProperty("scale_in", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermLinuxVirtualMachineScaleSetSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// Block for source_image_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceImageReference block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetSourceImageReferenceBlock>? SourceImageReference
    {
        set => SetProperty("source_image_reference", value);
    }

    /// <summary>
    /// Block for spot_restore.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpotRestore block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetSpotRestoreBlock>? SpotRestore
    {
        set => SetProperty("spot_restore", value);
    }

    /// <summary>
    /// Block for termination_notification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TerminationNotification block(s) allowed")]
    public List<AzurermLinuxVirtualMachineScaleSetTerminationNotificationBlock>? TerminationNotification
    {
        set => SetProperty("termination_notification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLinuxVirtualMachineScaleSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique_id attribute.
    /// </summary>
    public TerraformExpression UniqueId => this["unique_id"];

}

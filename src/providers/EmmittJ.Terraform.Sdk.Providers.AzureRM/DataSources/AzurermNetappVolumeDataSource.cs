using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappVolumeDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume.
/// </summary>
public partial class AzurermNetappVolumeDataSource : TerraformDataSource
{
    public AzurermNetappVolumeDataSource(string name) : base("azurerm_netapp_volume", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformProperty("pool_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PoolName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformProperty("security_style")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityStyle { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNetappVolumeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    [TerraformProperty("accept_grow_capacity_pool_for_short_term_clone_split")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AcceptGrowCapacityPoolForShortTermCloneSplit { get; }

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    [TerraformProperty("data_protection_backup_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataProtectionBackupPolicy { get; }

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    [TerraformProperty("data_protection_replication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataProtectionReplication { get; }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformProperty("encryption_key_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EncryptionKeySource { get; }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_private_endpoint_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyVaultPrivateEndpointId { get; }

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    [TerraformProperty("large_volume_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> LargeVolumeEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("mount_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> MountIpAddresses { get; }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformProperty("network_features")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkFeatures { get; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Protocols { get; }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformProperty("service_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceLevel { get; }

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    [TerraformProperty("smb_access_based_enumeration_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SmbAccessBasedEnumerationEnabled { get; }

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    [TerraformProperty("smb_non_browsable_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SmbNonBrowsableEnabled { get; }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [TerraformProperty("storage_quota_in_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageQuotaInGb { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [TerraformProperty("volume_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VolumePath { get; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Zone { get; }

}

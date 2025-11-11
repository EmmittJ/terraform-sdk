using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume.
/// </summary>
public class AzurermNetappVolumeDataSource : TerraformDataSource
{
    public AzurermNetappVolumeDataSource(string name) : base("azurerm_netapp_volume", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformPropertyName("pool_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PoolName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformPropertyName("security_style")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityStyle { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappVolumeDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    [TerraformPropertyName("accept_grow_capacity_pool_for_short_term_clone_split")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AcceptGrowCapacityPoolForShortTermCloneSplit => new TerraformReference(this, "accept_grow_capacity_pool_for_short_term_clone_split");

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    [TerraformPropertyName("data_protection_backup_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataProtectionBackupPolicy => new TerraformReference(this, "data_protection_backup_policy");

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    [TerraformPropertyName("data_protection_replication")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataProtectionReplication => new TerraformReference(this, "data_protection_replication");

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key_source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionKeySource => new TerraformReference(this, "encryption_key_source");

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_private_endpoint_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyVaultPrivateEndpointId => new TerraformReference(this, "key_vault_private_endpoint_id");

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    [TerraformPropertyName("large_volume_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LargeVolumeEnabled => new TerraformReference(this, "large_volume_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("mount_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> MountIpAddresses => new TerraformReference(this, "mount_ip_addresses");

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformPropertyName("network_features")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkFeatures => new TerraformReference(this, "network_features");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Protocols => new TerraformReference(this, "protocols");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformPropertyName("service_level")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceLevel => new TerraformReference(this, "service_level");

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_access_based_enumeration_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SmbAccessBasedEnumerationEnabled => new TerraformReference(this, "smb_access_based_enumeration_enabled");

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    [TerraformPropertyName("smb_non_browsable_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SmbNonBrowsableEnabled => new TerraformReference(this, "smb_non_browsable_enabled");

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("storage_quota_in_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageQuotaInGb => new TerraformReference(this, "storage_quota_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [TerraformPropertyName("volume_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumePath => new TerraformReference(this, "volume_path");

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Zone => new TerraformReference(this, "zone");

}

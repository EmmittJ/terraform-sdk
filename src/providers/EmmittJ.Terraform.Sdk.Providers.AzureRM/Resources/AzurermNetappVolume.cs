using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cool_access in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeCoolAccessBlock : TerraformBlockBase
{
    /// <summary>
    /// The coolness_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoolnessPeriodInDays is required")]
    [TerraformProperty("coolness_period_in_days")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CoolnessPeriodInDays { get; set; }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    [TerraformProperty("retrieval_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RetrievalPolicy { get; set; }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    [TerraformProperty("tiering_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TieringPolicy { get; set; }

}

/// <summary>
/// Block type for data_protection_backup_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeDataProtectionBackupPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The ID of the backup policy to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    [TerraformProperty("backup_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupPolicyId { get; set; }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    [TerraformProperty("backup_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupVaultId { get; set; }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    [TerraformProperty("policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PolicyEnabled { get; set; }

}

/// <summary>
/// Block type for data_protection_replication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeDataProtectionReplicationBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointType { get; set; }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    [TerraformProperty("remote_volume_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteVolumeLocation { get; set; }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    [TerraformProperty("remote_volume_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteVolumeResourceId { get; set; }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    [TerraformProperty("replication_frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationFrequency { get; set; }

}

/// <summary>
/// Block type for data_protection_snapshot_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeDataProtectionSnapshotPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The snapshot_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotPolicyId is required")]
    [TerraformProperty("snapshot_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SnapshotPolicyId { get; set; }

}

/// <summary>
/// Block type for export_policy_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNetappVolumeExportPolicyRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedClients is required")]
    [TerraformProperty("allowed_clients")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> AllowedClients { get; set; }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5_read_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5ReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5_read_write_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5ReadWriteEnabled { get; set; }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5i_read_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5iReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5i_read_write_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5iReadWriteEnabled { get; set; }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5p_read_only_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5pReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    [TerraformProperty("kerberos_5p_read_write_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Kerberos5pReadWriteEnabled { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Protocol { get; set; }

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("protocols_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> ProtocolsEnabled { get; set; }

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    [TerraformProperty("root_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RootAccessEnabled { get; set; }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    [TerraformProperty("rule_index")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RuleIndex { get; set; }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    [TerraformProperty("unix_read_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UnixReadOnly { get; set; }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    [TerraformProperty("unix_read_write")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UnixReadWrite { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNetappVolumeTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_netapp_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNetappVolume : TerraformResource
{
    public AzurermNetappVolume(string name) : base("azurerm_netapp_volume", name)
    {
    }

    /// <summary>
    /// While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. Can only be used in conjunction with `create_from_snapshot_resource_id`.
    /// </summary>
    [TerraformProperty("accept_grow_capacity_pool_for_short_term_clone_split")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceptGrowCapacityPoolForShortTermCloneSplit { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_vmware_data_store_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureVmwareDataStoreEnabled { get; set; }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    [TerraformProperty("create_from_snapshot_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CreateFromSnapshotResourceId { get; set; }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformProperty("encryption_key_source")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EncryptionKeySource { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    [TerraformProperty("kerberos_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? KerberosEnabled { get; set; }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_private_endpoint_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyVaultPrivateEndpointId { get; set; }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    [TerraformProperty("large_volume_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LargeVolumeEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformProperty("network_features")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkFeatures { get; set; }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformProperty("pool_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PoolName { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Protocols { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SecurityStyle { get; set; }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    [TerraformProperty("service_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceLevel { get; set; }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    [TerraformProperty("smb3_protocol_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Smb3ProtocolEncryptionEnabled { get; set; }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    [TerraformProperty("smb_access_based_enumeration_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbAccessBasedEnumerationEnabled { get; set; }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    [TerraformProperty("smb_continuous_availability_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbContinuousAvailabilityEnabled { get; set; }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    [TerraformProperty("smb_non_browsable_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SmbNonBrowsableEnabled { get; set; }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [TerraformProperty("snapshot_directory_visible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SnapshotDirectoryVisible { get; set; }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    [TerraformProperty("storage_quota_in_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> StorageQuotaInGb { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    [TerraformProperty("throughput_in_mibps")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ThroughputInMibps { get; set; }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    [TerraformProperty("volume_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VolumePath { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Block for cool_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoolAccess block(s) allowed")]
    [TerraformProperty("cool_access")]
    public partial TerraformList<TerraformBlock<AzurermNetappVolumeCoolAccessBlock>>? CoolAccess { get; set; }

    /// <summary>
    /// Block for data_protection_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionBackupPolicy block(s) allowed")]
    [TerraformProperty("data_protection_backup_policy")]
    public partial TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionBackupPolicyBlock>>? DataProtectionBackupPolicy { get; set; }

    /// <summary>
    /// Block for data_protection_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    [TerraformProperty("data_protection_replication")]
    public partial TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionReplicationBlock>>? DataProtectionReplication { get; set; }

    /// <summary>
    /// Block for data_protection_snapshot_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    [TerraformProperty("data_protection_snapshot_policy")]
    public partial TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>>? DataProtectionSnapshotPolicy { get; set; }

    /// <summary>
    /// Block for export_policy_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    [TerraformProperty("export_policy_rule")]
    public partial TerraformList<TerraformBlock<AzurermNetappVolumeExportPolicyRuleBlock>>? ExportPolicyRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNetappVolumeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("mount_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> MountIpAddresses { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cool_access in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeCoolAccessBlock : ITerraformBlock
{
    /// <summary>
    /// The coolness_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoolnessPeriodInDays is required")]
    [TerraformPropertyName("coolness_period_in_days")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CoolnessPeriodInDays { get; set; }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    [TerraformPropertyName("retrieval_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RetrievalPolicy { get; set; }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    [TerraformPropertyName("tiering_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TieringPolicy { get; set; }

}

/// <summary>
/// Block type for data_protection_backup_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionBackupPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The ID of the backup policy to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    [TerraformPropertyName("backup_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupPolicyId { get; set; }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    [TerraformPropertyName("backup_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupVaultId { get; set; }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    [TerraformPropertyName("policy_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PolicyEnabled { get; set; }

}

/// <summary>
/// Block type for data_protection_replication in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionReplicationBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointType { get; set; }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    [TerraformPropertyName("remote_volume_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RemoteVolumeLocation { get; set; }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    [TerraformPropertyName("remote_volume_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RemoteVolumeResourceId { get; set; }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    [TerraformPropertyName("replication_frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationFrequency { get; set; }

}

/// <summary>
/// Block type for data_protection_snapshot_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionSnapshotPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The snapshot_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotPolicyId is required")]
    [TerraformPropertyName("snapshot_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SnapshotPolicyId { get; set; }

}

/// <summary>
/// Block type for export_policy_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeExportPolicyRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedClients is required")]
    [TerraformPropertyName("allowed_clients")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowedClients { get; set; }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5_read_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5ReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5_read_write_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5ReadWriteEnabled { get; set; }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5i_read_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5iReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5i_read_write_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5iReadWriteEnabled { get; set; }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5p_read_only_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5pReadOnlyEnabled { get; set; }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    [TerraformPropertyName("kerberos_5p_read_write_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Kerberos5pReadWriteEnabled { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> Protocol { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "protocol");

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("protocols_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> ProtocolsEnabled { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "protocols_enabled");

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("root_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RootAccessEnabled { get; set; }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    [TerraformPropertyName("rule_index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RuleIndex { get; set; }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    [TerraformPropertyName("unix_read_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UnixReadOnly { get; set; }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    [TerraformPropertyName("unix_read_write")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UnixReadWrite { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_netapp_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappVolume : TerraformResource
{
    public AzurermNetappVolume(string name) : base("azurerm_netapp_volume", name)
    {
    }

    /// <summary>
    /// While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. Can only be used in conjunction with `create_from_snapshot_resource_id`.
    /// </summary>
    [TerraformPropertyName("accept_grow_capacity_pool_for_short_term_clone_split")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceptGrowCapacityPoolForShortTermCloneSplit { get; set; }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    [TerraformPropertyName("azure_vmware_data_store_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AzureVmwareDataStoreEnabled { get; set; }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("create_from_snapshot_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateFromSnapshotResourceId { get; set; }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformPropertyName("encryption_key_source")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EncryptionKeySource { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_key_source");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    [TerraformPropertyName("kerberos_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? KerberosEnabled { get; set; }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_private_endpoint_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyVaultPrivateEndpointId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_vault_private_endpoint_id");

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    [TerraformPropertyName("large_volume_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LargeVolumeEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformPropertyName("network_features")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkFeatures { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_features");

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformPropertyName("pool_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PoolName { get; set; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Protocols { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "protocols");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformPropertyName("security_style")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecurityStyle { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_style");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    [TerraformPropertyName("service_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceLevel { get; set; }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    [TerraformPropertyName("smb3_protocol_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Smb3ProtocolEncryptionEnabled { get; set; }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    [TerraformPropertyName("smb_access_based_enumeration_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbAccessBasedEnumerationEnabled { get; set; }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    [TerraformPropertyName("smb_continuous_availability_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbContinuousAvailabilityEnabled { get; set; }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    [TerraformPropertyName("smb_non_browsable_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SmbNonBrowsableEnabled { get; set; }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_directory_visible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SnapshotDirectoryVisible { get; set; }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    [TerraformPropertyName("storage_quota_in_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> StorageQuotaInGb { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    [TerraformPropertyName("throughput_in_mibps")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ThroughputInMibps { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "throughput_in_mibps");

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    [TerraformPropertyName("volume_path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VolumePath { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// Block for cool_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoolAccess block(s) allowed")]
    [TerraformPropertyName("cool_access")]
    public TerraformList<TerraformBlock<AzurermNetappVolumeCoolAccessBlock>>? CoolAccess { get; set; } = new();

    /// <summary>
    /// Block for data_protection_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionBackupPolicy block(s) allowed")]
    [TerraformPropertyName("data_protection_backup_policy")]
    public TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionBackupPolicyBlock>>? DataProtectionBackupPolicy { get; set; } = new();

    /// <summary>
    /// Block for data_protection_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    [TerraformPropertyName("data_protection_replication")]
    public TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionReplicationBlock>>? DataProtectionReplication { get; set; } = new();

    /// <summary>
    /// Block for data_protection_snapshot_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    [TerraformPropertyName("data_protection_snapshot_policy")]
    public TerraformList<TerraformBlock<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>>? DataProtectionSnapshotPolicy { get; set; } = new();

    /// <summary>
    /// Block for export_policy_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    [TerraformPropertyName("export_policy_rule")]
    public TerraformList<TerraformBlock<AzurermNetappVolumeExportPolicyRuleBlock>>? ExportPolicyRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappVolumeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("mount_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> MountIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "mount_ip_addresses");

}

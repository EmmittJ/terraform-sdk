using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cool_access in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeCoolAccessBlock : TerraformBlock
{
    /// <summary>
    /// The coolness_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoolnessPeriodInDays is required")]
    public required TerraformProperty<double> CoolnessPeriodInDays
    {
        get => GetProperty<TerraformProperty<double>>("coolness_period_in_days");
        set => WithProperty("coolness_period_in_days", value);
    }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    public required TerraformProperty<string> RetrievalPolicy
    {
        get => GetProperty<TerraformProperty<string>>("retrieval_policy");
        set => WithProperty("retrieval_policy", value);
    }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    public required TerraformProperty<string> TieringPolicy
    {
        get => GetProperty<TerraformProperty<string>>("tiering_policy");
        set => WithProperty("tiering_policy", value);
    }

}

/// <summary>
/// Block type for data_protection_backup_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the backup policy to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("backup_policy_id");
        set => WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformProperty<string> BackupVaultId
    {
        get => GetProperty<TerraformProperty<string>>("backup_vault_id");
        set => WithProperty("backup_vault_id", value);
    }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    public TerraformProperty<bool>? PolicyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("policy_enabled");
        set => WithProperty("policy_enabled", value);
    }

}

/// <summary>
/// Block type for data_protection_replication in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionReplicationBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointType
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_type");
        set => WithProperty("endpoint_type", value);
    }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    public required TerraformProperty<string> RemoteVolumeLocation
    {
        get => GetProperty<TerraformProperty<string>>("remote_volume_location");
        set => WithProperty("remote_volume_location", value);
    }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    public required TerraformProperty<string> RemoteVolumeResourceId
    {
        get => GetProperty<TerraformProperty<string>>("remote_volume_resource_id");
        set => WithProperty("remote_volume_resource_id", value);
    }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    public required TerraformProperty<string> ReplicationFrequency
    {
        get => GetProperty<TerraformProperty<string>>("replication_frequency");
        set => WithProperty("replication_frequency", value);
    }

}

/// <summary>
/// Block type for data_protection_snapshot_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionSnapshotPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The snapshot_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotPolicyId is required")]
    public required TerraformProperty<string> SnapshotPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_policy_id");
        set => WithProperty("snapshot_policy_id", value);
    }

}

/// <summary>
/// Block type for export_policy_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeExportPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedClients is required")]
    public HashSet<TerraformProperty<string>>? AllowedClients
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_clients");
        set => WithProperty("allowed_clients", value);
    }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5ReadOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5_read_only_enabled");
        set => WithProperty("kerberos_5_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5ReadWriteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5_read_write_enabled");
        set => WithProperty("kerberos_5_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5iReadOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5i_read_only_enabled");
        set => WithProperty("kerberos_5i_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5iReadWriteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5i_read_write_enabled");
        set => WithProperty("kerberos_5i_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5pReadOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5p_read_only_enabled");
        set => WithProperty("kerberos_5p_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5pReadWriteEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_5p_read_write_enabled");
        set => WithProperty("kerberos_5p_read_write_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Protocol
    {
        get => GetProperty<List<TerraformProperty<string>>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public List<TerraformProperty<string>>? ProtocolsEnabled
    {
        get => GetProperty<List<TerraformProperty<string>>>("protocols_enabled");
        set => WithProperty("protocols_enabled", value);
    }

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("root_access_enabled");
        set => WithProperty("root_access_enabled", value);
    }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    public required TerraformProperty<double> RuleIndex
    {
        get => GetProperty<TerraformProperty<double>>("rule_index");
        set => WithProperty("rule_index", value);
    }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    public TerraformProperty<bool>? UnixReadOnly
    {
        get => GetProperty<TerraformProperty<bool>>("unix_read_only");
        set => WithProperty("unix_read_only", value);
    }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    public TerraformProperty<bool>? UnixReadWrite
    {
        get => GetProperty<TerraformProperty<bool>>("unix_read_write");
        set => WithProperty("unix_read_write", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_netapp_volume resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermNetappVolume : TerraformResource
{
    public AzurermNetappVolume(string name) : base("azurerm_netapp_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("mount_ip_addresses");
    }

    /// <summary>
    /// While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. Can only be used in conjunction with `create_from_snapshot_resource_id`.
    /// </summary>
    public TerraformProperty<string>? AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => GetProperty<TerraformProperty<string>>("accept_grow_capacity_pool_for_short_term_clone_split");
        set => this.WithProperty("accept_grow_capacity_pool_for_short_term_clone_split", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureVmwareDataStoreEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("azure_vmware_data_store_enabled");
        set => this.WithProperty("azure_vmware_data_store_enabled", value);
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? CreateFromSnapshotResourceId
    {
        get => GetProperty<TerraformProperty<string>>("create_from_snapshot_resource_id");
        set => this.WithProperty("create_from_snapshot_resource_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKeySource
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key_source");
        set => this.WithProperty("encryption_key_source", value);
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
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public TerraformProperty<bool>? KerberosEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("kerberos_enabled");
        set => this.WithProperty("kerberos_enabled", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultPrivateEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_private_endpoint_id");
        set => this.WithProperty("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public TerraformProperty<bool>? LargeVolumeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("large_volume_enabled");
        set => this.WithProperty("large_volume_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkFeatures
    {
        get => GetProperty<TerraformProperty<string>>("network_features");
        set => this.WithProperty("network_features", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetProperty<TerraformProperty<string>>("pool_name");
        set => this.WithProperty("pool_name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The security_style attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityStyle
    {
        get => GetProperty<TerraformProperty<string>>("security_style");
        set => this.WithProperty("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformProperty<string> ServiceLevel
    {
        get => GetProperty<TerraformProperty<string>>("service_level");
        set => this.WithProperty("service_level", value);
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public TerraformProperty<bool>? Smb3ProtocolEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb3_protocol_encryption_enabled");
        set => this.WithProperty("smb3_protocol_encryption_enabled", value);
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public TerraformProperty<bool>? SmbAccessBasedEnumerationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_access_based_enumeration_enabled");
        set => this.WithProperty("smb_access_based_enumeration_enabled", value);
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public TerraformProperty<bool>? SmbContinuousAvailabilityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_continuous_availability_enabled");
        set => this.WithProperty("smb_continuous_availability_enabled", value);
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public TerraformProperty<bool>? SmbNonBrowsableEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smb_non_browsable_enabled");
        set => this.WithProperty("smb_non_browsable_enabled", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public TerraformProperty<bool>? SnapshotDirectoryVisible
    {
        get => GetProperty<TerraformProperty<bool>>("snapshot_directory_visible");
        set => this.WithProperty("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformProperty<double> StorageQuotaInGb
    {
        get => GetProperty<TerraformProperty<double>>("storage_quota_in_gb");
        set => this.WithProperty("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The throughput_in_mibps attribute.
    /// </summary>
    public TerraformProperty<double>? ThroughputInMibps
    {
        get => GetProperty<TerraformProperty<double>>("throughput_in_mibps");
        set => this.WithProperty("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformProperty<string> VolumePath
    {
        get => GetProperty<TerraformProperty<string>>("volume_path");
        set => this.WithProperty("volume_path", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for cool_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoolAccess block(s) allowed")]
    public List<AzurermNetappVolumeCoolAccessBlock>? CoolAccess
    {
        get => GetProperty<List<AzurermNetappVolumeCoolAccessBlock>>("cool_access");
        set => this.WithProperty("cool_access", value);
    }

    /// <summary>
    /// Block for data_protection_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionBackupPolicy block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionBackupPolicyBlock>? DataProtectionBackupPolicy
    {
        get => GetProperty<List<AzurermNetappVolumeDataProtectionBackupPolicyBlock>>("data_protection_backup_policy");
        set => this.WithProperty("data_protection_backup_policy", value);
    }

    /// <summary>
    /// Block for data_protection_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionReplicationBlock>? DataProtectionReplication
    {
        get => GetProperty<List<AzurermNetappVolumeDataProtectionReplicationBlock>>("data_protection_replication");
        set => this.WithProperty("data_protection_replication", value);
    }

    /// <summary>
    /// Block for data_protection_snapshot_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>? DataProtectionSnapshotPolicy
    {
        get => GetProperty<List<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>>("data_protection_snapshot_policy");
        set => this.WithProperty("data_protection_snapshot_policy", value);
    }

    /// <summary>
    /// Block for export_policy_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    public List<AzurermNetappVolumeExportPolicyRuleBlock>? ExportPolicyRule
    {
        get => GetProperty<List<AzurermNetappVolumeExportPolicyRuleBlock>>("export_policy_rule");
        set => this.WithProperty("export_policy_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappVolumeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformExpression MountIpAddresses => this["mount_ip_addresses"];

}

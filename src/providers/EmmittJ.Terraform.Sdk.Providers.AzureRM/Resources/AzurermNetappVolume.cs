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
        set => SetProperty("coolness_period_in_days", value);
    }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    public required TerraformProperty<string> RetrievalPolicy
    {
        set => SetProperty("retrieval_policy", value);
    }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    public required TerraformProperty<string> TieringPolicy
    {
        set => SetProperty("tiering_policy", value);
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
        set => SetProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformProperty<string> BackupVaultId
    {
        set => SetProperty("backup_vault_id", value);
    }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    public TerraformProperty<bool>? PolicyEnabled
    {
        set => SetProperty("policy_enabled", value);
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
        set => SetProperty("endpoint_type", value);
    }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    public required TerraformProperty<string> RemoteVolumeLocation
    {
        set => SetProperty("remote_volume_location", value);
    }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    public required TerraformProperty<string> RemoteVolumeResourceId
    {
        set => SetProperty("remote_volume_resource_id", value);
    }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    public required TerraformProperty<string> ReplicationFrequency
    {
        set => SetProperty("replication_frequency", value);
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
        set => SetProperty("snapshot_policy_id", value);
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
        set => SetProperty("allowed_clients", value);
    }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5ReadOnlyEnabled
    {
        set => SetProperty("kerberos_5_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5ReadWriteEnabled
    {
        set => SetProperty("kerberos_5_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5iReadOnlyEnabled
    {
        set => SetProperty("kerberos_5i_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5iReadWriteEnabled
    {
        set => SetProperty("kerberos_5i_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5pReadOnlyEnabled
    {
        set => SetProperty("kerberos_5p_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Kerberos5pReadWriteEnabled
    {
        set => SetProperty("kerberos_5p_read_write_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public List<TerraformProperty<string>>? ProtocolsEnabled
    {
        set => SetProperty("protocols_enabled", value);
    }

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RootAccessEnabled
    {
        set => SetProperty("root_access_enabled", value);
    }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    public required TerraformProperty<double> RuleIndex
    {
        set => SetProperty("rule_index", value);
    }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    public TerraformProperty<bool>? UnixReadOnly
    {
        set => SetProperty("unix_read_only", value);
    }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    public TerraformProperty<bool>? UnixReadWrite
    {
        set => SetProperty("unix_read_write", value);
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
        SetOutput("mount_ip_addresses");
        SetOutput("accept_grow_capacity_pool_for_short_term_clone_split");
        SetOutput("account_name");
        SetOutput("azure_vmware_data_store_enabled");
        SetOutput("create_from_snapshot_resource_id");
        SetOutput("encryption_key_source");
        SetOutput("id");
        SetOutput("kerberos_enabled");
        SetOutput("key_vault_private_endpoint_id");
        SetOutput("large_volume_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_features");
        SetOutput("pool_name");
        SetOutput("protocols");
        SetOutput("resource_group_name");
        SetOutput("security_style");
        SetOutput("service_level");
        SetOutput("smb3_protocol_encryption_enabled");
        SetOutput("smb_access_based_enumeration_enabled");
        SetOutput("smb_continuous_availability_enabled");
        SetOutput("smb_non_browsable_enabled");
        SetOutput("snapshot_directory_visible");
        SetOutput("storage_quota_in_gb");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("throughput_in_mibps");
        SetOutput("volume_path");
        SetOutput("zone");
    }

    /// <summary>
    /// While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. Can only be used in conjunction with `create_from_snapshot_resource_id`.
    /// </summary>
    public TerraformProperty<string> AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accept_grow_capacity_pool_for_short_term_clone_split");
        set => SetProperty("accept_grow_capacity_pool_for_short_term_clone_split", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AzureVmwareDataStoreEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("azure_vmware_data_store_enabled");
        set => SetProperty("azure_vmware_data_store_enabled", value);
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public TerraformProperty<string> CreateFromSnapshotResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_from_snapshot_resource_id");
        set => SetProperty("create_from_snapshot_resource_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformProperty<string> EncryptionKeySource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encryption_key_source");
        set => SetProperty("encryption_key_source", value);
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
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public TerraformProperty<bool> KerberosEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("kerberos_enabled");
        set => SetProperty("kerberos_enabled", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultPrivateEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_private_endpoint_id");
        set => SetProperty("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public TerraformProperty<bool> LargeVolumeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("large_volume_enabled");
        set => SetProperty("large_volume_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformProperty<string> NetworkFeatures
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_features");
        set => SetProperty("network_features", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_name");
        set => SetProperty("pool_name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Protocols
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("protocols");
        set => SetProperty("protocols", value);
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
    /// The security_style attribute.
    /// </summary>
    public TerraformProperty<string> SecurityStyle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_style");
        set => SetProperty("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformProperty<string> ServiceLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_level");
        set => SetProperty("service_level", value);
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public TerraformProperty<bool> Smb3ProtocolEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb3_protocol_encryption_enabled");
        set => SetProperty("smb3_protocol_encryption_enabled", value);
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public TerraformProperty<bool> SmbAccessBasedEnumerationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb_access_based_enumeration_enabled");
        set => SetProperty("smb_access_based_enumeration_enabled", value);
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public TerraformProperty<bool> SmbContinuousAvailabilityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb_continuous_availability_enabled");
        set => SetProperty("smb_continuous_availability_enabled", value);
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public TerraformProperty<bool> SmbNonBrowsableEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("smb_non_browsable_enabled");
        set => SetProperty("smb_non_browsable_enabled", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public TerraformProperty<bool> SnapshotDirectoryVisible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("snapshot_directory_visible");
        set => SetProperty("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformProperty<double> StorageQuotaInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_quota_in_gb");
        set => SetProperty("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The throughput_in_mibps attribute.
    /// </summary>
    public TerraformProperty<double> ThroughputInMibps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("throughput_in_mibps");
        set => SetProperty("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformProperty<string> VolumePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("volume_path");
        set => SetProperty("volume_path", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for cool_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoolAccess block(s) allowed")]
    public List<AzurermNetappVolumeCoolAccessBlock>? CoolAccess
    {
        set => SetProperty("cool_access", value);
    }

    /// <summary>
    /// Block for data_protection_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionBackupPolicy block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionBackupPolicyBlock>? DataProtectionBackupPolicy
    {
        set => SetProperty("data_protection_backup_policy", value);
    }

    /// <summary>
    /// Block for data_protection_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionReplicationBlock>? DataProtectionReplication
    {
        set => SetProperty("data_protection_replication", value);
    }

    /// <summary>
    /// Block for data_protection_snapshot_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    public List<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>? DataProtectionSnapshotPolicy
    {
        set => SetProperty("data_protection_snapshot_policy", value);
    }

    /// <summary>
    /// Block for export_policy_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    public List<AzurermNetappVolumeExportPolicyRuleBlock>? ExportPolicyRule
    {
        set => SetProperty("export_policy_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformExpression MountIpAddresses => this["mount_ip_addresses"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cool_access in AzurermNetappVolume.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeCoolAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cool_access";

    /// <summary>
    /// The coolness_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoolnessPeriodInDays is required")]
    public required TerraformValue<double> CoolnessPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("coolness_period_in_days");
        set => SetArgument("coolness_period_in_days", value);
    }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    public required TerraformValue<string> RetrievalPolicy
    {
        get => GetArgument<TerraformValue<string>>("retrieval_policy");
        set => SetArgument("retrieval_policy", value);
    }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    public required TerraformValue<string> TieringPolicy
    {
        get => GetArgument<TerraformValue<string>>("tiering_policy");
        set => SetArgument("tiering_policy", value);
    }

}


/// <summary>
/// Block type for data_protection_backup_policy in AzurermNetappVolume.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_protection_backup_policy";

    /// <summary>
    /// The ID of the backup policy to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformValue<string> BackupPolicyId
    {
        get => GetArgument<TerraformValue<string>>("backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformValue<string> BackupVaultId
    {
        get => GetArgument<TerraformValue<string>>("backup_vault_id");
        set => SetArgument("backup_vault_id", value);
    }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    public TerraformValue<bool>? PolicyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("policy_enabled");
        set => SetArgument("policy_enabled", value);
    }

}


/// <summary>
/// Block type for data_protection_replication in AzurermNetappVolume.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_protection_replication";

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? EndpointType
    {
        get => GetArgument<TerraformValue<string>>("endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    public required TerraformValue<string> RemoteVolumeLocation
    {
        get => GetArgument<TerraformValue<string>>("remote_volume_location");
        set => SetArgument("remote_volume_location", value);
    }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    public required TerraformValue<string> RemoteVolumeResourceId
    {
        get => GetArgument<TerraformValue<string>>("remote_volume_resource_id");
        set => SetArgument("remote_volume_resource_id", value);
    }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    public required TerraformValue<string> ReplicationFrequency
    {
        get => GetArgument<TerraformValue<string>>("replication_frequency");
        set => SetArgument("replication_frequency", value);
    }

}


/// <summary>
/// Block type for data_protection_snapshot_policy in AzurermNetappVolume.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeDataProtectionSnapshotPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_protection_snapshot_policy";

    /// <summary>
    /// The snapshot_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotPolicyId is required")]
    public required TerraformValue<string> SnapshotPolicyId
    {
        get => GetArgument<TerraformValue<string>>("snapshot_policy_id");
        set => SetArgument("snapshot_policy_id", value);
    }

}


/// <summary>
/// Block type for export_policy_rule in AzurermNetappVolume.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeExportPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_policy_rule";

    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedClients is required")]
    public required TerraformSet<string> AllowedClients
    {
        get => GetArgument<TerraformSet<string>>("allowed_clients");
        set => SetArgument("allowed_clients", value);
    }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5ReadOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5_read_only_enabled");
        set => SetArgument("kerberos_5_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5ReadWriteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5_read_write_enabled");
        set => SetArgument("kerberos_5_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5iReadOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5i_read_only_enabled");
        set => SetArgument("kerberos_5i_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5iReadWriteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5i_read_write_enabled");
        set => SetArgument("kerberos_5i_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5pReadOnlyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5p_read_only_enabled");
        set => SetArgument("kerberos_5p_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5pReadWriteEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_5p_read_write_enabled");
        set => SetArgument("kerberos_5p_read_write_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformList<string>? Protocol
    {
        get => GetArgument<TerraformList<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<string>? ProtocolsEnabled
    {
        get => GetArgument<TerraformList<string>>("protocols_enabled");
        set => SetArgument("protocols_enabled", value);
    }

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("root_access_enabled");
        set => SetArgument("root_access_enabled", value);
    }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    public required TerraformValue<double> RuleIndex
    {
        get => GetArgument<TerraformValue<double>>("rule_index");
        set => SetArgument("rule_index", value);
    }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    public TerraformValue<bool>? UnixReadOnly
    {
        get => GetArgument<TerraformValue<bool>>("unix_read_only");
        set => SetArgument("unix_read_only", value);
    }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    public TerraformValue<bool>? UnixReadWrite
    {
        get => GetArgument<TerraformValue<bool>>("unix_read_write");
        set => SetArgument("unix_read_write", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetappVolume.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_volume Terraform resource.
/// Manages a azurerm_netapp_volume resource.
/// </summary>
public partial class AzurermNetappVolume(string name) : TerraformResource("azurerm_netapp_volume", name)
{
    /// <summary>
    /// While auto splitting the short term clone volume, if the parent pool does not have enough space to accommodate the volume after split, it will be automatically resized, which will lead to increased billing. To accept capacity pool size auto grow and create a short term clone volume, set the property as accepted. Can only be used in conjunction with `create_from_snapshot_resource_id`.
    /// </summary>
    public TerraformValue<string>? AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => GetArgument<TerraformValue<string>>("accept_grow_capacity_pool_for_short_term_clone_split");
        set => SetArgument("accept_grow_capacity_pool_for_short_term_clone_split", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzureVmwareDataStoreEnabled
    {
        get => GetArgument<TerraformValue<bool>>("azure_vmware_data_store_enabled");
        set => SetArgument("azure_vmware_data_store_enabled", value);
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? CreateFromSnapshotResourceId
    {
        get => GetArgument<TerraformValue<string>>("create_from_snapshot_resource_id");
        set => SetArgument("create_from_snapshot_resource_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeySource
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_source");
        set => SetArgument("encryption_key_source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public TerraformValue<bool>? KerberosEnabled
    {
        get => GetArgument<TerraformValue<bool>>("kerberos_enabled");
        set => SetArgument("kerberos_enabled", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultPrivateEndpointId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_private_endpoint_id");
        set => SetArgument("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public TerraformValue<bool>? LargeVolumeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("large_volume_enabled");
        set => SetArgument("large_volume_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformValue<string>? NetworkFeatures
    {
        get => GetArgument<TerraformValue<string>>("network_features");
        set => SetArgument("network_features", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => GetArgument<TerraformValue<string>>("pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string>? Protocols
    {
        get => GetArgument<TerraformSet<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public TerraformValue<string>? SecurityStyle
    {
        get => GetArgument<TerraformValue<string>>("security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformValue<string> ServiceLevel
    {
        get => GetArgument<TerraformValue<string>>("service_level");
        set => SetArgument("service_level", value);
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public TerraformValue<bool>? Smb3ProtocolEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb3_protocol_encryption_enabled");
        set => SetArgument("smb3_protocol_encryption_enabled", value);
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public TerraformValue<bool>? SmbAccessBasedEnumerationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb_access_based_enumeration_enabled");
        set => SetArgument("smb_access_based_enumeration_enabled", value);
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public TerraformValue<bool>? SmbContinuousAvailabilityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb_continuous_availability_enabled");
        set => SetArgument("smb_continuous_availability_enabled", value);
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public TerraformValue<bool>? SmbNonBrowsableEnabled
    {
        get => GetArgument<TerraformValue<bool>>("smb_non_browsable_enabled");
        set => SetArgument("smb_non_browsable_enabled", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public TerraformValue<bool>? SnapshotDirectoryVisible
    {
        get => GetArgument<TerraformValue<bool>>("snapshot_directory_visible");
        set => SetArgument("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformValue<double> StorageQuotaInGb
    {
        get => GetArgument<TerraformValue<double>>("storage_quota_in_gb");
        set => SetArgument("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double>? ThroughputInMibps
    {
        get => GetArgument<TerraformValue<double>>("throughput_in_mibps");
        set => SetArgument("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformValue<string> VolumePath
    {
        get => GetArgument<TerraformValue<string>>("volume_path");
        set => SetArgument("volume_path", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> MountIpAddresses
        => AsReference("mount_ip_addresses");

    /// <summary>
    /// CoolAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoolAccess block(s) allowed")]
    public TerraformList<AzurermNetappVolumeCoolAccessBlock>? CoolAccess
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeCoolAccessBlock>>("cool_access");
        set => SetArgument("cool_access", value);
    }

    /// <summary>
    /// DataProtectionBackupPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionBackupPolicy block(s) allowed")]
    public TerraformList<AzurermNetappVolumeDataProtectionBackupPolicyBlock>? DataProtectionBackupPolicy
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeDataProtectionBackupPolicyBlock>>("data_protection_backup_policy");
        set => SetArgument("data_protection_backup_policy", value);
    }

    /// <summary>
    /// DataProtectionReplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    public TerraformList<AzurermNetappVolumeDataProtectionReplicationBlock>? DataProtectionReplication
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeDataProtectionReplicationBlock>>("data_protection_replication");
        set => SetArgument("data_protection_replication", value);
    }

    /// <summary>
    /// DataProtectionSnapshotPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    public TerraformList<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>? DataProtectionSnapshotPolicy
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeDataProtectionSnapshotPolicyBlock>>("data_protection_snapshot_policy");
        set => SetArgument("data_protection_snapshot_policy", value);
    }

    /// <summary>
    /// ExportPolicyRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    public TerraformList<AzurermNetappVolumeExportPolicyRuleBlock>? ExportPolicyRule
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeExportPolicyRuleBlock>>("export_policy_rule");
        set => SetArgument("export_policy_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

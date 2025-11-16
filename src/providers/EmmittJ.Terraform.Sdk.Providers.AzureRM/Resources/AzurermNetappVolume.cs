using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cool_access in .
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
        get => new TerraformReference<double>(this, "coolness_period_in_days");
        set => SetArgument("coolness_period_in_days", value);
    }

    /// <summary>
    /// The retrieval_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetrievalPolicy is required")]
    public required TerraformValue<string> RetrievalPolicy
    {
        get => new TerraformReference<string>(this, "retrieval_policy");
        set => SetArgument("retrieval_policy", value);
    }

    /// <summary>
    /// The tiering_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TieringPolicy is required")]
    public required TerraformValue<string> TieringPolicy
    {
        get => new TerraformReference<string>(this, "tiering_policy");
        set => SetArgument("tiering_policy", value);
    }

}

/// <summary>
/// Block type for data_protection_backup_policy in .
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
        get => new TerraformReference<string>(this, "backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The ID of the backup vault to associate with this volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVaultId is required")]
    public required TerraformValue<string> BackupVaultId
    {
        get => new TerraformReference<string>(this, "backup_vault_id");
        set => SetArgument("backup_vault_id", value);
    }

    /// <summary>
    /// If set to false, the backup policy will not be enabled on this volume, thus disabling scheduled backups.
    /// </summary>
    public TerraformValue<bool>? PolicyEnabled
    {
        get => new TerraformReference<bool>(this, "policy_enabled");
        set => SetArgument("policy_enabled", value);
    }

}

/// <summary>
/// Block type for data_protection_replication in .
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
        get => new TerraformReference<string>(this, "endpoint_type");
        set => SetArgument("endpoint_type", value);
    }

    /// <summary>
    /// The remote_volume_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeLocation is required")]
    public required TerraformValue<string> RemoteVolumeLocation
    {
        get => new TerraformReference<string>(this, "remote_volume_location");
        set => SetArgument("remote_volume_location", value);
    }

    /// <summary>
    /// The remote_volume_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVolumeResourceId is required")]
    public required TerraformValue<string> RemoteVolumeResourceId
    {
        get => new TerraformReference<string>(this, "remote_volume_resource_id");
        set => SetArgument("remote_volume_resource_id", value);
    }

    /// <summary>
    /// The replication_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationFrequency is required")]
    public required TerraformValue<string> ReplicationFrequency
    {
        get => new TerraformReference<string>(this, "replication_frequency");
        set => SetArgument("replication_frequency", value);
    }

}

/// <summary>
/// Block type for data_protection_snapshot_policy in .
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
        get => new TerraformReference<string>(this, "snapshot_policy_id");
        set => SetArgument("snapshot_policy_id", value);
    }

}

/// <summary>
/// Block type for export_policy_rule in .
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_clients").ResolveNodes(ctx));
        set => SetArgument("allowed_clients", value);
    }

    /// <summary>
    /// The kerberos_5_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5ReadOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5_read_only_enabled");
        set => SetArgument("kerberos_5_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5ReadWriteEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5_read_write_enabled");
        set => SetArgument("kerberos_5_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5iReadOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5i_read_only_enabled");
        set => SetArgument("kerberos_5i_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5i_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5iReadWriteEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5i_read_write_enabled");
        set => SetArgument("kerberos_5i_read_write_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_only_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5pReadOnlyEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5p_read_only_enabled");
        set => SetArgument("kerberos_5p_read_only_enabled", value);
    }

    /// <summary>
    /// The kerberos_5p_read_write_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Kerberos5pReadWriteEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_5p_read_write_enabled");
        set => SetArgument("kerberos_5p_read_write_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformList<string> Protocol
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocol").ResolveNodes(ctx));
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The protocols_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<string> ProtocolsEnabled
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols_enabled").ResolveNodes(ctx));
        set => SetArgument("protocols_enabled", value);
    }

    /// <summary>
    /// The root_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RootAccessEnabled
    {
        get => new TerraformReference<bool>(this, "root_access_enabled");
        set => SetArgument("root_access_enabled", value);
    }

    /// <summary>
    /// The rule_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleIndex is required")]
    public required TerraformValue<double> RuleIndex
    {
        get => new TerraformReference<double>(this, "rule_index");
        set => SetArgument("rule_index", value);
    }

    /// <summary>
    /// The unix_read_only attribute.
    /// </summary>
    public TerraformValue<bool>? UnixReadOnly
    {
        get => new TerraformReference<bool>(this, "unix_read_only");
        set => SetArgument("unix_read_only", value);
    }

    /// <summary>
    /// The unix_read_write attribute.
    /// </summary>
    public TerraformValue<bool>? UnixReadWrite
    {
        get => new TerraformReference<bool>(this, "unix_read_write");
        set => SetArgument("unix_read_write", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "accept_grow_capacity_pool_for_short_term_clone_split");
        set => SetArgument("accept_grow_capacity_pool_for_short_term_clone_split", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AzureVmwareDataStoreEnabled
    {
        get => new TerraformReference<bool>(this, "azure_vmware_data_store_enabled");
        set => SetArgument("azure_vmware_data_store_enabled", value);
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? CreateFromSnapshotResourceId
    {
        get => new TerraformReference<string>(this, "create_from_snapshot_resource_id");
        set => SetArgument("create_from_snapshot_resource_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeySource
    {
        get => new TerraformReference<string>(this, "encryption_key_source");
        set => SetArgument("encryption_key_source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public TerraformValue<bool>? KerberosEnabled
    {
        get => new TerraformReference<bool>(this, "kerberos_enabled");
        set => SetArgument("kerberos_enabled", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultPrivateEndpointId
    {
        get => new TerraformReference<string>(this, "key_vault_private_endpoint_id");
        set => SetArgument("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public TerraformValue<bool>? LargeVolumeEnabled
    {
        get => new TerraformReference<bool>(this, "large_volume_enabled");
        set => SetArgument("large_volume_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformValue<string> NetworkFeatures
    {
        get => new TerraformReference<string>(this, "network_features");
        set => SetArgument("network_features", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => new TerraformReference<string>(this, "pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<string> Protocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public TerraformValue<string> SecurityStyle
    {
        get => new TerraformReference<string>(this, "security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceLevel is required")]
    public required TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
        set => SetArgument("service_level", value);
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public TerraformValue<bool>? Smb3ProtocolEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "smb3_protocol_encryption_enabled");
        set => SetArgument("smb3_protocol_encryption_enabled", value);
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public TerraformValue<bool>? SmbAccessBasedEnumerationEnabled
    {
        get => new TerraformReference<bool>(this, "smb_access_based_enumeration_enabled");
        set => SetArgument("smb_access_based_enumeration_enabled", value);
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public TerraformValue<bool>? SmbContinuousAvailabilityEnabled
    {
        get => new TerraformReference<bool>(this, "smb_continuous_availability_enabled");
        set => SetArgument("smb_continuous_availability_enabled", value);
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public TerraformValue<bool>? SmbNonBrowsableEnabled
    {
        get => new TerraformReference<bool>(this, "smb_non_browsable_enabled");
        set => SetArgument("smb_non_browsable_enabled", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public TerraformValue<bool>? SnapshotDirectoryVisible
    {
        get => new TerraformReference<bool>(this, "snapshot_directory_visible");
        set => SetArgument("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageQuotaInGb is required")]
    public required TerraformValue<double> StorageQuotaInGb
    {
        get => new TerraformReference<double>(this, "storage_quota_in_gb");
        set => SetArgument("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double> ThroughputInMibps
    {
        get => new TerraformReference<double>(this, "throughput_in_mibps");
        set => SetArgument("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumePath is required")]
    public required TerraformValue<string> VolumePath
    {
        get => new TerraformReference<string>(this, "volume_path");
        set => SetArgument("volume_path", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

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

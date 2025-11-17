using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappVolumeGroupOracle.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeGroupOracleTimeoutsBlock : TerraformBlock
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
/// Block type for volume in AzurermNetappVolumeGroupOracle.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// The capacity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityPoolId is required")]
    public required TerraformValue<string> CapacityPoolId
    {
        get => new TerraformReference<string>(this, "capacity_pool_id");
        set => SetArgument("capacity_pool_id", value);
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
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> MountIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_ip_addresses").ResolveNodes(ctx));
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
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ProximityPlacementGroupId
    {
        get => new TerraformReference<string>(this, "proximity_placement_group_id");
        set => SetArgument("proximity_placement_group_id", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityStyle is required")]
    public required TerraformValue<string> SecurityStyle
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
    /// The snapshot_directory_visible attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotDirectoryVisible is required")]
    public required TerraformValue<bool> SnapshotDirectoryVisible
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThroughputInMibps is required")]
    public required TerraformValue<double> ThroughputInMibps
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
    /// The volume_spec_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSpecName is required")]
    public required TerraformValue<string> VolumeSpecName
    {
        get => new TerraformReference<string>(this, "volume_spec_name");
        set => SetArgument("volume_spec_name", value);
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
    /// DataProtectionReplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionReplication block(s) allowed")]
    public TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionReplicationBlock>? DataProtectionReplication
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionReplicationBlock>>("data_protection_replication");
        set => SetArgument("data_protection_replication", value);
    }

    /// <summary>
    /// DataProtectionSnapshotPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataProtectionSnapshotPolicy block(s) allowed")]
    public TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionSnapshotPolicyBlock>? DataProtectionSnapshotPolicy
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionSnapshotPolicyBlock>>("data_protection_snapshot_policy");
        set => SetArgument("data_protection_snapshot_policy", value);
    }

    /// <summary>
    /// ExportPolicyRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportPolicyRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ExportPolicyRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 ExportPolicyRule block(s) allowed")]
    public required TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockExportPolicyRuleBlock> ExportPolicyRule
    {
        get => GetRequiredArgument<TerraformList<AzurermNetappVolumeGroupOracleVolumeBlockExportPolicyRuleBlock>>("export_policy_rule");
        set => SetArgument("export_policy_rule", value);
    }

}

/// <summary>
/// Block type for data_protection_replication in AzurermNetappVolumeGroupOracleVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionReplicationBlock : TerraformBlock
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
/// Block type for data_protection_snapshot_policy in AzurermNetappVolumeGroupOracleVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlockDataProtectionSnapshotPolicyBlock : TerraformBlock
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
/// Block type for export_policy_rule in AzurermNetappVolumeGroupOracleVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermNetappVolumeGroupOracleVolumeBlockExportPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_policy_rule";

    /// <summary>
    /// The allowed_clients attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedClients is required")]
    public required TerraformValue<string> AllowedClients
    {
        get => new TerraformReference<string>(this, "allowed_clients");
        set => SetArgument("allowed_clients", value);
    }

    /// <summary>
    /// The nfsv3_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nfsv3Enabled is required")]
    public required TerraformValue<bool> Nfsv3Enabled
    {
        get => new TerraformReference<bool>(this, "nfsv3_enabled");
        set => SetArgument("nfsv3_enabled", value);
    }

    /// <summary>
    /// The nfsv41_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nfsv41Enabled is required")]
    public required TerraformValue<bool> Nfsv41Enabled
    {
        get => new TerraformReference<bool>(this, "nfsv41_enabled");
        set => SetArgument("nfsv41_enabled", value);
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
/// Represents a azurerm_netapp_volume_group_oracle Terraform resource.
/// Manages a azurerm_netapp_volume_group_oracle resource.
/// </summary>
public partial class AzurermNetappVolumeGroupOracle(string name) : TerraformResource("azurerm_netapp_volume_group_oracle", name)
{
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
    /// The application_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationIdentifier is required")]
    public required TerraformValue<string> ApplicationIdentifier
    {
        get => new TerraformReference<string>(this, "application_identifier");
        set => SetArgument("application_identifier", value);
    }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupDescription is required")]
    public required TerraformValue<string> GroupDescription
    {
        get => new TerraformReference<string>(this, "group_description");
        set => SetArgument("group_description", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeGroupOracleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeGroupOracleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Volume block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 Volume block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(12, ErrorMessage = "Maximum 12 Volume block(s) allowed")]
    public TerraformList<AzurermNetappVolumeGroupOracleVolumeBlock>? Volume
    {
        get => GetArgument<TerraformList<AzurermNetappVolumeGroupOracleVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}

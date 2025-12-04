using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappVolumeDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_netapp_volume Terraform data source.
/// Retrieves information about a azurerm_netapp_volume.
/// </summary>
public partial class AzurermNetappVolumeDataSource(string name) : TerraformDataSource("azurerm_netapp_volume", name)
{
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => GetArgument<TerraformValue<string>>("pool_name");
        set => SetArgument("pool_name", value);
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
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    public TerraformValue<string> AcceptGrowCapacityPoolForShortTermCloneSplit
        => AsReference("accept_grow_capacity_pool_for_short_term_clone_split");

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataProtectionBackupPolicy
        => AsReference("data_protection_backup_policy");

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataProtectionReplication
        => AsReference("data_protection_replication");

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeySource
        => AsReference("encryption_key_source");

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultPrivateEndpointId
        => AsReference("key_vault_private_endpoint_id");

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LargeVolumeEnabled
        => AsReference("large_volume_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> MountIpAddresses
        => AsReference("mount_ip_addresses");

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformValue<string> NetworkFeatures
        => AsReference("network_features");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
        => AsReference("protocols");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformValue<string> ServiceLevel
        => AsReference("service_level");

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SmbAccessBasedEnumerationEnabled
        => AsReference("smb_access_based_enumeration_enabled");

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SmbNonBrowsableEnabled
        => AsReference("smb_non_browsable_enabled");

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    public TerraformValue<double> StorageQuotaInGb
        => AsReference("storage_quota_in_gb");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    public TerraformValue<string> VolumePath
        => AsReference("volume_path");

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string> Zone
        => AsReference("zone");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

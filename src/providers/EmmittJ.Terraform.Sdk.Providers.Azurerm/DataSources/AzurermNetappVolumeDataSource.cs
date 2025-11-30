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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    public TerraformValue<string>? SecurityStyle
    {
        get => new TerraformReference<string>(this, "security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    public TerraformValue<string> AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => new TerraformReference<string>(this, "accept_grow_capacity_pool_for_short_term_clone_split");
    }

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataProtectionBackupPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_protection_backup_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataProtectionReplication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_protection_replication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformValue<string> EncryptionKeySource
    {
        get => new TerraformReference<string>(this, "encryption_key_source");
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultPrivateEndpointId
    {
        get => new TerraformReference<string>(this, "key_vault_private_endpoint_id");
    }

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LargeVolumeEnabled
    {
        get => new TerraformReference<bool>(this, "large_volume_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> MountIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformValue<string> NetworkFeatures
    {
        get => new TerraformReference<string>(this, "network_features");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
    }

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SmbAccessBasedEnumerationEnabled
    {
        get => new TerraformReference<bool>(this, "smb_access_based_enumeration_enabled");
    }

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SmbNonBrowsableEnabled
    {
        get => new TerraformReference<bool>(this, "smb_non_browsable_enabled");
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    public TerraformValue<double> StorageQuotaInGb
    {
        get => new TerraformReference<double>(this, "storage_quota_in_gb");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    public TerraformValue<string> VolumePath
    {
        get => new TerraformReference<string>(this, "volume_path");
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

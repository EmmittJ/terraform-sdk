using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    [TerraformArgument("pool_name")]
    public required TerraformValue<string> PoolName
    {
        get => new TerraformReference<string>(this, "pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    [TerraformArgument("security_style")]
    public TerraformValue<string>? SecurityStyle
    {
        get => new TerraformReference<string>(this, "security_style");
        set => SetArgument("security_style", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNetappVolumeDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    [TerraformArgument("accept_grow_capacity_pool_for_short_term_clone_split")]
    public TerraformValue<string> AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => new TerraformReference<string>(this, "accept_grow_capacity_pool_for_short_term_clone_split");
    }

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    [TerraformArgument("data_protection_backup_policy")]
    public TerraformList<object> DataProtectionBackupPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "data_protection_backup_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    [TerraformArgument("data_protection_replication")]
    public TerraformList<object> DataProtectionReplication
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "data_protection_replication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    [TerraformArgument("encryption_key_source")]
    public TerraformValue<string> EncryptionKeySource
    {
        get => new TerraformReference<string>(this, "encryption_key_source");
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_private_endpoint_id")]
    public TerraformValue<string> KeyVaultPrivateEndpointId
    {
        get => new TerraformReference<string>(this, "key_vault_private_endpoint_id");
    }

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    [TerraformArgument("large_volume_enabled")]
    public TerraformValue<bool> LargeVolumeEnabled
    {
        get => new TerraformReference<bool>(this, "large_volume_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("mount_ip_addresses")]
    public TerraformList<string> MountIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "mount_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    [TerraformArgument("network_features")]
    public TerraformValue<string> NetworkFeatures
    {
        get => new TerraformReference<string>(this, "network_features");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformArgument("protocols")]
    public TerraformList<string> Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformArgument("service_level")]
    public TerraformValue<string> ServiceLevel
    {
        get => new TerraformReference<string>(this, "service_level");
    }

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    [TerraformArgument("smb_access_based_enumeration_enabled")]
    public TerraformValue<bool> SmbAccessBasedEnumerationEnabled
    {
        get => new TerraformReference<bool>(this, "smb_access_based_enumeration_enabled");
    }

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    [TerraformArgument("smb_non_browsable_enabled")]
    public TerraformValue<bool> SmbNonBrowsableEnabled
    {
        get => new TerraformReference<bool>(this, "smb_non_browsable_enabled");
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    [TerraformArgument("storage_quota_in_gb")]
    public TerraformValue<double> StorageQuotaInGb
    {
        get => new TerraformReference<double>(this, "storage_quota_in_gb");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    [TerraformArgument("volume_path")]
    public TerraformValue<string> VolumePath
    {
        get => new TerraformReference<string>(this, "volume_path");
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformArgument("zone")]
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
    }

}

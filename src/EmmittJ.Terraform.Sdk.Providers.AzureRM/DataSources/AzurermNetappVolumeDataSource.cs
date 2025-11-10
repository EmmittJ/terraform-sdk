using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_volume.
/// </summary>
public class AzurermNetappVolumeDataSource : TerraformDataSource
{
    public AzurermNetappVolumeDataSource(string name) : base("azurerm_netapp_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accept_grow_capacity_pool_for_short_term_clone_split");
        this.DeclareOutput("data_protection_backup_policy");
        this.DeclareOutput("data_protection_replication");
        this.DeclareOutput("encryption_key_source");
        this.DeclareOutput("key_vault_private_endpoint_id");
        this.DeclareOutput("large_volume_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("mount_ip_addresses");
        this.DeclareOutput("network_features");
        this.DeclareOutput("protocols");
        this.DeclareOutput("service_level");
        this.DeclareOutput("smb_access_based_enumeration_enabled");
        this.DeclareOutput("smb_non_browsable_enabled");
        this.DeclareOutput("storage_quota_in_gb");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("volume_path");
        this.DeclareOutput("zone");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetProperty<TerraformProperty<string>>("pool_name");
        set => this.WithProperty("pool_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetappVolumeDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetappVolumeDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The accept grow capacity pool for short term clone split property.
    /// </summary>
    public TerraformExpression AcceptGrowCapacityPoolForShortTermCloneSplit => this["accept_grow_capacity_pool_for_short_term_clone_split"];

    /// <summary>
    /// The data_protection_backup_policy attribute.
    /// </summary>
    public TerraformExpression DataProtectionBackupPolicy => this["data_protection_backup_policy"];

    /// <summary>
    /// The data_protection_replication attribute.
    /// </summary>
    public TerraformExpression DataProtectionReplication => this["data_protection_replication"];

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformExpression EncryptionKeySource => this["encryption_key_source"];

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformExpression KeyVaultPrivateEndpointId => this["key_vault_private_endpoint_id"];

    /// <summary>
    /// The large_volume_enabled attribute.
    /// </summary>
    public TerraformExpression LargeVolumeEnabled => this["large_volume_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformExpression MountIpAddresses => this["mount_ip_addresses"];

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformExpression NetworkFeatures => this["network_features"];

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformExpression Protocols => this["protocols"];

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformExpression ServiceLevel => this["service_level"];

    /// <summary>
    /// The smb_access_based_enumeration_enabled attribute.
    /// </summary>
    public TerraformExpression SmbAccessBasedEnumerationEnabled => this["smb_access_based_enumeration_enabled"];

    /// <summary>
    /// The smb_non_browsable_enabled attribute.
    /// </summary>
    public TerraformExpression SmbNonBrowsableEnabled => this["smb_non_browsable_enabled"];

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    public TerraformExpression StorageQuotaInGb => this["storage_quota_in_gb"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    public TerraformExpression VolumePath => this["volume_path"];

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformExpression Zone => this["zone"];

}

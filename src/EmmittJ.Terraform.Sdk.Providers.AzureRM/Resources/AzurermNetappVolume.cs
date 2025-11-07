using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_volume resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_grow_capacity_pool_for_short_term_clone_split");
        set => this.WithProperty("accept_grow_capacity_pool_for_short_term_clone_split", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AzureVmwareDataStoreEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azure_vmware_data_store_enabled");
        set => this.WithProperty("azure_vmware_data_store_enabled", value);
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CreateFromSnapshotResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_from_snapshot_resource_id");
        set => this.WithProperty("create_from_snapshot_resource_id", value);
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptionKeySource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key_source");
        set => this.WithProperty("encryption_key_source", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public TerraformLiteralProperty<bool>? KerberosEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kerberos_enabled");
        set => this.WithProperty("kerberos_enabled", value);
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultPrivateEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_private_endpoint_id");
        set => this.WithProperty("key_vault_private_endpoint_id", value);
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public TerraformLiteralProperty<bool>? LargeVolumeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("large_volume_enabled");
        set => this.WithProperty("large_volume_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkFeatures
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_features");
        set => this.WithProperty("network_features", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_name");
        set => this.WithProperty("pool_name", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_style");
        set => this.WithProperty("security_style", value);
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_level");
        set => this.WithProperty("service_level", value);
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public TerraformLiteralProperty<bool>? Smb3ProtocolEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb3_protocol_encryption_enabled");
        set => this.WithProperty("smb3_protocol_encryption_enabled", value);
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public TerraformLiteralProperty<bool>? SmbAccessBasedEnumerationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_access_based_enumeration_enabled");
        set => this.WithProperty("smb_access_based_enumeration_enabled", value);
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public TerraformLiteralProperty<bool>? SmbContinuousAvailabilityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_continuous_availability_enabled");
        set => this.WithProperty("smb_continuous_availability_enabled", value);
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public TerraformLiteralProperty<bool>? SmbNonBrowsableEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_non_browsable_enabled");
        set => this.WithProperty("smb_non_browsable_enabled", value);
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SnapshotDirectoryVisible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("snapshot_directory_visible");
        set => this.WithProperty("snapshot_directory_visible", value);
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StorageQuotaInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_quota_in_gb");
        set => this.WithProperty("storage_quota_in_gb", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ThroughputInMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_in_mibps");
        set => this.WithProperty("throughput_in_mibps", value);
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_path");
        set => this.WithProperty("volume_path", value);
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformExpression MountIpAddresses => this["mount_ip_addresses"];

}

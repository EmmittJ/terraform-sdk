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
    public string? AcceptGrowCapacityPoolForShortTermCloneSplit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accept_grow_capacity_pool_for_short_term_clone_split")?.Value;
        set => this.WithProperty("accept_grow_capacity_pool_for_short_term_clone_split", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The azure_vmware_data_store_enabled attribute.
    /// </summary>
    public bool? AzureVmwareDataStoreEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("azure_vmware_data_store_enabled")?.Value;
        set => this.WithProperty("azure_vmware_data_store_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The create_from_snapshot_resource_id attribute.
    /// </summary>
    public string? CreateFromSnapshotResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_from_snapshot_resource_id")?.Value;
        set => this.WithProperty("create_from_snapshot_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_key_source attribute.
    /// </summary>
    public string? EncryptionKeySource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key_source")?.Value;
        set => this.WithProperty("encryption_key_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Enable to allow Kerberos secured volumes. Requires appropriate export rules as well as the parent `azurerm_netapp_account` having a defined AD connection.
    /// </summary>
    public bool? KerberosEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("kerberos_enabled")?.Value;
        set => this.WithProperty("kerberos_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_vault_private_endpoint_id attribute.
    /// </summary>
    public string? KeyVaultPrivateEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_private_endpoint_id")?.Value;
        set => this.WithProperty("key_vault_private_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether the volume is a large volume.
    /// </summary>
    public bool? LargeVolumeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("large_volume_enabled")?.Value;
        set => this.WithProperty("large_volume_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_features attribute.
    /// </summary>
    public string? NetworkFeatures
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_features")?.Value;
        set => this.WithProperty("network_features", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    public string? PoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_name")?.Value;
        set => this.WithProperty("pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<string>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols")?.Value;
        set => this.WithProperty("protocols", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public string? SecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_style")?.Value;
        set => this.WithProperty("security_style", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    public string? ServiceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_level")?.Value;
        set => this.WithProperty("service_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// SMB3 encryption option should be used only for SMB/DualProtocol volumes. Using it for any other workloads is not supported.
    /// </summary>
    public bool? Smb3ProtocolEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb3_protocol_encryption_enabled")?.Value;
        set => this.WithProperty("smb3_protocol_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Enable access based enumeration setting for SMB/Dual Protocol volume. When enabled, users who do not have permission to access a shared folder or file underneath it, do not see that shared resource displayed in their environment.
    /// </summary>
    public bool? SmbAccessBasedEnumerationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_access_based_enumeration_enabled")?.Value;
        set => this.WithProperty("smb_access_based_enumeration_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Continuous availability option should be used only for SQL and FSLogix workloads. Using it for any other SMB workloads is not supported.
    /// </summary>
    public bool? SmbContinuousAvailabilityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_continuous_availability_enabled")?.Value;
        set => this.WithProperty("smb_continuous_availability_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Enable non browsable share setting for SMB/Dual Protocol volume. When enabled, it restricts windows clients to browse the share
    /// </summary>
    public bool? SmbNonBrowsableEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("smb_non_browsable_enabled")?.Value;
        set => this.WithProperty("smb_non_browsable_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The snapshot_directory_visible attribute.
    /// </summary>
    public bool? SnapshotDirectoryVisible
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("snapshot_directory_visible")?.Value;
        set => this.WithProperty("snapshot_directory_visible", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_quota_in_gb attribute.
    /// </summary>
    public double? StorageQuotaInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_quota_in_gb")?.Value;
        set => this.WithProperty("storage_quota_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The throughput_in_mibps attribute.
    /// </summary>
    public double? ThroughputInMibps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("throughput_in_mibps")?.Value;
        set => this.WithProperty("throughput_in_mibps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The volume_path attribute.
    /// </summary>
    public string? VolumePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_path")?.Value;
        set => this.WithProperty("volume_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mount_ip_addresses attribute.
    /// </summary>
    public TerraformExpression MountIpAddresses => this["mount_ip_addresses"];

}

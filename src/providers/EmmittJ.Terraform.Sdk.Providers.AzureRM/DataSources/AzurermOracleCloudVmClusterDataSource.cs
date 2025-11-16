using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_cloud_vm_cluster Terraform data source.
/// Retrieves information about a azurerm_oracle_cloud_vm_cluster.
/// </summary>
public partial class AzurermOracleCloudVmClusterDataSource(string name) : TerraformDataSource("azurerm_oracle_cloud_vm_cluster", name)
{
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> BackupSubnetCidr
    {
        get => new TerraformReference<string>(this, "backup_subnet_cidr");
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
    }

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    public TerraformValue<string> CompartmentId
    {
        get => new TerraformReference<string>(this, "compartment_id");
    }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    public TerraformList<string> ComputeNodes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "compute_nodes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataCollectionOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_collection_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformValue<double> DataStoragePercentage
    {
        get => new TerraformReference<double>(this, "data_storage_percentage");
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformList<string> DbServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "db_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    public TerraformValue<string> DiskRedundancy
    {
        get => new TerraformReference<string>(this, "disk_redundancy");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FileSystemConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "file_system_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    public TerraformValue<string> GiVersion
    {
        get => new TerraformReference<string>(this, "gi_version");
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformValue<string> HostnameActual
    {
        get => new TerraformReference<string>(this, "hostname_actual");
    }

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "iorm_config_cache").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
    {
        get => new TerraformReference<string>(this, "last_update_history_entry_id");
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
    }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
    {
        get => new TerraformReference<string>(this, "lifecycle_details");
    }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
    {
        get => new TerraformReference<string>(this, "lifecycle_state");
    }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    public TerraformValue<double> ListenerPort
    {
        get => new TerraformReference<double>(this, "listener_port");
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalBackupEnabled
    {
        get => new TerraformReference<bool>(this, "local_backup_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    public TerraformValue<string> NsgUrl
    {
        get => new TerraformReference<string>(this, "nsg_url");
    }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    public TerraformValue<double> OcpuCount
    {
        get => new TerraformReference<double>(this, "ocpu_count");
    }

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    public TerraformValue<string> ScanDnsName
    {
        get => new TerraformReference<string>(this, "scan_dns_name");
    }

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
    {
        get => new TerraformReference<string>(this, "scan_dns_record_id");
    }

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    public TerraformList<string> ScanIpIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scan_ip_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcp
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp");
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcpSsl
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp_ssl");
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SparseDiskgroupEnabled
    {
        get => new TerraformReference<bool>(this, "sparse_diskgroup_enabled");
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    public TerraformList<string> SshPublicKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssh_public_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "storage_size_in_gbs");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    public TerraformValue<string> SubnetOcid
    {
        get => new TerraformReference<string>(this, "subnet_ocid");
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformValue<string> SystemVersion
    {
        get => new TerraformReference<string>(this, "system_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
    }

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    public TerraformList<string> VipOds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vip_ods").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleCloudVmClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleCloudVmClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

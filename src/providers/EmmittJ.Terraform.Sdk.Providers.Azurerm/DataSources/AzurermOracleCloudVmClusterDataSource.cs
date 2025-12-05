using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleCloudVmClusterDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> BackupSubnetCidr
        => CreateReference("backup_subnet_cidr");

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
        => CreateReference("cloud_exadata_infrastructure_id");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterName
        => CreateReference("cluster_name");

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    public TerraformValue<string> CompartmentId
        => CreateReference("compartment_id");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    public TerraformList<string> ComputeNodes
        => CreateReference("compute_nodes");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => CreateReference("cpu_core_count");

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataCollectionOptions
        => CreateReference("data_collection_options");

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformValue<double> DataStoragePercentage
        => CreateReference("data_storage_percentage");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformList<string> DbServers
        => CreateReference("db_servers");

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    public TerraformValue<string> DiskRedundancy
        => CreateReference("disk_redundancy");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => CreateReference("domain");

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FileSystemConfiguration
        => CreateReference("file_system_configuration");

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    public TerraformValue<string> GiVersion
        => CreateReference("gi_version");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => CreateReference("hostname");

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformValue<string> HostnameActual
        => CreateReference("hostname_actual");

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
        => CreateReference("iorm_config_cache");

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
        => CreateReference("last_update_history_entry_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => CreateReference("license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => CreateReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => CreateReference("lifecycle_state");

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    public TerraformValue<double> ListenerPort
        => CreateReference("listener_port");

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalBackupEnabled
        => CreateReference("local_backup_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => CreateReference("memory_size_in_gbs");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformValue<double> NodeCount
        => CreateReference("node_count");

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    public TerraformValue<string> NsgUrl
        => CreateReference("nsg_url");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    public TerraformValue<double> OcpuCount
        => CreateReference("ocpu_count");

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    public TerraformValue<string> ScanDnsName
        => CreateReference("scan_dns_name");

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
        => CreateReference("scan_dns_record_id");

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    public TerraformList<string> ScanIpIds
        => CreateReference("scan_ip_ids");

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcp
        => CreateReference("scan_listener_port_tcp");

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcpSsl
        => CreateReference("scan_listener_port_tcp_ssl");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformValue<string> Shape
        => CreateReference("shape");

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SparseDiskgroupEnabled
        => CreateReference("sparse_diskgroup_enabled");

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    public TerraformList<string> SshPublicKeys
        => CreateReference("ssh_public_keys");

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
        => CreateReference("storage_size_in_gbs");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    public TerraformValue<string> SubnetOcid
        => CreateReference("subnet_ocid");

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformValue<string> SystemVersion
        => CreateReference("system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => CreateReference("time_created");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
        => CreateReference("time_zone");

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    public TerraformList<string> VipOds
        => CreateReference("vip_ods");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkId
        => CreateReference("virtual_network_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => CreateReference("zone_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleCloudVmClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleCloudVmClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

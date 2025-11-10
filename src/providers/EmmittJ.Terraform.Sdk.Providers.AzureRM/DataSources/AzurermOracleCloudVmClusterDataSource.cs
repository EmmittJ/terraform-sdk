using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_cloud_vm_cluster.
/// </summary>
public class AzurermOracleCloudVmClusterDataSource : TerraformDataSource
{
    public AzurermOracleCloudVmClusterDataSource(string name) : base("azurerm_oracle_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleCloudVmClusterDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackupSubnetCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_subnet_cidr");

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloud_exadata_infrastructure_id");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_name");

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    [TerraformPropertyName("compartment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompartmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compartment_id");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    [TerraformPropertyName("compute_nodes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ComputeNodes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "compute_nodes");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    [TerraformPropertyName("data_collection_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataCollectionOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_collection_options");

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStoragePercentage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_percentage");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DbServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "db_servers");

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskRedundancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_redundancy");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    [TerraformPropertyName("file_system_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FileSystemConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "file_system_configuration");

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [TerraformPropertyName("gi_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GiVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gi_version");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformPropertyName("hostname_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostnameActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname_actual");

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    [TerraformPropertyName("iorm_config_cache")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IormConfigCache => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "iorm_config_cache");

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    [TerraformPropertyName("last_update_history_entry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdateHistoryEntryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_update_history_entry_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleDetails => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [TerraformPropertyName("listener_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ListenerPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "listener_port");

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalBackupEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_backup_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    [TerraformPropertyName("nsg_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NsgUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nsg_url");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    [TerraformPropertyName("ocpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> OcpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ocpu_count");

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("scan_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_name");

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    [TerraformPropertyName("scan_dns_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_record_id");

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    [TerraformPropertyName("scan_ip_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ScanIpIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "scan_ip_ids");

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTcp => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scan_listener_port_tcp");

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp_ssl")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTcpSsl => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scan_listener_port_tcp_ssl");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SparseDiskgroupEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "sparse_diskgroup_enabled");

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [TerraformPropertyName("ssh_public_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SshPublicKeys => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ssh_public_keys");

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_size_in_gbs");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubnetOcid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_ocid");

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SystemVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_created");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    [TerraformPropertyName("vip_ods")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VipOds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vip_ods");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_network_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

}

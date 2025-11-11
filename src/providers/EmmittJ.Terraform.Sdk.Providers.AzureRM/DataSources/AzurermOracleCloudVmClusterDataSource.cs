using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleCloudVmClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupSubnetCidr => new TerraformReference(this, "backup_subnet_cidr");

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudExadataInfrastructureId => new TerraformReference(this, "cloud_exadata_infrastructure_id");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterName => new TerraformReference(this, "cluster_name");

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    [TerraformPropertyName("compartment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompartmentId => new TerraformReference(this, "compartment_id");

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    [TerraformPropertyName("compute_nodes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ComputeNodes => new TerraformReference(this, "compute_nodes");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    [TerraformPropertyName("data_collection_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataCollectionOptions => new TerraformReference(this, "data_collection_options");

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStoragePercentage => new TerraformReference(this, "data_storage_percentage");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DbServers => new TerraformReference(this, "db_servers");

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DiskRedundancy => new TerraformReference(this, "disk_redundancy");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    [TerraformPropertyName("file_system_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FileSystemConfiguration => new TerraformReference(this, "file_system_configuration");

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [TerraformPropertyName("gi_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GiVersion => new TerraformReference(this, "gi_version");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformPropertyName("hostname_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostnameActual => new TerraformReference(this, "hostname_actual");

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    [TerraformPropertyName("iorm_config_cache")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IormConfigCache => new TerraformReference(this, "iorm_config_cache");

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    [TerraformPropertyName("last_update_history_entry_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdateHistoryEntryId => new TerraformReference(this, "last_update_history_entry_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_details")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleDetails => new TerraformReference(this, "lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [TerraformPropertyName("listener_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ListenerPort => new TerraformReference(this, "listener_port");

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalBackupEnabled => new TerraformReference(this, "local_backup_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NodeCount => new TerraformReference(this, "node_count");

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    [TerraformPropertyName("nsg_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NsgUrl => new TerraformReference(this, "nsg_url");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    [TerraformPropertyName("ocpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> OcpuCount => new TerraformReference(this, "ocpu_count");

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    [TerraformPropertyName("scan_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScanDnsName => new TerraformReference(this, "scan_dns_name");

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    [TerraformPropertyName("scan_dns_record_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScanDnsRecordId => new TerraformReference(this, "scan_dns_record_id");

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    [TerraformPropertyName("scan_ip_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ScanIpIds => new TerraformReference(this, "scan_ip_ids");

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScanListenerPortTcp => new TerraformReference(this, "scan_listener_port_tcp");

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp_ssl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScanListenerPortTcpSsl => new TerraformReference(this, "scan_listener_port_tcp_ssl");

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SparseDiskgroupEnabled => new TerraformReference(this, "sparse_diskgroup_enabled");

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [TerraformPropertyName("ssh_public_keys")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SshPublicKeys => new TerraformReference(this, "ssh_public_keys");

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> StorageSizeInGbs => new TerraformReference(this, "storage_size_in_gbs");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetId => new TerraformReference(this, "subnet_id");

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubnetOcid => new TerraformReference(this, "subnet_ocid");

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SystemVersion => new TerraformReference(this, "system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformPropertyName("time_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeCreated => new TerraformReference(this, "time_created");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeZone => new TerraformReference(this, "time_zone");

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    [TerraformPropertyName("vip_ods")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VipOds => new TerraformReference(this, "vip_ods");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkId => new TerraformReference(this, "virtual_network_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneId => new TerraformReference(this, "zone_id");

}

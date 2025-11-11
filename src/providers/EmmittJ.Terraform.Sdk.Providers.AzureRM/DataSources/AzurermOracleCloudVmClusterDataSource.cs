using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleCloudVmClusterDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_cloud_vm_cluster.
/// </summary>
public partial class AzurermOracleCloudVmClusterDataSource : TerraformDataSource
{
    public AzurermOracleCloudVmClusterDataSource(string name) : base("azurerm_oracle_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermOracleCloudVmClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("backup_subnet_cidr")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BackupSubnetCidr { get; }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudExadataInfrastructureId { get; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformProperty("cluster_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterName { get; }

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    [TerraformProperty("compartment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CompartmentId { get; }

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    [TerraformProperty("compute_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ComputeNodes { get; }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    [TerraformProperty("data_collection_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DataCollectionOptions { get; }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformProperty("data_storage_percentage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStoragePercentage { get; }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [TerraformProperty("db_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> DbServers { get; }

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    [TerraformProperty("disk_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiskRedundancy { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    [TerraformProperty("file_system_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> FileSystemConfiguration { get; }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [TerraformProperty("gi_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GiVersion { get; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformProperty("hostname_actual")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostnameActual { get; }

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    [TerraformProperty("iorm_config_cache")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IormConfigCache { get; }

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    [TerraformProperty("last_update_history_entry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdateHistoryEntryId { get; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    [TerraformProperty("lifecycle_details")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleDetails { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    [TerraformProperty("listener_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ListenerPort { get; }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("local_backup_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LocalBackupEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    [TerraformProperty("nsg_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NsgUrl { get; }

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    [TerraformProperty("ocpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> OcpuCount { get; }

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    [TerraformProperty("scan_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScanDnsName { get; }

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    [TerraformProperty("scan_dns_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScanDnsRecordId { get; }

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    [TerraformProperty("scan_ip_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ScanIpIds { get; }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformProperty("scan_listener_port_tcp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ScanListenerPortTcp { get; }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformProperty("scan_listener_port_tcp_ssl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ScanListenerPortTcpSsl { get; }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Shape { get; }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformProperty("sparse_diskgroup_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SparseDiskgroupEnabled { get; }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [TerraformProperty("ssh_public_keys")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SshPublicKeys { get; }

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StorageSizeInGbs { get; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetId { get; }

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    [TerraformProperty("subnet_ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubnetOcid { get; }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformProperty("system_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SystemVersion { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    [TerraformProperty("time_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeCreated { get; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TimeZone { get; }

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    [TerraformProperty("vip_ods")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> VipOds { get; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkId { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ZoneId { get; }

}

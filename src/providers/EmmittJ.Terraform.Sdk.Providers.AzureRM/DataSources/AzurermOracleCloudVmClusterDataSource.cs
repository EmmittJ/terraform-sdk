using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_oracle_cloud_vm_cluster.
/// </summary>
public class AzurermOracleCloudVmClusterDataSource : TerraformDataSource
{
    public AzurermOracleCloudVmClusterDataSource(string name) : base("azurerm_oracle_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_subnet_cidr");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("cluster_name");
        SetOutput("compartment_id");
        SetOutput("compute_model");
        SetOutput("compute_nodes");
        SetOutput("cpu_core_count");
        SetOutput("data_collection_options");
        SetOutput("data_storage_percentage");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_servers");
        SetOutput("disk_redundancy");
        SetOutput("display_name");
        SetOutput("domain");
        SetOutput("file_system_configuration");
        SetOutput("gi_version");
        SetOutput("hostname");
        SetOutput("hostname_actual");
        SetOutput("iorm_config_cache");
        SetOutput("last_update_history_entry_id");
        SetOutput("license_model");
        SetOutput("lifecycle_details");
        SetOutput("lifecycle_state");
        SetOutput("listener_port");
        SetOutput("local_backup_enabled");
        SetOutput("location");
        SetOutput("memory_size_in_gbs");
        SetOutput("node_count");
        SetOutput("nsg_url");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("ocpu_count");
        SetOutput("scan_dns_name");
        SetOutput("scan_dns_record_id");
        SetOutput("scan_ip_ids");
        SetOutput("scan_listener_port_tcp");
        SetOutput("scan_listener_port_tcp_ssl");
        SetOutput("shape");
        SetOutput("sparse_diskgroup_enabled");
        SetOutput("ssh_public_keys");
        SetOutput("storage_size_in_gbs");
        SetOutput("subnet_id");
        SetOutput("subnet_ocid");
        SetOutput("system_version");
        SetOutput("tags");
        SetOutput("time_created");
        SetOutput("time_zone");
        SetOutput("vip_ods");
        SetOutput("virtual_network_id");
        SetOutput("zone_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleCloudVmClusterDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformExpression BackupSubnetCidr => this["backup_subnet_cidr"];

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    public TerraformExpression CloudExadataInfrastructureId => this["cloud_exadata_infrastructure_id"];

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformExpression ClusterName => this["cluster_name"];

    /// <summary>
    /// The compartment_id attribute.
    /// </summary>
    public TerraformExpression CompartmentId => this["compartment_id"];

    /// <summary>
    /// The compute_model attribute.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The compute_nodes attribute.
    /// </summary>
    public TerraformExpression ComputeNodes => this["compute_nodes"];

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The data_collection_options attribute.
    /// </summary>
    public TerraformExpression DataCollectionOptions => this["data_collection_options"];

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformExpression DataStoragePercentage => this["data_storage_percentage"];

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

    /// <summary>
    /// The disk_redundancy attribute.
    /// </summary>
    public TerraformExpression DiskRedundancy => this["disk_redundancy"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The file_system_configuration attribute.
    /// </summary>
    public TerraformExpression FileSystemConfiguration => this["file_system_configuration"];

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    public TerraformExpression GiVersion => this["gi_version"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformExpression HostnameActual => this["hostname_actual"];

    /// <summary>
    /// The iorm_config_cache attribute.
    /// </summary>
    public TerraformExpression IormConfigCache => this["iorm_config_cache"];

    /// <summary>
    /// The last_update_history_entry_id attribute.
    /// </summary>
    public TerraformExpression LastUpdateHistoryEntryId => this["last_update_history_entry_id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformExpression LifecycleDetails => this["lifecycle_details"];

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformExpression LifecycleState => this["lifecycle_state"];

    /// <summary>
    /// The listener_port attribute.
    /// </summary>
    public TerraformExpression ListenerPort => this["listener_port"];

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformExpression LocalBackupEnabled => this["local_backup_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The nsg_url attribute.
    /// </summary>
    public TerraformExpression NsgUrl => this["nsg_url"];

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The ocpu_count attribute.
    /// </summary>
    public TerraformExpression OcpuCount => this["ocpu_count"];

    /// <summary>
    /// The scan_dns_name attribute.
    /// </summary>
    public TerraformExpression ScanDnsName => this["scan_dns_name"];

    /// <summary>
    /// The scan_dns_record_id attribute.
    /// </summary>
    public TerraformExpression ScanDnsRecordId => this["scan_dns_record_id"];

    /// <summary>
    /// The scan_ip_ids attribute.
    /// </summary>
    public TerraformExpression ScanIpIds => this["scan_ip_ids"];

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformExpression ScanListenerPortTcp => this["scan_listener_port_tcp"];

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformExpression ScanListenerPortTcpSsl => this["scan_listener_port_tcp_ssl"];

    /// <summary>
    /// The shape attribute.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformExpression SparseDiskgroupEnabled => this["sparse_diskgroup_enabled"];

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    public TerraformExpression SshPublicKeys => this["ssh_public_keys"];

    /// <summary>
    /// The storage_size_in_gbs attribute.
    /// </summary>
    public TerraformExpression StorageSizeInGbs => this["storage_size_in_gbs"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The subnet_ocid attribute.
    /// </summary>
    public TerraformExpression SubnetOcid => this["subnet_ocid"];

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformExpression SystemVersion => this["system_version"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformExpression TimeZone => this["time_zone"];

    /// <summary>
    /// The vip_ods attribute.
    /// </summary>
    public TerraformExpression VipOds => this["vip_ods"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("backup_subnet_cidr");
        this.DeclareOutput("cloud_exadata_infrastructure_id");
        this.DeclareOutput("cluster_name");
        this.DeclareOutput("compartment_id");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("compute_nodes");
        this.DeclareOutput("cpu_core_count");
        this.DeclareOutput("data_collection_options");
        this.DeclareOutput("data_storage_percentage");
        this.DeclareOutput("data_storage_size_in_tbs");
        this.DeclareOutput("db_node_storage_size_in_gbs");
        this.DeclareOutput("db_servers");
        this.DeclareOutput("disk_redundancy");
        this.DeclareOutput("display_name");
        this.DeclareOutput("domain");
        this.DeclareOutput("file_system_configuration");
        this.DeclareOutput("gi_version");
        this.DeclareOutput("hostname");
        this.DeclareOutput("hostname_actual");
        this.DeclareOutput("iorm_config_cache");
        this.DeclareOutput("last_update_history_entry_id");
        this.DeclareOutput("license_model");
        this.DeclareOutput("lifecycle_details");
        this.DeclareOutput("lifecycle_state");
        this.DeclareOutput("listener_port");
        this.DeclareOutput("local_backup_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("memory_size_in_gbs");
        this.DeclareOutput("node_count");
        this.DeclareOutput("nsg_url");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("ocpu_count");
        this.DeclareOutput("scan_dns_name");
        this.DeclareOutput("scan_dns_record_id");
        this.DeclareOutput("scan_ip_ids");
        this.DeclareOutput("scan_listener_port_tcp");
        this.DeclareOutput("scan_listener_port_tcp_ssl");
        this.DeclareOutput("shape");
        this.DeclareOutput("sparse_diskgroup_enabled");
        this.DeclareOutput("ssh_public_keys");
        this.DeclareOutput("storage_size_in_gbs");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("subnet_ocid");
        this.DeclareOutput("system_version");
        this.DeclareOutput("tags");
        this.DeclareOutput("time_created");
        this.DeclareOutput("time_zone");
        this.DeclareOutput("vip_ods");
        this.DeclareOutput("virtual_network_id");
        this.DeclareOutput("zone_id");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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

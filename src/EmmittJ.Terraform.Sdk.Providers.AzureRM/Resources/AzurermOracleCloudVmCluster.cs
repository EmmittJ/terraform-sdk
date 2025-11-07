using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_oracle_cloud_vm_cluster resource.
/// </summary>
public class AzurermOracleCloudVmCluster : TerraformResource
{
    public AzurermOracleCloudVmCluster(string name) : base("azurerm_oracle_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("hostname_actual");
        this.DeclareOutput("ocid");
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformProperty<string>? BackupSubnetCidr
    {
        get => GetProperty<TerraformProperty<string>>("backup_subnet_cidr");
        set => this.WithProperty("backup_subnet_cidr", value);
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    public TerraformProperty<string>? CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => this.WithProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public TerraformProperty<double>? CpuCoreCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_core_count");
        set => this.WithProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? DataStoragePercentage
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_percentage");
        set => this.WithProperty("data_storage_percentage", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeInTbs
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_in_tbs");
        set => this.WithProperty("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeInGbs
    {
        get => GetProperty<TerraformProperty<double>>("db_node_storage_size_in_gbs");
        set => this.WithProperty("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformProperty<List<string>>? DbServers
    {
        get => GetProperty<TerraformProperty<List<string>>>("db_servers");
        set => this.WithProperty("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    public TerraformProperty<string>? GiVersion
    {
        get => GetProperty<TerraformProperty<string>>("gi_version");
        set => this.WithProperty("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
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
    /// The license_model attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_backup_enabled");
        set => this.WithProperty("local_backup_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformProperty<double>? MemorySizeInGbs
    {
        get => GetProperty<TerraformProperty<double>>("memory_size_in_gbs");
        set => this.WithProperty("memory_size_in_gbs", value);
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
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcp
    {
        get => GetProperty<TerraformProperty<double>>("scan_listener_port_tcp");
        set => this.WithProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcpSsl
    {
        get => GetProperty<TerraformProperty<double>>("scan_listener_port_tcp_ssl");
        set => this.WithProperty("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SparseDiskgroupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sparse_diskgroup_enabled");
        set => this.WithProperty("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SshPublicKeys
    {
        get => GetProperty<TerraformProperty<List<string>>>("ssh_public_keys");
        set => this.WithProperty("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformProperty<string>? SystemVersion
    {
        get => GetProperty<TerraformProperty<string>>("system_version");
        set => this.WithProperty("system_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformExpression HostnameActual => this["hostname_actual"];

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

}

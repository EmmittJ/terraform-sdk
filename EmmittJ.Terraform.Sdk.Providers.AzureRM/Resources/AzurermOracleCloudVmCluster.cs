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
    public string? BackupSubnetCidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_subnet_cidr")?.Value;
        set => this.WithProperty("backup_subnet_cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    public string? CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_exadata_infrastructure_id")?.Value;
        set => this.WithProperty("cloud_exadata_infrastructure_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    public double? CpuCoreCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cpu_core_count")?.Value;
        set => this.WithProperty("cpu_core_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public double? DataStoragePercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_storage_percentage")?.Value;
        set => this.WithProperty("data_storage_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public double? DataStorageSizeInTbs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_storage_size_in_tbs")?.Value;
        set => this.WithProperty("data_storage_size_in_tbs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public double? DbNodeStorageSizeInGbs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("db_node_storage_size_in_gbs")?.Value;
        set => this.WithProperty("db_node_storage_size_in_gbs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public List<string>? DbServers
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("db_servers")?.Value;
        set => this.WithProperty("db_servers", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    public string? GiVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gi_version")?.Value;
        set => this.WithProperty("gi_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public string? Hostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname")?.Value;
        set => this.WithProperty("hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The license_model attribute.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public bool? LocalBackupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_backup_enabled")?.Value;
        set => this.WithProperty("local_backup_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public double? MemorySizeInGbs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("memory_size_in_gbs")?.Value;
        set => this.WithProperty("memory_size_in_gbs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public double? ScanListenerPortTcp
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scan_listener_port_tcp")?.Value;
        set => this.WithProperty("scan_listener_port_tcp", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public double? ScanListenerPortTcpSsl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scan_listener_port_tcp_ssl")?.Value;
        set => this.WithProperty("scan_listener_port_tcp_ssl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public bool? SparseDiskgroupEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sparse_diskgroup_enabled")?.Value;
        set => this.WithProperty("sparse_diskgroup_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    public List<string>? SshPublicKeys
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ssh_public_keys")?.Value;
        set => this.WithProperty("ssh_public_keys", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The system_version attribute.
    /// </summary>
    public string? SystemVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("system_version")?.Value;
        set => this.WithProperty("system_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The time_zone attribute.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public string? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id")?.Value;
        set => this.WithProperty("zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

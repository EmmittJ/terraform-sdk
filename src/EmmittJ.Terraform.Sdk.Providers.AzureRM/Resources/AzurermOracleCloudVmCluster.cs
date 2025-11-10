using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The diagnostics_events_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiagnosticsEventsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("diagnostics_events_enabled");
        set => WithProperty("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HealthMonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("health_monitoring_enabled");
        set => WithProperty("health_monitoring_enabled", value);
    }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IncidentLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("incident_logs_enabled");
        set => WithProperty("incident_logs_enabled", value);
    }

}

/// <summary>
/// Block type for file_system_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterFileSystemConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    public TerraformProperty<string>? MountPoint
    {
        get => GetProperty<TerraformProperty<string>>("mount_point");
        set => WithProperty("mount_point", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("size_in_gb");
        set => WithProperty("size_in_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_oracle_cloud_vm_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformProperty<double> CpuCoreCount
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public List<TerraformProperty<string>>? DbServers
    {
        get => GetProperty<List<TerraformProperty<string>>>("db_servers");
        set => this.WithProperty("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformProperty<string> GiVersion
    {
        get => GetProperty<TerraformProperty<string>>("gi_version");
        set => this.WithProperty("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformProperty<string> LicenseModel
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public List<TerraformProperty<string>>? SshPublicKeys
    {
        get => GetProperty<List<TerraformProperty<string>>>("ssh_public_keys");
        set => this.WithProperty("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformProperty<string> VirtualNetworkId
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
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    public List<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>? DataCollectionOptions
    {
        get => GetProperty<List<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>>("data_collection_options");
        set => this.WithProperty("data_collection_options", value);
    }

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>? FileSystemConfiguration
    {
        get => GetProperty<List<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>>("file_system_configuration");
        set => this.WithProperty("file_system_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleCloudVmClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleCloudVmClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

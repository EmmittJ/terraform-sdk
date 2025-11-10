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
        set => SetProperty("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HealthMonitoringEnabled
    {
        set => SetProperty("health_monitoring_enabled", value);
    }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IncidentLogsEnabled
    {
        set => SetProperty("incident_logs_enabled", value);
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
        set => SetProperty("mount_point", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? SizeInGb
    {
        set => SetProperty("size_in_gb", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("hostname_actual");
        SetOutput("ocid");
        SetOutput("backup_subnet_cidr");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("cluster_name");
        SetOutput("cpu_core_count");
        SetOutput("data_storage_percentage");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_servers");
        SetOutput("display_name");
        SetOutput("domain");
        SetOutput("gi_version");
        SetOutput("hostname");
        SetOutput("id");
        SetOutput("license_model");
        SetOutput("local_backup_enabled");
        SetOutput("location");
        SetOutput("memory_size_in_gbs");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("scan_listener_port_tcp");
        SetOutput("scan_listener_port_tcp_ssl");
        SetOutput("sparse_diskgroup_enabled");
        SetOutput("ssh_public_keys");
        SetOutput("subnet_id");
        SetOutput("system_version");
        SetOutput("tags");
        SetOutput("time_zone");
        SetOutput("virtual_network_id");
        SetOutput("zone_id");
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformProperty<string> BackupSubnetCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_subnet_cidr");
        set => SetProperty("backup_subnet_cidr", value);
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformProperty<double> CpuCoreCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cpu_core_count");
        set => SetProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformProperty<double> DataStoragePercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_storage_percentage");
        set => SetProperty("data_storage_percentage", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformProperty<double> DataStorageSizeInTbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_storage_size_in_tbs");
        set => SetProperty("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformProperty<double> DbNodeStorageSizeInGbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("db_node_storage_size_in_gbs");
        set => SetProperty("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public List<TerraformProperty<string>> DbServers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("db_servers");
        set => SetProperty("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformProperty<string> GiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gi_version");
        set => SetProperty("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostname");
        set => SetProperty("hostname", value);
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
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalBackupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_backup_enabled");
        set => SetProperty("local_backup_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformProperty<double> MemorySizeInGbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("memory_size_in_gbs");
        set => SetProperty("memory_size_in_gbs", value);
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
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformProperty<double> ScanListenerPortTcp
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scan_listener_port_tcp");
        set => SetProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformProperty<double> ScanListenerPortTcpSsl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scan_listener_port_tcp_ssl");
        set => SetProperty("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SparseDiskgroupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sparse_diskgroup_enabled");
        set => SetProperty("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public List<TerraformProperty<string>> SshPublicKeys
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ssh_public_keys");
        set => SetProperty("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformProperty<string> SystemVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("system_version");
        set => SetProperty("system_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
    }

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    public List<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>? DataCollectionOptions
    {
        set => SetProperty("data_collection_options", value);
    }

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>? FileSystemConfiguration
    {
        set => SetProperty("file_system_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleCloudVmClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

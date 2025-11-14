using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_collection_options";

    /// <summary>
    /// The diagnostics_events_enabled attribute.
    /// </summary>
    [TerraformArgument("diagnostics_events_enabled")]
    public TerraformValue<bool> DiagnosticsEventsEnabled
    {
        get => new TerraformReference<bool>(this, "diagnostics_events_enabled");
        set => SetArgument("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("health_monitoring_enabled")]
    public TerraformValue<bool> HealthMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "health_monitoring_enabled");
        set => SetArgument("health_monitoring_enabled", value);
    }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    [TerraformArgument("incident_logs_enabled")]
    public TerraformValue<bool> IncidentLogsEnabled
    {
        get => new TerraformReference<bool>(this, "incident_logs_enabled");
        set => SetArgument("incident_logs_enabled", value);
    }

}

/// <summary>
/// Block type for file_system_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterFileSystemConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_system_configuration";

    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformArgument("mount_point")]
    public TerraformValue<string>? MountPoint
    {
        get => new TerraformReference<string>(this, "mount_point");
        set => SetArgument("mount_point", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [TerraformArgument("size_in_gb")]
    public TerraformValue<double>? SizeInGb
    {
        get => new TerraformReference<double>(this, "size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("backup_subnet_cidr")]
    public TerraformValue<string>? BackupSubnetCidr
    {
        get => new TerraformReference<string>(this, "backup_subnet_cidr");
        set => SetArgument("backup_subnet_cidr", value);
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformArgument("cloud_exadata_infrastructure_id")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformArgument("cluster_name")]
    public TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformArgument("cpu_core_count")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformArgument("data_storage_percentage")]
    public TerraformValue<double> DataStoragePercentage
    {
        get => new TerraformReference<double>(this, "data_storage_percentage");
        set => SetArgument("data_storage_percentage", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformArgument("data_storage_size_in_tbs")]
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("db_node_storage_size_in_gbs")]
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
        set => SetArgument("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformArgument("db_servers")]
    public TerraformList<string>? DbServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "db_servers").ResolveNodes(ctx));
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformArgument("domain")]
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformArgument("gi_version")]
    public required TerraformValue<string> GiVersion
    {
        get => new TerraformReference<string>(this, "gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformArgument("hostname")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformArgument("license_model")]
    public required TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformArgument("local_backup_enabled")]
    public TerraformValue<bool> LocalBackupEnabled
    {
        get => new TerraformReference<bool>(this, "local_backup_enabled");
        set => SetArgument("local_backup_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformArgument("memory_size_in_gbs")]
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
        set => SetArgument("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformArgument("scan_listener_port_tcp")]
    public TerraformValue<double>? ScanListenerPortTcp
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp");
        set => SetArgument("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformArgument("scan_listener_port_tcp_ssl")]
    public TerraformValue<double>? ScanListenerPortTcpSsl
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp_ssl");
        set => SetArgument("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformArgument("sparse_diskgroup_enabled")]
    public TerraformValue<bool> SparseDiskgroupEnabled
    {
        get => new TerraformReference<bool>(this, "sparse_diskgroup_enabled");
        set => SetArgument("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformArgument("ssh_public_keys")]
    public TerraformList<string>? SshPublicKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssh_public_keys").ResolveNodes(ctx));
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformArgument("system_version")]
    public TerraformValue<string> SystemVersion
    {
        get => new TerraformReference<string>(this, "system_version");
        set => SetArgument("system_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformArgument("time_zone")]
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformArgument("virtual_network_id")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformArgument("zone_id")]
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    [TerraformArgument("data_collection_options")]
    public TerraformList<AzurermOracleCloudVmClusterDataCollectionOptionsBlock> DataCollectionOptions { get; set; } = new();

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("file_system_configuration")]
    public TerraformList<AzurermOracleCloudVmClusterFileSystemConfigurationBlock> FileSystemConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermOracleCloudVmClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformArgument("hostname_actual")]
    public TerraformValue<string> HostnameActual
    {
        get => new TerraformReference<string>(this, "hostname_actual");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformArgument("ocid")]
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

}

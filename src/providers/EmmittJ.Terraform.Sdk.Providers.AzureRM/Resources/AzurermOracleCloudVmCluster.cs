using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool> DiagnosticsEventsEnabled
    {
        get => new TerraformReference<bool>(this, "diagnostics_events_enabled");
        set => SetArgument("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HealthMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "health_monitoring_enabled");
        set => SetArgument("health_monitoring_enabled", value);
    }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
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
    public TerraformValue<string>? MountPoint
    {
        get => new TerraformReference<string>(this, "mount_point");
        set => SetArgument("mount_point", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_oracle_cloud_vm_cluster Terraform resource.
/// Manages a azurerm_oracle_cloud_vm_cluster resource.
/// </summary>
public partial class AzurermOracleCloudVmCluster(string name) : TerraformResource("azurerm_oracle_cloud_vm_cluster", name)
{
    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string>? BackupSubnetCidr
    {
        get => new TerraformReference<string>(this, "backup_subnet_cidr");
        set => SetArgument("backup_subnet_cidr", value);
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformValue<double> DataStoragePercentage
    {
        get => new TerraformReference<double>(this, "data_storage_percentage");
        set => SetArgument("data_storage_percentage", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
        set => SetArgument("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public TerraformList<string>? DbServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "db_servers").ResolveNodes(ctx));
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformValue<string> GiVersion
    {
        get => new TerraformReference<string>(this, "gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalBackupEnabled
    {
        get => new TerraformReference<bool>(this, "local_backup_enabled");
        set => SetArgument("local_backup_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
        set => SetArgument("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformValue<double>? ScanListenerPortTcp
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp");
        set => SetArgument("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformValue<double>? ScanListenerPortTcpSsl
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp_ssl");
        set => SetArgument("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformValue<bool> SparseDiskgroupEnabled
    {
        get => new TerraformReference<bool>(this, "sparse_diskgroup_enabled");
        set => SetArgument("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public TerraformList<string>? SshPublicKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ssh_public_keys").ResolveNodes(ctx));
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformValue<string> SystemVersion
    {
        get => new TerraformReference<string>(this, "system_version");
        set => SetArgument("system_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformValue<string> HostnameActual
    {
        get => new TerraformReference<string>(this, "hostname_actual");
    }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// DataCollectionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    public TerraformList<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>? DataCollectionOptions
    {
        get => GetArgument<TerraformList<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>>("data_collection_options");
        set => SetArgument("data_collection_options", value);
    }

    /// <summary>
    /// FileSystemConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>? FileSystemConfiguration
    {
        get => GetArgument<TerraformList<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>>("file_system_configuration");
        set => SetArgument("file_system_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleCloudVmClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleCloudVmClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

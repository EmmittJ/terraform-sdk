using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for data_collection_options in AzurermOracleCloudVmCluster.
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
    public TerraformValue<bool>? DiagnosticsEventsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("diagnostics_events_enabled");
        set => SetArgument("diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HealthMonitoringEnabled
    {
        get => GetArgument<TerraformValue<bool>>("health_monitoring_enabled");
        set => SetArgument("health_monitoring_enabled", value);
    }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IncidentLogsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("incident_logs_enabled");
        set => SetArgument("incident_logs_enabled", value);
    }

}


/// <summary>
/// Block type for file_system_configuration in AzurermOracleCloudVmCluster.
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
        get => GetArgument<TerraformValue<string>>("mount_point");
        set => SetArgument("mount_point", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? SizeInGb
    {
        get => GetArgument<TerraformValue<double>>("size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermOracleCloudVmCluster.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("backup_subnet_cidr");
        set => SetArgument("backup_subnet_cidr", value);
    }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => GetArgument<TerraformValue<string>>("cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformValue<string>? ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => GetArgument<TerraformValue<double>>("cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    public TerraformValue<double>? DataStoragePercentage
    {
        get => GetArgument<TerraformValue<double>>("data_storage_percentage");
        set => SetArgument("data_storage_percentage", value);
    }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    public TerraformValue<double>? DataStorageSizeInTbs
    {
        get => GetArgument<TerraformValue<double>>("data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double>? DbNodeStorageSizeInGbs
    {
        get => GetArgument<TerraformValue<double>>("db_node_storage_size_in_gbs");
        set => SetArgument("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public TerraformList<string>? DbServers
    {
        get => GetArgument<TerraformList<string>>("db_servers");
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformValue<string> GiVersion
    {
        get => GetArgument<TerraformValue<string>>("gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformValue<string> LicenseModel
    {
        get => GetArgument<TerraformValue<string>>("license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_backup_enabled");
        set => SetArgument("local_backup_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    public TerraformValue<double>? MemorySizeInGbs
    {
        get => GetArgument<TerraformValue<double>>("memory_size_in_gbs");
        set => SetArgument("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    public TerraformValue<double>? ScanListenerPortTcp
    {
        get => GetArgument<TerraformValue<double>>("scan_listener_port_tcp");
        set => SetArgument("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    public TerraformValue<double>? ScanListenerPortTcpSsl
    {
        get => GetArgument<TerraformValue<double>>("scan_listener_port_tcp_ssl");
        set => SetArgument("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SparseDiskgroupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sparse_diskgroup_enabled");
        set => SetArgument("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public TerraformList<string>? SshPublicKeys
    {
        get => GetArgument<TerraformList<string>>("ssh_public_keys");
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    public TerraformValue<string>? SystemVersion
    {
        get => GetArgument<TerraformValue<string>>("system_version");
        set => SetArgument("system_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string>? ZoneId
    {
        get => GetArgument<TerraformValue<string>>("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    public TerraformValue<string> HostnameActual
        => AsReference("hostname_actual");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

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

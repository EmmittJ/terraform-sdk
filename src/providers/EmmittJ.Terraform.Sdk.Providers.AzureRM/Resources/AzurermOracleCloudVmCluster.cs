using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOracleCloudVmClusterDataCollectionOptionsBlock() : TerraformBlock("data_collection_options")
{
    /// <summary>
    /// The diagnostics_events_enabled attribute.
    /// </summary>
    [TerraformProperty("diagnostics_events_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DiagnosticsEventsEnabled { get; set; }

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("health_monitoring_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> HealthMonitoringEnabled { get; set; }

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("incident_logs_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IncidentLogsEnabled { get; set; }

}

/// <summary>
/// Block type for file_system_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermOracleCloudVmClusterFileSystemConfigurationBlock() : TerraformBlock("file_system_configuration")
{
    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformProperty("mount_point")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MountPoint { get; set; }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [TerraformProperty("size_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SizeInGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermOracleCloudVmClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_oracle_cloud_vm_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermOracleCloudVmCluster : TerraformResource
{
    public AzurermOracleCloudVmCluster(string name) : base("azurerm_oracle_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The backup_subnet_cidr attribute.
    /// </summary>
    [TerraformProperty("backup_subnet_cidr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformProperty("cluster_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformProperty("cpu_core_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CpuCoreCount { get; set; }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformProperty("data_storage_percentage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DataStoragePercentage { get; set; }

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DataStorageSizeInTbs { get; set; }

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DbNodeStorageSizeInGbs { get; set; }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformProperty("db_servers")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DbServers { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformProperty("gi_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GiVersion { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformProperty("license_model")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformProperty("local_backup_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> LocalBackupEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MemorySizeInGbs { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformProperty("scan_listener_port_tcp")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScanListenerPortTcp { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformProperty("scan_listener_port_tcp_ssl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScanListenerPortTcpSsl { get; set; }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformProperty("sparse_diskgroup_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SparseDiskgroupEnabled { get; set; }

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformProperty("ssh_public_keys")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SshPublicKeys { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformProperty("system_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SystemVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformProperty("virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualNetworkId { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    [TerraformProperty("data_collection_options")]
    public TerraformList<AzurermOracleCloudVmClusterDataCollectionOptionsBlock> DataCollectionOptions { get; set; } = new();

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("file_system_configuration")]
    public TerraformList<AzurermOracleCloudVmClusterFileSystemConfigurationBlock> FileSystemConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermOracleCloudVmClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformProperty("hostname_actual")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostnameActual { get; }

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterDataCollectionOptionsBlock
{
    /// <summary>
    /// The diagnostics_events_enabled attribute.
    /// </summary>
    [TerraformPropertyName("diagnostics_events_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> DiagnosticsEventsEnabled { get; set; } = default!;

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("health_monitoring_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> HealthMonitoringEnabled { get; set; } = default!;

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("incident_logs_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IncidentLogsEnabled { get; set; } = default!;

}

/// <summary>
/// Block type for file_system_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterFileSystemConfigurationBlock
{
    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformPropertyName("mount_point")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MountPoint { get; set; }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("size_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SizeInGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("backup_subnet_cidr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterName { get; set; } = default!;

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformPropertyName("cpu_core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CpuCoreCount { get; set; }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_percentage")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DataStoragePercentage { get; set; } = default!;

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DataStorageSizeInTbs { get; set; } = default!;

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; set; } = default!;

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformPropertyName("db_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DbServers { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Domain { get; set; } = default!;

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformPropertyName("gi_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GiVersion { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformPropertyName("license_model")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> LocalBackupEnabled { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MemorySizeInGbs { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScanListenerPortTcp { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ScanListenerPortTcpSsl { get; set; }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SparseDiskgroupEnabled { get; set; } = default!;

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformPropertyName("ssh_public_keys")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? SshPublicKeys { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SystemVersion { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TimeZone { get; set; } = default!;

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformPropertyName("virtual_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualNetworkId { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ZoneId { get; set; } = default!;

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    [TerraformPropertyName("data_collection_options")]
    public TerraformList<TerraformBlock<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>>? DataCollectionOptions { get; set; }

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("file_system_configuration")]
    public TerraformList<TerraformBlock<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>>? FileSystemConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleCloudVmClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformPropertyName("hostname_actual")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostnameActual => new TerraformReference(this, "hostname_actual");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

}

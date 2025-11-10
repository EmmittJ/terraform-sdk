using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterDataCollectionOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The diagnostics_events_enabled attribute.
    /// </summary>
    [TerraformPropertyName("diagnostics_events_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DiagnosticsEventsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "diagnostics_events_enabled");

    /// <summary>
    /// The health_monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("health_monitoring_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> HealthMonitoringEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "health_monitoring_enabled");

    /// <summary>
    /// The incident_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("incident_logs_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IncidentLogsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "incident_logs_enabled");

}

/// <summary>
/// Block type for file_system_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleCloudVmClusterFileSystemConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The mount_point attribute.
    /// </summary>
    [TerraformPropertyName("mount_point")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MountPoint { get; set; }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("size_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SizeInGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleCloudVmClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// The cloud_exadata_infrastructure_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_name");

    /// <summary>
    /// The cpu_core_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformPropertyName("cpu_core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CpuCoreCount { get; set; }

    /// <summary>
    /// The data_storage_percentage attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_percentage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStoragePercentage { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_percentage");

    /// <summary>
    /// The data_storage_size_in_tbs attribute.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The db_node_storage_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformPropertyName("db_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? DbServers { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Domain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The gi_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformPropertyName("gi_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GiVersion { get; set; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformPropertyName("license_model")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; }

    /// <summary>
    /// The local_backup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> LocalBackupEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_backup_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The memory_size_in_gbs attribute.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScanListenerPortTcp { get; set; }

    /// <summary>
    /// The scan_listener_port_tcp_ssl attribute.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp_ssl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScanListenerPortTcpSsl { get; set; }

    /// <summary>
    /// The sparse_diskgroup_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SparseDiskgroupEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "sparse_diskgroup_enabled");

    /// <summary>
    /// The ssh_public_keys attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformPropertyName("ssh_public_keys")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SshPublicKeys { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// The system_version attribute.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SystemVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TimeZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformPropertyName("virtual_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualNetworkId { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ZoneId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCollectionOptions block(s) allowed")]
    [TerraformPropertyName("data_collection_options")]
    public TerraformList<TerraformBlock<AzurermOracleCloudVmClusterDataCollectionOptionsBlock>>? DataCollectionOptions { get; set; } = new();

    /// <summary>
    /// Block for file_system_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("file_system_configuration")]
    public TerraformList<TerraformBlock<AzurermOracleCloudVmClusterFileSystemConfigurationBlock>>? FileSystemConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermOracleCloudVmClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The hostname_actual attribute.
    /// </summary>
    [TerraformPropertyName("hostname_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostnameActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname_actual");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

}

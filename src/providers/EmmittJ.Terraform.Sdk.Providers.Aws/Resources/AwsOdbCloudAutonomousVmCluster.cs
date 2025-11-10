using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// The days of the week when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<object>>>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? HoursOfDay { get; set; }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? LeadTimeInWeeks { get; set; }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<object>>>? Months { get; set; }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformPropertyName("preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Preference { get; set; }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<double>>>? WeeksOfMonth { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudAutonomousVmClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_autonomous_vm_cluster resource.
/// </summary>
public class AwsOdbCloudAutonomousVmCluster : TerraformResource
{
    public AwsOdbCloudAutonomousVmCluster(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
    }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDataStorageSizeInTbs is required")]
    [TerraformPropertyName("autonomous_data_storage_size_in_tbs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> AutonomousDataStorageSizeInTbs { get; set; }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    [TerraformPropertyName("cpu_core_count_per_node")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CpuCoreCountPerNode { get; set; }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformPropertyName("db_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DbServers { get; set; }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    [TerraformPropertyName("is_mtls_enabled_vm_cluster")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IsMtlsEnabledVmCluster { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_mtls_enabled_vm_cluster");

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MemoryPerOracleComputeUnitInGbs { get; set; }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformPropertyName("odb_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OdbNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    [TerraformPropertyName("scan_listener_port_non_tls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ScanListenerPortNonTls { get; set; }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    [TerraformPropertyName("scan_listener_port_tls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ScanListenerPortTls { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TimeZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    [TerraformPropertyName("total_container_databases")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> TotalContainerDatabases { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbCloudAutonomousVmClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutonomousDataStoragePercentage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "autonomous_data_storage_percentage");

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("available_autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableAutonomousDataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_autonomous_data_storage_size_in_tbs");

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    [TerraformPropertyName("available_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableContainerDatabases => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_container_databases");

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases
    /// </summary>
    [TerraformPropertyName("available_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableCpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_cpus");

    /// <summary>
    /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_percentage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuPercentage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_percentage");

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_gbs");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    [TerraformPropertyName("exadata_storage_in_tbs_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ExadataStorageInTbsLowestScaledValue => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "exadata_storage_in_tbs_lowest_scaled_value");

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformPropertyName("max_acds_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxAcdsLowestScaledValue => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_acds_lowest_scaled_value");

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes(GB).
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource constraints.
    /// </summary>
    [TerraformPropertyName("non_provisionable_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NonProvisionableAutonomousContainerDatabases => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "non_provisionable_autonomous_container_databases");

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    ///  The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB)
    /// </summary>
    [TerraformPropertyName("odb_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> OdbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "odb_node_storage_size_in_gbs");

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisionable_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionableAutonomousContainerDatabases => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisionable_autonomous_container_databases");

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisioned_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionedAutonomousContainerDatabases => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisioned_autonomous_container_databases");

    /// <summary>
    /// The number of CPUs provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisioned_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ProvisionedCpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "provisioned_cpus");

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    [TerraformPropertyName("reclaimable_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReclaimableCpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "reclaimable_cpus");

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    [TerraformPropertyName("reserved_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReservedCpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "reserved_cpus");

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The status of the Autonomous VM cluster. Possible values include CREATING, AVAILABLE , UPDATING , DELETING , DELETED , FAILED 
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformPropertyName("time_database_ssl_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDatabaseSslCertificateExpires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_database_ssl_certificate_expires");

    /// <summary>
    /// The time_ords_certificate_expires attribute.
    /// </summary>
    [TerraformPropertyName("time_ords_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOrdsCertificateExpires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_ords_certificate_expires");

}

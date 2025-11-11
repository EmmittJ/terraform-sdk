using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock
{
    /// <summary>
    /// The days of the week when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("days_of_week")]
    // Optional argument - user may or may not set a value
    public TerraformSet<object>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("hours_of_day")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? HoursOfDay { get; set; }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    [TerraformPropertyName("lead_time_in_weeks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? LeadTimeInWeeks { get; set; }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    [TerraformPropertyName("months")]
    // Optional argument - user may or may not set a value
    public TerraformSet<object>? Months { get; set; }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformPropertyName("preference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Preference { get; set; }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    [TerraformPropertyName("weeks_of_month")]
    // Optional argument - user may or may not set a value
    public TerraformSet<double>? WeeksOfMonth { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudAutonomousVmClusterTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public required TerraformValue<double> AutonomousDataStorageSizeInTbs { get; set; }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    [TerraformPropertyName("cpu_core_count_per_node")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CpuCoreCountPerNode { get; set; }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformPropertyName("db_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DbServers { get; set; }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    [TerraformPropertyName("is_mtls_enabled_vm_cluster")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IsMtlsEnabledVmCluster { get; set; } = default!;

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LicenseModel { get; set; } = default!;

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MemoryPerOracleComputeUnitInGbs { get; set; }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformPropertyName("odb_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OdbNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    [TerraformPropertyName("scan_listener_port_non_tls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ScanListenerPortNonTls { get; set; }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    [TerraformPropertyName("scan_listener_port_tls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> ScanListenerPortTls { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TimeZone { get; set; } = default!;

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    [TerraformPropertyName("total_container_databases")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> TotalContainerDatabases { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbCloudAutonomousVmClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutonomousDataStoragePercentage => new TerraformReference(this, "autonomous_data_storage_percentage");

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("available_autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableAutonomousDataStorageSizeInTbs => new TerraformReference(this, "available_autonomous_data_storage_size_in_tbs");

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    [TerraformPropertyName("available_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableContainerDatabases => new TerraformReference(this, "available_container_databases");

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases
    /// </summary>
    [TerraformPropertyName("available_cpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableCpus => new TerraformReference(this, "available_cpus");

    /// <summary>
    /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuPercentage => new TerraformReference(this, "cpu_percentage");

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInGbs => new TerraformReference(this, "data_storage_size_in_gbs");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DataStorageSizeInTbs => new TerraformReference(this, "data_storage_size_in_tbs");

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    [TerraformPropertyName("exadata_storage_in_tbs_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ExadataStorageInTbsLowestScaledValue => new TerraformReference(this, "exadata_storage_in_tbs_lowest_scaled_value");

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformPropertyName("max_acds_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxAcdsLowestScaledValue => new TerraformReference(this, "max_acds_lowest_scaled_value");

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes(GB).
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NodeCount => new TerraformReference(this, "node_count");

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource constraints.
    /// </summary>
    [TerraformPropertyName("non_provisionable_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NonProvisionableAutonomousContainerDatabases => new TerraformReference(this, "non_provisionable_autonomous_container_databases");

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciUrl => new TerraformReference(this, "oci_url");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    ///  The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB)
    /// </summary>
    [TerraformPropertyName("odb_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> OdbNodeStorageSizeInGbs => new TerraformReference(this, "odb_node_storage_size_in_gbs");

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PercentProgress => new TerraformReference(this, "percent_progress");

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisionable_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionableAutonomousContainerDatabases => new TerraformReference(this, "provisionable_autonomous_container_databases");

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisioned_autonomous_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedAutonomousContainerDatabases => new TerraformReference(this, "provisioned_autonomous_container_databases");

    /// <summary>
    /// The number of CPUs provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("provisioned_cpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedCpus => new TerraformReference(this, "provisioned_cpus");

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    [TerraformPropertyName("reclaimable_cpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReclaimableCpus => new TerraformReference(this, "reclaimable_cpus");

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    [TerraformPropertyName("reserved_cpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReservedCpus => new TerraformReference(this, "reserved_cpus");

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The status of the Autonomous VM cluster. Possible values include CREATING, AVAILABLE , UPDATING , DELETING , DELETED , FAILED 
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformPropertyName("time_database_ssl_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDatabaseSslCertificateExpires => new TerraformReference(this, "time_database_ssl_certificate_expires");

    /// <summary>
    /// The time_ords_certificate_expires attribute.
    /// </summary>
    [TerraformPropertyName("time_ords_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOrdsCertificateExpires => new TerraformReference(this, "time_ords_certificate_expires");

}

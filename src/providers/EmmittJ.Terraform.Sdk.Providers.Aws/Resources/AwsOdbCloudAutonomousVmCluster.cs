using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The days of the week when maintenance can be performed.
    /// </summary>
    [TerraformProperty("days_of_week")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<object>? DaysOfWeek { get; set; }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    [TerraformProperty("hours_of_day")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? HoursOfDay { get; set; }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    [TerraformProperty("lead_time_in_weeks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? LeadTimeInWeeks { get; set; }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    [TerraformProperty("months")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<object>? Months { get; set; }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    [TerraformProperty("preference")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Preference { get; set; }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    [TerraformProperty("weeks_of_month")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<double>? WeeksOfMonth { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOdbCloudAutonomousVmClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_autonomous_vm_cluster resource.
/// </summary>
public partial class AwsOdbCloudAutonomousVmCluster : TerraformResource
{
    public AwsOdbCloudAutonomousVmCluster(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
    }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDataStorageSizeInTbs is required")]
    [TerraformProperty("autonomous_data_storage_size_in_tbs")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> AutonomousDataStorageSizeInTbs { get; set; }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    [TerraformProperty("cpu_core_count_per_node")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CpuCoreCountPerNode { get; set; }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformProperty("db_servers")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DbServers { get; set; }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    [TerraformProperty("is_mtls_enabled_vm_cluster")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IsMtlsEnabledVmCluster { get; set; }

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformProperty("license_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    [TerraformProperty("memory_per_oracle_compute_unit_in_gbs")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MemoryPerOracleComputeUnitInGbs { get; set; }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformProperty("odb_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OdbNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    [TerraformProperty("scan_listener_port_non_tls")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ScanListenerPortNonTls { get; set; }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    [TerraformProperty("scan_listener_port_tls")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ScanListenerPortTls { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TimeZone { get; set; }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    [TerraformProperty("total_container_databases")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TotalContainerDatabases { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsOdbCloudAutonomousVmClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformProperty("autonomous_data_storage_percentage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AutonomousDataStoragePercentage { get; }

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformProperty("available_autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableAutonomousDataStorageSizeInTbs { get; }

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    [TerraformProperty("available_container_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableContainerDatabases { get; }

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases
    /// </summary>
    [TerraformProperty("available_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableCpus { get; }

    /// <summary>
    /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("cpu_percentage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuPercentage { get; }

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    [TerraformProperty("data_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DataStorageSizeInGbs { get; }

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Domain { get; }

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    [TerraformProperty("exadata_storage_in_tbs_lowest_scaled_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ExadataStorageInTbsLowestScaledValue { get; }

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformProperty("max_acds_lowest_scaled_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxAcdsLowestScaledValue { get; }

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes(GB).
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource constraints.
    /// </summary>
    [TerraformProperty("non_provisionable_autonomous_container_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NonProvisionableAutonomousContainerDatabases { get; }

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

    /// <summary>
    ///  The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB)
    /// </summary>
    [TerraformProperty("odb_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> OdbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("provisionable_autonomous_container_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionableAutonomousContainerDatabases { get; }

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("provisioned_autonomous_container_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionedAutonomousContainerDatabases { get; }

    /// <summary>
    /// The number of CPUs provisioned in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("provisioned_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionedCpus { get; }

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    [TerraformProperty("reclaimable_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReclaimableCpus { get; }

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    [TerraformProperty("reserved_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReservedCpus { get; }

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Shape { get; }

    /// <summary>
    /// The status of the Autonomous VM cluster. Possible values include CREATING, AVAILABLE , UPDATING , DELETING , DELETED , FAILED 
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformProperty("time_database_ssl_certificate_expires")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeDatabaseSslCertificateExpires { get; }

    /// <summary>
    /// The time_ords_certificate_expires attribute.
    /// </summary>
    [TerraformProperty("time_ords_certificate_expires")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeOrdsCertificateExpires { get; }

}

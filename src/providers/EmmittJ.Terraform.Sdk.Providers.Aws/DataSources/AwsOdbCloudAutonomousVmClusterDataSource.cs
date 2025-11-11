using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_cluster.
/// </summary>
public partial class AwsOdbCloudAutonomousVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClusterDataSource(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
    }

    /// <summary>
    /// Unique ID of the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("autonomous_data_storage_percentage")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AutonomousDataStoragePercentage { get; }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformProperty("autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AutonomousDataStorageSizeInTbs { get; }

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
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    [TerraformProperty("available_cpus")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AvailableCpus { get; }

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudExadataInfrastructureId { get; }

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("cpu_core_count_per_node")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuCoreCountPerNode { get; }

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
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
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("db_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> DbServers { get; }

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

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
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("is_mtls_enabled_vm_cluster")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsMtlsEnabledVmCluster { get; }

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceWindow { get; }

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformProperty("max_acds_lowest_scaled_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxAcdsLowestScaledValue { get; }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    [TerraformProperty("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemoryPerOracleComputeUnitInGbs { get; }

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
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
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("odb_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OdbNetworkId { get; }

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
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
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    [TerraformProperty("scan_listener_port_non_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ScanListenerPortNonTls { get; }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    [TerraformProperty("scan_listener_port_tls")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ScanListenerPortTls { get; }

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Shape { get; }

    /// <summary>
    /// The status of the Autonomous VM cluster.
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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformProperty("time_database_ssl_certificate_expires")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeDatabaseSslCertificateExpires { get; }

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    [TerraformProperty("time_ords_certificate_expires")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeOrdsCertificateExpires { get; }

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeZone { get; }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    [TerraformProperty("total_container_databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalContainerDatabases { get; }

}

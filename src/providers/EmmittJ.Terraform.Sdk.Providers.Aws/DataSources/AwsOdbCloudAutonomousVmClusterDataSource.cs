using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_cluster.
/// </summary>
public class AwsOdbCloudAutonomousVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClusterDataSource(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
    }

    /// <summary>
    /// Unique ID of the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutonomousDataStoragePercentage => new TerraformReference(this, "autonomous_data_storage_percentage");

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutonomousDataStorageSizeInTbs => new TerraformReference(this, "autonomous_data_storage_size_in_tbs");

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
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    [TerraformPropertyName("available_cpus")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AvailableCpus => new TerraformReference(this, "available_cpus");

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudExadataInfrastructureId => new TerraformReference(this, "cloud_exadata_infrastructure_id");

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_core_count_per_node")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCountPerNode => new TerraformReference(this, "cpu_core_count_per_node");

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
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
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> DbServers => new TerraformReference(this, "db_servers");

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

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
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("is_mtls_enabled_vm_cluster")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsMtlsEnabledVmCluster => new TerraformReference(this, "is_mtls_enabled_vm_cluster");

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseModel => new TerraformReference(this, "license_model");

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceWindow => new TerraformReference(this, "maintenance_window");

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformPropertyName("max_acds_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxAcdsLowestScaledValue => new TerraformReference(this, "max_acds_lowest_scaled_value");

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs => new TerraformReference(this, "memory_per_oracle_compute_unit_in_gbs");

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
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
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("odb_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OdbNetworkId => new TerraformReference(this, "odb_network_id");

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
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
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_non_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScanListenerPortNonTls => new TerraformReference(this, "scan_listener_port_non_tls");

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScanListenerPortTls => new TerraformReference(this, "scan_listener_port_tls");

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The status of the Autonomous VM cluster.
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformPropertyName("time_database_ssl_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeDatabaseSslCertificateExpires => new TerraformReference(this, "time_database_ssl_certificate_expires");

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    [TerraformPropertyName("time_ords_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeOrdsCertificateExpires => new TerraformReference(this, "time_ords_certificate_expires");

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeZone => new TerraformReference(this, "time_zone");

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    [TerraformPropertyName("total_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TotalContainerDatabases => new TerraformReference(this, "total_container_databases");

}

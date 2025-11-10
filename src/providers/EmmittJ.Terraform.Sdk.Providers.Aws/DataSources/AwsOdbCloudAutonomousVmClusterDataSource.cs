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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_percentage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutonomousDataStoragePercentage => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "autonomous_data_storage_percentage");

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    [TerraformPropertyName("autonomous_data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutonomousDataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "autonomous_data_storage_size_in_tbs");

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
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    [TerraformPropertyName("available_cpus")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableCpus => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "available_cpus");

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloud_exadata_infrastructure_id");

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_core_count_per_node")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCountPerNode => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count_per_node");

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
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
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DbServers => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "db_servers");

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

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
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("is_mtls_enabled_vm_cluster")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsMtlsEnabledVmCluster => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_mtls_enabled_vm_cluster");

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceWindow => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    [TerraformPropertyName("max_acds_lowest_scaled_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxAcdsLowestScaledValue => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_acds_lowest_scaled_value");

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    [TerraformPropertyName("memory_per_oracle_compute_unit_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemoryPerOracleComputeUnitInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_per_oracle_compute_unit_in_gbs");

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
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
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("odb_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OdbNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_network_id");

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
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
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
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
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_non_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortNonTls => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scan_listener_port_non_tls");

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTls => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scan_listener_port_tls");

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The status of the Autonomous VM cluster.
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    [TerraformPropertyName("time_database_ssl_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeDatabaseSslCertificateExpires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_database_ssl_certificate_expires");

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    [TerraformPropertyName("time_ords_certificate_expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeOrdsCertificateExpires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_ords_certificate_expires");

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone");

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    [TerraformPropertyName("total_container_databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalContainerDatabases => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_container_databases");

}

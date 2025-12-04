using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_autonomous_vm_cluster Terraform data source.
/// Retrieves information about a aws_odb_cloud_autonomous_vm_cluster.
/// </summary>
public partial class AwsOdbCloudAutonomousVmClusterDataSource(string name) : TerraformDataSource("aws_odb_cloud_autonomous_vm_cluster", name)
{
    /// <summary>
    /// Unique ID of the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> AutonomousDataStoragePercentage
        => AsReference("autonomous_data_storage_percentage");

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> AutonomousDataStorageSizeInTbs
        => AsReference("autonomous_data_storage_size_in_tbs");

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> AvailableAutonomousDataStorageSizeInTbs
        => AsReference("available_autonomous_data_storage_size_in_tbs");

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    public TerraformValue<double> AvailableContainerDatabases
        => AsReference("available_container_databases");

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    public TerraformValue<double> AvailableCpus
        => AsReference("available_cpus");

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
        => AsReference("cloud_exadata_infrastructure_id");

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => AsReference("cpu_core_count");

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCountPerNode
        => AsReference("cpu_core_count_per_node");

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuPercentage
        => AsReference("cpu_percentage");

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGbs
        => AsReference("data_storage_size_in_gbs");

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => AsReference("data_storage_size_in_tbs");

    /// <summary>
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    public TerraformSet<string> DbServers
        => AsReference("db_servers");

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    public TerraformValue<double> ExadataStorageInTbsLowestScaledValue
        => AsReference("exadata_storage_in_tbs_lowest_scaled_value");

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<bool> IsMtlsEnabledVmCluster
        => AsReference("is_mtls_enabled_vm_cluster");

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    public TerraformValue<string> LicenseModel
        => AsReference("license_model");

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
        => AsReference("maintenance_window");

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    public TerraformValue<double> MaxAcdsLowestScaledValue
        => AsReference("max_acds_lowest_scaled_value");

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs
        => AsReference("memory_per_oracle_compute_unit_in_gbs");

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => AsReference("memory_size_in_gbs");

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
        => AsReference("node_count");

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
    /// </summary>
    public TerraformValue<double> NonProvisionableAutonomousContainerDatabases
        => AsReference("non_provisionable_autonomous_container_databases");

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OdbNetworkId
        => AsReference("odb_network_id");

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> OdbNodeStorageSizeInGbs
        => AsReference("odb_node_storage_size_in_gbs");

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionableAutonomousContainerDatabases
        => AsReference("provisionable_autonomous_container_databases");

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionedAutonomousContainerDatabases
        => AsReference("provisioned_autonomous_container_databases");

    /// <summary>
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionedCpus
        => AsReference("provisioned_cpus");

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    public TerraformValue<double> ReclaimableCpus
        => AsReference("reclaimable_cpus");

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    public TerraformValue<double> ReservedCpus
        => AsReference("reserved_cpus");

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    public TerraformValue<double> ScanListenerPortNonTls
        => AsReference("scan_listener_port_non_tls");

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTls
        => AsReference("scan_listener_port_tls");

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// The status of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    public TerraformValue<string> TimeDatabaseSslCertificateExpires
        => AsReference("time_database_ssl_certificate_expires");

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    public TerraformValue<string> TimeOrdsCertificateExpires
        => AsReference("time_ords_certificate_expires");

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> TimeZone
        => AsReference("time_zone");

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    public TerraformValue<double> TotalContainerDatabases
        => AsReference("total_container_databases");

}

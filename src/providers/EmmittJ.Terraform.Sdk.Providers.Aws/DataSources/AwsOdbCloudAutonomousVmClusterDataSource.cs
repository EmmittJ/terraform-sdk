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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> AutonomousDataStoragePercentage
    {
        get => new TerraformReference<double>(this, "autonomous_data_storage_percentage");
    }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> AutonomousDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "autonomous_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> AvailableAutonomousDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "available_autonomous_data_storage_size_in_tbs");
    }

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    public TerraformValue<double> AvailableContainerDatabases
    {
        get => new TerraformReference<double>(this, "available_container_databases");
    }

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    public TerraformValue<double> AvailableCpus
    {
        get => new TerraformReference<double>(this, "available_cpus");
    }

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
    }

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCountPerNode
    {
        get => new TerraformReference<double>(this, "cpu_core_count_per_node");
    }

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> CpuPercentage
    {
        get => new TerraformReference<double>(this, "cpu_percentage");
    }

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_gbs");
    }

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
    }

    /// <summary>
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    public TerraformSet<string> DbServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "db_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    public TerraformValue<double> ExadataStorageInTbsLowestScaledValue
    {
        get => new TerraformReference<double>(this, "exadata_storage_in_tbs_lowest_scaled_value");
    }

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<bool> IsMtlsEnabledVmCluster
    {
        get => new TerraformReference<bool>(this, "is_mtls_enabled_vm_cluster");
    }

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
    }

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    public TerraformValue<double> MaxAcdsLowestScaledValue
    {
        get => new TerraformReference<double>(this, "max_acds_lowest_scaled_value");
    }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    public TerraformValue<double> MemoryPerOracleComputeUnitInGbs
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_in_gbs");
    }

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
    /// </summary>
    public TerraformValue<double> NonProvisionableAutonomousContainerDatabases
    {
        get => new TerraformReference<double>(this, "non_provisionable_autonomous_container_databases");
    }

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> OdbNetworkId
    {
        get => new TerraformReference<string>(this, "odb_network_id");
    }

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> OdbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "odb_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionableAutonomousContainerDatabases
    {
        get => new TerraformReference<double>(this, "provisionable_autonomous_container_databases");
    }

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionedAutonomousContainerDatabases
    {
        get => new TerraformReference<double>(this, "provisioned_autonomous_container_databases");
    }

    /// <summary>
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<double> ProvisionedCpus
    {
        get => new TerraformReference<double>(this, "provisioned_cpus");
    }

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    public TerraformValue<double> ReclaimableCpus
    {
        get => new TerraformReference<double>(this, "reclaimable_cpus");
    }

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    public TerraformValue<double> ReservedCpus
    {
        get => new TerraformReference<double>(this, "reserved_cpus");
    }

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    public TerraformValue<double> ScanListenerPortNonTls
    {
        get => new TerraformReference<double>(this, "scan_listener_port_non_tls");
    }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTls
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tls");
    }

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The status of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    public TerraformValue<string> TimeDatabaseSslCertificateExpires
    {
        get => new TerraformReference<string>(this, "time_database_ssl_certificate_expires");
    }

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    public TerraformValue<string> TimeOrdsCertificateExpires
    {
        get => new TerraformReference<string>(this, "time_ords_certificate_expires");
    }

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
    }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    public TerraformValue<double> TotalContainerDatabases
    {
        get => new TerraformReference<double>(this, "total_container_databases");
    }

}

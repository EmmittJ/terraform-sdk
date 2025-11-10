using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_autonomous_vm_cluster.
/// </summary>
public class AwsOdbCloudAutonomousVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudAutonomousVmClusterDataSource(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("autonomous_data_storage_percentage");
        this.DeclareOutput("autonomous_data_storage_size_in_tbs");
        this.DeclareOutput("available_autonomous_data_storage_size_in_tbs");
        this.DeclareOutput("available_container_databases");
        this.DeclareOutput("available_cpus");
        this.DeclareOutput("cloud_exadata_infrastructure_id");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("cpu_core_count");
        this.DeclareOutput("cpu_core_count_per_node");
        this.DeclareOutput("cpu_percentage");
        this.DeclareOutput("created_at");
        this.DeclareOutput("data_storage_size_in_gbs");
        this.DeclareOutput("data_storage_size_in_tbs");
        this.DeclareOutput("db_servers");
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("domain");
        this.DeclareOutput("exadata_storage_in_tbs_lowest_scaled_value");
        this.DeclareOutput("hostname");
        this.DeclareOutput("is_mtls_enabled_vm_cluster");
        this.DeclareOutput("license_model");
        this.DeclareOutput("maintenance_window");
        this.DeclareOutput("max_acds_lowest_scaled_value");
        this.DeclareOutput("memory_per_oracle_compute_unit_in_gbs");
        this.DeclareOutput("memory_size_in_gbs");
        this.DeclareOutput("node_count");
        this.DeclareOutput("non_provisionable_autonomous_container_databases");
        this.DeclareOutput("oci_resource_anchor_name");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("odb_network_id");
        this.DeclareOutput("odb_node_storage_size_in_gbs");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("provisionable_autonomous_container_databases");
        this.DeclareOutput("provisioned_autonomous_container_databases");
        this.DeclareOutput("provisioned_cpus");
        this.DeclareOutput("reclaimable_cpus");
        this.DeclareOutput("reserved_cpus");
        this.DeclareOutput("scan_listener_port_non_tls");
        this.DeclareOutput("scan_listener_port_tls");
        this.DeclareOutput("shape");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("tags");
        this.DeclareOutput("time_database_ssl_certificate_expires");
        this.DeclareOutput("time_ords_certificate_expires");
        this.DeclareOutput("time_zone");
        this.DeclareOutput("total_container_databases");
    }

    /// <summary>
    /// Unique ID of the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The percentage of data storage currently in use for Autonomous Databases in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression AutonomousDataStoragePercentage => this["autonomous_data_storage_percentage"];

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformExpression AutonomousDataStorageSizeInTbs => this["autonomous_data_storage_size_in_tbs"];

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformExpression AvailableAutonomousDataStorageSizeInTbs => this["available_autonomous_data_storage_size_in_tbs"];

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    public TerraformExpression AvailableContainerDatabases => this["available_container_databases"];

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases.
    /// </summary>
    public TerraformExpression AvailableCpus => this["available_cpus"];

    /// <summary>
    /// Cloud exadata infrastructure id associated with this cloud autonomous VM cluster.
    /// </summary>
    public TerraformExpression CloudExadataInfrastructureId => this["cloud_exadata_infrastructure_id"];

    /// <summary>
    ///  The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression CpuCoreCountPerNode => this["cpu_core_count_per_node"];

    /// <summary>
    /// he percentage of total CPU cores currently in use in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression CpuPercentage => this["cpu_percentage"];

    /// <summary>
    /// The date and time when the Autonomous VM cluster was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in GB.
    /// </summary>
    public TerraformExpression DataStorageSizeInGbs => this["data_storage_size_in_gbs"];

    /// <summary>
    /// The total data storage allocated to the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The list of database servers associated with the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

    /// <summary>
    /// The user-provided description of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display name of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The domain name of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The minimum value to which you can scale down the Exadata storage, in TB.
    /// </summary>
    public TerraformExpression ExadataStorageInTbsLowestScaledValue => this["exadata_storage_in_tbs_lowest_scaled_value"];

    /// <summary>
    /// The hostname of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    ///  Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression IsMtlsEnabledVmCluster => this["is_mtls_enabled_vm_cluster"];

    /// <summary>
    /// The Oracle license model that applies to the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE .
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The maintenance window for the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    public TerraformExpression MaxAcdsLowestScaledValue => this["max_acds_lowest_scaled_value"];

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB.
    /// </summary>
    public TerraformExpression MemoryPerOracleComputeUnitInGbs => this["memory_per_oracle_compute_unit_in_gbs"];

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource  constraints.
    /// </summary>
    public TerraformExpression NonProvisionableAutonomousContainerDatabases => this["non_provisionable_autonomous_container_databases"];

    /// <summary>
    /// The name of the OCI resource anchor associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The URL for accessing the OCI console page for this Autonomous VM cluster.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The Oracle Cloud Identifier (OCID) of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM cluster.
    /// </summary>
    public TerraformExpression OdbNetworkId => this["odb_network_id"];

    /// <summary>
    /// The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformExpression OdbNodeStorageSizeInGbs => this["odb_node_storage_size_in_gbs"];

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The number of Autonomous CDBs that can be provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression ProvisionableAutonomousContainerDatabases => this["provisionable_autonomous_container_databases"];

    /// <summary>
    /// The number of Autonomous CDBs currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression ProvisionedAutonomousContainerDatabases => this["provisioned_autonomous_container_databases"];

    /// <summary>
    /// The number of CPU cores currently provisioned in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression ProvisionedCpus => this["provisioned_cpus"];

    /// <summary>
    /// The number of CPU cores that can be reclaimed from terminated or scaled-down Autonomous Databases.
    /// </summary>
    public TerraformExpression ReclaimableCpus => this["reclaimable_cpus"];

    /// <summary>
    /// The number of CPU cores reserved for system operations and redundancy.
    /// </summary>
    public TerraformExpression ReservedCpus => this["reserved_cpus"];

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521.
    /// </summary>
    public TerraformExpression ScanListenerPortNonTls => this["scan_listener_port_non_tls"];

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484.
    /// </summary>
    public TerraformExpression ScanListenerPortTls => this["scan_listener_port_tls"];

    /// <summary>
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The status of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    public TerraformExpression TimeDatabaseSslCertificateExpires => this["time_database_ssl_certificate_expires"];

    /// <summary>
    /// The expiration date and time of the Oracle REST Data Services (ORDS)certificate .
    /// </summary>
    public TerraformExpression TimeOrdsCertificateExpires => this["time_ords_certificate_expires"];

    /// <summary>
    /// The time zone of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression TimeZone => this["time_zone"];

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage.
    /// </summary>
    public TerraformExpression TotalContainerDatabases => this["total_container_databases"];

}

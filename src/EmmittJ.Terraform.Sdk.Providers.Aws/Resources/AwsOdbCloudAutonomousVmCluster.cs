using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_odb_cloud_autonomous_vm_cluster resource.
/// </summary>
public class AwsOdbCloudAutonomousVmCluster : TerraformResource
{
    public AwsOdbCloudAutonomousVmCluster(string name) : base("aws_odb_cloud_autonomous_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("autonomous_data_storage_percentage");
        this.DeclareOutput("available_autonomous_data_storage_size_in_tbs");
        this.DeclareOutput("available_container_databases");
        this.DeclareOutput("available_cpus");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("cpu_core_count");
        this.DeclareOutput("cpu_percentage");
        this.DeclareOutput("created_at");
        this.DeclareOutput("data_storage_size_in_gbs");
        this.DeclareOutput("data_storage_size_in_tbs");
        this.DeclareOutput("domain");
        this.DeclareOutput("exadata_storage_in_tbs_lowest_scaled_value");
        this.DeclareOutput("hostname");
        this.DeclareOutput("id");
        this.DeclareOutput("max_acds_lowest_scaled_value");
        this.DeclareOutput("memory_size_in_gbs");
        this.DeclareOutput("node_count");
        this.DeclareOutput("non_provisionable_autonomous_container_databases");
        this.DeclareOutput("oci_resource_anchor_name");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("odb_node_storage_size_in_gbs");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("provisionable_autonomous_container_databases");
        this.DeclareOutput("provisioned_autonomous_container_databases");
        this.DeclareOutput("provisioned_cpus");
        this.DeclareOutput("reclaimable_cpus");
        this.DeclareOutput("reserved_cpus");
        this.DeclareOutput("shape");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("time_database_ssl_certificate_expires");
        this.DeclareOutput("time_ords_certificate_expires");
    }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB. Changing this will force terraform to create new resource.
    /// </summary>
    public double? AutonomousDataStorageSizeInTbs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("autonomous_data_storage_size_in_tbs")?.Value;
        set => this.WithProperty("autonomous_data_storage_size_in_tbs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    public string? CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_exadata_infrastructure_id")?.Value;
        set => this.WithProperty("cloud_exadata_infrastructure_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    public double? CpuCoreCountPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cpu_core_count_per_node")?.Value;
        set => this.WithProperty("cpu_core_count_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public HashSet<string>? DbServers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("db_servers")?.Value;
        set => this.WithProperty("db_servers", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    public bool? IsMtlsEnabledVmCluster
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("is_mtls_enabled_vm_cluster")?.Value;
        set => this.WithProperty("is_mtls_enabled_vm_cluster", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    public string? LicenseModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_model")?.Value;
        set => this.WithProperty("license_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    public double? MemoryPerOracleComputeUnitInGbs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("memory_per_oracle_compute_unit_in_gbs")?.Value;
        set => this.WithProperty("memory_per_oracle_compute_unit_in_gbs", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public string? OdbNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("odb_network_id")?.Value;
        set => this.WithProperty("odb_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    public double? ScanListenerPortNonTls
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scan_listener_port_non_tls")?.Value;
        set => this.WithProperty("scan_listener_port_non_tls", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    public double? ScanListenerPortTls
    {
        get => GetProperty<TerraformLiteralProperty<double>>("scan_listener_port_tls")?.Value;
        set => this.WithProperty("scan_listener_port_tls", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public string? TimeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("time_zone")?.Value;
        set => this.WithProperty("time_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    public double? TotalContainerDatabases
    {
        get => GetProperty<TerraformLiteralProperty<double>>("total_container_databases")?.Value;
        set => this.WithProperty("total_container_databases", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    public TerraformExpression AutonomousDataStoragePercentage => this["autonomous_data_storage_percentage"];

    /// <summary>
    /// The available data storage space for Autonomous Databases in the Autonomous VM cluster, in TB.
    /// </summary>
    public TerraformExpression AvailableAutonomousDataStorageSizeInTbs => this["available_autonomous_data_storage_size_in_tbs"];

    /// <summary>
    /// The number of Autonomous CDBs that you can create with the currently available storage.
    /// </summary>
    public TerraformExpression AvailableContainerDatabases => this["available_container_databases"];

    /// <summary>
    /// The number of CPU cores available for allocation to Autonomous Databases
    /// </summary>
    public TerraformExpression AvailableCpus => this["available_cpus"];

    /// <summary>
    /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The total number of CPU cores in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    public TerraformExpression MaxAcdsLowestScaledValue => this["max_acds_lowest_scaled_value"];

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes(GB).
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The number of database server nodes in the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource constraints.
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
    ///  The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB)
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
    /// The number of CPUs provisioned in the Autonomous VM cluster.
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
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The status of the Autonomous VM cluster. Possible values include CREATING, AVAILABLE , UPDATING , DELETING , DELETED , FAILED 
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the current status of the Autonomous VM cluster.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    public TerraformExpression TimeDatabaseSslCertificateExpires => this["time_database_ssl_certificate_expires"];

    /// <summary>
    /// The time_ords_certificate_expires attribute.
    /// </summary>
    public TerraformExpression TimeOrdsCertificateExpires => this["time_ords_certificate_expires"];

}

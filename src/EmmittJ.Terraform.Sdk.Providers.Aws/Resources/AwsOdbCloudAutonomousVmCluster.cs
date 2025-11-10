using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The days of the week when maintenance can be performed.
    /// </summary>
    public HashSet<TerraformProperty<object>>? DaysOfWeek
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("days_of_week");
        set => WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    public HashSet<TerraformProperty<double>>? HoursOfDay
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("hours_of_day");
        set => WithProperty("hours_of_day", value);
    }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    public TerraformProperty<double>? LeadTimeInWeeks
    {
        get => GetProperty<TerraformProperty<double>>("lead_time_in_weeks");
        set => WithProperty("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Months
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("months");
        set => WithProperty("months", value);
    }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformProperty<string> Preference
    {
        get => GetRequiredProperty<TerraformProperty<string>>("preference");
        set => WithProperty("preference", value);
    }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    public HashSet<TerraformProperty<double>>? WeeksOfMonth
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("weeks_of_month");
        set => WithProperty("weeks_of_month", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudAutonomousVmClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDataStorageSizeInTbs is required")]
    public required TerraformProperty<double> AutonomousDataStorageSizeInTbs
    {
        get => GetRequiredProperty<TerraformProperty<double>>("autonomous_data_storage_size_in_tbs");
        set => this.WithProperty("autonomous_data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => this.WithProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    public required TerraformProperty<double> CpuCoreCountPerNode
    {
        get => GetRequiredProperty<TerraformProperty<double>>("cpu_core_count_per_node");
        set => this.WithProperty("cpu_core_count_per_node", value);
    }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public HashSet<TerraformProperty<string>>? DbServers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("db_servers");
        set => this.WithProperty("db_servers", value);
    }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    public TerraformProperty<bool>? IsMtlsEnabledVmCluster
    {
        get => GetProperty<TerraformProperty<bool>>("is_mtls_enabled_vm_cluster");
        set => this.WithProperty("is_mtls_enabled_vm_cluster", value);
    }

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    public required TerraformProperty<double> MemoryPerOracleComputeUnitInGbs
    {
        get => GetRequiredProperty<TerraformProperty<double>>("memory_per_oracle_compute_unit_in_gbs");
        set => this.WithProperty("memory_per_oracle_compute_unit_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformProperty<string> OdbNetworkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("odb_network_id");
        set => this.WithProperty("odb_network_id", value);
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
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    public required TerraformProperty<double> ScanListenerPortNonTls
    {
        get => GetRequiredProperty<TerraformProperty<double>>("scan_listener_port_non_tls");
        set => this.WithProperty("scan_listener_port_non_tls", value);
    }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    public required TerraformProperty<double> ScanListenerPortTls
    {
        get => GetRequiredProperty<TerraformProperty<double>>("scan_listener_port_tls");
        set => this.WithProperty("scan_listener_port_tls", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => this.WithProperty("time_zone", value);
    }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    public required TerraformProperty<double> TotalContainerDatabases
    {
        get => GetRequiredProperty<TerraformProperty<double>>("total_container_databases");
        set => this.WithProperty("total_container_databases", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbCloudAutonomousVmClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsOdbCloudAutonomousVmClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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

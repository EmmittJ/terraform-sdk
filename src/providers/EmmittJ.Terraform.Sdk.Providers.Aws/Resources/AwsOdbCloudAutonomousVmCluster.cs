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
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    public HashSet<TerraformProperty<double>>? HoursOfDay
    {
        set => SetProperty("hours_of_day", value);
    }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    public TerraformProperty<double>? LeadTimeInWeeks
    {
        set => SetProperty("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    public HashSet<TerraformProperty<object>>? Months
    {
        set => SetProperty("months", value);
    }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformProperty<string> Preference
    {
        set => SetProperty("preference", value);
    }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    public HashSet<TerraformProperty<double>>? WeeksOfMonth
    {
        set => SetProperty("weeks_of_month", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("autonomous_data_storage_percentage");
        SetOutput("available_autonomous_data_storage_size_in_tbs");
        SetOutput("available_container_databases");
        SetOutput("available_cpus");
        SetOutput("compute_model");
        SetOutput("cpu_core_count");
        SetOutput("cpu_percentage");
        SetOutput("created_at");
        SetOutput("data_storage_size_in_gbs");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("domain");
        SetOutput("exadata_storage_in_tbs_lowest_scaled_value");
        SetOutput("hostname");
        SetOutput("id");
        SetOutput("max_acds_lowest_scaled_value");
        SetOutput("memory_size_in_gbs");
        SetOutput("node_count");
        SetOutput("non_provisionable_autonomous_container_databases");
        SetOutput("oci_resource_anchor_name");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("odb_node_storage_size_in_gbs");
        SetOutput("percent_progress");
        SetOutput("provisionable_autonomous_container_databases");
        SetOutput("provisioned_autonomous_container_databases");
        SetOutput("provisioned_cpus");
        SetOutput("reclaimable_cpus");
        SetOutput("reserved_cpus");
        SetOutput("shape");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("tags_all");
        SetOutput("time_database_ssl_certificate_expires");
        SetOutput("time_ords_certificate_expires");
        SetOutput("autonomous_data_storage_size_in_tbs");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("cpu_core_count_per_node");
        SetOutput("db_servers");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("is_mtls_enabled_vm_cluster");
        SetOutput("license_model");
        SetOutput("memory_per_oracle_compute_unit_in_gbs");
        SetOutput("odb_network_id");
        SetOutput("region");
        SetOutput("scan_listener_port_non_tls");
        SetOutput("scan_listener_port_tls");
        SetOutput("tags");
        SetOutput("time_zone");
        SetOutput("total_container_databases");
    }

    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDataStorageSizeInTbs is required")]
    public required TerraformProperty<double> AutonomousDataStorageSizeInTbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("autonomous_data_storage_size_in_tbs");
        set => SetProperty("autonomous_data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    public required TerraformProperty<double> CpuCoreCountPerNode
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cpu_core_count_per_node");
        set => SetProperty("cpu_core_count_per_node", value);
    }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public HashSet<TerraformProperty<string>> DbServers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("db_servers");
        set => SetProperty("db_servers", value);
    }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    public TerraformProperty<bool> IsMtlsEnabledVmCluster
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_mtls_enabled_vm_cluster");
        set => SetProperty("is_mtls_enabled_vm_cluster", value);
    }

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    public required TerraformProperty<double> MemoryPerOracleComputeUnitInGbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("memory_per_oracle_compute_unit_in_gbs");
        set => SetProperty("memory_per_oracle_compute_unit_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformProperty<string> OdbNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("odb_network_id");
        set => SetProperty("odb_network_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    public required TerraformProperty<double> ScanListenerPortNonTls
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scan_listener_port_non_tls");
        set => SetProperty("scan_listener_port_non_tls", value);
    }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    public required TerraformProperty<double> ScanListenerPortTls
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scan_listener_port_tls");
        set => SetProperty("scan_listener_port_tls", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    public required TerraformProperty<double> TotalContainerDatabases
    {
        get => GetRequiredOutput<TerraformProperty<double>>("total_container_databases");
        set => SetProperty("total_container_databases", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbCloudAutonomousVmClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

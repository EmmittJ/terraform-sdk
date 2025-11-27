using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for maintenance_window in AwsOdbCloudAutonomousVmCluster.
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The days of the week when maintenance can be performed.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? DaysOfWeek
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "days_of_week").ResolveNodes(ctx));
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours of the day when maintenance can be performed.
    /// </summary>
    public TerraformSet<double>? HoursOfDay
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "hours_of_day").ResolveNodes(ctx));
        set => SetArgument("hours_of_day", value);
    }

    /// <summary>
    /// The lead time in weeks before the maintenance window.
    /// </summary>
    public TerraformValue<double>? LeadTimeInWeeks
    {
        get => new TerraformReference<double>(this, "lead_time_in_weeks");
        set => SetArgument("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months when maintenance can be performed.
    /// </summary>
    public TerraformSet<TerraformMap<object>>? Months
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "months").ResolveNodes(ctx));
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The preference for the maintenance window scheduling.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformValue<string> Preference
    {
        get => new TerraformReference<string>(this, "preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// Indicates whether to skip release updates during maintenance.
    /// </summary>
    public TerraformSet<double>? WeeksOfMonth
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "weeks_of_month").ResolveNodes(ctx));
        set => SetArgument("weeks_of_month", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOdbCloudAutonomousVmCluster.
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudAutonomousVmClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_odb_cloud_autonomous_vm_cluster Terraform resource.
/// Manages a aws_odb_cloud_autonomous_vm_cluster resource.
/// </summary>
public partial class AwsOdbCloudAutonomousVmCluster(string name) : TerraformResource("aws_odb_cloud_autonomous_vm_cluster", name)
{
    /// <summary>
    /// The data storage size allocated for Autonomous Databases in the Autonomous VM cluster, in TB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDataStorageSizeInTbs is required")]
    public required TerraformValue<double> AutonomousDataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "autonomous_data_storage_size_in_tbs");
        set => SetArgument("autonomous_data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// Exadata infrastructure id. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The number of CPU cores enabled per node in the Autonomous VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCountPerNode is required")]
    public required TerraformValue<double> CpuCoreCountPerNode
    {
        get => new TerraformReference<double>(this, "cpu_core_count_per_node");
        set => SetArgument("cpu_core_count_per_node", value);
    }

    /// <summary>
    /// The database servers in the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public required TerraformSet<string> DbServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "db_servers").ResolveNodes(ctx));
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// The description of the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Indicates whether mutual TLS (mTLS) authentication is enabled for the Autonomous VM cluster. Changing this will force terraform to create new resource. 
    /// </summary>
    public TerraformValue<bool> IsMtlsEnabledVmCluster
    {
        get => new TerraformReference<bool>(this, "is_mtls_enabled_vm_cluster");
        set => SetArgument("is_mtls_enabled_vm_cluster", value);
    }

    /// <summary>
    /// The license model for the Autonomous VM cluster. Valid values are LICENSE_INCLUDED or BRING_YOUR_OWN_LICENSE . Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The amount of memory allocated per Oracle Compute Unit, in GB. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryPerOracleComputeUnitInGbs is required")]
    public required TerraformValue<double> MemoryPerOracleComputeUnitInGbs
    {
        get => new TerraformReference<double>(this, "memory_per_oracle_compute_unit_in_gbs");
        set => SetArgument("memory_per_oracle_compute_unit_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network associated with this Autonomous VM Cluster. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformValue<string> OdbNetworkId
    {
        get => new TerraformReference<string>(this, "odb_network_id");
        set => SetArgument("odb_network_id", value);
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
    /// The SCAN listener port for non-TLS (TCP) protocol. The default is 1521. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortNonTls is required")]
    public required TerraformValue<double> ScanListenerPortNonTls
    {
        get => new TerraformReference<double>(this, "scan_listener_port_non_tls");
        set => SetArgument("scan_listener_port_non_tls", value);
    }

    /// <summary>
    /// The SCAN listener port for TLS (TCP) protocol. The default is 2484. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanListenerPortTls is required")]
    public required TerraformValue<double> ScanListenerPortTls
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tls");
        set => SetArgument("scan_listener_port_tls", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time zone of the Autonomous VM cluster. Changing this will force terraform to create new resource.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The total number of Autonomous Container Databases that can be created with the allocated local storage. Changing this will force terraform to create new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalContainerDatabases is required")]
    public required TerraformValue<double> TotalContainerDatabases
    {
        get => new TerraformReference<double>(this, "total_container_databases");
        set => SetArgument("total_container_databases", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The progress of the current operation on the Autonomous VM cluster, as a percentage.
    /// </summary>
    public TerraformValue<double> AutonomousDataStoragePercentage
    {
        get => new TerraformReference<double>(this, "autonomous_data_storage_percentage");
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
    /// The number of CPU cores available for allocation to Autonomous Databases
    /// </summary>
    public TerraformValue<double> AvailableCpus
    {
        get => new TerraformReference<double>(this, "available_cpus");
    }

    /// <summary>
    /// The compute model of the Autonomous VM cluster: ECPU or OCPU.
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
    /// The percentage of total CPU cores currently in use in the Autonomous VM cluster.
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The minimum value to which you can scale down the maximum number of Autonomous CDBs.
    /// </summary>
    public TerraformValue<double> MaxAcdsLowestScaledValue
    {
        get => new TerraformReference<double>(this, "max_acds_lowest_scaled_value");
    }

    /// <summary>
    /// The total amount of memory allocated to the Autonomous VM cluster, in gigabytes(GB).
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
    /// The number of Autonomous CDBs that can&#39;t be provisioned because of resource constraints.
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
    ///  The local node storage allocated to the Autonomous VM cluster, in gigabytes (GB)
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
    /// The number of CPUs provisioned in the Autonomous VM cluster.
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
    /// The shape of the Exadata infrastructure for the Autonomous VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The status of the Autonomous VM cluster. Possible values include CREATING, AVAILABLE , UPDATING , DELETING , DELETED , FAILED 
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The expiration date and time of the database SSL certificate.
    /// </summary>
    public TerraformValue<string> TimeDatabaseSslCertificateExpires
    {
        get => new TerraformReference<string>(this, "time_database_ssl_certificate_expires");
    }

    /// <summary>
    /// The time_ords_certificate_expires attribute.
    /// </summary>
    public TerraformValue<string> TimeOrdsCertificateExpires
    {
        get => new TerraformReference<string>(this, "time_ords_certificate_expires");
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AwsOdbCloudAutonomousVmClusterMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOdbCloudAutonomousVmClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOdbCloudAutonomousVmClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

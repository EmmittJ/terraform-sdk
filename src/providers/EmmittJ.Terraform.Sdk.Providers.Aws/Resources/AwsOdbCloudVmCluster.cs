using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_collection_options in AwsOdbCloudVmCluster.
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudVmClusterDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_collection_options";

    /// <summary>
    /// The is_diagnostics_events_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDiagnosticsEventsEnabled is required")]
    public required TerraformValue<bool> IsDiagnosticsEventsEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_diagnostics_events_enabled");
        set => SetArgument("is_diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The is_health_monitoring_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsHealthMonitoringEnabled is required")]
    public required TerraformValue<bool> IsHealthMonitoringEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_health_monitoring_enabled");
        set => SetArgument("is_health_monitoring_enabled", value);
    }

    /// <summary>
    /// The is_incident_logs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsIncidentLogsEnabled is required")]
    public required TerraformValue<bool> IsIncidentLogsEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_incident_logs_enabled");
        set => SetArgument("is_incident_logs_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOdbCloudVmCluster.
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudVmClusterTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_odb_cloud_vm_cluster Terraform resource.
/// Manages a aws_odb_cloud_vm_cluster resource.
/// </summary>
public partial class AwsOdbCloudVmCluster(string name) : TerraformResource("aws_odb_cloud_vm_cluster", name)
{
    /// <summary>
    /// The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name") ?? AsReference("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    public required TerraformValue<double> DataStorageSizeInTbs
    {
        get => GetRequiredArgument<TerraformValue<double>>("data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => GetArgument<TerraformValue<double>>("db_node_storage_size_in_gbs") ?? AsReference("db_node_storage_size_in_gbs");
        set => SetArgument("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public required TerraformSet<string> DbServers
    {
        get => GetRequiredArgument<TerraformSet<string>>("db_servers");
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformValue<string> GiVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnamePrefix is required")]
    public required TerraformValue<string> HostnamePrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname_prefix");
        set => SetArgument("hostname_prefix", value);
    }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<bool> IsLocalBackupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_local_backup_enabled") ?? AsReference("is_local_backup_enabled");
        set => SetArgument("is_local_backup_enabled", value);
    }

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<bool> IsSparseDiskgroupEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_sparse_diskgroup_enabled") ?? AsReference("is_sparse_diskgroup_enabled");
        set => SetArgument("is_sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => GetArgument<TerraformValue<string>>("license_model") ?? AsReference("license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => GetArgument<TerraformValue<double>>("memory_size_in_gbs") ?? AsReference("memory_size_in_gbs");
        set => SetArgument("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    public required TerraformValue<string> OdbNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("odb_network_id");
        set => SetArgument("odb_network_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcp
    {
        get => GetArgument<TerraformValue<double>>("scan_listener_port_tcp") ?? AsReference("scan_listener_port_tcp");
        set => SetArgument("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public required TerraformSet<string> SshPublicKeys
    {
        get => GetRequiredArgument<TerraformSet<string>>("ssh_public_keys");
        set => SetArgument("ssh_public_keys", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone") ?? AsReference("timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The compute model used when the instance is created or cloned — either ECPU or OCPU. ECPU is a virtualized compute unit; OCPU is a physical processor core with hyper-threading.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The timestamp when the VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The type of redundancy for the VM cluster: NORMAL (2-way) or HIGH (3-way).
    /// </summary>
    public TerraformValue<string> DiskRedundancy
        => AsReference("disk_redundancy");

    /// <summary>
    /// The domain name associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// A complete software version of Oracle Grid Infrastructure (GI).
    /// </summary>
    public TerraformValue<string> GiVersionComputed
        => AsReference("gi_version_computed");

    /// <summary>
    /// The host name for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> HostnamePrefixComputed
        => AsReference("hostname_prefix_computed");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The Exadata IORM (I/O Resource Manager) configuration cache details for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
        => AsReference("iorm_config_cache");

    /// <summary>
    /// The OCID of the most recent maintenance update history entry.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
        => AsReference("last_update_history_entry_id");

    /// <summary>
    /// The listener port number configured on the VM cluster.
    /// </summary>
    public TerraformValue<double> ListenerPort
        => AsReference("listener_port");

    /// <summary>
    /// The total number of nodes in the VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
        => AsReference("node_count");

    /// <summary>
    /// The name of the OCI resource anchor associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the VM cluster resource in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The OCID (Oracle Cloud Identifier) of the VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The percentage of progress made on the current operation for the VM cluster.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// The fully qualified domain name (FQDN) for the SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsName
        => AsReference("scan_dns_name");

    /// <summary>
    /// The OCID of the DNS record for the SCAN IPs linked to the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
        => AsReference("scan_dns_record_id");

    /// <summary>
    /// The list of OCIDs for SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformList<string> ScanIpIds
        => AsReference("scan_ip_ids");

    /// <summary>
    /// The hardware model name of the Exadata infrastructure running the VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// The current lifecycle status of the VM cluster.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information regarding the current status of the VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The local node storage allocated to the VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
        => AsReference("storage_size_in_gbs");

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformValue<string> SystemVersion
        => AsReference("system_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The virtual IP (VIP) addresses assigned to the VM cluster. CRS assigns one VIP per node for failover support.
    /// </summary>
    public TerraformList<string> VipIds
        => AsReference("vip_ids");

    /// <summary>
    /// DataCollectionOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOdbCloudVmClusterDataCollectionOptionsBlock>? DataCollectionOptions
    {
        get => GetArgument<TerraformList<AwsOdbCloudVmClusterDataCollectionOptionsBlock>>("data_collection_options");
        set => SetArgument("data_collection_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOdbCloudVmClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOdbCloudVmClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

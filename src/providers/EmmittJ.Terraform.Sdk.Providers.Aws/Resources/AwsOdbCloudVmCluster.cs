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
        get => new TerraformReference<bool>(this, "is_diagnostics_events_enabled");
        set => SetArgument("is_diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The is_health_monitoring_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsHealthMonitoringEnabled is required")]
    public required TerraformValue<bool> IsHealthMonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "is_health_monitoring_enabled");
        set => SetArgument("is_health_monitoring_enabled", value);
    }

    /// <summary>
    /// The is_incident_logs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsIncidentLogsEnabled is required")]
    public required TerraformValue<bool> IsIncidentLogsEnabled
    {
        get => new TerraformReference<bool>(this, "is_incident_logs_enabled");
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
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
        set => SetArgument("cpu_core_count", value);
    }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    public required TerraformValue<double> DataStorageSizeInTbs
    {
        get => new TerraformReference<double>(this, "data_storage_size_in_tbs");
        set => SetArgument("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
        set => SetArgument("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public required TerraformSet<string> DbServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "db_servers").ResolveNodes(ctx));
        set => SetArgument("db_servers", value);
    }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformValue<string> GiVersion
    {
        get => new TerraformReference<string>(this, "gi_version");
        set => SetArgument("gi_version", value);
    }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnamePrefix is required")]
    public required TerraformValue<string> HostnamePrefix
    {
        get => new TerraformReference<string>(this, "hostname_prefix");
        set => SetArgument("hostname_prefix", value);
    }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<bool> IsLocalBackupEnabled
    {
        get => new TerraformReference<bool>(this, "is_local_backup_enabled");
        set => SetArgument("is_local_backup_enabled", value);
    }

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<bool> IsSparseDiskgroupEnabled
    {
        get => new TerraformReference<bool>(this, "is_sparse_diskgroup_enabled");
        set => SetArgument("is_sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
        set => SetArgument("license_model", value);
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
        set => SetArgument("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
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
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<double> ScanListenerPortTcp
    {
        get => new TerraformReference<double>(this, "scan_listener_port_tcp");
        set => SetArgument("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public required TerraformSet<string> SshPublicKeys
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ssh_public_keys").ResolveNodes(ctx));
        set => SetArgument("ssh_public_keys", value);
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
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The compute model used when the instance is created or cloned — either ECPU or OCPU. ECPU is a virtualized compute unit; OCPU is a physical processor core with hyper-threading.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The timestamp when the VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The type of redundancy for the VM cluster: NORMAL (2-way) or HIGH (3-way).
    /// </summary>
    public TerraformValue<string> DiskRedundancy
    {
        get => new TerraformReference<string>(this, "disk_redundancy");
    }

    /// <summary>
    /// The domain name associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// A complete software version of Oracle Grid Infrastructure (GI).
    /// </summary>
    public TerraformValue<string> GiVersionComputed
    {
        get => new TerraformReference<string>(this, "gi_version_computed");
    }

    /// <summary>
    /// The host name for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformValue<string> HostnamePrefixComputed
    {
        get => new TerraformReference<string>(this, "hostname_prefix_computed");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The Exadata IORM (I/O Resource Manager) configuration cache details for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "iorm_config_cache").ResolveNodes(ctx));
    }

    /// <summary>
    /// The OCID of the most recent maintenance update history entry.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
    {
        get => new TerraformReference<string>(this, "last_update_history_entry_id");
    }

    /// <summary>
    /// The listener port number configured on the VM cluster.
    /// </summary>
    public TerraformValue<double> ListenerPort
    {
        get => new TerraformReference<double>(this, "listener_port");
    }

    /// <summary>
    /// The total number of nodes in the VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
    {
        get => new TerraformReference<double>(this, "node_count");
    }

    /// <summary>
    /// The name of the OCI resource anchor associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The HTTPS link to the VM cluster resource in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
    {
        get => new TerraformReference<string>(this, "oci_url");
    }

    /// <summary>
    /// The OCID (Oracle Cloud Identifier) of the VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The percentage of progress made on the current operation for the VM cluster.
    /// </summary>
    public TerraformValue<double> PercentProgress
    {
        get => new TerraformReference<double>(this, "percent_progress");
    }

    /// <summary>
    /// The fully qualified domain name (FQDN) for the SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsName
    {
        get => new TerraformReference<string>(this, "scan_dns_name");
    }

    /// <summary>
    /// The OCID of the DNS record for the SCAN IPs linked to the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
    {
        get => new TerraformReference<string>(this, "scan_dns_record_id");
    }

    /// <summary>
    /// The list of OCIDs for SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformList<string> ScanIpIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "scan_ip_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hardware model name of the Exadata infrastructure running the VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The current lifecycle status of the VM cluster.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information regarding the current status of the VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The local node storage allocated to the VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "storage_size_in_gbs");
    }

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformValue<string> SystemVersion
    {
        get => new TerraformReference<string>(this, "system_version");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual IP (VIP) addresses assigned to the VM cluster. CRS assigns one VIP per node for failover support.
    /// </summary>
    public TerraformList<string> VipIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vip_ids").ResolveNodes(ctx));
    }

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

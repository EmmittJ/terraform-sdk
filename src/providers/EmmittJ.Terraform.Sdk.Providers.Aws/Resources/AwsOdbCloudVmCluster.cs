using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudVmClusterDataCollectionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The is_diagnostics_events_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDiagnosticsEventsEnabled is required")]
    public required TerraformProperty<bool> IsDiagnosticsEventsEnabled
    {
        set => SetProperty("is_diagnostics_events_enabled", value);
    }

    /// <summary>
    /// The is_health_monitoring_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsHealthMonitoringEnabled is required")]
    public required TerraformProperty<bool> IsHealthMonitoringEnabled
    {
        set => SetProperty("is_health_monitoring_enabled", value);
    }

    /// <summary>
    /// The is_incident_logs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsIncidentLogsEnabled is required")]
    public required TerraformProperty<bool> IsIncidentLogsEnabled
    {
        set => SetProperty("is_incident_logs_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudVmClusterTimeoutsBlock : TerraformBlock
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
/// Manages a aws_odb_cloud_vm_cluster resource.
/// </summary>
public class AwsOdbCloudVmCluster : TerraformResource
{
    public AwsOdbCloudVmCluster(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("compute_model");
        SetOutput("created_at");
        SetOutput("disk_redundancy");
        SetOutput("domain");
        SetOutput("gi_version_computed");
        SetOutput("hostname_prefix_computed");
        SetOutput("id");
        SetOutput("iorm_config_cache");
        SetOutput("last_update_history_entry_id");
        SetOutput("listener_port");
        SetOutput("node_count");
        SetOutput("oci_resource_anchor_name");
        SetOutput("oci_url");
        SetOutput("ocid");
        SetOutput("percent_progress");
        SetOutput("scan_dns_name");
        SetOutput("scan_dns_record_id");
        SetOutput("scan_ip_ids");
        SetOutput("shape");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("storage_size_in_gbs");
        SetOutput("system_version");
        SetOutput("tags_all");
        SetOutput("vip_ids");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("cluster_name");
        SetOutput("cpu_core_count");
        SetOutput("data_storage_size_in_tbs");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_servers");
        SetOutput("display_name");
        SetOutput("gi_version");
        SetOutput("hostname_prefix");
        SetOutput("is_local_backup_enabled");
        SetOutput("is_sparse_diskgroup_enabled");
        SetOutput("license_model");
        SetOutput("memory_size_in_gbs");
        SetOutput("odb_network_id");
        SetOutput("region");
        SetOutput("scan_listener_port_tcp");
        SetOutput("ssh_public_keys");
        SetOutput("tags");
        SetOutput("timezone");
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformProperty<double> CpuCoreCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cpu_core_count");
        set => SetProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    public required TerraformProperty<double> DataStorageSizeInTbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("data_storage_size_in_tbs");
        set => SetProperty("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double> DbNodeStorageSizeInGbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("db_node_storage_size_in_gbs");
        set => SetProperty("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    public HashSet<TerraformProperty<string>> DbServers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("db_servers");
        set => SetProperty("db_servers", value);
    }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    public required TerraformProperty<string> GiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gi_version");
        set => SetProperty("gi_version", value);
    }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnamePrefix is required")]
    public required TerraformProperty<string> HostnamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostname_prefix");
        set => SetProperty("hostname_prefix", value);
    }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<bool> IsLocalBackupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_local_backup_enabled");
        set => SetProperty("is_local_backup_enabled", value);
    }

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<bool> IsSparseDiskgroupEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_sparse_diskgroup_enabled");
        set => SetProperty("is_sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string> LicenseModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_model");
        set => SetProperty("license_model", value);
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double> MemorySizeInGbs
    {
        get => GetRequiredOutput<TerraformProperty<double>>("memory_size_in_gbs");
        set => SetProperty("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
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
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double> ScanListenerPortTcp
    {
        get => GetRequiredOutput<TerraformProperty<double>>("scan_listener_port_tcp");
        set => SetProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public HashSet<TerraformProperty<string>> SshPublicKeys
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ssh_public_keys");
        set => SetProperty("ssh_public_keys", value);
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
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string> Timezone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timezone");
        set => SetProperty("timezone", value);
    }

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    public List<AwsOdbCloudVmClusterDataCollectionOptionsBlock>? DataCollectionOptions
    {
        set => SetProperty("data_collection_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOdbCloudVmClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The compute model used when the instance is created or cloned — either ECPU or OCPU. ECPU is a virtualized compute unit; OCPU is a physical processor core with hyper-threading.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The timestamp when the VM cluster was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The type of redundancy for the VM cluster: NORMAL (2-way) or HIGH (3-way).
    /// </summary>
    public TerraformExpression DiskRedundancy => this["disk_redundancy"];

    /// <summary>
    /// The domain name associated with the VM cluster.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// A complete software version of Oracle Grid Infrastructure (GI).
    /// </summary>
    public TerraformExpression GiVersionComputed => this["gi_version_computed"];

    /// <summary>
    /// The host name for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformExpression HostnamePrefixComputed => this["hostname_prefix_computed"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The Exadata IORM (I/O Resource Manager) configuration cache details for the VM cluster.
    /// </summary>
    public TerraformExpression IormConfigCache => this["iorm_config_cache"];

    /// <summary>
    /// The OCID of the most recent maintenance update history entry.
    /// </summary>
    public TerraformExpression LastUpdateHistoryEntryId => this["last_update_history_entry_id"];

    /// <summary>
    /// The listener port number configured on the VM cluster.
    /// </summary>
    public TerraformExpression ListenerPort => this["listener_port"];

    /// <summary>
    /// The total number of nodes in the VM cluster.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The name of the OCI resource anchor associated with the VM cluster.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The HTTPS link to the VM cluster resource in OCI.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The OCID (Oracle Cloud Identifier) of the VM cluster.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The percentage of progress made on the current operation for the VM cluster.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The fully qualified domain name (FQDN) for the SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformExpression ScanDnsName => this["scan_dns_name"];

    /// <summary>
    /// The OCID of the DNS record for the SCAN IPs linked to the VM cluster.
    /// </summary>
    public TerraformExpression ScanDnsRecordId => this["scan_dns_record_id"];

    /// <summary>
    /// The list of OCIDs for SCAN IP addresses associated with the VM cluster.
    /// </summary>
    public TerraformExpression ScanIpIds => this["scan_ip_ids"];

    /// <summary>
    /// The hardware model name of the Exadata infrastructure running the VM cluster.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The current lifecycle status of the VM cluster.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information regarding the current status of the VM cluster.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The local node storage allocated to the VM cluster, in gigabytes (GB).
    /// </summary>
    public TerraformExpression StorageSizeInGbs => this["storage_size_in_gbs"];

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformExpression SystemVersion => this["system_version"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The virtual IP (VIP) addresses assigned to the VM cluster. CRS assigns one VIP per node for failover support.
    /// </summary>
    public TerraformExpression VipIds => this["vip_ids"];

}

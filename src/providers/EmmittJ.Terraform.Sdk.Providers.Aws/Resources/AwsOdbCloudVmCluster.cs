using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOdbCloudVmClusterDataCollectionOptionsBlock() : TerraformBlock("data_collection_options")
{
    /// <summary>
    /// The is_diagnostics_events_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDiagnosticsEventsEnabled is required")]
    [TerraformProperty("is_diagnostics_events_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsDiagnosticsEventsEnabled { get; set; }

    /// <summary>
    /// The is_health_monitoring_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsHealthMonitoringEnabled is required")]
    [TerraformProperty("is_health_monitoring_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsHealthMonitoringEnabled { get; set; }

    /// <summary>
    /// The is_incident_logs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsIncidentLogsEnabled is required")]
    [TerraformProperty("is_incident_logs_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsIncidentLogsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOdbCloudVmClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_vm_cluster resource.
/// </summary>
public partial class AwsOdbCloudVmCluster : TerraformResource
{
    public AwsOdbCloudVmCluster(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("cluster_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformProperty("cpu_core_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CpuCoreCount { get; set; }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    [TerraformProperty("data_storage_size_in_tbs")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> DataStorageSizeInTbs { get; set; }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DbNodeStorageSizeInGbs { get; set; }

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformProperty("db_servers")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DbServers { get; set; }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformProperty("gi_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GiVersion { get; set; }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnamePrefix is required")]
    [TerraformProperty("hostname_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostnamePrefix { get; set; }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("is_local_backup_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IsLocalBackupEnabled { get; set; }

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("is_sparse_diskgroup_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IsSparseDiskgroupEnabled { get; set; }

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("license_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LicenseModel { get; set; }

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MemorySizeInGbs { get; set; }

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformProperty("odb_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OdbNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("scan_listener_port_tcp")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> ScanListenerPortTcp { get; set; }

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformProperty("ssh_public_keys")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SshPublicKeys { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Timezone { get; set; }

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("data_collection_options")]
    public TerraformList<AwsOdbCloudVmClusterDataCollectionOptionsBlock> DataCollectionOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsOdbCloudVmClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The compute model used when the instance is created or cloned — either ECPU or OCPU. ECPU is a virtualized compute unit; OCPU is a physical processor core with hyper-threading.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The timestamp when the VM cluster was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The type of redundancy for the VM cluster: NORMAL (2-way) or HIGH (3-way).
    /// </summary>
    [TerraformProperty("disk_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DiskRedundancy { get; }

    /// <summary>
    /// The domain name associated with the VM cluster.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Domain { get; }

    /// <summary>
    /// A complete software version of Oracle Grid Infrastructure (GI).
    /// </summary>
    [TerraformProperty("gi_version_computed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GiVersionComputed { get; }

    /// <summary>
    /// The host name for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [TerraformProperty("hostname_prefix_computed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostnamePrefixComputed { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The Exadata IORM (I/O Resource Manager) configuration cache details for the VM cluster.
    /// </summary>
    [TerraformProperty("iorm_config_cache")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IormConfigCache { get; }

    /// <summary>
    /// The OCID of the most recent maintenance update history entry.
    /// </summary>
    [TerraformProperty("last_update_history_entry_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdateHistoryEntryId { get; }

    /// <summary>
    /// The listener port number configured on the VM cluster.
    /// </summary>
    [TerraformProperty("listener_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ListenerPort { get; }

    /// <summary>
    /// The total number of nodes in the VM cluster.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// The name of the OCI resource anchor associated with the VM cluster.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The HTTPS link to the VM cluster resource in OCI.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The OCID (Oracle Cloud Identifier) of the VM cluster.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The percentage of progress made on the current operation for the VM cluster.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The fully qualified domain name (FQDN) for the SCAN IP addresses associated with the VM cluster.
    /// </summary>
    [TerraformProperty("scan_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ScanDnsName { get; }

    /// <summary>
    /// The OCID of the DNS record for the SCAN IPs linked to the VM cluster.
    /// </summary>
    [TerraformProperty("scan_dns_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ScanDnsRecordId { get; }

    /// <summary>
    /// The list of OCIDs for SCAN IP addresses associated with the VM cluster.
    /// </summary>
    [TerraformProperty("scan_ip_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ScanIpIds { get; }

    /// <summary>
    /// The hardware model name of the Exadata infrastructure running the VM cluster.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Shape { get; }

    /// <summary>
    /// The current lifecycle status of the VM cluster.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information regarding the current status of the VM cluster.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The local node storage allocated to the VM cluster, in gigabytes (GB).
    /// </summary>
    [TerraformProperty("storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> StorageSizeInGbs { get; }

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    [TerraformProperty("system_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SystemVersion { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The virtual IP (VIP) addresses assigned to the VM cluster. CRS assigns one VIP per node for failover support.
    /// </summary>
    [TerraformProperty("vip_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VipIds { get; }

}

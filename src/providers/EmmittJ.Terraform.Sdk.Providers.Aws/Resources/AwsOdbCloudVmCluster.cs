using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_collection_options in .
/// Nesting mode: list
/// </summary>
public class AwsOdbCloudVmClusterDataCollectionOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The is_diagnostics_events_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsDiagnosticsEventsEnabled is required")]
    [TerraformPropertyName("is_diagnostics_events_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsDiagnosticsEventsEnabled { get; set; }

    /// <summary>
    /// The is_health_monitoring_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsHealthMonitoringEnabled is required")]
    [TerraformPropertyName("is_health_monitoring_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsHealthMonitoringEnabled { get; set; }

    /// <summary>
    /// The is_incident_logs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsIncidentLogsEnabled is required")]
    [TerraformPropertyName("is_incident_logs_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> IsIncidentLogsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOdbCloudVmClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_odb_cloud_vm_cluster resource.
/// </summary>
public class AwsOdbCloudVmCluster : TerraformResource
{
    public AwsOdbCloudVmCluster(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_name");

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformPropertyName("cpu_core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CpuCoreCount { get; set; }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataStorageSizeInTbs is required")]
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs { get; set; }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbServers is required")]
    [TerraformPropertyName("db_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DbServers { get; set; }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GiVersion is required")]
    [TerraformPropertyName("gi_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GiVersion { get; set; }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostnamePrefix is required")]
    [TerraformPropertyName("hostname_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostnamePrefix { get; set; }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("is_local_backup_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IsLocalBackupEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_local_backup_enabled");

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("is_sparse_diskgroup_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> IsSparseDiskgroupEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_sparse_diskgroup_enabled");

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbNetworkId is required")]
    [TerraformPropertyName("odb_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OdbNetworkId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTcp { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scan_listener_port_tcp");

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformPropertyName("ssh_public_keys")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SshPublicKeys { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Timezone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone");

    /// <summary>
    /// Block for data_collection_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("data_collection_options")]
    public TerraformList<TerraformBlock<AwsOdbCloudVmClusterDataCollectionOptionsBlock>>? DataCollectionOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOdbCloudVmClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The compute model used when the instance is created or cloned — either ECPU or OCPU. ECPU is a virtualized compute unit; OCPU is a physical processor core with hyper-threading.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The timestamp when the VM cluster was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The type of redundancy for the VM cluster: NORMAL (2-way) or HIGH (3-way).
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskRedundancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_redundancy");

    /// <summary>
    /// The domain name associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// A complete software version of Oracle Grid Infrastructure (GI).
    /// </summary>
    [TerraformPropertyName("gi_version_computed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GiVersionComputed => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gi_version_computed");

    /// <summary>
    /// The host name for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    [TerraformPropertyName("hostname_prefix_computed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostnamePrefixComputed => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname_prefix_computed");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The Exadata IORM (I/O Resource Manager) configuration cache details for the VM cluster.
    /// </summary>
    [TerraformPropertyName("iorm_config_cache")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IormConfigCache => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "iorm_config_cache");

    /// <summary>
    /// The OCID of the most recent maintenance update history entry.
    /// </summary>
    [TerraformPropertyName("last_update_history_entry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdateHistoryEntryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_update_history_entry_id");

    /// <summary>
    /// The listener port number configured on the VM cluster.
    /// </summary>
    [TerraformPropertyName("listener_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ListenerPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "listener_port");

    /// <summary>
    /// The total number of nodes in the VM cluster.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The name of the OCI resource anchor associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the VM cluster resource in OCI.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The OCID (Oracle Cloud Identifier) of the VM cluster.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The percentage of progress made on the current operation for the VM cluster.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The fully qualified domain name (FQDN) for the SCAN IP addresses associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_name");

    /// <summary>
    /// The OCID of the DNS record for the SCAN IPs linked to the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_dns_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_record_id");

    /// <summary>
    /// The list of OCIDs for SCAN IP addresses associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_ip_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ScanIpIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "scan_ip_ids");

    /// <summary>
    /// The hardware model name of the Exadata infrastructure running the VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The current lifecycle status of the VM cluster.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information regarding the current status of the VM cluster.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The local node storage allocated to the VM cluster, in gigabytes (GB).
    /// </summary>
    [TerraformPropertyName("storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "storage_size_in_gbs");

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SystemVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "system_version");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The virtual IP (VIP) addresses assigned to the VM cluster. CRS assigns one VIP per node for failover support.
    /// </summary>
    [TerraformPropertyName("vip_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VipIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vip_ids");

}

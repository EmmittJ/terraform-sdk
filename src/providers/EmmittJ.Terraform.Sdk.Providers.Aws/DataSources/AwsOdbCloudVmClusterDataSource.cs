using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_vm_cluster.
/// </summary>
public partial class AwsOdbCloudVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudVmClusterDataSource(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ID of the Cloud Exadata Infrastructure.
    /// </summary>
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudExadataInfrastructureId { get; }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster.
    /// </summary>
    [TerraformProperty("cluster_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterName { get; }

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The number of CPU cores enabled on the VM cluster.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The time when the VM cluster was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The set of diagnostic collection options enabled for the VM cluster.
    /// </summary>
    [TerraformProperty("data_collection_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DataCollectionOptions { get; }

    /// <summary>
    /// The size of the data disk group, in terabytes (TB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformProperty("data_storage_size_in_tbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DataStorageSizeInTbs { get; }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The list of database servers for the VM cluster.
    /// </summary>
    [TerraformProperty("db_servers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> DbServers { get; }

    /// <summary>
    /// The type of redundancy configured for the VM cluster. NORMAL is 2-way redundancy. HIGH is 3-way redundancy.
    /// </summary>
    [TerraformProperty("disk_redundancy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DiskRedundancy { get; }

    /// <summary>
    /// The display name of the VM cluster.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The domain name of the VM cluster.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// he software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
    /// </summary>
    [TerraformProperty("gi_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GiVersion { get; }

    /// <summary>
    /// The computed hostname prefix for the VM cluster.
    /// </summary>
    [TerraformProperty("hostname_prefix_computed")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostnamePrefixComputed { get; }

    /// <summary>
    /// The ExadataIormConfig cache details for the VM cluster.
    /// </summary>
    [TerraformProperty("iorm_config_cache")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IormConfigCache { get; }

    /// <summary>
    /// Indicates whether database backups to local Exadata storage is enabled for the VM cluster.
    /// </summary>
    [TerraformProperty("is_local_backup_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsLocalBackupEnabled { get; }

    /// <summary>
    /// Indicates whether the VM cluster is configured with a sparse disk group.
    /// </summary>
    [TerraformProperty("is_sparse_disk_group_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IsSparseDiskGroupEnabled { get; }

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
    /// </summary>
    [TerraformProperty("last_update_history_entry_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdateHistoryEntryId { get; }

    /// <summary>
    /// The Oracle license model applied to the VM cluster.
    /// </summary>
    [TerraformProperty("license_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseModel { get; }

    /// <summary>
    /// The port number configured for the listener on the VM cluster.
    /// </summary>
    [TerraformProperty("listener_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ListenerPort { get; }

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The number of nodes in the VM cluster.
    /// </summary>
    [TerraformProperty("node_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> NodeCount { get; }

    /// <summary>
    /// The name of the OCI Resource Anchor.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The HTTPS link to the VM cluster in OCI.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The OCID of the VM cluster.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The ID of the ODB network.
    /// </summary>
    [TerraformProperty("odb_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OdbNetworkId { get; }

    /// <summary>
    /// The amount of progress made on the current operation on the VM cluster,expressed as a percentage.
    /// </summary>
    [TerraformProperty("percent_progress")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PercentProgress { get; }

    /// <summary>
    /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP
    ///  addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformProperty("scan_dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScanDnsName { get; }

    /// <summary>
    /// The OCID of the DNS record for the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformProperty("scan_dns_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScanDnsRecordId { get; }

    /// <summary>
    /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformProperty("scan_ip_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ScanIpIds { get; }

    /// <summary>
    /// The hardware model name of the Exadata infrastructure that&#39;s running the VM cluster.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Shape { get; }

    /// <summary>
    /// he public key portion of one or more key pairs used for SSH access to the VM cluster.
    /// </summary>
    [TerraformProperty("ssh_public_keys")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SshPublicKeys { get; }

    /// <summary>
    /// The status of the VM cluster.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the status of the VM cluster.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated to the VM cluster.
    /// </summary>
    [TerraformProperty("storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> StorageSizeInGbs { get; }

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    [TerraformProperty("system_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SystemVersion { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The time zone of the VM cluster.
    /// </summary>
    [TerraformProperty("timezone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Timezone { get; }

    /// <summary>
    /// The virtual IP (VIP) addresses that are associated with the VM cluster.
    /// Oracle&#39;s Cluster Ready Services (CRS) creates and maintains one VIP address for
    /// each node in the VM cluster to enable failover. If one node fails, the VIP is
    /// reassigned to another active node in the cluster.
    /// </summary>
    [TerraformProperty("vip_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> VipIds { get; }

}

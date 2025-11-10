using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_vm_cluster.
/// </summary>
public class AwsOdbCloudVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudVmClusterDataSource(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ID of the Cloud Exadata Infrastructure.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloud_exadata_infrastructure_id");

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_name");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The number of CPU cores enabled on the VM cluster.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The time when the VM cluster was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The set of diagnostic collection options enabled for the VM cluster.
    /// </summary>
    [TerraformPropertyName("data_collection_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataCollectionOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_collection_options");

    /// <summary>
    /// The size of the data disk group, in terabytes (TB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformPropertyName("data_storage_size_in_tbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeInTbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "data_storage_size_in_tbs");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The list of database servers for the VM cluster.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DbServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "db_servers");

    /// <summary>
    /// The type of redundancy configured for the VM cluster. NORMAL is 2-way redundancy. HIGH is 3-way redundancy.
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DiskRedundancy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disk_redundancy");

    /// <summary>
    /// The display name of the VM cluster.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The domain name of the VM cluster.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// he software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
    /// </summary>
    [TerraformPropertyName("gi_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GiVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gi_version");

    /// <summary>
    /// The computed hostname prefix for the VM cluster.
    /// </summary>
    [TerraformPropertyName("hostname_prefix_computed")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostnamePrefixComputed => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hostname_prefix_computed");

    /// <summary>
    /// The ExadataIormConfig cache details for the VM cluster.
    /// </summary>
    [TerraformPropertyName("iorm_config_cache")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IormConfigCache => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "iorm_config_cache");

    /// <summary>
    /// Indicates whether database backups to local Exadata storage is enabled for the VM cluster.
    /// </summary>
    [TerraformPropertyName("is_local_backup_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsLocalBackupEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_local_backup_enabled");

    /// <summary>
    /// Indicates whether the VM cluster is configured with a sparse disk group.
    /// </summary>
    [TerraformPropertyName("is_sparse_disk_group_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsSparseDiskGroupEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_sparse_disk_group_enabled");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
    /// </summary>
    [TerraformPropertyName("last_update_history_entry_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdateHistoryEntryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_update_history_entry_id");

    /// <summary>
    /// The Oracle license model applied to the VM cluster.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_model");

    /// <summary>
    /// The port number configured for the listener on the VM cluster.
    /// </summary>
    [TerraformPropertyName("listener_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ListenerPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "listener_port");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The number of nodes in the VM cluster.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "node_count");

    /// <summary>
    /// The name of the OCI Resource Anchor.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the VM cluster in OCI.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The OCID of the VM cluster.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The ID of the ODB network.
    /// </summary>
    [TerraformPropertyName("odb_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OdbNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_network_id");

    /// <summary>
    /// The amount of progress made on the current operation on the VM cluster,expressed as a percentage.
    /// </summary>
    [TerraformPropertyName("percent_progress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PercentProgress => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "percent_progress");

    /// <summary>
    /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP
    ///  addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_name");

    /// <summary>
    /// The OCID of the DNS record for the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_dns_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "scan_dns_record_id");

    /// <summary>
    /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    [TerraformPropertyName("scan_ip_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ScanIpIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "scan_ip_ids");

    /// <summary>
    /// The hardware model name of the Exadata infrastructure that&#39;s running the VM cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// he public key portion of one or more key pairs used for SSH access to the VM cluster.
    /// </summary>
    [TerraformPropertyName("ssh_public_keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SshPublicKeys => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "ssh_public_keys");

    /// <summary>
    /// The status of the VM cluster.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the status of the VM cluster.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated to the VM cluster.
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time zone of the VM cluster.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Timezone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone");

    /// <summary>
    /// The virtual IP (VIP) addresses that are associated with the VM cluster.
    /// Oracle&#39;s Cluster Ready Services (CRS) creates and maintains one VIP address for
    /// each node in the VM cluster to enable failover. If one node fails, the VIP is
    /// reassigned to another active node in the cluster.
    /// </summary>
    [TerraformPropertyName("vip_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VipIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vip_ids");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_vm_cluster.
/// </summary>
public class AwsOdbCloudVmClusterDataSource : TerraformDataSource
{
    public AwsOdbCloudVmClusterDataSource(string name) : base("aws_odb_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("cloud_exadata_infrastructure_id");
        this.WithOutput("cluster_name");
        this.WithOutput("compute_model");
        this.WithOutput("cpu_core_count");
        this.WithOutput("created_at");
        this.WithOutput("data_collection_options");
        this.WithOutput("data_storage_size_in_tbs");
        this.WithOutput("db_node_storage_size_in_gbs");
        this.WithOutput("db_servers");
        this.WithOutput("disk_redundancy");
        this.WithOutput("display_name");
        this.WithOutput("domain");
        this.WithOutput("gi_version");
        this.WithOutput("hostname_prefix_computed");
        this.WithOutput("iorm_config_cache");
        this.WithOutput("is_local_backup_enabled");
        this.WithOutput("is_sparse_disk_group_enabled");
        this.WithOutput("last_update_history_entry_id");
        this.WithOutput("license_model");
        this.WithOutput("listener_port");
        this.WithOutput("memory_size_in_gbs");
        this.WithOutput("node_count");
        this.WithOutput("oci_resource_anchor_name");
        this.WithOutput("oci_url");
        this.WithOutput("ocid");
        this.WithOutput("odb_network_id");
        this.WithOutput("percent_progress");
        this.WithOutput("scan_dns_name");
        this.WithOutput("scan_dns_record_id");
        this.WithOutput("scan_ip_ids");
        this.WithOutput("shape");
        this.WithOutput("ssh_public_keys");
        this.WithOutput("status");
        this.WithOutput("status_reason");
        this.WithOutput("storage_size_in_gbs");
        this.WithOutput("system_version");
        this.WithOutput("tags");
        this.WithOutput("timezone");
        this.WithOutput("vip_ids");
    }

    /// <summary>
    /// The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ID of the Cloud Exadata Infrastructure.
    /// </summary>
    public TerraformExpression CloudExadataInfrastructureId => this["cloud_exadata_infrastructure_id"];

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster.
    /// </summary>
    public TerraformExpression ClusterName => this["cluster_name"];

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The number of CPU cores enabled on the VM cluster.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The time when the VM cluster was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The set of diagnostic collection options enabled for the VM cluster.
    /// </summary>
    public TerraformExpression DataCollectionOptions => this["data_collection_options"];

    /// <summary>
    /// The size of the data disk group, in terabytes (TB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformExpression DataStorageSizeInTbs => this["data_storage_size_in_tbs"];

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The list of database servers for the VM cluster.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

    /// <summary>
    /// The type of redundancy configured for the VM cluster. NORMAL is 2-way redundancy. HIGH is 3-way redundancy.
    /// </summary>
    public TerraformExpression DiskRedundancy => this["disk_redundancy"];

    /// <summary>
    /// The display name of the VM cluster.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The domain name of the VM cluster.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// he software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
    /// </summary>
    public TerraformExpression GiVersion => this["gi_version"];

    /// <summary>
    /// The computed hostname prefix for the VM cluster.
    /// </summary>
    public TerraformExpression HostnamePrefixComputed => this["hostname_prefix_computed"];

    /// <summary>
    /// The ExadataIormConfig cache details for the VM cluster.
    /// </summary>
    public TerraformExpression IormConfigCache => this["iorm_config_cache"];

    /// <summary>
    /// Indicates whether database backups to local Exadata storage is enabled for the VM cluster.
    /// </summary>
    public TerraformExpression IsLocalBackupEnabled => this["is_local_backup_enabled"];

    /// <summary>
    /// Indicates whether the VM cluster is configured with a sparse disk group.
    /// </summary>
    public TerraformExpression IsSparseDiskGroupEnabled => this["is_sparse_disk_group_enabled"];

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
    /// </summary>
    public TerraformExpression LastUpdateHistoryEntryId => this["last_update_history_entry_id"];

    /// <summary>
    /// The Oracle license model applied to the VM cluster.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The port number configured for the listener on the VM cluster.
    /// </summary>
    public TerraformExpression ListenerPort => this["listener_port"];

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The number of nodes in the VM cluster.
    /// </summary>
    public TerraformExpression NodeCount => this["node_count"];

    /// <summary>
    /// The name of the OCI Resource Anchor.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The HTTPS link to the VM cluster in OCI.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The OCID of the VM cluster.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The ID of the ODB network.
    /// </summary>
    public TerraformExpression OdbNetworkId => this["odb_network_id"];

    /// <summary>
    /// The amount of progress made on the current operation on the VM cluster,expressed as a percentage.
    /// </summary>
    public TerraformExpression PercentProgress => this["percent_progress"];

    /// <summary>
    /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP
    ///  addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformExpression ScanDnsName => this["scan_dns_name"];

    /// <summary>
    /// The OCID of the DNS record for the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformExpression ScanDnsRecordId => this["scan_dns_record_id"];

    /// <summary>
    /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformExpression ScanIpIds => this["scan_ip_ids"];

    /// <summary>
    /// The hardware model name of the Exadata infrastructure that&#39;s running the VM cluster.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// he public key portion of one or more key pairs used for SSH access to the VM cluster.
    /// </summary>
    public TerraformExpression SshPublicKeys => this["ssh_public_keys"];

    /// <summary>
    /// The status of the VM cluster.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the status of the VM cluster.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated to the VM cluster.
    /// </summary>
    public TerraformExpression StorageSizeInGbs => this["storage_size_in_gbs"];

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformExpression SystemVersion => this["system_version"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time zone of the VM cluster.
    /// </summary>
    public TerraformExpression Timezone => this["timezone"];

    /// <summary>
    /// The virtual IP (VIP) addresses that are associated with the VM cluster.
    /// Oracle&#39;s Cluster Ready Services (CRS) creates and maintains one VIP address for
    /// each node in the VM cluster to enable failover. If one node fails, the VIP is
    /// reassigned to another active node in the cluster.
    /// </summary>
    public TerraformExpression VipIds => this["vip_ids"];

}

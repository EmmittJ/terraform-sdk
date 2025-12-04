using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_vm_cluster Terraform data source.
/// Retrieves information about a aws_odb_cloud_vm_cluster.
/// </summary>
public partial class AwsOdbCloudVmClusterDataSource(string name) : TerraformDataSource("aws_odb_cloud_vm_cluster", name)
{
    /// <summary>
    /// The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ID of the Cloud Exadata Infrastructure.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
        => AsReference("cloud_exadata_infrastructure_id");

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster.
    /// </summary>
    public TerraformValue<string> ClusterName
        => AsReference("cluster_name");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => AsReference("compute_model");

    /// <summary>
    /// The number of CPU cores enabled on the VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => AsReference("cpu_core_count");

    /// <summary>
    /// The time when the VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The set of diagnostic collection options enabled for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataCollectionOptions
        => AsReference("data_collection_options");

    /// <summary>
    /// The size of the data disk group, in terabytes (TB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => AsReference("data_storage_size_in_tbs");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => AsReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The list of database servers for the VM cluster.
    /// </summary>
    public TerraformList<string> DbServers
        => AsReference("db_servers");

    /// <summary>
    /// The type of redundancy configured for the VM cluster. NORMAL is 2-way redundancy. HIGH is 3-way redundancy.
    /// </summary>
    public TerraformValue<string> DiskRedundancy
        => AsReference("disk_redundancy");

    /// <summary>
    /// The display name of the VM cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The domain name of the VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// he software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
    /// </summary>
    public TerraformValue<string> GiVersion
        => AsReference("gi_version");

    /// <summary>
    /// The computed hostname prefix for the VM cluster.
    /// </summary>
    public TerraformValue<string> HostnamePrefixComputed
        => AsReference("hostname_prefix_computed");

    /// <summary>
    /// The ExadataIormConfig cache details for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
        => AsReference("iorm_config_cache");

    /// <summary>
    /// Indicates whether database backups to local Exadata storage is enabled for the VM cluster.
    /// </summary>
    public TerraformValue<bool> IsLocalBackupEnabled
        => AsReference("is_local_backup_enabled");

    /// <summary>
    /// Indicates whether the VM cluster is configured with a sparse disk group.
    /// </summary>
    public TerraformValue<bool> IsSparseDiskGroupEnabled
        => AsReference("is_sparse_disk_group_enabled");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
        => AsReference("last_update_history_entry_id");

    /// <summary>
    /// The Oracle license model applied to the VM cluster.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => AsReference("license_model");

    /// <summary>
    /// The port number configured for the listener on the VM cluster.
    /// </summary>
    public TerraformValue<double> ListenerPort
        => AsReference("listener_port");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => AsReference("memory_size_in_gbs");

    /// <summary>
    /// The number of nodes in the VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
        => AsReference("node_count");

    /// <summary>
    /// The name of the OCI Resource Anchor.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => AsReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the VM cluster in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The OCID of the VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The ID of the ODB network.
    /// </summary>
    public TerraformValue<string> OdbNetworkId
        => AsReference("odb_network_id");

    /// <summary>
    /// The amount of progress made on the current operation on the VM cluster,expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => AsReference("percent_progress");

    /// <summary>
    /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP
    ///  addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsName
        => AsReference("scan_dns_name");

    /// <summary>
    /// The OCID of the DNS record for the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
        => AsReference("scan_dns_record_id");

    /// <summary>
    /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformList<string> ScanIpIds
        => AsReference("scan_ip_ids");

    /// <summary>
    /// The hardware model name of the Exadata infrastructure that&#39;s running the VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
        => AsReference("shape");

    /// <summary>
    /// he public key portion of one or more key pairs used for SSH access to the VM cluster.
    /// </summary>
    public TerraformList<string> SshPublicKeys
        => AsReference("ssh_public_keys");

    /// <summary>
    /// The status of the VM cluster.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Additional information about the status of the VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated to the VM cluster.
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
        => AsReference("storage_size_in_gbs");

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformValue<string> SystemVersion
        => AsReference("system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The time zone of the VM cluster.
    /// </summary>
    public TerraformValue<string> Timezone
        => AsReference("timezone");

    /// <summary>
    /// The virtual IP (VIP) addresses that are associated with the VM cluster.
    /// Oracle&#39;s Cluster Ready Services (CRS) creates and maintains one VIP address for
    /// each node in the VM cluster to enable failover. If one node fails, the VIP is
    /// reassigned to another active node in the cluster.
    /// </summary>
    public TerraformList<string> VipIds
        => AsReference("vip_ids");

}

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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The ID of the Cloud Exadata Infrastructure.
    /// </summary>
    public TerraformValue<string> CloudExadataInfrastructureId
        => CreateReference("cloud_exadata_infrastructure_id");

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster.
    /// </summary>
    public TerraformValue<string> ClusterName
        => CreateReference("cluster_name");

    /// <summary>
    /// The OCI model compute model used when you create or clone an instance: ECPU or
    /// OCPU. An ECPU is an abstracted measure of compute resources. ECPUs are based on
    /// the number of cores elastically allocated from a pool of compute and storage
    /// servers. An OCPU is a legacy physical measure of compute resources. OCPUs are
    /// based on the physical core of a processor with hyper-threading enabled.
    /// </summary>
    public TerraformValue<string> ComputeModel
        => CreateReference("compute_model");

    /// <summary>
    /// The number of CPU cores enabled on the VM cluster.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
        => CreateReference("cpu_core_count");

    /// <summary>
    /// The time when the VM cluster was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The set of diagnostic collection options enabled for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataCollectionOptions
        => CreateReference("data_collection_options");

    /// <summary>
    /// The size of the data disk group, in terabytes (TB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> DataStorageSizeInTbs
        => CreateReference("data_storage_size_in_tbs");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
        => CreateReference("db_node_storage_size_in_gbs");

    /// <summary>
    /// The list of database servers for the VM cluster.
    /// </summary>
    public TerraformList<string> DbServers
        => CreateReference("db_servers");

    /// <summary>
    /// The type of redundancy configured for the VM cluster. NORMAL is 2-way redundancy. HIGH is 3-way redundancy.
    /// </summary>
    public TerraformValue<string> DiskRedundancy
        => CreateReference("disk_redundancy");

    /// <summary>
    /// The display name of the VM cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The domain name of the VM cluster.
    /// </summary>
    public TerraformValue<string> Domain
        => CreateReference("domain");

    /// <summary>
    /// he software version of the Oracle Grid Infrastructure (GI) for the VM cluster.
    /// </summary>
    public TerraformValue<string> GiVersion
        => CreateReference("gi_version");

    /// <summary>
    /// The computed hostname prefix for the VM cluster.
    /// </summary>
    public TerraformValue<string> HostnamePrefixComputed
        => CreateReference("hostname_prefix_computed");

    /// <summary>
    /// The ExadataIormConfig cache details for the VM cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> IormConfigCache
        => CreateReference("iorm_config_cache");

    /// <summary>
    /// Indicates whether database backups to local Exadata storage is enabled for the VM cluster.
    /// </summary>
    public TerraformValue<bool> IsLocalBackupEnabled
        => CreateReference("is_local_backup_enabled");

    /// <summary>
    /// Indicates whether the VM cluster is configured with a sparse disk group.
    /// </summary>
    public TerraformValue<bool> IsSparseDiskGroupEnabled
        => CreateReference("is_sparse_disk_group_enabled");

    /// <summary>
    /// The Oracle Cloud ID (OCID) of the last maintenance update history entry.
    /// </summary>
    public TerraformValue<string> LastUpdateHistoryEntryId
        => CreateReference("last_update_history_entry_id");

    /// <summary>
    /// The Oracle license model applied to the VM cluster.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => CreateReference("license_model");

    /// <summary>
    /// The port number configured for the listener on the VM cluster.
    /// </summary>
    public TerraformValue<double> ListenerPort
        => CreateReference("listener_port");

    /// <summary>
    /// The amount of memory, in gigabytes (GB), that&#39;s allocated for the VM cluster.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
        => CreateReference("memory_size_in_gbs");

    /// <summary>
    /// The number of nodes in the VM cluster.
    /// </summary>
    public TerraformValue<double> NodeCount
        => CreateReference("node_count");

    /// <summary>
    /// The name of the OCI Resource Anchor.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
        => CreateReference("oci_resource_anchor_name");

    /// <summary>
    /// The HTTPS link to the VM cluster in OCI.
    /// </summary>
    public TerraformValue<string> OciUrl
        => CreateReference("oci_url");

    /// <summary>
    /// The OCID of the VM cluster.
    /// </summary>
    public TerraformValue<string> Ocid
        => CreateReference("ocid");

    /// <summary>
    /// The ID of the ODB network.
    /// </summary>
    public TerraformValue<string> OdbNetworkId
        => CreateReference("odb_network_id");

    /// <summary>
    /// The amount of progress made on the current operation on the VM cluster,expressed as a percentage.
    /// </summary>
    public TerraformValue<double> PercentProgress
        => CreateReference("percent_progress");

    /// <summary>
    /// The FQDN of the DNS record for the Single Client Access Name (SCAN) IP
    ///  addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsName
        => CreateReference("scan_dns_name");

    /// <summary>
    /// The OCID of the DNS record for the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformValue<string> ScanDnsRecordId
        => CreateReference("scan_dns_record_id");

    /// <summary>
    /// The OCID of the SCAN IP addresses that are associated with the VM cluster.
    /// </summary>
    public TerraformList<string> ScanIpIds
        => CreateReference("scan_ip_ids");

    /// <summary>
    /// The hardware model name of the Exadata infrastructure that&#39;s running the VM cluster.
    /// </summary>
    public TerraformValue<string> Shape
        => CreateReference("shape");

    /// <summary>
    /// he public key portion of one or more key pairs used for SSH access to the VM cluster.
    /// </summary>
    public TerraformList<string> SshPublicKeys
        => CreateReference("ssh_public_keys");

    /// <summary>
    /// The status of the VM cluster.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Additional information about the status of the VM cluster.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// The amount of local node storage, in gigabytes (GB), that&#39;s allocated to the VM cluster.
    /// </summary>
    public TerraformValue<double> StorageSizeInGbs
        => CreateReference("storage_size_in_gbs");

    /// <summary>
    /// The operating system version of the image chosen for the VM cluster.
    /// </summary>
    public TerraformValue<string> SystemVersion
        => CreateReference("system_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The time zone of the VM cluster.
    /// </summary>
    public TerraformValue<string> Timezone
        => CreateReference("timezone");

    /// <summary>
    /// The virtual IP (VIP) addresses that are associated with the VM cluster.
    /// Oracle&#39;s Cluster Ready Services (CRS) creates and maintains one VIP address for
    /// each node in the VM cluster to enable failover. If one node fails, the VIP is
    /// reassigned to another active node in the cluster.
    /// </summary>
    public TerraformList<string> VipIds
        => CreateReference("vip_ids");

}

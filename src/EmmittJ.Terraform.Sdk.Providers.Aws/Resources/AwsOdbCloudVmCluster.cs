using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("compute_model");
        this.DeclareOutput("created_at");
        this.DeclareOutput("disk_redundancy");
        this.DeclareOutput("domain");
        this.DeclareOutput("gi_version_computed");
        this.DeclareOutput("hostname_prefix_computed");
        this.DeclareOutput("id");
        this.DeclareOutput("iorm_config_cache");
        this.DeclareOutput("last_update_history_entry_id");
        this.DeclareOutput("listener_port");
        this.DeclareOutput("node_count");
        this.DeclareOutput("oci_resource_anchor_name");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("ocid");
        this.DeclareOutput("percent_progress");
        this.DeclareOutput("scan_dns_name");
        this.DeclareOutput("scan_dns_record_id");
        this.DeclareOutput("scan_ip_ids");
        this.DeclareOutput("shape");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
        this.DeclareOutput("storage_size_in_gbs");
        this.DeclareOutput("system_version");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vip_ids");
    }

    /// <summary>
    /// The unique identifier of the Exadata infrastructure for this VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => this.WithProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The name of the Grid Infrastructure (GI) cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The number of CPU cores to enable on the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double>? CpuCoreCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_core_count");
        set => this.WithProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The size of the data disk group, in terabytes (TBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeInTbs
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_in_tbs");
        set => this.WithProperty("data_storage_size_in_tbs", value);
    }

    /// <summary>
    /// The amount of local node storage, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeInGbs
    {
        get => GetProperty<TerraformProperty<double>>("db_node_storage_size_in_gbs");
        set => this.WithProperty("db_node_storage_size_in_gbs", value);
    }

    /// <summary>
    /// The list of database servers for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DbServers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("db_servers");
        set => this.WithProperty("db_servers", value);
    }

    /// <summary>
    /// A user-friendly name for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// A valid software version of Oracle Grid Infrastructure (GI). To get the list of valid values, use the ListGiVersions operation and specify the shape of the Exadata infrastructure. Example: 19.0.0.0 This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? GiVersion
    {
        get => GetProperty<TerraformProperty<string>>("gi_version");
        set => this.WithProperty("gi_version", value);
    }

    /// <summary>
    /// The host name prefix for the VM cluster. Constraints: - Can&#39;t be &amp;quot;localhost&amp;quot; or &amp;quot;hostname&amp;quot;. - Can&#39;t contain &amp;quot;-version&amp;quot;. - The maximum length of the combined hostname and domain is 63 characters. - The hostname must be unique within the subnet. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? HostnamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("hostname_prefix");
        set => this.WithProperty("hostname_prefix", value);
    }

    /// <summary>
    /// Specifies whether to enable database backups to local Exadata storage for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<bool>? IsLocalBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_local_backup_enabled");
        set => this.WithProperty("is_local_backup_enabled", value);
    }

    /// <summary>
    /// Specifies whether to create a sparse disk group for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<bool>? IsSparseDiskgroupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("is_sparse_diskgroup_enabled");
        set => this.WithProperty("is_sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// The Oracle license model to apply to the VM cluster. Default: LICENSE_INCLUDED. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? LicenseModel
    {
        get => GetProperty<TerraformProperty<string>>("license_model");
        set => this.WithProperty("license_model", value);
    }

    /// <summary>
    /// The amount of memory, in gigabytes (GBs), to allocate for the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double>? MemorySizeInGbs
    {
        get => GetProperty<TerraformProperty<double>>("memory_size_in_gbs");
        set => this.WithProperty("memory_size_in_gbs", value);
    }

    /// <summary>
    /// The unique identifier of the ODB network for the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? OdbNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("odb_network_id");
        set => this.WithProperty("odb_network_id", value);
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
    /// The port number for TCP connections to the single client access name (SCAN) listener. Valid values: 1024–8999 with the following exceptions: 2484 , 6100 , 6200 , 7060, 7070 , 7085 , and 7879Default: 1521. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcp
    {
        get => GetProperty<TerraformProperty<double>>("scan_listener_port_tcp");
        set => this.WithProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// The public key portion of one or more key pairs used for SSH access to the VM cluster. This member is required. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SshPublicKeys
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ssh_public_keys");
        set => this.WithProperty("ssh_public_keys", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The configured time zone of the VM cluster. Changing this will create a new resource.
    /// </summary>
    public TerraformProperty<string>? Timezone
    {
        get => GetProperty<TerraformProperty<string>>("timezone");
        set => this.WithProperty("timezone", value);
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

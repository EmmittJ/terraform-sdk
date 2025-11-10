using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// OCI Cluster name.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => WithProperty("cluster_name", value);
    }

    /// <summary>
    /// Compartment ID of cluster.
    /// </summary>
    public TerraformProperty<string>? CompartmentId
    {
        get => GetProperty<TerraformProperty<string>>("compartment_id");
        set => WithProperty("compartment_id", value);
    }

    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformProperty<double> CpuCoreCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_core_count");
        set => WithProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeTb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_tb");
        set => WithProperty("data_storage_size_tb", value);
    }

    /// <summary>
    /// Local storage per VM
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("db_node_storage_size_gb");
        set => WithProperty("db_node_storage_size_gb", value);
    }

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    public List<TerraformProperty<string>>? DbServerOcids
    {
        get => GetProperty<List<TerraformProperty<string>>>("db_server_ocids");
        set => WithProperty("db_server_ocids", value);
    }

    /// <summary>
    /// The type of redundancy. 
    ///  Possible values:
    ///  DISK_REDUNDANCY_UNSPECIFIED
    /// HIGH
    /// NORMAL
    /// </summary>
    public TerraformProperty<string>? DiskRedundancy
    {
        get => GetProperty<TerraformProperty<string>>("disk_redundancy");
        set => WithProperty("disk_redundancy", value);
    }

    /// <summary>
    /// DNS listener IP.
    /// </summary>
    public TerraformProperty<string>? DnsListenerIp
    {
        get => GetProperty<TerraformProperty<string>>("dns_listener_ip");
        set => WithProperty("dns_listener_ip", value);
    }

    /// <summary>
    /// Parent DNS domain where SCAN DNS and hosts names are qualified.
    /// ex: ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    public TerraformProperty<string>? GiVersion
    {
        get => GetProperty<TerraformProperty<string>>("gi_version");
        set => WithProperty("gi_version", value);
    }

    /// <summary>
    /// host name without domain.
    /// format: &amp;quot;-&amp;quot; with some suffix.
    /// ex: sp2-yi0xq where &amp;quot;sp2&amp;quot; is the hostname_prefix.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    public TerraformProperty<string>? HostnamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("hostname_prefix");
        set => WithProperty("hostname_prefix", value);
    }

    /// <summary>
    /// License type of VM Cluster. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    public required TerraformProperty<string> LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => WithProperty("license_type", value);
    }

    /// <summary>
    /// Use local backup.
    /// </summary>
    public TerraformProperty<bool>? LocalBackupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_backup_enabled");
        set => WithProperty("local_backup_enabled", value);
    }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        get => GetProperty<TerraformProperty<double>>("memory_size_gb");
        set => WithProperty("memory_size_gb", value);
    }

    /// <summary>
    /// Number of database servers.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformProperty<string>? OciUrl
    {
        get => GetProperty<TerraformProperty<string>>("oci_url");
        set => WithProperty("oci_url", value);
    }

    /// <summary>
    /// Oracle Cloud Infrastructure ID of VM Cluster.
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        get => GetProperty<TerraformProperty<string>>("ocid");
        set => WithProperty("ocid", value);
    }

    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    public TerraformProperty<double>? OcpuCount
    {
        get => GetProperty<TerraformProperty<double>>("ocpu_count");
        set => WithProperty("ocpu_count", value);
    }

    /// <summary>
    /// SCAN DNS name.
    /// ex: sp2-yi0xq-scan.ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformProperty<string>? ScanDns
    {
        get => GetProperty<TerraformProperty<string>>("scan_dns");
        set => WithProperty("scan_dns", value);
    }

    /// <summary>
    /// OCID of scan DNS record.
    /// </summary>
    public TerraformProperty<string>? ScanDnsRecordId
    {
        get => GetProperty<TerraformProperty<string>>("scan_dns_record_id");
        set => WithProperty("scan_dns_record_id", value);
    }

    /// <summary>
    /// OCIDs of scan IPs.
    /// </summary>
    public List<TerraformProperty<string>>? ScanIpIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("scan_ip_ids");
        set => WithProperty("scan_ip_ids", value);
    }

    /// <summary>
    /// SCAN listener port - TCP
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcp
    {
        get => GetProperty<TerraformProperty<double>>("scan_listener_port_tcp");
        set => WithProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// SCAN listener port - TLS
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcpSsl
    {
        get => GetProperty<TerraformProperty<double>>("scan_listener_port_tcp_ssl");
        set => WithProperty("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// Shape of VM Cluster.
    /// </summary>
    public TerraformProperty<string>? Shape
    {
        get => GetProperty<TerraformProperty<string>>("shape");
        set => WithProperty("shape", value);
    }

    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    public TerraformProperty<bool>? SparseDiskgroupEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sparse_diskgroup_enabled");
        set => WithProperty("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    public List<TerraformProperty<string>>? SshPublicKeys
    {
        get => GetProperty<List<TerraformProperty<string>>>("ssh_public_keys");
        set => WithProperty("ssh_public_keys", value);
    }

    /// <summary>
    /// State of the cluster. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// TERMINATING
    /// TERMINATED
    /// FAILED
    /// MAINTENANCE_IN_PROGRESS
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The storage allocation for the disk group, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? StorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("storage_size_gb");
        set => WithProperty("storage_size_gb", value);
    }

    /// <summary>
    /// Operating system version of the image.
    /// </summary>
    public TerraformProperty<string>? SystemVersion
    {
        get => GetProperty<TerraformProperty<string>>("system_version");
        set => WithProperty("system_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_oracle_database_cloud_vm_cluster resource.
/// </summary>
public class GoogleOracleDatabaseCloudVmCluster : TerraformResource
{
    public GoogleOracleDatabaseCloudVmCluster(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("gcp_oracle_zone");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformProperty<string>? BackupOdbSubnet
    {
        get => GetProperty<TerraformProperty<string>>("backup_odb_subnet");
        set => this.WithProperty("backup_odb_subnet", value);
    }

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    public TerraformProperty<string>? BackupSubnetCidr
    {
        get => GetProperty<TerraformProperty<string>>("backup_subnet_cidr");
        set => this.WithProperty("backup_subnet_cidr", value);
    }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
    }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformProperty<string> CloudVmClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => this.WithProperty("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    public required TerraformProperty<string> ExadataInfrastructure
    {
        get => GetProperty<TerraformProperty<string>>("exadata_infrastructure");
        set => this.WithProperty("exadata_infrastructure", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformProperty<string>? OdbNetwork
    {
        get => GetProperty<TerraformProperty<string>>("odb_network");
        set => this.WithProperty("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformProperty<string>? OdbSubnet
    {
        get => GetProperty<TerraformProperty<string>>("odb_subnet");
        set => this.WithProperty("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>? Properties
    {
        get => GetProperty<List<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseCloudVmClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOracleDatabaseCloudVmClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    public TerraformExpression GcpOracleZone => this["gcp_oracle_zone"];

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}

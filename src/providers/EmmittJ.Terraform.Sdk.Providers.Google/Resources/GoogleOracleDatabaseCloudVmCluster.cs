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
        set => SetProperty("cluster_name", value);
    }

    /// <summary>
    /// Compartment ID of cluster.
    /// </summary>
    public TerraformProperty<string>? CompartmentId
    {
        set => SetProperty("compartment_id", value);
    }

    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    public required TerraformProperty<double> CpuCoreCount
    {
        set => SetProperty("cpu_core_count", value);
    }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeTb
    {
        set => SetProperty("data_storage_size_tb", value);
    }

    /// <summary>
    /// Local storage per VM
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeGb
    {
        set => SetProperty("db_node_storage_size_gb", value);
    }

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    public List<TerraformProperty<string>>? DbServerOcids
    {
        set => SetProperty("db_server_ocids", value);
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
        set => SetProperty("disk_redundancy", value);
    }

    /// <summary>
    /// DNS listener IP.
    /// </summary>
    public TerraformProperty<string>? DnsListenerIp
    {
        set => SetProperty("dns_listener_ip", value);
    }

    /// <summary>
    /// Parent DNS domain where SCAN DNS and hosts names are qualified.
    /// ex: ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    public TerraformProperty<string>? GiVersion
    {
        set => SetProperty("gi_version", value);
    }

    /// <summary>
    /// host name without domain.
    /// format: &amp;quot;-&amp;quot; with some suffix.
    /// ex: sp2-yi0xq where &amp;quot;sp2&amp;quot; is the hostname_prefix.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    public TerraformProperty<string>? HostnamePrefix
    {
        set => SetProperty("hostname_prefix", value);
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
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// Use local backup.
    /// </summary>
    public TerraformProperty<bool>? LocalBackupEnabled
    {
        set => SetProperty("local_backup_enabled", value);
    }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        set => SetProperty("memory_size_gb", value);
    }

    /// <summary>
    /// Number of database servers.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformProperty<string>? OciUrl
    {
        set => SetProperty("oci_url", value);
    }

    /// <summary>
    /// Oracle Cloud Infrastructure ID of VM Cluster.
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        set => SetProperty("ocid", value);
    }

    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    public TerraformProperty<double>? OcpuCount
    {
        set => SetProperty("ocpu_count", value);
    }

    /// <summary>
    /// SCAN DNS name.
    /// ex: sp2-yi0xq-scan.ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    public TerraformProperty<string>? ScanDns
    {
        set => SetProperty("scan_dns", value);
    }

    /// <summary>
    /// OCID of scan DNS record.
    /// </summary>
    public TerraformProperty<string>? ScanDnsRecordId
    {
        set => SetProperty("scan_dns_record_id", value);
    }

    /// <summary>
    /// OCIDs of scan IPs.
    /// </summary>
    public List<TerraformProperty<string>>? ScanIpIds
    {
        set => SetProperty("scan_ip_ids", value);
    }

    /// <summary>
    /// SCAN listener port - TCP
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcp
    {
        set => SetProperty("scan_listener_port_tcp", value);
    }

    /// <summary>
    /// SCAN listener port - TLS
    /// </summary>
    public TerraformProperty<double>? ScanListenerPortTcpSsl
    {
        set => SetProperty("scan_listener_port_tcp_ssl", value);
    }

    /// <summary>
    /// Shape of VM Cluster.
    /// </summary>
    public TerraformProperty<string>? Shape
    {
        set => SetProperty("shape", value);
    }

    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    public TerraformProperty<bool>? SparseDiskgroupEnabled
    {
        set => SetProperty("sparse_diskgroup_enabled", value);
    }

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    public List<TerraformProperty<string>>? SshPublicKeys
    {
        set => SetProperty("ssh_public_keys", value);
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
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The storage allocation for the disk group, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? StorageSizeGb
    {
        set => SetProperty("storage_size_gb", value);
    }

    /// <summary>
    /// Operating system version of the image.
    /// </summary>
    public TerraformProperty<string>? SystemVersion
    {
        set => SetProperty("system_version", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_oracle_database_cloud_vm_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseCloudVmCluster : TerraformResource
{
    public GoogleOracleDatabaseCloudVmCluster(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("gcp_oracle_zone");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("backup_odb_subnet");
        SetOutput("backup_subnet_cidr");
        SetOutput("cidr");
        SetOutput("cloud_vm_cluster_id");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("exadata_infrastructure");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("network");
        SetOutput("odb_network");
        SetOutput("odb_subnet");
        SetOutput("project");
    }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformProperty<string> BackupOdbSubnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_odb_subnet");
        set => SetProperty("backup_odb_subnet", value);
    }

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    public TerraformProperty<string> BackupSubnetCidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_subnet_cidr");
        set => SetProperty("backup_subnet_cidr", value);
    }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    public TerraformProperty<string> Cidr
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr");
        set => SetProperty("cidr", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => SetProperty("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    public required TerraformProperty<string> ExadataInfrastructure
    {
        get => GetRequiredOutput<TerraformProperty<string>>("exadata_infrastructure");
        set => SetProperty("exadata_infrastructure", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformProperty<string> OdbNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("odb_network");
        set => SetProperty("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformProperty<string> OdbSubnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("odb_subnet");
        set => SetProperty("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseCloudVmClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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

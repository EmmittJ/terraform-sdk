using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// OCI Cluster name.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "cluster_name");

    /// <summary>
    /// Compartment ID of cluster.
    /// </summary>
    [TerraformPropertyName("compartment_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompartmentId => new TerraformReferenceProperty<TerraformProperty<string>>("", "compartment_id");

    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformPropertyName("cpu_core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CpuCoreCount { get; set; }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    [TerraformPropertyName("data_storage_size_tb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeTb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "data_storage_size_tb");

    /// <summary>
    /// Local storage per VM
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "db_node_storage_size_gb");

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    [TerraformPropertyName("db_server_ocids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> DbServerOcids { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "db_server_ocids");

    /// <summary>
    /// The type of redundancy. 
    ///  Possible values:
    ///  DISK_REDUNDANCY_UNSPECIFIED
    /// HIGH
    /// NORMAL
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DiskRedundancy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "disk_redundancy");

    /// <summary>
    /// DNS listener IP.
    /// </summary>
    [TerraformPropertyName("dns_listener_ip")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsListenerIp => new TerraformReferenceProperty<TerraformProperty<string>>("", "dns_listener_ip");

    /// <summary>
    /// Parent DNS domain where SCAN DNS and hosts names are qualified.
    /// ex: ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    [TerraformPropertyName("domain")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>("", "domain");

    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    [TerraformPropertyName("gi_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GiVersion { get; set; }

    /// <summary>
    /// host name without domain.
    /// format: &amp;quot;-&amp;quot; with some suffix.
    /// ex: sp2-yi0xq where &amp;quot;sp2&amp;quot; is the hostname_prefix.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>("", "hostname");

    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    [TerraformPropertyName("hostname_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostnamePrefix { get; set; }

    /// <summary>
    /// License type of VM Cluster. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformPropertyName("license_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseType { get; set; }

    /// <summary>
    /// Use local backup.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalBackupEnabled { get; set; }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    [TerraformPropertyName("memory_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MemorySizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_size_gb");

    /// <summary>
    /// Number of database servers.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "node_count");

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "oci_url");

    /// <summary>
    /// Oracle Cloud Infrastructure ID of VM Cluster.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>("", "ocid");

    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    [TerraformPropertyName("ocpu_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> OcpuCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "ocpu_count");

    /// <summary>
    /// SCAN DNS name.
    /// ex: sp2-yi0xq-scan.ocispdelegated.ocisp10jvnet.oraclevcn.com
    /// </summary>
    [TerraformPropertyName("scan_dns")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDns => new TerraformReferenceProperty<TerraformProperty<string>>("", "scan_dns");

    /// <summary>
    /// OCID of scan DNS record.
    /// </summary>
    [TerraformPropertyName("scan_dns_record_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScanDnsRecordId => new TerraformReferenceProperty<TerraformProperty<string>>("", "scan_dns_record_id");

    /// <summary>
    /// OCIDs of scan IPs.
    /// </summary>
    [TerraformPropertyName("scan_ip_ids")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ScanIpIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "scan_ip_ids");

    /// <summary>
    /// SCAN listener port - TCP
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTcp => new TerraformReferenceProperty<TerraformProperty<double>>("", "scan_listener_port_tcp");

    /// <summary>
    /// SCAN listener port - TLS
    /// </summary>
    [TerraformPropertyName("scan_listener_port_tcp_ssl")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScanListenerPortTcpSsl => new TerraformReferenceProperty<TerraformProperty<double>>("", "scan_listener_port_tcp_ssl");

    /// <summary>
    /// Shape of VM Cluster.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>("", "shape");

    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> SparseDiskgroupEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "sparse_diskgroup_enabled");

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    [TerraformPropertyName("ssh_public_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SshPublicKeys { get; set; }

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
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The storage allocation for the disk group, in gigabytes (GB).
    /// </summary>
    [TerraformPropertyName("storage_size_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> StorageSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "storage_size_gb");

    /// <summary>
    /// Operating system version of the image.
    /// </summary>
    [TerraformPropertyName("system_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SystemVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "system_version");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_oracle_database_cloud_vm_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseCloudVmCluster : TerraformResource
{
    public GoogleOracleDatabaseCloudVmCluster(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("backup_odb_subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BackupOdbSubnet { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backup_odb_subnet");

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cidr { get; set; }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformPropertyName("cloud_vm_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudVmClusterId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    [TerraformPropertyName("exadata_infrastructure")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExadataInfrastructure { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OdbNetwork { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_network");

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("odb_subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OdbSubnet { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "odb_subnet");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>>? Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseCloudVmClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("gcp_oracle_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GcpOracleZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcp_oracle_zone");

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}

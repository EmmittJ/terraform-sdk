using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOracleDatabaseCloudVmClusterPropertiesBlock() : TerraformBlock("properties")
{
    /// <summary>
    /// OCI Cluster name.
    /// </summary>
    [TerraformProperty("cluster_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterName { get; set; }


    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformProperty("cpu_core_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CpuCoreCount { get; set; }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    [TerraformProperty("data_storage_size_tb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DataStorageSizeTb { get; set; }

    /// <summary>
    /// Local storage per VM
    /// </summary>
    [TerraformProperty("db_node_storage_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DbNodeStorageSizeGb { get; set; }

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    [TerraformProperty("db_server_ocids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> DbServerOcids { get; set; }

    /// <summary>
    /// The type of redundancy. 
    ///  Possible values:
    ///  DISK_REDUNDANCY_UNSPECIFIED
    /// HIGH
    /// NORMAL
    /// </summary>
    [TerraformProperty("disk_redundancy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DiskRedundancy { get; set; }



    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    [TerraformProperty("gi_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GiVersion { get; set; }


    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    [TerraformProperty("hostname_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostnamePrefix { get; set; }

    /// <summary>
    /// License type of VM Cluster. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformProperty("license_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// Use local backup.
    /// </summary>
    [TerraformProperty("local_backup_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalBackupEnabled { get; set; }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    [TerraformProperty("memory_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MemorySizeGb { get; set; }

    /// <summary>
    /// Number of database servers.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> NodeCount { get; set; }



    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    [TerraformProperty("ocpu_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> OcpuCount { get; set; }







    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    [TerraformProperty("sparse_diskgroup_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> SparseDiskgroupEnabled { get; set; }

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    [TerraformProperty("ssh_public_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SshPublicKeys { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOracleDatabaseCloudVmClusterTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_oracle_database_cloud_vm_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOracleDatabaseCloudVmCluster : TerraformResource
{
    public GoogleOracleDatabaseCloudVmCluster(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
    }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformProperty("backup_odb_subnet")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BackupOdbSubnet { get; set; }

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    [TerraformProperty("backup_subnet_cidr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    [TerraformProperty("cidr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cidr { get; set; }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformProperty("cloud_vm_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudVmClusterId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    [TerraformProperty("exadata_infrastructure")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExadataInfrastructure { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformProperty("odb_network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OdbNetwork { get; set; }

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformProperty("odb_subnet")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OdbSubnet { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformProperty("properties")]
    public TerraformList<GoogleOracleDatabaseCloudVmClusterPropertiesBlock> Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleOracleDatabaseCloudVmClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    [TerraformProperty("gcp_oracle_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GcpOracleZone { get; }

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterPropertiesBlock
{
    /// <summary>
    /// OCI Cluster name.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ClusterName { get; set; } = default!;


    /// <summary>
    /// Number of enabled CPU cores.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCoreCount is required")]
    [TerraformPropertyName("cpu_core_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CpuCoreCount { get; set; }

    /// <summary>
    /// The data disk group size to be allocated in TBs.
    /// </summary>
    [TerraformPropertyName("data_storage_size_tb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DataStorageSizeTb { get; set; } = default!;

    /// <summary>
    /// Local storage per VM
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DbNodeStorageSizeGb { get; set; } = default!;

    /// <summary>
    /// OCID of database servers.
    /// </summary>
    [TerraformPropertyName("db_server_ocids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> DbServerOcids { get; set; } = default!;

    /// <summary>
    /// The type of redundancy. 
    ///  Possible values:
    ///  DISK_REDUNDANCY_UNSPECIFIED
    /// HIGH
    /// NORMAL
    /// </summary>
    [TerraformPropertyName("disk_redundancy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DiskRedundancy { get; set; } = default!;



    /// <summary>
    /// Grid Infrastructure Version.
    /// </summary>
    [TerraformPropertyName("gi_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GiVersion { get; set; }


    /// <summary>
    /// Prefix for VM cluster host names.
    /// </summary>
    [TerraformPropertyName("hostname_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostnamePrefix { get; set; }

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
    public required TerraformValue<string> LicenseType { get; set; }

    /// <summary>
    /// Use local backup.
    /// </summary>
    [TerraformPropertyName("local_backup_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalBackupEnabled { get; set; }

    /// <summary>
    /// Memory allocated in GBs.
    /// </summary>
    [TerraformPropertyName("memory_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MemorySizeGb { get; set; } = default!;

    /// <summary>
    /// Number of database servers.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> NodeCount { get; set; } = default!;



    /// <summary>
    /// OCPU count per VM. Minimum is 0.1.
    /// </summary>
    [TerraformPropertyName("ocpu_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> OcpuCount { get; set; } = default!;







    /// <summary>
    /// Use exadata sparse snapshots.
    /// </summary>
    [TerraformPropertyName("sparse_diskgroup_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> SparseDiskgroupEnabled { get; set; } = default!;

    /// <summary>
    /// SSH public keys to be stored with cluster.
    /// </summary>
    [TerraformPropertyName("ssh_public_keys")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SshPublicKeys { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BackupOdbSubnet { get; set; } = default!;

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BackupSubnetCidr { get; set; }

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cidr { get; set; }

    /// <summary>
    /// The ID of the VM Cluster to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    [TerraformPropertyName("cloud_vm_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudVmClusterId { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExadataInfrastructure is required")]
    [TerraformPropertyName("exadata_infrastructure")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExadataInfrastructure { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OdbNetwork { get; set; } = default!;

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("odb_subnet")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OdbSubnet { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseCloudVmClusterPropertiesBlock>>? Properties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseCloudVmClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("gcp_oracle_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GcpOracleZone => new TerraformReference(this, "gcp_oracle_zone");

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}

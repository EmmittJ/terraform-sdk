using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_cloud_vm_cluster.
/// </summary>
public class GoogleOracleDatabaseCloudVmClusterDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseCloudVmClusterDataSource(string name) : base("google_oracle_database_cloud_vm_cluster", name)
    {
    }

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
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbNode&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The name of the backup OdbSubnet associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("backup_odb_subnet")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupOdbSubnet => new TerraformReference(this, "backup_odb_subnet");

    /// <summary>
    /// CIDR range of the backup subnet.
    /// </summary>
    [TerraformPropertyName("backup_subnet_cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackupSubnetCidr => new TerraformReference(this, "backup_subnet_cidr");

    /// <summary>
    /// Network settings. CIDR to use for cluster IP allocation.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cidr => new TerraformReference(this, "cidr");

    /// <summary>
    /// The date and time that the VM cluster was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster. Deleting this cluster via terraform destroy or terraform apply will only succeed if this field is false in the Terraform state.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The name of the Exadata Infrastructure resource on which VM cluster
    /// resource is created, in the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastuctures/{cloud_extradata_infrastructure}
    /// </summary>
    [TerraformPropertyName("exadata_infrastructure")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExadataInfrastructure => new TerraformReference(this, "exadata_infrastructure");

    /// <summary>
    /// GCP location where Oracle Exadata is hosted. It is same as GCP Oracle zone
    /// of Exadata infrastructure.
    /// </summary>
    [TerraformPropertyName("gcp_oracle_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GcpOracleZone => new TerraformReference(this, "gcp_oracle_zone");

    /// <summary>
    /// Labels or tags associated with the VM Cluster. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// Identifier. The name of the VM Cluster resource with the format:
    /// projects/{project}/locations/{region}/cloudVmClusters/{cloud_vm_cluster}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The name of the VPC network.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

    /// <summary>
    /// The name of the OdbNetwork associated with the VM Cluster.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OdbNetwork => new TerraformReference(this, "odb_network");

    /// <summary>
    /// The name of the OdbSubnet associated with the VM Cluster for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("odb_subnet")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OdbSubnet => new TerraformReference(this, "odb_subnet");

    /// <summary>
    /// Various properties and settings associated with Exadata VM cluster.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Properties => new TerraformReference(this, "properties");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_server.
/// </summary>
public class AwsOdbDbServerDataSource : TerraformDataSource
{
    public AwsOdbDbServerDataSource(string name) : base("aws_odb_db_server", name)
    {
    }

    /// <summary>
    /// The identifier of the database server to retrieve information about.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The identifier of the the database server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The list of unique identifiers for the Autonomous VMs associated with this database server.
    /// </summary>
    [TerraformPropertyName("autonomous_virtual_machine_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AutonomousVirtualMachineIds => new TerraformReference(this, "autonomous_virtual_machine_ids");

    /// <summary>
    /// The OCID of the autonomous VM clusters that are associated with the database server.
    /// </summary>
    [TerraformPropertyName("autonomous_vm_cluster_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AutonomousVmClusterIds => new TerraformReference(this, "autonomous_vm_cluster_ids");

    /// <summary>
    ///  The compute model of the database server.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ComputeModel => new TerraformReference(this, "compute_model");

    /// <summary>
    /// The number of CPU cores enabled on the database server.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCoreCount => new TerraformReference(this, "cpu_core_count");

    /// <summary>
    /// The date and time when the database server was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The allocated local node storage in GBs on the database server.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DbNodeStorageSizeInGbs => new TerraformReference(this, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and
    /// system updates take place during the maintenance window.
    /// </summary>
    [TerraformPropertyName("db_server_patching_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DbServerPatchingDetails => new TerraformReference(this, "db_server_patching_details");

    /// <summary>
    /// The display name of the database server.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The exadata infrastructure ID of the database server.
    /// </summary>
    [TerraformPropertyName("exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExadataInfrastructureId => new TerraformReference(this, "exadata_infrastructure_id");

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxCpuCount => new TerraformReference(this, "max_cpu_count");

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxDbNodeStorageInGbs => new TerraformReference(this, "max_db_node_storage_in_gbs");

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxMemoryInGbs => new TerraformReference(this, "max_memory_in_gbs");

    /// <summary>
    /// The allocated memory in GBs on the database server.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MemorySizeInGbs => new TerraformReference(this, "memory_size_in_gbs");

    /// <summary>
    /// The name of the OCI resource anchor.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OciResourceAnchorName => new TerraformReference(this, "oci_resource_anchor_name");

    /// <summary>
    /// The OCID of the database server to retrieve information about.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ocid => new TerraformReference(this, "ocid");

    /// <summary>
    /// The shape of the database server. The shape determines the amount of CPU, storage, and memory resources available.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Shape => new TerraformReference(this, "shape");

    /// <summary>
    /// The status of the database server.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// Additional information about the current status of the database server.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The OCID of the VM clusters that are associated with the database server.
    /// </summary>
    [TerraformPropertyName("vm_cluster_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> VmClusterIds => new TerraformReference(this, "vm_cluster_ids");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_server.
/// </summary>
public partial class AwsOdbDbServerDataSource : TerraformDataSource
{
    public AwsOdbDbServerDataSource(string name) : base("aws_odb_db_server", name)
    {
    }

    /// <summary>
    /// The identifier of the database server to retrieve information about.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformProperty("cloud_exadata_infrastructure_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The identifier of the the database server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The list of unique identifiers for the Autonomous VMs associated with this database server.
    /// </summary>
    [TerraformProperty("autonomous_virtual_machine_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AutonomousVirtualMachineIds { get; }

    /// <summary>
    /// The OCID of the autonomous VM clusters that are associated with the database server.
    /// </summary>
    [TerraformProperty("autonomous_vm_cluster_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AutonomousVmClusterIds { get; }

    /// <summary>
    ///  The compute model of the database server.
    /// </summary>
    [TerraformProperty("compute_model")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ComputeModel { get; }

    /// <summary>
    /// The number of CPU cores enabled on the database server.
    /// </summary>
    [TerraformProperty("cpu_core_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CpuCoreCount { get; }

    /// <summary>
    /// The date and time when the database server was created.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The allocated local node storage in GBs on the database server.
    /// </summary>
    [TerraformProperty("db_node_storage_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DbNodeStorageSizeInGbs { get; }

    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and
    /// system updates take place during the maintenance window.
    /// </summary>
    [TerraformProperty("db_server_patching_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DbServerPatchingDetails { get; }

    /// <summary>
    /// The display name of the database server.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The exadata infrastructure ID of the database server.
    /// </summary>
    [TerraformProperty("exadata_infrastructure_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExadataInfrastructureId { get; }

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    [TerraformProperty("max_cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxCpuCount { get; }

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    [TerraformProperty("max_db_node_storage_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxDbNodeStorageInGbs { get; }

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    [TerraformProperty("max_memory_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxMemoryInGbs { get; }

    /// <summary>
    /// The allocated memory in GBs on the database server.
    /// </summary>
    [TerraformProperty("memory_size_in_gbs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MemorySizeInGbs { get; }

    /// <summary>
    /// The name of the OCI resource anchor.
    /// </summary>
    [TerraformProperty("oci_resource_anchor_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OciResourceAnchorName { get; }

    /// <summary>
    /// The OCID of the database server to retrieve information about.
    /// </summary>
    [TerraformProperty("ocid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ocid { get; }

    /// <summary>
    /// The shape of the database server. The shape determines the amount of CPU, storage, and memory resources available.
    /// </summary>
    [TerraformProperty("shape")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Shape { get; }

    /// <summary>
    /// The status of the database server.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// Additional information about the current status of the database server.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The OCID of the VM clusters that are associated with the database server.
    /// </summary>
    [TerraformProperty("vm_cluster_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VmClusterIds { get; }

}

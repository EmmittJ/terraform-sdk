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
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// The identifier of the the database server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The list of unique identifiers for the Autonomous VMs associated with this database server.
    /// </summary>
    [TerraformPropertyName("autonomous_virtual_machine_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AutonomousVirtualMachineIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "autonomous_virtual_machine_ids");

    /// <summary>
    /// The OCID of the autonomous VM clusters that are associated with the database server.
    /// </summary>
    [TerraformPropertyName("autonomous_vm_cluster_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AutonomousVmClusterIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "autonomous_vm_cluster_ids");

    /// <summary>
    ///  The compute model of the database server.
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ComputeModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "compute_model");

    /// <summary>
    /// The number of CPU cores enabled on the database server.
    /// </summary>
    [TerraformPropertyName("cpu_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "cpu_core_count");

    /// <summary>
    /// The date and time when the database server was created.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The allocated local node storage in GBs on the database server.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "db_node_storage_size_in_gbs");

    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and
    /// system updates take place during the maintenance window.
    /// </summary>
    [TerraformPropertyName("db_server_patching_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DbServerPatchingDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "db_server_patching_details");

    /// <summary>
    /// The display name of the database server.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The exadata infrastructure ID of the database server.
    /// </summary>
    [TerraformPropertyName("exadata_infrastructure_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExadataInfrastructureId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "exadata_infrastructure_id");

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCpuCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_cpu_count");

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDbNodeStorageInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_db_node_storage_in_gbs");

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    [TerraformPropertyName("max_memory_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxMemoryInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_memory_in_gbs");

    /// <summary>
    /// The allocated memory in GBs on the database server.
    /// </summary>
    [TerraformPropertyName("memory_size_in_gbs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeInGbs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "memory_size_in_gbs");

    /// <summary>
    /// The name of the OCI resource anchor.
    /// </summary>
    [TerraformPropertyName("oci_resource_anchor_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciResourceAnchorName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_resource_anchor_name");

    /// <summary>
    /// The OCID of the database server to retrieve information about.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ocid");

    /// <summary>
    /// The shape of the database server. The shape determines the amount of CPU, storage, and memory resources available.
    /// </summary>
    [TerraformPropertyName("shape")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Shape => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shape");

    /// <summary>
    /// The status of the database server.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// Additional information about the current status of the database server.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The OCID of the VM clusters that are associated with the database server.
    /// </summary>
    [TerraformPropertyName("vm_cluster_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VmClusterIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "vm_cluster_ids");

}

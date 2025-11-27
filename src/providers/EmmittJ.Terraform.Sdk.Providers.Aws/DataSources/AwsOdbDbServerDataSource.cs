using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_db_server Terraform data source.
/// Retrieves information about a aws_odb_db_server.
/// </summary>
public partial class AwsOdbDbServerDataSource(string name) : TerraformDataSource("aws_odb_db_server", name)
{
    /// <summary>
    /// The identifier of the database server to retrieve information about.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The identifier of the the database server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The list of unique identifiers for the Autonomous VMs associated with this database server.
    /// </summary>
    public TerraformList<string> AutonomousVirtualMachineIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "autonomous_virtual_machine_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The OCID of the autonomous VM clusters that are associated with the database server.
    /// </summary>
    public TerraformList<string> AutonomousVmClusterIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "autonomous_vm_cluster_ids").ResolveNodes(ctx));
    }

    /// <summary>
    ///  The compute model of the database server.
    /// </summary>
    public TerraformValue<string> ComputeModel
    {
        get => new TerraformReference<string>(this, "compute_model");
    }

    /// <summary>
    /// The number of CPU cores enabled on the database server.
    /// </summary>
    public TerraformValue<double> CpuCoreCount
    {
        get => new TerraformReference<double>(this, "cpu_core_count");
    }

    /// <summary>
    /// The date and time when the database server was created.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The allocated local node storage in GBs on the database server.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeInGbs
    {
        get => new TerraformReference<double>(this, "db_node_storage_size_in_gbs");
    }

    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and
    /// system updates take place during the maintenance window.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbServerPatchingDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "db_server_patching_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display name of the database server.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The exadata infrastructure ID of the database server.
    /// </summary>
    public TerraformValue<string> ExadataInfrastructureId
    {
        get => new TerraformReference<string>(this, "exadata_infrastructure_id");
    }

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
    {
        get => new TerraformReference<double>(this, "max_cpu_count");
    }

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageInGbs
    {
        get => new TerraformReference<double>(this, "max_db_node_storage_in_gbs");
    }

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    public TerraformValue<double> MaxMemoryInGbs
    {
        get => new TerraformReference<double>(this, "max_memory_in_gbs");
    }

    /// <summary>
    /// The allocated memory in GBs on the database server.
    /// </summary>
    public TerraformValue<double> MemorySizeInGbs
    {
        get => new TerraformReference<double>(this, "memory_size_in_gbs");
    }

    /// <summary>
    /// The name of the OCI resource anchor.
    /// </summary>
    public TerraformValue<string> OciResourceAnchorName
    {
        get => new TerraformReference<string>(this, "oci_resource_anchor_name");
    }

    /// <summary>
    /// The OCID of the database server to retrieve information about.
    /// </summary>
    public TerraformValue<string> Ocid
    {
        get => new TerraformReference<string>(this, "ocid");
    }

    /// <summary>
    /// The shape of the database server. The shape determines the amount of CPU, storage, and memory resources available.
    /// </summary>
    public TerraformValue<string> Shape
    {
        get => new TerraformReference<string>(this, "shape");
    }

    /// <summary>
    /// The status of the database server.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Additional information about the current status of the database server.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

    /// <summary>
    /// The OCID of the VM clusters that are associated with the database server.
    /// </summary>
    public TerraformList<string> VmClusterIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "vm_cluster_ids").ResolveNodes(ctx));
    }

}

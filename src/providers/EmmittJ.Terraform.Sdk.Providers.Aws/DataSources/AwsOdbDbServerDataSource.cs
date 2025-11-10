using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_server.
/// </summary>
public class AwsOdbDbServerDataSource : TerraformDataSource
{
    public AwsOdbDbServerDataSource(string name) : base("aws_odb_db_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("autonomous_virtual_machine_ids");
        SetOutput("autonomous_vm_cluster_ids");
        SetOutput("compute_model");
        SetOutput("cpu_core_count");
        SetOutput("created_at");
        SetOutput("db_node_storage_size_in_gbs");
        SetOutput("db_server_patching_details");
        SetOutput("display_name");
        SetOutput("exadata_infrastructure_id");
        SetOutput("max_cpu_count");
        SetOutput("max_db_node_storage_in_gbs");
        SetOutput("max_memory_in_gbs");
        SetOutput("memory_size_in_gbs");
        SetOutput("oci_resource_anchor_name");
        SetOutput("ocid");
        SetOutput("shape");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("vm_cluster_ids");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The identifier of the database server to retrieve information about.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// The identifier of the the database server.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The list of unique identifiers for the Autonomous VMs associated with this database server.
    /// </summary>
    public TerraformExpression AutonomousVirtualMachineIds => this["autonomous_virtual_machine_ids"];

    /// <summary>
    /// The OCID of the autonomous VM clusters that are associated with the database server.
    /// </summary>
    public TerraformExpression AutonomousVmClusterIds => this["autonomous_vm_cluster_ids"];

    /// <summary>
    ///  The compute model of the database server.
    /// </summary>
    public TerraformExpression ComputeModel => this["compute_model"];

    /// <summary>
    /// The number of CPU cores enabled on the database server.
    /// </summary>
    public TerraformExpression CpuCoreCount => this["cpu_core_count"];

    /// <summary>
    /// The date and time when the database server was created.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The allocated local node storage in GBs on the database server.
    /// </summary>
    public TerraformExpression DbNodeStorageSizeInGbs => this["db_node_storage_size_in_gbs"];

    /// <summary>
    /// The scheduling details for the quarterly maintenance window. Patching and
    /// system updates take place during the maintenance window.
    /// </summary>
    public TerraformExpression DbServerPatchingDetails => this["db_server_patching_details"];

    /// <summary>
    /// The display name of the database server.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The exadata infrastructure ID of the database server.
    /// </summary>
    public TerraformExpression ExadataInfrastructureId => this["exadata_infrastructure_id"];

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    public TerraformExpression MaxCpuCount => this["max_cpu_count"];

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    public TerraformExpression MaxDbNodeStorageInGbs => this["max_db_node_storage_in_gbs"];

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    public TerraformExpression MaxMemoryInGbs => this["max_memory_in_gbs"];

    /// <summary>
    /// The allocated memory in GBs on the database server.
    /// </summary>
    public TerraformExpression MemorySizeInGbs => this["memory_size_in_gbs"];

    /// <summary>
    /// The name of the OCI resource anchor.
    /// </summary>
    public TerraformExpression OciResourceAnchorName => this["oci_resource_anchor_name"];

    /// <summary>
    /// The OCID of the database server to retrieve information about.
    /// </summary>
    public TerraformExpression Ocid => this["ocid"];

    /// <summary>
    /// The shape of the database server. The shape determines the amount of CPU, storage, and memory resources available.
    /// </summary>
    public TerraformExpression Shape => this["shape"];

    /// <summary>
    /// The status of the database server.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Additional information about the current status of the database server.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

    /// <summary>
    /// The OCID of the VM clusters that are associated with the database server.
    /// </summary>
    public TerraformExpression VmClusterIds => this["vm_cluster_ids"];

}

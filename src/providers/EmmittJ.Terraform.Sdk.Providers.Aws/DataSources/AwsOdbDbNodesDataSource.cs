using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_db_nodes Terraform data source.
/// Retrieves information about a aws_odb_db_nodes.
/// </summary>
public partial class AwsOdbDbNodesDataSource(string name) : TerraformDataSource("aws_odb_db_nodes", name)
{
    /// <summary>
    /// Id of the cloud VM cluster. The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformValue<string> CloudVmClusterId
    {
        get => GetArgument<TerraformValue<string>>("cloud_vm_cluster_id");
        set => SetArgument("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The list of DB nodes along with their properties.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbNodes
        => AsReference("db_nodes");

}

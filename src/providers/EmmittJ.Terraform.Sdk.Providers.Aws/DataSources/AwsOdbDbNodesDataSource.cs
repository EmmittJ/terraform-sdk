using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_nodes.
/// </summary>
public class AwsOdbDbNodesDataSource : TerraformDataSource
{
    public AwsOdbDbNodesDataSource(string name) : base("aws_odb_db_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("db_nodes");
        SetOutput("cloud_vm_cluster_id");
        SetOutput("region");
    }

    /// <summary>
    /// Id of the cloud VM cluster. The unique identifier of the VM cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformProperty<string> CloudVmClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => SetProperty("cloud_vm_cluster_id", value);
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
    /// The list of DB nodes along with their properties.
    /// </summary>
    public TerraformExpression DbNodes => this["db_nodes"];

}

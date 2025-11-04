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
        this.DeclareOutput("db_nodes");
    }

    /// <summary>
    /// Id of the cloud VM cluster. The unique identifier of the VM cluster.
    /// </summary>
    public string? CloudVmClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_vm_cluster_id")?.Value;
        set => this.WithProperty("cloud_vm_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of DB nodes along with their properties.
    /// </summary>
    public TerraformExpression DbNodes => this["db_nodes"];

}

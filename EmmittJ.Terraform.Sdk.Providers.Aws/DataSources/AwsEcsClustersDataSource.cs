using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_clusters.
/// </summary>
public class AwsEcsClustersDataSource : TerraformDataSource
{
    public AwsEcsClustersDataSource(string name) : base("aws_ecs_clusters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_arns");
    }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    public TerraformExpression ClusterArns => this["cluster_arns"];

}

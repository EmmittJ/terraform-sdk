using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_clusters.
/// </summary>
public class AwsRdsClustersDataSource : TerraformDataSource
{
    public AwsRdsClustersDataSource(string name) : base("aws_rds_clusters", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cluster_arns");
        this.DeclareOutput("cluster_identifiers");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    public TerraformExpression ClusterArns => this["cluster_arns"];

    /// <summary>
    /// The cluster_identifiers attribute.
    /// </summary>
    public TerraformExpression ClusterIdentifiers => this["cluster_identifiers"];

}

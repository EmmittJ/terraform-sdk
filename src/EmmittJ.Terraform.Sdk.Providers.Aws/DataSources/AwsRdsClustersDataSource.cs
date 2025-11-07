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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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

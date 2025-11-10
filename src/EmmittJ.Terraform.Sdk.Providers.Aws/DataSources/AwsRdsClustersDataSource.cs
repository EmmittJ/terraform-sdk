using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRdsClustersDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRdsClustersDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsRdsClustersDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
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

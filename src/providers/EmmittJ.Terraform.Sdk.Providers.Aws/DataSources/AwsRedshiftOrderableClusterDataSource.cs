using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_orderable_cluster.
/// </summary>
public class AwsRedshiftOrderableClusterDataSource : TerraformDataSource
{
    public AwsRedshiftOrderableClusterDataSource(string name) : base("aws_redshift_orderable_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputvailability_zones");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_type");
        set => this.WithProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterVersion
    {
        get => GetProperty<TerraformProperty<string>>("cluster_version");
        set => this.WithProperty("cluster_version", value);
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
    /// The node_type attribute.
    /// </summary>
    public TerraformProperty<string>? NodeType
    {
        get => GetProperty<TerraformProperty<string>>("node_type");
        set => this.WithProperty("node_type", value);
    }

    /// <summary>
    /// The preferred_node_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredNodeTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_node_types");
        set => this.WithProperty("preferred_node_types", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

}

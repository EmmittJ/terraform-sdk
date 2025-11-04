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
        this.DeclareOutput("availability_zones");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public string? ClusterType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_type")?.Value;
        set => this.WithProperty("cluster_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public string? ClusterVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_version")?.Value;
        set => this.WithProperty("cluster_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The node_type attribute.
    /// </summary>
    public string? NodeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_type")?.Value;
        set => this.WithProperty("node_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preferred_node_types attribute.
    /// </summary>
    public List<string>? PreferredNodeTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_node_types")?.Value;
        set => this.WithProperty("preferred_node_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

}

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
        SetOutput("availability_zones");
        SetOutput("cluster_type");
        SetOutput("cluster_version");
        SetOutput("id");
        SetOutput("node_type");
        SetOutput("preferred_node_types");
        SetOutput("region");
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformProperty<string> ClusterType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_type");
        set => SetProperty("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformProperty<string> ClusterVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_version");
        set => SetProperty("cluster_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformProperty<string> NodeType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("node_type");
        set => SetProperty("node_type", value);
    }

    /// <summary>
    /// The preferred_node_types attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredNodeTypes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_node_types");
        set => SetProperty("preferred_node_types", value);
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
    /// The availability_zones attribute.
    /// </summary>
    public TerraformExpression AvailabilityZones => this["availability_zones"];

}

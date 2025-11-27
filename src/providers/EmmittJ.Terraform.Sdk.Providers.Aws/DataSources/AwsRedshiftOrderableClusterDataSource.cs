using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_orderable_cluster Terraform data source.
/// Retrieves information about a aws_redshift_orderable_cluster.
/// </summary>
public partial class AwsRedshiftOrderableClusterDataSource(string name) : TerraformDataSource("aws_redshift_orderable_cluster", name)
{
    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    public TerraformValue<string> ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
        set => SetArgument("cluster_type", value);
    }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    public TerraformValue<string> ClusterVersion
    {
        get => new TerraformReference<string>(this, "cluster_version");
        set => SetArgument("cluster_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    public TerraformValue<string> NodeType
    {
        get => new TerraformReference<string>(this, "node_type");
        set => SetArgument("node_type", value);
    }

    /// <summary>
    /// The preferred_node_types attribute.
    /// </summary>
    public TerraformList<string>? PreferredNodeTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_node_types").ResolveNodes(ctx));
        set => SetArgument("preferred_node_types", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "availability_zones").ResolveNodes(ctx));
    }

}

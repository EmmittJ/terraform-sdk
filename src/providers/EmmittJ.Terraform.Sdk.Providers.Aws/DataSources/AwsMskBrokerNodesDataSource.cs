using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_msk_broker_nodes Terraform data source.
/// Retrieves information about a aws_msk_broker_nodes.
/// </summary>
public partial class AwsMskBrokerNodesDataSource(string name) : TerraformDataSource("aws_msk_broker_nodes", name)
{
    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The node_info_list attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeInfoList
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_info_list").ResolveNodes(ctx));
    }

}

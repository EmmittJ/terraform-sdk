using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_broker_nodes.
/// </summary>
public class AwsMskBrokerNodesDataSource : TerraformDataSource
{
    public AwsMskBrokerNodesDataSource(string name) : base("aws_msk_broker_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("node_info_list");
        SetOutput("cluster_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformProperty<string> ClusterArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_arn");
        set => SetProperty("cluster_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The node_info_list attribute.
    /// </summary>
    public TerraformExpression NodeInfoList => this["node_info_list"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_broker_nodes.
/// </summary>
public partial class AwsMskBrokerNodesDataSource : TerraformDataSource
{
    public AwsMskBrokerNodesDataSource(string name) : base("aws_msk_broker_nodes", name)
    {
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    [TerraformProperty("cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The node_info_list attribute.
    /// </summary>
    [TerraformProperty("node_info_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NodeInfoList { get; }

}

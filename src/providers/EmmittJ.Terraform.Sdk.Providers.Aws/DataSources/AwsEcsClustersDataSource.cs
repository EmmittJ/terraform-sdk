using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_clusters.
/// </summary>
public partial class AwsEcsClustersDataSource : TerraformDataSource
{
    public AwsEcsClustersDataSource(string name) : base("aws_ecs_clusters", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    [TerraformProperty("cluster_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ClusterArns { get; }

}

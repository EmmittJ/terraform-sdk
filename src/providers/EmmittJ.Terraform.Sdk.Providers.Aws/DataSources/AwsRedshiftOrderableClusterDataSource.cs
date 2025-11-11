using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_orderable_cluster.
/// </summary>
public partial class AwsRedshiftOrderableClusterDataSource : TerraformDataSource
{
    public AwsRedshiftOrderableClusterDataSource(string name) : base("aws_redshift_orderable_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterType { get; set; }

    /// <summary>
    /// The cluster_version attribute.
    /// </summary>
    [TerraformProperty("cluster_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ClusterVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [TerraformProperty("node_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NodeType { get; set; }

    /// <summary>
    /// The preferred_node_types attribute.
    /// </summary>
    [TerraformProperty("preferred_node_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? PreferredNodeTypes { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AvailabilityZones { get; }

}

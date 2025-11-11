using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsRdsClustersDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_rds_clusters.
/// </summary>
public partial class AwsRdsClustersDataSource : TerraformDataSource
{
    public AwsRdsClustersDataSource(string name) : base("aws_rds_clusters", name)
    {
    }

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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsRdsClustersDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    [TerraformProperty("cluster_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ClusterArns { get; }

    /// <summary>
    /// The cluster_identifiers attribute.
    /// </summary>
    [TerraformProperty("cluster_identifiers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ClusterIdentifiers { get; }

}

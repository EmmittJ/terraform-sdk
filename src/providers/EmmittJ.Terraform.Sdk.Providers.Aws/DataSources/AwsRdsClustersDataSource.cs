using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsRdsClustersDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_rds_clusters.
/// </summary>
public class AwsRdsClustersDataSource : TerraformDataSource
{
    public AwsRdsClustersDataSource(string name) : base("aws_rds_clusters", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsRdsClustersDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    [TerraformPropertyName("cluster_arns")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ClusterArns => new TerraformReference(this, "cluster_arns");

    /// <summary>
    /// The cluster_identifiers attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifiers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ClusterIdentifiers => new TerraformReference(this, "cluster_identifiers");

}

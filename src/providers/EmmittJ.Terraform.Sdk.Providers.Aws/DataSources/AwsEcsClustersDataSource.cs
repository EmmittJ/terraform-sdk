using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_clusters.
/// </summary>
public class AwsEcsClustersDataSource : TerraformDataSource
{
    public AwsEcsClustersDataSource(string name) : base("aws_ecs_clusters", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The cluster_arns attribute.
    /// </summary>
    [TerraformPropertyName("cluster_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ClusterArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "cluster_arns");

}

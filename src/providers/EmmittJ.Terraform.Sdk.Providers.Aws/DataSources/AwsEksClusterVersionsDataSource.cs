using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster_versions.
/// </summary>
public partial class AwsEksClusterVersionsDataSource : TerraformDataSource
{
    public AwsEksClusterVersionsDataSource(string name) : base("aws_eks_cluster_versions", name)
    {
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterType { get; set; }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    [TerraformProperty("cluster_versions_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ClusterVersionsOnly { get; set; }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    [TerraformProperty("default_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultOnly { get; set; }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    [TerraformProperty("include_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludeAll { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version_status attribute.
    /// </summary>
    [TerraformProperty("version_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VersionStatus { get; set; }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    [TerraformProperty("cluster_versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ClusterVersions { get; }

}

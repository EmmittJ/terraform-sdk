using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_cluster_versions.
/// </summary>
public class AwsEksClusterVersionsDataSource : TerraformDataSource
{
    public AwsEksClusterVersionsDataSource(string name) : base("aws_eks_cluster_versions", name)
    {
    }

    /// <summary>
    /// The cluster_type attribute.
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterType { get; set; }

    /// <summary>
    /// The cluster_versions_only attribute.
    /// </summary>
    [TerraformPropertyName("cluster_versions_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? ClusterVersionsOnly { get; set; }

    /// <summary>
    /// The default_only attribute.
    /// </summary>
    [TerraformPropertyName("default_only")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultOnly { get; set; }

    /// <summary>
    /// The include_all attribute.
    /// </summary>
    [TerraformPropertyName("include_all")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeAll { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The version_status attribute.
    /// </summary>
    [TerraformPropertyName("version_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionStatus { get; set; }

    /// <summary>
    /// The cluster_versions attribute.
    /// </summary>
    [TerraformPropertyName("cluster_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterVersions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_versions");

}

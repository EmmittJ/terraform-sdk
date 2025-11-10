using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudhsm_v2_cluster.
/// </summary>
public class AwsCloudhsmV2ClusterDataSource : TerraformDataSource
{
    public AwsCloudhsmV2ClusterDataSource(string name) : base("aws_cloudhsm_v2_cluster", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    [TerraformPropertyName("cluster_state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterState { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_state");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The cluster_certificates attribute.
    /// </summary>
    [TerraformPropertyName("cluster_certificates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterCertificates => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_certificates");

    /// <summary>
    /// The security_group_id attribute.
    /// </summary>
    [TerraformPropertyName("security_group_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityGroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_group_id");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}

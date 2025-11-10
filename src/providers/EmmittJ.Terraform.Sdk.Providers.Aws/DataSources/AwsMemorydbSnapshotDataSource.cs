using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_snapshot.
/// </summary>
public class AwsMemorydbSnapshotDataSource : TerraformDataSource
{
    public AwsMemorydbSnapshotDataSource(string name) : base("aws_memorydb_snapshot", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cluster_configuration attribute.
    /// </summary>
    [TerraformPropertyName("cluster_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_configuration");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_name");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Source => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source");

}

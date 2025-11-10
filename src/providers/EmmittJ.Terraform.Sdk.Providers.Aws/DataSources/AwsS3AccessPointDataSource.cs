using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_access_point.
/// </summary>
public class AwsS3AccessPointDataSource : TerraformDataSource
{
    public AwsS3AccessPointDataSource(string name) : base("aws_s3_access_point", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

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
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Bucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket");

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformPropertyName("bucket_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BucketAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_account_id");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformPropertyName("data_source_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_source_id");

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [TerraformPropertyName("data_source_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataSourceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_source_type");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Endpoints => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "endpoints");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformPropertyName("network_origin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkOrigin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_origin");

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    [TerraformPropertyName("public_access_block_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PublicAccessBlockConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "public_access_block_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    [TerraformPropertyName("vpc_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_configuration");

}

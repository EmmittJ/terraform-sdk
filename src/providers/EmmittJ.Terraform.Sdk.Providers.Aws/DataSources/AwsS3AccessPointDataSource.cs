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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Alias => new TerraformReference(this, "alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Bucket => new TerraformReference(this, "bucket");

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformPropertyName("bucket_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BucketAccountId => new TerraformReference(this, "bucket_account_id");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformPropertyName("data_source_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataSourceId => new TerraformReference(this, "data_source_id");

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [TerraformPropertyName("data_source_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataSourceType => new TerraformReference(this, "data_source_type");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Endpoints => new TerraformReference(this, "endpoints");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformPropertyName("network_origin")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkOrigin => new TerraformReference(this, "network_origin");

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    [TerraformPropertyName("public_access_block_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PublicAccessBlockConfiguration => new TerraformReference(this, "public_access_block_configuration");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    [TerraformPropertyName("vpc_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcConfiguration => new TerraformReference(this, "vpc_configuration");

}

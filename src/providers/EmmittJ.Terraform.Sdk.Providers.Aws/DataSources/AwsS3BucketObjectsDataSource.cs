using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket_objects.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AwsS3BucketObjectsDataSource : TerraformDataSource
{
    public AwsS3BucketObjectsDataSource(string name) : base("aws_s3_bucket_objects", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformPropertyName("delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delimiter { get; set; }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    [TerraformPropertyName("encoding_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncodingType { get; set; }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    [TerraformPropertyName("fetch_owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FetchOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_keys attribute.
    /// </summary>
    [TerraformPropertyName("max_keys")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxKeys { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    [TerraformPropertyName("start_after")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StartAfter { get; set; }

    /// <summary>
    /// The common_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("common_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> CommonPrefixes => new TerraformReference(this, "common_prefixes");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [TerraformPropertyName("keys")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Keys => new TerraformReference(this, "keys");

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Owners => new TerraformReference(this, "owners");

}

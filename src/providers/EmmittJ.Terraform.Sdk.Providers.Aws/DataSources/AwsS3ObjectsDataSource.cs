using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_objects.
/// </summary>
public class AwsS3ObjectsDataSource : TerraformDataSource
{
    public AwsS3ObjectsDataSource(string name) : base("aws_s3_objects", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformPropertyName("delimiter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delimiter { get; set; }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    [TerraformPropertyName("encoding_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncodingType { get; set; }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    [TerraformPropertyName("fetch_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FetchOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_keys attribute.
    /// </summary>
    [TerraformPropertyName("max_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxKeys { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [TerraformPropertyName("request_payer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestPayer { get; set; }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    [TerraformPropertyName("start_after")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartAfter { get; set; }

    /// <summary>
    /// The common_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("common_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CommonPrefixes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "common_prefixes");

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [TerraformPropertyName("keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Keys => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "keys");

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformPropertyName("owners")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Owners => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "owners");

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    [TerraformPropertyName("request_charged")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RequestCharged => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "request_charged");

}

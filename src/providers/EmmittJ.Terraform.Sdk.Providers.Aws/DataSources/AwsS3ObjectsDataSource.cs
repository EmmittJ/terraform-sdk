using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_objects.
/// </summary>
public partial class AwsS3ObjectsDataSource : TerraformDataSource
{
    public AwsS3ObjectsDataSource(string name) : base("aws_s3_objects", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    [TerraformProperty("delimiter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delimiter { get; set; }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    [TerraformProperty("encoding_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncodingType { get; set; }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    [TerraformProperty("fetch_owner")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FetchOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_keys attribute.
    /// </summary>
    [TerraformProperty("max_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxKeys { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [TerraformProperty("request_payer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestPayer { get; set; }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    [TerraformProperty("start_after")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartAfter { get; set; }

    /// <summary>
    /// The common_prefixes attribute.
    /// </summary>
    [TerraformProperty("common_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> CommonPrefixes { get; }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [TerraformProperty("keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Keys { get; }

    /// <summary>
    /// The owners attribute.
    /// </summary>
    [TerraformProperty("owners")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Owners { get; }

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    [TerraformProperty("request_charged")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RequestCharged { get; }

}

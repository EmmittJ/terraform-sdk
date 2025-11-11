using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_public_key resource.
/// </summary>
public partial class AwsCloudfrontPublicKey : TerraformResource
{
    public AwsCloudfrontPublicKey(string name) : base("aws_cloudfront_public_key", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The encoded_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncodedKey is required")]
    [TerraformProperty("encoded_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EncodedKey { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    [TerraformProperty("caller_reference")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CallerReference { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}

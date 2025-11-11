using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfront_function resource.
/// </summary>
public partial class AwsCloudfrontFunction : TerraformResource
{
    public AwsCloudfrontFunction(string name) : base("aws_cloudfront_function", name)
    {
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    [TerraformProperty("code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Code { get; set; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    [TerraformProperty("key_value_store_associations")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? KeyValueStoreAssociations { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The publish attribute.
    /// </summary>
    [TerraformProperty("publish")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Publish { get; set; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    [TerraformProperty("runtime")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Runtime { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The live_stage_etag attribute.
    /// </summary>
    [TerraformProperty("live_stage_etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LiveStageEtag { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}

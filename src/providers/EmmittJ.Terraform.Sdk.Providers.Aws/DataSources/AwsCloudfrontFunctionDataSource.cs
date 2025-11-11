using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_function.
/// </summary>
public partial class AwsCloudfrontFunctionDataSource : TerraformDataSource
{
    public AwsCloudfrontFunctionDataSource(string name) : base("aws_cloudfront_function", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [TerraformProperty("stage")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Stage { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The code attribute.
    /// </summary>
    [TerraformProperty("code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Code { get; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Comment { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The key_value_store_associations attribute.
    /// </summary>
    [TerraformProperty("key_value_store_associations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> KeyValueStoreAssociations { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTime { get; }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    [TerraformProperty("runtime")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Runtime { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_distribution.
/// </summary>
public partial class AwsCloudfrontDistributionDataSource : TerraformDataSource
{
    public AwsCloudfrontDistributionDataSource(string name) : base("aws_cloudfront_distribution", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformProperty("aliases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Aliases { get; }

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    [TerraformProperty("anycast_ip_list_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AnycastIpListId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostedZoneId { get; }

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    [TerraformProperty("in_progress_validation_batches")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> InProgressValidationBatches { get; }

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTime { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    [TerraformProperty("web_acl_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WebAclId { get; }

}

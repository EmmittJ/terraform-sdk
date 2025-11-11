using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_distribution.
/// </summary>
public class AwsCloudfrontDistributionDataSource : TerraformDataSource
{
    public AwsCloudfrontDistributionDataSource(string name) : base("aws_cloudfront_distribution", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    [TerraformPropertyName("aliases")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Aliases => new TerraformReference(this, "aliases");

    /// <summary>
    /// The anycast_ip_list_id attribute.
    /// </summary>
    [TerraformPropertyName("anycast_ip_list_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AnycastIpListId => new TerraformReference(this, "anycast_ip_list_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostedZoneId => new TerraformReference(this, "hosted_zone_id");

    /// <summary>
    /// The in_progress_validation_batches attribute.
    /// </summary>
    [TerraformPropertyName("in_progress_validation_batches")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> InProgressValidationBatches => new TerraformReference(this, "in_progress_validation_batches");

    /// <summary>
    /// The last_modified_time attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedTime => new TerraformReference(this, "last_modified_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The web_acl_id attribute.
    /// </summary>
    [TerraformPropertyName("web_acl_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebAclId => new TerraformReference(this, "web_acl_id");

}

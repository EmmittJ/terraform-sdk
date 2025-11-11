using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_cache_policy.
/// </summary>
public partial class AwsCloudfrontCachePolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontCachePolicyDataSource(string name) : base("aws_cloudfront_cache_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Comment { get; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DefaultTtl { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaxTtl { get; }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformProperty("min_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MinTtl { get; }

    /// <summary>
    /// The parameters_in_cache_key_and_forwarded_to_origin attribute.
    /// </summary>
    [TerraformProperty("parameters_in_cache_key_and_forwarded_to_origin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ParametersInCacheKeyAndForwardedToOrigin { get; }

}

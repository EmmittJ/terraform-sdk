using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_cache_policy.
/// </summary>
public class AwsCloudfrontCachePolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontCachePolicyDataSource(string name) : base("aws_cloudfront_cache_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Comment => new TerraformReference(this, "comment");

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultTtl => new TerraformReference(this, "default_ttl");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxTtl => new TerraformReference(this, "max_ttl");

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinTtl => new TerraformReference(this, "min_ttl");

    /// <summary>
    /// The parameters_in_cache_key_and_forwarded_to_origin attribute.
    /// </summary>
    [TerraformPropertyName("parameters_in_cache_key_and_forwarded_to_origin")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ParametersInCacheKeyAndForwardedToOrigin => new TerraformReference(this, "parameters_in_cache_key_and_forwarded_to_origin");

}

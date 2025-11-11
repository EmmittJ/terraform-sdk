using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_request_policy.
/// </summary>
public class AwsCloudfrontOriginRequestPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginRequestPolicyDataSource(string name) : base("aws_cloudfront_origin_request_policy", name)
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
    /// The cookies_config attribute.
    /// </summary>
    [TerraformPropertyName("cookies_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CookiesConfig => new TerraformReference(this, "cookies_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    [TerraformPropertyName("headers_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> HeadersConfig => new TerraformReference(this, "headers_config");

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    [TerraformPropertyName("query_strings_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> QueryStringsConfig => new TerraformReference(this, "query_strings_config");

}

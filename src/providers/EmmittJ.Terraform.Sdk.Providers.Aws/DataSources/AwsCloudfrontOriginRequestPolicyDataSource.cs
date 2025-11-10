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
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Comment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "comment");

    /// <summary>
    /// The cookies_config attribute.
    /// </summary>
    [TerraformPropertyName("cookies_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CookiesConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cookies_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    [TerraformPropertyName("headers_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HeadersConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "headers_config");

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    [TerraformPropertyName("query_strings_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> QueryStringsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "query_strings_config");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_origin_request_policy.
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontOriginRequestPolicyDataSource(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Comment { get; }

    /// <summary>
    /// The cookies_config attribute.
    /// </summary>
    [TerraformProperty("cookies_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CookiesConfig { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The headers_config attribute.
    /// </summary>
    [TerraformProperty("headers_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HeadersConfig { get; }

    /// <summary>
    /// The query_strings_config attribute.
    /// </summary>
    [TerraformProperty("query_strings_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> QueryStringsConfig { get; }

}

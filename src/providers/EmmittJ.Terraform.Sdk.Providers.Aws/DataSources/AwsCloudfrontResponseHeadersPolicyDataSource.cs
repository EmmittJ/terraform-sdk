using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_response_headers_policy.
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontResponseHeadersPolicyDataSource(string name) : base("aws_cloudfront_response_headers_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

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
    /// The cors_config attribute.
    /// </summary>
    [TerraformPropertyName("cors_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CorsConfig => new TerraformReference(this, "cors_config");

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("custom_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomHeadersConfig => new TerraformReference(this, "custom_headers_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("remove_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RemoveHeadersConfig => new TerraformReference(this, "remove_headers_config");

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("security_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecurityHeadersConfig => new TerraformReference(this, "security_headers_config");

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("server_timing_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServerTimingHeadersConfig => new TerraformReference(this, "server_timing_headers_config");

}

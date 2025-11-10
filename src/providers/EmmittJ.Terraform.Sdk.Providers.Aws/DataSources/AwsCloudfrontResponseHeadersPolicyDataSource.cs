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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The cors_config attribute.
    /// </summary>
    [TerraformPropertyName("cors_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CorsConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cors_config");

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("custom_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomHeadersConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_headers_config");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("remove_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RemoveHeadersConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "remove_headers_config");

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("security_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecurityHeadersConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "security_headers_config");

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    [TerraformPropertyName("server_timing_headers_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServerTimingHeadersConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "server_timing_headers_config");

}

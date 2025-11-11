using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_response_headers_policy.
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyDataSource : TerraformDataSource
{
    public AwsCloudfrontResponseHeadersPolicyDataSource(string name) : base("aws_cloudfront_response_headers_policy", name)
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
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

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
    /// The cors_config attribute.
    /// </summary>
    [TerraformProperty("cors_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CorsConfig { get; }

    /// <summary>
    /// The custom_headers_config attribute.
    /// </summary>
    [TerraformProperty("custom_headers_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CustomHeadersConfig { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The remove_headers_config attribute.
    /// </summary>
    [TerraformProperty("remove_headers_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RemoveHeadersConfig { get; }

    /// <summary>
    /// The security_headers_config attribute.
    /// </summary>
    [TerraformProperty("security_headers_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SecurityHeadersConfig { get; }

    /// <summary>
    /// The server_timing_headers_config attribute.
    /// </summary>
    [TerraformProperty("server_timing_headers_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServerTimingHeadersConfig { get; }

}

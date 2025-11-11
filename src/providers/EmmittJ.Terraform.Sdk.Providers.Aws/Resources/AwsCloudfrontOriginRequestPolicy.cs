using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookies_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyCookiesConfigBlock
{
    /// <summary>
    /// The cookie_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBehavior is required")]
    [TerraformPropertyName("cookie_behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CookieBehavior { get; set; }

}

/// <summary>
/// Block type for headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyHeadersConfigBlock
{
    /// <summary>
    /// The header_behavior attribute.
    /// </summary>
    [TerraformPropertyName("header_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HeaderBehavior { get; set; }

}

/// <summary>
/// Block type for query_strings_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock
{
    /// <summary>
    /// The query_string_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringBehavior is required")]
    [TerraformPropertyName("query_string_behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueryStringBehavior { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_origin_request_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontOriginRequestPolicy : TerraformResource
{
    public AwsCloudfrontOriginRequestPolicy(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for cookies_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookiesConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    [TerraformPropertyName("cookies_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>>? CookiesConfig { get; set; }

    /// <summary>
    /// Block for headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadersConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    [TerraformPropertyName("headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>>? HeadersConfig { get; set; }

    /// <summary>
    /// Block for query_strings_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    [TerraformPropertyName("query_strings_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>>? QueryStringsConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cookies_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicyCookiesConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The cookie_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookieBehavior is required")]
    [TerraformProperty("cookie_behavior")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CookieBehavior { get; set; }

}

/// <summary>
/// Block type for headers_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicyHeadersConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The header_behavior attribute.
    /// </summary>
    [TerraformProperty("header_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HeaderBehavior { get; set; }

}

/// <summary>
/// Block type for query_strings_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The query_string_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringBehavior is required")]
    [TerraformProperty("query_string_behavior")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryStringBehavior { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_origin_request_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontOriginRequestPolicy : TerraformResource
{
    public AwsCloudfrontOriginRequestPolicy(string name) : base("aws_cloudfront_origin_request_policy", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for cookies_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CookiesConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CookiesConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CookiesConfig block(s) allowed")]
    [TerraformProperty("cookies_config")]
    public partial TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyCookiesConfigBlock>>? CookiesConfig { get; set; }

    /// <summary>
    /// Block for headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HeadersConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HeadersConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeadersConfig block(s) allowed")]
    [TerraformProperty("headers_config")]
    public partial TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyHeadersConfigBlock>>? HeadersConfig { get; set; }

    /// <summary>
    /// Block for query_strings_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryStringsConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryStringsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryStringsConfig block(s) allowed")]
    [TerraformProperty("query_strings_config")]
    public partial TerraformList<TerraformBlock<AwsCloudfrontOriginRequestPolicyQueryStringsConfigBlock>>? QueryStringsConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}

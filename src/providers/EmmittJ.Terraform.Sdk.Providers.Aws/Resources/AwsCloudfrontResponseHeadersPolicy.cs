using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlock
{
    /// <summary>
    /// The access_control_allow_credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowCredentials is required")]
    [TerraformPropertyName("access_control_allow_credentials")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AccessControlAllowCredentials { get; set; }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    [TerraformPropertyName("access_control_max_age_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AccessControlMaxAgeSec { get; set; }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    [TerraformPropertyName("origin_override")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> OriginOverride { get; set; }

}

/// <summary>
/// Block type for custom_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock
{
}

/// <summary>
/// Block type for remove_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock
{
}

/// <summary>
/// Block type for security_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock
{
}

/// <summary>
/// Block type for server_timing_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    [TerraformPropertyName("sampling_rate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> SamplingRate { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_response_headers_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontResponseHeadersPolicy : TerraformResource
{
    public AwsCloudfrontResponseHeadersPolicy(string name) : base("aws_cloudfront_response_headers_policy", name)
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
    /// Block for cors_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    [TerraformPropertyName("cors_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>>? CorsConfig { get; set; }

    /// <summary>
    /// Block for custom_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    [TerraformPropertyName("custom_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>>? CustomHeadersConfig { get; set; }

    /// <summary>
    /// Block for remove_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    [TerraformPropertyName("remove_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>>? RemoveHeadersConfig { get; set; }

    /// <summary>
    /// Block for security_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    [TerraformPropertyName("security_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>>? SecurityHeadersConfig { get; set; }

    /// <summary>
    /// Block for server_timing_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    [TerraformPropertyName("server_timing_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>>? ServerTimingHeadersConfig { get; set; }

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

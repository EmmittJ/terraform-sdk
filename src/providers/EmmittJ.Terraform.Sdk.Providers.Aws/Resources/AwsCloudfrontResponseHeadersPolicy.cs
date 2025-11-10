using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCorsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The access_control_allow_credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowCredentials is required")]
    [TerraformPropertyName("access_control_allow_credentials")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> AccessControlAllowCredentials { get; set; }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    [TerraformPropertyName("access_control_max_age_sec")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AccessControlMaxAgeSec { get; set; }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    [TerraformPropertyName("origin_override")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> OriginOverride { get; set; }

}

/// <summary>
/// Block type for custom_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for remove_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for security_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for server_timing_headers_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    [TerraformPropertyName("sampling_rate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SamplingRate { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for cors_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    [TerraformPropertyName("cors_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock>>? CorsConfig { get; set; } = new();

    /// <summary>
    /// Block for custom_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    [TerraformPropertyName("custom_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock>>? CustomHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for remove_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    [TerraformPropertyName("remove_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock>>? RemoveHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for security_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    [TerraformPropertyName("security_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock>>? SecurityHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for server_timing_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    [TerraformPropertyName("server_timing_headers_config")]
    public TerraformList<TerraformBlock<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock>>? ServerTimingHeadersConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

}

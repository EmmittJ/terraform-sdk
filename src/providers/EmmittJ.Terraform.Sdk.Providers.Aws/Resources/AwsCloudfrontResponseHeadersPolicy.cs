using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cors_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyCorsConfigBlock() : TerraformBlock("cors_config")
{
    /// <summary>
    /// The access_control_allow_credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessControlAllowCredentials is required")]
    [TerraformProperty("access_control_allow_credentials")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AccessControlAllowCredentials { get; set; }

    /// <summary>
    /// The access_control_max_age_sec attribute.
    /// </summary>
    [TerraformProperty("access_control_max_age_sec")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AccessControlMaxAgeSec { get; set; }

    /// <summary>
    /// The origin_override attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OriginOverride is required")]
    [TerraformProperty("origin_override")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> OriginOverride { get; set; }

}

/// <summary>
/// Block type for custom_headers_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock() : TerraformBlock("custom_headers_config")
{
}

/// <summary>
/// Block type for remove_headers_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock() : TerraformBlock("remove_headers_config")
{
}

/// <summary>
/// Block type for security_headers_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock() : TerraformBlock("security_headers_config")
{
}

/// <summary>
/// Block type for server_timing_headers_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock() : TerraformBlock("server_timing_headers_config")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRate is required")]
    [TerraformProperty("sampling_rate")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SamplingRate { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_response_headers_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontResponseHeadersPolicy : TerraformResource
{
    public AwsCloudfrontResponseHeadersPolicy(string name) : base("aws_cloudfront_response_headers_policy", name)
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
    /// Block for cors_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfig block(s) allowed")]
    [TerraformProperty("cors_config")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyCorsConfigBlock> CorsConfig { get; set; } = new();

    /// <summary>
    /// Block for custom_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomHeadersConfig block(s) allowed")]
    [TerraformProperty("custom_headers_config")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyCustomHeadersConfigBlock> CustomHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for remove_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoveHeadersConfig block(s) allowed")]
    [TerraformProperty("remove_headers_config")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyRemoveHeadersConfigBlock> RemoveHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for security_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityHeadersConfig block(s) allowed")]
    [TerraformProperty("security_headers_config")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicySecurityHeadersConfigBlock> SecurityHeadersConfig { get; set; } = new();

    /// <summary>
    /// Block for server_timing_headers_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerTimingHeadersConfig block(s) allowed")]
    [TerraformProperty("server_timing_headers_config")]
    public TerraformList<AwsCloudfrontResponseHeadersPolicyServerTimingHeadersConfigBlock> ServerTimingHeadersConfig { get; set; } = new();

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

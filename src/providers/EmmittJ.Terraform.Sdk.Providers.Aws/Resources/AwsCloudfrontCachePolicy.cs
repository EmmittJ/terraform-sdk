using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters_in_cache_key_and_forwarded_to_origin in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock : TerraformBlockBase
{
    /// <summary>
    /// The enable_accept_encoding_brotli attribute.
    /// </summary>
    [TerraformProperty("enable_accept_encoding_brotli")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>
    /// The enable_accept_encoding_gzip attribute.
    /// </summary>
    [TerraformProperty("enable_accept_encoding_gzip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableAcceptEncodingGzip { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_cache_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudfrontCachePolicy : TerraformResource
{
    public AwsCloudfrontCachePolicy(string name) : base("aws_cloudfront_cache_policy", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformProperty("comment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Comment { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxTtl { get; set; }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformProperty("min_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinTtl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for parameters_in_cache_key_and_forwarded_to_origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParametersInCacheKeyAndForwardedToOrigin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ParametersInCacheKeyAndForwardedToOrigin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParametersInCacheKeyAndForwardedToOrigin block(s) allowed")]
    [TerraformProperty("parameters_in_cache_key_and_forwarded_to_origin")]
    public partial TerraformList<TerraformBlock<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>>? ParametersInCacheKeyAndForwardedToOrigin { get; set; }

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

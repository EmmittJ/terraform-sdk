using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for parameters_in_cache_key_and_forwarded_to_origin in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock : ITerraformBlock
{
    /// <summary>
    /// The enable_accept_encoding_brotli attribute.
    /// </summary>
    [TerraformPropertyName("enable_accept_encoding_brotli")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAcceptEncodingBrotli { get; set; }

    /// <summary>
    /// The enable_accept_encoding_gzip attribute.
    /// </summary>
    [TerraformPropertyName("enable_accept_encoding_gzip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAcceptEncodingGzip { get; set; }

}

/// <summary>
/// Manages a aws_cloudfront_cache_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontCachePolicy : TerraformResource
{
    public AwsCloudfrontCachePolicy(string name) : base("aws_cloudfront_cache_policy", name)
    {
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    [TerraformPropertyName("comment")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Comment { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DefaultTtl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_ttl attribute.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxTtl { get; set; }

    /// <summary>
    /// The min_ttl attribute.
    /// </summary>
    [TerraformPropertyName("min_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinTtl { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for parameters_in_cache_key_and_forwarded_to_origin.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParametersInCacheKeyAndForwardedToOrigin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ParametersInCacheKeyAndForwardedToOrigin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParametersInCacheKeyAndForwardedToOrigin block(s) allowed")]
    [TerraformPropertyName("parameters_in_cache_key_and_forwarded_to_origin")]
    public TerraformList<TerraformBlock<AwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginBlock>>? ParametersInCacheKeyAndForwardedToOrigin { get; set; } = new();

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

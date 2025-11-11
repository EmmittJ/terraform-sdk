using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cdn_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketCdnPolicyBlock
{
    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: [&amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;CACHE_ALL_STATIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("cache_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CacheMode { get; set; } = default!;

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformPropertyName("client_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ClientTtl { get; set; } = default!;

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age). When the &#39;cache_mode&#39;
    /// is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DefaultTtl { get; set; } = default!;

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformPropertyName("max_ttl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxTtl { get; set; } = default!;

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    [TerraformPropertyName("negative_caching")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> NegativeCaching { get; set; } = default!;

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.
    /// </summary>
    [TerraformPropertyName("request_coalescing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequestCoalescing { get; set; }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    [TerraformPropertyName("serve_while_stale")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ServeWhileStale { get; set; } = default!;

    /// <summary>
    /// Maximum number of seconds the response to a signed URL request will
    /// be considered fresh. After this time period,
    /// the response will be revalidated before being served.
    /// When serving responses to signed URL requests,
    /// Cloud CDN will internally behave as though
    /// all responses from this backend had a &amp;quot;Cache-Control: public,
    /// max-age=[TTL]&amp;quot; header, regardless of any existing Cache-Control
    /// header. The actual headers served in responses will not be altered.
    /// </summary>
    [TerraformPropertyName("signed_url_cache_max_age_sec")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SignedUrlCacheMaxAgeSec { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeBackendBucketParamsBlock
{
    /// <summary>
    /// Resource manager tags to be bound to the backend bucket. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformPropertyName("resource_manager_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeBackendBucketTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_backend_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeBackendBucket : TerraformResource
{
    public GoogleComputeBackendBucket(string name) : base("google_compute_backend_bucket", name)
    {
    }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("compression_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CompressionMode { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    [TerraformPropertyName("custom_response_headers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? CustomResponseHeaders { get; set; }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    [TerraformPropertyName("edge_security_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EdgeSecurityPolicy { get; set; }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    [TerraformPropertyName("enable_cdn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableCdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("load_balancing_scheme")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancingScheme { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035.  Specifically, the name must be 1-63 characters long and
    /// match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means
    /// the first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the
    /// last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for cdn_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    [TerraformPropertyName("cdn_policy")]
    public TerraformList<TerraformBlock<GoogleComputeBackendBucketCdnPolicyBlock>>? CdnPolicy { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformPropertyName("params")]
    public TerraformList<TerraformBlock<GoogleComputeBackendBucketParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeBackendBucketTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cdn_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeBackendBucketCdnPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the cache setting for all responses from this backend.
    /// The possible values are: USE_ORIGIN_HEADERS, FORCE_CACHE_ALL and CACHE_ALL_STATIC Possible values: [&amp;quot;USE_ORIGIN_HEADERS&amp;quot;, &amp;quot;FORCE_CACHE_ALL&amp;quot;, &amp;quot;CACHE_ALL_STATIC&amp;quot;]
    /// </summary>
    [TerraformProperty("cache_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CacheMode { get; set; }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformProperty("client_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ClientTtl { get; set; }

    /// <summary>
    /// Specifies the default TTL for cached content served by this origin for responses
    /// that do not have an existing valid TTL (max-age or s-max-age). When the &#39;cache_mode&#39;
    /// is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DefaultTtl { get; set; }

    /// <summary>
    /// Specifies the maximum allowed TTL for cached content served by this origin. When the
    /// &#39;cache_mode&#39; is set to &amp;quot;USE_ORIGIN_HEADERS&amp;quot;, you must omit this field.
    /// </summary>
    [TerraformProperty("max_ttl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxTtl { get; set; }

    /// <summary>
    /// Negative caching allows per-status code TTLs to be set, in order to apply fine-grained caching for common errors or redirects.
    /// </summary>
    [TerraformProperty("negative_caching")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> NegativeCaching { get; set; }

    /// <summary>
    /// If true then Cloud CDN will combine multiple concurrent cache fill requests into a small number of requests to the origin.
    /// </summary>
    [TerraformProperty("request_coalescing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequestCoalescing { get; set; }

    /// <summary>
    /// Serve existing content from the cache (if available) when revalidating content with the origin, or when an error is encountered when refreshing the cache.
    /// </summary>
    [TerraformProperty("serve_while_stale")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ServeWhileStale { get; set; }

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
    [TerraformProperty("signed_url_cache_max_age_sec")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SignedUrlCacheMaxAgeSec { get; set; }

}

/// <summary>
/// Block type for params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeBackendBucketParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// Resource manager tags to be bound to the backend bucket. Tag keys and values have the
    /// same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456.
    /// </summary>
    [TerraformProperty("resource_manager_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ResourceManagerTags { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeBackendBucketTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_backend_bucket resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeBackendBucket : TerraformResource
{
    public GoogleComputeBackendBucket(string name) : base("google_compute_backend_bucket", name)
    {
    }

    /// <summary>
    /// Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// Compress text responses using Brotli or gzip compression, based on the client&#39;s Accept-Encoding header. Possible values: [&amp;quot;AUTOMATIC&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("compression_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CompressionMode { get; set; }

    /// <summary>
    /// Headers that the HTTP/S load balancer should add to proxied responses.
    /// </summary>
    [TerraformProperty("custom_response_headers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? CustomResponseHeaders { get; set; }

    /// <summary>
    /// An optional textual description of the resource; provided by the
    /// client when the resource is created.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The security policy associated with this backend bucket.
    /// </summary>
    [TerraformProperty("edge_security_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EdgeSecurityPolicy { get; set; }

    /// <summary>
    /// If true, enable Cloud CDN for this BackendBucket.
    /// Note: This cannot be set to true when loadBalancingScheme is set to INTERNAL_MANAGED.
    /// </summary>
    [TerraformProperty("enable_cdn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableCdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The value can only be INTERNAL_MANAGED for cross-region internal layer 7 load balancer.
    /// If loadBalancingScheme is not specified, the backend bucket can be used by classic global external load balancers, or global application external load balancers, or both.
    /// Important: CDN cannot be enabled (enableCdn cannot be set to true) when loadBalancingScheme is set to INTERNAL_MANAGED. Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;]
    /// </summary>
    [TerraformProperty("load_balancing_scheme")]
    // Optional argument - source generator will implement get/set
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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for cdn_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnPolicy block(s) allowed")]
    [TerraformProperty("cdn_policy")]
    public TerraformList<TerraformBlock<GoogleComputeBackendBucketCdnPolicyBlock>>? CdnPolicy { get; set; }

    /// <summary>
    /// Block for params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Params block(s) allowed")]
    [TerraformProperty("params")]
    public TerraformList<TerraformBlock<GoogleComputeBackendBucketParamsBlock>>? Params { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeBackendBucketTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

}
